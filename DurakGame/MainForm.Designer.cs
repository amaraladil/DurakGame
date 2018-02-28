namespace DurakGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnClearCards = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblMessageAi = new System.Windows.Forms.Label();
            this.lblMessagePlayer = new System.Windows.Forms.Label();
            this.grpCards = new System.Windows.Forms.GroupBox();
            this.rdoMinCard = new System.Windows.Forms.RadioButton();
            this.rdoMediumCard = new System.Windows.Forms.RadioButton();
            this.rdoMaxDeck = new System.Windows.Forms.RadioButton();
            this.mnuDurakTopStrip = new System.Windows.Forms.MenuStrip();
            this.mnuStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpCards.SuspendLayout();
            this.mnuDurakTopStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearCards
            // 
            this.btnClearCards.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCards.Location = new System.Drawing.Point(833, 186);
            this.btnClearCards.Name = "btnClearCards";
            this.btnClearCards.Size = new System.Drawing.Size(95, 163);
            this.btnClearCards.TabIndex = 2;
            this.btnClearCards.Text = "Clear Cards";
            this.btnClearCards.UseVisualStyleBackColor = false;
            this.btnClearCards.Click += new System.EventHandler(this.btnClearCards_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.White;
            this.lblWarning.Location = new System.Drawing.Point(694, 148);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(95, 16);
            this.lblWarning.TabIndex = 3;
            this.lblWarning.Text = "WarningText";
            // 
            // lblMessageAi
            // 
            this.lblMessageAi.AutoSize = true;
            this.lblMessageAi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageAi.ForeColor = System.Drawing.Color.White;
            this.lblMessageAi.Location = new System.Drawing.Point(88, 148);
            this.lblMessageAi.Name = "lblMessageAi";
            this.lblMessageAi.Size = new System.Drawing.Size(86, 16);
            this.lblMessageAi.TabIndex = 4;
            this.lblMessageAi.Text = "AiMessage";
            // 
            // lblMessagePlayer
            // 
            this.lblMessagePlayer.AutoSize = true;
            this.lblMessagePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessagePlayer.ForeColor = System.Drawing.Color.White;
            this.lblMessagePlayer.Location = new System.Drawing.Point(88, 361);
            this.lblMessagePlayer.Name = "lblMessagePlayer";
            this.lblMessagePlayer.Size = new System.Drawing.Size(117, 16);
            this.lblMessagePlayer.TabIndex = 5;
            this.lblMessagePlayer.Text = "PlayerMessage";
            // 
            // grpCards
            // 
            this.grpCards.Controls.Add(this.rdoMinCard);
            this.grpCards.Controls.Add(this.rdoMediumCard);
            this.grpCards.Controls.Add(this.rdoMaxDeck);
            this.grpCards.ForeColor = System.Drawing.Color.White;
            this.grpCards.Location = new System.Drawing.Point(833, 380);
            this.grpCards.Name = "grpCards";
            this.grpCards.Size = new System.Drawing.Size(103, 106);
            this.grpCards.TabIndex = 6;
            this.grpCards.TabStop = false;
            this.grpCards.Text = "Number Of Cards";
            // 
            // rdoMinCard
            // 
            this.rdoMinCard.AutoSize = true;
            this.rdoMinCard.Checked = true;
            this.rdoMinCard.ForeColor = System.Drawing.Color.White;
            this.rdoMinCard.Location = new System.Drawing.Point(12, 75);
            this.rdoMinCard.Name = "rdoMinCard";
            this.rdoMinCard.Size = new System.Drawing.Size(67, 17);
            this.rdoMinCard.TabIndex = 2;
            this.rdoMinCard.TabStop = true;
            this.rdoMinCard.Text = "24 Cards";
            this.rdoMinCard.UseVisualStyleBackColor = true;
            // 
            // rdoMediumCard
            // 
            this.rdoMediumCard.AutoSize = true;
            this.rdoMediumCard.ForeColor = System.Drawing.Color.White;
            this.rdoMediumCard.Location = new System.Drawing.Point(12, 52);
            this.rdoMediumCard.Name = "rdoMediumCard";
            this.rdoMediumCard.Size = new System.Drawing.Size(67, 17);
            this.rdoMediumCard.TabIndex = 1;
            this.rdoMediumCard.TabStop = true;
            this.rdoMediumCard.Text = "36 Cards";
            this.rdoMediumCard.UseVisualStyleBackColor = true;
            // 
            // rdoMaxDeck
            // 
            this.rdoMaxDeck.AutoSize = true;
            this.rdoMaxDeck.ForeColor = System.Drawing.Color.White;
            this.rdoMaxDeck.Location = new System.Drawing.Point(12, 29);
            this.rdoMaxDeck.Name = "rdoMaxDeck";
            this.rdoMaxDeck.Size = new System.Drawing.Size(67, 17);
            this.rdoMaxDeck.TabIndex = 0;
            this.rdoMaxDeck.TabStop = true;
            this.rdoMaxDeck.Text = "52 Cards";
            this.rdoMaxDeck.UseVisualStyleBackColor = true;
            // 
            // mnuDurakTopStrip
            // 
            this.mnuDurakTopStrip.BackColor = System.Drawing.Color.Gray;
            this.mnuDurakTopStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStatistic});
            this.mnuDurakTopStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuDurakTopStrip.Name = "mnuDurakTopStrip";
            this.mnuDurakTopStrip.Size = new System.Drawing.Size(949, 24);
            this.mnuDurakTopStrip.TabIndex = 7;
            // 
            // mnuStatistic
            // 
            this.mnuStatistic.ForeColor = System.Drawing.Color.White;
            this.mnuStatistic.Name = "mnuStatistic";
            this.mnuStatistic.Size = new System.Drawing.Size(65, 20);
            this.mnuStatistic.Text = "Statistics";
            this.mnuStatistic.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(310, 361);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(72, 16);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "Message";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnClearCards;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(949, 520);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.grpCards);
            this.Controls.Add(this.lblMessagePlayer);
            this.Controls.Add(this.lblMessageAi);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnClearCards);
            this.Controls.Add(this.mnuDurakTopStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuDurakTopStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Durak Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCards.ResumeLayout(false);
            this.grpCards.PerformLayout();
            this.mnuDurakTopStrip.ResumeLayout(false);
            this.mnuDurakTopStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClearCards;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblMessageAi;
        private System.Windows.Forms.Label lblMessagePlayer;
        private System.Windows.Forms.GroupBox grpCards;
        private System.Windows.Forms.RadioButton rdoMinCard;
        private System.Windows.Forms.RadioButton rdoMediumCard;
        private System.Windows.Forms.RadioButton rdoMaxDeck;
        private System.Windows.Forms.MenuStrip mnuDurakTopStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuStatistic;
        private System.Windows.Forms.Label lblMessage;
    }
}

