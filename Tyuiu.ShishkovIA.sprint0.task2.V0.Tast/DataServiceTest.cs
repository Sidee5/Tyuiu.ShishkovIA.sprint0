using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShishkovIA.sprint0.task2.V0.Lib;

namespace Tyuiu.ShishkovIA.sprint0.task2.V0.Tast
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassage()
        {
            var name = "Илья";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Илья", res);


        }
    }
}
