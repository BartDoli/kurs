namespace CourseFormApp
{
    partial class CourseFormApp
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
            this.Start = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.Button();
            this.EnterHeight = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XNumber = new System.Windows.Forms.Label();
            this.YNumber = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.AddRadioButton = new System.Windows.Forms.RadioButton();
            this.SubstractRadioButton = new System.Windows.Forms.RadioButton();
            this.MultiplyRadioButton = new System.Windows.Forms.RadioButton();
            this.DivideRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.LogsTextBox = new System.Windows.Forms.TextBox();
            this.LogsText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.SandyBrown;
            this.Start.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Start.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Start.Location = new System.Drawing.Point(20, 20);
            this.Start.Margin = new System.Windows.Forms.Padding(5);
            this.Start.MaximumSize = new System.Drawing.Size(130, 65);
            this.Start.MinimumSize = new System.Drawing.Size(110, 55);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(110, 55);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.SandyBrown;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestartButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RestartButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.RestartButton.Location = new System.Drawing.Point(538, 381);
            this.RestartButton.MaximumSize = new System.Drawing.Size(130, 65);
            this.RestartButton.MinimumSize = new System.Drawing.Size(110, 55);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(120, 55);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ExitButton.Location = new System.Drawing.Point(666, 381);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExitButton.MaximumSize = new System.Drawing.Size(130, 65);
            this.ExitButton.MinimumSize = new System.Drawing.Size(110, 55);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(120, 55);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Shutdown
            // 
            this.Shutdown.BackColor = System.Drawing.Color.SandyBrown;
            this.Shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Shutdown.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Shutdown.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Shutdown.Location = new System.Drawing.Point(666, 316);
            this.Shutdown.Margin = new System.Windows.Forms.Padding(5);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(120, 55);
            this.Shutdown.TabIndex = 3;
            this.Shutdown.Text = "Shutdown";
            this.Shutdown.UseVisualStyleBackColor = false;
            this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // EnterHeight
            // 
            this.EnterHeight.AutoSize = true;
            this.EnterHeight.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterHeight.ForeColor = System.Drawing.Color.SaddleBrown;
            this.EnterHeight.Location = new System.Drawing.Point(444, 60);
            this.EnterHeight.Name = "EnterHeight";
            this.EnterHeight.Size = new System.Drawing.Size(198, 20);
            this.EnterHeight.TabIndex = 4;
            this.EnterHeight.Text = "Enter your height :";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(648, 60);
            this.HeightTextBox.MaxLength = 3;
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 23);
            this.HeightTextBox.TabIndex = 5;
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(20, 165);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(100, 23);
            this.XTextBox.TabIndex = 6;
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(20, 223);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(100, 23);
            this.YTextBox.TabIndex = 7;
            // 
            // XNumber
            // 
            this.XNumber.AutoSize = true;
            this.XNumber.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.XNumber.ForeColor = System.Drawing.Color.SaddleBrown;
            this.XNumber.Location = new System.Drawing.Point(20, 142);
            this.XNumber.Name = "XNumber";
            this.XNumber.Size = new System.Drawing.Size(100, 20);
            this.XNumber.TabIndex = 8;
            this.XNumber.Text = "X number";
            // 
            // YNumber
            // 
            this.YNumber.AutoSize = true;
            this.YNumber.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YNumber.ForeColor = System.Drawing.Color.SaddleBrown;
            this.YNumber.Location = new System.Drawing.Point(20, 200);
            this.YNumber.Name = "YNumber";
            this.YNumber.Size = new System.Drawing.Size(100, 20);
            this.YNumber.TabIndex = 9;
            this.YNumber.Text = "Y number";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.SandyBrown;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalculateButton.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CalculateButton.Location = new System.Drawing.Point(20, 378);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(5);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 27);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(20, 413);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(100, 23);
            this.ResultTextBox.TabIndex = 11;
            // 
            // AddRadioButton
            // 
            this.AddRadioButton.AutoSize = true;
            this.AddRadioButton.Checked = true;
            this.AddRadioButton.Location = new System.Drawing.Point(20, 252);
            this.AddRadioButton.Name = "AddRadioButton";
            this.AddRadioButton.Size = new System.Drawing.Size(47, 19);
            this.AddRadioButton.TabIndex = 12;
            this.AddRadioButton.TabStop = true;
            this.AddRadioButton.Text = "Add";
            this.AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubstractRadioButton
            // 
            this.SubstractRadioButton.AutoSize = true;
            this.SubstractRadioButton.Location = new System.Drawing.Point(20, 277);
            this.SubstractRadioButton.Name = "SubstractRadioButton";
            this.SubstractRadioButton.Size = new System.Drawing.Size(74, 19);
            this.SubstractRadioButton.TabIndex = 13;
            this.SubstractRadioButton.Text = "Substract";
            this.SubstractRadioButton.UseVisualStyleBackColor = true;
            // 
            // MultiplyRadioButton
            // 
            this.MultiplyRadioButton.AutoSize = true;
            this.MultiplyRadioButton.Location = new System.Drawing.Point(20, 302);
            this.MultiplyRadioButton.Name = "MultiplyRadioButton";
            this.MultiplyRadioButton.Size = new System.Drawing.Size(69, 19);
            this.MultiplyRadioButton.TabIndex = 14;
            this.MultiplyRadioButton.Text = "Multiply";
            this.MultiplyRadioButton.UseVisualStyleBackColor = true;
            // 
            // DivideRadioButton
            // 
            this.DivideRadioButton.AutoSize = true;
            this.DivideRadioButton.Location = new System.Drawing.Point(20, 327);
            this.DivideRadioButton.Name = "DivideRadioButton";
            this.DivideRadioButton.Size = new System.Drawing.Size(58, 19);
            this.DivideRadioButton.TabIndex = 15;
            this.DivideRadioButton.Text = "Divide";
            this.DivideRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(138, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // LogsTextBox
            // 
            this.LogsTextBox.Location = new System.Drawing.Point(128, 223);
            this.LogsTextBox.Multiline = true;
            this.LogsTextBox.Name = "LogsTextBox";
            this.LogsTextBox.ReadOnly = true;
            this.LogsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogsTextBox.Size = new System.Drawing.Size(392, 213);
            this.LogsTextBox.TabIndex = 18;
            // 
            // LogsText
            // 
            this.LogsText.AutoSize = true;
            this.LogsText.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogsText.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LogsText.Location = new System.Drawing.Point(128, 200);
            this.LogsText.Name = "LogsText";
            this.LogsText.Size = new System.Drawing.Size(63, 20);
            this.LogsText.TabIndex = 19;
            this.LogsText.Text = "Logs :";
            // 
            // CourseFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogsText);
            this.Controls.Add(this.LogsTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DivideRadioButton);
            this.Controls.Add(this.MultiplyRadioButton);
            this.Controls.Add(this.SubstractRadioButton);
            this.Controls.Add(this.AddRadioButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.YNumber);
            this.Controls.Add(this.XNumber);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.EnterHeight);
            this.Controls.Add(this.Shutdown);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.Start);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "CourseFormApp";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Start;
        private Button RestartButton;
        private Button ExitButton;
        private Button Shutdown;
        private Label EnterHeight;
        private TextBox HeightTextBox;
        private TextBox XTextBox;
        private TextBox YTextBox;
        private Label XNumber;
        private Label YNumber;
        private Button CalculateButton;
        private TextBox ResultTextBox;
        private RadioButton AddRadioButton;
        private RadioButton SubstractRadioButton;
        private RadioButton MultiplyRadioButton;
        private RadioButton DivideRadioButton;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox LogsTextBox;
        private Label LogsText;
    }
}