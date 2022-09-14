using NUnit.Framework;
using CNC_Algos_Test;
using System;
namespace TestProject1
{
    public class Tests
    {
        Conversion conv = null;
        [SetUp]
        public void Setup()
        {
            conv = new Conversion();
        }

        [Test]
        public void ConvertInch2mm_InputisInch_ReturnsFalse()
        {
            var result = conv.In2mm(1.25);

            Assert.GreaterOrEqual(result, 0.001);
            //Assert.Throws<System.NotImplementedException>(() => conv.In2mm(1.25));
        }

        [Test]
        public void ConvertmmToinch_Inputismm_ChecksEquality()
        {
            double res = conv.mm2In(1.25);

            Assert.AreEqual(0.049125, res);
            //Assert.Throws<System.NotImplementedException>(() => conv.mm2In(1.25));
        }
    }
}