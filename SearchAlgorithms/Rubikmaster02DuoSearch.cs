using System.Collections.Generic;

namespace SearchAlgorithms
{
    public static class Rubikmaster02
    {
        public static int[] RmMultiDuoSearch<T>(this IReadOnlyList<T> input, IReadOnlyList<T> match)
        {
            List<int> matchLocations = new List<int>();
            int       inputLength    = input.Count - 1;
            int       matchLength    = match.Count - 1;

            for (int i = 0; i < inputLength; i++)
            {
                if (i + matchLength > inputLength)
                {
                    break;
                }

                if (!input[i].Equals(match[0]) || !input[i + matchLength].Equals(match[matchLength]))
                {
                    continue;
                }

                int k = 0;
                for (; k < matchLength - 1; k++)
                {
                    if (!input[k + i + 1].Equals(match[k + 1]))
                    {
                        break;
                    }
                }

                if (k == matchLength - 1)
                {
                    matchLocations.Add(i);
                }
            }

            return matchLocations.Count > 0 ? matchLocations.ToArray() : new[] {-1};
        }

        public static int RmSingleDuoSearch<T>(this IReadOnlyList<T> input, IReadOnlyList<T> match)
        {
            int inputLength = input.Count - 1;
            int matchLength = match.Count - 1;

            for (int i = 0; i < inputLength; i++)
            {
                if (i + matchLength > inputLength)
                {
                    break;
                }

                if (!input[i].Equals(match[0]) || !input[i + matchLength].Equals(match[matchLength]))
                {
                    continue;
                }

                int k = 0;
                for (; k < matchLength - 1; k++)
                {
                    if (!input[k + i + 1].Equals(match[k + 1]))
                    {
                        break;
                    }
                }

                if (k == matchLength - 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}