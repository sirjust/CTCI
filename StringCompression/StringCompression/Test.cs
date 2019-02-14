using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompression
{
    [TestFixture]
    public class Test
    {
        Compress compress = new Compress();
        [Test]
        public void Test1()
        {
            Assert.AreEqual("a1b4c2", compress.CompressString("abbbbcc"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("a10", compress.CompressString("aaaaaaaaaa"));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual("a5b6", compress.CompressString("aaaaabbbbbb"));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual("a", compress.CompressString("a"));
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual("", compress.CompressString(""));
        }
    }
}
