using System;
using System.Collections.Generic;

namespace PropositionalLogic
{
    public partial class TruthTable
    {
        private LinkedList<BasicOperation> truthTable = new LinkedList<BasicOperation>();
        private LinkedListNode<BasicOperation> iterator;
        public int Height { get; private set; }             //Truth Table Height
        public int Width { get; private set; }              //Truth Table Width
        public PL_Base Statement { get; private set; }      //The PL Statement

        public TruthTable(PL_Base statement)
        {
            Statement = statement;
            Height = (int)Math.Pow(2, Statement.Letters.Length);
            InsertLetters(Statement.Letters);
        }

        ~TruthTable()
        {
            truthTable.Clear();
            truthTable = null;
        }

        public void GenerateTruthTable()
        {
            if (Statement.PL_Statement.Split(Statement.Letters, StringSplitOptions.RemoveEmptyEntries).Length == 0)
                return;

            QueuingSolve queue = new QueuingSolve(Statement.PL_Statement, this);
            iterator = truthTable.First;
        }

        private void InsertLetters(string[] letters)
        {
            int block = Height / 2;
            bool[] truthValues = new bool[Height];
            for (int i = 0; i < letters.Length; i++)
            {
                bool block_flip = true;
                for (int j = 0; j < Height; j++)
                {
                    truthValues[j] = block_flip;
                    if ((j + 1) % block == 0) block_flip = !block_flip;
                }
                block /= 2;
                BasicOperation inputArg = new BasicOperation(this, letters[i].ToString(), truthValues);
                truthTable.AddLast(inputArg);
                Width++;
            }
        }

        private void InsertOpIntoTruthTable(BasicOperation op)
        {
            if (op.TruthValues != null)
            {
                truthTable.AddLast(op);
                Width++;
            }
        }

        private BasicOperation GetOpFromTruthTable(string label)
        {
            LinkedListNode<BasicOperation> node = truthTable.First;
            for (int i = 0; i < truthTable.Count; i++)
            {
                if (node.Value.OpName == label || node.Value.Label.ToString() == label)
                    return node.Value;

                node = node.Next;
            }
            return null;
        }

        public string GetOpName(int index)
        {
            iterator = truthTable.First;
            for (int i = 0; i < index; i++)
                iterator = iterator.Next;

            return iterator.Value.OpName;
        }

        public bool[] GetOpTruthValue(int index)
        {
            iterator = truthTable.First;
            for (int i = 0; i < index; i++)
                iterator = iterator.Next;
            bool[] column = iterator.Value.TruthValues;
            return column;
        }

        public string GetOpType(int index)
        {
            iterator = truthTable.First;
            for (int i = 0; i < index; i++)
                iterator = iterator.Next;
            return iterator.Value.Type;
        }

        public int GetIndexOf(string subOperation)
        {
            LinkedListNode<BasicOperation> node = truthTable.First;
            for (int i = 0; i < truthTable.Count; i++)
            {
                if (node.Value.OpName == subOperation || node.Value.Label.ToString() == subOperation)
                    return i;

                node = node.Next;
            }
            return -1;
        }
    }
}