using Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Metaphone_Algorithm_Tests
{
    [TestClass]
    public class PhoneticTests
    {
        [TestMethod]
        public void solitude() => Assert.AreEqual("SLTT", MetaphoneAlgorithm.toPhonetic("solitude"));
        [TestMethod]
        public void debunker() => Assert.AreEqual("TBNKR", MetaphoneAlgorithm.toPhonetic("debunker"));
        [TestMethod]
        public void aardvark() => Assert.AreEqual("ARTFRK", MetaphoneAlgorithm.toPhonetic("aardvark"));
        [TestMethod]
        public void cutlass() => Assert.AreEqual("KTLSS", MetaphoneAlgorithm.toPhonetic("cutlass"));
        [TestMethod]
        public void metaphone() => Assert.AreEqual("MTFN", MetaphoneAlgorithm.toPhonetic("metaphone"));
        [TestMethod]
        public void kiss() => Assert.AreEqual("KSS", MetaphoneAlgorithm.toPhonetic("kiss"));
        [TestMethod]
        public void roosevelt() => Assert.AreEqual("RSFLT", MetaphoneAlgorithm.toPhonetic("roosevelt"));
        [TestMethod]
        public void knock() => Assert.AreEqual("NK", MetaphoneAlgorithm.toPhonetic("knock"));
        [TestMethod]
        public void xanadu() => Assert.AreEqual("SNT", MetaphoneAlgorithm.toPhonetic("xanadu"));
        [TestMethod]
        public void alleyway() => Assert.AreEqual("SNT", MetaphoneAlgorithm.toPhonetic("alleyway"));
        [TestMethod]
        public void raw() => Assert.AreEqual("SNT", MetaphoneAlgorithm.toPhonetic("raw"));
    }

}
