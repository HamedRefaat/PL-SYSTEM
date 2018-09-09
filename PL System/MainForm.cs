using System;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using BurtonSoftware.ThemeKit;
using PropositionalLogic;
using TableColumn;

namespace PLSystems
{
    public partial class MainForm1 : ThemeForm
    {
        private Computer my;

        public enum SystemType { PL, PL_DASH1, PL_DASH2, PL_DASH3 }
        private SystemType currentType;

        private LinkedList<string> up_downList = new LinkedList<string>();
        private LinkedListNode<string> up_downNode;

        Color[] colors = new Color[] { Color.DarkRed, Color.Orange, Color.Blue };
        int colorIndex;

        public MainForm1()
        {
            InitializeComponent();
            my = new Computer();
            MaximumSize = new Size(my.Screen.WorkingArea.Width, my.Screen.WorkingArea.Height);
            inputBox.Focus();

            up_downList.AddFirst(inputBox.Text);
            up_downNode = up_downList.First;
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            int x = inputBox.SelectionStart;
            inputBox.SelectionStart = x;
            this.Text = inputBox.SelectionStart.ToString(); 
            switch (e.KeyData)
            {
                case (Keys.Control | Keys.D1):
                    inputBox.SelectedText = "¬";
                    break;
                case (Keys.Control | Keys.D2):
                    inputBox.SelectedText = "→";
                    break;
                case (Keys.Control | Keys.D3):
                    inputBox.SelectedText = "↔";
                    break;
                case (Keys.Control | Keys.D4):
                    inputBox.SelectedText = "^";
                    break;
                case (Keys.Control | Keys.D5):
                    inputBox.SelectedText = "˅";
                    break;
                case (Keys.Alt | Keys.D1):
                    equRadioBtn.Checked = true;
                    AnswerBtn_Click(sender, e);
                    break;
                case (Keys.Alt | Keys.D2):
                    conRadioBtn.Checked = true;
                    AnswerBtn_Click(sender, e);
                    break;
                case (Keys.Alt | Keys.D3):
                    logConRadio.Checked = true;
                    AnswerBtn_Click(sender, e);
                    break;
            }
        }

        private void InputBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.ControlKey && e.KeyData !=  Keys.A)
            {
                colorIndex = 0;
                int x = inputBox.SelectionStart;
                RichTextBox demo = new RichTextBox();
                demo.Rtf = inputBox.Rtf;
                string[] arr = demo.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                int start = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    demo.Select(start, arr[i].Length);
                    demo.SelectionColor = colors[colorIndex];
                    colorIndex = ++colorIndex % colors.Length;
                    start += arr[i].Length + 1;
                }
                inputBox.Rtf = demo.Rtf;
                inputBox.SelectionStart = x;
                this.inputBox.Font = new System.Drawing.Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        private void InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (autoValCheckBox.Checked)
                if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !",?:()¬→↔^˅".Contains<char>(e.KeyChar)
                    && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
                    e.KeyChar = '\0';

            if (autoCapCheckBox.Checked)
                e.KeyChar = char.ToUpper(e.KeyChar);

            if (e.KeyChar == ' ') e.KeyChar = '\0';
            else if (e.KeyChar == (char)Keys.Enter && inputBox.TextLength != 0)
            {
                up_downList.AddLast(inputBox.Text);
                up_downNode = up_downList.Last;
                upBtn.Enabled = true;

                if (quesLabel.Visible)
                    AnswerBtn_Click(sender, e);
                else
                    SolveBtn_Click(sender, e);
            }
            else if (e.KeyChar == (char)Keys.Back && inputBox.SelectionStart == 0)
            {
                quesLabel.Visible = false;
                inputBox.Size = new Size(530, 18);
                inputBox.Location = new Point(2, inputBox.Location.Y);
            }
            else if (e.KeyChar == (char)Keys.Up && upBtn.Enabled)
                UpBtn_Click(sender, e);
            else if (e.KeyChar == (char)Keys.Down && downBtn.Enabled)
                DownBtn_Click(sender, e);
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            if (inputBox.Text.Contains<char>(' '))
                inputBox.Text = inputBox.Text.Replace(" ", "");

            if (inputBox.Text.StartsWith("?1") && !quesLabel.Visible)
            {
                quesLabel.Visible = true;
                quesLabel.Text = equRadioBtn.Text;
                inputBox.Size = new Size(inputBox.Width - quesLabel.Width, inputBox.Height);
                inputBox.Location = new Point(quesLabel.Width + 3, inputBox.Location.Y);
                equRadioBtn.Checked = true;
                inputBox.Text = inputBox.Text.Replace("?1", "");
            }
            else if (inputBox.Text.StartsWith("?2") && !quesLabel.Visible)
            {
                quesLabel.Visible = true;
                quesLabel.Text = conRadioBtn.Text;
                inputBox.Size = new Size(inputBox.Width - quesLabel.Width, inputBox.Height);
                inputBox.Location = new Point(quesLabel.Width + 3, inputBox.Location.Y);
                conRadioBtn.Checked = true;
                inputBox.Text = inputBox.Text.Replace("?2", "");
            }
            else if (inputBox.Text.StartsWith("?3") && !quesLabel.Visible)
            {
                quesLabel.Visible = true;
                quesLabel.Text = logConRadio.Text;
                inputBox.Size = new Size(inputBox.Width - quesLabel.Width, inputBox.Height);
                inputBox.Location = new Point(quesLabel.Width + 3, inputBox.Location.Y);
                logConRadio.Checked = true;
                inputBox.Text = inputBox.Text.Replace("?3", "");
            }
        }

        private void SolveBtn_Click(object sender, EventArgs e)
        {
            PL_Base pl;
            try
            {
                holder.Controls.Clear();
                TruthTable truthTable;
                pl = Solve(inputBox.Text, out truthTable);
                if (pl == null) return;

                Point column_loc = new Point(3, 3);
                ColumnOfTable column;
                for (int i = 0; i < pl.TruthTable.Width - 1; i++)
                {
                    column = new ColumnOfTable(truthTable.GetOpTruthValue(i), truthTable.GetOpName(i), truthTable.GetOpType(i));
                    column.Location = column_loc;
                    column_loc.X += column.Width - 1;
                    holder.Controls.Add(column);
                }

                column = new ColumnOfTable(truthTable.GetOpTruthValue(truthTable.Width - 1), "Final", truthTable.GetOpType(truthTable.Width - 1));
                column.Location = column_loc;
                holder.Controls.Add(column);


                logLabel.Text = "Output: " + truthTable.GetOpName(truthTable.Width - 1);
            }
            catch (MalFormedException ex)
            {
                logLabel.Text = ex.Message;
                if (ex.Location != -1)
                {
                    inputBox.SelectionStart = ex.Location - 1;
                    inputBox.SelectionLength = 1;
                    inputBox.Focus();
                }
            }
        }

        private PL_Base Solve(string statement, out TruthTable truthTable)
        {
            PL_Base PL_Statement;
            try
            {
                switch (currentType)
                {
                    case SystemType.PL:
                        PL_Statement = new PL(statement);
                        break;

                    case SystemType.PL_DASH1:
                        PL_Statement = new PL_Dash1(statement);
                        break;

                    case SystemType.PL_DASH2:
                        PL_Statement = new PL_Dash2(statement);
                        break;

                    default:
                        PL_Statement = new PL_Dash3(statement);
                        break;
                }
                PL_Statement.GenerateTruthTable();
                truthTable = PL_Statement.TruthTable;
                return PL_Statement;
            }
            catch (MalFormedException)
            {
                throw;
            }
        }

        private void Op_Click(object sender, EventArgs e)
        {
            inputBox.SelectedText = ((Button)sender).Text;
            inputBox.Focus();
            inputBox.SelectionLength = 0;
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            downBtn.Enabled = true;

            up_downNode = up_downNode.Previous;
            inputBox.Text = up_downNode.Value;
            inputBox.SelectionStart = inputBox.Text.Length;

            if (up_downNode.Value == "")
                upBtn.Enabled = false;
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            upBtn.Enabled = true;

            up_downNode = up_downNode.Next;
            inputBox.Text = up_downNode.Value;
            inputBox.SelectionStart = inputBox.Text.Length;

            if (up_downNode.Next == null)
                downBtn.Enabled = false;
        }

        private void WideBtn_Click(object sender, EventArgs e)
        {
            this.Width = my.Screen.WorkingArea.Width;
            this.Location = new Point(0, this.Location.Y);
            this.fullBtn.Text = "Mini";
        }

        private void TallBtn_Click(object sender, EventArgs e)
        {
            this.Height = my.Screen.WorkingArea.Height;
            this.Location = new Point(this.Location.X, 0);
            this.fullBtn.Text = "Mini";
        }

        private void FullBtn_Click(object sender, EventArgs e)
        {
            if (this.fullBtn.Text == "Full")
            {
                this.Size = MaximumSize;
                this.Location = new Point(0, 0);
                this.fullBtn.Text = "Mini";
            }
            else
            {
                this.Size = MinimumSize;
                this.fullBtn.Text = "Full";
            }
        }

        private void ContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (logLabel.Text.StartsWith("Output: "))
                foreach (ToolStripMenuItem item in contextMenu.Items)
                    item.Enabled = true;
            else
                foreach (ToolStripMenuItem item in contextMenu.Items)
                    item.Enabled = false;

            if (!inputBox.Focused)
                addAtToolStripMenuItem.Enabled = false;
        }

        private void AddFirstMenuItem_Click(object sender, EventArgs e)
        {
            inputBox.SelectionStart = 0;
            inputBox.SelectedText = logLabel.Text.Replace("Output: ", "");
            inputBox.Focus();
        }

        private void AddLastMenuItem_Click(object sender, EventArgs e)
        {
            inputBox.SelectionStart = inputBox.Text.Length;
            inputBox.SelectedText = logLabel.Text.Replace("Output: ", "");
            inputBox.Focus();
        }

        private void AddAtMenuItem_Click(object sender, EventArgs e)
        {
            inputBox.SelectedText = logLabel.Text.Replace("Output: ", "");
            inputBox.Focus();
        }

        private void RamoveAndAddMenuItem_Click(object sender, EventArgs e)
        {
            inputBox.Text = logLabel.Text.Replace("Output: ", "");
            inputBox.Focus();
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            my.Clipboard.SetText(logLabel.Text.Replace("Output: ", ""), TextDataFormat.UnicodeText);
        }

        private void SysBtn_Click(object sender, EventArgs e)
        {
            if (sysPanel.Height <= 160)
            {
                sysShowTimer.Enabled = true;
                convPanel.Height = 50;
                questionPanel.Height = 50;
                configPanel.Height = 50;
            }
            else
            {
                sysPanel.Height = 50;
              
         
            }
        }

        private void SysShow_Tick(object sender, EventArgs e)
        {
            if (sysPanel.Height >= 160) sysShowTimer.Enabled = false;
            this.sysPanel.Height += 4;
        }

        private void AsPL_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in opsPanel.Controls)
                item.Visible = true;
            solveBtn.Text = "Solve In PL";
            currentType = SystemType.PL;
        }

        private void AsPLDash1_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in opsPanel.Controls)
                item.Visible = false;
            not.Visible = implies.Visible = true;
            solveBtn.Text = "Solve in PL Dash 1";
            currentType = SystemType.PL_DASH1;
        }

        private void AsPLDash2_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in opsPanel.Controls)
                item.Visible = false;
            not.Visible = and.Visible = true;
            solveBtn.Text = "Solve in PL Dash 2";
            currentType = SystemType.PL_DASH2;
        }

        private void AsPLDash3_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control item in opsPanel.Controls)
                item.Visible = false;
            not.Visible = or.Visible = true;
            solveBtn.Text = "Solve in PL Dash 3";
            currentType = SystemType.PL_DASH3;
        }

        private void ConvBtn_Click(object sender, EventArgs e)
        {
            if (convPanel.Height <= 160)
            {
                convShowTimer.Enabled = true;
                sysPanel.Height = 50;
                questionPanel.Height = 50;
                configPanel.Height = 50;
            }
            else
            {
                convPanel.Height = 50;
                convShowTimer.Enabled = false; ;
            }
        }

        private void ConvShow_Tick(object sender, EventArgs e)
        {
            if (convPanel.Height >= 160) convShowTimer.Enabled = false;
            this.convPanel.Height += 4;
        }

        private void ToPL_Dash1_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Convertor convertor = new Convertor();
                PL pl = new PL(inputBox.Text);
                string temp = convertor.ToPL_Dash1(pl).PL_Statement;
                logLabel.Text = "Output: " + temp.Substring(1, temp.Length - 2);
            }
            catch (MalFormedException ex)
            {
                logLabel.Text = ex.Message;
            }

        }

        private void ToPL_Dash2_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Convertor convertor = new Convertor();
                PL pl = new PL(inputBox.Text);
                string temp = convertor.ToPL_Dash2(pl).PL_Statement;
                logLabel.Text = "Output: " + temp.Substring(1, temp.Length - 2);
            }
            catch (MalFormedException ex)
            {
                logLabel.Text = ex.Message;
            }

        }

        private void ToPL_Dash3_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Convertor convertor = new Convertor();
                PL pl = new PL(inputBox.Text);
                string temp = convertor.ToPL_Dash3(pl).PL_Statement;
                logLabel.Text = "Output: " + temp.Substring(1, temp.Length - 2);
            }
            catch (MalFormedException ex)
            {
                logLabel.Text = ex.Message;
            }

        }

        private void AskBtn_Click(object sender, EventArgs e)
        {
            if (questionPanel.Height <= 190)
            {
                askShowTimer.Enabled = true;

                sysPanel.Height = 50;
                convPanel.Height = 50;
                configPanel.Height = 50;
            }
            else
            {
                questionPanel.Height = 50;
              
            }
        }

        private void AskShowTimer_Tick(object sender, EventArgs e)
        {
            
            if (questionPanel.Height == 190)
                askShowTimer.Enabled = false;
            questionPanel.Height += 4;
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
        }

        private void ConfigBtn_Click(object sender, EventArgs e)
        {
            if (configPanel.Height <= 80)
            {
                configShowTimer.Enabled = true;
                sysPanel.Height = 34;
                convPanel.Height = 34;
                questionPanel.Height = 34;
            }
        }

        private void ConfigShowTimer_Tick(object sender, EventArgs e)
        {
            if (configPanel.Height >= 80)
                configShowTimer.Enabled = false;
            configPanel.Height += 4;
        }

        private void AutoCapCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoCapCheckBox.Checked)
                inputBox.Text = inputBox.Text.ToUpper();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Do you want to Exit?.",
                "Closing Warn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void Frame_ResizeBegin(object sender, EventArgs e)
        {
            if (holder != null)
                holder.Visible = false;
        }

        private void Frame_ResizeEnd(object sender, EventArgs e)
        {
            if (holder != null)
                holder.Visible = true;
        }
        
        private void Frame_FirstShown(object sender, EventArgs e)
        {
            this.DisplayEffect = FormDisplayEffect.Fade;
        }

       
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void holder_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void conRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void equRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (!equRadioBtn.Checked && !conRadioBtn.Checked && !logConRadio.Checked)
            {
                MessageBox.Show(this, "Select a question first.", "Questions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string[] statements = inputBox.Text.Replace(" ", "").Split(new char[] { ',' });
            if (statements.Length < 2)
            {
                MessageBox.Show(this, "This operation need more than one statement." + Environment.NewLine +
                    "Enter a comma separated statements, select a question then click Answer again.",
                    "Questions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            PL[] pl = new PL[statements.Length];
            for (int i = 0; i < statements.Length; i++)
            {
                try
                {
                    pl[i] = new PL(statements[i]);
                }
                catch (MalFormedException ex)
                {
                    logLabel.Text = "Formmat error at statement " + (i + 1) + ": " + ex.Message;
                    return;
                }
            }

            for (int i = 0; i < statements.Length; i++)
                pl[i].GenerateTruthTable();

            if (equRadioBtn.Checked)
            {
                for (int i = 0; i < pl.Length - 1; i++)
                {
                    if (pl[i].Letters.Length != pl[i + 1].Letters.Length)
                    {
                        MessageBox.Show(this, "Non homogeneous statement!." + Environment.NewLine +
                            "All statements must have equal number of defferent letters.",
                            "Hetrogeneous statements", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                for (int i = 0; i < pl[0].TruthTable.Height; i++)
                {
                    int width;
                    for (int j = 0; j < statements.Length - 1; j++)
                    {
                        width = pl[j].TruthTable.Width;
                        if (pl[j].TruthTable.GetOpTruthValue(pl[j].TruthTable.Width - 1)[i] != pl[j + 1].TruthTable.GetOpTruthValue(pl[j + 1].TruthTable.Width - 1)[i])
                        {
                            logLabel.Text = "The " + statements.Length + " statements are not equivalance";
                            return;
                        }
                    }
                    logLabel.Text = "The " + statements.Length + " statements are equivalance";
                }
            }
            else if (conRadioBtn.Checked)
            {
                for (int i = 0; i < pl.Length - 1; i++)
                {
                    if (pl[i].Letters.Length != pl[i + 1].Letters.Length)
                    {
                        MessageBox.Show(this, "Non homogeneous statement!." + Environment.NewLine +
                            "All statements must have equal number of defferent letters.",
                            "Hetrogeneous statements", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                for (int i = 0; i < pl[0].TruthTable.Height; i++)
                {
                    bool test = false;
                    int width = pl[0].TruthTable.Width;
                    if (pl[0].TruthTable.GetOpTruthValue(width - 1)[i])
                    {
                        test = true;
                        for (int j = 0; j < statements.Length; j++)
                        {
                            width = pl[j].TruthTable.Width;
                            test = test && pl[j].TruthTable.GetOpTruthValue(width - 1)[i];
                        }
                    }
                    if (test)
                    {
                        logLabel.Text = "The " + statements.Length + " statements are consistent";
                        return;
                    }
                }
                logLabel.Text = "The " + statements.Length + " statements are inconsistent";
            }
            else
            {
                string alpha = "(" + statements[0] + ")";
                for (int i = 1; i < statements.Length - 1; i++)
                    alpha += "^(" + statements[i] + ")";

                string beta = statements[statements.Length - 1];

                PL first = new PL(alpha);
                first.GenerateTruthTable();
                PL second = new PL(beta);
                second.GenerateTruthTable();

                PL all = new PL(first.PL_Statement + "^" + second.PL_Statement);
                all.GenerateTruthTable();

                bool[] premises = all.TruthTable.GetOpTruthValue(all.TruthTable.GetIndexOf(first.PL_Statement));
                bool[] concolusion = all.TruthTable.GetOpTruthValue(all.TruthTable.GetIndexOf(second.PL_Statement));

                for (int i = 0; i < all.TruthTable.Height; i++)
                {
                    if (premises[i] && !concolusion[i])
                    {
                        logLabel.Text = "The " + statements.Length + " statements are not logical consequence.";
                        return;
                    }
                }
                logLabel.Text = "The " + statements.Length + " statements are logical consequence.";
            }
        }

        private void autoValCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}