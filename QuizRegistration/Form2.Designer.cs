using System.ComponentModel;

namespace QuizRegistration
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.formTabs = new Guna.UI2.WinForms.Guna2TabControl();
            this.registrationTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chooseGameLabel = new System.Windows.Forms.Label();
            this.chooseGameDropdown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gameDateLabel = new System.Windows.Forms.Label();
            this.gamePlaceLabel = new System.Windows.Forms.Label();
            this.chooseTeamLabel = new System.Windows.Forms.Label();
            this.chooseTeamDropdown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.choosePlayersCountLabel = new System.Windows.Forms.Label();
            this.captainNameLabel = new System.Windows.Forms.Label();
            this.captainPhoneLabel = new System.Windows.Forms.Label();
            this.captainPhoneInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.registrationBtn = new System.Windows.Forms.Button();
            this.registrationDateLabel = new System.Windows.Forms.Label();
            this.gameBanner = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gameSeparator = new Guna.UI2.WinForms.Guna2Separator();
            this.registrationLogInput = new System.Windows.Forms.RichTextBox();
            this.captainNameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.choosePlayersCountField = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.gamesTab = new System.Windows.Forms.TabPage();
            this.helpTab = new System.Windows.Forms.TabPage();
            this.faqLabel = new System.Windows.Forms.Label();
            this.formTabs.SuspendLayout();
            this.registrationTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosePlayersCountField)).BeginInit();
            this.helpTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTabs
            // 
            this.formTabs.Controls.Add(this.registrationTab);
            this.formTabs.Controls.Add(this.gamesTab);
            this.formTabs.Controls.Add(this.helpTab);
            this.formTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTabs.ItemSize = new System.Drawing.Size(180, 40);
            this.formTabs.Location = new System.Drawing.Point(0, 0);
            this.formTabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.formTabs.Name = "formTabs";
            this.formTabs.SelectedIndex = 0;
            this.formTabs.Size = new System.Drawing.Size(1178, 944);
            this.formTabs.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.formTabs.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.formTabs.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.formTabs.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.formTabs.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.formTabs.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.formTabs.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.formTabs.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.formTabs.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.formTabs.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.formTabs.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.formTabs.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.formTabs.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.formTabs.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.formTabs.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.formTabs.TabButtonSize = new System.Drawing.Size(180, 40);
            this.formTabs.TabIndex = 999;
            this.formTabs.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.formTabs.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.formTabs.SelectedIndexChanged += new System.EventHandler(this.guna2TabControl1_SelectedIndexChanged);
            // 
            // registrationTab
            // 
            this.registrationTab.Controls.Add(this.tableLayoutPanel1);
            this.registrationTab.Location = new System.Drawing.Point(4, 44);
            this.registrationTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registrationTab.Name = "registrationTab";
            this.registrationTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registrationTab.Size = new System.Drawing.Size(1170, 896);
            this.registrationTab.TabIndex = 999;
            this.registrationTab.Text = "Регистрация";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 587F));
            this.tableLayoutPanel1.Controls.Add(this.chooseGameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chooseGameDropdown, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameDateLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gamePlaceLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chooseTeamLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.chooseTeamDropdown, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.choosePlayersCountLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.captainNameLabel, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.captainPhoneLabel, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.captainPhoneInput, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.registrationBtn, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.registrationDateLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.gameBanner, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameSeparator, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.registrationLogInput, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.captainNameInput, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.choosePlayersCountField, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1164, 888);
            this.tableLayoutPanel1.TabIndex = 999;
            // 
            // chooseGameLabel
            // 
            this.chooseGameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseGameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseGameLabel.Location = new System.Drawing.Point(3, 0);
            this.chooseGameLabel.Name = "chooseGameLabel";
            this.chooseGameLabel.Size = new System.Drawing.Size(571, 48);
            this.chooseGameLabel.TabIndex = 999;
            this.chooseGameLabel.Text = "Данные игры";
            this.chooseGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chooseGameDropdown
            // 
            this.chooseGameDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseGameDropdown.BackColor = System.Drawing.Color.Transparent;
            this.chooseGameDropdown.CustomizableEdges = customizableEdges1;
            this.chooseGameDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.chooseGameDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseGameDropdown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chooseGameDropdown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chooseGameDropdown.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseGameDropdown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chooseGameDropdown.ItemHeight = 40;
            this.chooseGameDropdown.Location = new System.Drawing.Point(3, 52);
            this.chooseGameDropdown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chooseGameDropdown.Name = "chooseGameDropdown";
            this.chooseGameDropdown.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.chooseGameDropdown.Size = new System.Drawing.Size(571, 46);
            this.chooseGameDropdown.TabIndex = 1;
            this.chooseGameDropdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chooseGameDropdown.SelectedIndexChanged += new System.EventHandler(this.chooseGameDropdown_SelectedIndexChanged);
            // 
            // gameDateLabel
            // 
            this.gameDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gameDateLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameDateLabel.Location = new System.Drawing.Point(3, 108);
            this.gameDateLabel.Name = "gameDateLabel";
            this.gameDateLabel.Size = new System.Drawing.Size(571, 84);
            this.gameDateLabel.TabIndex = 999;
            this.gameDateLabel.Text = "Дата игры:";
            this.gameDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gamePlaceLabel
            // 
            this.gamePlaceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePlaceLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamePlaceLabel.Location = new System.Drawing.Point(3, 192);
            this.gamePlaceLabel.Name = "gamePlaceLabel";
            this.gamePlaceLabel.Size = new System.Drawing.Size(571, 84);
            this.gamePlaceLabel.TabIndex = 999;
            this.gamePlaceLabel.Text = "Место игры:";
            this.gamePlaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chooseTeamLabel
            // 
            this.chooseTeamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseTeamLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseTeamLabel.Location = new System.Drawing.Point(0, 382);
            this.chooseTeamLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.chooseTeamLabel.Name = "chooseTeamLabel";
            this.chooseTeamLabel.Size = new System.Drawing.Size(577, 38);
            this.chooseTeamLabel.TabIndex = 999;
            this.chooseTeamLabel.Text = "Данные команды";
            this.chooseTeamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chooseTeamDropdown
            // 
            this.chooseTeamDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseTeamDropdown.BackColor = System.Drawing.Color.Transparent;
            this.chooseTeamDropdown.CustomizableEdges = customizableEdges3;
            this.chooseTeamDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.chooseTeamDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseTeamDropdown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chooseTeamDropdown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chooseTeamDropdown.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseTeamDropdown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chooseTeamDropdown.ItemHeight = 40;
            this.chooseTeamDropdown.Location = new System.Drawing.Point(0, 420);
            this.chooseTeamDropdown.Margin = new System.Windows.Forms.Padding(0);
            this.chooseTeamDropdown.Name = "chooseTeamDropdown";
            this.chooseTeamDropdown.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.chooseTeamDropdown.Size = new System.Drawing.Size(577, 46);
            this.chooseTeamDropdown.TabIndex = 2;
            this.chooseTeamDropdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // choosePlayersCountLabel
            // 
            this.choosePlayersCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.choosePlayersCountLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choosePlayersCountLabel.Location = new System.Drawing.Point(0, 490);
            this.choosePlayersCountLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.choosePlayersCountLabel.Name = "choosePlayersCountLabel";
            this.choosePlayersCountLabel.Size = new System.Drawing.Size(577, 38);
            this.choosePlayersCountLabel.TabIndex = 999;
            this.choosePlayersCountLabel.Text = "Количество участников:";
            this.choosePlayersCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // captainNameLabel
            // 
            this.captainNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.captainNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captainNameLabel.Location = new System.Drawing.Point(0, 598);
            this.captainNameLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.captainNameLabel.Name = "captainNameLabel";
            this.captainNameLabel.Size = new System.Drawing.Size(577, 38);
            this.captainNameLabel.TabIndex = 999;
            this.captainNameLabel.Text = "Имя капитана";
            this.captainNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // captainPhoneLabel
            // 
            this.captainPhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.captainPhoneLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captainPhoneLabel.Location = new System.Drawing.Point(0, 706);
            this.captainPhoneLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.captainPhoneLabel.Name = "captainPhoneLabel";
            this.captainPhoneLabel.Size = new System.Drawing.Size(577, 38);
            this.captainPhoneLabel.TabIndex = 999;
            this.captainPhoneLabel.Text = "Номер телефона капитана";
            this.captainPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // captainPhoneInput
            // 
            this.captainPhoneInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.captainPhoneInput.BackColor = System.Drawing.SystemColors.ControlText;
            this.captainPhoneInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.captainPhoneInput.CustomizableEdges = customizableEdges5;
            this.captainPhoneInput.DefaultText = "";
            this.captainPhoneInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.captainPhoneInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.captainPhoneInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.captainPhoneInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.captainPhoneInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.captainPhoneInput.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captainPhoneInput.ForeColor = System.Drawing.Color.Black;
            this.captainPhoneInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.captainPhoneInput.Location = new System.Drawing.Point(0, 744);
            this.captainPhoneInput.Margin = new System.Windows.Forms.Padding(0);
            this.captainPhoneInput.MaxLength = 18;
            this.captainPhoneInput.Name = "captainPhoneInput";
            this.captainPhoneInput.PasswordChar = '\0';
            this.captainPhoneInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.captainPhoneInput.PlaceholderText = "";
            this.captainPhoneInput.SelectedText = "";
            this.captainPhoneInput.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.captainPhoneInput.Size = new System.Drawing.Size(577, 60);
            this.captainPhoneInput.TabIndex = 5;
            this.captainPhoneInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.captainPhoneInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.captainPhoneInput_KeyPress);
            // 
            // registrationBtn
            // 
            this.registrationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationBtn.Location = new System.Drawing.Point(0, 814);
            this.registrationBtn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(577, 64);
            this.registrationBtn.TabIndex = 6;
            this.registrationBtn.Text = "Зарегистрироваться";
            this.registrationBtn.UseVisualStyleBackColor = true;
            this.registrationBtn.Click += new System.EventHandler(this.registrationBtn_Click);
            // 
            // registrationDateLabel
            // 
            this.registrationDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationDateLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationDateLabel.Location = new System.Drawing.Point(3, 276);
            this.registrationDateLabel.Name = "registrationDateLabel";
            this.registrationDateLabel.Size = new System.Drawing.Size(571, 84);
            this.registrationDateLabel.TabIndex = 999;
            this.registrationDateLabel.Text = "Регистрация:";
            this.registrationDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gameBanner
            // 
            this.gameBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gameBanner.CustomizableEdges = customizableEdges7;
            this.gameBanner.ImageRotate = 0F;
            this.gameBanner.Location = new System.Drawing.Point(580, 51);
            this.gameBanner.Name = "gameBanner";
            this.tableLayoutPanel1.SetRowSpan(this.gameBanner, 4);
            this.gameBanner.ShadowDecoration.CustomizableEdges = customizableEdges8;
            this.gameBanner.Size = new System.Drawing.Size(581, 306);
            this.gameBanner.TabIndex = 999;
            this.gameBanner.TabStop = false;
            // 
            // gameSeparator
            // 
            this.gameSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gameSeparator, 2);
            this.gameSeparator.Location = new System.Drawing.Point(0, 360);
            this.gameSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.gameSeparator.Name = "gameSeparator";
            this.gameSeparator.Size = new System.Drawing.Size(1164, 12);
            this.gameSeparator.TabIndex = 999;
            // 
            // registrationLogInput
            // 
            this.registrationLogInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationLogInput.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLogInput.Location = new System.Drawing.Point(630, 375);
            this.registrationLogInput.Margin = new System.Windows.Forms.Padding(53, 3, 3, 3);
            this.registrationLogInput.Name = "registrationLogInput";
            this.registrationLogInput.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.registrationLogInput, 9);
            this.registrationLogInput.Size = new System.Drawing.Size(531, 510);
            this.registrationLogInput.TabIndex = 999;
            this.registrationLogInput.Text = "";
            // 
            // captainNameInput
            // 
            this.captainNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.captainNameInput.BackColor = System.Drawing.SystemColors.ControlText;
            this.captainNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.captainNameInput.CustomizableEdges = customizableEdges9;
            this.captainNameInput.DefaultText = "";
            this.captainNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.captainNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.captainNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.captainNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.captainNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.captainNameInput.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captainNameInput.ForeColor = System.Drawing.Color.Black;
            this.captainNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.captainNameInput.Location = new System.Drawing.Point(0, 636);
            this.captainNameInput.Margin = new System.Windows.Forms.Padding(0);
            this.captainNameInput.Name = "captainNameInput";
            this.captainNameInput.PasswordChar = '\0';
            this.captainNameInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.captainNameInput.PlaceholderText = "";
            this.captainNameInput.SelectedText = "";
            this.captainNameInput.ShadowDecoration.CustomizableEdges = customizableEdges10;
            this.captainNameInput.Size = new System.Drawing.Size(577, 60);
            this.captainNameInput.TabIndex = 4;
            this.captainNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // choosePlayersCountField
            // 
            this.choosePlayersCountField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.choosePlayersCountField.BackColor = System.Drawing.Color.Transparent;
            this.choosePlayersCountField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.choosePlayersCountField.CustomizableEdges = customizableEdges11;
            this.choosePlayersCountField.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choosePlayersCountField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.choosePlayersCountField.Location = new System.Drawing.Point(0, 528);
            this.choosePlayersCountField.Margin = new System.Windows.Forms.Padding(0);
            this.choosePlayersCountField.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.choosePlayersCountField.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.choosePlayersCountField.Name = "choosePlayersCountField";
            this.choosePlayersCountField.ShadowDecoration.CustomizableEdges = customizableEdges12;
            this.choosePlayersCountField.Size = new System.Drawing.Size(577, 60);
            this.choosePlayersCountField.TabIndex = 3;
            this.choosePlayersCountField.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // gamesTab
            // 
            this.gamesTab.AutoScroll = true;
            this.gamesTab.Location = new System.Drawing.Point(4, 44);
            this.gamesTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gamesTab.Name = "gamesTab";
            this.gamesTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gamesTab.Size = new System.Drawing.Size(1170, 896);
            this.gamesTab.TabIndex = 999;
            this.gamesTab.Text = "Мои игры";
            // 
            // helpTab
            // 
            this.helpTab.Controls.Add(this.faqLabel);
            this.helpTab.Location = new System.Drawing.Point(4, 44);
            this.helpTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.helpTab.Name = "helpTab";
            this.helpTab.Size = new System.Drawing.Size(1170, 896);
            this.helpTab.TabIndex = 999;
            this.helpTab.Text = "Справка";
            // 
            // faqLabel
            // 
            this.faqLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faqLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.faqLabel.Location = new System.Drawing.Point(0, 0);
            this.faqLabel.Name = "faqLabel";
            this.faqLabel.Size = new System.Drawing.Size(1170, 896);
            this.faqLabel.TabIndex = 0;
            this.faqLabel.Text = resources.GetString("faqLabel.Text");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1178, 944);
            this.Controls.Add(this.formTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(900, 870);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.formTabs.ResumeLayout(false);
            this.registrationTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosePlayersCountField)).EndInit();
            this.helpTab.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label faqLabel;

        private Guna.UI2.WinForms.Guna2TabControl formTabs;
        private System.Windows.Forms.TabPage registrationTab;
        private System.Windows.Forms.TabPage gamesTab;
        private System.Windows.Forms.TabPage helpTab;
        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        
        private System.Windows.Forms.Label chooseGameLabel;
        private Guna.UI2.WinForms.Guna2ComboBox chooseGameDropdown;
        private Guna.UI2.WinForms.Guna2PictureBox gameBanner;
        private System.Windows.Forms.Label gameDateLabel;
        private System.Windows.Forms.Label gamePlaceLabel;
        private System.Windows.Forms.Label registrationDateLabel;
        private Guna.UI2.WinForms.Guna2Separator gameSeparator;
        
        private System.Windows.Forms.Label chooseTeamLabel;
        private Guna.UI2.WinForms.Guna2ComboBox chooseTeamDropdown;
        private System.Windows.Forms.Label choosePlayersCountLabel;
        private Guna.UI2.WinForms.Guna2NumericUpDown choosePlayersCountField;
        private System.Windows.Forms.Label captainNameLabel;
        private Guna.UI2.WinForms.Guna2TextBox captainNameInput;
        private System.Windows.Forms.Label captainPhoneLabel;
        private Guna.UI2.WinForms.Guna2TextBox captainPhoneInput;
        private System.Windows.Forms.Button registrationBtn;
        
        private System.Windows.Forms.RichTextBox registrationLogInput;

        #endregion
    }
}
