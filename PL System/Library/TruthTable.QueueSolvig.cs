using System;
using System.Collections.Generic;
using System.Linq;

namespace PropositionalLogic
{
    public partial class TruthTable
    {
        private class QueuingSolve
        {
            private TruthTable TruthTable { get; set; }

            private String InputStatement { get; set; }

            private LinkedList<Parenthsis> priorityList = new LinkedList<Parenthsis>();      //List of parentheses to calculate priority

            public QueuingSolve(string statement, TruthTable truthTable)
            {
                InputStatement = statement;
                TruthTable = truthTable;
                DefinePriorityList();
                GenerateTruthTable();
            }

            private void GenerateTruthTable()
            {
                while (priorityList.Count > 0)
                {
                    LinkedListNode<Parenthsis> hightest = HighestPrioitySubOp();
                    string subOperation = InputStatement.Substring(hightest.Value.Index + 1, hightest.Next.Value.Index - hightest.Value.Index - 1);
                    Solve(subOperation);
                    DefinePriorityList();   //Finaly define priority of parantheses for the while condition.
                }
            }

            private LinkedListNode<Parenthsis> HighestPrioitySubOp()
            {

                //Get the left first heightest priority.
                LinkedListNode<Parenthsis> hightest;
                hightest = priorityList.First;
                for (int j = 0; j < priorityList.Count - 1; j++)
                {
                    if (hightest.Value.IsLeft && !hightest.Next.Value.IsLeft)
                        break;

                    hightest = hightest.Next;
                }
                return hightest;
            }

            //Define a list used to calculate the priority of parantheses
            private void DefinePriorityList()
            {
                priorityList.Clear();
                for (int i = 0; i < InputStatement.Length; i++)
                    switch (InputStatement[i])
                    {
                        case '(':
                            priorityList.AddLast(new Parenthsis(true, i));
                            break;

                        case ')':
                            priorityList.AddLast(new Parenthsis(false, i));
                            break;

                        default:
                            break;
                    }
            }

            private void Solve(string subOperation)
            {
                if (subOperation.Split(PL.sysOperators, StringSplitOptions.RemoveEmptyEntries).Length <= 2)
                {
                    BasicOperation basicOp = new BasicOperation(TruthTable, subOperation);
                    if (basicOp.Label == '\0')
                    {
                        InputStatement = InputStatement.Replace("(" + subOperation + ")", subOperation);
                        return;
                    }
                    InputStatement = InputStatement.Replace("(" + subOperation + ")", basicOp.Label.ToString());
                    InputStatement = InputStatement.Replace(subOperation, basicOp.Label.ToString());
                    while (InputStatement.Contains("(" + basicOp.Label + ")"))
                        InputStatement = InputStatement.Replace("(" + basicOp.Label + ")", basicOp.Label.ToString());
                    InputStatement = InputStatement.Replace("¬" + basicOp.Label.ToString(), "(¬" + basicOp.Label.ToString() + ")");
                    if (InputStatement.Length > 1 && !InputStatement.Contains('('))
                        InputStatement = "(" + InputStatement + ")";
                    TruthTable.InsertOpIntoTruthTable(basicOp);
                }
                else
                    RefineSubOp(subOperation);

            }

            private void RefineSubOp(string subOperation)
            {
                string[] subHigh = subOperation.Split(new char[] { '→', '↔' }, StringSplitOptions.RemoveEmptyEntries);
                string ops = subOperation;
                for (int i = 0; i < subHigh.Length; i++)
                    ops = ops.Remove(i, subHigh[i].Length);
                char[] subHigh_Operators = ops.ToCharArray();

                for (int i = 0; i < subHigh.Length; i++)
                {
                    string[] sub_subHigh = subHigh[i].Split(new char[] { '^', '˅' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] sub_subHigh_Operators = subHigh[i].Split(sub_subHigh, StringSplitOptions.RemoveEmptyEntries);
                    string temp = sub_subHigh[0];
                    for (int j = 0; j < sub_subHigh_Operators.Length; j++)
                        temp = "(" + temp + sub_subHigh_Operators[j] + sub_subHigh[j + 1] + ")";

                    subHigh[i] = temp;
                }

                string final = subHigh[0];
                for (int i = 0; i < subHigh.Length - 1; i++)
                    final = "(" + final + subHigh_Operators[i] + subHigh[i + 1] + ")";

                InputStatement = InputStatement.Replace("(" + subOperation + ")", final);
            }

            private class Parenthsis
            {
                public bool IsLeft { get; private set; }
                public int Index { get; private set; }

                public Parenthsis(bool isLeft, int index)
                {
                    IsLeft = isLeft;
                    Index = index;
                }
            }
        }
    }
}