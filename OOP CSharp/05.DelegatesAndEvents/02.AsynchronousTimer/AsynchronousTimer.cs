namespace AsynchronousTimer
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    class AsynchronousTimer
    {
        private Action action;
        private int ticks;
        private int timeBetweenTicks;

        public AsynchronousTimer(Action action, int ticks, int timeBetweenTicks)
        {
            this.Action = action;
            this.ticks = ticks;
            this.timeBetweenTicks = timeBetweenTicks;
        }

        public Action Action
        {
            get { return this.action; }
            set 
            {
                if (value == null)
                    throw new ArgumentNullException("The action can't be null!!");
                this.action = value;
            }
        }

        public void StartAsync() 
        {
            Activate();
        }

        public void Activate()
        {
            while (this.ticks > 0)
            {
                Thread asyncThread = new Thread(() =>
                {
                    this.action();
                    this.ticks--;

                });
                asyncThread.Start();
                Thread.Sleep(this.timeBetweenTicks);
            }
        }
    }
}
