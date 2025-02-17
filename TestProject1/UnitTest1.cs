using NUnit.Framework;
using System;

namespace TestProject1
{
    public class TriangleTests
    {
        [Test]
        public void ValidTriangleTest()
        {
            // �������� ������������� ������������
            bool result = Triangle.Exists(3, 4, 5);
            string message = result ? "����������� ����������" : "����������� �� ����������";
            Assert.AreEqual("����������� ����������", message);
        }

        [Test]
        public void InvalidTriangleTest()
        {
            // �������� ������������ ������������
            bool result = Triangle.Exists(1, 2, 3);
            string message = result ? "����������� ����������" : "����������� �� ����������";
            Assert.AreEqual("����������� �� ����������", message);
        }

        [Test]
        public void RightTriangleTest()
        {
            // ��������, ��� ����������� �������������
            bool result = Triangle.IsRightTriangle(5, 12, 13);
            string message = result ? "������������� �����������" : "�� ������������� �����������";
            Assert.AreEqual("������������� �����������", message);
        }

        [Test]
        public void NotRightTriangleTest()
        {
            // ��������, ��� ����������� �� �������� �������������
            bool result = Triangle.IsRightTriangle(5, 5, 5);
            string message = result ? "������������� �����������" : "�� ������������� �����������";
            Assert.AreEqual("�� ������������� �����������", message);
        }

        [Test]
        public void NonExistentTriangleTest()
        {
            // ��������, ��� ����� ����������� ���������� ��� ����������� ������������
            try
            {
                Triangle.IsRightTriangle(0, 4, 5);
                Assert.Fail("��������� ����������");
            }
            catch (ArgumentException)
            {
                Assert.AreEqual("����������� �����������", "����������� �����������");
            }
        }
    }
}
