using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyLoverClone.Models
{
    public class HandleST
    {
        public int handle(int mo)
        {
            if (mo < 0) return 12;
            if (mo > 12) return 0;
            else return mo;
        }
    }
}