namespace fin
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.расчетЗПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new fin.Data();
            this.расчетЗПBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.личныеДанныеЗапросBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расчет_З_ПTableAdapter = new fin.DataTableAdapters.расчет_З_ПTableAdapter();
            this.личныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.окладDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.премияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.надбавкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вычетЗаБолезниDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расчетЗПBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расчетЗПBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.личныеДанныеЗапросBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.окладDataGridViewTextBoxColumn,
            this.премияDataGridViewTextBoxColumn,
            this.надбавкиDataGridViewTextBoxColumn,
            this.вычетЗаБолезниDataGridViewTextBoxColumn,
            this.зПDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.расчетЗПBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // расчетЗПBindingSource
            // 
            this.расчетЗПBindingSource.DataMember = "расчет З/П";
            this.расчетЗПBindingSource.DataSource = this.data;
            // 
            // data
            // 
            this.data.DataSetName = "Data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // расчет_З_ПTableAdapter
            // 
            this.расчет_З_ПTableAdapter.ClearBeforeFill = true;
            // 
            // личныйНомерDataGridViewTextBoxColumn
            // 
            this.личныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Личный номер";
            this.личныйНомерDataGridViewTextBoxColumn.HeaderText = "Личный номер";
            this.личныйНомерDataGridViewTextBoxColumn.Name = "личныйНомерDataGridViewTextBoxColumn";
            this.личныйНомерDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // окладDataGridViewTextBoxColumn
            // 
            this.окладDataGridViewTextBoxColumn.DataPropertyName = "Оклад";
            this.окладDataGridViewTextBoxColumn.HeaderText = "Оклад";
            this.окладDataGridViewTextBoxColumn.Name = "окладDataGridViewTextBoxColumn";
            this.окладDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // премияDataGridViewTextBoxColumn
            // 
            this.премияDataGridViewTextBoxColumn.DataPropertyName = "Премия";
            this.премияDataGridViewTextBoxColumn.HeaderText = "Премия";
            this.премияDataGridViewTextBoxColumn.Name = "премияDataGridViewTextBoxColumn";
            this.премияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // надбавкиDataGridViewTextBoxColumn
            // 
            this.надбавкиDataGridViewTextBoxColumn.DataPropertyName = "Надбавки";
            this.надбавкиDataGridViewTextBoxColumn.HeaderText = "Надбавки";
            this.надбавкиDataGridViewTextBoxColumn.Name = "надбавкиDataGridViewTextBoxColumn";
            this.надбавкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // вычетЗаБолезниDataGridViewTextBoxColumn
            // 
            this.вычетЗаБолезниDataGridViewTextBoxColumn.DataPropertyName = "Вычет за болезни";
            this.вычетЗаБолезниDataGridViewTextBoxColumn.HeaderText = "Вычет за болезни";
            this.вычетЗаБолезниDataGridViewTextBoxColumn.Name = "вычетЗаБолезниDataGridViewTextBoxColumn";
            this.вычетЗаБолезниDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // зПDataGridViewTextBoxColumn
            // 
            this.зПDataGridViewTextBoxColumn.DataPropertyName = "З/П";
            this.зПDataGridViewTextBoxColumn.HeaderText = "З/П";
            this.зПDataGridViewTextBoxColumn.Name = "зПDataGridViewTextBoxColumn";
            this.зПDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расчетЗПBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расчетЗПBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.личныеДанныеЗапросBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource личныеДанныеЗапросBindingSource;
        private System.Windows.Forms.BindingSource расчетЗПBindingSource5;
        private Data data;
        private System.Windows.Forms.BindingSource расчетЗПBindingSource;
        private DataTableAdapters.расчет_З_ПTableAdapter расчет_З_ПTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn личныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn окладDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn премияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn надбавкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вычетЗаБолезниDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
    }
}