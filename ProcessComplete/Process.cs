using System;

namespace ProcessComplete
{
    public class Process
    {
        public event EventHandler ProcessCompleted;
        public Process()
        {

        }
        public void Run()
        {
            OnProcessCompleted(EventArgs.Empty);
        }

        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }
}
