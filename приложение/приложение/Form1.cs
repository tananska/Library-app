using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace приложение
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> books = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
           
            books.Add(nameTextBox.Text);
            booksListView.Items.Add(nameTextBox.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (books.Contains(searchTextBox.Text))
            {
                MessageBox.Show("Книгата е намерена.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Книгата не е намерена.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < booksListView.Items.Count; i++)
            {
                if (searchTextBox.Text == booksListView.Items[i].Text)
                {
                    booksListView.Items[i].Remove();
                    books.Remove(searchTextBox.Text);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (lowerLettersRadioButton.Checked)
            {
                books.Add(nameTextBox.Text.ToLower());
                booksListView.Items.Add(nameTextBox.Text.ToLower());
            }
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (upperLettersRadioButton.Checked)
            {
             books.Add(nameTextBox.Text.ToUpper());
             booksListView.Items.Add(nameTextBox.Text.ToUpper());
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            searchTextBox.Clear();
            if (upperLettersRadioButton.Checked)
            {
                upperLettersRadioButton.Checked = false;
            }
            else
            {
                lowerLettersRadioButton.Checked = false;
            }
        }
        
    }
}
