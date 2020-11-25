using System;
using System.Collections.Generic;
using System.Linq;

namespace Balloons
{
    public class Searcher
    {
        private readonly Dictionary<char, int> _baseTextLetterCounts;
            
        // constructor
        public Searcher(string baseText)
        {
            _baseTextLetterCounts = CountLetters(baseText);
        }

        public int Search(string searchText)
        {
            var searchTextLetterCounts = CountLetters(searchText);
            var results = new List<int>();
            foreach (var searchLetter in searchTextLetterCounts)
            {
                if (_baseTextLetterCounts.ContainsKey(searchLetter.Key))
                {
                    var baseCount = _baseTextLetterCounts[searchLetter.Key];
                    var searchCount = searchLetter.Value;
                    var result = baseCount / searchCount;
                    results.Add(result);
                }
                else
                {
                    return 0;
                }
            }
            return results.Min();
        }

        private Dictionary<char, int> CountLetters(string input)
        {
            var result = new Dictionary<char, int>();
            foreach (var letter in input)
            {
                if (result.ContainsKey(letter))
                {
                    result[letter]++;
                }
                else
                {
                    result.Add(letter, 1);
                }
            }
            return result;
        }
    }
}