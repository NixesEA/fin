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

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
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
           // panel.Enabled = true;
            //txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //panel.Enabled = false;
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
               // panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                окладBindingSource.ResetBindings(false);
            }
        }
    }
}
