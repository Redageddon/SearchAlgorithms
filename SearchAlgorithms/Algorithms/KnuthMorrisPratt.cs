using System;
using System.Collections.Generic;

namespace SearchAlgorithms.Algorithms
{
    public class KnuthMorrisPratt : ISearchAlgorithm
    {
        public List<int> MultiSearch<T>(IReadOnlyList<T> input, IReadOnlyList<T> search, int start, int count)
        {
            List<int> matchLocations = new List<int>();
            int inputLength = count > input.Count - 1 ? input.Count - 1 : count;
            int       j              = 0;

            for (int i = start; i < inputLength;)
            {
                if (search[j].Equals(input[i]))
                {
                    j++;
                    i++;
                }

                if (j == search.Count)
                {
                    matchLocations.Add(i - j);
                    j = 0;
                }
                else if (i < inputLength && !search[j].Equals(input[i]))
                {
                    if (j != 0)
                    {
                        j = 0;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            if (matchLocations.Count > 0)
            {
                return matchLocations;
            }

            matchLocations.Add(-1);
            return matchLocations;
        }

        public int SingleSearch<T>(IReadOnlyList<T> input, IReadOnlyList<T> search, int start, int count)
        {
            int j = 0;
            int inputLength = count > input.Count - 1 ? input.Count - 1 : count;

            for (int i = start; i < inputLength;)
            {
                if (search[j].Equals(input[i]))
                {
                    j++;
                    i++;
                }

                if (j == search.Count)
                {
                    return i - j;
                }

                if (i < inputLength && !search[j].Equals(input[i]))
                {
                    if (j != 0)
                    {
                        j = 0;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            return -1;
        }
    }
}