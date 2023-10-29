namespace AnketWinform
{
    partial class Anket
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameTextBox = new TextBox();
            BirthTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            EmailTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            NameLbl = new Label();
            SurnameLbl = new Label();
            EmailLbl = new Label();
            PhoneLbl = new Label();
            BirthLbl = new Label();
            listBox = new ListBox();
            button1 = new Button();
            FileNameTextBox = new TextBox();
            ElaveBtn = new Button();
            SaveBtn = new Button();
            LoadBtn = new Button();
            DeyisBtn = new Button();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Location = new Point(129, 29);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(253, 27);
            NameTextBox.TabIndex = 0;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // BirthTextBox
            // 
            BirthTextBox.BorderStyle = BorderStyle.FixedSingle;
            BirthTextBox.Location = new Point(129, 220);
            BirthTextBox.Name = "BirthTextBox";
            BirthTextBox.Size = new Size(253, 27);
            BirthTextBox.TabIndex = 1;
            BirthTextBox.TextChanged += BirthTextBox_TextChanged;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.BorderStyle = BorderStyle.FixedSingle;
            PhoneTextBox.Location = new Point(129, 170);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(253, 27);
            PhoneTextBox.TabIndex = 2;
            PhoneTextBox.TextChanged += PhoneTextBox_TextChanged;
            // 
            // EmailTextBox
            // 
            EmailTextBox.BorderStyle = BorderStyle.FixedSingle;
            EmailTextBox.Location = new Point(129, 124);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(253, 27);
            EmailTextBox.TabIndex = 3;
            EmailTextBox.TextChanged += EmailTextBox_TextChanged;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.BorderStyle = BorderStyle.FixedSingle;
            SurnameTextBox.Location = new Point(129, 76);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(253, 27);
            SurnameTextBox.TabIndex = 4;
            SurnameTextBox.TextChanged += SurnameTextBox_TextChanged;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NameLbl.Location = new Point(28, 32);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(59, 20);
            NameLbl.TabIndex = 5;
            NameLbl.Text = "Name :";
            // 
            // SurnameLbl
            // 
            SurnameLbl.AutoSize = true;
            SurnameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SurnameLbl.Location = new Point(28, 79);
            SurnameLbl.Name = "SurnameLbl";
            SurnameLbl.Size = new Size(79, 20);
            SurnameLbl.TabIndex = 6;
            SurnameLbl.Text = "Surname :";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EmailLbl.Location = new Point(28, 127);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(55, 20);
            EmailLbl.TabIndex = 7;
            EmailLbl.Text = "Email :";
            // 
            // PhoneLbl
            // 
            PhoneLbl.AutoSize = true;
            PhoneLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneLbl.Location = new Point(28, 173);
            PhoneLbl.Name = "PhoneLbl";
            PhoneLbl.Size = new Size(61, 20);
            PhoneLbl.TabIndex = 8;
            PhoneLbl.Text = "Phone :";
            // 
            // BirthLbl
            // 
            BirthLbl.AutoSize = true;
            BirthLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BirthLbl.Location = new Point(34, 223);
            BirthLbl.Name = "BirthLbl";
            BirthLbl.Size = new Size(52, 20);
            BirthLbl.TabIndex = 9;
            BirthLbl.Text = "Birth :";
            // 
            // listBox
            // 
            listBox.BorderStyle = BorderStyle.FixedSingle;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 20;
            listBox.Location = new Point(586, 29);
            listBox.Name = "listBox";
            listBox.Size = new Size(351, 342);
            listBox.TabIndex = 10;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(586, 28);
            button1.Name = "button1";
            button1.Size = new Size(351, 29);
            button1.TabIndex = 11;
            button1.Text = "ListBox";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FileNameTextBox
            // 
            FileNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            FileNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FileNameTextBox.Location = new Point(586, 368);
            FileNameTextBox.Name = "FileNameTextBox";
            FileNameTextBox.Size = new Size(351, 27);
            FileNameTextBox.TabIndex = 12;
            FileNameTextBox.Text = "File Name";
            FileNameTextBox.TextChanged += FileNameTextBox_TextChanged;
            // 
            // ElaveBtn
            // 
            ElaveBtn.BackColor = SystemColors.ButtonHighlight;
            ElaveBtn.FlatStyle = FlatStyle.Flat;
            ElaveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ElaveBtn.Location = new Point(161, 260);
            ElaveBtn.Name = "ElaveBtn";
            ElaveBtn.Size = new Size(190, 29);
            ElaveBtn.TabIndex = 14;
            ElaveBtn.Text = "Əlavə et";
            ElaveBtn.UseVisualStyleBackColor = false;
            ElaveBtn.Click += ElaveBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = SystemColors.ButtonHighlight;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.Location = new Point(762, 401);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(175, 29);
            SaveBtn.TabIndex = 15;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = SystemColors.ButtonHighlight;
            LoadBtn.FlatStyle = FlatStyle.Flat;
            LoadBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoadBtn.Location = new Point(586, 401);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(175, 29);
            LoadBtn.TabIndex = 16;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // DeyisBtn
            // 
            DeyisBtn.BackColor = SystemColors.ButtonHighlight;
            DeyisBtn.FlatStyle = FlatStyle.Flat;
            DeyisBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeyisBtn.Location = new Point(161, 295);
            DeyisBtn.Name = "DeyisBtn";
            DeyisBtn.Size = new Size(190, 29);
            DeyisBtn.TabIndex = 17;
            DeyisBtn.Text = "Dəyiş";
            DeyisBtn.UseVisualStyleBackColor = false;
            DeyisBtn.Click += DeyisBtn_Click;
            // 
            // Anket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1009, 500);
            Controls.Add(DeyisBtn);
            Controls.Add(LoadBtn);
            Controls.Add(SaveBtn);
            Controls.Add(ElaveBtn);
            Controls.Add(FileNameTextBox);
            Controls.Add(button1);
            Controls.Add(listBox);
            Controls.Add(BirthLbl);
            Controls.Add(PhoneLbl);
            Controls.Add(EmailLbl);
            Controls.Add(SurnameLbl);
            Controls.Add(NameLbl);
            Controls.Add(SurnameTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(PhoneTextBox);
            Controls.Add(BirthTextBox);
            Controls.Add(NameTextBox);
            Name = "Anket";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private TextBox BirthTextBox;
        private TextBox PhoneTextBox;
        private TextBox EmailTextBox;
        private TextBox SurnameTextBox;
        private Label NameLbl;
        private Label SurnameLbl;
        private Label EmailLbl;
        private Label PhoneLbl;
        private Label BirthLbl;
        private ListBox listBox;
        private Button button1;
        private TextBox FileNameTextBox;
        private Button ElaveBtn;
        private Button SaveBtn;
        private Button LoadBtn;
        private Button DeyisBtn;
    }
}