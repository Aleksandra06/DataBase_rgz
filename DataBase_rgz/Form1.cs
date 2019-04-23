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

    public struct sproducts
    {
        public string spruduct;
        public int ssum;
    };

    public struct sreciepts
    {
        public string scategory;
        public string sdish;
        public int snum;
        public sproducts[] sproduct;
    };

    public partial class Form1 : Form
    {
        sreciepts[] dish;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            //string[] rproducts = new string[10];
            //int[] rsum = new int[10];

            //n = (int)this.блюдоTableAdapter.Sum_dish();
            ////int m = (int)this.продуктыTableAdapter.Sum_products();
            ////dishs = new reciepts[n];
            //string tmp;
            //for (int i = 1; i < n; i++)
            //{
            //   / dishs[i].rdish = this.dataGridView1[2, i + 1].ToString();
            //    dishs[i].rcategory = this.dataGridView1[3, i + 1].ToString();
            //    //for (int j=0;j<m; j++)
            //    //{
            //    //    while (dataGridView2[])
            //    //    dishs[i].rproducts[j] = 
            //    //}
            //}

        }

        private void LoadData()
        {
            Form1_Load();
            int n = (int)this.блюдоTableAdapter.sum_recipes();
            int m = (int)this.продуктыTableAdapter.sum_product();
            int tmp;
            dish = new sreciepts[n];
            for (int i = 0; i < n; i++)
            {
                dish[i].scategory = (string)recipesDataSet.Блюдо[i][2];
                dish[i].sdish = (string)recipesDataSet.Блюдо[i][1];
                dish[i].snum = 0;
                for (int j = 0; j < m; j++)
                {
                    if ((int)recipesDataSet.Продукты[dish[i].snum][3] == (int)recipesDataSet.Блюдо[i][0])
                        dish[i].snum = dish[i].snum + 1;
                }
                dish[i].sproduct = new sproducts[dish[i].snum];
                tmp = 0;
                for (int j = 0; j < m; j++)
                {
                    if (((int)recipesDataSet.Продукты[j][3] == (int)recipesDataSet.Блюдо[i][0]) && (tmp< dish[i].snum))
                    {
                        dish[i].sproduct[tmp].spruduct = (string)recipesDataSet.Продукты[j][1];
                        string tgk = (string)recipesDataSet.Продукты[j][2];
                        tmp++;
                        //dish[i].sproduct[j].ssum = (int)recipesDataSet.Продукты[j][2];
                    }
                }
            }



            //while (reader.Read())
            //{
            //    data.Add(new string[3]);

            //    data[data.Count - 1][0] = reader[0].ToString();
            //    data[data.Count - 1][1] = reader[1].ToString();
            //    data[data.Count - 1][2] = reader[2].ToString();
            //}

            //reader.Close();

            //myConnection.Close();

            //foreach (string[] s in data)
            //    dataGridView1.Rows.Add(s);
        }

        private void textBoxKolChel_KeyPress(object sender, KeyPressEventArgs e)//ввод цифр
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load()
        {
            this.продуктыTableAdapter.Fill(this.recipesDataSet.Продукты);
            this.блюдоTableAdapter.Fill(this.recipesDataSet.Блюдо);
            this.продукты_естьTableAdapter.Fill(this.productsDataSet.Продукты_есть);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Поиск по названию блюда
        {
            try
            {
                this.блюдоTableAdapter.search_dish(this.recipesDataSet.Блюдо, textBox1.Text);
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
                this.блюдоTableAdapter.seach_category(this.recipesDataSet.Блюдо, textBox2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)//Поиск по продукту
        {
            try
            {
                this.блюдоTableAdapter.search_product(this.recipesDataSet.Блюдо, textBox4.Text);
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
