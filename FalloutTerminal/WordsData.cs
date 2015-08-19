using System.Collections.Generic;
using System.Linq;

namespace FalloutTerminal {
    class WordsData {
        private Dictionary<string, Dictionary<string, int>> similarities;

        public IEnumerable<string> Words {
            get {
                return similarities.Keys;
            }
        }

        public static int countSimilarities(string s1, string s2) {
            return s1.Zip(s2, (x, y) => x == y ? 1 : 0).Sum();
        }

        // Simple greedy algorithm: guess the word that lets you differentiate between the
        // greatest number of remaining candidate words.
        public string getNextGuess(IEnumerable<string> candidates) {
            var variety = new Dictionary<string, int>();

            if (similarities.Count() == 0 || candidates.Count() == 0) {
                return "";
            } else if (candidates.Count() == 1) {
                // No point reducing candidates: we're done!
                return candidates.First();
            }

            foreach (var k in similarities.Keys) {
                int[] similarityValues = new int[k.Length+1];
                foreach (var v in candidates) {
                    int n = countSimilarities(k, v);
                    similarityValues[n] = 1;
                }
                variety.Add(k, similarityValues.Sum());
            }

            return variety.OrderByDescending(kv => kv.Value).First().Key;
        }

        // `words` should be contains words all the same length.
        public WordsData(IEnumerable<string> words) {
            int wordlength = words.FirstOrDefault().Length;
            similarities = new Dictionary<string, Dictionary<string, int>>(words.Count());
            foreach (string s in words) {
                similarities.Add(s, new Dictionary<string,int>(words.Count()));
                foreach (string t in words) {
                    int n = countSimilarities(s, t);
                    similarities[s][t] = n;
                }
            }
        }
    }
}
