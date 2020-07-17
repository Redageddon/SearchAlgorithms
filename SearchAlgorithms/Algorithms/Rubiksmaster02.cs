using System.Collections.Generic;

namespace SearchAlgorithms.Algorithms
{
    public class Rubiksmaster02 : ISearchAlgorithm
    {
        public List<int> MultiSearch<T>(IReadOnlyList<T> input, IReadOnlyList<T> match, int start, int count)
        {
            List<int> matchLocations = new List<int>();
            int       inputLength    = count > input.Count - 1 ? input.Count - 1 : count;
            int       matchLength    = match.Count - 1;

            if (inputLength == 0 || matchLength == 0 || matchLength > inputLength || count == 0)
            {
                matchLocations.Add(-1);
                return matchLocations;
            }
            
            for (int i = start; i < inputLength - matchLength + 1; i++)
            {
                if (!input[i].Equals(match[0]) || !input[i + matchLength].Equals(match[matchLength]))
                {
                    continue;
                }

                bool sequenceEqual = true;
                for (int k = 0; k < matchLength - 1; k++)
                {
                    if (!input[k + i + 1].Equals(match[k + 1]))
                    {
                        sequenceEqual = false;
                        break;
                    }
                }

                if (sequenceEqual)
                {
                    matchLocations.Add(i);
                }
                else
                {
                    i += matchLength;
                }
            }

            if (matchLocations.Count > 0)
            {
                return matchLocations;
            }

            matchLocations.Add(-1);
            return matchLocations;
        }

        public int SingleSearch<T>(IReadOnlyList<T> input, IReadOnlyList<T> match, int start, int count)
        {
            int inputLength = count > input.Count - 1 ? input.Count - 1 : count;
            int matchLength = match.Count - 1;
            
            if (inputLength == 0 || matchLength == 0 || matchLength > inputLength || count == 0)
            {
                return -1;
            }

            for (int i = start; i < inputLength - matchLength + 1; i++)
            {
                if (!input[i].Equals(match[0]) || !input[i + matchLength].Equals(match[matchLength]))
                {
                    continue;
                }

                bool naturalExit = true;
                for (int k = 0; k < matchLength - 1; k++)
                {
                    if (!input[k + i + 1].Equals(match[k + 1]))
                    {
                        naturalExit = false;
                        break;
                    }
                }

                if (naturalExit)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}