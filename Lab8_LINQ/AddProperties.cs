using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8_LINQ
{
    /// <summary>
    /// Форма добавления
    /// </summary>
    public partial class AddProperties : Form
    {
        MainForm context;
        public AddProperties(MainForm context)
        {
            InitializeComponent();
            this.context = context;
            btnAdd.Click += new EventHandler(OnBtnAddClick);
        }
        /// <summary>
        /// Добавление новго разговора в файл и вывод информации о нём на экран
        /// </summary>
        /// <remarks>При возникновении ошибки на экране появляется соответсвующая надпись</remarks>
        private void OnBtnAddClick(object sender, EventArgs e)
        {
            int number;
            if (maskedTextBox4.Text != "" &&  phoneTxtBox.Text != ""
                && rateTxtBox.Text != "" && maskedTextBox1.Text != ""
                && discountTxtBox.Text != "" && maskedTextBox2.Text != "" 
                && int.TryParse(rateTxtBox.Text, out number) && int.TryParse(discountTxtBox.Text, out number))
            {
               string result = "Фамилия: " + maskedTextBox4.Text + Environment.NewLine +
                    "Телефон: " + phoneTxtBox.Text + Environment.NewLine +
                    "Дата разговора: " + maskedTextBox1.Text + Environment.NewLine +
                    "Тариф: " + rateTxtBox.Text + Environment.NewLine +
                    "Скидка: " + discountTxtBox.Text + Environment.NewLine +
                    "Время начала разговора: " + maskedTextBox2.Text + Environment.NewLine +
                    "Время окончания разговора: " + maskedTextBox3.Text + Environment.NewLine + Environment.NewLine;
                try
                {
                    XDocument xdoc = XDocument.Load(MainForm.source);
                    xdoc.Element("payers").Add(new XElement("payer",
                        new XElement("surname", maskedTextBox4.Text),
                        new XElement("phone", phoneTxtBox.Text),
                        new XElement("dateConvers", maskedTextBox1.Text),
                        new XElement("rate", rateTxtBox.Text),
                        new XElement("discount", discountTxtBox.Text),
                        new XElement("timeStart", maskedTextBox2.Text),
                        new XElement("timeFinish", maskedTextBox3.Text)));
                    context.setText(result);
                    xdoc.Save(MainForm.source);
                } catch
                {
                    MessageBox.Show("Ошибка записи в файл");
                }
            } else
            {
                MessageBox.Show("Ошибка! Некорректные введённые данные.");
            }
            this.Close();
        }
    }
}
