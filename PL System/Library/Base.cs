using System.Linq;
namespace PropositionalLogic
{
    public abstract class PL_Base
    {
        //PL system operaators.
        public static char[] sysOperators;
        
        //Current pl statement & letters.
        public string PL_Statement { get; protected set; }
        public string[] Letters { get; protected set; }

        //Truth table for the current PL statement
        public TruthTable TruthTable { get; protected set; }

        /// <summary>
        /// Get a value indicating weather a statement is WWF or not.
        /// </summary>
        ///<exception cref="MalFormedException">
        ///Throw an exception if the statement is not well formmatted.
        /// </exception> 
        public bool IsWFF
        {
            get {
                //Checking for input miss match.
                for (int i = 0; i < PL_Statement.Length; i++)
                    if (!(char.IsLetter(PL_Statement[i]) && char.IsUpper(PL_Statement, i)
                        || sysOperators.Contains<char>(PL_Statement[i])
                        || PL_Statement[i] == '(' || PL_Statement[i] == ')'))
                    {
                        MalFormedException ex = new MalFormedException("Format error: '" + PL_Statement[i] + "' not allowed at current system.");
                        ex.Location = i;
                        throw ex;
                    }

                //Checking for correct parentheses priority.
                int count = 0;
                for (int i = 0; i < PL_Statement.Length; i++)
                {
                    if (PL_Statement[i] == '(')
                        count++;
                    else if (PL_Statement[i] == ')')
                        count--;
                }

                string direction = "";
                if (count != 0)
                {
                    if (count < 0) direction = "Left"; else direction = "Right";
                    throw new MalFormedException("Paranthsis pair error: " + direction + " parantheses mised.");
                }

                //Checking whether operations are correct or not.
                IsOperationValid();
                
                PaternRefine();     //Refining the equation to be more readable.

                return true;
            }
        }

        //Constructor
        public PL_Base()
        { }

        //If the equation is WFF then evaluate it.
        public void GenerateTruthTable()
        {
            try
            {
                if (IsWFF)
                    TruthTable.GenerateTruthTable();
            }
            catch (MalFormedException) { throw; }
        }

        //Refinnig the statement shape and priority
        private void PaternRefine()
        {
            string temp;

            //Remov all double negiations
            if (PL_Statement.Contains("¬¬"))
                PL_Statement = PL_Statement.Replace("¬¬", "");

            for (int i = 0; i < Letters.Length; i++)
            {
                temp = "¬(¬" + Letters[i] + ")";
                PL_Statement = PL_Statement.Replace(temp, Letters[i]);
            }

            //Replace all occurrnces of "¬(A)" with "(¬A)"
            for (int i = 0; i < Letters.Length; i++)
            {
                temp = "¬(" + Letters[i] + ")";
                PL_Statement = PL_Statement.Replace(temp, "(¬" + Letters[i] + ")");
            }

            //Replace all occurrnces of "¬A" with "(¬A)"
            for (int i = 0; i < Letters.Length; i++)
            {
                temp = "¬" + Letters[i];
                PL_Statement = PL_Statement.Replace(temp, "(¬" + Letters[i] + ")");
            }

            //Replace all occurrnces of "((¬A))" with "(¬A)"
            for (int i = 0; i < Letters.Length; i++)
            {
                temp = "((¬" + Letters[i] + "))";
                PL_Statement = PL_Statement.Replace(temp, "(¬" + Letters[i] + ")");
            }

            //Replace all occurrnces of "(A)" with "A"
            for (int i = 0; i < Letters.Length; i++)
            {
                temp = "(" + Letters[i] + ")";
                PL_Statement = PL_Statement.Replace(temp, Letters[i]);
            }
        }

        abstract protected bool IsOperationValid();

        //Checking whether an operation or operand is precceded
        //by some defined others or not.
        protected bool IsPreccededBy(string allowed, bool operand, int opLoc)
        {
            if (operand)
                //if (Letters.Contains<string>(Statement[opLoc - 1].ToString()))
                if (char.IsLetter(PL_Statement[opLoc - 1]))
                    return true;

            if (allowed.Contains<char>(PL_Statement[opLoc - 1]))
                return true;

            MalFormedException ex = new MalFormedException("Operation error near: " + "'" + PL_Statement[opLoc] + "'.");
            ex.Location = opLoc;
            throw ex;

        }

        //Checking whether an operation or operand is followed
        //by some defined others or not.
        protected bool IsFollowedBy(string allowed, bool operand, int opLoc)
        {
            if (operand)
                //if (Letters.Contains<string>(Statement[opLoc + 1].ToString()))
                if (char.IsLetter(PL_Statement[opLoc + 1]))
                    return true;

            if (allowed.Contains<char>(PL_Statement[opLoc + 1]))
                return true;

            MalFormedException ex = new MalFormedException("Operation error near: " + "'" + PL_Statement[opLoc] + "'.");
            ex.Location = opLoc;
            throw ex;
        }
    }
}