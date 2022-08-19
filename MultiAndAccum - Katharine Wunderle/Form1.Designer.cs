
namespace MultiAndAccum___Katharine_Wunderle
{
    partial class Form1
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
            this.num1Lbl = new System.Windows.Forms.Label();
            this.num2Lbl = new System.Windows.Forms.Label();
            this.rsltLbl = new System.Windows.Forms.Label();
            this.ttlLbl = new System.Windows.Forms.Label();
            this.num1Inpt = new System.Windows.Forms.TextBox();
            this.num2Inpt = new System.Windows.Forms.TextBox();
            this.xLbl = new System.Windows.Forms.Label();
            this.eqlLbl = new System.Windows.Forms.Label();
            this.rsltOtpt = new System.Windows.Forms.Label();
            this.ttlOtpt = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1Lbl
            // 
            this.num1Lbl.AutoSize = true;
            this.num1Lbl.Location = new System.Drawing.Point(35, 38);
            this.num1Lbl.Name = "num1Lbl";
            this.num1Lbl.Size = new System.Drawing.Size(53, 13);
            this.num1Lbl.TabIndex = 0;
            this.num1Lbl.Text = "Number 1";
            // 
            // num2Lbl
            // 
            this.num2Lbl.AutoSize = true;
            this.num2Lbl.Location = new System.Drawing.Point(156, 38);
            this.num2Lbl.Name = "num2Lbl";
            this.num2Lbl.Size = new System.Drawing.Size(53, 13);
            this.num2Lbl.TabIndex = 1;
            this.num2Lbl.Text = "Number 2";
            // 
            // rsltLbl
            // 
            this.rsltLbl.AutoSize = true;
            this.rsltLbl.Location = new System.Drawing.Point(288, 38);
            this.rsltLbl.Name = "rsltLbl";
            this.rsltLbl.Size = new System.Drawing.Size(37, 13);
            this.rsltLbl.TabIndex = 2;
            this.rsltLbl.Text = "Result";
            // 
            // ttlLbl
            // 
            this.ttlLbl.AutoSize = true;
            this.ttlLbl.Location = new System.Drawing.Point(396, 25);
            this.ttlLbl.Name = "ttlLbl";
            this.ttlLbl.Size = new System.Drawing.Size(86, 26);
            this.ttlLbl.TabIndex = 3;
            this.ttlLbl.Text = "Running Total of\r\nResults So Far";
            this.ttlLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num1Inpt
            // 
            this.num1Inpt.Location = new System.Drawing.Point(12, 54);
            this.num1Inpt.Name = "num1Inpt";
            this.num1Inpt.Size = new System.Drawing.Size(100, 20);
            this.num1Inpt.TabIndex = 4;
            // 
            // num2Inpt
            // 
            this.num2Inpt.Location = new System.Drawing.Point(134, 54);
            this.num2Inpt.Name = "num2Inpt";
            this.num2Inpt.Size = new System.Drawing.Size(100, 20);
            this.num2Inpt.TabIndex = 5;
            // 
            // xLbl
            // 
            this.xLbl.AutoSize = true;
            this.xLbl.Location = new System.Drawing.Point(118, 57);
            this.xLbl.Name = "xLbl";
            this.xLbl.Size = new System.Drawing.Size(12, 13);
            this.xLbl.TabIndex = 6;
            this.xLbl.Text = "x";
            this.xLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eqlLbl
            // 
            this.eqlLbl.AutoSize = true;
            this.eqlLbl.Location = new System.Drawing.Point(242, 57);
            this.eqlLbl.Name = "eqlLbl";
            this.eqlLbl.Size = new System.Drawing.Size(13, 13);
            this.eqlLbl.TabIndex = 7;
            this.eqlLbl.Text = "=";
            this.eqlLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rsltOtpt
            // 
            this.rsltOtpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rsltOtpt.Location = new System.Drawing.Point(261, 54);
            this.rsltOtpt.Name = "rsltOtpt";
            this.rsltOtpt.Size = new System.Drawing.Size(100, 20);
            this.rsltOtpt.TabIndex = 8;
            this.rsltOtpt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ttlOtpt
            // 
            this.ttlOtpt.BackColor = System.Drawing.Color.LightBlue;
            this.ttlOtpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttlOtpt.Location = new System.Drawing.Point(389, 54);
            this.ttlOtpt.Name = "ttlOtpt";
            this.ttlOtpt.Size = new System.Drawing.Size(100, 20);
            this.ttlOtpt.TabIndex = 9;
            this.ttlOtpt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(274, 80);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 10;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(274, 109);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 23);
            this.clrBtn.TabIndex = 11;
            this.clrBtn.Text = "Clear All";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 141);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.ttlOtpt);
            this.Controls.Add(this.rsltOtpt);
            this.Controls.Add(this.eqlLbl);
            this.Controls.Add(this.xLbl);
            this.Controls.Add(this.num2Inpt);
            this.Controls.Add(this.num1Inpt);
            this.Controls.Add(this.ttlLbl);
            this.Controls.Add(this.rsltLbl);
            this.Controls.Add(this.num2Lbl);
            this.Controls.Add(this.num1Lbl);
            this.Name = "Form1";
            this.Text = "Multiply and Accumulate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1Lbl;
        private System.Windows.Forms.Label num2Lbl;
        private System.Windows.Forms.Label rsltLbl;
        private System.Windows.Forms.Label ttlLbl;
        private System.Windows.Forms.TextBox num1Inpt;
        private System.Windows.Forms.TextBox num2Inpt;
        private System.Windows.Forms.Label xLbl;
        private System.Windows.Forms.Label eqlLbl;
        private System.Windows.Forms.Label rsltOtpt;
        private System.Windows.Forms.Label ttlOtpt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button clrBtn;
    }
}

