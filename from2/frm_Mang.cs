using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace from2
{
    public partial class frm_Mang : Form
    {
        public frm_Mang()
        {
            InitializeComponent();
        }
        string[] arr;
        private void btn_tong_Click(object sender, EventArgs e)
        {
            if(txt_arr.Text.Trim() == "")
            {
                string title = "Thông Báo";
                string content = "Chưa nhập mảng";
                MessageBox.Show(content, title);
            }
            else
            {
                arr = txt_arr.Text.Split(' ');
                int tong = 0;
                foreach (string x in arr)
                {
                    int temp = int.Parse(x);
                    tong += temp;
                }
                txt_tong.Text = tong.ToString();
            }
            
        }

        private void btn_chan_Click(object sender, EventArgs e)
        {
            if (txt_arr.Text.Trim() == "")
            {
                string title = "Thông Báo";
                string content = "Chưa nhập mảng";
                MessageBox.Show(content, title);
            }
            else
            {
                arr = txt_arr.Text.Split(' ');
                int chan = 0;
                foreach (string x in arr)
                {
                    int temp = int.Parse(x);
                    if (temp % 2 == 0)
                    {
                        chan += temp;
                    }
                }
                txt_chan.Text = chan.ToString();
            }
        }

        private void btn_le_Click(object sender, EventArgs e)
        {
            if (txt_arr.Text.Trim() == "")
            {
                string title = "Thông Báo";
                string content = "Chưa nhập mảng";
                MessageBox.Show(content, title);
            }
            else
            {
                arr = txt_arr.Text.Split(' ');
                int le = 0;
                foreach (string x in arr)
                {
                    int temp = int.Parse(x);
                    if (temp % 2 == 1)
                    {
                        le += temp;
                    }
                }
                txt_le.Text = le.ToString();
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muôn thoát ?", "Cảnh cáo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_arr.ResetText();
            txt_le.ResetText();
            txt_chan.ResetText();
            txt_tong.ResetText();
        }
    }
}
