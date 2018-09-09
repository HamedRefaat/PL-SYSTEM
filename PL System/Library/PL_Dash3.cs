using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropositionalLogic
{
    public class PL_Dash3 : PL_Base
    {
        private bool isWFF;

        //Constructor
        public PL_Dash3(string statement)
            : base()
        {
            sysOperators = new char[] { '¬', '˅' };
            StringBuilder sb = new StringBuilder("(");
            sb.Append(statement.Trim());
            sb.Replace(" ", "");        //Remove all white spaces.

            sb.Append(")");
            PL_Statement = sb.ToString();

            Letters = PL_Statement.Split(new char[] { '¬', '˅', '(', ')' },
                StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();        //Extract operands from the equation.
            if (Letters.Length == 0) throw new MalFormedException("Empty statement");
            Array.Sort(Letters);

            isWFF = IsWFF;

            TruthTable = new TruthTable(this);
        }

        //Checking whether all operations are have suitable operands or not.
        override protected bool IsOperationValid()
        {
            for (int i = 1; i < PL_Statement.Length - 1; i++)
            {
                switch (PL_Statement[i])
                {
                    case '(':

                        IsPreccededBy("¬˅(", false, i);
                        IsFollowedBy("¬(", true, i);
                        break;

                    case ')':
                        IsPreccededBy(")", true, i);
                        IsFollowedBy("˅)", false, i);
                        break;

                    case '¬':
                        IsPreccededBy("¬˅(", false, i);
                        IsFollowedBy("¬(", true, i);
                        break;

                    case '˅':
                        IsPreccededBy(")", true, i);
                        IsFollowedBy("¬(", true, i);
                        break;
                }
            }
            return true;
        }
    }
}
