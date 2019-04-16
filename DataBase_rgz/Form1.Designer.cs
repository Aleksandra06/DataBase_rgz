namespace DataBase_rgz
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxKolChel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.блюдоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.блюдоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipesDataSet = new DataBase_rgz.recipesDataSet();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колво5челDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.блюдоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.продуктDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктыестьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataSet = new DataBase_rgz.productsDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.блюдоTableAdapter = new DataBase_rgz.recipesDataSetTableAdapters.БлюдоTableAdapter();
            this.продуктыTableAdapter = new DataBase_rgz.recipesDataSetTableAdapters.ПродуктыTableAdapter();
            this.продукты_естьTableAdapter = new DataBase_rgz.productsDataSetTableAdapters.Продукты_естьTableAdapter();
            this.блюдоDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колво5челDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataSet)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыестьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(808, 495);
            this.TabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.OldLace;
            this.tabPage1.Controls.Add(this.textBoxKolChel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(800, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Меню";
            // 
            // textBoxKolChel
            // 
            this.textBoxKolChel.BackColor = System.Drawing.Color.Ivory;
            this.textBoxKolChel.Location = new System.Drawing.Point(6, 20);
            this.textBoxKolChel.MaxLength = 4;
            this.textBoxKolChel.Name = "textBoxKolChel";
            this.textBoxKolChel.Size = new System.Drawing.Size(100, 27);
            this.textBoxKolChel.TabIndex = 3;
            this.textBoxKolChel.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во человек";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(800, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск блюда";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl2.Location = new System.Drawing.Point(0, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(794, 463);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(786, 431);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "По названию/категории";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(426, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 29);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(426, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(422, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Поиск по категории блюда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(422, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поиск по названию блюда";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.блюдоDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.блюдоBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(373, 424);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Width = 57;
            // 
            // блюдоDataGridViewTextBoxColumn
            // 
            this.блюдоDataGridViewTextBoxColumn.DataPropertyName = "Блюдо";
            this.блюдоDataGridViewTextBoxColumn.HeaderText = "Блюдо";
            this.блюдоDataGridViewTextBoxColumn.Name = "блюдоDataGridViewTextBoxColumn";
            this.блюдоDataGridViewTextBoxColumn.ReadOnly = true;
            this.блюдоDataGridViewTextBoxColumn.Width = 71;
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.ReadOnly = true;
            this.категорияDataGridViewTextBoxColumn.Width = 99;
            // 
            // блюдоBindingSource
            // 
            this.блюдоBindingSource.DataMember = "Блюдо";
            this.блюдоBindingSource.DataSource = this.recipesDataSet;
            // 
            // recipesDataSet
            // 
            this.recipesDataSet.DataSetName = "recipesDataSet";
            this.recipesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Azure;
            this.tabPage5.Controls.Add(this.textBox3);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.dataGridView2);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(786, 431);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "По продукту";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(568, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 29);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(564, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Продукт:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn1,
            this.продуктDataGridViewTextBoxColumn,
            this.колво5челDataGridViewTextBoxColumn,
            this.блюдоDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.продуктыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(540, 411);
            this.dataGridView2.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn1
            // 
            this.кодDataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn1.Name = "кодDataGridViewTextBoxColumn1";
            this.кодDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn1.Width = 57;
            // 
            // продуктDataGridViewTextBoxColumn
            // 
            this.продуктDataGridViewTextBoxColumn.DataPropertyName = "Продукт";
            this.продуктDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.продуктDataGridViewTextBoxColumn.Name = "продуктDataGridViewTextBoxColumn";
            this.продуктDataGridViewTextBoxColumn.ReadOnly = true;
            this.продуктDataGridViewTextBoxColumn.Width = 85;
            // 
            // колво5челDataGridViewTextBoxColumn
            // 
            this.колво5челDataGridViewTextBoxColumn.DataPropertyName = "Кол-во/5чел";
            this.колво5челDataGridViewTextBoxColumn.HeaderText = "Кол-во/5чел";
            this.колво5челDataGridViewTextBoxColumn.Name = "колво5челDataGridViewTextBoxColumn";
            this.колво5челDataGridViewTextBoxColumn.ReadOnly = true;
            this.колво5челDataGridViewTextBoxColumn.Width = 110;
            // 
            // блюдоDataGridViewTextBoxColumn1
            // 
            this.блюдоDataGridViewTextBoxColumn1.DataPropertyName = "Блюдо";
            this.блюдоDataGridViewTextBoxColumn1.HeaderText = "Блюдо";
            this.блюдоDataGridViewTextBoxColumn1.Name = "блюдоDataGridViewTextBoxColumn1";
            this.блюдоDataGridViewTextBoxColumn1.ReadOnly = true;
            this.блюдоDataGridViewTextBoxColumn1.Width = 71;
            // 
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "Продукты";
            this.продуктыBindingSource.DataSource = this.recipesDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightYellow;
            this.tabPage3.Controls.Add(this.dataGridView4);
            this.tabPage3.Controls.Add(this.radioButton4);
            this.tabPage3.Controls.Add(this.radioButton3);
            this.tabPage3.Controls.Add(this.radioButton2);
            this.tabPage3.Controls.Add(this.radioButton1);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(800, 463);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Поиск по продуктам";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.блюдоDataGridViewTextBoxColumn2,
            this.продуктDataGridViewTextBoxColumn2,
            this.колво5челDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.продуктыBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(299, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.Size = new System.Drawing.Size(320, 454);
            this.dataGridView4.TabIndex = 13;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(658, 156);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(77, 25);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Десерт";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(658, 125);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 25);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Второе";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(658, 94);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 25);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Первое";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(658, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 25);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Закуска";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.продуктDataGridViewTextBoxColumn1,
            this.колвоDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.продуктыестьBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(290, 454);
            this.dataGridView3.TabIndex = 8;
            // 
            // продуктDataGridViewTextBoxColumn1
            // 
            this.продуктDataGridViewTextBoxColumn1.DataPropertyName = "Продукт";
            this.продуктDataGridViewTextBoxColumn1.HeaderText = "Продукт";
            this.продуктDataGridViewTextBoxColumn1.Name = "продуктDataGridViewTextBoxColumn1";
            this.продуктDataGridViewTextBoxColumn1.Width = 85;
            // 
            // колвоDataGridViewTextBoxColumn
            // 
            this.колвоDataGridViewTextBoxColumn.DataPropertyName = "Кол-во";
            this.колвоDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.колвоDataGridViewTextBoxColumn.Name = "колвоDataGridViewTextBoxColumn";
            this.колвоDataGridViewTextBoxColumn.Width = 77;
            // 
            // продуктыестьBindingSource
            // 
            this.продуктыестьBindingSource.DataMember = "Продукты_есть";
            this.продуктыестьBindingSource.DataSource = this.productsDataSet;
            // 
            // productsDataSet
            // 
            this.productsDataSet.DataSetName = "productsDataSet";
            this.productsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(654, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Категория";
            // 
            // блюдоTableAdapter
            // 
            this.блюдоTableAdapter.ClearBeforeFill = true;
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // продукты_естьTableAdapter
            // 
            this.продукты_естьTableAdapter.ClearBeforeFill = true;
            // 
            // блюдоDataGridViewTextBoxColumn2
            // 
            this.блюдоDataGridViewTextBoxColumn2.DataPropertyName = "Блюдо";
            this.блюдоDataGridViewTextBoxColumn2.HeaderText = "Блюдо";
            this.блюдоDataGridViewTextBoxColumn2.Name = "блюдоDataGridViewTextBoxColumn2";
            this.блюдоDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // продуктDataGridViewTextBoxColumn2
            // 
            this.продуктDataGridViewTextBoxColumn2.DataPropertyName = "Продукт";
            this.продуктDataGridViewTextBoxColumn2.HeaderText = "Продукт";
            this.продуктDataGridViewTextBoxColumn2.Name = "продуктDataGridViewTextBoxColumn2";
            this.продуктDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // колво5челDataGridViewTextBoxColumn1
            // 
            this.колво5челDataGridViewTextBoxColumn1.DataPropertyName = "Кол-во/5чел";
            this.колво5челDataGridViewTextBoxColumn1.HeaderText = "Кол-во/5чел";
            this.колво5челDataGridViewTextBoxColumn1.Name = "колво5челDataGridViewTextBoxColumn1";
            this.колво5челDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(826, 510);
            this.Controls.Add(this.TabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Составитель меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.блюдоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataSet)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыестьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxKolChel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage5;
        private recipesDataSet recipesDataSet;
        private System.Windows.Forms.BindingSource блюдоBindingSource;
        private recipesDataSetTableAdapters.БлюдоTableAdapter блюдоTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn блюдоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private recipesDataSetTableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn продуктDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колво5челDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn блюдоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private productsDataSet productsDataSet;
        private System.Windows.Forms.BindingSource продуктыестьBindingSource;
        private productsDataSetTableAdapters.Продукты_естьTableAdapter продукты_естьTableAdapter;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn продуктDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn блюдоDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn продуктDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn колво5челDataGridViewTextBoxColumn1;
    }
}

