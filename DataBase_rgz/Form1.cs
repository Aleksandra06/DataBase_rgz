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

    public struct MENU
    {
        public string snack;
        public string one_dish;
        public string tho_dish;
        public string dessert;
    }

    public partial class Form1 : Form
    {
        // sreciepts[] dish;
        MENU menu;

        public Form1()
        {
            InitializeComponent();
            //System.IO.FileStream fs = new System.IO.FileStream(@"D:/study/Computational_Mathematics/", System.IO.FileMode.Open);
            //System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
            //fs.Close();
            //pictureBox1.Image = img;
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
            string str;
            int num = 0;
            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                dataGridView4.Rows[i].Visible = true;
                dataGridView4.CurrentCell = dataGridView4.Rows[i].Cells[1];
                for (int j = 0; j < dataGridView5.RowCount; j++)
                {
                    str = dataGridView5.Rows[j].Cells[0].Value.ToString();
                    num = -1;
                    do
                    {
                        num++;
                    } while ((str != dataGridView3.Rows[num].Cells[0].Value.ToString()) && (num < dataGridView3.RowCount - 1));
                    if ((str != dataGridView3.Rows[num].Cells[0].Value.ToString()) ||
                        ((int)dataGridView5.Rows[j].Cells[1].Value >= (int)dataGridView3.Rows[num].Cells[1].Value)) {
                        if (i != 0) dataGridView4.CurrentCell = dataGridView4.Rows[0].Cells[1];
                        else dataGridView4.CurrentCell = dataGridView4.Rows[1].Cells[1];
                        dataGridView4.Rows[i].Visible = false;
                    }
                }
            }
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
            dataGridView4.Visible = true;
            dataGridView5.Visible = true;
            pictureBox1.Visible = false;
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

       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.продуктыTableAdapter.Fill(this.recipesDataSet.Продукты);
            this.блюдоTableAdapter.Fill(this.recipesDataSet.Блюдо);
            this.продукты_естьTableAdapter.Fill(this.productsDataSet.Продукты_есть);
        }

        private void TabControl1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            LoadData();

        }

        public void search_radioButton(string str)//когда всего одна строка или ноль, то ее неполучается сделать невидимой
        {
            int n = 0;
            int vis = -1;
            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                if ((dataGridView4.Rows[i].Visible == true) && (str == dataGridView4.Rows[i].Cells[2].Value.ToString()))
                {
                    n++;
                }
            }
            if (n != 0)
            {
                for (int i = 0; i < dataGridView4.RowCount; i++)
                {
                    n = i + 1;
                    if ((dataGridView4.Rows[i].Visible == true) && (str != dataGridView4.Rows[i].Cells[2].Value.ToString()))
                    {
                        if (vis == -1)
                        {
                            while (dataGridView4.Rows[n].Visible == false)
                                n++;
                            dataGridView4.CurrentCell = dataGridView4.Rows[n].Cells[1];
                            dataGridView4.Rows[i].Visible = false;
                        }
                        else
                        {
                            dataGridView4.CurrentCell = dataGridView4.Rows[vis].Cells[1];
                            dataGridView4.Rows[i].Visible = false;
                        }
                    }
                    else
                        if (dataGridView4.Rows[i].Visible == true)
                            vis = i;
                }
            }
            else
            {
                dataGridView4.Visible = false;
                dataGridView5.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
            search_radioButton("Закуска");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
            search_radioButton("Первое");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
            search_radioButton("Второе");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
            search_radioButton("Десерт");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
            for(int i = 0; i<dataGridView4.ColumnCount; i++)
            {
                if (dataGridView4.Rows[i].Visible == true)
                {

                }
            }
        }
    }
}
