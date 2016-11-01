using NUnit.Framework;
using CityChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityChain
{
    [TestFixture]
    public class TestsForCityChainClass
    {
        CityChain cityChain;
        [SetUp]
        public void SetUp()
        {
            cityChain = new CityChain();
        }

        [Test]
        public void TestCityChain()
        {
            string[,] cities = new string[5, 2] { { "Bern", "Berlin" }, { "Paris", "New York" }, { "Moscow", "Paris" }, { "New York", "Madrid" }, { "Madrid", "Bern" } };
            Dictionary<string, string> res = cityChain.CreateChain(cities);
            var sb = new StringBuilder();
            foreach (KeyValuePair<string, string> pair in res)
            {
                sb.AppendFormat("{0} {1};", pair.Key, pair.Value);
            }

            Assert.AreEqual(sb.ToString(), "Moscow Paris;Paris New York;New York Madrid;Madrid Bern;Bern Berlin;");
        }
    }
}
