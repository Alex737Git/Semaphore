using System;
using System.ComponentModel;
using System.Threading;

namespace ListBoxesThreading
{
    public class ThreadWork : INotifyPropertyChanged
    {
        #region Propeties and Fields
        private int _count;
        Thread RunThread;
        static Semaphore _s;
        public int Number { get; } = 0;
        public bool stop { get; set; }

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                NotifyPropertyChanged("Count");
            }
        }

        // These three propeties for Displaying the DataMember of ListBoxes
        public string Created
        {
            get { return RunThread.Name + " -> created"; }
        }
        public string Waiting
        {
            get { return RunThread.Name + " -> waiting"; }
        }
        public string Working
        {
            get { return RunThread.Name + " -> " + Count; }
        }
        #endregion

        #region Ctor
        public ThreadWork(string name, int count)
        {
            Number = count;
            RunThread = new Thread(Run) { Name = name };
            RunThread.IsBackground = true;
        }
        #endregion

        #region Start, Stop and Run functions
        public void Start(Semaphore sem)
        {
            _s = sem;
            RunThread.Start();

        }
        public void Stop()
        {
            stop = true;
        }
        void Run()
        {
            do
            {
                if (_s.WaitOne())
                {
                    try
                    {
                        Count++;
                        Thread.Sleep(1000);
                    }
                    finally
                    {
                        _s.Release();
                    }
                }
            }
            while (!stop);
        }

        #endregion

        #region INotify propety Changed

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
        #endregion
    }
}
