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
    public partial class Form1 : Form
    {
        
        
        public ModelsView.Manager CategoryManager { get; set; }
        public Form1()
        {
            Program.f1 = this;
            InitializeComponent();
            CategoryManager = new ModelsView.Manager();
            CategoryManager.CategoryListChanged += UpdateListBox; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(CategoryManager);
            newForm.Show();

        }
        void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (var Category in CategoryManager.GetCategoryNames())
            {
                listBox1.Items.Add(Category);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.ShowDialog();
           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBox1.SelectedIndex != null)
            //{
            //    Program.f3.textBox1.Enabled = true;
            //    Program.f3.textBox1.Text = listBox1.SelectedItem as string;
            //}
            //else
            {
            //    Program.f3.textBox1.Enabled=false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
