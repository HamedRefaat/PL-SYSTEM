using System;
using System.Collections.Generic;
using System.Linq;

namespace PropositionalLogic
{
    public class Convertor
    {
        private LinkedList<Parenthsis> priorityList = new LinkedList<Parenthsis>();
        private LinkedList<BasicOp> opList = new LinkedList<BasicOp>();
        private string input, output;
        public Convertor() { }

        ~Convertor()
        {
            priorityList.Clear();
        }

        public PL_Dash1 ToPL_Dash1(PL statement)
        {
         
            input = statement.PL_Statement;
            definePriority();
            while (priorityList.Count > 0)
            {
                PLtoPLDash1();
                definePriority();
            }

            LinkedListNode<BasicOp> node = opList.Last;
            output = node.Value.OpName;
            for (int i = 0; i < opList.Count - 1; i++)
            {
                node = node.Previous;
                output = output.Replace(node.Value.Label.ToString(), node.Value.OpName);
            }
            return new PL_Dash1(output);
        }

        private void PLtoPLDash1()
        {
            LinkedListNode<Parenthsis> hightest = highestPrioitySubOp();
            string subOperation = input.Substring(hightest.Value.Index + 1, hightest.Next.Value.Index - hightest.Value.Index - 1);
            string[] operands = subOperation.Split(new char[] { '^', '˅', '→', '↔' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            BasicOp basicOp;

            if (operands.Length == 1)
            {
                basicOp = new BasicOp("(" + subOperation + ")");
                opList.AddLast(basicOp);
                input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
            }
            else if (operands.Length == 2)
            {
                string op = subOperation.Split(operands, StringSplitOptions.RemoveEmptyEntries).ToArray()[0].ToString();
                switch (op)
                {
                    case "^":
                        basicOp = new BasicOp("¬(" + operands[0] + "→¬" + operands[1] + ")");
                        input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
                        opList.AddLast(basicOp);
                        break;

                    case "˅":
                        basicOp = new BasicOp("(¬" + operands[0] + "→" + operands[1] + ")");
                        input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
                        opList.AddLast(basicOp);
                        break;

                    case "↔":
                        basicOp = new BasicOp("¬((" + operands[0] + "→" + operands[1] + ")→¬(" + operands[1] + "→" + operands[0] + "))");
                        input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
                        opList.AddLast(basicOp);
                        break;

                    default:

                        basicOp = new BasicOp("(" + subOperation + ")");
                        input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
                        opList.AddLast(basicOp);
                        break;

                }
                input = input.Replace("(" + subOperation + ")", subOperation);
            }
            else refine(subOperation);
        }

        private void refine(string subOperation)
        {
            string[] subHigh = subOperation.Split(new char[] { '→', '↔' }, StringSplitOptions.RemoveEmptyEntries);
            string[] subHigh_Operators = subOperation.Split(subHigh, StringSplitOptions.RemoveEmptyEntries);
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
            for (int i = 0; i < subHigh_Operators.Length; i++)
                final = "(" + final + subHigh_Operators[i] + subHigh[i + 1] + ")";

            input = input.Replace("(" + subOperation + ")", final);
        }

        public PL_Dash2 ToPL_Dash2(PL statement)
        {
            input = statement.PL_Statement;
            definePriority();
            while (priorityList.Count > 0)
            {
                PLtoPLDash2();
                definePriority();
            }

            LinkedListNode<BasicOp> node = opList.Last;
            output = node.Value.OpName;
            for (int i = 0; i < opList.Count - 1; i++)
            {
                node = node.Previous;
                output = output.Replace(node.Value.Label.ToString(), node.Value.OpName);
            }
            PL_Dash2 s = new PL_Dash2(output);
            return new PL_Dash2(output);
        }

        private void PLtoPLDash2()
        {
            LinkedListNode<Parenthsis> hightest = highestPrioitySubOp();
            string subOperation = input.Substring(hightest.Value.Index + 1, hightest.Next.Value.Index - hightest.Value.Index - 1);
            string[] operands = subOperation.Split(new char[] { '^', '˅', '→', '↔' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            BasicOp basicOp;

            if (operands.Length == 1)
            {
                basicOp = new BasicOp("(" + subOperation + ")");
                opList.AddLast(basicOp);
                input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
            }
            else if (operands.Length == 2)
            {
                string op = subOperation.Split(operands, StringSplitOptions.RemoveEmptyEntries).ToArray()[0].ToString();
                switch (op)
                {
                    case "→":
                        basicOp = new BasicOp("¬(" + operands[0] + "^¬" + operands[1] + ")");
                        input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
                        opList.AddLast(basicOp);
                        break;

                    case "˅":
                        basicOp = new BasicOp("¬(¬" + operands[0] + "^¬" + operands[1] + ")");
                        input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
                        opList.AddLast(basicOp);
                        break;

                    case "↔":
                        basicOp = new BasicOp("¬(" + operands[0] + "^¬" + operands[1] + ")^¬(" + operands[1] + "^¬" + operands[0] + ")");
                        input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
                        opList.AddLast(basicOp);
                        break;

                    default:

                        basicOp = new BasicOp("(" + subOperation + ")");
                        input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
                        opList.AddLast(basicOp);
                        break;

                }
                input = input.Replace("(" + subOperation + ")", subOperation);
            }
            else refine(subOperation);
        }

        public PL_Dash3 ToPL_Dash3(PL statement)
        {
            //type = Type.PL;
            input = statement.PL_Statement;
            definePriority();
            while (priorityList.Count > 0)
            {
                PLtoPLDash3();
                definePriority();
            }

            LinkedListNode<BasicOp> node = opList.Last;
            output = node.Value.OpName;
            for (int i = 0; i < opList.Count - 1; i++)
            {
                node = node.Previous;
                output = output.Replace(node.Value.Label.ToString(), node.Value.OpName);
            }
            return new PL_Dash3(output);
        }

        private void PLtoPLDash3()
        {
            LinkedListNode<Parenthsis> hightest = highestPrioitySubOp();
            string subOperation = input.Substring(hightest.Value.Index + 1, hightest.Next.Value.Index - hightest.Value.Index - 1);
            string[] operands = subOperation.Split(new char[] { '^', '˅', '→', '↔' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            BasicOp basicOp;

            if (operands.Length == 1)
            {
                basicOp = new BasicOp("(" + subOperation + ")");
                opList.AddLast(basicOp);
                input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
            }
            else if (operands.Length == 2)
            {
                string op = subOperation.Split(operands, StringSplitOptions.RemoveEmptyEntries).ToArray()[0].ToString();
                switch (op)
                {
                    case "→":
                        basicOp = new BasicOp("(¬" + operands[0] + "˅" + operands[1] + ")");
                        input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
                        opList.AddLast(basicOp);
                        break;

                    case "^":
                        basicOp = new BasicOp("¬(¬" + operands[0] + "˅¬" + operands[1] + ")");
                        input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
                        opList.AddLast(basicOp);
                        break;

                    case "↔":
                        basicOp = new BasicOp("¬(¬(¬" + operands[0] + "˅" + operands[1] + ")˅¬(¬" + operands[1] + "˅" + operands[0] + "))");
                        input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
                        opList.AddLast(basicOp);
                        break;

                    default:

                        basicOp = new BasicOp("(" + subOperation + ")");
                        input = input.Replace("(" + subOperation + ")", basicOp.Label.ToString());
                        opList.AddLast(basicOp);
                        break;

                }
                input = input.Replace("(" + subOperation + ")", subOperation);
            }
            else refine(subOperation);
        }

        private void definePriority()
        {
            priorityList.Clear();
            for (int i = 0; i < input.Length; i++)
                switch (input[i])
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

        private LinkedListNode<Parenthsis> highestPrioitySubOp()
        {
            LinkedListNode<Parenthsis> hightest;
            hightest = priorityList.First;
            for (int i = 0; i < priorityList.Count - 1; i++)
            {
                if (hightest.Value.IsLeft && !hightest.Next.Value.IsLeft)
                    break;

                hightest = hightest.Next;
            }
            return hightest;
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

        private class BasicOp
        {
            public string OpName { get; private set; }
            public char Label { get; private set; }
            private static char id = 'a';

            public BasicOp(string opName)
            {
                OpName = opName;
                Label = id++;
            }
        }
    }
}