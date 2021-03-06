﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8_LINQ
{
   /// <summary>
   /// Форма удаления
   /// </summary>
    public partial class Delete : Form
    {
        MainForm context;
        public Delete(MainForm context)
        {
            InitializeComponent();
            this.context = context;
            btnDel.Click += new EventHandler(OnBtnDelClick);
        }
        /// <summary>
        /// Удаление разговора по номеру телефона
        /// </summary>
        /// <remarks>При возникновении ошибки на экране появляется сообщение об ошибке</remarks>
        private void OnBtnDelClick(object sender, EventArgs e)
        {
            IEnumerable<XElement> deleteQuery = null;
            try
            {
                XDocument xdoc = XDocument.Load(MainForm.source);
                context.showAll(null, null);
                deleteQuery = xdoc.Element("payers").Elements("payer").Where(s => s.Element("phone").Value == delTxtBox.Text);

                if (deleteQuery.Count() == 0)
                {
                    MessageBox.Show("Такой разговор не найден: " + delTxtBox.Text, "Ошибка");
                }
                else
                {
                    foreach (var query in deleteQuery)
                    {
                        try
                        {
                            MessageBox.Show("Удалена информация об абоненте: \n" + context.getSubsInfo(query), "Удаление...");
                            query.Remove();
                            xdoc.Save(MainForm.source);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Произошла ошибка при удалении.\n" + ex.Message, "Ошибка");
                        }
                    }
                    context.showAll(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не найден абонент с таким номером телефона: " + delTxtBox.Text,"Ошибка");
            }
            this.Close();
        }
    }
}
