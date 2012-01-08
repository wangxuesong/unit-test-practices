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
        private IMyDriver[] _drivers;

        public MyConnection(string[] uris)
        {
        }

        /// <summary>
        /// for unittest
        /// </summary>
        /// <param name="drivers"></param>
        internal MyConnection(IMyDriver[] drivers)
        {
            this._drivers = drivers;
        }

        public void Open()
        {
            foreach (var driver in _drivers)
            {
                driver.Connect();
                if (Connected != null)
                {
                    Connected(this, new EventArgs());
                }
            }
        }

        public void Close()
        {
            foreach (var driver in _drivers)
            {
                driver.Close();
            }
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
