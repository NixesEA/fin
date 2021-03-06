﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fin
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel.Enabled = false;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "data.Оклад". При необходимости она может быть перемещена или удалена.
            this.окладTableAdapter.Fill(this.data.Оклад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data.Премия". При необходимости она может быть перемещена или удалена.
            this.премияTableAdapter.Fill(this.data.Премия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data.Надбавка". При необходимости она может быть перемещена или удалена.
            this.надбавкаTableAdapter.Fill(this.data.Надбавка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data.Больничный_лист". При необходимости она может быть перемещена или удалена.
            this.больничный_листTableAdapter.Fill(this.data.Больничный_лист);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data.Личные_данные". При необходимости она может быть перемещена или удалена.
            this.личные_данныеTableAdapter.Fill(this.data.Личные_данные);
           
        }

        //поиск
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    this.личные_данныеTableAdapter.Fill(this.data.Личные_данные);
                    //личныеДанныеBindingSource.DataSource = this.appData.Личные_данные;
                    dataGridView1.DataSource = личныеДанныеBindingSource;
                }
                else
                {
                    var query = from o in this.data.Личные_данные
                                where Convert.ToString(o.Личный_номер).Contains(txtSearch.Text) || o.Должность == txtSearch.Text || o.Семейное_положение == txtSearch.Text || o.ФИО.Contains(txtSearch.Text)
                                select o;
                    //личныеДанныеBindingSource.DataSource = query.ToList();
                    dataGridView1.DataSource = query.ToList();

                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                if (MessageBox.Show("Удалить запись?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    личныеДанныеBindingSource.RemoveCurrent();
            }
        }

        //личные данные
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtName.Focus();
                this.data.Личные_данные.AddЛичные_данныеRow(this.data.Личные_данные.NewЛичные_данныеRow());
                личныеДанныеBindingSource.MoveLast();
  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                личныеДанныеBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            личныеДанныеBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                личныеДанныеBindingSource.EndEdit();
                личные_данныеTableAdapter.Update(this.data.Личные_данные);
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                личныеДанныеBindingSource.ResetBindings(false);
            }
        }

        //Больничные
        private void btnNew_Ill_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        //Надбавки
        private void btnNew_Plus_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        //Премии
        private void btnNew_Prem_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }

        //рассчет
        private void рассчитатьЗпToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void обновитьТаблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data.Оклад". При необходимости она может быть перемещена или удалена.
            this.окладTableAdapter.Fill(this.data.Оклад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data.Премия". При необходимости она может быть перемещена или удалена.
            this.премияTableAdapter.Fill(this.data.Премия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data.Надбавка". При необходимости она может быть перемещена или удалена.
            this.надбавкаTableAdapter.Fill(this.data.Надбавка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data.Больничный_лист". При необходимости она может быть перемещена или удалена.
            this.больничный_листTableAdapter.Fill(this.data.Больничный_лист);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data.Личные_данные". При необходимости она может быть перемещена или удалена.
            this.личные_данныеTableAdapter.Fill(this.data.Личные_данные);
        }

        //оклад
        private void button1_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
        }

    }
}
