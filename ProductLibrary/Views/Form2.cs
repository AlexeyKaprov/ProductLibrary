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
    public partial class Form2 : Form
    {
        public ModelsView.Manager CategoryManager { get; set; }
        public Form2(ModelsView.Manager manager)
        {
            InitializeComponent();
            CategoryManager = manager;
            CategoryManager.CategoryListChanged += UpdateListBox;
            //CategoryManager.CategoryNameChanged += RenameName;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text))
            {
                CategoryManager.AddCategory(textBox1.Text, "", 5);
            }
        }
        void UpdateListBox()
        {
            Program.f1.listBox1.Items.Clear();
            foreach (var category in CategoryManager.GetCategoryNames())
            {
                Program.f1.listBox1.Items.Add(category);
            }
        }
    }
}
