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
            this.SearchedEditionGridView = new System.Windows.Forms.DataGridView();
            this.SelectEdition = new System.Windows.Forms.ComboBox();
            this.SearchingParamLabel = new System.Windows.Forms.Label();
            this.SearchingWordTextBox = new System.Windows.Forms.TextBox();
            this.SearchingWordLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.EditionDescriptionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchedEditionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EditionDescriptionGroupBox
            // 
            this.EditionDescriptionGroupBox.Controls.Add(this.SearchedEditionGridView);
            this.EditionDescriptionGroupBox.Location = new System.Drawing.Point(27, 22);
            this.EditionDescriptionGroupBox.Name = "EditionDescriptionGroupBox";
            this.EditionDescriptionGroupBox.Size = new System.Drawing.Size(745, 320);
            this.EditionDescriptionGroupBox.TabIndex = 2;
            this.EditionDescriptionGroupBox.TabStop = false;
            this.EditionDescriptionGroupBox.Text = "Описание изданий";
            // 
            // SearchedEditionGridView
            // 
            this.SearchedEditionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchedEditionGridView.Location = new System.Drawing.Point(6, 21);
            this.SearchedEditionGridView.Name = "SearchedEditionGridView";
            this.SearchedEditionGridView.ReadOnly = true;
            this.SearchedEditionGridView.RowHeadersVisible = false;
            this.SearchedEditionGridView.RowHeadersWidth = 51;
            this.SearchedEditionGridView.RowTemplate.Height = 24;
            this.SearchedEditionGridView.Size = new System.Drawing.Size(733, 293);
            this.SearchedEditionGridView.TabIndex = 0;
            // 
            // SelectEdition
            // 
            this.SelectEdition.FormattingEnabled = true;
            this.SelectEdition.Items.AddRange(new object[] {
            "Название",
            "Город",
            "Год выхода",
            "Количество страниц"});
            this.SelectEdition.Location = new System.Drawing.Point(33, 374);
            this.SelectEdition.Name = "SelectEdition";
            this.SelectEdition.Size = new System.Drawing.Size(195, 24);
            this.SelectEdition.TabIndex = 3;
            this.SelectEdition.SelectedIndexChanged += new System.EventHandler(this.SelectEdition_SelectedIndexChanged);
            // 
            // SearchingParamLabel
            // 
            this.SearchingParamLabel.AutoSize = true;
            this.SearchingParamLabel.Location = new System.Drawing.Point(30, 354);
            this.SearchingParamLabel.Name = "SearchingParamLabel";
            this.SearchingParamLabel.Size = new System.Drawing.Size(124, 17);
            this.SearchingParamLabel.TabIndex = 4;
            this.SearchingParamLabel.Text = "Параметр поиска";
            // 
            // SearchingWordTextBox
            // 
            this.SearchingWordTextBox.Location = new System.Drawing.Point(295, 374);
            this.SearchingWordTextBox.Name = "SearchingWordTextBox";
            this.SearchingWordTextBox.Size = new System.Drawing.Size(199, 22);
            this.SearchingWordTextBox.TabIndex = 5;
            // 
            // SearchingWordLabel
            // 
            this.SearchingWordLabel.AutoSize = true;
            this.SearchingWordLabel.Location = new System.Drawing.Point(292, 354);
            this.SearchingWordLabel.Name = "SearchingWordLabel";
            this.SearchingWordLabel.Size = new System.Drawing.Size(126, 17);
            this.SearchingWordLabel.TabIndex = 6;
            this.SearchingWordLabel.Text = "Слово для поиска";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(557, 374);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(79, 33);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(687, 374);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(79, 33);
            this.Close.TabIndex = 10;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // SearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchingWordLabel);
            this.Controls.Add(this.SearchingWordTextBox);
            this.Controls.Add(this.SearchingParamLabel);
            this.Controls.Add(this.SelectEdition);
            this.Controls.Add(this.EditionDescriptionGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SearchingForm";
            this.Text = "Поиск издания";
            this.Load += new System.EventHandler(this.SearchingForm_Load);
            this.EditionDescriptionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchedEditionGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox EditionDescriptionGroupBox;
        private System.Windows.Forms.DataGridView SearchedEditionGridView;
        private System.Windows.Forms.ComboBox SelectEdition;
        private System.Windows.Forms.Label SearchingParamLabel;
        private System.Windows.Forms.TextBox SearchingWordTextBox;
        private System.Windows.Forms.Label SearchingWordLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button Close;
    }
}