using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[,] sPrdct = { { "四季春青茶","35"},{ "黃金烏龍","35"},{ "波霸紅茶","45"},{ "檸檬綠/青","55"},
                                 { "冰淇淋紅茶","55"},{ "多多檸檬綠","65"},{ "奶茶","55"},{ "烏龍奶","55"},
                                 { "燕麥烏龍奶","55"},{ "紅茶瑪奇朵","55"},{ "燕麥阿華田","60"},
                                 { "紅茶拿鐵","65"},{ "布丁紅茶拿鐵","75"}
                                };

            int iRowCnt = sPrdct.GetLength(0);
            int iColCnt = sPrdct.GetLength(1);
            for (int i = 0; i < iRowCnt; i++) 
            {
                dtGV_Menu.Rows.Add(new object[] { sPrdct[i, 0], sPrdct[i, 1] });
            }
        }

        private void dtGV_Menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbx_PrdNa.Text = dtGV_Menu.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbx_PrdPr.Text = dtGV_Menu.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
