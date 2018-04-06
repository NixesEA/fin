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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data._расчет_З_П". При необходимости она может быть перемещена или удалена.
            this.расчет_З_ПTableAdapter2.Fill(this.data._расчет_З_П);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data._расчет_З_П". При необходимости она может быть перемещена или удалена.
            this.расчет_З_ПTableAdapter2.Fill(this.data._расчет_З_П);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "data.Личные_данные_Запрос". При необходимости она может быть перемещена или удалена.
            //this.личные_данные_ЗапросTableAdapter.Fill(this.data.Личные_данные_Запрос);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appDataa._Расчет_з_п". При необходимости она может быть перемещена или удалена.
            this.расчет_з_пTableAdapter1.Fill(this.appDataa._Расчет_з_п);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData._Расчет_з_п". При необходимости она может быть перемещена или удалена.
            this.расчет_з_пTableAdapter.Fill(this.appData._Расчет_з_п);

        }
    }
}
