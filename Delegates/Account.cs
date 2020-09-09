using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class OverdrawnEventArgs : EventArgs
    {
        public Account acc;
        public int NewBalance;
        public bool isOverDrawnAllowed=false;
    }
    public class Account
    {
        //public event Action<Account> Overdrawn;
        public event EventHandler<OverdrawnEventArgs> Overdrawn;

        
        protected int _balance;
        
        public virtual int balance
        {
            get { return _balance; }
            set
            {
                if (balance >= 0)
                { 
                    _balance = value;
                }
                else
                {
                    OverdrawnEventArgs args = new OverdrawnEventArgs();
                    args.acc = this;
                    args.NewBalance = value;
                    args.isOverDrawnAllowed = false;
                    OnOverdrawnevent(args);
                    if (args.isOverDrawnAllowed)
                    {
                        _balance = value;
                    }
                }
            }

        }

        protected virtual void OnOverdrawnevent(OverdrawnEventArgs args)
        {
            if (Overdrawn!=null)
            {
                Overdrawn(this, args);
            }
        }

        
    }

}
