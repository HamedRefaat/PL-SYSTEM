namespace TableColumn
{
    partial class ColumnOfTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.down1 = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.Label();
            this.right = new System.Windows.Forms.Label();
            this.top1 = new System.Windows.Forms.Label();
            this.OpName = new System.Windows.Forms.Label();
            this.top2 = new System.Windows.Forms.Label();
            this.OpType = new System.Windows.Forms.Label();
            this.down2 = new System.Windows.Forms.Label();
            this.container = new BurtonSoftware.ThemeKit.ThemePanel();
            this.output = new System.Windows.Forms.Panel();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // down1
            // 
            this.down1.BackColor = System.Drawing.Color.Gold;
            this.down1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.down1.Location = new System.Drawing.Point(0, 205);
            this.down1.Margin = new System.Windows.Forms.Padding(0);
            this.down1.Name = "down1";
            this.down1.Size = new System.Drawing.Size(101, 1);
            this.down1.TabIndex = 4;
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.Gold;
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.Location = new System.Drawing.Point(0, 0);
            this.left.Margin = new System.Windows.Forms.Padding(0);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(1, 205);
            this.left.TabIndex = 5;
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.Gold;
            this.right.Dock = System.Windows.Forms.DockStyle.Right;
            this.right.Location = new System.Drawing.Point(100, 0);
            this.right.Margin = new System.Windows.Forms.Padding(0);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(1, 205);
            this.right.TabIndex = 6;
            // 
            // top1
            // 
            this.top1.BackColor = System.Drawing.Color.Gold;
            this.top1.Dock = System.Windows.Forms.DockStyle.Top;
            this.top1.Location = new System.Drawing.Point(1, 0);
            this.top1.Margin = new System.Windows.Forms.Padding(0);
            this.top1.Name = "top1";
            this.top1.Size = new System.Drawing.Size(99, 2);
            this.top1.TabIndex = 7;
            // 
            // OpName
            // 
            this.OpName.BackColor = System.Drawing.Color.RoyalBlue;
            this.OpName.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpName.ForeColor = System.Drawing.Color.DarkRed;
            this.OpName.Location = new System.Drawing.Point(1, 2);
            this.OpName.Margin = new System.Windows.Forms.Padding(0);
            this.OpName.Name = "OpName";
            this.OpName.Size = new System.Drawing.Size(99, 22);
            this.OpName.TabIndex = 8;
            this.OpName.Text = "Op Name";
            this.OpName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // top2
            // 
            this.top2.BackColor = System.Drawing.Color.Gold;
            this.top2.Dock = System.Windows.Forms.DockStyle.Top;
            this.top2.Location = new System.Drawing.Point(1, 24);
            this.top2.Margin = new System.Windows.Forms.Padding(0);
            this.top2.Name = "top2";
            this.top2.Size = new System.Drawing.Size(99, 2);
            this.top2.TabIndex = 9;
            // 
            // OpType
            // 
            this.OpType.BackColor = System.Drawing.Color.White;
            this.OpType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OpType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpType.Location = new System.Drawing.Point(1, 185);
            this.OpType.Margin = new System.Windows.Forms.Padding(0);
            this.OpType.Name = "OpType";
            this.OpType.Size = new System.Drawing.Size(99, 20);
            this.OpType.TabIndex = 10;
            this.OpType.Text = "Op Type";
            this.OpType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // down2
            // 
            this.down2.BackColor = System.Drawing.Color.Gold;
            this.down2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.down2.Location = new System.Drawing.Point(1, 184);
            this.down2.Margin = new System.Windows.Forms.Padding(0);
            this.down2.Name = "down2";
            this.down2.Size = new System.Drawing.Size(99, 1);
            this.down2.TabIndex = 11;
            // 
            // container
            // 
            this.container.Controls.Add(this.output);
            this.container.Controls.Add(this.down2);
            this.container.Controls.Add(this.OpType);
            this.container.Controls.Add(this.top2);
            this.container.Controls.Add(this.OpName);
            this.container.Controls.Add(this.top1);
            this.container.Controls.Add(this.right);
            this.container.Controls.Add(this.left);
            this.container.Controls.Add(this.down1);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Margin = new System.Windows.Forms.Padding(0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(101, 206);
            this.container.Style = null;
            this.container.TabIndex = 0;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.Transparent;
            this.output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(1, 26);
            this.output.Margin = new System.Windows.Forms.Padding(0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(99, 158);
            this.output.TabIndex = 12;
            // 
            // ColumnOfTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.container);
            this.Name = "ColumnOfTable";
            this.Size = new System.Drawing.Size(101, 206);
            this.container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.VisibleChanged += new System.EventHandler(this.container_VisibleChanged);
        }


        #endregion

        private System.Windows.Forms.Label down1;
        private System.Windows.Forms.Label left;
        private System.Windows.Forms.Label right;
        private System.Windows.Forms.Label top1;
        private System.Windows.Forms.Label OpName;
        private System.Windows.Forms.Label top2;
        private System.Windows.Forms.Label OpType;
        private System.Windows.Forms.Label down2;
        private BurtonSoftware.ThemeKit.ThemePanel container;
        private System.Windows.Forms.Panel output;

    }
}
