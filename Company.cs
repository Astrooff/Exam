using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
            ShowCompany();
            ShowAgent();
        }
        void ShowCompany()
        {
            listViewCompany.Items.Clear();
            foreach (CompanySet person in Program.Edb.CompanySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        person.Id.ToString(),
                        person.ShortName,
                        person.Adress,
                        person.INN,
                        person.KPP,
                        person.IdAgent.ToString()
                    });
                item.Tag = person;
                listViewCompany.Items.Add(item);
            }
            listViewCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowAgent()
        {
            comboBoxAgent.Items.Clear();
            foreach (AgentsSet agent in Program.Edb.AgentsSet)
            {
                string[] item =
                {
                    agent.Id.ToString()+". ",agent.Name +" " + agent.Surname
                };
                comboBoxAgent.Items.Add(string.Join(" ", item));
            }
        }

        private void textBoxINN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxKPP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxINN.Text) ||
               String.IsNullOrEmpty(textBoxKPP.Text) ||
               String.IsNullOrEmpty(textBoxShortName.Text) ||
               String.IsNullOrEmpty(textBoxAdress.Text) ||
               comboBoxAgent.SelectedItem == null)
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CompanySet comp = new CompanySet();
                comp.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                comp.ShortName = textBoxShortName.Text;
                comp.INN = textBoxINN.Text;
                comp.KPP= textBoxKPP.Text;
                comp.Adress = textBoxAdress.Text;
                Program.Edb.CompanySet.Add(comp);
                Program.Edb.SaveChanges();
                ShowCompany();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCompany.SelectedItems.Count == 1)
                {
                    CompanySet company = listViewCompany.SelectedItems[0].Tag as CompanySet;
                    Program.Edb.CompanySet.Remove(company);
                    Program.Edb.SaveChanges();
                    ShowAgent();
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта кнопка используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCompany.SelectedItems.Count == 1)
            {
                CompanySet person = listViewCompany.SelectedItems[0].Tag as CompanySet;
                person.ShortName = textBoxShortName.Text;
                person.INN = textBoxINN.Text;
                person.KPP = textBoxKPP.Text;
                person.Adress = textBoxAdress.Text;
                person.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                Program.Edb.SaveChanges();
                ShowCompany();
            }
        }
    }
}
