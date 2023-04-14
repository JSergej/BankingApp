namespace BankingApp
{
    partial class FormLogin
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
            this.tblPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNo0 = new System.Windows.Forms.Button();
            this.btnNo9 = new System.Windows.Forms.Button();
            this.btnNo8 = new System.Windows.Forms.Button();
            this.btnNo7 = new System.Windows.Forms.Button();
            this.btnNo6 = new System.Windows.Forms.Button();
            this.btnNo5 = new System.Windows.Forms.Button();
            this.btnNo4 = new System.Windows.Forms.Button();
            this.btnNo3 = new System.Windows.Forms.Button();
            this.btnNo2 = new System.Windows.Forms.Button();
            this.btnNo1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPinNo = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.txtPinNo = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.tblPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPanel1
            // 
            this.tblPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.tblPanel1.ColumnCount = 3;
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblPanel1.Controls.Add(this.button1, 0, 3);
            this.tblPanel1.Controls.Add(this.btnClear, 2, 3);
            this.tblPanel1.Controls.Add(this.btnNo0, 1, 3);
            this.tblPanel1.Controls.Add(this.btnNo9, 2, 2);
            this.tblPanel1.Controls.Add(this.btnNo8, 1, 2);
            this.tblPanel1.Controls.Add(this.btnNo7, 0, 2);
            this.tblPanel1.Controls.Add(this.btnNo6, 2, 1);
            this.tblPanel1.Controls.Add(this.btnNo5, 1, 1);
            this.tblPanel1.Controls.Add(this.btnNo4, 0, 1);
            this.tblPanel1.Controls.Add(this.btnNo3, 2, 0);
            this.tblPanel1.Controls.Add(this.btnNo2, 1, 0);
            this.tblPanel1.Controls.Add(this.btnNo1, 0, 0);
            this.tblPanel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPanel1.Location = new System.Drawing.Point(256, 161);
            this.tblPanel1.Name = "tblPanel1";
            this.tblPanel1.RowCount = 4;
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.89937F));
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.78616F));
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanel1.Size = new System.Drawing.Size(386, 292);
            this.tblPanel1.TabIndex = 17;
            this.tblPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tblPanel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 68);
            this.button1.TabIndex = 34;
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(259, 221);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 68);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNo0
            // 
            this.btnNo0.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo0.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo0.Location = new System.Drawing.Point(131, 221);
            this.btnNo0.Name = "btnNo0";
            this.btnNo0.Size = new System.Drawing.Size(122, 68);
            this.btnNo0.TabIndex = 32;
            this.btnNo0.Text = "0";
            this.btnNo0.UseVisualStyleBackColor = false;
            this.btnNo0.Click += new System.EventHandler(this.KeyPadNum_Click);
            // 
            // btnNo9
            // 
            this.btnNo9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo9.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo9.Location = new System.Drawing.Point(259, 146);
            this.btnNo9.Name = "btnNo9";
            this.btnNo9.Size = new System.Drawing.Size(124, 69);
            this.btnNo9.TabIndex = 30;
            this.btnNo9.Text = "9";
            this.btnNo9.UseVisualStyleBackColor = false;
            this.btnNo9.Click += new System.EventHandler(this.KeyPadNum_Click);
            // 
            // btnNo8
            // 
            this.btnNo8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo8.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo8.Location = new System.Drawing.Point(131, 146);
            this.btnNo8.Name = "btnNo8";
            this.btnNo8.Size = new System.Drawing.Size(122, 69);
            this.btnNo8.TabIndex = 29;
            this.btnNo8.Text = "8";
            this.btnNo8.UseVisualStyleBackColor = false;
            this.btnNo8.Click += new System.EventHandler(this.KeyPadNum_Click);
            // 
            // btnNo7
            // 
            this.btnNo7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo7.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo7.Location = new System.Drawing.Point(3, 146);
            this.btnNo7.Name = "btnNo7";
            this.btnNo7.Size = new System.Drawing.Size(122, 69);
            this.btnNo7.TabIndex = 28;
            this.btnNo7.Text = "7";
            this.btnNo7.UseVisualStyleBackColor = false;
            this.btnNo7.Click += new System.EventHandler(this.KeyPadNum_Click);
            // 
            // btnNo6
            // 
            this.btnNo6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo6.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo6.Location = new System.Drawing.Point(259, 76);
            this.btnNo6.Name = "btnNo6";
            this.btnNo6.Size = new System.Drawing.Size(124, 64);
            this.btnNo6.TabIndex = 27;
            this.btnNo6.Text = "6";
            this.btnNo6.UseVisualStyleBackColor = false;
            this.btnNo6.Click += new System.EventHandler(this.KeyPadNum_Click);
            // 
            // btnNo5
            // 
            this.btnNo5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo5.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo5.Location = new System.Drawing.Point(131, 76);
            this.btnNo5.Name = "btnNo5";
            this.btnNo5.Size = new System.Drawing.Size(122, 64);
            this.btnNo5.TabIndex = 26;
            this.btnNo5.Text = "5";
            this.btnNo5.UseVisualStyleBackColor = false;
            this.btnNo5.Click += new System.EventHandler(this.KeyPadNum_Click);
            // 
            // btnNo4
            // 
            this.btnNo4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo4.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo4.Location = new System.Drawing.Point(3, 76);
            this.btnNo4.Name = "btnNo4";
            this.btnNo4.Size = new System.Drawing.Size(122, 64);
            this.btnNo4.TabIndex = 25;
            this.btnNo4.Text = "4";
            this.btnNo4.UseVisualStyleBackColor = false;
            this.btnNo4.Click += new System.EventHandler(this.KeyPadNum_Click);
            // 
            // btnNo3
            // 
            this.btnNo3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo3.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo3.Location = new System.Drawing.Point(259, 3);
            this.btnNo3.Name = "btnNo3";
            this.btnNo3.Size = new System.Drawing.Size(124, 67);
            this.btnNo3.TabIndex = 24;
            this.btnNo3.Text = "3";
            this.btnNo3.UseVisualStyleBackColor = false;
            this.btnNo3.Click += new System.EventHandler(this.KeyPadNum_Click);
            // 
            // btnNo2
            // 
            this.btnNo2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo2.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo2.Location = new System.Drawing.Point(131, 3);
            this.btnNo2.Name = "btnNo2";
            this.btnNo2.Size = new System.Drawing.Size(122, 67);
            this.btnNo2.TabIndex = 23;
            this.btnNo2.Text = "2";
            this.btnNo2.UseVisualStyleBackColor = false;
            this.btnNo2.Click += new System.EventHandler(this.KeyPadNum_Click);
            // 
            // btnNo1
            // 
            this.btnNo1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo1.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo1.Location = new System.Drawing.Point(3, 3);
            this.btnNo1.Name = "btnNo1";
            this.btnNo1.Size = new System.Drawing.Size(122, 67);
            this.btnNo1.TabIndex = 22;
            this.btnNo1.Text = "1";
            this.btnNo1.UseVisualStyleBackColor = false;
            this.btnNo1.Click += new System.EventHandler(this.KeyPadNum_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 13.82781F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(777, 486);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 67);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLogin.Font = new System.Drawing.Font("Georgia", 13.82781F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(777, 161);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 68);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPinNo
            // 
            this.lblPinNo.AutoSize = true;
            this.lblPinNo.Font = new System.Drawing.Font("Georgia", 13.82781F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPinNo.ForeColor = System.Drawing.Color.Black;
            this.lblPinNo.Location = new System.Drawing.Point(11, 101);
            this.lblPinNo.Name = "lblPinNo";
            this.lblPinNo.Size = new System.Drawing.Size(176, 32);
            this.lblPinNo.TabIndex = 14;
            this.lblPinNo.Text = "Pin Number:";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Font = new System.Drawing.Font("Georgia", 13.82781F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccountNo.ForeColor = System.Drawing.Color.Black;
            this.lblAccountNo.Location = new System.Drawing.Point(11, 30);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(238, 32);
            this.lblAccountNo.TabIndex = 13;
            this.lblAccountNo.Text = "Account Number:";
            // 
            // txtPinNo
            // 
            this.txtPinNo.BackColor = System.Drawing.Color.Azure;
            this.txtPinNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPinNo.Font = new System.Drawing.Font("Verdana", 13.82781F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinNo.Location = new System.Drawing.Point(258, 97);
            this.txtPinNo.MaxLength = 4;
            this.txtPinNo.Multiline = true;
            this.txtPinNo.Name = "txtPinNo";
            this.txtPinNo.PasswordChar = '*';
            this.txtPinNo.ReadOnly = true;
            this.txtPinNo.Size = new System.Drawing.Size(328, 44);
            this.txtPinNo.TabIndex = 12;
            this.txtPinNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPinNo.TextChanged += new System.EventHandler(this.txtPinNo_TextChanged);
            this.txtPinNo.Enter += new System.EventHandler(this.txtPinNo_Enter);
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BackColor = System.Drawing.Color.Azure;
            this.txtAccountNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAccountNo.Font = new System.Drawing.Font("Verdana", 13.82781F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(258, 26);
            this.txtAccountNo.MaxLength = 6;
            this.txtAccountNo.Multiline = true;
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.ReadOnly = true;
            this.txtAccountNo.Size = new System.Drawing.Size(384, 42);
            this.txtAccountNo.TabIndex = 99;
            this.txtAccountNo.TextChanged += new System.EventHandler(this.txtBoxAcc_TextChanged);
            this.txtAccountNo.Enter += new System.EventHandler(this.txtAccountNo_Enter);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(930, 583);
            this.Controls.Add(this.tblPanel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPinNo);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.txtPinNo);
            this.Controls.Add(this.txtAccountNo);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banking_App Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.tblPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNo0;
        private System.Windows.Forms.Button btnNo9;
        private System.Windows.Forms.Button btnNo8;
        private System.Windows.Forms.Button btnNo7;
        private System.Windows.Forms.Button btnNo6;
        private System.Windows.Forms.Button btnNo5;
        private System.Windows.Forms.Button btnNo4;
        private System.Windows.Forms.Button btnNo3;
        private System.Windows.Forms.Button btnNo2;
        private System.Windows.Forms.Button btnNo1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPinNo;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.TextBox txtPinNo;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Button button1;
    }
}

