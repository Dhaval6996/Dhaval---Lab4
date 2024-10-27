using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnitDemonstration;
using System;

namespace TestProject
{

    [TestClass]
    public class UnitTest1
    {
        Triangle myObj = new Triangle();
        [TestMethod]
        public void ValidTriangle_ValidAngles_ReturnsValid()
        {
            // Arrange
            int angle1 = 60;
            int angle2 = 60;
            int angle3 = 60;

            // Act
            string result = Triangle.ValidTriangle(angle1, angle2, angle3);

            // Assert
            Assert.AreEqual("Valid triangle", result);
        }
        public void ValidTriangle_InvalidSum_ReturnsNotValid()
        {
            // Arrange
            int angle1 = 50;
            int angle2 = 60;
            int angle3 = 60;

            // Act
            string result = Triangle.ValidTriangle(angle1, angle2, angle3);

            // Assert
            Assert.AreEqual("Not a valid triangle", result);
        }
        public void ValidTriangle_ZeroOrNegativeAngles_ReturnsError()
        {
            // Arrange
            int angle1 = 0;
            int angle2 = 60;
            int angle3 = 60;

            // Act
            string result = Triangle.ValidTriangle(angle1, angle2, angle3);

            // Assert
            Assert.AreEqual("Angles should be greater than 0", result);
        }

        [TestMethod]
        public void ValidTriangle_NegativeAngle_ReturnsError()
        {
            // Arrange
            int angle1 = -10;
            int angle2 = 90;
            int angle3 = 100;

            // Act
            string result = Triangle.ValidTriangle(angle1, angle2, angle3);

            // Assert
            Assert.AreEqual("Angles should be greater than 0", result);
        }

        

        // Invalid Test Case: One angle is zero
        [TestMethod]
        public void ValidTriangle_ZeroAngle_ReturnsError()
        {
            // Arrange
            int angle1 = 0;
            int angle2 = 60;
            int angle3 = 120;

            // Act
            string result = Triangle.ValidTriangle(angle1, angle2, angle3);

            // Assert
            Assert.AreEqual("Angles should be greater than 0", result);
        }


        // Invalid Test Case: Sum of angles is more than 180
        [TestMethod]
        public void ValidTriangle_SumMoreThan180_ReturnsNotValid()
        {
            // Arrange
            int angle1 = 100;
            int angle2 = 60;
            int angle3 = 30;

            // Act
            string result = Triangle.ValidTriangle(angle1, angle2, angle3);

            // Assert
            Assert.AreEqual("Not a valid triangle", result);
        }



        [TestMethod]
        public void Test()
        {
            // Arrange
            int angle1 = 100;
            int angle2 = 260;
            int angle3 = 230;

            // Act
            string result = Triangle.ValidTriangle(angle1, angle2, angle3);

            // Assert
            Assert.AreEqual("Not a valid triangle", result);
        }

        // Invalid test cases
        [TestMethod]
        public void ValidTriangle_SumGreaterThan180_ReturnsNotValid()
        {
            int angle1 = 100;
            int angle2 = 150;
            int angle3 = 200;
            string result = Triangle.ValidTriangle(angle1, angle2, angle3);
            Assert.AreEqual("Not a valid triangle", result);
        }

        [TestMethod]
        public void ValidTriangle_RightAngleTriangle_ReturnsValid()
        {
            // Arrange
            int angle1 = 90;
            int angle2 = 45;
            int angle3 = 45;

            // Act
            string result = Triangle.ValidTriangle(angle1, angle2, angle3);

            // Assert
            Assert.AreEqual("Valid triangle", result);
        }
        [TestMethod]
        public void ValidTriangle_AcuteTriangle_ReturnsValid()
        {
            // Arrange
            int angle1 = 60;
            int angle2 = 70;
            int angle3 = 50;

            // Act
            string result = Triangle.ValidTriangle(angle1, angle2, angle3);

            // Assert
            Assert.AreEqual("Valid triangle", result);
        }


        [TestMethod]
        public void ValidTriangle_ObtuseTriangle_ReturnsValid()
        {
            // Arrange
            int angle1 = 120;
            int angle2 = 30;
            int angle3 = 30;

            // Act
            string result = Triangle.ValidTriangle(angle1, angle2, angle3);

            // Assert
            Assert.AreEqual("Valid triangle", result);
        }
        [TestMethod]
        public void ValidTriangle_IsoscelesTriangle_ReturnsValid()
        {
            // Arrange
            int angle1 = 70;
            int angle2 = 70;
            int angle3 = 40;

            // Act
            string result = Triangle.ValidTriangle(angle1, angle2, angle3);

            // Assert
            Assert.AreEqual("Valid triangle", result);
        }

        [TestMethod]
        public void ValidTriangle_ScaleneTriangle_ReturnsValid()
        {
            // Arrange
            int angle1 = 50;
            int angle2 = 60;
            int angle3 = 70;

            // Act
            string result = Triangle.ValidTriangle(angle1, angle2, angle3);

            // Assert
            Assert.AreEqual("Valid triangle", result);
        }





    }
}
