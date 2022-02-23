using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQsql_m
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Обратите внимание, что входная точка в базу данных теперь создается
            //конструктором класса DataClassesProcDataContext(в общем
            //случае класс будет называться так: { имя файла отображения} DataContext),
            //которому больше не нужно передавать параметром строку соединения в явном виде.

            var db = new DataClassesProcDataContext();

            foreach (var r in db.Ten_Most_Expensive_Products())
            {
                ListViewItem item =
                listView1.Items.Add(r.TenMostExpensiveProducts.ToString());
                item.SubItems.Add(r.UnitPrice.ToString());
            }
        }
    }
}
