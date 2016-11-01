using System;
using System.Collections.Generic;

namespace CityChain
{
    public class CityChain
    {
        public Dictionary<string, string> CreateChain(string[,] cities)
        {
            Dictionary<string, string> firstCityKeyDict = new Dictionary<string, string>();
            Dictionary<string, string> secondCityKeyDict = new Dictionary<string, string>();
            Dictionary<string, string> res = new Dictionary<string, string>();

            for (int i = 0; i < cities.GetLength(0); i++)
            {
                firstCityKeyDict.Add(cities[i, 0], cities[i, 1]);
                secondCityKeyDict.Add(cities[i, 1], cities[i, 0]);
            }

            string nextElement = string.Empty;
            foreach (KeyValuePair<string, string> kvp in firstCityKeyDict)
            {
                if (!secondCityKeyDict.ContainsKey(kvp.Key))
                {
                    //find the first element
                    nextElement = kvp.Key;
                    break;
                }
            }

            while (firstCityKeyDict.ContainsKey(nextElement))
            {
                res.Add(nextElement, firstCityKeyDict[nextElement]);
                nextElement = firstCityKeyDict[nextElement];
            }

            return res;
        }
    }
}
