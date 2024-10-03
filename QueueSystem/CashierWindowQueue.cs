using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using static QueueSystem.QueueingForm;

namespace QueueSystem
{
    public partial class CashierWindowQueue : Form
    {
        private Timer timer;
        CustomerNumberServing customerNumberServing;
        public CashierWindowQueue()
        {
            InitializeComponent();
            InitializeTimer();
            DisplayCashierQueue(CashierClass.CashierQueue);
            customerNumberServing = new CustomerNumberServing();
        }

        public void InitializeTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable cashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (object obj in cashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string nowServing;

            if (CashierClass.CashierQueue.Count > 0)
            {
                nowServing = CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
                customerNumberServing.NowServing(nowServing);
                customerNumberServing.Show();
            }

            else
            {
                customerNumberServing.NowServing("P - #####");
            }
            
        }
    }
}