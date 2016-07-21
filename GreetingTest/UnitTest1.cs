using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldSample;
using HelloWorldSample.Models;
using GreetingTest;
using HelloWorldSample.Controllers;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace GreetingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new GreetingController();
        }

        [TestMethod]
        public async void GetAllGreetingsAsync_ShouldReturnAllGreetings()
        {
            var testGreetings = GetTestGreetings();
            var controller = new SimpleTestController(testGreetings);

            var result = await controller.GetAllGreetingsAsync() as List<Greeting>;
         
        }

        private object GetTestGreetings()
        {
            //
            throw new NotImplementedException();
        }
    }
}





