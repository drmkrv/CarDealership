using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace UnitTestProject
{
    // Класс тестов для формы просмотра машин.
    [TestClass]
    public class TestCars
    {
        // Тест на проверку корректности получения марки автомобиля по его ID.
        [TestMethod]
        public void TestCars_GetBrand_BMW()
        {
            string result;
            ClassLibrary.Cars Cars = new ClassLibrary.Cars();
            result = Cars.GetBrand("1");

            Assert.AreEqual("BMW", result);
        }

        // Тест на проверку корректности получения модели автомобиля по его ID.
        [TestMethod]
        public void TestCars_GetModel_BMW_M5()
        {
            string result;
            ClassLibrary.Cars Cars = new ClassLibrary.Cars();
            result = Cars.GetModel("2");

            Assert.AreEqual("M5", result);
        }

        // Тест на проверку корректности получения цвета кузова по его ID.
        [TestMethod]
        public void TestCars_GetColor_Red()
        {
            string result;
            ClassLibrary.Cars Cars = new ClassLibrary.Cars();
            result = Cars.GetColor("3");

            Assert.AreEqual("Красный", result);
        }

        // Тест на проверку корректности получения цвета салона по его ID.
        [TestMethod]
        public void TestCars_GetColorInterior_Yellow()
        {
            string result;
            ClassLibrary.Cars Cars = new ClassLibrary.Cars();
            result = Cars.GetColorInterior("4");

            Assert.AreEqual("Жёлтый", result);
        }
    }
}
