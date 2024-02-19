using System;

namespace Arrays
{
    internal abstract class BaseArray
    {
        public BaseArray() { }
        public abstract void DisplayArray();
        public abstract void UserFill();
        public abstract void RandomFill();
        public abstract float Mean();

    }
}
