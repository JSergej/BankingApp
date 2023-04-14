using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class UserLogs
    {
        public EventArgs e = null;
        public delegate void dg_recLog(UserLogs ul, EventArgs e);  //delegate declared
        public event dg_recLog  ev_recLog;                         //event declared

        public void RecordLog()
        {
            if(ev_recLog != null)
            {
                ev_recLog(this, e);
            }
        }
    }
    
}
