using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Translate : Form
    {
        public Translate()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void Title_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("You found the Easter egg!", "Congrats!", MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeProgram_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void IdentifyLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
