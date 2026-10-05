/*************************************************************************
* Fișier:          FormMain.Designer.cs
* Autor:           Șalaru Ioana
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Definirea interfeței grafice principale a aplicației.
*************************************************************************/

namespace IaPermis
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonLoginCreateAccount = new System.Windows.Forms.Button();
            this.textBoxLoginUser = new System.Windows.Forms.TextBox();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.buttonLoginHelp = new System.Windows.Forms.Button();
            this.buttonLoginAutentificare = new System.Windows.Forms.Button();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.labelLoginUser = new System.Windows.Forms.Label();
            this.labelLoginTitle = new System.Windows.Forms.Label();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.buttonRegisterHelp = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelRegisterUser = new System.Windows.Forms.Label();
            this.labelRegisterPassword = new System.Windows.Forms.Label();
            this.textBoxRegisterUser = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.labelRegisterTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMenuStatistics = new System.Windows.Forms.Button();
            this.buttonMenuStartQuiz = new System.Windows.Forms.Button();
            this.labelMenuTitle = new System.Windows.Forms.Label();
            this.labelHiUser = new System.Windows.Forms.Label();
            this.buttonMenuLogout = new System.Windows.Forms.Button();
            this.buttonMenuHelp = new System.Windows.Forms.Button();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.labelStatisticsTitle = new System.Windows.Forms.Label();
            this.buttonStatisticsBack = new System.Windows.Forms.Button();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.labelStatisticsAverage = new System.Windows.Forms.Label();
            this.labelStatisticsPassRate = new System.Windows.Forms.Label();
            this.labelStatisticsUser = new System.Windows.Forms.Label();
            this.buttonStatisticsLogout = new System.Windows.Forms.Button();
            this.buttonStatisticsHelp = new System.Windows.Forms.Button();
            this.panelQuiz = new System.Windows.Forms.Panel();
            this.labelQuizTimeTitle = new System.Windows.Forms.Label();
            this.buttonQuizLeave = new System.Windows.Forms.Button();
            this.buttonQuizNext = new System.Windows.Forms.Button();
            this.buttonQuizAnswer2 = new System.Windows.Forms.Button();
            this.buttonQuizAnswer3 = new System.Windows.Forms.Button();
            this.buttonQuizAnswer4 = new System.Windows.Forms.Button();
            this.buttonQuizAnswer1 = new System.Windows.Forms.Button();
            this.labelQuizTimeValue = new System.Windows.Forms.Label();
            this.pictureBoxQuiz = new System.Windows.Forms.PictureBox();
            this.labelQuizWrongAnswers = new System.Windows.Forms.Label();
            this.labelQuizQuestionNumber = new System.Windows.Forms.Label();
            this.labelQuizQuestion = new System.Windows.Forms.Label();
            this.buttonQuizHelp = new System.Windows.Forms.Button();
            this.progressBarQuiz = new System.Windows.Forms.ProgressBar();
            this.panelResults = new System.Windows.Forms.Panel();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.labelResultsMessage = new System.Windows.Forms.Label();
            this.labelResultsNumber = new System.Windows.Forms.Label();
            this.labelResultsHiUser = new System.Windows.Forms.Label();
            this.buttonResultsBackToMenu = new System.Windows.Forms.Button();
            this.buttonResultsSeeStatistics = new System.Windows.Forms.Button();
            this.buttonResultsHelp = new System.Windows.Forms.Button();
            this.buttonResultsLogout = new System.Windows.Forms.Button();
            this.labelResultsTitle = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelStatistics.SuspendLayout();
            this.groupBoxStatistics.SuspendLayout();
            this.panelQuiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuiz)).BeginInit();
            this.panelResults.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.PowderBlue;
            this.panelLogin.BackgroundImage = global::IaPermis.Properties.Resources.backgroundCars1;
            this.panelLogin.Controls.Add(this.buttonLoginCreateAccount);
            this.panelLogin.Controls.Add(this.textBoxLoginUser);
            this.panelLogin.Controls.Add(this.textBoxLoginPassword);
            this.panelLogin.Controls.Add(this.buttonLoginHelp);
            this.panelLogin.Controls.Add(this.buttonLoginAutentificare);
            this.panelLogin.Controls.Add(this.labelLoginPassword);
            this.panelLogin.Controls.Add(this.labelLoginUser);
            this.panelLogin.Controls.Add(this.labelLoginTitle);
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(700, 520);
            this.panelLogin.TabIndex = 6;
            // 
            // buttonLoginCreateAccount
            // 
            this.buttonLoginCreateAccount.BackColor = System.Drawing.Color.LightCyan;
            this.buttonLoginCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoginCreateAccount.Location = new System.Drawing.Point(381, 362);
            this.buttonLoginCreateAccount.Name = "buttonLoginCreateAccount";
            this.buttonLoginCreateAccount.Size = new System.Drawing.Size(155, 43);
            this.buttonLoginCreateAccount.TabIndex = 6;
            this.buttonLoginCreateAccount.Text = "Creare Cont";
            this.buttonLoginCreateAccount.UseVisualStyleBackColor = false;
            this.buttonLoginCreateAccount.Click += new System.EventHandler(this.buttonLoginCreateAccount_Click);
            // 
            // textBoxLoginUser
            // 
            this.textBoxLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLoginUser.Location = new System.Drawing.Point(272, 192);
            this.textBoxLoginUser.Name = "textBoxLoginUser";
            this.textBoxLoginUser.Size = new System.Drawing.Size(210, 30);
            this.textBoxLoginUser.TabIndex = 3;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLoginPassword.Location = new System.Drawing.Point(272, 251);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PasswordChar = '●';
            this.textBoxLoginPassword.Size = new System.Drawing.Size(210, 30);
            this.textBoxLoginPassword.TabIndex = 4;
            // 
            // buttonLoginHelp
            // 
            this.buttonLoginHelp.BackColor = System.Drawing.Color.LightCyan;
            this.buttonLoginHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoginHelp.Location = new System.Drawing.Point(541, 8);
            this.buttonLoginHelp.Name = "buttonLoginHelp";
            this.buttonLoginHelp.Size = new System.Drawing.Size(133, 36);
            this.buttonLoginHelp.TabIndex = 7;
            this.buttonLoginHelp.Text = "Ajutor";
            this.buttonLoginHelp.UseVisualStyleBackColor = false;
            this.buttonLoginHelp.Click += new System.EventHandler(this.buttonLoginHelp_Click);
            // 
            // buttonLoginAutentificare
            // 
            this.buttonLoginAutentificare.BackColor = System.Drawing.Color.LightCyan;
            this.buttonLoginAutentificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoginAutentificare.Location = new System.Drawing.Point(143, 362);
            this.buttonLoginAutentificare.Name = "buttonLoginAutentificare";
            this.buttonLoginAutentificare.Size = new System.Drawing.Size(155, 43);
            this.buttonLoginAutentificare.TabIndex = 5;
            this.buttonLoginAutentificare.Text = "Autentificare";
            this.buttonLoginAutentificare.UseVisualStyleBackColor = false;
            this.buttonLoginAutentificare.Click += new System.EventHandler(this.buttonLoginAutentificare_Click);
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginPassword.Location = new System.Drawing.Point(160, 251);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(74, 25);
            this.labelLoginPassword.TabIndex = 2;
            this.labelLoginPassword.Text = "Parola";
            // 
            // labelLoginUser
            // 
            this.labelLoginUser.AutoSize = true;
            this.labelLoginUser.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginUser.Location = new System.Drawing.Point(139, 192);
            this.labelLoginUser.Name = "labelLoginUser";
            this.labelLoginUser.Size = new System.Drawing.Size(96, 25);
            this.labelLoginUser.TabIndex = 1;
            this.labelLoginUser.Text = "Utilizator";
            // 
            // labelLoginTitle
            // 
            this.labelLoginTitle.AutoSize = true;
            this.labelLoginTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelLoginTitle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginTitle.Location = new System.Drawing.Point(227, 79);
            this.labelLoginTitle.Name = "labelLoginTitle";
            this.labelLoginTitle.Size = new System.Drawing.Size(293, 67);
            this.labelLoginTitle.TabIndex = 0;
            this.labelLoginTitle.Text = "IaPermis";
            // 
            // panelRegister
            // 
            this.panelRegister.BackgroundImage = global::IaPermis.Properties.Resources.backgroundCars1;
            this.panelRegister.Controls.Add(this.buttonRegisterHelp);
            this.panelRegister.Controls.Add(this.buttonRegister);
            this.panelRegister.Controls.Add(this.labelRegisterUser);
            this.panelRegister.Controls.Add(this.labelRegisterPassword);
            this.panelRegister.Controls.Add(this.textBoxRegisterUser);
            this.panelRegister.Controls.Add(this.textBoxRegisterPassword);
            this.panelRegister.Controls.Add(this.labelRegisterTitle);
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(700, 520);
            this.panelRegister.TabIndex = 8;
            this.panelRegister.Visible = false;
            // 
            // buttonRegisterHelp
            // 
            this.buttonRegisterHelp.BackColor = System.Drawing.Color.LightCyan;
            this.buttonRegisterHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRegisterHelp.Location = new System.Drawing.Point(537, 5);
            this.buttonRegisterHelp.Name = "buttonRegisterHelp";
            this.buttonRegisterHelp.Size = new System.Drawing.Size(133, 36);
            this.buttonRegisterHelp.TabIndex = 0;
            this.buttonRegisterHelp.Text = "Ajutor";
            this.buttonRegisterHelp.UseVisualStyleBackColor = false;
            this.buttonRegisterHelp.Click += new System.EventHandler(this.buttonRegisterHelp_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.LightCyan;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRegister.Location = new System.Drawing.Point(236, 362);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(205, 46);
            this.buttonRegister.TabIndex = 1;
            this.buttonRegister.Text = "Creează cont";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelRegisterUser
            // 
            this.labelRegisterUser.AutoSize = true;
            this.labelRegisterUser.BackColor = System.Drawing.Color.Transparent;
            this.labelRegisterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRegisterUser.Location = new System.Drawing.Point(171, 201);
            this.labelRegisterUser.Name = "labelRegisterUser";
            this.labelRegisterUser.Size = new System.Drawing.Size(96, 25);
            this.labelRegisterUser.TabIndex = 2;
            this.labelRegisterUser.Text = "Utilizator";
            // 
            // labelRegisterPassword
            // 
            this.labelRegisterPassword.AutoSize = true;
            this.labelRegisterPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRegisterPassword.Location = new System.Drawing.Point(171, 273);
            this.labelRegisterPassword.Name = "labelRegisterPassword";
            this.labelRegisterPassword.Size = new System.Drawing.Size(74, 25);
            this.labelRegisterPassword.TabIndex = 3;
            this.labelRegisterPassword.Text = "Parola";
            // 
            // textBoxRegisterUser
            // 
            this.textBoxRegisterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRegisterUser.Location = new System.Drawing.Point(295, 198);
            this.textBoxRegisterUser.Name = "textBoxRegisterUser";
            this.textBoxRegisterUser.Size = new System.Drawing.Size(187, 30);
            this.textBoxRegisterUser.TabIndex = 4;
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(295, 267);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.PasswordChar = '●';
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(187, 30);
            this.textBoxRegisterPassword.TabIndex = 5;
            // 
            // labelRegisterTitle
            // 
            this.labelRegisterTitle.AutoSize = true;
            this.labelRegisterTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelRegisterTitle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRegisterTitle.Location = new System.Drawing.Point(227, 88);
            this.labelRegisterTitle.Name = "labelRegisterTitle";
            this.labelRegisterTitle.Size = new System.Drawing.Size(293, 67);
            this.labelRegisterTitle.TabIndex = 6;
            this.labelRegisterTitle.Text = "IaPermis";
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = global::IaPermis.Properties.Resources.backgroundCars1;
            this.panelMenu.Controls.Add(this.buttonMenuStatistics);
            this.panelMenu.Controls.Add(this.buttonMenuStartQuiz);
            this.panelMenu.Controls.Add(this.labelMenuTitle);
            this.panelMenu.Controls.Add(this.labelHiUser);
            this.panelMenu.Controls.Add(this.buttonMenuLogout);
            this.panelMenu.Controls.Add(this.buttonMenuHelp);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(700, 520);
            this.panelMenu.TabIndex = 7;
            this.panelMenu.Visible = false;
            // 
            // buttonMenuStatistics
            // 
            this.buttonMenuStatistics.BackColor = System.Drawing.Color.LightCyan;
            this.buttonMenuStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuStatistics.Location = new System.Drawing.Point(220, 321);
            this.buttonMenuStatistics.Name = "buttonMenuStatistics";
            this.buttonMenuStatistics.Size = new System.Drawing.Size(249, 45);
            this.buttonMenuStatistics.TabIndex = 5;
            this.buttonMenuStatistics.Text = "Vezi statistici";
            this.buttonMenuStatistics.UseVisualStyleBackColor = false;
            this.buttonMenuStatistics.Click += new System.EventHandler(this.buttonMenuStatistics_Click);
            // 
            // buttonMenuStartQuiz
            // 
            this.buttonMenuStartQuiz.BackColor = System.Drawing.Color.LightCyan;
            this.buttonMenuStartQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuStartQuiz.Location = new System.Drawing.Point(220, 236);
            this.buttonMenuStartQuiz.Name = "buttonMenuStartQuiz";
            this.buttonMenuStartQuiz.Size = new System.Drawing.Size(249, 41);
            this.buttonMenuStartQuiz.TabIndex = 4;
            this.buttonMenuStartQuiz.Text = "Începe quiz";
            this.buttonMenuStartQuiz.UseVisualStyleBackColor = false;
            this.buttonMenuStartQuiz.Click += new System.EventHandler(this.buttonMenuStartQuiz_Click);
            // 
            // labelMenuTitle
            // 
            this.labelMenuTitle.AutoSize = true;
            this.labelMenuTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelMenuTitle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMenuTitle.Location = new System.Drawing.Point(227, 122);
            this.labelMenuTitle.Name = "labelMenuTitle";
            this.labelMenuTitle.Size = new System.Drawing.Size(293, 67);
            this.labelMenuTitle.TabIndex = 3;
            this.labelMenuTitle.Text = "IaPermis";
            // 
            // labelHiUser
            // 
            this.labelHiUser.AutoSize = true;
            this.labelHiUser.BackColor = System.Drawing.Color.Transparent;
            this.labelHiUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHiUser.Location = new System.Drawing.Point(503, 42);
            this.labelHiUser.Name = "labelHiUser";
            this.labelHiUser.Size = new System.Drawing.Size(69, 25);
            this.labelHiUser.TabIndex = 2;
            this.labelHiUser.Text = "Salut!";
            // 
            // buttonMenuLogout
            // 
            this.buttonMenuLogout.BackColor = System.Drawing.Color.LightCyan;
            this.buttonMenuLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuLogout.Location = new System.Drawing.Point(404, 3);
            this.buttonMenuLogout.Name = "buttonMenuLogout";
            this.buttonMenuLogout.Size = new System.Drawing.Size(133, 36);
            this.buttonMenuLogout.TabIndex = 1;
            this.buttonMenuLogout.Text = "Delogare";
            this.buttonMenuLogout.UseVisualStyleBackColor = false;
            this.buttonMenuLogout.Click += new System.EventHandler(this.buttonMenuLogout_Click);
            // 
            // buttonMenuHelp
            // 
            this.buttonMenuHelp.BackColor = System.Drawing.Color.LightCyan;
            this.buttonMenuHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMenuHelp.Location = new System.Drawing.Point(543, 3);
            this.buttonMenuHelp.Name = "buttonMenuHelp";
            this.buttonMenuHelp.Size = new System.Drawing.Size(133, 36);
            this.buttonMenuHelp.TabIndex = 0;
            this.buttonMenuHelp.Text = "Ajutor";
            this.buttonMenuHelp.UseVisualStyleBackColor = false;
            this.buttonMenuHelp.Click += new System.EventHandler(this.buttonMenuHelp_Click);
            // 
            // panelStatistics
            // 
            this.panelStatistics.BackgroundImage = global::IaPermis.Properties.Resources.backgroundCars1;
            this.panelStatistics.Controls.Add(this.labelStatisticsTitle);
            this.panelStatistics.Controls.Add(this.buttonStatisticsBack);
            this.panelStatistics.Controls.Add(this.groupBoxStatistics);
            this.panelStatistics.Controls.Add(this.buttonStatisticsLogout);
            this.panelStatistics.Controls.Add(this.buttonStatisticsHelp);
            this.panelStatistics.Location = new System.Drawing.Point(0, 0);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(700, 520);
            this.panelStatistics.TabIndex = 6;
            this.panelStatistics.Visible = false;
            // 
            // labelStatisticsTitle
            // 
            this.labelStatisticsTitle.AutoSize = true;
            this.labelStatisticsTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelStatisticsTitle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatisticsTitle.Location = new System.Drawing.Point(227, 79);
            this.labelStatisticsTitle.Name = "labelStatisticsTitle";
            this.labelStatisticsTitle.Size = new System.Drawing.Size(293, 67);
            this.labelStatisticsTitle.TabIndex = 5;
            this.labelStatisticsTitle.Text = "IaPermis";
            // 
            // buttonStatisticsBack
            // 
            this.buttonStatisticsBack.BackColor = System.Drawing.Color.LightCyan;
            this.buttonStatisticsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStatisticsBack.Location = new System.Drawing.Point(256, 372);
            this.buttonStatisticsBack.Name = "buttonStatisticsBack";
            this.buttonStatisticsBack.Size = new System.Drawing.Size(185, 53);
            this.buttonStatisticsBack.TabIndex = 10;
            this.buttonStatisticsBack.Text = "Înapoi la meniu";
            this.buttonStatisticsBack.UseVisualStyleBackColor = false;
            this.buttonStatisticsBack.Click += new System.EventHandler(this.buttonStatisticsBack_Click);
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.BackColor = System.Drawing.Color.LightCyan;
            this.groupBoxStatistics.Controls.Add(this.labelStatisticsAverage);
            this.groupBoxStatistics.Controls.Add(this.labelStatisticsPassRate);
            this.groupBoxStatistics.Controls.Add(this.labelStatisticsUser);
            this.groupBoxStatistics.Location = new System.Drawing.Point(175, 158);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(327, 183);
            this.groupBoxStatistics.TabIndex = 11;
            this.groupBoxStatistics.TabStop = false;
            // 
            // labelStatisticsAverage
            // 
            this.labelStatisticsAverage.AutoSize = true;
            this.labelStatisticsAverage.BackColor = System.Drawing.Color.Transparent;
            this.labelStatisticsAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatisticsAverage.Location = new System.Drawing.Point(79, 138);
            this.labelStatisticsAverage.Name = "labelStatisticsAverage";
            this.labelStatisticsAverage.Size = new System.Drawing.Size(234, 29);
            this.labelStatisticsAverage.TabIndex = 9;
            this.labelStatisticsAverage.Text = "Scor mediu: NN/26";
            // 
            // labelStatisticsPassRate
            // 
            this.labelStatisticsPassRate.AutoSize = true;
            this.labelStatisticsPassRate.BackColor = System.Drawing.Color.Transparent;
            this.labelStatisticsPassRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatisticsPassRate.Location = new System.Drawing.Point(57, 78);
            this.labelStatisticsPassRate.Name = "labelStatisticsPassRate";
            this.labelStatisticsPassRate.Size = new System.Drawing.Size(280, 29);
            this.labelStatisticsPassRate.TabIndex = 8;
            this.labelStatisticsPassRate.Text = "Rata de trecere: xx.x %";
            // 
            // labelStatisticsUser
            // 
            this.labelStatisticsUser.AutoSize = true;
            this.labelStatisticsUser.BackColor = System.Drawing.Color.Transparent;
            this.labelStatisticsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatisticsUser.Location = new System.Drawing.Point(69, 19);
            this.labelStatisticsUser.Name = "labelStatisticsUser";
            this.labelStatisticsUser.Size = new System.Drawing.Size(249, 29);
            this.labelStatisticsUser.TabIndex = 7;
            this.labelStatisticsUser.Text = "Utilizator: numeUser";
            // 
            // buttonStatisticsLogout
            // 
            this.buttonStatisticsLogout.BackColor = System.Drawing.Color.LightCyan;
            this.buttonStatisticsLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStatisticsLogout.Location = new System.Drawing.Point(402, 8);
            this.buttonStatisticsLogout.Name = "buttonStatisticsLogout";
            this.buttonStatisticsLogout.Size = new System.Drawing.Size(133, 36);
            this.buttonStatisticsLogout.TabIndex = 6;
            this.buttonStatisticsLogout.Text = "Delogare";
            this.buttonStatisticsLogout.UseVisualStyleBackColor = false;
            this.buttonStatisticsLogout.Click += new System.EventHandler(this.buttonStatisticsLogout_Click);
            // 
            // buttonStatisticsHelp
            // 
            this.buttonStatisticsHelp.BackColor = System.Drawing.Color.LightCyan;
            this.buttonStatisticsHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStatisticsHelp.Location = new System.Drawing.Point(541, 8);
            this.buttonStatisticsHelp.Name = "buttonStatisticsHelp";
            this.buttonStatisticsHelp.Size = new System.Drawing.Size(133, 36);
            this.buttonStatisticsHelp.TabIndex = 4;
            this.buttonStatisticsHelp.Text = "Ajutor";
            this.buttonStatisticsHelp.UseVisualStyleBackColor = false;
            this.buttonStatisticsHelp.Click += new System.EventHandler(this.buttonStatisticsHelp_Click);
            // 
            // panelQuiz
            // 
            this.panelQuiz.BackgroundImage = global::IaPermis.Properties.Resources.backgroundCars1;
            this.panelQuiz.Controls.Add(this.labelQuizTimeTitle);
            this.panelQuiz.Controls.Add(this.buttonQuizLeave);
            this.panelQuiz.Controls.Add(this.buttonQuizNext);
            this.panelQuiz.Controls.Add(this.buttonQuizAnswer2);
            this.panelQuiz.Controls.Add(this.buttonQuizAnswer3);
            this.panelQuiz.Controls.Add(this.buttonQuizAnswer4);
            this.panelQuiz.Controls.Add(this.buttonQuizAnswer1);
            this.panelQuiz.Controls.Add(this.labelQuizTimeValue);
            this.panelQuiz.Controls.Add(this.pictureBoxQuiz);
            this.panelQuiz.Controls.Add(this.labelQuizWrongAnswers);
            this.panelQuiz.Controls.Add(this.labelQuizQuestionNumber);
            this.panelQuiz.Controls.Add(this.labelQuizQuestion);
            this.panelQuiz.Controls.Add(this.buttonQuizHelp);
            this.panelQuiz.Controls.Add(this.progressBarQuiz);
            this.panelQuiz.Location = new System.Drawing.Point(0, 0);
            this.panelQuiz.Name = "panelQuiz";
            this.panelQuiz.Size = new System.Drawing.Size(700, 520);
            this.panelQuiz.TabIndex = 0;
            this.panelQuiz.Visible = false;
            // 
            // labelQuizTimeTitle
            // 
            this.labelQuizTimeTitle.AutoSize = true;
            this.labelQuizTimeTitle.BackColor = System.Drawing.Color.LightCyan;
            this.labelQuizTimeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuizTimeTitle.Location = new System.Drawing.Point(568, 67);
            this.labelQuizTimeTitle.Name = "labelQuizTimeTitle";
            this.labelQuizTimeTitle.Size = new System.Drawing.Size(108, 20);
            this.labelQuizTimeTitle.TabIndex = 17;
            this.labelQuizTimeTitle.Text = "Timp rămas";
            // 
            // buttonQuizLeave
            // 
            this.buttonQuizLeave.BackColor = System.Drawing.Color.LightCyan;
            this.buttonQuizLeave.Location = new System.Drawing.Point(8, 465);
            this.buttonQuizLeave.Name = "buttonQuizLeave";
            this.buttonQuizLeave.Size = new System.Drawing.Size(159, 37);
            this.buttonQuizLeave.TabIndex = 15;
            this.buttonQuizLeave.Text = "Părăsește progresul";
            this.buttonQuizLeave.UseVisualStyleBackColor = false;
            this.buttonQuizLeave.Click += new System.EventHandler(this.buttonQuizLeave_Click);
            // 
            // buttonQuizNext
            // 
            this.buttonQuizNext.BackColor = System.Drawing.Color.LightCyan;
            this.buttonQuizNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonQuizNext.Location = new System.Drawing.Point(545, 465);
            this.buttonQuizNext.Name = "buttonQuizNext";
            this.buttonQuizNext.Size = new System.Drawing.Size(131, 37);
            this.buttonQuizNext.TabIndex = 16;
            this.buttonQuizNext.Text = "Continuă";
            this.buttonQuizNext.UseVisualStyleBackColor = false;
            this.buttonQuizNext.Click += new System.EventHandler(this.buttonQuizNext_Click);
            // 
            // buttonQuizAnswer2
            // 
            this.buttonQuizAnswer2.BackColor = System.Drawing.Color.LightCyan;
            this.buttonQuizAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonQuizAnswer2.Location = new System.Drawing.Point(19, 393);
            this.buttonQuizAnswer2.Name = "buttonQuizAnswer2";
            this.buttonQuizAnswer2.Size = new System.Drawing.Size(309, 62);
            this.buttonQuizAnswer2.TabIndex = 12;
            this.buttonQuizAnswer2.Text = "Răspuns 2";
            this.buttonQuizAnswer2.UseVisualStyleBackColor = false;
            this.buttonQuizAnswer2.Click += new System.EventHandler(this.buttonQuizAnswer2_Click);
            // 
            // buttonQuizAnswer3
            // 
            this.buttonQuizAnswer3.BackColor = System.Drawing.Color.LightCyan;
            this.buttonQuizAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonQuizAnswer3.Location = new System.Drawing.Point(343, 320);
            this.buttonQuizAnswer3.Name = "buttonQuizAnswer3";
            this.buttonQuizAnswer3.Size = new System.Drawing.Size(309, 62);
            this.buttonQuizAnswer3.TabIndex = 13;
            this.buttonQuizAnswer3.Text = "Răspuns 3";
            this.buttonQuizAnswer3.UseVisualStyleBackColor = false;
            this.buttonQuizAnswer3.Click += new System.EventHandler(this.buttonQuizAnswer3_Click);
            // 
            // buttonQuizAnswer4
            // 
            this.buttonQuizAnswer4.BackColor = System.Drawing.Color.LightCyan;
            this.buttonQuizAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonQuizAnswer4.Location = new System.Drawing.Point(343, 393);
            this.buttonQuizAnswer4.Name = "buttonQuizAnswer4";
            this.buttonQuizAnswer4.Size = new System.Drawing.Size(309, 62);
            this.buttonQuizAnswer4.TabIndex = 14;
            this.buttonQuizAnswer4.Text = "Răspuns 4";
            this.buttonQuizAnswer4.UseVisualStyleBackColor = false;
            this.buttonQuizAnswer4.Click += new System.EventHandler(this.buttonQuizAnswer4_Click);
            // 
            // buttonQuizAnswer1
            // 
            this.buttonQuizAnswer1.BackColor = System.Drawing.Color.LightCyan;
            this.buttonQuizAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonQuizAnswer1.Location = new System.Drawing.Point(19, 320);
            this.buttonQuizAnswer1.Name = "buttonQuizAnswer1";
            this.buttonQuizAnswer1.Size = new System.Drawing.Size(309, 62);
            this.buttonQuizAnswer1.TabIndex = 11;
            this.buttonQuizAnswer1.Text = "Răspuns 1";
            this.buttonQuizAnswer1.UseVisualStyleBackColor = false;
            this.buttonQuizAnswer1.Click += new System.EventHandler(this.buttonQuizAnswer1_Click);
            // 
            // labelQuizTimeValue
            // 
            this.labelQuizTimeValue.AutoSize = true;
            this.labelQuizTimeValue.BackColor = System.Drawing.Color.LightCyan;
            this.labelQuizTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuizTimeValue.Location = new System.Drawing.Point(597, 100);
            this.labelQuizTimeValue.Name = "labelQuizTimeValue";
            this.labelQuizTimeValue.Size = new System.Drawing.Size(47, 25);
            this.labelQuizTimeValue.TabIndex = 10;
            this.labelQuizTimeValue.Text = "30s";
            // 
            // pictureBoxQuiz
            // 
            this.pictureBoxQuiz.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBoxQuiz.Location = new System.Drawing.Point(11, 142);
            this.pictureBoxQuiz.MaximumSize = new System.Drawing.Size(530, 157);
            this.pictureBoxQuiz.Name = "pictureBoxQuiz";
            this.pictureBoxQuiz.Size = new System.Drawing.Size(524, 157);
            this.pictureBoxQuiz.TabIndex = 9;
            this.pictureBoxQuiz.TabStop = false;
            // 
            // labelQuizWrongAnswers
            // 
            this.labelQuizWrongAnswers.AutoSize = true;
            this.labelQuizWrongAnswers.BackColor = System.Drawing.Color.LightCyan;
            this.labelQuizWrongAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuizWrongAnswers.Location = new System.Drawing.Point(580, 177);
            this.labelQuizWrongAnswers.Name = "labelQuizWrongAnswers";
            this.labelQuizWrongAnswers.Size = new System.Drawing.Size(96, 20);
            this.labelQuizWrongAnswers.TabIndex = 8;
            this.labelQuizWrongAnswers.Text = "Greșeli: 0/3";
            // 
            // labelQuizQuestionNumber
            // 
            this.labelQuizQuestionNumber.AutoSize = true;
            this.labelQuizQuestionNumber.BackColor = System.Drawing.Color.LightCyan;
            this.labelQuizQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuizQuestionNumber.Location = new System.Drawing.Point(568, 142);
            this.labelQuizQuestionNumber.Name = "labelQuizQuestionNumber";
            this.labelQuizQuestionNumber.Size = new System.Drawing.Size(108, 20);
            this.labelQuizQuestionNumber.TabIndex = 7;
            this.labelQuizQuestionNumber.Text = "Număr: xx/26";
            // 
            // labelQuizQuestion
            // 
            this.labelQuizQuestion.BackColor = System.Drawing.Color.LightCyan;
            this.labelQuizQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuizQuestion.Location = new System.Drawing.Point(7, 55);
            this.labelQuizQuestion.Name = "labelQuizQuestion";
            this.labelQuizQuestion.Size = new System.Drawing.Size(530, 78);
            this.labelQuizQuestion.TabIndex = 6;
            this.labelQuizQuestion.Text = "Text întrebare...";
            // 
            // buttonQuizHelp
            // 
            this.buttonQuizHelp.BackColor = System.Drawing.Color.LightCyan;
            this.buttonQuizHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonQuizHelp.Location = new System.Drawing.Point(537, 12);
            this.buttonQuizHelp.Name = "buttonQuizHelp";
            this.buttonQuizHelp.Size = new System.Drawing.Size(133, 36);
            this.buttonQuizHelp.TabIndex = 5;
            this.buttonQuizHelp.Text = "Ajutor";
            this.buttonQuizHelp.UseVisualStyleBackColor = false;
            this.buttonQuizHelp.Click += new System.EventHandler(this.buttonQuizHelp_Click);
            // 
            // progressBarQuiz
            // 
            this.progressBarQuiz.BackColor = System.Drawing.Color.LightCyan;
            this.progressBarQuiz.ForeColor = System.Drawing.Color.CadetBlue;
            this.progressBarQuiz.Location = new System.Drawing.Point(10, 13);
            this.progressBarQuiz.Name = "progressBarQuiz";
            this.progressBarQuiz.Size = new System.Drawing.Size(477, 30);
            this.progressBarQuiz.TabIndex = 0;
            // 
            // panelResults
            // 
            this.panelResults.BackgroundImage = global::IaPermis.Properties.Resources.backgroundCars1;
            this.panelResults.Controls.Add(this.groupBoxResults);
            this.panelResults.Controls.Add(this.labelResultsHiUser);
            this.panelResults.Controls.Add(this.buttonResultsBackToMenu);
            this.panelResults.Controls.Add(this.buttonResultsSeeStatistics);
            this.panelResults.Controls.Add(this.buttonResultsHelp);
            this.panelResults.Controls.Add(this.buttonResultsLogout);
            this.panelResults.Controls.Add(this.labelResultsTitle);
            this.panelResults.Location = new System.Drawing.Point(0, 0);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(700, 520);
            this.panelResults.TabIndex = 18;
            this.panelResults.Visible = false;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBoxResults.Controls.Add(this.labelResultsMessage);
            this.groupBoxResults.Controls.Add(this.labelResultsNumber);
            this.groupBoxResults.Location = new System.Drawing.Point(121, 152);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(410, 167);
            this.groupBoxResults.TabIndex = 13;
            this.groupBoxResults.TabStop = false;
            // 
            // labelResultsMessage
            // 
            this.labelResultsMessage.AutoSize = true;
            this.labelResultsMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResultsMessage.Location = new System.Drawing.Point(90, 106);
            this.labelResultsMessage.Name = "labelResultsMessage";
            this.labelResultsMessage.Size = new System.Drawing.Size(268, 32);
            this.labelResultsMessage.TabIndex = 1;
            this.labelResultsMessage.Text = "Felicitări, ai trecut!";
            // 
            // labelResultsNumber
            // 
            this.labelResultsNumber.AutoSize = true;
            this.labelResultsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResultsNumber.Location = new System.Drawing.Point(112, 29);
            this.labelResultsNumber.Name = "labelResultsNumber";
            this.labelResultsNumber.Size = new System.Drawing.Size(217, 32);
            this.labelResultsNumber.TabIndex = 0;
            this.labelResultsNumber.Text = "Rezultat: xx/26";
            // 
            // labelResultsHiUser
            // 
            this.labelResultsHiUser.AutoSize = true;
            this.labelResultsHiUser.BackColor = System.Drawing.Color.Transparent;
            this.labelResultsHiUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResultsHiUser.Location = new System.Drawing.Point(503, 44);
            this.labelResultsHiUser.Name = "labelResultsHiUser";
            this.labelResultsHiUser.Size = new System.Drawing.Size(69, 25);
            this.labelResultsHiUser.TabIndex = 12;
            this.labelResultsHiUser.Text = "Salut!";
            // 
            // buttonResultsBackToMenu
            // 
            this.buttonResultsBackToMenu.BackColor = System.Drawing.Color.LightCyan;
            this.buttonResultsBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonResultsBackToMenu.Location = new System.Drawing.Point(417, 389);
            this.buttonResultsBackToMenu.Name = "buttonResultsBackToMenu";
            this.buttonResultsBackToMenu.Size = new System.Drawing.Size(185, 53);
            this.buttonResultsBackToMenu.TabIndex = 11;
            this.buttonResultsBackToMenu.Text = "Înapoi la meniu";
            this.buttonResultsBackToMenu.UseVisualStyleBackColor = false;
            this.buttonResultsBackToMenu.Click += new System.EventHandler(this.buttonResultsBackToMenu_Click);
            // 
            // buttonResultsSeeStatistics
            // 
            this.buttonResultsSeeStatistics.BackColor = System.Drawing.Color.LightCyan;
            this.buttonResultsSeeStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonResultsSeeStatistics.Location = new System.Drawing.Point(82, 388);
            this.buttonResultsSeeStatistics.Name = "buttonResultsSeeStatistics";
            this.buttonResultsSeeStatistics.Size = new System.Drawing.Size(185, 54);
            this.buttonResultsSeeStatistics.TabIndex = 9;
            this.buttonResultsSeeStatistics.Text = "Vezi statistici";
            this.buttonResultsSeeStatistics.UseVisualStyleBackColor = false;
            this.buttonResultsSeeStatistics.Click += new System.EventHandler(this.buttonResultsSeeStatistics_Click);
            // 
            // buttonResultsHelp
            // 
            this.buttonResultsHelp.BackColor = System.Drawing.Color.LightCyan;
            this.buttonResultsHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonResultsHelp.Location = new System.Drawing.Point(541, 8);
            this.buttonResultsHelp.Name = "buttonResultsHelp";
            this.buttonResultsHelp.Size = new System.Drawing.Size(133, 36);
            this.buttonResultsHelp.TabIndex = 8;
            this.buttonResultsHelp.Text = "Ajutor";
            this.buttonResultsHelp.UseVisualStyleBackColor = false;
            this.buttonResultsHelp.Click += new System.EventHandler(this.buttonResultsHelp_Click);
            // 
            // buttonResultsLogout
            // 
            this.buttonResultsLogout.BackColor = System.Drawing.Color.LightCyan;
            this.buttonResultsLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonResultsLogout.Location = new System.Drawing.Point(398, 8);
            this.buttonResultsLogout.Name = "buttonResultsLogout";
            this.buttonResultsLogout.Size = new System.Drawing.Size(133, 36);
            this.buttonResultsLogout.TabIndex = 7;
            this.buttonResultsLogout.Text = "Delogare";
            this.buttonResultsLogout.UseVisualStyleBackColor = false;
            this.buttonResultsLogout.Click += new System.EventHandler(this.buttonResultsLogout_Click);
            // 
            // labelResultsTitle
            // 
            this.labelResultsTitle.AutoSize = true;
            this.labelResultsTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelResultsTitle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResultsTitle.Location = new System.Drawing.Point(195, 58);
            this.labelResultsTitle.Name = "labelResultsTitle";
            this.labelResultsTitle.Size = new System.Drawing.Size(293, 67);
            this.labelResultsTitle.TabIndex = 4;
            this.labelResultsTitle.Text = "IaPermis";
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.panelResults);
            this.Controls.Add(this.panelQuiz);
            this.Controls.Add(this.panelStatistics);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 560);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IaPermis";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelStatistics.ResumeLayout(false);
            this.panelStatistics.PerformLayout();
            this.groupBoxStatistics.ResumeLayout(false);
            this.groupBoxStatistics.PerformLayout();
            this.panelQuiz.ResumeLayout(false);
            this.panelQuiz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuiz)).EndInit();
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonLoginHelp;
        private System.Windows.Forms.Button buttonLoginCreateAccount;
        private System.Windows.Forms.Button buttonLoginAutentificare;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.TextBox textBoxLoginUser;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.Label labelLoginUser;
        private System.Windows.Forms.Label labelLoginTitle;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label labelRegisterTitle;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.TextBox textBoxRegisterUser;
        private System.Windows.Forms.Label labelRegisterPassword;
        private System.Windows.Forms.Label labelRegisterUser;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonRegisterHelp;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonMenuStatistics;
        private System.Windows.Forms.Button buttonMenuStartQuiz;
        private System.Windows.Forms.Label labelMenuTitle;
        private System.Windows.Forms.Label labelHiUser;
        private System.Windows.Forms.Button buttonMenuLogout;
        private System.Windows.Forms.Button buttonMenuHelp;
        private System.Windows.Forms.Panel panelStatistics;
        private System.Windows.Forms.Button buttonStatisticsBack;
        private System.Windows.Forms.Label labelStatisticsAverage;
        private System.Windows.Forms.Label labelStatisticsPassRate;
        private System.Windows.Forms.Label labelStatisticsUser;
        private System.Windows.Forms.Button buttonStatisticsLogout;
        private System.Windows.Forms.Label labelStatisticsTitle;
        private System.Windows.Forms.Button buttonStatisticsHelp;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.Panel panelQuiz;
        private System.Windows.Forms.Label labelQuizQuestion;
        private System.Windows.Forms.Button buttonQuizHelp;
        private System.Windows.Forms.ProgressBar progressBarQuiz;
        private System.Windows.Forms.Label labelQuizWrongAnswers;
        private System.Windows.Forms.Label labelQuizQuestionNumber;
        private System.Windows.Forms.Label labelQuizTimeValue;
        private System.Windows.Forms.PictureBox pictureBoxQuiz;
        private System.Windows.Forms.Button buttonQuizLeave;
        private System.Windows.Forms.Button buttonQuizNext;
        private System.Windows.Forms.Button buttonQuizAnswer2;
        private System.Windows.Forms.Button buttonQuizAnswer3;
        private System.Windows.Forms.Button buttonQuizAnswer4;
        private System.Windows.Forms.Button buttonQuizAnswer1;
        private System.Windows.Forms.Label labelQuizTimeTitle;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Label labelResultsHiUser;
        private System.Windows.Forms.Button buttonResultsBackToMenu;
        private System.Windows.Forms.Button buttonResultsSeeStatistics;
        private System.Windows.Forms.Button buttonResultsHelp;
        private System.Windows.Forms.Button buttonResultsLogout;
        private System.Windows.Forms.Label labelResultsTitle;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Label labelResultsMessage;
        private System.Windows.Forms.Label labelResultsNumber;
    }
}