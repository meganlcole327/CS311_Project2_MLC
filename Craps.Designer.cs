
namespace CS311_Project2_MLC
{
    partial class Craps
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblDice1 = new Label();
            lblDice2 = new Label();
            lblBank = new Label();
            txtBet = new TextBox();
            btnRoll = new Button();
            lblOutcome = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtDiceSum = new TextBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblDice1
            // 
            lblDice1.AutoSize = true;
            lblDice1.Cursor = Cursors.SizeAll;
            lblDice1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDice1.ForeColor = Color.Red;
            lblDice1.Location = new Point(45, 45);
            lblDice1.Name = "lblDice1";
            lblDice1.Size = new Size(77, 27);
            lblDice1.TabIndex = 0;
            lblDice1.Text = "Dice 1";
            lblDice1.Click += lblDice1_Click;
            // 
            // lblDice2
            // 
            lblDice2.AutoSize = true;
            lblDice2.Cursor = Cursors.SizeAll;
            lblDice2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDice2.ForeColor = Color.Red;
            lblDice2.Location = new Point(190, 45);
            lblDice2.Name = "lblDice2";
            lblDice2.Size = new Size(77, 27);
            lblDice2.TabIndex = 1;
            lblDice2.Text = "Dice 2";
            // 
            // lblBank
            // 
            lblBank.AutoSize = true;
            lblBank.Cursor = Cursors.SizeAll;
            lblBank.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBank.ForeColor = Color.FromArgb(0, 0, 192);
            lblBank.Location = new Point(45, 149);
            lblBank.Name = "lblBank";
            lblBank.Size = new Size(155, 27);
            lblBank.TabIndex = 2;
            lblBank.Text = "Bank Balance";
            // 
            // txtBet
            // 
            txtBet.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBet.Location = new Point(45, 202);
            txtBet.Name = "txtBet";
            txtBet.PlaceholderText = "Enter your bet";
            txtBet.Size = new Size(177, 34);
            txtBet.TabIndex = 3;
            // 
            // btnRoll
            // 
            btnRoll.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoll.Location = new Point(45, 258);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(111, 39);
            btnRoll.TabIndex = 4;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblOutcome
            // 
            lblOutcome.AutoSize = true;
            lblOutcome.Cursor = Cursors.SizeAll;
            lblOutcome.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutcome.ForeColor = Color.FromArgb(0, 0, 192);
            lblOutcome.Location = new Point(45, 335);
            lblOutcome.Name = "lblOutcome";
            lblOutcome.Size = new Size(106, 27);
            lblOutcome.TabIndex = 5;
            lblOutcome.Text = "Outcome";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtDiceSum
            // 
            txtDiceSum.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtDiceSum.ForeColor = Color.DarkGray;
            txtDiceSum.Location = new Point(45, 94);
            txtDiceSum.Name = "txtDiceSum";
            txtDiceSum.ReadOnly = true;
            txtDiceSum.Size = new Size(186, 31);
            txtDiceSum.TabIndex = 6;
            txtDiceSum.Text = "Sum of Your Roll:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DimGray;
            btnClear.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.LightGray;
            btnClear.Location = new Point(207, 258);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(148, 39);
            btnClear.TabIndex = 7;
            btnClear.Text = "Reset Game";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Craps
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(621, 390);
            Controls.Add(btnClear);
            Controls.Add(txtDiceSum);
            Controls.Add(lblOutcome);
            Controls.Add(btnRoll);
            Controls.Add(txtBet);
            Controls.Add(lblBank);
            Controls.Add(lblDice2);
            Controls.Add(lblDice1);
            Name = "Craps";
            Text = "Craps";
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblDice1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblDice1;
        private Label lblDice2;
        private Label lblBank;
        private TextBox txtBet;
        private Button btnRoll;
        private Label lblOutcome;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtDiceSum;
        private Button btnClear;
    }
}
