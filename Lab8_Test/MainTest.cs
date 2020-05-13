using Lab8_LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Lab8_Test
{
    [TestClass]
    public class MainTest
    {
        /// <summary>
        ///  ���� ��������
        /// </summary>
        [TestMethod]
        public void TestOneSub()
        {
            string expected = "�������: �������" + Environment.NewLine +
                "�������: 84958374637" + Environment.NewLine +
                "���� ���������: 22.03.2020" + Environment.NewLine +
                "����� (�� ���): 350" + Environment.NewLine +
                "������ (� %): 20" + Environment.NewLine +
                "����� ������ ���������: 18:19:29" + Environment.NewLine +
                "����� ��������� ���������: 19:02:23" + Environment.NewLine + Environment.NewLine;
            MainForm.source = "../../../../Lab8_Test/sources/f1.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  ��� ���������
        /// </summary>
        [TestMethod]
        public void TestTwoSub()
        {
            string expected = "�������: �������" + Environment.NewLine +
                "�������: 84958374637" + Environment.NewLine +
                "���� ���������: 22.03.2020" + Environment.NewLine +
                "����� (�� ���): 350" + Environment.NewLine +
                "������ (� %): 20" + Environment.NewLine +
                "����� ������ ���������: 18:19:29" + Environment.NewLine +
                "����� ��������� ���������: 19:02:23" + Environment.NewLine + Environment.NewLine+
                "�������: �����" + Environment.NewLine +
                "�������: 84958374631" + Environment.NewLine +
                "���� ���������: 19.03.2019" + Environment.NewLine +
                "����� (�� ���): 10" + Environment.NewLine +
                "������ (� %): 30" + Environment.NewLine +
                "����� ������ ���������: 1:9:19" + Environment.NewLine +
                "����� ��������� ���������: 9:22:3" + Environment.NewLine + Environment.NewLine;
            MainForm.source = "../../../../Lab8_Test/sources/f2.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  ��� ���������
        /// </summary>
        [TestMethod]
        public void TestNoSub()
        {
            string expected = "";
            MainForm.source = "../../../../Lab8_Test/sources/f3.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  ������� ��� �����
        /// </summary>
        [TestMethod]
        public void TestNoName()
        {
            string expected = "";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  ������� ��� ������ ���������
        /// </summary>
        [TestMethod]
        public void TestNoTimeStart()
        {
            string expected = "";
            MainForm.source = "../../../../Lab8_Test/sources/f10.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  ������ ��� ������
        /// </summary>
        [TestMethod]
        public void TestNoRate()
        {
            string expected = "";
            MainForm.source = "../../../../Lab8_Test/sources/f5.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  ������� ��� ������
        /// </summary>
        [TestMethod]
        public void TestNoDiscount()
        {
            string expected = "";
            MainForm.source = "../../../../Lab8_Test/sources/f6.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  ������� � ������� �������� ������� �� ���� �����
        /// </summary>
        [TestMethod]
        public void TestUncorrDiscount()
        {
            string expected = "";
            MainForm.source = "../../../../Lab8_Test/sources/f7.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  ������� � ������� �������� �����
        /// </summary>
        [TestMethod]
        public void TestUncorrDate()
        {
            string expected = "";
            MainForm.source = "../../../../Lab8_Test/sources/f8.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  ������� � ������� �������� �������
        /// </summary>
        [TestMethod]
        public void TestUncorrRate()
        {
            string expected = "";
            MainForm.source = "../../../../Lab8_Test/sources/f9.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
    }
}
