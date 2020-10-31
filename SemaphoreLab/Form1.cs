using ListBoxesThreading;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SemaphoreLab
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private BindingList<ThreadWork> bsCreated;
        private BindingList<ThreadWork> bsWaiting;
        private BindingList<ThreadWork> bsWorking;
        private int previousNumber;
        static Semaphore _s = new Semaphore(0, 100);

        #region Ctor
        public Form1()
        {
            InitializeComponent();
            bsCreated = new BindingList<ThreadWork>();
            bsWaiting = new BindingList<ThreadWork>();
            bsWorking = new BindingList<ThreadWork>();
            //listBoxes set up with Binding lists
            lbWorkingThreads.DataSource = bsWorking;
            lbWorkingThreads.DisplayMember = "Working";
            lbCreatedThreads.DataSource = bsCreated;
            lbCreatedThreads.DisplayMember = "Created";
            lbWaitingThreads.DataSource = bsWaiting;
            lbWaitingThreads.DisplayMember = "Waiting";
        }
        #endregion

        #region Events
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            string thread = "Thread ";
            ThreadWork threadWork = new ThreadWork(thread + count.ToString(), count);
            bsCreated.Add(threadWork);
        }
        private void lbCreatedThreads_DoubleClick(object sender, EventArgs e)
        {
            if (lbCreatedThreads.SelectedItem != null)
            {
                ThreadWork createdThread = lbCreatedThreads.SelectedItem as ThreadWork;
                bsCreated.Remove(createdThread);
                bsWaiting.Add(createdThread);
            }
            // when the working list has places we add new threads from the Waiting list
            if (bsWorking.Count - (int)nUDNumber.Value < 0)
            {
                AddThreadsToWorkingList();
            }
        }
        private void lbWorkingThreads_DoubleClick(object sender, EventArgs e)
        {
            if (lbWorkingThreads.SelectedItem != null)
            {
                ThreadWork workingThread = lbWorkingThreads.SelectedItem as ThreadWork;
                bsWorking.Remove(workingThread);
                workingThread.Stop();
            }
            // when the working list has places we add new threads from the Waiting list
            if (bsWorking.Count - (int)nUDNumber.Value < 0)
            {
                AddThreadsToWorkingList();
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (nUDNumber.Value > 0)
            {
                _s.Release((int)nUDNumber.Value);
            }
            else _s.Release();
            // this function reduces or addes a new thread to the working thread list
            BalanceWorkingThreads();
        } 
        #endregion

        #region BalanceWorkingThreads function
        private void BalanceWorkingThreads()
        {
            if (previousNumber < (int)nUDNumber.Value)
            {
                if (bsWaiting.Count > 0)
                { // function that add threads to the working list
                    AddThreadsToWorkingList();
                }
            }
            else
            {
                if (bsWorking.Count > 0)
                {
                    // find max to remove it 
                    ThreadWork threadWork = bsWorking.First(x => x.Count == bsWorking.Max(y => y.Count));
                    bsWorking.Remove(threadWork);
                    threadWork.Stop();
                }
            }
            // for checking 
            previousNumber = (int)nUDNumber.Value;
        }
        #endregion

        #region AddThreadsToWorkingList function
        private void AddThreadsToWorkingList()
        {
            if (bsWaiting.Count() > 0)// if the waiting list has any threads
            {
                ThreadWork threadWork = bsWaiting.First(x => x.Number == bsWaiting.Max(y => y.Number));
                bsWaiting.Remove(threadWork);
                bsWorking.Add(threadWork);
                //the semaphore is sent as a parameter to the ThreadWork class.
                threadWork.Start(_s);
            }
        } 
        #endregion
    }
}
