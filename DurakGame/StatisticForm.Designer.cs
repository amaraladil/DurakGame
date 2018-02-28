namespace DurakGame
{
    partial class StatisticForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            this.lblWinsText = new System.Windows.Forms.Label();
            this.lblLossText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTwentyFour = new System.Windows.Forms.Label();
            this.lblThirtySix = new System.Windows.Forms.Label();
            this.lblFiftyTwo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblWinsCount = new System.Windows.Forms.Label();
            this.lblLossCount = new System.Windows.Forms.Label();
            this.lblCountTwentyFour = new System.Windows.Forms.Label();
            this.lblCountThirtySix = new System.Windows.Forms.Label();
            this.lblCountFiftyTwo = new System.Windows.Forms.Label();
            this.lblTieCount = new System.Windows.Forms.Label();
            this.lblTieText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWinsText
            // 
            this.lblWinsText.AutoSize = true;
            this.lblWinsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinsText.ForeColor = System.Drawing.Color.White;
            this.lblWinsText.Location = new System.Drawing.Point(12, 9);
            this.lblWinsText.Name = "lblWinsText";
            this.lblWinsText.Size = new System.Drawing.Size(86, 15);
            this.lblWinsText.TabIndex = 0;
            this.lblWinsText.Text = "Player Wins:";
            // 
            // lblLossText
            // 
            this.lblLossText.AutoSize = true;
            this.lblLossText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossText.ForeColor = System.Drawing.Color.White;
            this.lblLossText.Location = new System.Drawing.Point(12, 64);
            this.lblLossText.Name = "lblLossText";
            this.lblLossText.Size = new System.Drawing.Size(85, 15);
            this.lblLossText.TabIndex = 1;
            this.lblLossText.Text = "Player Loss:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cards Started with:";
            // 
            // lblTwentyFour
            // 
            this.lblTwentyFour.AutoSize = true;
            this.lblTwentyFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwentyFour.ForeColor = System.Drawing.Color.White;
            this.lblTwentyFour.Location = new System.Drawing.Point(59, 132);
            this.lblTwentyFour.Name = "lblTwentyFour";
            this.lblTwentyFour.Size = new System.Drawing.Size(64, 15);
            this.lblTwentyFour.TabIndex = 3;
            this.lblTwentyFour.Text = "24 Cards";
            // 
            // lblThirtySix
            // 
            this.lblThirtySix.AutoSize = true;
            this.lblThirtySix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirtySix.ForeColor = System.Drawing.Color.White;
            this.lblThirtySix.Location = new System.Drawing.Point(59, 160);
            this.lblThirtySix.Name = "lblThirtySix";
            this.lblThirtySix.Size = new System.Drawing.Size(64, 15);
            this.lblThirtySix.TabIndex = 4;
            this.lblThirtySix.Text = "36 Cards";
            // 
            // lblFiftyTwo
            // 
            this.lblFiftyTwo.AutoSize = true;
            this.lblFiftyTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiftyTwo.ForeColor = System.Drawing.Color.White;
            this.lblFiftyTwo.Location = new System.Drawing.Point(59, 184);
            this.lblFiftyTwo.Name = "lblFiftyTwo";
            this.lblFiftyTwo.Size = new System.Drawing.Size(64, 15);
            this.lblFiftyTwo.TabIndex = 5;
            this.lblFiftyTwo.Text = "52 Cards";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(23, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close Statisitic";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(164, 210);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset Statistic";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblWinsCount
            // 
            this.lblWinsCount.AutoSize = true;
            this.lblWinsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinsCount.ForeColor = System.Drawing.Color.White;
            this.lblWinsCount.Location = new System.Drawing.Point(128, 9);
            this.lblWinsCount.Name = "lblWinsCount";
            this.lblWinsCount.Size = new System.Drawing.Size(15, 15);
            this.lblWinsCount.TabIndex = 8;
            this.lblWinsCount.Text = "0";
            // 
            // lblLossCount
            // 
            this.lblLossCount.AutoSize = true;
            this.lblLossCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossCount.ForeColor = System.Drawing.Color.White;
            this.lblLossCount.Location = new System.Drawing.Point(128, 64);
            this.lblLossCount.Name = "lblLossCount";
            this.lblLossCount.Size = new System.Drawing.Size(15, 15);
            this.lblLossCount.TabIndex = 9;
            this.lblLossCount.Text = "0";
            // 
            // lblCountTwentyFour
            // 
            this.lblCountTwentyFour.AutoSize = true;
            this.lblCountTwentyFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountTwentyFour.ForeColor = System.Drawing.Color.White;
            this.lblCountTwentyFour.Location = new System.Drawing.Point(161, 132);
            this.lblCountTwentyFour.Name = "lblCountTwentyFour";
            this.lblCountTwentyFour.Size = new System.Drawing.Size(15, 15);
            this.lblCountTwentyFour.TabIndex = 10;
            this.lblCountTwentyFour.Text = "0";
            // 
            // lblCountThirtySix
            // 
            this.lblCountThirtySix.AutoSize = true;
            this.lblCountThirtySix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountThirtySix.ForeColor = System.Drawing.Color.White;
            this.lblCountThirtySix.Location = new System.Drawing.Point(161, 160);
            this.lblCountThirtySix.Name = "lblCountThirtySix";
            this.lblCountThirtySix.Size = new System.Drawing.Size(15, 15);
            this.lblCountThirtySix.TabIndex = 11;
            this.lblCountThirtySix.Text = "0";
            // 
            // lblCountFiftyTwo
            // 
            this.lblCountFiftyTwo.AutoSize = true;
            this.lblCountFiftyTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountFiftyTwo.ForeColor = System.Drawing.Color.White;
            this.lblCountFiftyTwo.Location = new System.Drawing.Point(161, 184);
            this.lblCountFiftyTwo.Name = "lblCountFiftyTwo";
            this.lblCountFiftyTwo.Size = new System.Drawing.Size(15, 15);
            this.lblCountFiftyTwo.TabIndex = 12;
            this.lblCountFiftyTwo.Text = "0";
            // 
            // lblTieCount
            // 
            this.lblTieCount.AutoSize = true;
            this.lblTieCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieCount.ForeColor = System.Drawing.Color.White;
            this.lblTieCount.Location = new System.Drawing.Point(128, 37);
            this.lblTieCount.Name = "lblTieCount";
            this.lblTieCount.Size = new System.Drawing.Size(15, 15);
            this.lblTieCount.TabIndex = 14;
            this.lblTieCount.Text = "0";
            // 
            // lblTieText
            // 
            this.lblTieText.AutoSize = true;
            this.lblTieText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieText.ForeColor = System.Drawing.Color.White;
            this.lblTieText.Location = new System.Drawing.Point(12, 37);
            this.lblTieText.Name = "lblTieText";
            this.lblTieText.Size = new System.Drawing.Size(75, 15);
            this.lblTieText.TabIndex = 13;
            this.lblTieText.Text = "Player Tie:";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(331, 245);
            this.ControlBox = false;
            this.Controls.Add(this.lblTieCount);
            this.Controls.Add(this.lblTieText);
            this.Controls.Add(this.lblCountFiftyTwo);
            this.Controls.Add(this.lblCountThirtySix);
            this.Controls.Add(this.lblCountTwentyFour);
            this.Controls.Add(this.lblLossCount);
            this.Controls.Add(this.lblWinsCount);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFiftyTwo);
            this.Controls.Add(this.lblThirtySix);
            this.Controls.Add(this.lblTwentyFour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLossText);
            this.Controls.Add(this.lblWinsText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statisitic Report Window";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinsText;
        private System.Windows.Forms.Label lblLossText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTwentyFour;
        private System.Windows.Forms.Label lblThirtySix;
        private System.Windows.Forms.Label lblFiftyTwo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblWinsCount;
        private System.Windows.Forms.Label lblLossCount;
        private System.Windows.Forms.Label lblCountTwentyFour;
        private System.Windows.Forms.Label lblCountThirtySix;
        private System.Windows.Forms.Label lblCountFiftyTwo;
        private System.Windows.Forms.Label lblTieCount;
        private System.Windows.Forms.Label lblTieText;
    }
}