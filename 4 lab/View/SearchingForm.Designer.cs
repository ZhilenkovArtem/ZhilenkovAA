namespace View
{
    partial class SearchingForm
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
            this.EditionDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.EditionDescriptionGridView = new System.Windows.Forms.DataGridView();
            this.SelectEdition = new System.Windows.Forms.ComboBox();
            this.SearchingParamLabel = new System.Windows.Forms.Label();
            this.SearchingWordTextBox = new System.Windows.Forms.TextBox();
            this.SearchingWordLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.DateSearchingLabel = new System.Windows.Forms.Label();
            this.EditionDescriptionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditionDescriptionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EditionDescriptionGroupBox
            // 
            this.EditionDescriptionGroupBox.Controls.Add(this.EditionDescriptionGridView);
            this.EditionDescriptionGroupBox.Location = new System.Drawing.Point(27, 22);
            this.EditionDescriptionGroupBox.Name = "EditionDescriptionGroupBox";
            this.EditionDescriptionGroupBox.Size = new System.Drawing.Size(745, 320);
            this.EditionDescriptionGroupBox.TabIndex = 2;
            this.EditionDescriptionGroupBox.TabStop = false;
            this.EditionDescriptionGroupBox.Text = "Описание изданий";
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
            // SelectEdition
            // 
            this.SelectEdition.FormattingEnabled = true;
            this.SelectEdition.Items.AddRange(new object[] {
            "Название",
            "Город",
            "Дата",
            "Количество страниц"});
            this.SelectEdition.Location = new System.Drawing.Point(33, 377);
            this.SelectEdition.Name = "SelectEdition";
            this.SelectEdition.Size = new System.Drawing.Size(195, 24);
            this.SelectEdition.TabIndex = 3;
            this.SelectEdition.SelectedIndexChanged += new System.EventHandler(this.SelectEdition_SelectedIndexChanged);
            // 
            // SearchingParamLabel
            // 
            this.SearchingParamLabel.AutoSize = true;
            this.SearchingParamLabel.Location = new System.Drawing.Point(30, 357);
            this.SearchingParamLabel.Name = "SearchingParamLabel";
            this.SearchingParamLabel.Size = new System.Drawing.Size(124, 17);
            this.SearchingParamLabel.TabIndex = 4;
            this.SearchingParamLabel.Text = "Параметр поиска";
            // 
            // SearchingWordTextBox
            // 
            this.SearchingWordTextBox.Location = new System.Drawing.Point(251, 377);
            this.SearchingWordTextBox.Name = "SearchingWordTextBox";
            this.SearchingWordTextBox.Size = new System.Drawing.Size(199, 22);
            this.SearchingWordTextBox.TabIndex = 5;
            // 
            // SearchingWordLabel
            // 
            this.SearchingWordLabel.AutoSize = true;
            this.SearchingWordLabel.Location = new System.Drawing.Point(248, 357);
            this.SearchingWordLabel.Name = "SearchingWordLabel";
            this.SearchingWordLabel.Size = new System.Drawing.Size(126, 17);
            this.SearchingWordLabel.TabIndex = 6;
            this.SearchingWordLabel.Text = "Слово для поиска";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(687, 371);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(79, 35);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(474, 375);
            this.DatePicker.MaxDate = new System.DateTime(2020, 10, 10, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(186, 22);
            this.DatePicker.TabIndex = 8;
            this.DatePicker.Value = new System.DateTime(2020, 10, 10, 0, 0, 0, 0);
            // 
            // DateSearchingLabel
            // 
            this.DateSearchingLabel.AutoSize = true;
            this.DateSearchingLabel.Location = new System.Drawing.Point(471, 355);
            this.DateSearchingLabel.Name = "DateSearchingLabel";
            this.DateSearchingLabel.Size = new System.Drawing.Size(120, 17);
            this.DateSearchingLabel.TabIndex = 9;
            this.DateSearchingLabel.Text = "Дата для поиска";
            // 
            // SearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateSearchingLabel);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchingWordLabel);
            this.Controls.Add(this.SearchingWordTextBox);
            this.Controls.Add(this.SearchingParamLabel);
            this.Controls.Add(this.SelectEdition);
            this.Controls.Add(this.EditionDescriptionGroupBox);
            this.Name = "SearchingForm";
            this.Text = "Поиск издания";
            this.Load += new System.EventHandler(this.SearchingForm_Load);
            this.EditionDescriptionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditionDescriptionGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox EditionDescriptionGroupBox;
        private System.Windows.Forms.DataGridView EditionDescriptionGridView;
        private System.Windows.Forms.ComboBox SelectEdition;
        private System.Windows.Forms.Label SearchingParamLabel;
        private System.Windows.Forms.TextBox SearchingWordTextBox;
        private System.Windows.Forms.Label SearchingWordLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label DateSearchingLabel;
    }
}