using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetExtensions;

namespace DotNetExtensions.Test
{
    [TestClass]
    public class StringTest
    {

        [TestMethod]
        public void RemoveDiacritics()
        {
            string result = "Mendonça".RemoveDiacritics();
            Assert.AreEqual(result, "Mendonca");

            result = "áÉíöû".RemoveDiacritics();
            Assert.AreEqual(result, "aEiou");
        }


        [TestMethod]
        public void Slugify()
        {
            string result = "Felipe Mendonça Marques Silva".Slugify();
            Assert.AreEqual(result, "felipe-mendonca-marques-silva");

            result = "Tom & Jerry".Slugify();
            Assert.AreEqual(result, "tom-jerry");

            result = " Teste com  2  espacos ".Slugify();
            Assert.AreEqual(result, "teste-com-2-espacos");
        }
    }
}
