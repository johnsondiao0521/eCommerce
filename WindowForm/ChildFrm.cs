using System;
using System.Windows.Forms;

namespace WindowForm
{
    public delegate void TextChangeMsg(string msg);
    public partial class ChildFrm : Form
    {
        //public MainFrm MainFrm { get; set; }
        public event TextChangeMsg TextChangeMsgEvent;
        public ChildFrm()
        {
            InitializeComponent();
        }

        private void btnChild_Click(object sender, EventArgs e)
        {
            TextChangeMsgEvent?.Invoke(this.txtMsg.Text);
        }
    }
}
