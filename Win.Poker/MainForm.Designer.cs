namespace Win.Poker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.cardImage0 = new System.Windows.Forms.PictureBox();
            this.cardImage1 = new System.Windows.Forms.PictureBox();
            this.cardImage2 = new System.Windows.Forms.PictureBox();
            this.cardImage3 = new System.Windows.Forms.PictureBox();
            this.cardImage4 = new System.Windows.Forms.PictureBox();
            this.btnDeal = new System.Windows.Forms.Button();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblHold0 = new System.Windows.Forms.Label();
            this.lblHold1 = new System.Windows.Forms.Label();
            this.lblHold2 = new System.Windows.Forms.Label();
            this.lblHold3 = new System.Windows.Forms.Label();
            this.lblHold4 = new System.Windows.Forms.Label();
            this.lblWinAmount = new System.Windows.Forms.Label();
            this.lblWinType = new System.Windows.Forms.Label();
            this.numBet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDouble = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).BeginInit();
            this.SuspendLayout();
            // 
            // cardImage0
            // 
            this.cardImage0.Location = new System.Drawing.Point(12, 151);
            this.cardImage0.Name = "cardImage0";
            this.cardImage0.Size = new System.Drawing.Size(150, 250);
            this.cardImage0.TabIndex = 0;
            this.cardImage0.TabStop = false;
            this.cardImage0.Click += new System.EventHandler(this.cardImage0_Click);
            // 
            // cardImage1
            // 
            this.cardImage1.Location = new System.Drawing.Point(168, 151);
            this.cardImage1.Name = "cardImage1";
            this.cardImage1.Size = new System.Drawing.Size(150, 250);
            this.cardImage1.TabIndex = 1;
            this.cardImage1.TabStop = false;
            this.cardImage1.Click += new System.EventHandler(this.cardImage1_Click);
            // 
            // cardImage2
            // 
            this.cardImage2.Location = new System.Drawing.Point(324, 151);
            this.cardImage2.Name = "cardImage2";
            this.cardImage2.Size = new System.Drawing.Size(150, 250);
            this.cardImage2.TabIndex = 2;
            this.cardImage2.TabStop = false;
            this.cardImage2.Click += new System.EventHandler(this.cardImage2_Click);
            // 
            // cardImage3
            // 
            this.cardImage3.Location = new System.Drawing.Point(480, 151);
            this.cardImage3.Name = "cardImage3";
            this.cardImage3.Size = new System.Drawing.Size(150, 250);
            this.cardImage3.TabIndex = 3;
            this.cardImage3.TabStop = false;
            this.cardImage3.Click += new System.EventHandler(this.cardImage3_Click);
            // 
            // cardImage4
            // 
            this.cardImage4.Location = new System.Drawing.Point(636, 151);
            this.cardImage4.Name = "cardImage4";
            this.cardImage4.Size = new System.Drawing.Size(150, 250);
            this.cardImage4.TabIndex = 4;
            this.cardImage4.TabStop = false;
            this.cardImage4.Click += new System.EventHandler(this.cardImage4_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.ForeColor = System.Drawing.Color.White;
            this.btnDeal.Location = new System.Drawing.Point(324, 457);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(150, 64);
            this.btnDeal.TabIndex = 5;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(13, 13);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(102, 25);
            this.lblCredit.TabIndex = 6;
            this.lblCredit.Text = "Credit: 0";
            // 
            // lblHold0
            // 
            this.lblHold0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblHold0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHold0.ForeColor = System.Drawing.Color.Red;
            this.lblHold0.Location = new System.Drawing.Point(12, 98);
            this.lblHold0.Name = "lblHold0";
            this.lblHold0.Size = new System.Drawing.Size(150, 50);
            this.lblHold0.TabIndex = 7;
            this.lblHold0.Text = "Hold";
            this.lblHold0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHold0.Visible = false;
            // 
            // lblHold1
            // 
            this.lblHold1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblHold1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHold1.ForeColor = System.Drawing.Color.Red;
            this.lblHold1.Location = new System.Drawing.Point(168, 98);
            this.lblHold1.Name = "lblHold1";
            this.lblHold1.Size = new System.Drawing.Size(150, 50);
            this.lblHold1.TabIndex = 8;
            this.lblHold1.Text = "Hold";
            this.lblHold1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHold1.Visible = false;
            // 
            // lblHold2
            // 
            this.lblHold2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblHold2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHold2.ForeColor = System.Drawing.Color.Red;
            this.lblHold2.Location = new System.Drawing.Point(324, 98);
            this.lblHold2.Name = "lblHold2";
            this.lblHold2.Size = new System.Drawing.Size(150, 50);
            this.lblHold2.TabIndex = 9;
            this.lblHold2.Text = "Hold";
            this.lblHold2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHold2.Visible = false;
            // 
            // lblHold3
            // 
            this.lblHold3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblHold3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHold3.ForeColor = System.Drawing.Color.Red;
            this.lblHold3.Location = new System.Drawing.Point(480, 98);
            this.lblHold3.Name = "lblHold3";
            this.lblHold3.Size = new System.Drawing.Size(150, 50);
            this.lblHold3.TabIndex = 10;
            this.lblHold3.Text = "Hold";
            this.lblHold3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHold3.Visible = false;
            // 
            // lblHold4
            // 
            this.lblHold4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblHold4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHold4.ForeColor = System.Drawing.Color.Red;
            this.lblHold4.Location = new System.Drawing.Point(636, 98);
            this.lblHold4.Name = "lblHold4";
            this.lblHold4.Size = new System.Drawing.Size(150, 50);
            this.lblHold4.TabIndex = 11;
            this.lblHold4.Text = "Hold";
            this.lblHold4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHold4.Visible = false;
            // 
            // lblWinAmount
            // 
            this.lblWinAmount.AutoSize = true;
            this.lblWinAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinAmount.Location = new System.Drawing.Point(477, 13);
            this.lblWinAmount.Name = "lblWinAmount";
            this.lblWinAmount.Size = new System.Drawing.Size(96, 31);
            this.lblWinAmount.TabIndex = 12;
            this.lblWinAmount.Text = "Win: 0";
            this.lblWinAmount.Visible = false;
            // 
            // lblWinType
            // 
            this.lblWinType.AutoSize = true;
            this.lblWinType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinType.Location = new System.Drawing.Point(474, 44);
            this.lblWinType.Name = "lblWinType";
            this.lblWinType.Size = new System.Drawing.Size(83, 31);
            this.lblWinType.TabIndex = 13;
            this.lblWinType.Text = "None";
            this.lblWinType.Visible = false;
            // 
            // numBet
            // 
            this.numBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBet.Location = new System.Drawing.Point(135, 469);
            this.numBet.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numBet.Name = "numBet";
            this.numBet.Size = new System.Drawing.Size(120, 44);
            this.numBet.TabIndex = 14;
            this.numBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBet.ValueChanged += new System.EventHandler(this.numBet_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bet:";
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(555, 484);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(75, 23);
            this.btnDouble.TabIndex = 16;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Visible = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBet);
            this.Controls.Add(this.lblWinType);
            this.Controls.Add(this.lblWinAmount);
            this.Controls.Add(this.lblHold4);
            this.Controls.Add(this.lblHold3);
            this.Controls.Add(this.lblHold2);
            this.Controls.Add(this.lblHold1);
            this.Controls.Add(this.lblHold0);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.cardImage4);
            this.Controls.Add(this.cardImage3);
            this.Controls.Add(this.cardImage2);
            this.Controls.Add(this.cardImage1);
            this.Controls.Add(this.cardImage0);
            this.MaximumSize = new System.Drawing.Size(812, 600);
            this.MinimumSize = new System.Drawing.Size(812, 600);
            this.Name = "MainForm";
            this.Text = "Win.Poker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Leave += new System.EventHandler(this.MainForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.cardImage0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.PictureBox cardImage0;
        private System.Windows.Forms.PictureBox cardImage1;
        private System.Windows.Forms.PictureBox cardImage2;
        private System.Windows.Forms.PictureBox cardImage3;
        private System.Windows.Forms.PictureBox cardImage4;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblHold0;
        private System.Windows.Forms.Label lblHold1;
        private System.Windows.Forms.Label lblHold2;
        private System.Windows.Forms.Label lblHold3;
        private System.Windows.Forms.Label lblHold4;
        private System.Windows.Forms.Label lblWinAmount;
        private System.Windows.Forms.Label lblWinType;
        private System.Windows.Forms.NumericUpDown numBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDouble;
    }
}
