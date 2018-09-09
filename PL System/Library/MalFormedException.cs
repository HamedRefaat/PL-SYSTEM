using System;

namespace PropositionalLogic
{
    public class MalFormedException : ApplicationException
    {
        public int Location { get; set; }
        public MalFormedException()
            : base()
        {
            Location = -1;
        }

        public MalFormedException(string message)
            : base(message)
        {
            Location = -1;
        }
    }
}
