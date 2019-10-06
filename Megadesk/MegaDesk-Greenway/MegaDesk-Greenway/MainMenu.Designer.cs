namespace MegaDesk_Greenway
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.newQuote = new System.Windows.Forms.Button();
            this.ViewQuoteButton = new System.Windows.Forms.Button();
            this.searchQuoteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newQuote
            // 
            this.newQuote.Location = new System.Drawing.Point(24, 22);
            this.newQuote.Name = "newQuote";
            this.newQuote.Size = new System.Drawing.Size(127, 45);
            this.newQuote.TabIndex = 0;
            this.newQuote.Text = "&Add New Quote";
            this.newQuote.UseVisualStyleBackColor = true;
            this.newQuote.Click += new System.EventHandler(this.NewQuote_Click);
            // 
            // ViewQuoteButton
            // 
            this.ViewQuoteButton.Location = new System.Drawing.Point(24, 73);
            this.ViewQuoteButton.Name = "ViewQuoteButton";
            this.ViewQuoteButton.Size = new System.Drawing.Size(127, 45);
            this.ViewQuoteButton.TabIndex = 1;
            this.ViewQuoteButton.Text = "&View Quotes";
            this.ViewQuoteButton.UseVisualStyleBackColor = true;
            this.ViewQuoteButton.Click += new System.EventHandler(this.ViewQuoteButton_Click);
            // 
            // searchQuoteButton
            // 
            this.searchQuoteButton.Location = new System.Drawing.Point(24, 124);
            this.searchQuoteButton.Name = "searchQuoteButton";
            this.searchQuoteButton.Size = new System.Drawing.Size(127, 45);
            this.searchQuoteButton.TabIndex = 2;
            this.searchQuoteButton.Text = "&Search Quotes";
            this.searchQuoteButton.UseVisualStyleBackColor = true;
            this.searchQuoteButton.Click += new System.EventHandler(this.SearchQuoteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(24, 175);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(127, 45);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 198);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 248);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchQuoteButton);
            this.Controls.Add(this.ViewQuoteButton);
            this.Controls.Add(this.newQuote);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newQuote;
        private System.Windows.Forms.Button ViewQuoteButton;
        private System.Windows.Forms.Button searchQuoteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

