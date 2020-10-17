namespace View
{
    partial class AddingAuthors
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RemoveAuthor = new System.Windows.Forms.Button();
            this.AddAuthor = new System.Windows.Forms.Button();
            this.InitialsLabel = new System.Windows.Forms.Label();
            this.InitialsTextBox1 = new System.Windows.Forms.TextBox();
            this.SurnameTextBox1 = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.AuthorsPanel = new System.Windows.Forms.Panel();
            this.SurnameTextBox4 = new System.Windows.Forms.TextBox();
            this.InitialsTextBox4 = new System.Windows.Forms.TextBox();
            this.SurnameTextBox3 = new System.Windows.Forms.TextBox();
            this.InitialsTextBox3 = new System.Windows.Forms.TextBox();
            this.SurnameTextBox2 = new System.Windows.Forms.TextBox();
            this.InitialsTextBox2 = new System.Windows.Forms.TextBox();
            this.AuthorsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveAuthor
            // 
            this.RemoveAuthor.Location = new System.Drawing.Point(363, 97);
            this.RemoveAuthor.Name = "RemoveAuthor";
            this.RemoveAuthor.Size = new System.Drawing.Size(95, 42);
            this.RemoveAuthor.TabIndex = 30;
            this.RemoveAuthor.Text = "Удалить автора";
            this.RemoveAuthor.UseVisualStyleBackColor = true;
            this.RemoveAuthor.Click += new System.EventHandler(this.RemoveAuthor_Click);
            // 
            // AddAuthor
            // 
            this.AddAuthor.Location = new System.Drawing.Point(363, 33);
            this.AddAuthor.Name = "AddAuthor";
            this.AddAuthor.Size = new System.Drawing.Size(95, 42);
            this.AddAuthor.TabIndex = 29;
            this.AddAuthor.Text = "Добавить автора";
            this.AddAuthor.UseVisualStyleBackColor = true;
            this.AddAuthor.Click += new System.EventHandler(this.AddAuthor_Click);
            // 
            // InitialsLabel
            // 
            this.InitialsLabel.AutoSize = true;
            this.InitialsLabel.Location = new System.Drawing.Point(222, 10);
            this.InitialsLabel.Name = "InitialsLabel";
            this.InitialsLabel.Size = new System.Drawing.Size(76, 17);
            this.InitialsLabel.TabIndex = 28;
            this.InitialsLabel.Text = "Инициалы";
            // 
            // InitialsTextBox1
            // 
            this.InitialsTextBox1.Location = new System.Drawing.Point(236, 30);
            this.InitialsTextBox1.Name = "InitialsTextBox1";
            this.InitialsTextBox1.Size = new System.Drawing.Size(58, 22);
            this.InitialsTextBox1.TabIndex = 27;
            this.InitialsTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.InitialsTextBoxValidating);
            // 
            // SurnameTextBox1
            // 
            this.SurnameTextBox1.Location = new System.Drawing.Point(24, 30);
            this.SurnameTextBox1.Name = "SurnameTextBox1";
            this.SurnameTextBox1.Size = new System.Drawing.Size(193, 22);
            this.SurnameTextBox1.TabIndex = 26;
            this.SurnameTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.SurnameTextBoxValidating);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(7, 10);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(70, 17);
            this.SurnameLabel.TabIndex = 25;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // AuthorsPanel
            // 
            this.AuthorsPanel.AutoScroll = true;
            this.AuthorsPanel.Controls.Add(this.SurnameTextBox4);
            this.AuthorsPanel.Controls.Add(this.InitialsTextBox4);
            this.AuthorsPanel.Controls.Add(this.SurnameTextBox3);
            this.AuthorsPanel.Controls.Add(this.InitialsTextBox3);
            this.AuthorsPanel.Controls.Add(this.SurnameTextBox2);
            this.AuthorsPanel.Controls.Add(this.InitialsTextBox2);
            this.AuthorsPanel.Controls.Add(this.SurnameTextBox1);
            this.AuthorsPanel.Controls.Add(this.SurnameLabel);
            this.AuthorsPanel.Controls.Add(this.InitialsTextBox1);
            this.AuthorsPanel.Controls.Add(this.InitialsLabel);
            this.AuthorsPanel.Location = new System.Drawing.Point(3, 4);
            this.AuthorsPanel.Name = "AuthorsPanel";
            this.AuthorsPanel.Size = new System.Drawing.Size(341, 145);
            this.AuthorsPanel.TabIndex = 31;
            // 
            // SurnameTextBox4
            // 
            this.SurnameTextBox4.Location = new System.Drawing.Point(24, 114);
            this.SurnameTextBox4.Name = "SurnameTextBox4";
            this.SurnameTextBox4.Size = new System.Drawing.Size(193, 22);
            this.SurnameTextBox4.TabIndex = 33;
            this.SurnameTextBox4.Validating += new System.ComponentModel.CancelEventHandler(this.SurnameTextBoxValidating);
            // 
            // InitialsTextBox4
            // 
            this.InitialsTextBox4.Location = new System.Drawing.Point(236, 114);
            this.InitialsTextBox4.Name = "InitialsTextBox4";
            this.InitialsTextBox4.Size = new System.Drawing.Size(58, 22);
            this.InitialsTextBox4.TabIndex = 34;
            this.InitialsTextBox4.Validating += new System.ComponentModel.CancelEventHandler(this.SurnameTextBoxValidating);
            // 
            // SurnameTextBox3
            // 
            this.SurnameTextBox3.Location = new System.Drawing.Point(24, 86);
            this.SurnameTextBox3.Name = "SurnameTextBox3";
            this.SurnameTextBox3.Size = new System.Drawing.Size(193, 22);
            this.SurnameTextBox3.TabIndex = 31;
            this.SurnameTextBox3.Validating += new System.ComponentModel.CancelEventHandler(this.SurnameTextBoxValidating);
            // 
            // InitialsTextBox3
            // 
            this.InitialsTextBox3.Location = new System.Drawing.Point(236, 86);
            this.InitialsTextBox3.Name = "InitialsTextBox3";
            this.InitialsTextBox3.Size = new System.Drawing.Size(58, 22);
            this.InitialsTextBox3.TabIndex = 32;
            this.InitialsTextBox3.Validating += new System.ComponentModel.CancelEventHandler(this.InitialsTextBoxValidating);
            // 
            // SurnameTextBox2
            // 
            this.SurnameTextBox2.Location = new System.Drawing.Point(24, 58);
            this.SurnameTextBox2.Name = "SurnameTextBox2";
            this.SurnameTextBox2.Size = new System.Drawing.Size(193, 22);
            this.SurnameTextBox2.TabIndex = 29;
            this.SurnameTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.SurnameTextBoxValidating);
            // 
            // InitialsTextBox2
            // 
            this.InitialsTextBox2.Location = new System.Drawing.Point(236, 58);
            this.InitialsTextBox2.Name = "InitialsTextBox2";
            this.InitialsTextBox2.Size = new System.Drawing.Size(58, 22);
            this.InitialsTextBox2.TabIndex = 30;
            this.InitialsTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.InitialsTextBoxValidating);
            // 
            // AddingAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AuthorsPanel);
            this.Controls.Add(this.RemoveAuthor);
            this.Controls.Add(this.AddAuthor);
            this.Name = "AddingAuthors";
            this.Size = new System.Drawing.Size(480, 152);
            this.AuthorsPanel.ResumeLayout(false);
            this.AuthorsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveAuthor;
        private System.Windows.Forms.Button AddAuthor;
        private System.Windows.Forms.Label InitialsLabel;
        private System.Windows.Forms.TextBox InitialsTextBox1;
        private System.Windows.Forms.TextBox SurnameTextBox1;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Panel AuthorsPanel;
        private System.Windows.Forms.TextBox SurnameTextBox4;
        private System.Windows.Forms.TextBox InitialsTextBox4;
        private System.Windows.Forms.TextBox SurnameTextBox3;
        private System.Windows.Forms.TextBox InitialsTextBox3;
        private System.Windows.Forms.TextBox SurnameTextBox2;
        private System.Windows.Forms.TextBox InitialsTextBox2;
    }
}
