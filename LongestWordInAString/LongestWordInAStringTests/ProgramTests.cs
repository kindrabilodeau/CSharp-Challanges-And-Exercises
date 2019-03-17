using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 
using 
namespace LongestWordInAStringTests
{
    [TestClass()]
    public class LongestWord
    {
        [TestMethod()]
        public void MaxStringTest()
        {
            LongestWord longest = new LongestWord();
            string test = longest.MaxString();
            Assert.AreEqual(test); 
        }
    }
}