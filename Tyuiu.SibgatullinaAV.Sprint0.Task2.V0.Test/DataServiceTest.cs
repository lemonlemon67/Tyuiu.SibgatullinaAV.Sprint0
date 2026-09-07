using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SibgatullinaAV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SibgatullinaAV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "кокакола";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("хеллоу!!!!, кокакола", res);
        }
    }
}
