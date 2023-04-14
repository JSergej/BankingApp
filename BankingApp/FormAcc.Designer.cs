namespace BankingApp
{
    partial class FormAcc
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.tblPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnNo0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnNo9 = new System.Windows.Forms.Button();
            this.btnNo6 = new System.Windows.Forms.Button();
            this.btnNo3 = new System.Windows.Forms.Button();
            this.btnNo2 = new System.Windows.Forms.Button();
            this.btnNo4 = new System.Windows.Forms.Button();
            this.btnNo8 = new System.Windows.Forms.Button();
            this.btnNo5 = new System.Windows.Forms.Button();
            this.btnNo1 = new System.Windows.Forms.Button();
            this.btnNo7 = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.lblAccNo = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAccBal = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.tblPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Azure;
            this.lblMessage.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblMessage.Location = new System.Drawing.Point(28, 519);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(979, 55);
            this.lblMessage.TabIndex = 34;
            // 
            // tblPanel1
            // 
            this.tblPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.tblPanel1.ColumnCount = 3;
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.53846F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.23077F));
            this.tblPanel1.Controls.Add(this.btnBackspace, 2, 3);
            this.tblPanel1.Controls.Add(this.btnNo0, 1, 3);
            this.tblPanel1.Controls.Add(this.btnDot, 0, 3);
            this.tblPanel1.Controls.Add(this.btnNo9, 2, 2);
            this.tblPanel1.Controls.Add(this.btnNo6, 2, 1);
            this.tblPanel1.Controls.Add(this.btnNo3, 2, 0);
            this.tblPanel1.Controls.Add(this.btnNo2, 1, 0);
            this.tblPanel1.Controls.Add(this.btnNo4, 0, 1);
            this.tblPanel1.Controls.Add(this.btnNo8, 1, 2);
            this.tblPanel1.Controls.Add(this.btnNo5, 1, 1);
            this.tblPanel1.Controls.Add(this.btnNo1, 0, 0);
            this.tblPanel1.Controls.Add(this.btnNo7, 0, 2);
            this.tblPanel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblPanel1.Location = new System.Drawing.Point(273, 221);
            this.tblPanel1.Name = "tblPanel1";
            this.tblPanel1.RowCount = 4;
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.45652F));
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.54348F));
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPanel1.Size = new System.Drawing.Size(429, 292);
            this.tblPanel1.TabIndex = 33;
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Location = new System.Drawing.Point(288, 221);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(138, 68);
            this.btnBackspace.TabIndex = 33;
            this.btnBackspace.Text = "Clear";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNo0
            // 
            this.btnNo0.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo0.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo0.Location = new System.Drawing.Point(145, 221);
            this.btnNo0.Name = "btnNo0";
            this.btnNo0.Size = new System.Drawing.Size(137, 68);
            this.btnNo0.TabIndex = 32;
            this.btnNo0.Text = "0";
            this.btnNo0.UseVisualStyleBackColor = false;
            this.btnNo0.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDot.Font = new System.Drawing.Font("Microsoft YaHei", 16.21192F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(3, 221);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(136, 68);
            this.btnDot.TabIndex = 31;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // btnNo9
            // 
            this.btnNo9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo9.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo9.Location = new System.Drawing.Point(288, 147);
            this.btnNo9.Name = "btnNo9";
            this.btnNo9.Size = new System.Drawing.Size(138, 68);
            this.btnNo9.TabIndex = 30;
            this.btnNo9.Text = "9";
            this.btnNo9.UseVisualStyleBackColor = false;
            this.btnNo9.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // btnNo6
            // 
            this.btnNo6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo6.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo6.Location = new System.Drawing.Point(288, 76);
            this.btnNo6.Name = "btnNo6";
            this.btnNo6.Size = new System.Drawing.Size(138, 65);
            this.btnNo6.TabIndex = 27;
            this.btnNo6.Text = "6";
            this.btnNo6.UseVisualStyleBackColor = false;
            this.btnNo6.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // btnNo3
            // 
            this.btnNo3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo3.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo3.Location = new System.Drawing.Point(288, 3);
            this.btnNo3.Name = "btnNo3";
            this.btnNo3.Size = new System.Drawing.Size(138, 67);
            this.btnNo3.TabIndex = 24;
            this.btnNo3.Text = "3";
            this.btnNo3.UseVisualStyleBackColor = false;
            this.btnNo3.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // btnNo2
            // 
            this.btnNo2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo2.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo2.Location = new System.Drawing.Point(145, 3);
            this.btnNo2.Name = "btnNo2";
            this.btnNo2.Size = new System.Drawing.Size(137, 67);
            this.btnNo2.TabIndex = 23;
            this.btnNo2.Text = "2";
            this.btnNo2.UseVisualStyleBackColor = false;
            this.btnNo2.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // btnNo4
            // 
            this.btnNo4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo4.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo4.Location = new System.Drawing.Point(3, 76);
            this.btnNo4.Name = "btnNo4";
            this.btnNo4.Size = new System.Drawing.Size(136, 65);
            this.btnNo4.TabIndex = 25;
            this.btnNo4.Text = "4";
            this.btnNo4.UseVisualStyleBackColor = false;
            this.btnNo4.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // btnNo8
            // 
            this.btnNo8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo8.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo8.Location = new System.Drawing.Point(145, 147);
            this.btnNo8.Name = "btnNo8";
            this.btnNo8.Size = new System.Drawing.Size(137, 68);
            this.btnNo8.TabIndex = 29;
            this.btnNo8.Text = "8";
            this.btnNo8.UseVisualStyleBackColor = false;
            this.btnNo8.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // btnNo5
            // 
            this.btnNo5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo5.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo5.Location = new System.Drawing.Point(145, 76);
            this.btnNo5.Name = "btnNo5";
            this.btnNo5.Size = new System.Drawing.Size(137, 65);
            this.btnNo5.TabIndex = 26;
            this.btnNo5.Text = "5";
            this.btnNo5.UseVisualStyleBackColor = false;
            this.btnNo5.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // btnNo1
            // 
            this.btnNo1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNo1.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo1.Location = new System.Drawing.Point(3, 3);
            this.btnNo1.Name = "btnNo1";
            this.btnNo1.Size = new System.Drawing.Size(136, 67);
            this.btnNo1.TabIndex = 22;
            this.btnNo1.Text = "1";
            this.btnNo1.UseVisualStyleBackColor = false;
            this.btnNo1.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // btnNo7
            // 
            this.btnNo7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNo7.Font = new System.Drawing.Font("Microsoft YaHei", 11.92053F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo7.Location = new System.Drawing.Point(3, 147);
            this.btnNo7.Name = "btnNo7";
            this.btnNo7.Size = new System.Drawing.Size(136, 68);
            this.btnNo7.TabIndex = 28;
            this.btnNo7.Text = "7";
            this.btnNo7.UseVisualStyleBackColor = false;
            this.btnNo7.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.Green;
            this.btnExecute.Font = new System.Drawing.Font("Georgia", 11.92053F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExecute.Location = new System.Drawing.Point(826, 155);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(166, 72);
            this.btnExecute.TabIndex = 32;
            this.btnExecute.Text = "Complete Transaction";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnProceedTransaction_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.Azure;
            this.txtAmount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAmount.Location = new System.Drawing.Point(409, 152);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(290, 41);
            this.txtAmount.TabIndex = 31;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Georgia", 13.82781F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAmount.Location = new System.Drawing.Point(234, 155);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(155, 34);
            this.lblAmount.TabIndex = 30;
            this.lblAmount.Text = "Amount: €";
            // 
            // rbWithdraw
            // 
            this.rbWithdraw.AutoSize = true;
            this.rbWithdraw.Font = new System.Drawing.Font("Georgia", 13.82781F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWithdraw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbWithdraw.Location = new System.Drawing.Point(27, 311);
            this.rbWithdraw.Name = "rbWithdraw";
            this.rbWithdraw.Size = new System.Drawing.Size(169, 38);
            this.rbWithdraw.TabIndex = 29;
            this.rbWithdraw.Text = "Withdraw";
            this.rbWithdraw.UseVisualStyleBackColor = true;
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Checked = true;
            this.rbDeposit.Font = new System.Drawing.Font("Georgia", 13.82781F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeposit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbDeposit.Location = new System.Drawing.Point(27, 258);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(141, 38);
            this.rbDeposit.TabIndex = 28;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Deposit";
            this.rbDeposit.UseVisualStyleBackColor = true;
            // 
            // lblAccNo
            // 
            this.lblAccNo.AutoSize = true;
            this.lblAccNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAccNo.Location = new System.Drawing.Point(293, 22);
            this.lblAccNo.Name = "lblAccNo";
            this.lblAccNo.Size = new System.Drawing.Size(0, 32);
            this.lblAccNo.TabIndex = 27;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBalance.Location = new System.Drawing.Point(293, 69);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 32);
            this.lblBalance.TabIndex = 26;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Georgia", 12.87417F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(826, 441);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(166, 68);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblAccBal
            // 
            this.lblAccBal.AutoSize = true;
            this.lblAccBal.Font = new System.Drawing.Font("Georgia", 13.82781F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccBal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAccBal.Location = new System.Drawing.Point(21, 67);
            this.lblAccBal.Name = "lblAccBal";
            this.lblAccBal.Size = new System.Drawing.Size(237, 34);
            this.lblAccBal.TabIndex = 24;
            this.lblAccBal.Text = "Account Balance:";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Font = new System.Drawing.Font("Georgia", 13.82781F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccountNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAccountNo.Location = new System.Drawing.Point(21, 20);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(243, 34);
            this.lblAccountNo.TabIndex = 23;
            this.lblAccountNo.Text = "Account Number:";
            // 
            // FormAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1033, 583);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tblPanel1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.rbWithdraw);
            this.Controls.Add(this.rbDeposit);
            this.Controls.Add(this.lblAccNo);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblAccBal);
            this.Controls.Add(this.lblAccountNo);
            this.Location = new System.Drawing.Point(250, 200);
            this.Name = "FormAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banking_App Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAcc_FormClosed);
            this.Load += new System.EventHandler(this.FormAcc_Load);
            this.tblPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TableLayoutPanel tblPanel1;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnNo0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnNo9;
        private System.Windows.Forms.Button btnNo8;
        private System.Windows.Forms.Button btnNo7;
        private System.Windows.Forms.Button btnNo6;
        private System.Windows.Forms.Button btnNo5;
        private System.Windows.Forms.Button btnNo4;
        private System.Windows.Forms.Button btnNo3;
        private System.Windows.Forms.Button btnNo2;
        private System.Windows.Forms.Button btnNo1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.RadioButton rbWithdraw;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.Label lblAccNo;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblAccBal;
        private System.Windows.Forms.Label lblAccountNo;
    }
}