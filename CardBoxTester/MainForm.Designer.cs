namespace CardBoxTester
{
    partial class frmMainForm
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
            this.btnFlipCard = new System.Windows.Forms.Button();
            this.cboCardName = new System.Windows.Forms.ComboBox();
            this.cboSuit = new System.Windows.Forms.ComboBox();
            this.lblClicked = new System.Windows.Forms.Label();
            this.lblFlipped = new System.Windows.Forms.Label();
            this.cbxTestCard = new CardBox.CardBox();
            this.SuspendLayout();
            // 
            // btnFlipCard
            // 
            this.btnFlipCard.Location = new System.Drawing.Point(382, 38);
            this.btnFlipCard.Name = "btnFlipCard";
            this.btnFlipCard.Size = new System.Drawing.Size(75, 23);
            this.btnFlipCard.TabIndex = 0;
            this.btnFlipCard.Text = "&Flip Card";
            this.btnFlipCard.UseVisualStyleBackColor = true;
            this.btnFlipCard.Click += new System.EventHandler(this.btnFlipCard_Click);
            // 
            // cboCardName
            // 
            this.cboCardName.FormattingEnabled = true;
            this.cboCardName.Items.AddRange(new object[] {
            "Ace",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Jack",
            "Queen",
            "King",
            "Joker"});
            this.cboCardName.Location = new System.Drawing.Point(368, 114);
            this.cboCardName.Name = "cboCardName";
            this.cboCardName.Size = new System.Drawing.Size(121, 21);
            this.cboCardName.TabIndex = 1;
            this.cboCardName.SelectedIndexChanged += new System.EventHandler(this.cboCardName_SelectedIndexChanged);
            // 
            // cboSuit
            // 
            this.cboSuit.FormattingEnabled = true;
            this.cboSuit.Items.AddRange(new object[] {
            "Spades",
            "Hearts",
            "Diamonds",
            "Clubs"});
            this.cboSuit.Location = new System.Drawing.Point(368, 77);
            this.cboSuit.Name = "cboSuit";
            this.cboSuit.Size = new System.Drawing.Size(121, 21);
            this.cboSuit.TabIndex = 2;
            this.cboSuit.SelectedIndexChanged += new System.EventHandler(this.cboSuit_SelectedIndexChanged);
            // 
            // lblClicked
            // 
            this.lblClicked.AutoSize = true;
            this.lblClicked.Location = new System.Drawing.Point(35, 370);
            this.lblClicked.Name = "lblClicked";
            this.lblClicked.Size = new System.Drawing.Size(101, 13);
            this.lblClicked.TabIndex = 3;
            this.lblClicked.Text = "Card not clicked yet";
            // 
            // lblFlipped
            // 
            this.lblFlipped.AutoSize = true;
            this.lblFlipped.Location = new System.Drawing.Point(38, 398);
            this.lblFlipped.Name = "lblFlipped";
            this.lblFlipped.Size = new System.Drawing.Size(98, 13);
            this.lblFlipped.TabIndex = 4;
            this.lblFlipped.Text = "Card not flipped yet";
            // 
            // cbxTestCard
            // 
            this.cbxTestCard.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.cbxTestCard.FaceUp = false;
            this.cbxTestCard.Location = new System.Drawing.Point(23, 12);
            this.cbxTestCard.Name = "cbxTestCard";
            this.cbxTestCard.Rank = CardBoxLib.Rank.Ace;
            this.cbxTestCard.Size = new System.Drawing.Size(90, 140);
            this.cbxTestCard.Suit = CardBoxLib.Suit.Hearts;
            this.cbxTestCard.TabIndex = 5;
            this.cbxTestCard.CardFlipped += new System.EventHandler(this.cbxTestCard_CardFlipped);
            this.cbxTestCard.Click += new System.EventHandler(this.cbxTestCard_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 455);
            this.Controls.Add(this.cbxTestCard);
            this.Controls.Add(this.lblFlipped);
            this.Controls.Add(this.lblClicked);
            this.Controls.Add(this.cboSuit);
            this.Controls.Add(this.cboCardName);
            this.Controls.Add(this.btnFlipCard);
            this.Name = "frmMainForm";
            this.Text = "CardBox Test";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlipCard;
        private System.Windows.Forms.ComboBox cboCardName;
        private System.Windows.Forms.ComboBox cboSuit;
        private System.Windows.Forms.Label lblClicked;
        private System.Windows.Forms.Label lblFlipped;
        private CardBox.CardBox cbxTestCard;
    }
}

