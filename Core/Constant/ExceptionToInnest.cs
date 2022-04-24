using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Constant
{
    public static class ExceptionToInnest
    {
        public static Exception ToInnest(this Exception ex)
        {
            if (ex.InnerException!=null)
            {
                return ex.InnerException.ToInnest();
            }
            return ex;
        }
    }
}
