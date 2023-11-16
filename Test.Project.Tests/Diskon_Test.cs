using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;

namespace Diskon.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Test_HitungDiskon()
        {
            // Arrange
            int quantity1 = 10;
            int quantity2 = 30;
            int quantity3 = 50;
            int quantity4 = 70;
            int quantity5 = 90;
            int quantity6 = 110;

            // Act
            double discount1 = Program.HitungDiskon(quantity1);
            double discount2 = Program.HitungDiskon(quantity2);
            double discount3 = Program.HitungDiskon(quantity3);
            double discount4 = Program.HitungDiskon(quantity4);
            double discount5 = Program.HitungDiskon(quantity5);
            double discount6 = Program.HitungDiskon(quantity6);

            // Assert
            Assert.AreEqual(0.02, discount1);
            Assert.AreEqual(0.04, discount2);
            Assert.AreEqual(0.06, discount3);
            Assert.AreEqual(0.08, discount4);
            Assert.AreEqual(0.10, discount5);
            Assert.AreEqual(0.20, discount6);
        }

        [TestMethod]
        public void Test_TampilkanDiskon()
        {
            // Arrange
            double discount = 0.15;
            string expectedOutput = "Diskon yang Anda dapatkan: 15%";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.TampilkanDiskon(discount);
                string actualOutput = sw.ToString().Trim();

                // Assert
                Assert.AreEqual(expectedOutput, actualOutput);
            }
        }

    }
}
