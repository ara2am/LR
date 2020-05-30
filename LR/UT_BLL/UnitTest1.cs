using System;
using System.Collections.Generic;
using BLL.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestBLL
{
    [TestClass]
    public class BllTests
    {
        [TestMethod]
        public void AddWorkerTest()
        {
            Cafe[] items =
            {
                new Cafe("Test1", "t1", 23),
                new Cafe("Test2", "t2", 765),
                new Cafe("Test3", "t3", 2456),
                new Cafe("Test4", "t4", 654),
            };
            Worker boolkek = new Worker("Alld", "Dfgh");

            Mock<Cafe> bll = new Mock<Cafe>();
            bll.Setup(b => b.AddWorker(boolkek)).Returns(boolkek);
            var Bll = bll.Object;
            var expected = items[0];
            var actual = Bll.GetWorker("Alld", "Dfgh");
			
            Assert.AreEqual(expected, actual);
        }
		
		[TestMethod]
        public void GetAllCafeTest()
        {
            List<Cafe> items = new List<Cafe>()
            {

                new Cafe("Test1", "t1", 23),
                new Cafe("Test2", "t2", 765),
                new Cafe("Test3", "t3", 2456),
                new Cafe("Test4", "t4", 654),
   
			};
			
            Mock<Cafe> bll = new Mock<Cafe>();
            bll.Setup(b => b.GetAll()).Returns(items);
            Cafe Bll = bll.Object;
            List<Cafe> expected = items;
            List<Cafe> actual = Bll.GetAll();
			
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCafeByIdTest ()
        {
            Cafe[] items =
            {
                new Cafe("Test1", "t1", 23),
                new Cafe("Test2", "t2", 765),
                new Cafe("Test3", "t3", 2456),
                new Cafe("Test4", "t4", 654),
            };
			
            Mock<Cafe> bll = new Mock<Cafe>();
            bll.Setup(b => b.Get(1)).Returns(items[0]);
            bll.Setup(b => b.Get(2)).Returns(items[1]);
            var Bll = bll.Object;
            var expected = items[0];
            var actual = Bll.GetQuest(5);
			
            Assert.AreEqual(expected, actual);
        }
    }
}
