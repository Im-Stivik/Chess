namespace Chess
{
    
    
    public partial class SettingsEditForm
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MarginToTopTextBox = new System.Windows.Forms.TextBox();
            this.MarginToLeftTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WhiteCellColorBtn = new System.Windows.Forms.Button();
            this.BlackCellColorBtn = new System.Windows.Forms.Button();
            this.MoveOptionColorBtn = new System.Windows.Forms.Button();
            this.EatOptionColorBtn = new System.Windows.Forms.Button();
            this.HighlightedCellColorBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.PiesSizeTextBox = new System.Windows.Forms.TextBox();
            this.ForwardMarginLeftTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ForwardMarginTopTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ForwardWidthTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ForwardHeightTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BackMarginLeftTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BackMarginTopTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BackWidthTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BackHeightTextBox = new System.Windows.Forms.TextBox();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = null;
            this.label1.Text = "Selected Highlight:";
            this.label1.Location = new System.Drawing.Point(48, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = null;
            this.label2.Text = "Margin to top";
            this.label2.Location = new System.Drawing.Point(48, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = null;
            this.label3.Text = "Pies Size:";
            this.label3.Location = new System.Drawing.Point(48, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 0;
            // 
            // MarginToTopTextBox
            // 
            this.MarginToTopTextBox.Text = "";
            this.MarginToTopTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MarginToTopTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MarginToTopTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MarginToTopTextBox.MaxLength = 3;
            this.MarginToTopTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MarginToTopTextBox.Location = new System.Drawing.Point(152, 96);
            this.MarginToTopTextBox.Name = "MarginToTopTextBox";
            this.MarginToTopTextBox.Size = new System.Drawing.Size(72, 22);
            this.MarginToTopTextBox.TabIndex = 1;
            this.MarginToTopTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IgnoreNotNumeric);
            // 
            // MarginToLeftTextBox
            // 
            this.MarginToLeftTextBox.Text = "";
            this.MarginToLeftTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MarginToLeftTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MarginToLeftTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MarginToLeftTextBox.MaxLength = 3;
            this.MarginToLeftTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MarginToLeftTextBox.Location = new System.Drawing.Point(152, 144);
            this.MarginToLeftTextBox.Name = "MarginToLeftTextBox";
            this.MarginToLeftTextBox.Size = new System.Drawing.Size(72, 22);
            this.MarginToLeftTextBox.TabIndex = 1;
            this.MarginToLeftTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IgnoreNotNumeric);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = null;
            this.label4.Text = "Margin To Left";
            this.label4.Location = new System.Drawing.Point(48, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = null;
            this.label5.Text = "Forward Margin To Left";
            this.label5.Location = new System.Drawing.Point(48, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Image = null;
            this.label6.Text = "Black Cell Color:";
            this.label6.Location = new System.Drawing.Point(48, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Image = null;
            this.label7.Text = "Move Option Color";
            this.label7.Location = new System.Drawing.Point(48, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Image = null;
            this.label8.Text = "Eat Option Color";
            this.label8.Location = new System.Drawing.Point(48, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 0;
            // 
            // WhiteCellColorBtn
            // 
            this.WhiteCellColorBtn.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.WhiteCellColorBtn.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.WhiteCellColorBtn.Text = "";
            this.WhiteCellColorBtn.UseVisualStyleBackColor = true;
            this.WhiteCellColorBtn.Location = new System.Drawing.Point(160, 192);
            this.WhiteCellColorBtn.Name = "WhiteCellColorBtn";
            this.WhiteCellColorBtn.Size = new System.Drawing.Size(26, 25);
            this.WhiteCellColorBtn.TabIndex = 2;
            this.WhiteCellColorBtn.Click += new System.EventHandler(this.PickColorBtn_Click);
            // 
            // BlackCellColorBtn
            // 
            this.BlackCellColorBtn.BackColor = System.Drawing.Color.Green;
            this.BlackCellColorBtn.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.BlackCellColorBtn.Text = "";
            this.BlackCellColorBtn.UseVisualStyleBackColor = true;
            this.BlackCellColorBtn.Location = new System.Drawing.Point(160, 232);
            this.BlackCellColorBtn.Name = "BlackCellColorBtn";
            this.BlackCellColorBtn.Size = new System.Drawing.Size(26, 25);
            this.BlackCellColorBtn.TabIndex = 2;
            this.BlackCellColorBtn.Click += new System.EventHandler(this.PickColorBtn_Click);
            // 
            // MoveOptionColorBtn
            // 
            this.MoveOptionColorBtn.BackColor = System.Drawing.Color.Cyan;
            this.MoveOptionColorBtn.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MoveOptionColorBtn.Text = "";
            this.MoveOptionColorBtn.UseVisualStyleBackColor = true;
            this.MoveOptionColorBtn.Location = new System.Drawing.Point(160, 272);
            this.MoveOptionColorBtn.Name = "MoveOptionColorBtn";
            this.MoveOptionColorBtn.Size = new System.Drawing.Size(26, 25);
            this.MoveOptionColorBtn.TabIndex = 2;
            this.MoveOptionColorBtn.Click += new System.EventHandler(this.PickColorBtn_Click);
            // 
            // EatOptionColorBtn
            // 
            this.EatOptionColorBtn.BackColor = System.Drawing.Color.Gold;
            this.EatOptionColorBtn.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.EatOptionColorBtn.Text = "";
            this.EatOptionColorBtn.UseVisualStyleBackColor = true;
            this.EatOptionColorBtn.Location = new System.Drawing.Point(160, 312);
            this.EatOptionColorBtn.Name = "EatOptionColorBtn";
            this.EatOptionColorBtn.Size = new System.Drawing.Size(26, 25);
            this.EatOptionColorBtn.TabIndex = 2;
            this.EatOptionColorBtn.Click += new System.EventHandler(this.PickColorBtn_Click);
            // 
            // HighlightedCellColorBtn
            // 
            this.HighlightedCellColorBtn.BackColor = System.Drawing.Color.DimGray;
            this.HighlightedCellColorBtn.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.HighlightedCellColorBtn.Text = "";
            this.HighlightedCellColorBtn.UseVisualStyleBackColor = true;
            this.HighlightedCellColorBtn.Location = new System.Drawing.Point(160, 353);
            this.HighlightedCellColorBtn.Name = "HighlightedCellColorBtn";
            this.HighlightedCellColorBtn.Size = new System.Drawing.Size(26, 25);
            this.HighlightedCellColorBtn.TabIndex = 2;
            this.HighlightedCellColorBtn.Click += new System.EventHandler(this.PickColorBtn_Click);
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Location = new System.Drawing.Point(280, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 30);
            this.button1.TabIndex = 3;
            this.button1.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // button2
            // 
            this.button2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Location = new System.Drawing.Point(296, 672);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 30);
            this.button2.TabIndex = 3;
            this.button2.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // button3
            // 
            this.button3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.button3.Text = "Import";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Location = new System.Drawing.Point(280, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 30);
            this.button3.TabIndex = 3;
            this.button3.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = null;
            this.label9.Text = "White Cell Color:";
            this.label9.Location = new System.Drawing.Point(48, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 0;
            // 
            // PiesSizeTextBox
            // 
            this.PiesSizeTextBox.Text = "";
            this.PiesSizeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PiesSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PiesSizeTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PiesSizeTextBox.MaxLength = 3;
            this.PiesSizeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PiesSizeTextBox.Location = new System.Drawing.Point(152, 40);
            this.PiesSizeTextBox.Name = "PiesSizeTextBox";
            this.PiesSizeTextBox.Size = new System.Drawing.Size(72, 22);
            this.PiesSizeTextBox.TabIndex = 1;
            // 
            // ForwardMarginLeftTextBox
            // 
            this.ForwardMarginLeftTextBox.Text = "";
            this.ForwardMarginLeftTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ForwardMarginLeftTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ForwardMarginLeftTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ForwardMarginLeftTextBox.MaxLength = 3;
            this.ForwardMarginLeftTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForwardMarginLeftTextBox.Location = new System.Drawing.Point(200, 400);
            this.ForwardMarginLeftTextBox.Name = "ForwardMarginLeftTextBox";
            this.ForwardMarginLeftTextBox.Size = new System.Drawing.Size(72, 22);
            this.ForwardMarginLeftTextBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Image = null;
            this.label10.Text = "Forward Margin To Top";
            this.label10.Location = new System.Drawing.Point(48, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 16);
            this.label10.TabIndex = 0;
            // 
            // ForwardMarginTopTextBox
            // 
            this.ForwardMarginTopTextBox.Text = "";
            this.ForwardMarginTopTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ForwardMarginTopTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ForwardMarginTopTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ForwardMarginTopTextBox.MaxLength = 3;
            this.ForwardMarginTopTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForwardMarginTopTextBox.Location = new System.Drawing.Point(200, 432);
            this.ForwardMarginTopTextBox.Name = "ForwardMarginTopTextBox";
            this.ForwardMarginTopTextBox.Size = new System.Drawing.Size(72, 22);
            this.ForwardMarginTopTextBox.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Image = null;
            this.label11.Text = "Forward Butotn Height";
            this.label11.Location = new System.Drawing.Point(48, 500);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 16);
            this.label11.TabIndex = 0;
            // 
            // ForwardWidthTextBox
            // 
            this.ForwardWidthTextBox.Text = "";
            this.ForwardWidthTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ForwardWidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ForwardWidthTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ForwardWidthTextBox.MaxLength = 3;
            this.ForwardWidthTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForwardWidthTextBox.Location = new System.Drawing.Point(200, 466);
            this.ForwardWidthTextBox.Name = "ForwardWidthTextBox";
            this.ForwardWidthTextBox.Size = new System.Drawing.Size(72, 22);
            this.ForwardWidthTextBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Image = null;
            this.label12.Text = "Forward Butotn width";
            this.label12.Location = new System.Drawing.Point(48, 468);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 16);
            this.label12.TabIndex = 0;
            // 
            // ForwardHeightTextBox
            // 
            this.ForwardHeightTextBox.Text = "";
            this.ForwardHeightTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ForwardHeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ForwardHeightTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ForwardHeightTextBox.MaxLength = 3;
            this.ForwardHeightTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForwardHeightTextBox.Location = new System.Drawing.Point(200, 500);
            this.ForwardHeightTextBox.Name = "ForwardHeightTextBox";
            this.ForwardHeightTextBox.Size = new System.Drawing.Size(72, 22);
            this.ForwardHeightTextBox.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Image = null;
            this.label13.Text = "Back Margin To Left";
            this.label13.Location = new System.Drawing.Point(48, 536);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 0;
            // 
            // BackMarginLeftTextBox
            // 
            this.BackMarginLeftTextBox.Text = "";
            this.BackMarginLeftTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.BackMarginLeftTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackMarginLeftTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BackMarginLeftTextBox.MaxLength = 3;
            this.BackMarginLeftTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BackMarginLeftTextBox.Location = new System.Drawing.Point(200, 536);
            this.BackMarginLeftTextBox.Name = "BackMarginLeftTextBox";
            this.BackMarginLeftTextBox.Size = new System.Drawing.Size(72, 22);
            this.BackMarginLeftTextBox.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Image = null;
            this.label14.Text = "Back Margin To Top";
            this.label14.Location = new System.Drawing.Point(48, 568);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 16);
            this.label14.TabIndex = 0;
            // 
            // BackMarginTopTextBox
            // 
            this.BackMarginTopTextBox.Text = "";
            this.BackMarginTopTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.BackMarginTopTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackMarginTopTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BackMarginTopTextBox.MaxLength = 3;
            this.BackMarginTopTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BackMarginTopTextBox.Location = new System.Drawing.Point(200, 568);
            this.BackMarginTopTextBox.Name = "BackMarginTopTextBox";
            this.BackMarginTopTextBox.Size = new System.Drawing.Size(72, 22);
            this.BackMarginTopTextBox.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Image = null;
            this.label15.Text = "Back Butotn Height";
            this.label15.Location = new System.Drawing.Point(48, 636);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 16);
            this.label15.TabIndex = 0;
            // 
            // BackWidthTextBox
            // 
            this.BackWidthTextBox.Text = "";
            this.BackWidthTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.BackWidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackWidthTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BackWidthTextBox.MaxLength = 3;
            this.BackWidthTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BackWidthTextBox.Location = new System.Drawing.Point(200, 602);
            this.BackWidthTextBox.Name = "BackWidthTextBox";
            this.BackWidthTextBox.Size = new System.Drawing.Size(72, 22);
            this.BackWidthTextBox.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Image = null;
            this.label16.Text = "Back Butotn width";
            this.label16.Location = new System.Drawing.Point(48, 604);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 16);
            this.label16.TabIndex = 0;
            // 
            // BackHeightTextBox
            // 
            this.BackHeightTextBox.Text = "";
            this.BackHeightTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.BackHeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackHeightTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BackHeightTextBox.MaxLength = 3;
            this.BackHeightTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BackHeightTextBox.Location = new System.Drawing.Point(200, 636);
            this.BackHeightTextBox.Name = "BackHeightTextBox";
            this.BackHeightTextBox.Size = new System.Drawing.Size(72, 22);
            this.BackHeightTextBox.TabIndex = 1;
            // 
            // SettingsEditForm
            // 
            this.ClientSize = new System.Drawing.Size(373, 707);
            this.Text = "SettingsEditForm";
            this.Location = new System.Drawing.Point(-64, 16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MarginToTopTextBox);
            this.Controls.Add(this.MarginToLeftTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.WhiteCellColorBtn);
            this.Controls.Add(this.BlackCellColorBtn);
            this.Controls.Add(this.MoveOptionColorBtn);
            this.Controls.Add(this.EatOptionColorBtn);
            this.Controls.Add(this.HighlightedCellColorBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PiesSizeTextBox);
            this.Controls.Add(this.ForwardMarginLeftTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ForwardMarginTopTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ForwardWidthTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ForwardHeightTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BackMarginLeftTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BackMarginTopTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BackWidthTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BackHeightTextBox);
            this.Name = "SettingsEditForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IgnoreNotNumeric);
        }
        
        #endregion
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MarginToTopTextBox;
        private System.Windows.Forms.TextBox MarginToLeftTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button WhiteCellColorBtn;
        private System.Windows.Forms.Button BlackCellColorBtn;
        private System.Windows.Forms.Button MoveOptionColorBtn;
        private System.Windows.Forms.Button EatOptionColorBtn;
        private System.Windows.Forms.Button HighlightedCellColorBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PiesSizeTextBox;
        private System.Windows.Forms.TextBox ForwardMarginLeftTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ForwardMarginTopTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ForwardWidthTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ForwardHeightTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox BackMarginLeftTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox BackMarginTopTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox BackWidthTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox BackHeightTextBox;
    }

}
