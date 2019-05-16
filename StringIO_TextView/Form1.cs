using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringIO_TextView
{
    public partial class Form1 : Form
    {
        private string OrgStr;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lblResult.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(TextCheck())
            {
                this.lblResult.Text = this.OrgStr + this.txtEdit.Text;
            }
        }

        private bool TextCheck()
        {
            if (this.txtEdit.Text != "") return true;
            else
            {
                MessageBox.Show("텍스트를 입력하세요!", "알림",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtEdit.Focus();
                return false;
            }
        }

        private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sender -> 이벤트가 발생한 객체, e -> 버튼
            //keydown : 키를 눌렀을 때
            //keyup : 키를 뗐을 때
            //keypress : 키를 누르고 있을 때
            if (e.KeyChar == (char)13)
                {
                    if (TextCheck())
                    {
                        this.lblResult.Text = this.OrgStr + this.txtEdit.Text;
                        e.Handled = true;
                        //keypress를 완료했기 때문에 더이상 작동하지 않도록 하라는 의미.
                    }
                }
            }
    }
}
