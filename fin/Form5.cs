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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appDataa._Расчет_з_п". При необходимости она может быть перемещена или удалена.
            this.расчет_з_пTableAdapter1.Fill(this.appDataa._Расчет_з_п);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData._Расчет_з_п". При необходимости она может быть перемещена или удалена.
            this.расчет_з_пTableAdapter.Fill(this.appData._Расчет_з_п);

        }
    }
}
