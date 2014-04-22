using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameRating.Models
{
    public static class IDHolder
    {
        private static int _ID = 1;

        public static int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
    }
}