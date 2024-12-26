using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.BozhukovVP.Sprint7.Project.V7
{
    public partial class FormEdit_BVP : Form
    {
        FormMain fmain;
        public FormEdit_BVP(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void buttonEdit_BVP_Click(object sender, EventArgs e)
        {
            int a = fmain.dataGridViewBase_BVP.CurrentRow.Index;
            fmain.dataGridViewBase_BVP.Rows[a].Cells[0].Value = textBoxPodEdit_BVP.Text;
            fmain.dataGridViewBase_BVP.Rows[a].Cells[1].Value = textBoxHomeEdit_BVP.Text;
            fmain.dataGridViewBase_BVP.Rows[a].Cells[2].Value = textBoxRoomsEdit_BVP.Text;
            fmain.dataGridViewBase_BVP.Rows[a].Cells[3].Value = textBoxSizeEdit_BVP.Text;
            fmain.dataGridViewBase_BVP.Rows[a].Cells[4].Value = textBoxChildEdit_BVP.Text;
            fmain.dataGridViewBase_BVP.Rows[a].Cells[5].Value = textBoxDolgEdit_BVP.Text;
            this.Close();
        }

        private void textBoxPodEdit_BVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxHomeEdit_BVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxRoomsEdit_BVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxSizeEdit_BVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxChildEdit_BVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxDolgEdit_BVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxPodEdit_BVP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
