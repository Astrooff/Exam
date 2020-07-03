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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonAgents_Click(object sender, EventArgs e)
        {
            Form form = new Agents();
            form.Show();
        }

        private void buttonPerosn_Click(object sender, EventArgs e)
        {
            Form form = new Person();
            form.Show();
        }

        private void buttonCompany_Click(object sender, EventArgs e)
        {
            Form form = new Company();
            form.Show();
        }
    }
}
