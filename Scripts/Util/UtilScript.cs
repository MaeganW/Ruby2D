using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Util
{
    public static class UtilScript
    {
        public static bool Equivalent(this string me, string other)
        {
            if (me == null && other == null)
                return true;

            if (me == null || other == null)
                return false;

            return me.Equals(other, StringComparison.OrdinalIgnoreCase);
        }
        
    } 

}
