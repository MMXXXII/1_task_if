using NUnit.Framework;
using System;

namespace TestProject1
{
    public class TriangleTests
    {
        // Проверяет, что метод Exists возвращает true для корректных сторон треугольника.
        [Test]
        public void Exists_ValidSides_ReturnsTrue()
        {
            Assert.IsTrue(Triangle.Exists(3, 4, 5)); // Прямоугольный треугольник
            Assert.IsTrue(Triangle.Exists(5, 5, 5)); // Равносторонний треугольник
        }
        // Проверяет, что метод Exists возвращает false для некорректных сторон треугольника.
        [Test]
        public void Exists_InvalidSides_ReturnsFalse()
        {
            Assert.IsFalse(Triangle.Exists(1, 2, 3)); // Не выполняется неравенство треугольника
            Assert.IsFalse(Triangle.Exists(0, 4, 5)); // Одна из сторон равна нулю
            Assert.IsFalse(Triangle.Exists(-3, 4, 5)); // Одна из сторон отрицательная
        }

        // Проверяет, что метод IsRightTriangle возвращает true для прямоугольных треугольников.
        [Test]
        public void IsRightTriangle_ValidRightTriangle_ReturnsTrue()
        {
            Assert.IsTrue(Triangle.IsRightTriangle(3, 4, 5)); // Классический Пифагоров треугольник
            Assert.IsTrue(Triangle.IsRightTriangle(5, 12, 13)); // Еще один Пифагоров треугольник
        }

        // Проверяет, что метод IsRightTriangle возвращает false для непрямоугольных треугольников.
        [Test]
        public void IsRightTriangle_InvalidRightTriangle_ReturnsFalse()
        {
            Assert.IsFalse(Triangle.IsRightTriangle(3, 4, 6)); // Боковая сторона больше, чем нужно
            Assert.IsFalse(Triangle.IsRightTriangle(5, 5, 5)); // Равносторонний треугольник
        }

        // Проверяет, что метод IsRightTriangle выбрасывает исключение для несуществующих треугольников.
        [Test]
        public void IsRightTriangle_NonExistentTriangle_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Triangle.IsRightTriangle(1, 2, 3)); // Не выполняется неравенство треугольника
            Assert.Throws<ArgumentException>(() => Triangle.IsRightTriangle(0, 4, 5)); // Одна из сторон равна нулю
        }
    }
}
