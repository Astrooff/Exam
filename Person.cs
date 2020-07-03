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
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
            ShowPerson();
            ShowAgent();
        }

        private void textBoxSurName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char i = e.KeyChar;
            if ((i < 'А' || i > 'я') && i != '\b' && i != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char i = e.KeyChar;
            if ((i < 'А' || i > 'я') && i != '\b' && i != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char i = e.KeyChar;
            if ((i < 'А' || i > 'я') && i != '\b' && i != '.')
            {
                e.Handled = true;
            }
        }
        void ShowPerson()
        {
            listViewPerson.Items.Clear();
            foreach (PersonSet person in Program.Edb.PersonSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        person.Id.ToString(),
                        person.Surname,
                        person.Name,
                        person.LastName,
                        person.Adress,
                        person.Sex,
                        person.IdAgent.ToString()
                    });
                item.Tag = person;
                listViewPerson.Items.Add(item);
            }
            listViewPerson.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSurName.Text) ||
               String.IsNullOrEmpty(textBoxName.Text) ||
               String.IsNullOrEmpty(textBoxLastName.Text) ||
               String.IsNullOrEmpty(textBoxAdress.Text) ||
               comboBoxSex.SelectedItem == null &&
               comboBoxAgent.SelectedItem == null)
            {
                    MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PersonSet person = new PersonSet();
                person.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                person.Name = textBoxName.Text;
                person.Surname = textBoxSurName.Text;
                person.LastName = textBoxLastName.Text;
                person.Adress = textBoxAdress.Text;
                person.Sex = comboBoxSex.SelectedItem.ToString();
                Program.Edb.PersonSet.Add(person);
                Program.Edb.SaveChanges();
                ShowPerson();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPerson.SelectedItems.Count == 1)
                {
                    PersonSet person = listViewPerson.SelectedItems[0].Tag as PersonSet;
                    Program.Edb.PersonSet.Remove(person);
                    Program.Edb.SaveChanges();
                    ShowPerson();
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта кнопка используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPerson.SelectedItems.Count == 1)
            {
                PersonSet person = listViewPerson.SelectedItems[0].Tag as PersonSet;
                person.Surname = textBoxSurName.Text;
                person.Name = textBoxName.Text;
                person.LastName = textBoxLastName.Text;
                person.Adress = textBoxAdress.Text;
                person.Sex = comboBoxSex.SelectedItem.ToString();
                person.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                Program.Edb.SaveChanges();
                ShowPerson();
            }
        }
    }
}

