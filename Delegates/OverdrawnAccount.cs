using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class OverdrawnAccount : Account
    {
        
        int _balance;
        public OverdrawnAccount(int bal)
        {
            _balance = bal;
        }

        public override int balance
        {
            get { return _balance; }
            set
            {
                _balance = value;
                if (balance <-100)
                {

                    OverdrawnEventArgs args = new OverdrawnEventArgs();
                    args.acc = this;
                    OnOverdrawnevent(args);

                }

            }
        }
    }
}
