using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BlankEntry()
        {
            string result = Anagrama_y_Test.Program.SortWords("");
            Assert.AreEqual("Llene todos los espacios", result);
        }
                
        [TestMethod]
        public void IsAnagramTrue()
        {
            bool result = Anagrama_y_Test.Program.IsAnagram("hola","aloh");
            Assert.AreEqual(true, result);
        }        
        [TestMethod]
        public void IsAnagramFalse()
        {
            bool result = Anagrama_y_Test.Program.IsAnagram("hola","afdfe");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void SortTest()
        {
            string result = Anagrama_y_Test.Program.SortWords("hola");
            Assert.AreEqual("ahlo", result);
        }
    }
}
