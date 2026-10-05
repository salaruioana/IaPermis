namespace IaPermis
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelQuiz = new System.Windows.Forms.Panel();
            this.panelStats = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.labelLoginTitle = new System.Windows.Forms.Label();
            this.labelLoginUser = new System.Windows.Forms.Label();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.textBoxLoginUser = new System.Windows.Forms.TextBox();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonGoRegister = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegisterUsername = new System.Windows.Forms.TextBox();
            this.labelRegisterUsername = new System.Windows.Forms.Label();
            this.labelRegisterPassword = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.labelLoginTitle);
            this.panelLogin.Controls.Add(this.labelLoginUser);
            this.panelLogin.Controls.Add(this.labelLoginPassword);
            this.panelLogin.Controls.Add(this.textBoxLoginUser);
            this.panelLogin.Controls.Add(this.textBoxLoginPassword);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.buttonGoRegister);
            this.panelLogin.Location = new System.Drawing.Point(1, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(700, 560);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.Visible = false;
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.buttonRegister);
            this.panelRegister.Controls.Add(this.textBoxRegisterPassword);
            this.panelRegister.Controls.Add(this.textBoxRegisterUsername);
            this.panelRegister.Controls.Add(this.labelRegisterUsername);
            this.panelRegister.Controls.Add(this.labelRegisterPassword);
            this.panelRegister.Location = new System.Drawing.Point(1, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(700, 560);
            this.panelRegister.TabIndex = 1;
            this.panelRegister.Visible = false;
            // 
            // panelMenu
            // 
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(700, 560);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Visible = false;
            // 
            // panelQuiz
            // 
            this.panelQuiz.Location = new System.Drawing.Point(0, 0);
            this.panelQuiz.Name = "panelQuiz";
            this.panelQuiz.Size = new System.Drawing.Size(700, 560);
            this.panelQuiz.TabIndex = 0;
            this.panelQuiz.Visible = false;
            // 
            // panelStats
            // 
            this.panelStats.Location = new System.Drawing.Point(1, 0);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(700, 560);
            this.panelStats.TabIndex = 2;
            this.panelStats.Visible = false;
            // 
            // panelResult
            // 
            this.panelResult.Location = new System.Drawing.Point(1, 0);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(700, 560);
            this.panelResult.TabIndex = 3;
            this.panelResult.Visible = false;
            // 
            // labelLoginTitle
            // 
            this.labelLoginTitle.AutoSize = true;
            this.labelLoginTitle.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelLoginTitle.Location = new System.Drawing.Point(151, 54);
            this.labelLoginTitle.Name = "labelLoginTitle";
            this.labelLoginTitle.Size = new System.Drawing.Size(401, 91);
            this.labelLoginTitle.TabIndex = 0;
            this.labelLoginTitle.Text = "IaPermis";
            // 
            // labelLoginUser
            // 
            this.labelLoginUser.AutoSize = true;
            this.labelLoginUser.BackColor = System.Drawing.Color.PowderBlue;
            this.labelLoginUser.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginUser.Location = new System.Drawing.Point(123, 188);
            this.labelLoginUser.Name = "labelLoginUser";
            this.labelLoginUser.Size = new System.Drawing.Size(123, 39);
            this.labelLoginUser.TabIndex = 1;
            this.labelLoginUser.Text = "Utilizator";
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginPassword.Location = new System.Drawing.Point(150, 254);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(87, 39);
            this.labelLoginPassword.TabIndex = 2;
            this.labelLoginPassword.Text = "Parola";
            // 
            // textBoxLoginUser
            // 
            this.textBoxLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLoginUser.Location = new System.Drawing.Point(300, 189);
            this.textBoxLoginUser.Name = "textBoxLoginUser";
            this.textBoxLoginUser.Size = new System.Drawing.Size(261, 38);
            this.textBoxLoginUser.TabIndex = 3;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLoginPassword.Location = new System.Drawing.Point(300, 254);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PasswordChar = '●';
            this.textBoxLoginPassword.Size = new System.Drawing.Size(261, 38);
            this.textBoxLoginPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.Location = new System.Drawing.Point(82, 363);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(227, 56);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Autentificare";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonGoRegister
            // 
            this.buttonGoRegister.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGoRegister.Location = new System.Drawing.Point(396, 363);
            this.buttonGoRegister.Name = "buttonGoRegister";
            this.buttonGoRegister.Size = new System.Drawing.Size(225, 56);
            this.buttonGoRegister.TabIndex = 6;
            this.buttonGoRegister.Text = "Crează cont";
            this.buttonGoRegister.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRegister.Location = new System.Drawing.Point(207, 298);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(221, 54);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "Înregistrare";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(331, 201);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(231, 38);
            this.textBoxRegisterPassword.TabIndex = 1;
            // 
            // textBoxRegisterUsername
            // 
            this.textBoxRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRegisterUsername.Location = new System.Drawing.Point(331, 131);
            this.textBoxRegisterUsername.Name = "textBoxRegisterUsername";
            this.textBoxRegisterUsername.Size = new System.Drawing.Size(231, 38);
            this.textBoxRegisterUsername.TabIndex = 2;
            // 
            // labelRegisterUsername
            // 
            this.labelRegisterUsername.AutoSize = true;
            this.labelRegisterUsername.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRegisterUsername.Location = new System.Drawing.Point(95, 130);
            this.labelRegisterUsername.Name = "labelRegisterUsername";
            this.labelRegisterUsername.Size = new System.Drawing.Size(196, 39);
            this.labelRegisterUsername.TabIndex = 3;
            this.labelRegisterUsername.Text = "Nume utilizator";
            // 
            // labelRegisterPassword
            // 
            this.labelRegisterPassword.AutoSize = true;
            this.labelRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRegisterPassword.Location = new System.Drawing.Point(96, 195);
            this.labelRegisterPassword.Name = "labelRegisterPassword";
            this.labelRegisterPassword.Size = new System.Drawing.Size(97, 32);
            this.labelRegisterPassword.TabIndex = 4;
            this.labelRegisterPassword.Text = "Parolă";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(682, 513);
            this.Controls.Add(this.panelQuiz);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panelLogin);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 560);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IaPermis";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelQuiz;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label labelLoginTitle;
        private System.Windows.Forms.Label labelLoginUser;
        private System.Windows.Forms.TextBox textBoxLoginUser;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.Button buttonGoRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Label labelRegisterPassword;
        private System.Windows.Forms.Label labelRegisterUsername;
        private System.Windows.Forms.TextBox textBoxRegisterUsername;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.Button buttonRegister;
    }
}

