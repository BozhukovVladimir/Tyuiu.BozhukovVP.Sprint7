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
    public partial class FormAdd : Form
    {
        FormMain fmain;
        public FormAdd(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void textBoxPodAdd_BVP_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_BVP_Click(object sender, EventArgs e)
        {
            if ((textBoxChildAdd_BVP.Text == "") || (textBoxDolgAdd_BVP.Text == ""))
            {
                MessageBox.Show("Введите обязательные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fmain.dataGridViewBase_BVP.Rows.Add(textBoxPodAdd_BVP.Text, textBoxHomeAdd_BVP.Text, textBoxRoomsAdd_BVP.Text, textBoxSizeAdd_BVP.Text, textBoxChildAdd_BVP.Text, textBoxDolgAdd_BVP.Text);
                this.Close();
            }
        }


        private void textBoxPodAdd_BVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxHomeAdd_BVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxRoomsAdd_BVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxSizeAdd_BVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxChildAdd_BVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxDolgAdd_BVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
