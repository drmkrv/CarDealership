using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace UnitTestProject
{
    // Класс тестов для формы регистрации
    [TestClass]
    public class TestReg
    {
        // Тест регистрации с существующим клиентом
        [TestMethod]
        public void TestReg_Client_Exist()
        {
            bool result;
            ClassLibrary.Reg Reg = new ClassLibrary.Reg();
            result = Reg.GetClientExistence("test1", "+79991111111", "1@test.ru");

            Assert.AreEqual(false, result);
        }
        // Тест регистрации нового пользователя
        [TestMethod]
        public void TestReg_Client_Not_Exist()
        {
            bool result;
            ClassLibrary.Reg Reg = new ClassLibrary.Reg();
            result = Reg.GetClientExistence("test3", "79993333333", "3@test.ru");

            Assert.AreEqual(true, result);
        }
    }
}
