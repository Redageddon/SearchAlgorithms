using System.Collections.Generic;

namespace SearchAlgorithms
{
    public static class KnuthMorrisPratt
    {
        public static List<int> KmpMultiSearch<T>(this IReadOnlyList<T> input, IReadOnlyList<T> search)
        {
            List<int> matchLocations = new List<int>();
            int       j              = 0;

            for (int i = 0; i < input.Count;)
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
                else if (i < input.Count && !search[j].Equals(input[i]))
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

        public static int KmpSingleSearch<T>(this IReadOnlyList<T> input, IReadOnlyList<T> search)
        {
            int j = 0;

            for (int i = 0; i < input.Count;)
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

                if (i < input.Count && !search[j].Equals(input[i]))
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