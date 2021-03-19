namespace Translator
{
    partial class Translate
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
            this.MinimizeProgram = new System.Windows.Forms.Button();
            this.ExitProgram = new System.Windows.Forms.Button();
            this.Title = new MetroFramework.Controls.MetroLabel();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.TabMenu = new MetroFramework.Controls.MetroTabPage();
            this.MenuTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.TabTranslate = new MetroFramework.Controls.MetroTabPage();
            this.TranslateLabel = new System.Windows.Forms.Label();
            this.TranslateButton = new System.Windows.Forms.Button();
            this.OutputLanguage = new MetroFramework.Controls.MetroComboBox();
            this.InputLanguage = new MetroFramework.Controls.MetroComboBox();
            this.OutputTextBox = new MetroFramework.Controls.MetroTextBox();
            this.InputTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TabIdentify = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputIdentify = new System.Windows.Forms.Label();
            this.IdentifyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.IdentifyButton = new System.Windows.Forms.Button();
            this.IdentifyLabel = new System.Windows.Forms.Label();
            this.TopPanel = new MetroFramework.Controls.MetroPanel();
            this.TabControl.SuspendLayout();
            this.TabMenu.SuspendLayout();
            this.TabTranslate.SuspendLayout();
            this.TabIdentify.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinimizeProgram
            // 
            this.MinimizeProgram.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeProgram.FlatAppearance.BorderSize = 0;
            this.MinimizeProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeProgram.ForeColor = System.Drawing.Color.Teal;
            this.MinimizeProgram.Location = new System.Drawing.Point(750, 0);
            this.MinimizeProgram.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeProgram.Name = "MinimizeProgram";
            this.MinimizeProgram.Size = new System.Drawing.Size(25, 25);
            this.MinimizeProgram.TabIndex = 3;
            this.MinimizeProgram.Text = "-";
            this.MinimizeProgram.UseVisualStyleBackColor = false;
            this.MinimizeProgram.Click += new System.EventHandler(this.MinimizeProgram_Click);
            // 
            // ExitProgram
            // 
            this.ExitProgram.BackColor = System.Drawing.Color.Transparent;
            this.ExitProgram.FlatAppearance.BorderSize = 0;
            this.ExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitProgram.ForeColor = System.Drawing.Color.Teal;
            this.ExitProgram.Location = new System.Drawing.Point(775, 0);
            this.ExitProgram.Margin = new System.Windows.Forms.Padding(0);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(25, 25);
            this.ExitProgram.TabIndex = 2;
            this.ExitProgram.Text = "X";
            this.ExitProgram.UseVisualStyleBackColor = false;
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(3, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(68, 20);
            this.Title.Style = MetroFramework.MetroColorStyle.Teal;
            this.Title.TabIndex = 1;
            this.Title.Text = "Translator";
            this.Title.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Title.UseStyleColors = true;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabMenu);
            this.TabControl.Controls.Add(this.TabTranslate);
            this.TabControl.Controls.Add(this.TabIdentify);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 25);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 425);
            this.TabControl.Style = MetroFramework.MetroColorStyle.Teal;
            this.TabControl.TabIndex = 1;
            this.TabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabControl.UseSelectable = true;
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.MenuTextBox);
            this.TabMenu.Controls.Add(this.MenuLabel);
            this.TabMenu.HorizontalScrollbarBarColor = true;
            this.TabMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.TabMenu.HorizontalScrollbarSize = 10;
            this.TabMenu.Location = new System.Drawing.Point(4, 38);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.Size = new System.Drawing.Size(792, 383);
            this.TabMenu.Style = MetroFramework.MetroColorStyle.Teal;
            this.TabMenu.TabIndex = 0;
            this.TabMenu.Text = "Menu";
            this.TabMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabMenu.VerticalScrollbarBarColor = true;
            this.TabMenu.VerticalScrollbarHighlightOnWheel = false;
            this.TabMenu.VerticalScrollbarSize = 10;
            // 
            // MenuTextBox
            // 
            this.MenuTextBox.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.MenuTextBox.CustomButton.Image = null;
            this.MenuTextBox.CustomButton.Location = new System.Drawing.Point(252, 2);
            this.MenuTextBox.CustomButton.Name = "";
            this.MenuTextBox.CustomButton.Size = new System.Drawing.Size(145, 145);
            this.MenuTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MenuTextBox.CustomButton.TabIndex = 1;
            this.MenuTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MenuTextBox.CustomButton.UseSelectable = true;
            this.MenuTextBox.CustomButton.Visible = false;
            this.MenuTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.MenuTextBox.Lines = new string[] {
        "Dit is de translator app gemaakt door Daniel ter Burg en Arwin Sparenberg. Deze a" +
            "pp kan stukken tekst vertalen naar een andere taal. Ook kan de app een taal herk" +
            "ennen en laten zien welke taal het is."};
            this.MenuTextBox.Location = new System.Drawing.Point(198, 100);
            this.MenuTextBox.MaxLength = 32767;
            this.MenuTextBox.Multiline = true;
            this.MenuTextBox.Name = "MenuTextBox";
            this.MenuTextBox.PasswordChar = '\0';
            this.MenuTextBox.ReadOnly = true;
            this.MenuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MenuTextBox.SelectedText = "";
            this.MenuTextBox.SelectionLength = 0;
            this.MenuTextBox.SelectionStart = 0;
            this.MenuTextBox.ShortcutsEnabled = true;
            this.MenuTextBox.Size = new System.Drawing.Size(400, 150);
            this.MenuTextBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.MenuTextBox.TabIndex = 3;
            this.MenuTextBox.Text = "Dit is de translator app gemaakt door Daniel ter Burg en Arwin Sparenberg. Deze a" +
    "pp kan stukken tekst vertalen naar een andere taal. Ook kan de app een taal herk" +
    "ennen en laten zien welke taal het is.";
            this.MenuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MenuTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MenuTextBox.UseSelectable = true;
            this.MenuTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MenuTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.BackColor = System.Drawing.Color.Transparent;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLabel.ForeColor = System.Drawing.Color.Teal;
            this.MenuLabel.Location = new System.Drawing.Point(302, 25);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(192, 44);
            this.MenuLabel.TabIndex = 2;
            this.MenuLabel.Text = "Translator";
            // 
            // TabTranslate
            // 
            this.TabTranslate.Controls.Add(this.TranslateLabel);
            this.TabTranslate.Controls.Add(this.TranslateButton);
            this.TabTranslate.Controls.Add(this.OutputLanguage);
            this.TabTranslate.Controls.Add(this.InputLanguage);
            this.TabTranslate.Controls.Add(this.OutputTextBox);
            this.TabTranslate.Controls.Add(this.InputTextBox);
            this.TabTranslate.HorizontalScrollbarBarColor = true;
            this.TabTranslate.HorizontalScrollbarHighlightOnWheel = false;
            this.TabTranslate.HorizontalScrollbarSize = 10;
            this.TabTranslate.Location = new System.Drawing.Point(4, 38);
            this.TabTranslate.Name = "TabTranslate";
            this.TabTranslate.Size = new System.Drawing.Size(792, 383);
            this.TabTranslate.Style = MetroFramework.MetroColorStyle.Teal;
            this.TabTranslate.TabIndex = 1;
            this.TabTranslate.Text = "Translate";
            this.TabTranslate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabTranslate.VerticalScrollbarBarColor = true;
            this.TabTranslate.VerticalScrollbarHighlightOnWheel = false;
            this.TabTranslate.VerticalScrollbarSize = 10;
            // 
            // TranslateLabel
            // 
            this.TranslateLabel.AutoSize = true;
            this.TranslateLabel.BackColor = System.Drawing.Color.Transparent;
            this.TranslateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TranslateLabel.ForeColor = System.Drawing.Color.Teal;
            this.TranslateLabel.Location = new System.Drawing.Point(310, 25);
            this.TranslateLabel.Name = "TranslateLabel";
            this.TranslateLabel.Size = new System.Drawing.Size(185, 46);
            this.TranslateLabel.TabIndex = 7;
            this.TranslateLabel.Text = "Translate";
            // 
            // TranslateButton
            // 
            this.TranslateButton.BackColor = System.Drawing.Color.Transparent;
            this.TranslateButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.TranslateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.TranslateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.TranslateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TranslateButton.ForeColor = System.Drawing.SystemColors.Window;
            this.TranslateButton.Location = new System.Drawing.Point(335, 281);
            this.TranslateButton.Margin = new System.Windows.Forms.Padding(0);
            this.TranslateButton.Name = "TranslateButton";
            this.TranslateButton.Size = new System.Drawing.Size(125, 30);
            this.TranslateButton.TabIndex = 6;
            this.TranslateButton.Text = "Translate";
            this.TranslateButton.UseVisualStyleBackColor = false;
            this.TranslateButton.Click += new System.EventHandler(this.TranslateButton_Click);
            // 
            // OutputLanguage
            // 
            this.OutputLanguage.BackColor = System.Drawing.Color.Teal;
            this.OutputLanguage.FormattingEnabled = true;
            this.OutputLanguage.ItemHeight = 24;
            this.OutputLanguage.Items.AddRange(new object[] {
            "en",
            "nl",
            "de",
            "it",
            "fr",
            "ja",
            "pt",
            "es"});
            this.OutputLanguage.Location = new System.Drawing.Point(565, 281);
            this.OutputLanguage.Name = "OutputLanguage";
            this.OutputLanguage.Size = new System.Drawing.Size(125, 30);
            this.OutputLanguage.Style = MetroFramework.MetroColorStyle.Teal;
            this.OutputLanguage.TabIndex = 5;
            this.OutputLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OutputLanguage.UseSelectable = true;
            this.OutputLanguage.UseStyleColors = true;
            // 
            // InputLanguage
            // 
            this.InputLanguage.ForeColor = System.Drawing.Color.Teal;
            this.InputLanguage.FormattingEnabled = true;
            this.InputLanguage.ItemHeight = 24;
            this.InputLanguage.Items.AddRange(new object[] {
            "en",
            "nl",
            "de",
            "it",
            "fr",
            "ja",
            "pt",
            "es"});
            this.InputLanguage.Location = new System.Drawing.Point(110, 281);
            this.InputLanguage.Name = "InputLanguage";
            this.InputLanguage.Size = new System.Drawing.Size(125, 30);
            this.InputLanguage.Style = MetroFramework.MetroColorStyle.Teal;
            this.InputLanguage.TabIndex = 4;
            this.InputLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InputLanguage.UseCustomForeColor = true;
            this.InputLanguage.UseSelectable = true;
            this.InputLanguage.UseStyleColors = true;
            // 
            // OutputTextBox
            // 
            // 
            // 
            // 
            this.OutputTextBox.CustomButton.Image = null;
            this.OutputTextBox.CustomButton.Location = new System.Drawing.Point(152, 2);
            this.OutputTextBox.CustomButton.Name = "";
            this.OutputTextBox.CustomButton.Size = new System.Drawing.Size(145, 145);
            this.OutputTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.OutputTextBox.CustomButton.TabIndex = 1;
            this.OutputTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.OutputTextBox.CustomButton.UseSelectable = true;
            this.OutputTextBox.CustomButton.Visible = false;
            this.OutputTextBox.ForeColor = System.Drawing.Color.Black;
            this.OutputTextBox.Lines = new string[] {
        "Output"};
            this.OutputTextBox.Location = new System.Drawing.Point(471, 100);
            this.OutputTextBox.MaxLength = 32767;
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.PasswordChar = '\0';
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OutputTextBox.SelectedText = "";
            this.OutputTextBox.SelectionLength = 0;
            this.OutputTextBox.SelectionStart = 0;
            this.OutputTextBox.ShortcutsEnabled = true;
            this.OutputTextBox.Size = new System.Drawing.Size(300, 150);
            this.OutputTextBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.OutputTextBox.TabIndex = 3;
            this.OutputTextBox.Text = "Output";
            this.OutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OutputTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OutputTextBox.UseSelectable = true;
            this.OutputTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.OutputTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InputTextBox
            // 
            this.InputTextBox.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.InputTextBox.CustomButton.Image = null;
            this.InputTextBox.CustomButton.Location = new System.Drawing.Point(152, 2);
            this.InputTextBox.CustomButton.Name = "";
            this.InputTextBox.CustomButton.Size = new System.Drawing.Size(145, 145);
            this.InputTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InputTextBox.CustomButton.TabIndex = 1;
            this.InputTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InputTextBox.CustomButton.UseSelectable = true;
            this.InputTextBox.CustomButton.Visible = false;
            this.InputTextBox.ForeColor = System.Drawing.Color.Black;
            this.InputTextBox.Lines = new string[] {
        "Input"};
            this.InputTextBox.Location = new System.Drawing.Point(25, 100);
            this.InputTextBox.MaxLength = 32767;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.PasswordChar = '\0';
            this.InputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InputTextBox.SelectedText = "";
            this.InputTextBox.SelectionLength = 0;
            this.InputTextBox.SelectionStart = 0;
            this.InputTextBox.ShortcutsEnabled = true;
            this.InputTextBox.Size = new System.Drawing.Size(300, 150);
            this.InputTextBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.InputTextBox.TabIndex = 2;
            this.InputTextBox.Text = "Input";
            this.InputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InputTextBox.UseSelectable = true;
            this.InputTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InputTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TabIdentify
            // 
            this.TabIdentify.Controls.Add(this.label2);
            this.TabIdentify.Controls.Add(this.OutputIdentify);
            this.TabIdentify.Controls.Add(this.IdentifyTextBox);
            this.TabIdentify.Controls.Add(this.IdentifyButton);
            this.TabIdentify.Controls.Add(this.IdentifyLabel);
            this.TabIdentify.HorizontalScrollbarBarColor = true;
            this.TabIdentify.HorizontalScrollbarHighlightOnWheel = false;
            this.TabIdentify.HorizontalScrollbarSize = 10;
            this.TabIdentify.Location = new System.Drawing.Point(4, 38);
            this.TabIdentify.Name = "TabIdentify";
            this.TabIdentify.Size = new System.Drawing.Size(792, 383);
            this.TabIdentify.Style = MetroFramework.MetroColorStyle.Teal;
            this.TabIdentify.TabIndex = 2;
            this.TabIdentify.Text = "Identify";
            this.TabIdentify.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TabIdentify.VerticalScrollbarBarColor = true;
            this.TabIdentify.VerticalScrollbarHighlightOnWheel = false;
            this.TabIdentify.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(261, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "The input language is: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputIdentify
            // 
            this.OutputIdentify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputIdentify.AutoSize = true;
            this.OutputIdentify.BackColor = System.Drawing.Color.Transparent;
            this.OutputIdentify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputIdentify.ForeColor = System.Drawing.Color.Teal;
            this.OutputIdentify.Location = new System.Drawing.Point(477, 337);
            this.OutputIdentify.Name = "OutputIdentify";
            this.OutputIdentify.Size = new System.Drawing.Size(0, 25);
            this.OutputIdentify.TabIndex = 5;
            this.OutputIdentify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IdentifyTextBox
            // 
            // 
            // 
            // 
            this.IdentifyTextBox.CustomButton.Image = null;
            this.IdentifyTextBox.CustomButton.Location = new System.Drawing.Point(152, 2);
            this.IdentifyTextBox.CustomButton.Name = "";
            this.IdentifyTextBox.CustomButton.Size = new System.Drawing.Size(145, 145);
            this.IdentifyTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IdentifyTextBox.CustomButton.TabIndex = 1;
            this.IdentifyTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IdentifyTextBox.CustomButton.UseSelectable = true;
            this.IdentifyTextBox.CustomButton.Visible = false;
            this.IdentifyTextBox.Lines = new string[] {
        "Input"};
            this.IdentifyTextBox.Location = new System.Drawing.Point(248, 100);
            this.IdentifyTextBox.MaxLength = 32767;
            this.IdentifyTextBox.Name = "IdentifyTextBox";
            this.IdentifyTextBox.PasswordChar = '\0';
            this.IdentifyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IdentifyTextBox.SelectedText = "";
            this.IdentifyTextBox.SelectionLength = 0;
            this.IdentifyTextBox.SelectionStart = 0;
            this.IdentifyTextBox.ShortcutsEnabled = true;
            this.IdentifyTextBox.Size = new System.Drawing.Size(300, 150);
            this.IdentifyTextBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.IdentifyTextBox.TabIndex = 4;
            this.IdentifyTextBox.Text = "Input";
            this.IdentifyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IdentifyTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.IdentifyTextBox.UseSelectable = true;
            this.IdentifyTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IdentifyTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // IdentifyButton
            // 
            this.IdentifyButton.BackColor = System.Drawing.Color.Transparent;
            this.IdentifyButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.IdentifyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.IdentifyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.IdentifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdentifyButton.ForeColor = System.Drawing.SystemColors.Window;
            this.IdentifyButton.Location = new System.Drawing.Point(333, 281);
            this.IdentifyButton.Margin = new System.Windows.Forms.Padding(0);
            this.IdentifyButton.Name = "IdentifyButton";
            this.IdentifyButton.Size = new System.Drawing.Size(131, 30);
            this.IdentifyButton.TabIndex = 3;
            this.IdentifyButton.Text = "Identify Language";
            this.IdentifyButton.UseVisualStyleBackColor = false;
            this.IdentifyButton.Click += new System.EventHandler(this.IdentifyButton_Click);
            // 
            // IdentifyLabel
            // 
            this.IdentifyLabel.AutoSize = true;
            this.IdentifyLabel.BackColor = System.Drawing.Color.Transparent;
            this.IdentifyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentifyLabel.ForeColor = System.Drawing.Color.Teal;
            this.IdentifyLabel.Location = new System.Drawing.Point(221, 25);
            this.IdentifyLabel.Name = "IdentifyLabel";
            this.IdentifyLabel.Size = new System.Drawing.Size(354, 46);
            this.IdentifyLabel.TabIndex = 2;
            this.IdentifyLabel.Text = "Identify a language";
            this.IdentifyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.MinimizeProgram);
            this.TopPanel.Controls.Add(this.ExitProgram);
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.Color.Black;
            this.TopPanel.HorizontalScrollbarBarColor = true;
            this.TopPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.TopPanel.HorizontalScrollbarSize = 10;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 25);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopPanel.VerticalScrollbarBarColor = true;
            this.TopPanel.VerticalScrollbarHighlightOnWheel = false;
            this.TopPanel.VerticalScrollbarSize = 10;
            // 
            // Translate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Translate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translator";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Translate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Translate_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Translate_MouseUp);
            this.TabControl.ResumeLayout(false);
            this.TabMenu.ResumeLayout(false);
            this.TabMenu.PerformLayout();
            this.TabTranslate.ResumeLayout(false);
            this.TabTranslate.PerformLayout();
            this.TabIdentify.ResumeLayout(false);
            this.TabIdentify.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage TabMenu;
        private MetroFramework.Controls.MetroTabPage TabTranslate;
        private MetroFramework.Controls.MetroTabPage TabIdentify;
        private MetroFramework.Controls.MetroLabel Title;
        private System.Windows.Forms.Button ExitProgram;
        private System.Windows.Forms.Button MinimizeProgram;
        private MetroFramework.Controls.MetroTextBox OutputTextBox;
        private MetroFramework.Controls.MetroTextBox InputTextBox;
        private MetroFramework.Controls.MetroComboBox InputLanguage;
        private MetroFramework.Controls.MetroComboBox OutputLanguage;
        private System.Windows.Forms.Button TranslateButton;
        private System.Windows.Forms.Label TranslateLabel;
        private MetroFramework.Controls.MetroTextBox IdentifyTextBox;
        private System.Windows.Forms.Button IdentifyButton;
        private System.Windows.Forms.Label IdentifyLabel;
        private MetroFramework.Controls.MetroTextBox MenuTextBox;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OutputIdentify;
        private MetroFramework.Controls.MetroPanel TopPanel;
    }
}

