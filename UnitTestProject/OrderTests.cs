using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace UnitTestProject
{
    // Класс тестов для формы заказов.
    [TestClass]
    public class TestOrder
    {
        // Тест на проверку корректности получения списка марок автомобилей.
        [TestMethod]
        public void TestOrder_Brand_List()
        {
            List<string> result;
            List<string> test = new List<string> { "BMW", "Mercedes-Benz", "Porsche", "Lamborghini", "Audi" };
            ClassLibrary.Order Order = new ClassLibrary.Order();
            result = Order.Brand();

            CollectionAssert.AreEqual(test, result);
        }

        // Тест на проверку корректности получения списка моделей автомобилей.
        [TestMethod]
        public void TestOrder_Model_List()
        {
            List<string> result;
            List<string> test = new List<string> { "M3", "M5" };
            ClassLibrary.Order Order = new ClassLibrary.Order();
            result = Order.Model("BMW");

            CollectionAssert.AreEqual(test, result);
        }

        // Тест на проверку корректности получения списка цветов кузова.
        [TestMethod]
        public void TestOrder_Color_List()
        {
            List<string> result;
            List<string> test = new List<string> { "Белый", "Чёрный", "Красный", "Жёлтый", "Зелёный", "Синий", "Серый" };
            ClassLibrary.Order Order = new ClassLibrary.Order();
            result = Order.Color();

            CollectionAssert.AreEqual(test, result);
        }

        // Тест на проверку корректности получения списка цветов салона.
        [TestMethod]
        public void TestOrder_ColorInterior_List()
        {
            List<string> result;
            List<string> test = new List<string> { "Белый", "Чёрный", "Красный", "Жёлтый", "Зелёный", "Синий", "Серый" };
            ClassLibrary.Order Order = new ClassLibrary.Order();
            result = Order.ColorInterior();

            CollectionAssert.AreEqual(test, result);
        }
    }
}
