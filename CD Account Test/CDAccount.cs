using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Account_Test
{
    class CDAccount : SavingAccount
    {
        private string _maturityDate;

        public CDAccount()
        {
            _maturityDate = "";
        }
        public string MaturityDate
        {
            get { return _maturityDate; }
            set { _maturityDate = value; }
        }
    }
}
