using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using DemoEx;

namespace DemoExTests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void LoadData_ShouldNotThrowException_WhenDatabaseIsEmpty ()
        {
            Form1 form = new Form1();

            form.LoadData();

        }


        [TestMethod]
        public void Button2Click_ShouldDecrementCurrentBy10_WhenCurrentIsGreaterThan10 ()
        {
            Form1 form = new Form1();
            form.current = 20;

            form.button2_Click(null, null);

            Assert.AreEqual(10, form.current, "Current should be decremented by 10.");
        }

        [TestMethod]
        public void Button2Click_ShouldSetCurrentToZero_WhenCurrentIsLessThan10 ()
        {
            Form1 form = new Form1();
            form.current = 5;

            form.button2_Click(null, null);

            Assert.AreEqual(0, form.current, "Current should be set to zero.");
        }
        [TestMethod]
        public void Button2Click_ShouldSetCurrentToZero_WhenCurrentIsLessThan20 ()
        {
            Form1 form = new Form1();
            form.current = 10;

            form.button2_Click(null, null);

            Assert.AreEqual(0, form.current, "Current should be set to zero.");
        }

        [TestMethod]
        public void Button1Click_ShouldIncrementCurrentBy10_WhenCurrentIsLessThanTotalCount ()
        {
            Form1 form = new Form1();
            form.current = 10;

            form.button1_Click(null, null);

            Assert.AreEqual(20, form.current, "Current should be incremented by 10.");
        }


    }
}
