using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductLibrary
{
    public partial class Form3 : Form
    {
        public ModelsView.Manager CategoryManager { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CategoryManager.RenameCategory(Program.f1.listBox1.SelectedItem as string, textBox1.Text);
        }
        private void RenameItem(string oldName, string newName)
        {
            for ( int i = 0; i < Program.f1.listBox1.Items.Count; i++) 
            {
                if ((string)Program.f1.listBox1.Items[i] == oldName)
                {
                    Program.f1.listBox1.Items[Program.f1.listBox1.Items.IndexOf(Program.f1.listBox1.Items[i])] = newName;
                }
            }
        }
    }
}
