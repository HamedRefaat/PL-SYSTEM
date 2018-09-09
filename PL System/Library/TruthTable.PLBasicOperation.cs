using System;

namespace PropositionalLogic
{
    public partial class TruthTable
    {
        private class BasicOperation
        {
            private static char[] sysOperation = PL_Base.sysOperators;

            private TruthTable truthTtable = null;
            public string OpName { get; private set; }
            public char Label { get; private set; }
            public string Type { get; private set; }
            private static char id = 'a';
            public bool[] TruthValues
            {
                get
                {
                    bool[] temp = new bool[truthTtable.Height];
                    truthValues.CopyTo(temp, 0);
                    return temp;
                }
                private set
                {
                    truthValues = new bool[value.Length];
                    value.CopyTo(truthValues, 0);
                }
            }
            private bool[] truthValues;

            public BasicOperation(TruthTable truthTable, string opName)
            {
                OpName = opName;
                this.truthTtable = truthTable;
                Evaluate();
            }

            public BasicOperation(TruthTable truthTable, string opName, bool[] truthValues)   //Ctor used to insert the statement truth table input args
            {
                OpName = opName;
                this.truthTtable = truthTable;
                TruthValues = truthValues;
                Type = "Letter";
            }

            private void Evaluate()
            {
                string[] operands = OpName.Split(sysOperation, StringSplitOptions.RemoveEmptyEntries);
                if (operands.Length == 1 && !OpName.StartsWith("¬")) return;
                char op = OpName.Split(operands, StringSplitOptions.RemoveEmptyEntries)[0][0];   //Get 1st char of 1st element in the array.

                truthValues = new bool[truthTtable.Height];

                bool[] col1 = truthTtable.GetOpFromTruthTable(operands[0]).TruthValues;
                bool[] col2 = new bool[0];
                if (operands.Length == 2) col2 = truthTtable.GetOpFromTruthTable(operands[1]).TruthValues;

                if (operands.Length == 1)
                    OpName = "(" + op + truthTtable.GetOpFromTruthTable(operands[0]).OpName + ")";
                else
                {
                    OpName = "(" + truthTtable.GetOpFromTruthTable(operands[0]).OpName
                    + op + truthTtable.GetOpFromTruthTable(operands[1]).OpName + ")";
                }
                Label = id++;

                switch (op)
                {
                    case '¬':
                        Negiation(col1);
                        break;

                    case '^':
                        And(col1, col2);
                        break;

                    case '˅':
                        Or(col1, col2);
                        break;

                    case '→':
                        Implies(col1, col2);
                        break;

                    case '↔':
                        Equivalence(col1, col2);
                        break;
                }


                bool value = true;
                for (int i = 0; i < truthValues.Length; i++)
                    value = value && truthValues[i];
                if (value)
                {
                    Type = "Tautology";
                    return;
                }

                value = false;
                for (int i = 0; i < truthValues.Length; i++)
                    value = value || truthValues[i];

                if (!value)
                {
                    Type = "Contradictory";
                    return;
                }

                Type = "Contigent";
            }

            private void Negiation(bool[] col)
            {
                bool[] column = new bool[truthTtable.Height];
                for (int i = 0; i < truthTtable.Height; i++)
                    column[i] = !col[i];
                TruthValues = column;
            }

            private void And(bool[] col1, bool[] col2)
            {
                bool[] column = new bool[truthTtable.Height];
                for (int i = 0; i < truthTtable.Height; i++)
                    column[i] = col1[i] && col2[i];

                TruthValues = column;
            }

            private void Or(bool[] col1, bool[] col2)
            {
                bool[] column = new bool[truthTtable.Height];
                for (int i = 0; i < truthTtable.Height; i++)
                    column[i] = col1[i] || col2[i];

                TruthValues = column;
            }

            private void Implies(bool[] col1, bool[] col2)
            {
                bool[] column = new bool[truthTtable.Height];
                for (int i = 0; i < truthTtable.Height; i++)
                    column[i] = !col1[i] || col2[i];

                TruthValues = column;
            }

            private void Equivalence(bool[] col1, bool[] col2)
            {
                bool[] column = new bool[truthTtable.Height];
                for (int i = 0; i < truthTtable.Height; i++)
                    column[i] = (!col1[i] || col2[i]) && (!col2[i] || col1[i]);

                TruthValues = column;
            }
        }
    }
}