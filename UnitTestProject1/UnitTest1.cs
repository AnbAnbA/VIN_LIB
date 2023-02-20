using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VIN_LIB;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCheckVINCorrect()
        {
            Assert.IsTrue(Class1.CheckVIN("WMWRE33423TD08329"));
        }
        [TestMethod]
        public void TestMethodCheckVINNotCorrect()
        {
            Assert.IsFalse(Class1.CheckVIN("WMQRE33423TD08329"));
        }
        [TestMethod]
        public void CheckVINCorrectType()
        {
            string vin = "KFFCF52557C401113";
            Assert.IsInstanceOfType(Class1.CheckVIN(vin), vin.GetType());
        }
        [TestMethod]
        public void CheckVINNotCorrectType()
        {
            int vin = 234675648;
            Assert.IsNotInstanceOfType(Class1.CheckVIN("KFFCF52557C401113"), vin.GetType());
        }

        [TestMethod]
        public void GetVINCountryCorrect()
        {
            Assert.AreEqual("Азия", Class1.GetVINCountry("KDR346FYSHU677896"));
        }
        [TestMethod]
        public void GetVINCountryNotCorrect()
        {
            Assert.AreNotEqual("Южная Америка", Class1.GetVINCountry("TLFFJRI5678273657"));
        }
        [TestMethod]
        public void GetVINCountryCorrecType()
        {
            string vin = "TLFFJRI5678273657";
            Assert.IsInstanceOfType(Class1.GetVINCountry(vin), vin.GetType());
        }
        [TestMethod]
        public void GetVINCountryNotCorrecType()
        {
            int vin = 234675648;
            Assert.IsNotInstanceOfType(Class1.GetVINCountry("TLFFJRI5678273657"), vin.GetType());
        }
        [TestMethod]
        public void GetVINCountryCorrectNum()
        {
            Assert.AreEqual("Северная Америка", Class1.GetVINCountry("56JHMCM565C404453"));
        }
        [TestMethod]
        public void CheckVINCorrectOnlyNum()
        {
            Assert.IsTrue(Class1.CheckVIN("12345678919748929") == true);
        }
        [TestMethod]
        public void CheckVINEmptyParametr()
        {
            Assert.IsTrue(false == Class1.CheckVIN(""));
        }
        [TestMethod]
        public void GetVINCountryNullVIN()
        {
            Assert.AreEqual("", Class1.GetVINCountry(null));
        }
        [TestMethod]
        public void GetVINCountryEmptyVin()
        {
            Assert.IsNotNull(Class1.GetVINCountry(""));
        }
        [TestMethod]
        public void CheckVINCorrectLargeData()
        {
            string vin = "";
            for (int i = 0; i < 10000; i++)
            {
                vin += i;
            }
            Assert.IsFalse(Class1.CheckVIN(vin));
        }
        [TestMethod]
        public void GetVINCountryNotCorrectVIN()
        {
            Assert.IsTrue(Class1.GetVINCountry("OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO") == "");
        }
    }
}
