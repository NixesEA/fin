﻿namespace fin
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
            this.btnNew_Ill = new System.Windows.Forms.Button();
            this.btnNew_Prem = new System.Windows.Forms.Button();
            this.btnNew_Plus = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idЗаписиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.личныйНомерDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаболеванияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыздоравленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.личныеДанныеБольничныйЛистBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.личныеДанныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new fin.Data();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idЗаписиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.личныйНомерDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.надбавкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.личныеДанныеНадбавкаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idЗаписиDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.личныйНомерDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерПремииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.личныеДанныеПремияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.личныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.семейноеПоложениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоДетейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtSpec = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.расчитатьЗпToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.личныеДанныеОкладBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.личныеДанныеНадбавкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.окладBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.больничныйЛистBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.надбавкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.премияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.личные_данныеTableAdapter = new fin.DataTableAdapters.Личные_данныеTableAdapter();
            this.больничный_листTableAdapter = new fin.DataTableAdapters.Больничный_листTableAdapter();
            this.надбавкаTableAdapter = new fin.DataTableAdapters.НадбавкаTableAdapter();
            this.премияTableAdapter = new fin.DataTableAdapters.ПремияTableAdapter();
            this.окладTableAdapter = new fin.DataTableAdapters.ОкладTableAdapter();
            this.окладBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.личныеДанныеБольничныйЛистBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.личныеДанныеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.личныеДанныеНадбавкаBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.личныеДанныеПремияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.личныеДанныеОкладBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.личныеДанныеНадбавкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.окладBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.больничныйЛистBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.надбавкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.премияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.окладBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew_Ill
            // 
            this.btnNew_Ill.AutoSize = true;
            this.btnNew_Ill.Location = new System.Drawing.Point(1090, 53);
            this.btnNew_Ill.Name = "btnNew_Ill";
            this.btnNew_Ill.Size = new System.Drawing.Size(177, 58);
            this.btnNew_Ill.TabIndex = 55;
            this.btnNew_Ill.Text = "Добавить запись о болезни";
            this.btnNew_Ill.UseVisualStyleBackColor = true;
            this.btnNew_Ill.Click += new System.EventHandler(this.btnNew_Ill_Click);
            // 
            // btnNew_Prem
            // 
            this.btnNew_Prem.AutoSize = true;
            this.btnNew_Prem.Location = new System.Drawing.Point(1090, 528);
            this.btnNew_Prem.Name = "btnNew_Prem";
            this.btnNew_Prem.Size = new System.Drawing.Size(177, 55);
            this.btnNew_Prem.TabIndex = 57;
            this.btnNew_Prem.Text = "Добавить премии";
            this.btnNew_Prem.UseVisualStyleBackColor = true;
            this.btnNew_Prem.Click += new System.EventHandler(this.btnNew_Prem_Click);
            // 
            // btnNew_Plus
            // 
            this.btnNew_Plus.AutoSize = true;
            this.btnNew_Plus.Location = new System.Drawing.Point(1090, 318);
            this.btnNew_Plus.Name = "btnNew_Plus";
            this.btnNew_Plus.Size = new System.Drawing.Size(177, 58);
            this.btnNew_Plus.TabIndex = 56;
            this.btnNew_Plus.Text = "Добавить надбавки";
            this.btnNew_Plus.UseVisualStyleBackColor = true;
            this.btnNew_Plus.Click += new System.EventHandler(this.btnNew_Plus_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView4);
            this.groupBox3.Location = new System.Drawing.Point(660, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 259);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Больничные";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idЗаписиDataGridViewTextBoxColumn,
            this.личныйНомерDataGridViewTextBoxColumn1,
            this.датаЗаболеванияDataGridViewTextBoxColumn,
            this.датаВыздоравленияDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.личныеДанныеБольничныйЛистBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 16);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(418, 240);
            this.dataGridView4.TabIndex = 0;
            // 
            // idЗаписиDataGridViewTextBoxColumn
            // 
            this.idЗаписиDataGridViewTextBoxColumn.DataPropertyName = "id записи";
            this.idЗаписиDataGridViewTextBoxColumn.HeaderText = "id записи";
            this.idЗаписиDataGridViewTextBoxColumn.Name = "idЗаписиDataGridViewTextBoxColumn";
            this.idЗаписиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // личныйНомерDataGridViewTextBoxColumn1
            // 
            this.личныйНомерDataGridViewTextBoxColumn1.DataPropertyName = "Личный номер";
            this.личныйНомерDataGridViewTextBoxColumn1.HeaderText = "Личный номер";
            this.личныйНомерDataGridViewTextBoxColumn1.Name = "личныйНомерDataGridViewTextBoxColumn1";
            this.личныйНомерDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // датаЗаболеванияDataGridViewTextBoxColumn
            // 
            this.датаЗаболеванияDataGridViewTextBoxColumn.DataPropertyName = "Дата заболевания";
            this.датаЗаболеванияDataGridViewTextBoxColumn.HeaderText = "Дата заболевания";
            this.датаЗаболеванияDataGridViewTextBoxColumn.Name = "датаЗаболеванияDataGridViewTextBoxColumn";
            this.датаЗаболеванияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаВыздоравленияDataGridViewTextBoxColumn
            // 
            this.датаВыздоравленияDataGridViewTextBoxColumn.DataPropertyName = "Дата выздоравления";
            this.датаВыздоравленияDataGridViewTextBoxColumn.HeaderText = "Дата выздоравления";
            this.датаВыздоравленияDataGridViewTextBoxColumn.Name = "датаВыздоравленияDataGridViewTextBoxColumn";
            this.датаВыздоравленияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // личныеДанныеБольничныйЛистBindingSource
            // 
            this.личныеДанныеБольничныйЛистBindingSource.DataMember = "Личные данныеБольничный лист";
            this.личныеДанныеБольничныйЛистBindingSource.DataSource = this.личныеДанныеBindingSource;
            // 
            // личныеДанныеBindingSource
            // 
            this.личныеДанныеBindingSource.DataMember = "Личные данные";
            this.личныеДанныеBindingSource.DataSource = this.data;
            // 
            // data
            // 
            this.data.DataSetName = "Data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Location = new System.Drawing.Point(660, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 204);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Надбавки";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idЗаписиDataGridViewTextBoxColumn1,
            this.личныйНомерDataGridViewTextBoxColumn2,
            this.надбавкаDataGridViewTextBoxColumn,
            this.датаНачалаDataGridViewTextBoxColumn,
            this.датаОкончанияDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.личныеДанныеНадбавкаBindingSource1;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 16);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(418, 185);
            this.dataGridView3.TabIndex = 0;
            // 
            // idЗаписиDataGridViewTextBoxColumn1
            // 
            this.idЗаписиDataGridViewTextBoxColumn1.DataPropertyName = "id записи";
            this.idЗаписиDataGridViewTextBoxColumn1.HeaderText = "id записи";
            this.idЗаписиDataGridViewTextBoxColumn1.Name = "idЗаписиDataGridViewTextBoxColumn1";
            this.idЗаписиDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // личныйНомерDataGridViewTextBoxColumn2
            // 
            this.личныйНомерDataGridViewTextBoxColumn2.DataPropertyName = "Личный номер";
            this.личныйНомерDataGridViewTextBoxColumn2.HeaderText = "Личный номер";
            this.личныйНомерDataGridViewTextBoxColumn2.Name = "личныйНомерDataGridViewTextBoxColumn2";
            this.личныйНомерDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // надбавкаDataGridViewTextBoxColumn
            // 
            this.надбавкаDataGridViewTextBoxColumn.DataPropertyName = "Надбавка";
            this.надбавкаDataGridViewTextBoxColumn.HeaderText = "Надбавка";
            this.надбавкаDataGridViewTextBoxColumn.Name = "надбавкаDataGridViewTextBoxColumn";
            this.надбавкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаНачалаDataGridViewTextBoxColumn
            // 
            this.датаНачалаDataGridViewTextBoxColumn.DataPropertyName = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.Name = "датаНачалаDataGridViewTextBoxColumn";
            this.датаНачалаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаОкончанияDataGridViewTextBoxColumn
            // 
            this.датаОкончанияDataGridViewTextBoxColumn.DataPropertyName = "Дата окончания";
            this.датаОкончанияDataGridViewTextBoxColumn.HeaderText = "Дата окончания";
            this.датаОкончанияDataGridViewTextBoxColumn.Name = "датаОкончанияDataGridViewTextBoxColumn";
            this.датаОкончанияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // личныеДанныеНадбавкаBindingSource1
            // 
            this.личныеДанныеНадбавкаBindingSource1.DataMember = "Личные данныеНадбавка";
            this.личныеДанныеНадбавкаBindingSource1.DataSource = this.личныеДанныеBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(660, 512);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 186);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Премии";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idЗаписиDataGridViewTextBoxColumn2,
            this.личныйНомерDataGridViewTextBoxColumn3,
            this.размерПремииDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.личныеДанныеПремияBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(418, 167);
            this.dataGridView2.TabIndex = 14;
            // 
            // idЗаписиDataGridViewTextBoxColumn2
            // 
            this.idЗаписиDataGridViewTextBoxColumn2.DataPropertyName = "id записи";
            this.idЗаписиDataGridViewTextBoxColumn2.HeaderText = "id записи";
            this.idЗаписиDataGridViewTextBoxColumn2.Name = "idЗаписиDataGridViewTextBoxColumn2";
            this.idЗаписиDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // личныйНомерDataGridViewTextBoxColumn3
            // 
            this.личныйНомерDataGridViewTextBoxColumn3.DataPropertyName = "Личный номер";
            this.личныйНомерDataGridViewTextBoxColumn3.HeaderText = "Личный номер";
            this.личныйНомерDataGridViewTextBoxColumn3.Name = "личныйНомерDataGridViewTextBoxColumn3";
            this.личныйНомерDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // размерПремииDataGridViewTextBoxColumn
            // 
            this.размерПремииDataGridViewTextBoxColumn.DataPropertyName = "Размер премии";
            this.размерПремииDataGridViewTextBoxColumn.HeaderText = "Размер премии";
            this.размерПремииDataGridViewTextBoxColumn.Name = "размерПремииDataGridViewTextBoxColumn";
            this.размерПремииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // личныеДанныеПремияBindingSource
            // 
            this.личныеДанныеПремияBindingSource.DataMember = "Личные данныеПремия";
            this.личныеДанныеПремияBindingSource.DataSource = this.личныеДанныеBindingSource;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(62, 214);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(568, 20);
            this.txtSearch.TabIndex = 51;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Поиск:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.личныйНомерDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.семейноеПоложениеDataGridViewTextBoxColumn,
            this.колвоДетейDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.личныеДанныеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(618, 426);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // личныйНомерDataGridViewTextBoxColumn
            // 
            this.личныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Личный номер";
            this.личныйНомерDataGridViewTextBoxColumn.HeaderText = "Личный номер";
            this.личныйНомерDataGridViewTextBoxColumn.Name = "личныйНомерDataGridViewTextBoxColumn";
            this.личныйНомерDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // семейноеПоложениеDataGridViewTextBoxColumn
            // 
            this.семейноеПоложениеDataGridViewTextBoxColumn.DataPropertyName = "Семейное положение";
            this.семейноеПоложениеDataGridViewTextBoxColumn.HeaderText = "Семейное положение";
            this.семейноеПоложениеDataGridViewTextBoxColumn.Name = "семейноеПоложениеDataGridViewTextBoxColumn";
            this.семейноеПоложениеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // колвоДетейDataGridViewTextBoxColumn
            // 
            this.колвоДетейDataGridViewTextBoxColumn.DataPropertyName = "Кол-во детей";
            this.колвоДетейDataGridViewTextBoxColumn.HeaderText = "Кол-во детей";
            this.колвоДетейDataGridViewTextBoxColumn.Name = "колвоДетейDataGridViewTextBoxColumn";
            this.колвоДетейDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.txtCh);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.txtFam);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.textBox3);
            this.panel.Controls.Add(this.txtSpec);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtNomber);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(12, 39);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(344, 169);
            this.panel.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 65;
            this.button1.Text = "Добавить оклад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCh
            // 
            this.txtCh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.личныеДанныеBindingSource, "Кол-во детей", true));
            this.txtCh.Location = new System.Drawing.Point(133, 110);
            this.txtCh.Name = "txtCh";
            this.txtCh.Size = new System.Drawing.Size(196, 20);
            this.txtCh.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кол-во детей";
            // 
            // txtFam
            // 
            this.txtFam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.личныеДанныеBindingSource, "Семейное положение", true));
            this.txtFam.Location = new System.Drawing.Point(133, 84);
            this.txtFam.Name = "txtFam";
            this.txtFam.Size = new System.Drawing.Size(196, 20);
            this.txtFam.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Семейное положение";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.личныеДанныеBindingSource, "Должность", true));
            this.textBox3.Location = new System.Drawing.Point(133, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 20);
            this.textBox3.TabIndex = 5;
            // 
            // txtSpec
            // 
            this.txtSpec.AutoSize = true;
            this.txtSpec.Location = new System.Drawing.Point(5, 59);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(65, 13);
            this.txtSpec.TabIndex = 4;
            this.txtSpec.Text = "Должность";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.личныеДанныеBindingSource, "ФИО", true));
            this.txtName.Location = new System.Drawing.Point(133, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 20);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО";
            // 
            // txtNomber
            // 
            this.txtNomber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.личныеДанныеBindingSource, "Личный номер", true));
            this.txtNomber.Location = new System.Drawing.Point(133, 6);
            this.txtNomber.Name = "txtNomber";
            this.txtNomber.Size = new System.Drawing.Size(196, 20);
            this.txtNomber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Личный номер";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(561, 672);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 23);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(480, 672);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 23);
            this.btnCancel.TabIndex = 61;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(399, 672);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(69, 23);
            this.btnEdit.TabIndex = 60;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(318, 672);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(69, 23);
            this.btnNew.TabIndex = 59;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расчитатьЗпToolStripMenuItem,
            this.обновитьТаблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 63;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // расчитатьЗпToolStripMenuItem
            // 
            this.расчитатьЗпToolStripMenuItem.Name = "расчитатьЗпToolStripMenuItem";
            this.расчитатьЗпToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.расчитатьЗпToolStripMenuItem.Text = "рассчитать з/п";
            this.расчитатьЗпToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьЗпToolStripMenuItem_Click);
            // 
            // обновитьТаблицыToolStripMenuItem
            // 
            this.обновитьТаблицыToolStripMenuItem.Name = "обновитьТаблицыToolStripMenuItem";
            this.обновитьТаблицыToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.обновитьТаблицыToolStripMenuItem.Text = "Обновить таблицы";
            this.обновитьТаблицыToolStripMenuItem.Click += new System.EventHandler(this.обновитьТаблицыToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Оклад";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.личныеДанныеОкладBindingSource, "Оклад", true));
            this.label8.Location = new System.Drawing.Point(458, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 64;
            // 
            // личныеДанныеОкладBindingSource
            // 
            this.личныеДанныеОкладBindingSource.DataMember = "Личные данныеОклад";
            this.личныеДанныеОкладBindingSource.DataSource = this.личныеДанныеBindingSource;
            // 
            // личныеДанныеНадбавкаBindingSource
            // 
            this.личныеДанныеНадбавкаBindingSource.DataMember = "Личные данныеНадбавка";
            this.личныеДанныеНадбавкаBindingSource.DataSource = this.личныеДанныеBindingSource;
            // 
            // окладBindingSource
            // 
            this.окладBindingSource.DataMember = "Оклад";
            this.окладBindingSource.DataSource = this.data;
            // 
            // больничныйЛистBindingSource
            // 
            this.больничныйЛистBindingSource.DataMember = "Больничный лист";
            this.больничныйЛистBindingSource.DataSource = this.data;
            // 
            // надбавкаBindingSource
            // 
            this.надбавкаBindingSource.DataMember = "Надбавка";
            this.надбавкаBindingSource.DataSource = this.data;
            // 
            // премияBindingSource
            // 
            this.премияBindingSource.DataMember = "Премия";
            this.премияBindingSource.DataSource = this.data;
            // 
            // личные_данныеTableAdapter
            // 
            this.личные_данныеTableAdapter.ClearBeforeFill = true;
            // 
            // больничный_листTableAdapter
            // 
            this.больничный_листTableAdapter.ClearBeforeFill = true;
            // 
            // надбавкаTableAdapter
            // 
            this.надбавкаTableAdapter.ClearBeforeFill = true;
            // 
            // премияTableAdapter
            // 
            this.премияTableAdapter.ClearBeforeFill = true;
            // 
            // окладTableAdapter
            // 
            this.окладTableAdapter.ClearBeforeFill = true;
            // 
            // окладBindingSource1
            // 
            this.окладBindingSource1.DataMember = "Оклад";
            this.окладBindingSource1.DataSource = this.data;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 747);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnNew_Ill);
            this.Controls.Add(this.btnNew_Prem);
            this.Controls.Add(this.btnNew_Plus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Личные данные";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.личныеДанныеБольничныйЛистBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.личныеДанныеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.личныеДанныеНадбавкаBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.личныеДанныеПремияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.личныеДанныеОкладBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.личныеДанныеНадбавкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.окладBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.больничныйЛистBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.надбавкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.премияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.окладBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNew_Ill;
        private System.Windows.Forms.Button btnNew_Prem;
        private System.Windows.Forms.Button btnNew_Plus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtCh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtSpec;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private Data data;
        private System.Windows.Forms.BindingSource личныеДанныеBindingSource;
        private DataTableAdapters.Личные_данныеTableAdapter личные_данныеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn личныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn семейноеПоложениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоДетейDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource больничныйЛистBindingSource;
        private DataTableAdapters.Больничный_листTableAdapter больничный_листTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idЗаписиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn личныйНомерDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаболеванияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыздоравленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource надбавкаBindingSource;
        private DataTableAdapters.НадбавкаTableAdapter надбавкаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idЗаписиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn личныйНомерDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn надбавкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource премияBindingSource;
        private DataTableAdapters.ПремияTableAdapter премияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idЗаписиDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn личныйНомерDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерПремииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource окладBindingSource;
        private DataTableAdapters.ОкладTableAdapter окладTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem расчитатьЗпToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьТаблицыToolStripMenuItem;
        private System.Windows.Forms.BindingSource личныеДанныеБольничныйЛистBindingSource;
        private System.Windows.Forms.BindingSource личныеДанныеНадбавкаBindingSource1;
        private System.Windows.Forms.BindingSource личныеДанныеПремияBindingSource;
        private System.Windows.Forms.BindingSource личныеДанныеНадбавкаBindingSource;
        private System.Windows.Forms.BindingSource окладBindingSource1;
        private System.Windows.Forms.BindingSource личныеДанныеОкладBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

