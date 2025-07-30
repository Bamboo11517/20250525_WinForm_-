namespace _20250525_WinForm
{
    partial class Form1
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
            login = new Button();
            userid = new Label();
            pass = new Label();
            txtUserid = new TextBox();
            txtPass = new TextBox();
            timerEmptyCheck = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(148, 194);
            login.Margin = new Padding(2);
            login.Name = "login";
            login.Size = new Size(196, 38);
            login.TabIndex = 0;
            login.Text = "ログイン";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // userid
            // 
            userid.AutoSize = true;
            userid.Location = new Point(99, 36);
            userid.Margin = new Padding(2, 0, 2, 0);
            userid.Name = "userid";
            userid.Size = new Size(46, 15);
            userid.TabIndex = 1;
            userid.Text = "ユーザID";
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(99, 109);
            pass.Margin = new Padding(2, 0, 2, 0);
            pass.Name = "pass";
            pass.Size = new Size(51, 15);
            pass.TabIndex = 2;
            pass.Text = "パスワード";
            pass.Click += pass_Click;
            // 
            // txtUserid
            // 
            txtUserid.Location = new Point(99, 61);
            txtUserid.Margin = new Padding(2);
            txtUserid.MaxLength = 8;
            txtUserid.Name = "txtUserid";
            txtUserid.Size = new Size(294, 23);
            txtUserid.TabIndex = 1;
            txtUserid.KeyPress += NumericalInputControl;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(99, 132);
            txtPass.Margin = new Padding(2);
            txtPass.MaxLength = 10;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(294, 23);
            txtPass.TabIndex = 2;
            // 
            // timerEmptyCheck
            // 
            timerEmptyCheck.Interval = 500;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 288);
            Controls.Add(txtPass);
            Controls.Add(txtUserid);
            Controls.Add(pass);
            Controls.Add(userid);
            Controls.Add(login);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private Label userid;
        private Label pass;
        private TextBox txtUserid;
        private TextBox txtPass;
        private System.Windows.Forms.Timer timerEmptyCheck;
    }
}
