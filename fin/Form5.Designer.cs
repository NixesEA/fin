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
            this.личныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.окладDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.премииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.надбавкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вычетЗаБолезниDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итогоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расчетЗпBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new fin.appData();
            this.расчет_з_пTableAdapter = new fin.appDataTableAdapters.Расчет_з_пTableAdapter();
            this.appDataa = new fin.appDataa();
            this.расчетЗпBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.расчет_з_пTableAdapter1 = new fin.appDataaTableAdapters.Расчет_з_пTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расчетЗпBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расчетЗпBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.личныйНомерDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.окладDataGridViewTextBoxColumn,
            this.премииDataGridViewTextBoxColumn,
            this.надбавкиDataGridViewTextBoxColumn,
            this.вычетЗаБолезниDataGridViewTextBoxColumn,
            this.итогоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.расчетЗпBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // личныйНомерDataGridViewTextBoxColumn
            // 
            this.личныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Личный номер";
            this.личныйНомерDataGridViewTextBoxColumn.HeaderText = "Личный номер";
            this.личныйНомерDataGridViewTextBoxColumn.Name = "личныйНомерDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // окладDataGridViewTextBoxColumn
            // 
            this.окладDataGridViewTextBoxColumn.DataPropertyName = "Оклад";
            this.окладDataGridViewTextBoxColumn.HeaderText = "Оклад";
            this.окладDataGridViewTextBoxColumn.Name = "окладDataGridViewTextBoxColumn";
            // 
            // премииDataGridViewTextBoxColumn
            // 
            this.премииDataGridViewTextBoxColumn.DataPropertyName = "Премии";
            this.премииDataGridViewTextBoxColumn.HeaderText = "Премии";
            this.премииDataGridViewTextBoxColumn.Name = "премииDataGridViewTextBoxColumn";
            // 
            // надбавкиDataGridViewTextBoxColumn
            // 
            this.надбавкиDataGridViewTextBoxColumn.DataPropertyName = "Надбавки";
            this.надбавкиDataGridViewTextBoxColumn.HeaderText = "Надбавки";
            this.надбавкиDataGridViewTextBoxColumn.Name = "надбавкиDataGridViewTextBoxColumn";
            // 
            // вычетЗаБолезниDataGridViewTextBoxColumn
            // 
            this.вычетЗаБолезниDataGridViewTextBoxColumn.DataPropertyName = "Вычет за болезни";
            this.вычетЗаБолезниDataGridViewTextBoxColumn.HeaderText = "Вычет за болезни";
            this.вычетЗаБолезниDataGridViewTextBoxColumn.Name = "вычетЗаБолезниDataGridViewTextBoxColumn";
            // 
            // итогоDataGridViewTextBoxColumn
            // 
            this.итогоDataGridViewTextBoxColumn.DataPropertyName = "Итого";
            this.итогоDataGridViewTextBoxColumn.HeaderText = "Итого";
            this.итогоDataGridViewTextBoxColumn.Name = "итогоDataGridViewTextBoxColumn";
            // 
            // расчетЗпBindingSource
            // 
            this.расчетЗпBindingSource.DataMember = "Расчет з/п";
            this.расчетЗпBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "appData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // расчет_з_пTableAdapter
            // 
            this.расчет_з_пTableAdapter.ClearBeforeFill = true;
            // 
            // appDataa
            // 
            this.appDataa.DataSetName = "appDataa";
            this.appDataa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // расчетЗпBindingSource1
            // 
            this.расчетЗпBindingSource1.DataMember = "Расчет з/п";
            this.расчетЗпBindingSource1.DataSource = this.appDataa;
            // 
            // расчет_з_пTableAdapter1
            // 
            this.расчет_з_пTableAdapter1.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.расчетЗпBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расчетЗпBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private appData appData;
        private System.Windows.Forms.BindingSource расчетЗпBindingSource;
        private appDataTableAdapters.Расчет_з_пTableAdapter расчет_з_пTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn личныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn окладDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn премииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn надбавкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вычетЗаБолезниDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn итогоDataGridViewTextBoxColumn;
        private appDataa appDataa;
        private System.Windows.Forms.BindingSource расчетЗпBindingSource1;
        private appDataaTableAdapters.Расчет_з_пTableAdapter расчет_з_пTableAdapter1;
    }
}