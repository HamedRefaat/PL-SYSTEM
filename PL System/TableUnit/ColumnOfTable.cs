using System;
using System.Windows.Forms;
using System.Text;
namespace TableColumn
{
    public partial class ColumnOfTable : UserControl
    {
        private static int OpNameHeight = 20;
        public ColumnOfTable()
            : base()
        {
            InitializeComponent();
        }

        public ColumnOfTable(bool[] truthValue, string name, string type)
            : this()
        {
            OpName.Text = name;

            Label[] lb = new Label[truthValue.Length];
            System.Drawing.Point p = new System.Drawing.Point(0, 0);
            bool flip_flop = true;
            for (int i = 0; i < truthValue.Length; i++)
            {
                lb[i] = new Label();
                lb[i].Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                if (flip_flop)
                {
                    lb[i].BackColor = System.Drawing.Color.White;
                    flip_flop = false;
                }
                else
                {
                    lb[i].BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
                    flip_flop = true;
                }
                lb[i].Text = truthValue[i].ToString()[0].ToString();
                lb[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lb[i].Dock = DockStyle.Bottom;
                lb[i].Location = p;
                p.Y += lb[i].Height;
                output.Controls.Add(lb[i]);
            }

            OpType.Text = type;

            OpName.AutoSize = true;
            OpType.AutoSize = true;
            if (OpName.Width > OpType.Width)
                this.Width = OpName.Width + 2;
            else
                this.Width = OpType.Width + 2;

            OpType.Dock = DockStyle.Bottom;
            OpName.Dock = DockStyle.Top;
            OpName.AutoSize = false;
            OpType.AutoSize = false;

            if (OpName.Height > OpNameHeight) OpNameHeight = OpName.Height;

            output.AutoSize = true;
            output.AutoSize = false;
            output.Dock = DockStyle.Fill;
            this.Height = lb.Length * lb[0].Height + OpNameHeight + 4 * top1.Height + OpType.Height;
        }

        private void container_VisibleChanged(object sender, System.EventArgs e)
        {
            OpName.Height = OpNameHeight;
            this.Height = 6 + OpNameHeight + output.Height + OpType.Height;
        }
    }
}
