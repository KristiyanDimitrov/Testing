using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTesting
{
    partial class Car // Partial classes will be combined on compilation. Can be used to chop class functionality
{
        // Has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }
    }

}
