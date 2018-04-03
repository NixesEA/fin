namespace fin
{
    partial class Form2
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtSpec = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appData = new fin.appData();
            this.больничныйЛистBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.больничный_листTableAdapter = new fin.appDataTableAdapters.Больничный_листTableAdapter();
            this.idЗаписиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.личныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаболеванияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыздоравленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.больничныйЛистBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(255, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(174, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 172);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(69, 23);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 172);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(69, 23);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.textBox3);
            this.panel.Controls.Add(this.txtSpec);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtNomber);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(12, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(344, 142);
            this.panel.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.больничныйЛистBindingSource, "Дата выздоравления", true));
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
            this.txtSpec.Size = new System.Drawing.Size(116, 13);
            this.txtSpec.TabIndex = 4;
            this.txtSpec.Text = "Дата выздоровления";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.больничныйЛистBindingSource, "Дата заболевания", true));
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
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата заболевания";
            // 
            // txtNomber
            // 
            this.txtNomber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.больничныйЛистBindingSource, "Личный номер", true));
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idЗаписиDataGridViewTextBoxColumn,
            this.личныйНомерDataGridViewTextBoxColumn,
            this.датаЗаболеванияDataGridViewTextBoxColumn,
            this.датаВыздоравленияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.больничныйЛистBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 218);
            this.dataGridView1.TabIndex = 20;
            // 
            // appData
            // 
            this.appData.DataSetName = "appData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // больничныйЛистBindingSource
            // 
            this.больничныйЛистBindingSource.DataMember = "Больничный лист";
            this.больничныйЛистBindingSource.DataSource = this.appData;
            // 
            // больничный_листTableAdapter
            // 
            this.больничный_листTableAdapter.ClearBeforeFill = true;
            // 
            // idЗаписиDataGridViewTextBoxColumn
            // 
            this.idЗаписиDataGridViewTextBoxColumn.DataPropertyName = "id записи";
            this.idЗаписиDataGridViewTextBoxColumn.HeaderText = "id записи";
            this.idЗаписиDataGridViewTextBoxColumn.Name = "idЗаписиDataGridViewTextBoxColumn";
            // 
            // личныйНомерDataGridViewTextBoxColumn
            // 
            this.личныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Личный номер";
            this.личныйНомерDataGridViewTextBoxColumn.HeaderText = "Личный номер";
            this.личныйНомерDataGridViewTextBoxColumn.Name = "личныйНомерDataGridViewTextBoxColumn";
            // 
            // датаЗаболеванияDataGridViewTextBoxColumn
            // 
            this.датаЗаболеванияDataGridViewTextBoxColumn.DataPropertyName = "Дата заболевания";
            this.датаЗаболеванияDataGridViewTextBoxColumn.HeaderText = "Дата заболевания";
            this.датаЗаболеванияDataGridViewTextBoxColumn.Name = "датаЗаболеванияDataGridViewTextBoxColumn";
            // 
            // датаВыздоравленияDataGridViewTextBoxColumn
            // 
            this.датаВыздоравленияDataGridViewTextBoxColumn.DataPropertyName = "Дата выздоравления";
            this.датаВыздоравленияDataGridViewTextBoxColumn.HeaderText = "Дата выздоравления";
            this.датаВыздоравленияDataGridViewTextBoxColumn.Name = "датаВыздоравленияDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Больничные";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.больничныйЛистBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtSpec;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private appData appData;
        private System.Windows.Forms.BindingSource больничныйЛистBindingSource;
        private appDataTableAdapters.Больничный_листTableAdapter больничный_листTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idЗаписиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn личныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаболеванияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыздоравленияDataGridViewTextBoxColumn;
    }
}