using System.Windows.Forms;

namespace QuizRegistration
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.authorizationLabel = new System.Windows.Forms.Label();
            this.emailField = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordField = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.savePasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.wrongPasswordLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(3, 151);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(1188, 101);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(3, 353);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(1188, 101);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Пароль";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBtn.Location = new System.Drawing.Point(350, 706);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(350, 50, 350, 60);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(494, 92);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Войти";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // authorizationLabel
            // 
            this.authorizationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.authorizationLabel.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationLabel.Location = new System.Drawing.Point(0, 0);
            this.authorizationLabel.Margin = new System.Windows.Forms.Padding(0);
            this.authorizationLabel.Name = "authorizationLabel";
            this.authorizationLabel.Size = new System.Drawing.Size(1194, 151);
            this.authorizationLabel.TabIndex = 6;
            this.authorizationLabel.Text = "Авторизация";
            this.authorizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailField
            // 
            this.emailField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.emailField.BackColor = System.Drawing.SystemColors.ControlText;
            this.emailField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailField.CustomizableEdges = customizableEdges1;
            this.emailField.DefaultText = "";
            this.emailField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailField.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.emailField.ForeColor = System.Drawing.Color.Black;
            this.emailField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailField.Location = new System.Drawing.Point(200, 272);
            this.emailField.Margin = new System.Windows.Forms.Padding(200, 20, 200, 20);
            this.emailField.Name = "emailField";
            this.emailField.PasswordChar = '\0';
            this.emailField.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailField.PlaceholderText = "";
            this.emailField.SelectedText = "";
            this.emailField.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.emailField.Size = new System.Drawing.Size(794, 61);
            this.emailField.TabIndex = 1;
            this.emailField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmailField_KeyDown);
            // 
            // passwordField
            // 
            this.passwordField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordField.CustomizableEdges = customizableEdges3;
            this.passwordField.DefaultText = "";
            this.passwordField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordField.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.passwordField.ForeColor = System.Drawing.Color.Black;
            this.passwordField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordField.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.passwordField.IconRightOffset = new System.Drawing.Point(10, 0);
            this.passwordField.IconRightSize = new System.Drawing.Size(30, 30);
            this.passwordField.Location = new System.Drawing.Point(200, 474);
            this.passwordField.Margin = new System.Windows.Forms.Padding(200, 20, 200, 20);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '●';
            this.passwordField.PlaceholderText = "";
            this.passwordField.SelectedText = "";
            this.passwordField.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.passwordField.Size = new System.Drawing.Size(794, 61);
            this.passwordField.TabIndex = 2;
            this.passwordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordField.IconRightClick += new System.EventHandler(this.passwordField_IconRightClick);
            this.passwordField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordField_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1194F));
            this.tableLayoutPanel1.Controls.Add(this.authorizationLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.emailLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.emailField, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.passwordLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.passwordField, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.savePasswordCheckbox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.loginBtn, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.wrongPasswordLabel, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 960);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // savePasswordCheckbox
            // 
            this.savePasswordCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.savePasswordCheckbox.AutoSize = true;
            this.savePasswordCheckbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savePasswordCheckbox.Location = new System.Drawing.Point(466, 588);
            this.savePasswordCheckbox.Name = "savePasswordCheckbox";
            this.savePasswordCheckbox.Size = new System.Drawing.Size(261, 34);
            this.savePasswordCheckbox.TabIndex = 3;
            this.savePasswordCheckbox.Text = "Сохранить пароль";
            this.savePasswordCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.savePasswordCheckbox.UseVisualStyleBackColor = true;
            this.savePasswordCheckbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.savePasswordCheckbox_KeyDown);
            // 
            // wrongPasswordLabel
            // 
            this.wrongPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.wrongPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.wrongPasswordLabel.Location = new System.Drawing.Point(3, 858);
            this.wrongPasswordLabel.Name = "wrongPasswordLabel";
            this.wrongPasswordLabel.Size = new System.Drawing.Size(1188, 102);
            this.wrongPasswordLabel.TabIndex = 7;
            this.wrongPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1194, 960);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(850, 850);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizRegistration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label wrongPasswordLabel;

        private System.Windows.Forms.CheckBox savePasswordCheckbox;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Label authorizationLabel;

        private Guna.UI2.WinForms.Guna2TextBox passwordField;
        private System.Windows.Forms.Label emailLabel;
        private Guna.UI2.WinForms.Guna2TextBox emailField;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label passwordLabel;

        #endregion
    }
}
