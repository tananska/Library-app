namespace приложение
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
            this.addBookLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.booksListView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.upperLettersRadioButton = new System.Windows.Forms.RadioButton();
            this.lowerLettersRadioButton = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBookLabel
            // 
            this.addBookLabel.AutoSize = true;
            this.addBookLabel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.addBookLabel.Location = new System.Drawing.Point(21, 54);
            this.addBookLabel.Name = "addBookLabel";
            this.addBookLabel.Size = new System.Drawing.Size(91, 17);
            this.addBookLabel.TabIndex = 0;
            this.addBookLabel.Text = "Въведи книга";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(21, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Въведи книга\r\nза търсене";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(21, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Налични \r\nкниги\r\n";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(158, 51);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(158, 103);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 4;
            // 
            // booksListView
            // 
            this.booksListView.Location = new System.Drawing.Point(116, 174);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(142, 130);
            this.booksListView.TabIndex = 5;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upperLettersRadioButton);
            this.groupBox1.Controls.Add(this.lowerLettersRadioButton);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(316, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 250);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Избор на букви";
            // 
            // upperLettersRadioButton
            // 
            this.upperLettersRadioButton.AutoSize = true;
            this.upperLettersRadioButton.Location = new System.Drawing.Point(8, 101);
            this.upperLettersRadioButton.Name = "upperLettersRadioButton";
            this.upperLettersRadioButton.Size = new System.Drawing.Size(93, 17);
            this.upperLettersRadioButton.TabIndex = 1;
            this.upperLettersRadioButton.TabStop = true;
            this.upperLettersRadioButton.Text = "Главни букви";
            this.upperLettersRadioButton.UseVisualStyleBackColor = true;
            this.upperLettersRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lowerLettersRadioButton
            // 
            this.lowerLettersRadioButton.AutoSize = true;
            this.lowerLettersRadioButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lowerLettersRadioButton.Location = new System.Drawing.Point(8, 59);
            this.lowerLettersRadioButton.Name = "lowerLettersRadioButton";
            this.lowerLettersRadioButton.Size = new System.Drawing.Size(90, 17);
            this.lowerLettersRadioButton.TabIndex = 0;
            this.lowerLettersRadioButton.TabStop = true;
            this.lowerLettersRadioButton.Text = "Малки букви";
            this.lowerLettersRadioButton.UseVisualStyleBackColor = false;
            this.lowerLettersRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.addButton.Location = new System.Drawing.Point(479, 79);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добави";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.searchButton.Location = new System.Drawing.Point(479, 149);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Търси";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.deleteButton.Location = new System.Drawing.Point(479, 211);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Изтрий";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.clearButton.Location = new System.Drawing.Point(479, 281);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Изчисти";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(593, 333);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.booksListView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBookLabel);
            this.Name = "Form1";
            this.Text = "Каталог с книги";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addBookLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListView booksListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton upperLettersRadioButton;
        private System.Windows.Forms.RadioButton lowerLettersRadioButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
    }
}

