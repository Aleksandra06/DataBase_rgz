using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Drawing.Printing;

namespace DataBase_rgz
{
    public struct MENU
    {
        public string snack;
        public string one_dish;
        public string tho_dish;
        public string dessert;
    }

    public partial class Form1 : Form
    {
        Word._Application oWord = new Word.Application();

        MENU menu;
        int rt = -1;

        public Form1()
        {
            InitializeComponent();
            menu.snack = "?";
            menu.dessert = "?";
            menu.one_dish = "?";
            menu.tho_dish = "?";
            LoadData();
           
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
                        ((int)dataGridView5.Rows[j].Cells[1].Value >= (int)dataGridView3.Rows[num].Cells[1].Value))
                    {
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
                pictureBox1.Visible = true;
                dataGridView4.Visible = false;
                dataGridView5.Visible = false;
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

        private void data_label()
        {

        } 

        private void button1_Click(object sender, EventArgs e)
        {
            rt++;
            if (textBoxKolChel.Text.ToString() != "")
            {
                int kol = (int)Math.Ceiling(Convert.ToDouble(textBoxKolChel.Text) / 5);
                LoadData();
                if (dataGridView4.SortOrder != SortOrder.Ascending)
                    dataGridView4.Sort(dataGridView4.Columns[2], ListSortDirection.Descending);
                int mz1 = 0, m11 = 0, m21 = 0, md1 = 0;
                while ((dataGridView4.Rows[mz1].Cells[2].Value.ToString() != "Закуска") && (mz1 < dataGridView4.RowCount - 1))
                    mz1++;
                while ((dataGridView4.Rows[m11].Cells[2].Value.ToString() != "Первое") && (m11 < dataGridView4.RowCount - 1))
                    m11++;
                while ((dataGridView4.Rows[m21].Cells[2].Value.ToString() != "Второе") && (m21 < dataGridView4.RowCount - 1))
                    m21++;
                while ((dataGridView4.Rows[md1].Cells[2].Value.ToString() != "Десерт") && (md1 < dataGridView4.RowCount - 1))
                    md1++;
                int mz2 = mz1, m12 = m11, m22 = m21, md2 = md1;
                while ((dataGridView4.Rows[mz2].Cells[2].Value.ToString() == "Закуска") && (mz2 < dataGridView4.RowCount - 1))
                    mz2++;
                while ((dataGridView4.Rows[m12].Cells[2].Value.ToString() == "Первое") && (m12 < dataGridView4.RowCount - 1))
                    m12++;
                while ((dataGridView4.Rows[m22].Cells[2].Value.ToString() == "Второе") && (m22 < dataGridView4.RowCount - 1))
                    m22++;
                while ((dataGridView4.Rows[md2].Cells[2].Value.ToString() == "Десерт") && (md2 < dataGridView4.RowCount - 1))
                    md2++;
                if (dataGridView4.Rows[mz2].Cells[2].Value.ToString() == "Закуска") mz2++;
                if (dataGridView4.Rows[m12].Cells[2].Value.ToString() == "Первое") m12++;
                if (dataGridView4.Rows[m22].Cells[2].Value.ToString() == "Второе") m22++;
                if (dataGridView4.Rows[md2].Cells[2].Value.ToString() == "Десерт") md2++;
                bool flag;
                bool flags = false;
                int i = mz1;
                while ((i <= mz2) && (flags == false))
                {
                    while ((dataGridView4.Rows[i].Visible != true) && (i <= mz2))
                        i++;
                    flag = false;
                    while ((flag == false) && (i <= mz2))
                    {
                        dataGridView4.CurrentCell = dataGridView4.Rows[i].Cells[1];
                        flag = true;
                        int r = 0;
                        while ((r < dataGridView5.RowCount) && (flag == true))
                        {
                            int num = -1;
                            do
                            {
                                num++;
                            } while ((dataGridView5.Rows[r].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString())
                                    && (num < dataGridView3.RowCount - 1));
                            if ((dataGridView5.Rows[r].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString()) ||
                                ((int)dataGridView5.Rows[r].Cells[1].Value * kol >= (int)dataGridView3.Rows[num].Cells[1].Value))
                            {
                                flag = false;
                            }
                            r++;
                        }
                        i++;
                    }
                    if (flag == true)
                    {
                        for (int w = 0; w < dataGridView5.RowCount; w++)
                        {
                            int num = -1;
                            do
                            {
                                num++;
                            } while ((dataGridView5.Rows[w].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString())
                                    && (num < dataGridView3.RowCount - 1));
                            if (dataGridView5.Rows[w].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString())
                            {
                                dataGridView3.Rows[num].Cells[1].Value = ((int)dataGridView3.Rows[num].Cells[1].Value - kol * (int)dataGridView5.Rows[w].Cells[1].Value).ToString();
                            }
                        }
                        menu.snack = dataGridView4.Rows[i].Cells[1].Value.ToString();
                        int j = m11;
                        while ((j <= m12) && (flags == false))
                        {
                            while ((dataGridView4.Rows[j].Visible == false) && (j <= m12))
                                j++;
                            while ((flag == false) && (j <= m12))
                            {
                                dataGridView4.CurrentCell = dataGridView4.Rows[j].Cells[1];
                                flag = true;
                                int r = 0;
                                while ((r < dataGridView5.RowCount) && (flag == true))
                                {
                                    int num = -1;
                                    do
                                    {
                                        num++;
                                    } while ((dataGridView5.Rows[r].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString()) &&
                                            (num < dataGridView3.RowCount - 1));
                                    if ((dataGridView5.Rows[r].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString()) ||
                                        ((int)dataGridView5.Rows[r].Cells[1].Value * kol >= (int)dataGridView3.Rows[num].Cells[1].Value))
                                    {
                                        flag = false;
                                    }
                                    r++;
                                }
                                j++;
                            }
                            if (flag == true)
                            {
                                for (int w = 0; w < dataGridView5.RowCount; w++)
                                {
                                    int num = -1;
                                    do
                                    {
                                        num++;
                                    } while ((dataGridView5.Rows[w].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString())
                                            && (num < dataGridView3.RowCount - 1));
                                    if (dataGridView5.Rows[w].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString())
                                    {
                                        dataGridView3.Rows[num].Cells[1].Value = ((int)dataGridView3.Rows[num].Cells[1].Value - kol * (int)dataGridView5.Rows[w].Cells[1].Value).ToString();
                                    }
                                }
                                menu.one_dish = dataGridView4.Rows[j].Cells[1].Value.ToString();
                                int k = m21;
                                while ((k <= m22) && (flags == false))
                                {
                                    while ((dataGridView4.Rows[k].Visible == false) && (k <= m22))
                                        k++;
                                    while ((flag == false) && (k <= m22))
                                    {
                                        dataGridView4.CurrentCell = dataGridView4.Rows[k].Cells[1];
                                        flag = true;
                                        int r = 0;
                                        while ((r < dataGridView5.RowCount) && (flag == true))
                                        {
                                            int num = -1;
                                            do
                                            {
                                                num++;
                                            } while ((dataGridView5.Rows[r].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString()) &&
                                                    (num < dataGridView3.RowCount - 1));
                                            if ((dataGridView5.Rows[r].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString()) ||
                                                ((int)dataGridView5.Rows[r].Cells[1].Value * kol >= (int)dataGridView3.Rows[num].Cells[1].Value))
                                            {
                                                flag = false;
                                            }
                                            r++;
                                        }
                                        k++;
                                    }
                                    if (flag == true)
                                    {
                                        for (int w = 0; w < dataGridView5.RowCount; w++)
                                        {
                                            int num = -1;
                                            do
                                            {
                                                num++;
                                            } while ((dataGridView5.Rows[w].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString())
                                                    && (num < dataGridView3.RowCount - 1));
                                            if (dataGridView5.Rows[w].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString())
                                            {
                                                dataGridView3.Rows[num].Cells[1].Value = ((int)dataGridView3.Rows[num].Cells[1].Value - kol * (int)dataGridView5.Rows[w].Cells[1].Value).ToString();
                                            }
                                        }
                                        menu.tho_dish = dataGridView4.Rows[k].Cells[1].Value.ToString();
                                        int l = md1;
                                        while ((l <= md2) && (flags == false))
                                        {
                                            while ((dataGridView4.Rows[l].Visible == false) && (l <= md2))
                                                l++;
                                            while ((flag == false) && (l <= md2))
                                            {
                                                dataGridView4.CurrentCell = dataGridView4.Rows[k].Cells[1];
                                                flag = true;
                                                int r = 0;
                                                while ((r < dataGridView5.RowCount) && (flag == true))
                                                {
                                                    int num = -1;
                                                    do
                                                    {
                                                        num++;
                                                    } while ((dataGridView5.Rows[r].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString()) &&
                                                            (num < dataGridView3.RowCount - 1));
                                                    if ((dataGridView5.Rows[r].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString()) ||
                                                        ((int)dataGridView5.Rows[r].Cells[1].Value * kol >= (int)dataGridView3.Rows[num].Cells[1].Value))
                                                    {
                                                        flag = false;
                                                    }
                                                    r++;
                                                }
                                                l++;
                                            }
                                            if (flag == true)
                                            {
                                                menu.dessert = dataGridView4.Rows[l].Cells[1].Value.ToString();
                                                flags = true;
                                            }
                                        }
                                    }
                                    if (flag == false)
                                    {
                                        dataGridView4.CurrentCell = dataGridView4.Rows[k].Cells[1];
                                        for (int w = 0; w < dataGridView5.RowCount; w++)
                                        {
                                            int num = -1;
                                            do
                                            {
                                                num++;
                                            } while ((dataGridView5.Rows[w].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString())
                                                    && (num < dataGridView3.RowCount - 1));
                                            if (dataGridView5.Rows[w].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString())
                                            {
                                                dataGridView3.Rows[num].Cells[1].Value = ((int)dataGridView3.Rows[num].Cells[1].Value + kol * (int)dataGridView5.Rows[w].Cells[1].Value).ToString();
                                            }
                                        }
                                    }
                                }
                            }
                            if (flag == false)
                            {
                                dataGridView4.CurrentCell = dataGridView4.Rows[j].Cells[1];
                                for (int w = 0; w < dataGridView5.RowCount; w++)
                                {
                                    int num = -1;
                                    do
                                    {
                                        num++;
                                    } while ((dataGridView5.Rows[w].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString())
                                            && (num < dataGridView3.RowCount - 1));
                                    if (dataGridView5.Rows[w].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString())
                                    {
                                        dataGridView3.Rows[num].Cells[1].Value = ((int)dataGridView3.Rows[num].Cells[1].Value + kol * (int)dataGridView5.Rows[w].Cells[1].Value).ToString();
                                    }
                                }
                            }

                        }
                        if (flag == false)
                        {
                            dataGridView4.CurrentCell = dataGridView4.Rows[i].Cells[1];
                            for (int w = 0; w < dataGridView5.RowCount; w++)
                            {
                                int num = -1;
                                do
                                {
                                    num++;
                                } while ((dataGridView5.Rows[w].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString())
                                        && (num < dataGridView3.RowCount - 1));
                                if (dataGridView5.Rows[w].Cells[0].Value.ToString() != dataGridView3.Rows[num].Cells[0].Value.ToString())
                                {
                                    dataGridView3.Rows[num].Cells[1].Value = ((int)dataGridView3.Rows[num].Cells[1].Value + kol * (int)dataGridView5.Rows[w].Cells[1].Value).ToString();
                                }
                            }
                        }

                    }
                }
                if (rt == 0) button1_Click(sender,  e);
                if (flags == true)
                {
                    label10.Text = menu.snack;
                    label11.Text = menu.one_dish;
                    label12.Text = menu.tho_dish;
                    label13.Text = menu.dessert;
                }
                else
                {
                    label10.Text = "?";
                    label11.Text = "?";
                    label12.Text = "?";
                    label13.Text = "?";
                }
            }
            if (textBox3.Text.ToString() != "")
                groupBox1.Text = "Меню обеда на " + textBox3.Text.ToString();
            else
                groupBox1.Text = "Меню обеда";
        }

        private Word._Document GetDoc(string path)
        {
            Word._Document oDoc = oWord.Documents.Add(path);
            SetTemplate(oDoc);
            return oDoc;
        }

        private void SetTemplate(Word._Document oDoc)
        {
            oDoc.Bookmarks["date"].Range.Text = textBox3.Text;
            oDoc.Bookmarks["snack"].Range.Text = menu.snack;
            oDoc.Bookmarks["one_dish"].Range.Text = menu.one_dish;
            oDoc.Bookmarks["tho_dish"].Range.Text = menu.tho_dish;
            oDoc.Bookmarks["dessert"].Range.Text = menu.dessert;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (menu.snack != "?" && textBox3.Text != "")
            {
                Word._Document oDoc = GetDoc(Environment.CurrentDirectory + "\\menu.dotx");
                oDoc.SaveAs(FileName: Environment.CurrentDirectory + "\\Menu.docx");
                oDoc.Close();
                PrintDocument D = new PrintDocument();
                D.DocumentName = Environment.CurrentDirectory + "\\Menu.docx";
                D.Print();
            }
            else
            {
                if (textBox3.Text == "")
                    MessageBox.Show("Введите дату", "Ошибка");
                else
                    MessageBox.Show("Невозможно составить меню из данных продуктов или меню не было составлено", "Ошибка");
            }
        }
    }
}
