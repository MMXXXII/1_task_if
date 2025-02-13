using NUnit.Framework;
using System;

namespace TestProject1
{
    public class TriangleTests
    {
        // ���������, ��� ����� Exists ���������� true ��� ���������� ������ ������������.
        [Test]
        public void Exists_ValidSides_ReturnsTrue()
        {
            Assert.IsTrue(Triangle.Exists(3, 4, 5)); // ������������� �����������
            Assert.IsTrue(Triangle.Exists(5, 5, 5)); // �������������� �����������
        }
        // ���������, ��� ����� Exists ���������� false ��� ������������ ������ ������������.
        [Test]
        public void Exists_InvalidSides_ReturnsFalse()
        {
            Assert.IsFalse(Triangle.Exists(1, 2, 3)); // �� ����������� ����������� ������������
            Assert.IsFalse(Triangle.Exists(0, 4, 5)); // ���� �� ������ ����� ����
            Assert.IsFalse(Triangle.Exists(-3, 4, 5)); // ���� �� ������ �������������
        }

        // ���������, ��� ����� IsRightTriangle ���������� true ��� ������������� �������������.
        [Test]
        public void IsRightTriangle_ValidRightTriangle_ReturnsTrue()
        {
            Assert.IsTrue(Triangle.IsRightTriangle(3, 4, 5)); // ������������ ��������� �����������
            Assert.IsTrue(Triangle.IsRightTriangle(5, 12, 13)); // ��� ���� ��������� �����������
        }

        // ���������, ��� ����� IsRightTriangle ���������� false ��� ��������������� �������������.
        [Test]
        public void IsRightTriangle_InvalidRightTriangle_ReturnsFalse()
        {
            Assert.IsFalse(Triangle.IsRightTriangle(3, 4, 6)); // ������� ������� ������, ��� �����
            Assert.IsFalse(Triangle.IsRightTriangle(5, 5, 5)); // �������������� �����������
        }

        // ���������, ��� ����� IsRightTriangle ����������� ���������� ��� �������������� �������������.
        [Test]
        public void IsRightTriangle_NonExistentTriangle_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Triangle.IsRightTriangle(1, 2, 3)); // �� ����������� ����������� ������������
            Assert.Throws<ArgumentException>(() => Triangle.IsRightTriangle(0, 4, 5)); // ���� �� ������ ����� ����
        }
    }
}
