using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8_LINQ
{
    public partial class MainForm : Form
    {
        public int paramIndex = 0;
        public string paramValue = "";
        public static string source = "../../../source.xml";
        public MainForm()
        {
            InitializeComponent();
            showAll(null, null);
            this.showAllToolStripMenuItem.Click += new EventHandler(showAll);
            this.deleteToolStripMenuItem.Click += new EventHandler(OnDelClick);
            this.setSearchToolStripMenuItem.Click += new System.EventHandler(this.OnSetSearchClick);
        }
        /// <summary>
        /// Вывести все разговоры
        /// </summary>
        public void showAll(object sender, EventArgs e)
        {
            try
            {
                XDocument xdoc = XDocument.Load(source);
                var payers = xdoc.Element("payers");
                tableView.Text = "";
                foreach (XElement xe in payers.Elements("payer"))
                {
                    tableView.Text += getSubsInfo(xe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:\n" + ex.Message, "Ошибка");
            }
        }
        /// <summary>
        /// Получение информации об абоненте
        /// </summary>
        /// <param name="xe">XElement с информацией об абоненте</param>
        /// <returns>информация об абоненте</returns>
        public string getSubsInfo(XElement xe)
        {
            int number;
            string info = "";
            XElement surname = xe.Element("surname");
            XElement phone = xe.Element("phone");
            XElement dateConvers = xe.Element("dateConvers");
            XElement rate = xe.Element("rate");
            XElement discount = xe.Element("discount");
            XElement timeStart = xe.Element("timeStart");
            XElement timeFinsh = xe.Element("timeFinish");

            if (surname != null && phone != null && dateConvers != null &&
                rate != null && discount != null && timeStart != null && timeFinsh != null &&
                surname.Value != "" && phone.Value != "" && rate.Value != "" && discount.Value != "" && timeStart.Value != "" && timeFinsh.Value != "")
            {
                info = "Фамилия: " + surname.Value + Environment.NewLine +
                    "Телефон: " + phone.Value + Environment.NewLine +
                    "Дата разговора: " + dateConvers.Value + Environment.NewLine +
                    "Тариф (за мин): " + rate.Value + Environment.NewLine +
                    "Скидка (в %): " + discount.Value + Environment.NewLine +
                    "Время начала разговора: " + timeStart.Value + Environment.NewLine +
                    "Время окончания разговора: " + timeFinsh.Value + Environment.NewLine + Environment.NewLine;
            }
            return info;

        }
        /// <summary>
        /// Открытие формы с изменением параметров поиска
        /// </summary>
        private void OnSetSearchClick(object sender, EventArgs e)
        {
            SearchProperties setFilterForm = new SearchProperties(this, paramIndex, paramValue);
            setFilterForm.Show();
        }
        /// <summary>
        /// Открытие формы с добавлением записи
        /// </summary>
        private void OnAddClick(object sender, EventArgs e)
        {
            AddProperties addProp = new AddProperties(this);
            addProp.Show();
        }
        /// <summary>
        /// Открытие формы с удалением записи
        /// </summary>
        private void OnDelClick(object sender, EventArgs e)
        {
            Delete del = new Delete(this);
            del.Show();
        }
        /// <summary>
        /// Метод, который выводит на экран, найденных абонентов
        /// </summary>
        /// <param name="paramIndex">номер параметра для сравнения</param>
        /// <param name="str">подстрока, по которой нужно найти абонентов</param>
        public void search(int paramIndex, String str)
        {
            paramValue = str;
            this.paramIndex = paramIndex;
            String param = "";
            switch (paramIndex)
            {
                case 0:
                    param = "surname";
                    break;
                case 1:
                    param = "dateConvers";
                    break;
                case 2:
                    param = "phone";
                    break;
            }
            this.tableView.Text = "";
            try
            {
                var res = XDocument.Load(source).Element("payers").Elements("payer").Where(s => s.Element(param).Value.ToLower().Contains(str.ToLower()));
                foreach (XElement xe in res)
                {
                    tableView.Text += getSubsInfo(xe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:\n" + ex.Message, "Ошибка");
            }
        }
        public void setText(string str)
        {
            tableView.Text = str;
        }
    }
}
