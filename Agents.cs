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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            ShowAg();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSurName.Text) ||
                String.IsNullOrEmpty(textBoxName.Text) ||
                String.IsNullOrEmpty(textBoxLastName.Text) ||
                String.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                AgentsSet agents = new AgentsSet();
                agents.Name = textBoxName.Text;
                agents.Surname = textBoxSurName.Text;
                agents.LastName = textBoxLastName.Text;
                agents.Email = textBoxEmail.Text;
                Program.Edb.AgentsSet.Add(agents);
                Program.Edb.SaveChanges();
                ShowAg();
            }
        }
        void ShowAg()
        {
            listViewAgents.Items.Clear();
            foreach (AgentsSet agents in Program.Edb.AgentsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        agents.Id.ToString(),
                        agents.Surname,
                        agents.Name,
                        agents.LastName,
                        agents.Email
                    });
                item.Tag = agents;
                listViewAgents.Items.Add(item);
            }
            listViewAgents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSurName.Text) ||
                  String.IsNullOrEmpty(textBoxName.Text) ||
                  String.IsNullOrEmpty(textBoxLastName.Text) ||
                  String.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (listViewAgents.SelectedItems.Count == 1)
                {
                    AgentsSet ag = listViewAgents.SelectedItems[0].Tag as AgentsSet;
                    ag.Surname = textBoxSurName.Text;
                    ag.Name = textBoxName.Text;
                    ag.LastName = textBoxLastName.Text;
                    ag.Email = textBoxEmail.Text;
                    Program.Edb.SaveChanges();
                    ShowAg();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgents.SelectedItems.Count == 1)
                {
                    AgentsSet stud = listViewAgents.SelectedItems[0].Tag as AgentsSet;
                    Program.Edb.AgentsSet.Remove(stud);
                    Program.Edb.SaveChanges();
                    ShowAg();
                }
                textBoxSurName.Text = "";
                textBoxName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта кнопка используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
