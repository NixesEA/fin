using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data.Оклад". При необходимости она может быть перемещена или удалена.
            this.окладTableAdapter.Fill(this.data.Оклад);

            textBox1.Enabled = false;
            textBox2.Enabled = false;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;

                this.data.Личные_данные.AddЛичные_данныеRow(this.data.Личные_данные.NewЛичные_данныеRow());
                окладBindingSource.MoveLast();

                this.data.Оклад.AddОкладRow(this.data.Оклад.NewОкладRow());//
                окладBindingSource.MoveLast();//   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                окладBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox2.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            окладBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                окладBindingSource.EndEdit();
                окладTableAdapter.Update(this.data.Оклад);
                окладBindingSource.EndEdit();
                окладTableAdapter.Update(this.data.Оклад);

                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                окладBindingSource.ResetBindings(false);
            }
        }
    }
}
