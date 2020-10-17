namespace View
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EditionDescriptionGridView = new System.Windows.Forms.DataGridView();
            this.EditionDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.AddEdition = new System.Windows.Forms.Button();
            this.RemoveEdition = new System.Windows.Forms.Button();
            this.Searching = new System.Windows.Forms.Button();
            this.RandomEditionButton = new System.Windows.Forms.Button();
            this.SaveData = new System.Windows.Forms.Button();
            this.LoadData = new System.Windows.Forms.Button();
            this.CloseForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditionDescriptionGridView)).BeginInit();
            this.EditionDescriptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditionDescriptionGridView
            // 
            this.EditionDescriptionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditionDescriptionGridView.Location = new System.Drawing.Point(6, 21);
            this.EditionDescriptionGridView.Name = "EditionDescriptionGridView";
            this.EditionDescriptionGridView.ReadOnly = true;
            this.EditionDescriptionGridView.RowHeadersVisible = false;
            this.EditionDescriptionGridView.RowHeadersWidth = 51;
            this.EditionDescriptionGridView.RowTemplate.Height = 24;
            this.EditionDescriptionGridView.Size = new System.Drawing.Size(733, 293);
            this.EditionDescriptionGridView.TabIndex = 0;
            // 
            // EditionDescriptionGroupBox
            // 
            this.EditionDescriptionGroupBox.Controls.Add(this.EditionDescriptionGridView);
            this.EditionDescriptionGroupBox.Location = new System.Drawing.Point(27, 22);
            this.EditionDescriptionGroupBox.Name = "EditionDescriptionGroupBox";
            this.EditionDescriptionGroupBox.Size = new System.Drawing.Size(745, 320);
            this.EditionDescriptionGroupBox.TabIndex = 1;
            this.EditionDescriptionGroupBox.TabStop = false;
            this.EditionDescriptionGroupBox.Text = "Описание изданий";
            // 
            // AddEdition
            // 
            this.AddEdition.Location = new System.Drawing.Point(26, 367);
            this.AddEdition.Name = "AddEdition";
            this.AddEdition.Size = new System.Drawing.Size(102, 46);
            this.AddEdition.TabIndex = 2;
            this.AddEdition.Text = "Добавить издание";
            this.AddEdition.UseVisualStyleBackColor = true;
            this.AddEdition.Click += new System.EventHandler(this.AddEdition_Click);
            // 
            // RemoveEdition
            // 
            this.RemoveEdition.Location = new System.Drawing.Point(134, 367);
            this.RemoveEdition.Name = "RemoveEdition";
            this.RemoveEdition.Size = new System.Drawing.Size(102, 46);
            this.RemoveEdition.TabIndex = 3;
            this.RemoveEdition.Text = "Удалить издание";
            this.RemoveEdition.UseVisualStyleBackColor = true;
            this.RemoveEdition.Click += new System.EventHandler(this.RemoveEdition_Click);
            // 
            // Searching
            // 
            this.Searching.Location = new System.Drawing.Point(350, 367);
            this.Searching.Name = "Searching";
            this.Searching.Size = new System.Drawing.Size(102, 46);
            this.Searching.TabIndex = 4;
            this.Searching.Text = "Поиск изданий";
            this.Searching.UseVisualStyleBackColor = true;
            this.Searching.Click += new System.EventHandler(this.Searching_Click);
            // 
            // RandomEditionButton
            // 
            this.RandomEditionButton.Location = new System.Drawing.Point(242, 367);
            this.RandomEditionButton.Name = "RandomEditionButton";
            this.RandomEditionButton.Size = new System.Drawing.Size(102, 46);
            this.RandomEditionButton.TabIndex = 5;
            this.RandomEditionButton.Text = "Слуйчайное издание";
            this.RandomEditionButton.UseVisualStyleBackColor = true;
            this.RandomEditionButton.Click += new System.EventHandler(this.RandomEdition_Click);
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(458, 367);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(102, 46);
            this.SaveData.TabIndex = 6;
            this.SaveData.Text = "Сохранить";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(566, 367);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(102, 46);
            this.LoadData.TabIndex = 7;
            this.LoadData.Text = "Загрузить";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(674, 367);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(102, 46);
            this.CloseForm.TabIndex = 8;
            this.CloseForm.Text = "Закрыть";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.RandomEditionButton);
            this.Controls.Add(this.Searching);
            this.Controls.Add(this.RemoveEdition);
            this.Controls.Add(this.AddEdition);
            this.Controls.Add(this.EditionDescriptionGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Издания";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditionDescriptionGridView)).EndInit();
            this.EditionDescriptionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EditionDescriptionGridView;
        private System.Windows.Forms.GroupBox EditionDescriptionGroupBox;
        private System.Windows.Forms.Button AddEdition;
        private System.Windows.Forms.Button RemoveEdition;
        private System.Windows.Forms.Button Searching;
        private System.Windows.Forms.Button RandomEditionButton;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.Button CloseForm;
    }
}

