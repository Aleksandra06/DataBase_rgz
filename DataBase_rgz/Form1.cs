using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_rgz
{
    public struct reciepts
    {
        public string rcategory;
        public string rdish;
        public string[] rproducts;
        public int[] rsum;
    };

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            string[] rproducts = new string[10];
            int[] rsum = new int[10];

            //int n = (int)this.блюдоTableAdapter.Sum_dish();
            //reciepts[] dishs = new reciepts[n];
        }

        private void textBoxKolChel_KeyPress(object sender, KeyPressEventArgs e)//ввод цифр
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "productsDataSet.Продукты_есть". При необходимости она может быть перемещена или удалена.
            this.продукты_естьTableAdapter.Fill(this.productsDataSet.Продукты_есть);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "recipesDataSet.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter.Fill(this.recipesDataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "recipesDataSet.Блюдо". При необходимости она может быть перемещена или удалена.
            this.блюдоTableAdapter.Fill(this.recipesDataSet.Блюдо);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Поиск по названию блюда
        {
            try
            {
                this.блюдоTableAdapter.Dish_search(this.recipesDataSet.Блюдо, textBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//Поиск по категории
        {
            try
            {
                this.блюдоTableAdapter.Category_seach(this.recipesDataSet.Блюдо, textBox2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//Поиск по продукту
        {
            try
            {
                this.продуктыTableAdapter.Product_seach(this.recipesDataSet.Продукты, textBox3.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            
            try
            {
               // this.продуктыTableAdapter.Product_seach(this.recipesDataSet.Продукты, this.productsDataSet.Продукты_есть);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
