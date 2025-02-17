using NUnit.Framework;
using System;

namespace TestProject1
{
    public class TriangleTests
    {
        [Test]
        public void ValidTriangleTest()
        {
            // Проверка существования треугольника
            bool result = Triangle.Exists(3, 4, 5);
            string message = result ? "Треугольник существует" : "Треугольник не существует";
            Assert.AreEqual("Треугольник существует", message);
        }

        [Test]
        public void InvalidTriangleTest()
        {
            // Проверка невозможного треугольника
            bool result = Triangle.Exists(1, 2, 3);
            string message = result ? "Треугольник существует" : "Треугольник не существует";
            Assert.AreEqual("Треугольник не существует", message);
        }

        [Test]
        public void RightTriangleTest()
        {
            // Проверка, что треугольник прямоугольный
            bool result = Triangle.IsRightTriangle(5, 12, 13);
            string message = result ? "Прямоугольный треугольник" : "Не прямоугольный треугольник";
            Assert.AreEqual("Прямоугольный треугольник", message);
        }

        [Test]
        public void NotRightTriangleTest()
        {
            // Проверка, что треугольник не является прямоугольным
            bool result = Triangle.IsRightTriangle(5, 5, 5);
            string message = result ? "Прямоугольный треугольник" : "Не прямоугольный треугольник";
            Assert.AreEqual("Не прямоугольный треугольник", message);
        }

        [Test]
        public void NonExistentTriangleTest()
        {
            // Проверка, что метод выбрасывает исключение при невозможном треугольнике
            try
            {
                Triangle.IsRightTriangle(0, 4, 5);
                Assert.Fail("Ожидалось исключение");
            }
            catch (ArgumentException)
            {
                Assert.AreEqual("Невозможный треугольник", "Невозможный треугольник");
            }
        }
    }
}
