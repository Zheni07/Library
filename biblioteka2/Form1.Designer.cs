namespace biblioteka2
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbtnDark = new System.Windows.Forms.RadioButton();
            this.rbtnLight = new System.Windows.Forms.RadioButton();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.btnRefresh);
            this.mainPanel.Controls.Add(this.btnDeleteBook);
            this.mainPanel.Controls.Add(this.lblStatus);
            this.mainPanel.Controls.Add(this.rbtnDark);
            this.mainPanel.Controls.Add(this.rbtnLight);
            this.mainPanel.Controls.Add(this.btnEditBook);
            this.mainPanel.Controls.Add(this.btnAddBook);
            this.mainPanel.Controls.Add(this.chkAvailable);
            this.mainPanel.Controls.Add(this.cmbGenre);
            this.mainPanel.Controls.Add(this.txtAuthor);
            this.mainPanel.Controls.Add(this.txtTitle);
            this.mainPanel.Controls.Add(this.lstBooks);
            this.mainPanel.Location = new System.Drawing.Point(9, 10);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(825, 240);
            this.mainPanel.TabIndex = 0;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(601, 190);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(93, 25);
            this.btnDeleteBook.TabIndex = 10;
            this.btnDeleteBook.Text = "Изтрий";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(238, 190);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(570, 19);
            this.lblStatus.TabIndex = 9;
            // 
            // rbtnDark
            // 
            this.rbtnDark.AutoSize = true;
            this.rbtnDark.Location = new System.Drawing.Point(136, 187);
            this.rbtnDark.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnDark.Name = "rbtnDark";
            this.rbtnDark.Size = new System.Drawing.Size(87, 17);
            this.rbtnDark.TabIndex = 8;
            this.rbtnDark.TabStop = true;
            this.rbtnDark.Text = "Тъмна тема\r\n";
            this.rbtnDark.UseVisualStyleBackColor = true;
            this.rbtnDark.CheckedChanged += new System.EventHandler(this.rbtnDark_CheckedChanged);
            // 
            // rbtnLight
            // 
            this.rbtnLight.AutoSize = true;
            this.rbtnLight.Location = new System.Drawing.Point(12, 187);
            this.rbtnLight.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnLight.Name = "rbtnLight";
            this.rbtnLight.Size = new System.Drawing.Size(89, 17);
            this.rbtnLight.TabIndex = 7;
            this.rbtnLight.TabStop = true;
            this.rbtnLight.Text = "Светла тема";
            this.rbtnLight.UseVisualStyleBackColor = true;
            this.rbtnLight.CheckedChanged += new System.EventHandler(this.rbtnLight_CheckedChanged);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(715, 139);
            this.btnEditBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(93, 25);
            this.btnEditBook.TabIndex = 6;
            this.btnEditBook.Text = "Редактирай";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(601, 138);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(93, 25);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Добави ";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Location = new System.Drawing.Point(476, 143);
            this.chkAvailable.Margin = new System.Windows.Forms.Padding(2);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(80, 17);
            this.chkAvailable.TabIndex = 4;
            this.chkAvailable.Text = "Наличност";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(340, 141);
            this.cmbGenre.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(92, 21);
            this.cmbGenre.TabIndex = 3;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(178, 141);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(126, 20);
            this.txtAuthor.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 143);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(126, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.Location = new System.Drawing.Point(12, 13);
            this.lstBooks.Margin = new System.Windows.Forms.Padding(2);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(797, 108);
            this.lstBooks.TabIndex = 0;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(715, 190);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 25);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Обнови";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 260);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.RadioButton rbtnDark;
        private System.Windows.Forms.RadioButton rbtnLight;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnRefresh;
    }
}

