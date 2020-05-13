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
        ///  Один разговор
        /// </summary>
        [TestMethod]
        public void TestOneSub()
        {
            string expected = "Фамилия: Соколов" + Environment.NewLine +
                "Телефон: 84958374637" + Environment.NewLine +
                "Дата разговора: 22.03.2020" + Environment.NewLine +
                "Тариф (за мин): 350" + Environment.NewLine +
                "Скидка (в %): 20" + Environment.NewLine +
                "Время начала разговора: 18:19:29" + Environment.NewLine +
                "Время окончания разговора: 19:02:23" + Environment.NewLine + Environment.NewLine;
            MainForm.source = "../../../../Lab8_Test/sources/f1.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  Два разговора
        /// </summary>
        [TestMethod]
        public void TestTwoSub()
        {
            string expected = "Фамилия: Соколов" + Environment.NewLine +
                "Телефон: 84958374637" + Environment.NewLine +
                "Дата разговора: 22.03.2020" + Environment.NewLine +
                "Тариф (за мин): 350" + Environment.NewLine +
                "Скидка (в %): 20" + Environment.NewLine +
                "Время начала разговора: 18:19:29" + Environment.NewLine +
                "Время окончания разговора: 19:02:23" + Environment.NewLine + Environment.NewLine+
                "Фамилия: Чижов" + Environment.NewLine +
                "Телефон: 84958374631" + Environment.NewLine +
                "Дата разговора: 19.03.2019" + Environment.NewLine +
                "Тариф (за мин): 10" + Environment.NewLine +
                "Скидка (в %): 30" + Environment.NewLine +
                "Время начала разговора: 1:9:19" + Environment.NewLine +
                "Время окончания разговора: 9:22:3" + Environment.NewLine + Environment.NewLine;
            MainForm.source = "../../../../Lab8_Test/sources/f2.xml";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  нет абонентов
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
        ///  Абонент без имени
        /// </summary>
        [TestMethod]
        public void TestNoName()
        {
            string expected = "";
            MainForm m = new MainForm();
            Assert.AreEqual(m.tableView.Text, expected);
        }
        /// <summary>
        ///  Абонент без начала разговора
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
        ///  Абоент без тарифа
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
        ///  Абонент без скидки
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
        ///  Абонент с неверно введённой скидкой по типу даных
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
        ///  Абонент с неверно введённой датой
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
        ///  Абонент с неверно введённым тарифом
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
