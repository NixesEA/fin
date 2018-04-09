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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel.Enabled = false;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data.Надбавка". При необходимости она может быть перемещена или удалена.
            this.надбавкаTableAdapter.Fill(this.data.Надбавка);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtName.Focus();
                this.data.Надбавка.AddНадбавкаRow(this.data.Надбавка.NewНадбавкаRow());
                надбавкаBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                надбавкаBindingSource.ResetBindings(false);
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
            надбавкаBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                надбавкаBindingSource.EndEdit();
                надбавкаTableAdapter.Update(this.data.Надбавка);
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                надбавкаBindingSource.ResetBindings(false);
            }
        }

    }
}
