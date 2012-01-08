using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDriver;

namespace MyWork
{
    public class MyConnection
    {
        public readonly static int ReconnectInterval = 3000;
        private IMyDriver[] drivers;

        public MyConnection(string[] uris)
        {
        }

        /// <summary>
        /// for unittest
        /// </summary>
        /// <param name="drivers"></param>
        internal MyConnection(IMyDriver[] drivers)
        {
            this.drivers = drivers;
        }

        public void Open()
        {
            foreach (var driver in drivers)
            {
                driver.Connect();
            }
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public IDisposable Subscribe(int queryId, IMySubscriber subscriber)
        {
            throw new NotImplementedException();
        }

        public event EventHandler Connected;

        public event EventHandler ConnectionFailed;

        public event EventHandler Disconnected;
    }
}
