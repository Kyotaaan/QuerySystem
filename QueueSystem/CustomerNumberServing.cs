using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueSystem
{
    public partial class CustomerNumberServing : Form
    {
        public CustomerNumberServing()
        {
            InitializeComponent();
        }
        public void NowServing(string queueNum)
        {
            lblServingNum.Text = queueNum;
        }
    }
}