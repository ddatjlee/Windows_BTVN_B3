using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(ho.Text);
            item.SubItems.Add(ten.Text);
            item.SubItems.Add(sdt.Text);
            lv1.Items.Add(item);
        }
       

        private void btnSua_Click(object sender, EventArgs e)
        {

            bool hasChecked = false;
            foreach (ListViewItem item in lv1.Items)
            {
                if (item.Checked)
                {
                    item.Text = ho.Text; 
                    item.SubItems[1].Text = ten.Text; 
                    item.SubItems[2].Text = sdt.Text; 
                    hasChecked = true;
                    break;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool hasChecked = false; 

            for (int i = lv1.Items.Count - 1; i >= 0; i--) 
            {
                if (lv1.Items[i].Checked)
                {
                    lv1.Items.RemoveAt(i);
                    hasChecked = true;
                }
            }
        }
        private void lv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (lv1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = lv1.SelectedItems[0];
                    ho.Text = selectedItem.Text;
                    ten.Text = selectedItem.SubItems[1].Text;
                    sdt.Text = selectedItem.SubItems[2].Text;
                }
            
        }

        private void ho_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
