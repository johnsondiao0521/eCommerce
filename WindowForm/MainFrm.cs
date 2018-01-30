using System;
using System.Windows.Forms;

namespace WindowForm
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChildFrm child = new ChildFrm();
            child.TextChangeMsgEvent += SetMessage;

            child.Show();
        }

        private void SetMessage(string msg)
        {
            this.txtMsg.Text = msg;
        }
    }
}
