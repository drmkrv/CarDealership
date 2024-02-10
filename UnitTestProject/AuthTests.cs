using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace UnitTestProject
{
    // Класс тестов для формы авторизации.
    [TestClass]
    public class TestAuth
    {
        // Тест с корректным вводом логина и пароля.
        [TestMethod]
        public void TestAuth_LogIn_IDClient_Is_One()
        {
            object ID;

            ClassLibrary.Auth Auth = new ClassLibrary.Auth();
            ID = Auth.LogInFunc("test1", "test1");

            Assert.AreEqual(1, ID);
        }
        // Тест с некорректным вводом логина и пароля.
        [TestMethod]
        public void TestAuth_LogIn_IDClient_Is_Not_One()
        {
            object ID;

            ClassLibrary.Auth Auth = new ClassLibrary.Auth();
            ID = Auth.LogInFunc("test2", "test1");

            Assert.AreNotEqual(1, ID);
        }
    }
}
