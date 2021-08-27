using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PlainTextFileSearcher.Business
{
    public class SearchService
    {
        public List<string> folderPaths = new List<string>();
        public List<string> filePaths = new List<string>();

        public void IndexFolders(string startingPath)
        { 
            folderPaths.AddRange(FindFolders(startingPath));
            filePaths.AddRange(FindFiles(startingPath));
        }

        private string[] FindFolders(string path)
        {
            return System.IO.Directory.GetDirectories(path, "*", System.IO.SearchOption.AllDirectories); 
        }
        private string[] FindFiles(string path)
        {
            return System.IO.Directory.GetFiles(path, "*", System.IO.SearchOption.AllDirectories);
        }

        public async Task<List<Tuple<int, int>>> FindInAllFiles(string searchWord)
        {
            List<Tuple<int, int>> FindInAllFilesResultList = new List<Tuple<int, int>>();

            Parallel.For(0, filePaths.Count,
            index => 
            {
                List <Tuple<int, int>> r = FindInFile(filePaths[index], searchWord).Result;
                FindInAllFilesResultList.AddRange(r);
            });
            return FindInAllFilesResultList;
        }

        private async Task<List<Tuple<int, int>>> FindInFile(string pathToFile, string searchWord)
        {
            List<Tuple<int, int>> resultListTuple = new List<Tuple<int, int>>();
            string[] lines = System.IO.File.ReadAllLines(pathToFile);

            Parallel.For(0, lines.Length,
                   index => {
                       List<int> results = FindAllInString(lines[index], searchWord);
                       for (int r = 0; r < results.Count; r++)
                       {
                           resultListTuple.Add(new Tuple<int, int>(results[r], index));
                       }
                   });
            return resultListTuple;
        }

        private List<int> FindAllInString(string input, string searchWord)
        {
            List<int> results = new List<int>();
            int nextIndex = 0;


            while (nextIndex >= 0 && nextIndex + searchWord.Length <= input.Length)
            {
                nextIndex = NextIndexOf(input, searchWord, nextIndex);
                if (nextIndex >= 0)
                {
                    results.Add(nextIndex);
                    nextIndex += searchWord.Length;
                }
            }
            return results;
        }

        private int NextIndexOf(string input, string match, int startIndex)
        {
            if (startIndex == -1)
                return -1;
            var result = input.IndexOf(match, startIndex, match.Length, StringComparison.OrdinalIgnoreCase);
            return result;
        }
    }
}
