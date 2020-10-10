namespace View
{
    partial class AddingEditionForm
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
            this.SelectEdition = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.PagesLabel = new System.Windows.Forms.Label();
            this.PagesTextBox = new System.Windows.Forms.TextBox();
            this.SelectEditionBox = new System.Windows.Forms.GroupBox();
            this.Publishing = new System.Windows.Forms.Label();
            this.PublishingTextBox = new System.Windows.Forms.TextBox();
            this.UniversityLabel = new System.Windows.Forms.Label();
            this.UniversityTextBox = new System.Windows.Forms.TextBox();
            this.SpecialityCodeLabel = new System.Windows.Forms.Label();
            this.SpecialityCodeTextBox = new System.Windows.Forms.TextBox();
            this.SpecialityLabel = new System.Windows.Forms.Label();
            this.SpecialityTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.InitialsTextBox = new System.Windows.Forms.TextBox();
            this.InitialsLabel = new System.Windows.Forms.Label();
            this.AddAuthor = new System.Windows.Forms.Button();
            this.RemoveAuthor = new System.Windows.Forms.Button();
            this.Consent = new System.Windows.Forms.Button();
            this.Renouncement = new System.Windows.Forms.Button();
            this.SelectEditionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectEdition
            // 
            this.SelectEdition.FormattingEnabled = true;
            this.SelectEdition.Items.AddRange(new object[] {
            "Книга",
            "Сборник",
            "Диссертация",
            "Журнал"});
            this.SelectEdition.Location = new System.Drawing.Point(13, 21);
            this.SelectEdition.Name = "SelectEdition";
            this.SelectEdition.Size = new System.Drawing.Size(195, 24);
            this.SelectEdition.TabIndex = 0;
            this.SelectEdition.SelectedIndexChanged += new System.EventHandler(this.SelectEdition_SelectedIndexChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(9, 69);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(72, 17);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Название";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(29, 89);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(195, 22);
            this.TitleTextBox.TabIndex = 2;
            this.TitleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TitleTextBox_Validating);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(9, 114);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(48, 17);
            this.CityLabel.TabIndex = 3;
            this.CityLabel.Text = "Город";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(29, 134);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(195, 22);
            this.CityTextBox.TabIndex = 4;
            this.CityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CityTextBox_Validating);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(29, 179);
            this.DatePicker.MaxDate = new System.DateTime(2020, 10, 10, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(195, 22);
            this.DatePicker.TabIndex = 5;
            this.DatePicker.Value = new System.DateTime(2020, 10, 10, 0, 0, 0, 0);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(9, 159);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(42, 17);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "Дата";
            // 
            // PagesLabel
            // 
            this.PagesLabel.AutoSize = true;
            this.PagesLabel.Location = new System.Drawing.Point(9, 204);
            this.PagesLabel.Name = "PagesLabel";
            this.PagesLabel.Size = new System.Drawing.Size(144, 17);
            this.PagesLabel.TabIndex = 7;
            this.PagesLabel.Text = "Количество страниц";
            // 
            // PagesTextBox
            // 
            this.PagesTextBox.Location = new System.Drawing.Point(29, 224);
            this.PagesTextBox.Name = "PagesTextBox";
            this.PagesTextBox.Size = new System.Drawing.Size(195, 22);
            this.PagesTextBox.TabIndex = 8;
            this.PagesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PagesTextBox_Validating);
            // 
            // SelectEditionBox
            // 
            this.SelectEditionBox.Controls.Add(this.SelectEdition);
            this.SelectEditionBox.Location = new System.Drawing.Point(16, 7);
            this.SelectEditionBox.Name = "SelectEditionBox";
            this.SelectEditionBox.Size = new System.Drawing.Size(218, 59);
            this.SelectEditionBox.TabIndex = 9;
            this.SelectEditionBox.TabStop = false;
            this.SelectEditionBox.Text = "Выбор типа издания";
            // 
            // Publishing
            // 
            this.Publishing.AutoSize = true;
            this.Publishing.Location = new System.Drawing.Point(9, 249);
            this.Publishing.Name = "Publishing";
            this.Publishing.Size = new System.Drawing.Size(100, 17);
            this.Publishing.TabIndex = 10;
            this.Publishing.Text = "Издательство";
            // 
            // PublishingTextBox
            // 
            this.PublishingTextBox.Location = new System.Drawing.Point(29, 272);
            this.PublishingTextBox.Name = "PublishingTextBox";
            this.PublishingTextBox.Size = new System.Drawing.Size(195, 22);
            this.PublishingTextBox.TabIndex = 11;
            this.PublishingTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PublishingTextBox_Validating);
            // 
            // UniversityLabel
            // 
            this.UniversityLabel.AutoSize = true;
            this.UniversityLabel.Location = new System.Drawing.Point(9, 300);
            this.UniversityLabel.Name = "UniversityLabel";
            this.UniversityLabel.Size = new System.Drawing.Size(93, 17);
            this.UniversityLabel.TabIndex = 12;
            this.UniversityLabel.Text = "Университет";
            // 
            // UniversityTextBox
            // 
            this.UniversityTextBox.Location = new System.Drawing.Point(29, 320);
            this.UniversityTextBox.Name = "UniversityTextBox";
            this.UniversityTextBox.Size = new System.Drawing.Size(195, 22);
            this.UniversityTextBox.TabIndex = 13;
            this.UniversityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.UniversityTextBox_Validating);
            // 
            // SpecialityCodeLabel
            // 
            this.SpecialityCodeLabel.AutoSize = true;
            this.SpecialityCodeLabel.Location = new System.Drawing.Point(9, 347);
            this.SpecialityCodeLabel.Name = "SpecialityCodeLabel";
            this.SpecialityCodeLabel.Size = new System.Drawing.Size(137, 17);
            this.SpecialityCodeLabel.TabIndex = 14;
            this.SpecialityCodeLabel.Text = "Код специальности";
            // 
            // SpecialityCodeTextBox
            // 
            this.SpecialityCodeTextBox.Location = new System.Drawing.Point(28, 367);
            this.SpecialityCodeTextBox.Name = "SpecialityCodeTextBox";
            this.SpecialityCodeTextBox.Size = new System.Drawing.Size(196, 22);
            this.SpecialityCodeTextBox.TabIndex = 15;
            this.SpecialityCodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SpecialityCodeTextBox_Validating);
            // 
            // SpecialityLabel
            // 
            this.SpecialityLabel.AutoSize = true;
            this.SpecialityLabel.Location = new System.Drawing.Point(9, 392);
            this.SpecialityLabel.Name = "SpecialityLabel";
            this.SpecialityLabel.Size = new System.Drawing.Size(101, 17);
            this.SpecialityLabel.TabIndex = 16;
            this.SpecialityLabel.Text = "Специльность";
            // 
            // SpecialityTextBox
            // 
            this.SpecialityTextBox.Location = new System.Drawing.Point(29, 412);
            this.SpecialityTextBox.Name = "SpecialityTextBox";
            this.SpecialityTextBox.Size = new System.Drawing.Size(195, 22);
            this.SpecialityTextBox.TabIndex = 17;
            this.SpecialityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SpecialityTextBox_Validating);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(12, 437);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(70, 17);
            this.SurnameLabel.TabIndex = 19;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(29, 457);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(121, 22);
            this.SurnameTextBox.TabIndex = 20;
            this.SurnameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SurnameTextBox_Validating);
            // 
            // InitialsTextBox
            // 
            this.InitialsTextBox.Location = new System.Drawing.Point(166, 457);
            this.InitialsTextBox.Name = "InitialsTextBox";
            this.InitialsTextBox.Size = new System.Drawing.Size(58, 22);
            this.InitialsTextBox.TabIndex = 21;
            this.InitialsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.InitialsTextBox_Validating);
            // 
            // InitialsLabel
            // 
            this.InitialsLabel.AutoSize = true;
            this.InitialsLabel.Location = new System.Drawing.Point(152, 437);
            this.InitialsLabel.Name = "InitialsLabel";
            this.InitialsLabel.Size = new System.Drawing.Size(76, 17);
            this.InitialsLabel.TabIndex = 22;
            this.InitialsLabel.Text = "Инициалы";
            // 
            // AddAuthor
            // 
            this.AddAuthor.Location = new System.Drawing.Point(28, 485);
            this.AddAuthor.Name = "AddAuthor";
            this.AddAuthor.Size = new System.Drawing.Size(95, 42);
            this.AddAuthor.TabIndex = 23;
            this.AddAuthor.Text = "Добавить автора";
            this.AddAuthor.UseVisualStyleBackColor = true;
            this.AddAuthor.Click += new System.EventHandler(this.AddAuthor_Click);
            // 
            // RemoveAuthor
            // 
            this.RemoveAuthor.Location = new System.Drawing.Point(129, 485);
            this.RemoveAuthor.Name = "RemoveAuthor";
            this.RemoveAuthor.Size = new System.Drawing.Size(95, 42);
            this.RemoveAuthor.TabIndex = 24;
            this.RemoveAuthor.Text = "Удалить автора";
            this.RemoveAuthor.UseVisualStyleBackColor = true;
            this.RemoveAuthor.Click += new System.EventHandler(this.RemoveAuthor_Click);
            // 
            // Consent
            // 
            this.Consent.Location = new System.Drawing.Point(28, 541);
            this.Consent.Name = "Consent";
            this.Consent.Size = new System.Drawing.Size(75, 35);
            this.Consent.TabIndex = 25;
            this.Consent.Text = "OK";
            this.Consent.UseVisualStyleBackColor = true;
            this.Consent.Click += new System.EventHandler(this.Consent_Click);
            // 
            // Renouncement
            // 
            this.Renouncement.Location = new System.Drawing.Point(149, 541);
            this.Renouncement.Name = "Renouncement";
            this.Renouncement.Size = new System.Drawing.Size(75, 35);
            this.Renouncement.TabIndex = 26;
            this.Renouncement.Text = "Cancel";
            this.Renouncement.UseVisualStyleBackColor = true;
            this.Renouncement.Click += new System.EventHandler(this.Renouncement_Click);
            // 
            // AddingEditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 594);
            this.Controls.Add(this.Renouncement);
            this.Controls.Add(this.Consent);
            this.Controls.Add(this.RemoveAuthor);
            this.Controls.Add(this.AddAuthor);
            this.Controls.Add(this.InitialsLabel);
            this.Controls.Add(this.InitialsTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.SpecialityTextBox);
            this.Controls.Add(this.SpecialityLabel);
            this.Controls.Add(this.SpecialityCodeTextBox);
            this.Controls.Add(this.SpecialityCodeLabel);
            this.Controls.Add(this.UniversityTextBox);
            this.Controls.Add(this.UniversityLabel);
            this.Controls.Add(this.PublishingTextBox);
            this.Controls.Add(this.Publishing);
            this.Controls.Add(this.SelectEditionBox);
            this.Controls.Add(this.PagesTextBox);
            this.Controls.Add(this.PagesLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AddingEditionForm";
            this.Text = "Добавление";
            this.Load += new System.EventHandler(this.AddingEditionForm_Load);
            this.SelectEditionBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectEdition;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label PagesLabel;
        private System.Windows.Forms.TextBox PagesTextBox;
        private System.Windows.Forms.GroupBox SelectEditionBox;
        private System.Windows.Forms.Label Publishing;
        private System.Windows.Forms.TextBox PublishingTextBox;
        private System.Windows.Forms.Label UniversityLabel;
        private System.Windows.Forms.TextBox UniversityTextBox;
        private System.Windows.Forms.Label SpecialityCodeLabel;
        private System.Windows.Forms.TextBox SpecialityCodeTextBox;
        private System.Windows.Forms.Label SpecialityLabel;
        private System.Windows.Forms.TextBox SpecialityTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox InitialsTextBox;
        private System.Windows.Forms.Label InitialsLabel;
        private System.Windows.Forms.Button AddAuthor;
        private System.Windows.Forms.Button RemoveAuthor;
        private System.Windows.Forms.Button Consent;
        private System.Windows.Forms.Button Renouncement;
    }
}