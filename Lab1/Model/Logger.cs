using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1.Model
{
    class Logger
    {

        private List<string> LogList = new List<string>();

        public void Log(string Msg)
        {
            if (LogList.Count > 10)
            {
                LogList.RemoveAt(0);
                LogList.Add(Msg);
            }
            else
            {
                LogList.Add(Msg);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\n", LogList);
        }

    }
}
