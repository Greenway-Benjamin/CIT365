namespace MegaDesk_Greenway
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.backButton = new System.Windows.Forms.Button();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.depthBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drawersBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.createQuoteButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rushOrderBox = new System.Windows.Forms.ComboBox();
            this.surfaceMaterialBox = new System.Windows.Forms.ComboBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(217, 264);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(122, 38);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(126, 20);
            this.firstNameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(122, 64);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(126, 20);
            this.lastNameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(122, 120);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(44, 20);
            this.widthBox.TabIndex = 5;
            this.widthBox.Validating += new System.ComponentModel.CancelEventHandler(this.validatingWidth);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Depth";
            // 
            // depthBox
            // 
            this.depthBox.Location = new System.Drawing.Point(122, 146);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(44, 20);
            this.depthBox.TabIndex = 7;
            this.depthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthValidate);
            this.depthBox.Validating += new System.ComponentModel.CancelEventHandler(this.validatingDepth);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of Drawers";
            // 
            // drawersBox
            // 
            this.drawersBox.Location = new System.Drawing.Point(122, 172);
            this.drawersBox.Name = "drawersBox";
            this.drawersBox.Size = new System.Drawing.Size(44, 20);
            this.drawersBox.TabIndex = 9;
            this.drawersBox.Validating += new System.ComponentModel.CancelEventHandler(this.validatingDrawers);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Surface Material";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rush Order";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Customer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Desk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "in.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(172, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "in.";
            // 
            // createQuoteButton
            // 
            this.createQuoteButton.Location = new System.Drawing.Point(15, 264);
            this.createQuoteButton.Name = "createQuoteButton";
            this.createQuoteButton.Size = new System.Drawing.Size(95, 23);
            this.createQuoteButton.TabIndex = 20;
            this.createQuoteButton.Text = "Create Quote";
            this.createQuoteButton.UseVisualStyleBackColor = true;
            this.createQuoteButton.Click += new System.EventHandler(this.CreateQuoteButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rushOrderBox
            // 
            this.rushOrderBox.FormattingEnabled = true;
            this.rushOrderBox.Location = new System.Drawing.Point(122, 225);
            this.rushOrderBox.Name = "rushOrderBox";
            this.rushOrderBox.Size = new System.Drawing.Size(126, 21);
            this.rushOrderBox.TabIndex = 15;
            this.rushOrderBox.Validating += new System.ComponentModel.CancelEventHandler(this.validatingRush);
            // 
            // surfaceMaterialBox
            // 
            this.surfaceMaterialBox.FormattingEnabled = true;
            this.surfaceMaterialBox.Location = new System.Drawing.Point(122, 198);
            this.surfaceMaterialBox.Name = "surfaceMaterialBox";
            this.surfaceMaterialBox.Size = new System.Drawing.Size(126, 21);
            this.surfaceMaterialBox.TabIndex = 13;
            this.surfaceMaterialBox.Validating += new System.ComponentModel.CancelEventHandler(this.validatingSurfaceMaterial);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 299);
            this.Controls.Add(this.createQuoteButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rushOrderBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.surfaceMaterialBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drawersBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.backButton);
            this.Name = "AddQuote";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox depthBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox drawersBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button createQuoteButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox rushOrderBox;
        private System.Windows.Forms.ComboBox surfaceMaterialBox;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}