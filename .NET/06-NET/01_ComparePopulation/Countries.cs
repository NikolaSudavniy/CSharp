using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparePopulation
{
    namespace Country
    {
        class Capital
        {
            public string Name { get; set; }
            public int Population { get; set; }
        }

        class CountryA
        {
            public Capital Capital { get; set; }
        }

        class CountryB
        {
            public Capital Capital { get; set; }
        }

        class CountryC
        {
            public Capital Capital { get; set; }
        }

        class CapitalComparer : IComparer<Capital>
        {
            public int Compare(Capital x, Capital y)
            {
                return x.Population.CompareTo(y.Population);
            }
        }

        class CapitalComparisonResult
        {
            public string LargestCapital { get; set; }
            public string SmallestCapital { get; set; }
            public string MiddleCapital { get; set; }
        }

        static class CapitalComparator
        {
            public static CapitalComparisonResult CompareCapitals(IEnumerable<Capital> capitals)
            {
                var sortedCapitals = capitals.OrderBy(c => c.Population).ToList();
                var middleIndex = sortedCapitals.Count / 2;
                var middleCapital = sortedCapitals[middleIndex];
                var largestCapital = sortedCapitals.Last();
                var smallestCapital = sortedCapitals.First();

                var comparisonResult = new CapitalComparisonResult
                {
                    LargestCapital = $"{largestCapital.Name} - {largestCapital.Population} чел.",
                    SmallestCapital = $"{smallestCapital.Name} - {smallestCapital.Population} чел.",
                    MiddleCapital = $"{middleCapital.Name} - {middleCapital.Population} чел."
                };

                return comparisonResult;
            }
        }

    }
}