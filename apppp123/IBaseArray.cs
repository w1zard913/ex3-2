using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal interface IBaseArray
    {
        public abstract void DisplayArray();
        public abstract void UserFill();
        public abstract void RandomFill();
        public abstract float Mean();
    }
}
