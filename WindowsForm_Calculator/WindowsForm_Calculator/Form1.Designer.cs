namespace WindowsForm_Calculator
{
    partial class Form1
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
            Current_numstring = new TextBox();
            button_plusminus = new Button();
            num_0 = new Button();
            button_comma = new Button();
            num_3 = new Button();
            num_2 = new Button();
            num_1 = new Button();
            num_6 = new Button();
            num_5 = new Button();
            num_4 = new Button();
            num_9 = new Button();
            num_8 = new Button();
            num_7 = new Button();
            button_multiply = new Button();
            button_minus = new Button();
            button_plus = new Button();
            button16 = new Button();
            button_division = new Button();
            button_clear = new Button();
            button_clearentry = new Button();
            button_Backspace = new Button();
            button_sqrt = new Button();
            button_squaring = new Button();
            button_procent = new Button();
            temp_numstring = new TextBox();
            SuspendLayout();
            // 
            // Current_numstring
            // 
            Current_numstring.BackColor = Color.FromArgb(32, 32, 32);
            Current_numstring.BorderStyle = BorderStyle.None;
            Current_numstring.Font = new Font("Segoe UI Semibold", 27F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Current_numstring.ForeColor = SystemColors.Window;
            Current_numstring.Location = new Point(7, 116);
            Current_numstring.Margin = new Padding(3, 0, 3, 10);
            Current_numstring.MaximumSize = new Size(312, 48);
            Current_numstring.MaxLength = 14;
            Current_numstring.MinimumSize = new Size(312, 48);
            Current_numstring.Name = "Current_numstring";
            Current_numstring.ReadOnly = true;
            Current_numstring.Size = new Size(312, 48);
            Current_numstring.TabIndex = 11;
            Current_numstring.Text = "0";
            Current_numstring.TextAlign = HorizontalAlignment.Right;
            // 
            // button_plusminus
            // 
            button_plusminus.BackColor = Color.FromArgb(59, 59, 59);
            button_plusminus.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            button_plusminus.FlatStyle = FlatStyle.Flat;
            button_plusminus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_plusminus.ForeColor = Color.White;
            button_plusminus.Location = new Point(7, 421);
            button_plusminus.Margin = new Padding(2);
            button_plusminus.Name = "button_plusminus";
            button_plusminus.Size = new Size(75, 45);
            button_plusminus.TabIndex = 0;
            button_plusminus.Text = "±";
            button_plusminus.UseVisualStyleBackColor = false;
            button_plusminus.Click += operation;
            // 
            // num_0
            // 
            num_0.BackColor = Color.FromArgb(59, 59, 59);
            num_0.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            num_0.FlatStyle = FlatStyle.Flat;
            num_0.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            num_0.ForeColor = Color.White;
            num_0.Location = new Point(86, 421);
            num_0.Margin = new Padding(2);
            num_0.Name = "num_0";
            num_0.Size = new Size(75, 45);
            num_0.TabIndex = 1;
            num_0.Text = "0";
            num_0.UseVisualStyleBackColor = false;
            num_0.Click += num_Click;
            // 
            // button_comma
            // 
            button_comma.BackColor = Color.FromArgb(59, 59, 59);
            button_comma.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            button_comma.FlatStyle = FlatStyle.Flat;
            button_comma.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_comma.ForeColor = Color.White;
            button_comma.Location = new Point(165, 421);
            button_comma.Margin = new Padding(2);
            button_comma.Name = "button_comma";
            button_comma.Size = new Size(75, 45);
            button_comma.TabIndex = 2;
            button_comma.Text = ",";
            button_comma.UseVisualStyleBackColor = false;
            button_comma.Click += num_Click;
            // 
            // num_3
            // 
            num_3.BackColor = Color.FromArgb(59, 59, 59);
            num_3.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            num_3.FlatStyle = FlatStyle.Flat;
            num_3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            num_3.ForeColor = Color.White;
            num_3.Location = new Point(165, 372);
            num_3.Margin = new Padding(2);
            num_3.Name = "num_3";
            num_3.Size = new Size(75, 45);
            num_3.TabIndex = 5;
            num_3.Text = "3";
            num_3.UseVisualStyleBackColor = false;
            num_3.Click += num_Click;
            // 
            // num_2
            // 
            num_2.BackColor = Color.FromArgb(59, 59, 59);
            num_2.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            num_2.FlatStyle = FlatStyle.Flat;
            num_2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            num_2.ForeColor = Color.White;
            num_2.Location = new Point(86, 372);
            num_2.Margin = new Padding(2);
            num_2.Name = "num_2";
            num_2.Size = new Size(75, 45);
            num_2.TabIndex = 4;
            num_2.Text = "2";
            num_2.UseVisualStyleBackColor = false;
            num_2.Click += num_Click;
            // 
            // num_1
            // 
            num_1.BackColor = Color.FromArgb(59, 59, 59);
            num_1.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            num_1.FlatStyle = FlatStyle.Flat;
            num_1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            num_1.ForeColor = Color.White;
            num_1.Location = new Point(7, 372);
            num_1.Margin = new Padding(2);
            num_1.Name = "num_1";
            num_1.Size = new Size(75, 45);
            num_1.TabIndex = 3;
            num_1.Text = "1";
            num_1.UseVisualStyleBackColor = false;
            num_1.Click += num_Click;
            // 
            // num_6
            // 
            num_6.BackColor = Color.FromArgb(59, 59, 59);
            num_6.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            num_6.FlatStyle = FlatStyle.Flat;
            num_6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            num_6.ForeColor = Color.White;
            num_6.Location = new Point(165, 323);
            num_6.Margin = new Padding(2);
            num_6.Name = "num_6";
            num_6.Size = new Size(75, 45);
            num_6.TabIndex = 8;
            num_6.Text = "6";
            num_6.UseVisualStyleBackColor = false;
            num_6.Click += num_Click;
            // 
            // num_5
            // 
            num_5.BackColor = Color.FromArgb(59, 59, 59);
            num_5.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            num_5.FlatStyle = FlatStyle.Flat;
            num_5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            num_5.ForeColor = Color.White;
            num_5.Location = new Point(86, 323);
            num_5.Margin = new Padding(2);
            num_5.Name = "num_5";
            num_5.Size = new Size(75, 45);
            num_5.TabIndex = 7;
            num_5.Text = "5";
            num_5.UseVisualStyleBackColor = false;
            num_5.Click += num_Click;
            // 
            // num_4
            // 
            num_4.BackColor = Color.FromArgb(59, 59, 59);
            num_4.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            num_4.FlatStyle = FlatStyle.Flat;
            num_4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            num_4.ForeColor = Color.White;
            num_4.Location = new Point(7, 323);
            num_4.Margin = new Padding(2);
            num_4.Name = "num_4";
            num_4.Size = new Size(75, 45);
            num_4.TabIndex = 6;
            num_4.Text = "4";
            num_4.UseVisualStyleBackColor = false;
            num_4.Click += num_Click;
            // 
            // num_9
            // 
            num_9.BackColor = Color.FromArgb(59, 59, 59);
            num_9.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            num_9.FlatStyle = FlatStyle.Flat;
            num_9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            num_9.ForeColor = Color.White;
            num_9.Location = new Point(165, 274);
            num_9.Margin = new Padding(2);
            num_9.Name = "num_9";
            num_9.Size = new Size(75, 45);
            num_9.TabIndex = 11;
            num_9.Text = "9";
            num_9.UseVisualStyleBackColor = false;
            num_9.Click += num_Click;
            // 
            // num_8
            // 
            num_8.BackColor = Color.FromArgb(59, 59, 59);
            num_8.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            num_8.FlatStyle = FlatStyle.Flat;
            num_8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            num_8.ForeColor = Color.White;
            num_8.Location = new Point(86, 274);
            num_8.Margin = new Padding(2);
            num_8.Name = "num_8";
            num_8.Size = new Size(75, 45);
            num_8.TabIndex = 10;
            num_8.Text = "8";
            num_8.UseVisualStyleBackColor = false;
            num_8.Click += num_Click;
            // 
            // num_7
            // 
            num_7.BackColor = Color.FromArgb(59, 59, 59);
            num_7.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59);
            num_7.FlatStyle = FlatStyle.Flat;
            num_7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            num_7.ForeColor = Color.White;
            num_7.Location = new Point(7, 274);
            num_7.Margin = new Padding(2);
            num_7.Name = "num_7";
            num_7.Size = new Size(75, 45);
            num_7.TabIndex = 9;
            num_7.Text = "7";
            num_7.UseVisualStyleBackColor = false;
            num_7.Click += num_Click;
            // 
            // button_multiply
            // 
            button_multiply.BackColor = Color.FromArgb(50, 50, 50);
            button_multiply.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            button_multiply.FlatStyle = FlatStyle.Flat;
            button_multiply.Font = new Font("Lucida Sans Unicode", 14.25F);
            button_multiply.ForeColor = Color.White;
            button_multiply.Location = new Point(244, 225);
            button_multiply.Margin = new Padding(2);
            button_multiply.Name = "button_multiply";
            button_multiply.Size = new Size(75, 45);
            button_multiply.TabIndex = 15;
            button_multiply.Text = "×";
            button_multiply.UseVisualStyleBackColor = false;
            button_multiply.Click += operation;
            // 
            // button_minus
            // 
            button_minus.BackColor = Color.FromArgb(50, 50, 50);
            button_minus.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            button_minus.FlatStyle = FlatStyle.Flat;
            button_minus.Font = new Font("Lucida Sans Unicode", 14.25F);
            button_minus.ForeColor = Color.White;
            button_minus.Location = new Point(244, 274);
            button_minus.Margin = new Padding(2);
            button_minus.Name = "button_minus";
            button_minus.Size = new Size(75, 45);
            button_minus.TabIndex = 14;
            button_minus.Text = "-";
            button_minus.UseVisualStyleBackColor = false;
            button_minus.Click += operation;
            // 
            // button_plus
            // 
            button_plus.BackColor = Color.FromArgb(50, 50, 50);
            button_plus.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            button_plus.FlatStyle = FlatStyle.Flat;
            button_plus.Font = new Font("Lucida Sans Unicode", 14.25F);
            button_plus.ForeColor = Color.White;
            button_plus.Location = new Point(244, 323);
            button_plus.Margin = new Padding(2);
            button_plus.Name = "button_plus";
            button_plus.Size = new Size(75, 45);
            button_plus.TabIndex = 13;
            button_plus.Text = "+";
            button_plus.UseVisualStyleBackColor = false;
            button_plus.Click += operation;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(216, 216, 216);
            button16.FlatAppearance.BorderColor = Color.FromArgb(216, 216, 216);
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button16.ForeColor = Color.Black;
            button16.Location = new Point(244, 372);
            button16.Margin = new Padding(2);
            button16.Name = "button16";
            button16.Size = new Size(75, 94);
            button16.TabIndex = 12;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = false;
            button16.Click += equals_operation;
            // 
            // button_division
            // 
            button_division.BackColor = Color.FromArgb(50, 50, 50);
            button_division.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            button_division.FlatStyle = FlatStyle.Flat;
            button_division.Font = new Font("Lucida Sans Unicode", 14.25F);
            button_division.ForeColor = Color.White;
            button_division.Location = new Point(244, 176);
            button_division.Margin = new Padding(2);
            button_division.Name = "button_division";
            button_division.Size = new Size(75, 45);
            button_division.TabIndex = 19;
            button_division.Text = "÷";
            button_division.UseVisualStyleBackColor = false;
            button_division.Click += operation;
            // 
            // button_clear
            // 
            button_clear.BackColor = Color.FromArgb(50, 50, 50);
            button_clear.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(165, 176);
            button_clear.Margin = new Padding(2);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(75, 45);
            button_clear.TabIndex = 18;
            button_clear.Text = "C";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += string_clear;
            // 
            // button_clearentry
            // 
            button_clearentry.BackColor = Color.FromArgb(50, 50, 50);
            button_clearentry.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            button_clearentry.FlatStyle = FlatStyle.Flat;
            button_clearentry.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_clearentry.ForeColor = Color.White;
            button_clearentry.Location = new Point(86, 176);
            button_clearentry.Margin = new Padding(2);
            button_clearentry.Name = "button_clearentry";
            button_clearentry.Size = new Size(75, 45);
            button_clearentry.TabIndex = 17;
            button_clearentry.Text = "CE";
            button_clearentry.UseVisualStyleBackColor = false;
            button_clearentry.Click += string_clear;
            // 
            // button_Backspace
            // 
            button_Backspace.BackColor = Color.FromArgb(50, 50, 50);
            button_Backspace.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            button_Backspace.FlatStyle = FlatStyle.Flat;
            button_Backspace.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Backspace.ForeColor = Color.White;
            button_Backspace.Location = new Point(7, 176);
            button_Backspace.Margin = new Padding(2);
            button_Backspace.Name = "button_Backspace";
            button_Backspace.Size = new Size(75, 45);
            button_Backspace.TabIndex = 16;
            button_Backspace.Text = "⌫";
            button_Backspace.UseVisualStyleBackColor = false;
            button_Backspace.Click += string_clear;
            // 
            // button_sqrt
            // 
            button_sqrt.BackColor = Color.FromArgb(50, 50, 50);
            button_sqrt.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            button_sqrt.FlatStyle = FlatStyle.Flat;
            button_sqrt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_sqrt.ForeColor = Color.White;
            button_sqrt.Location = new Point(165, 225);
            button_sqrt.Margin = new Padding(2);
            button_sqrt.Name = "button_sqrt";
            button_sqrt.Size = new Size(75, 45);
            button_sqrt.TabIndex = 22;
            button_sqrt.Text = "√";
            button_sqrt.UseVisualStyleBackColor = false;
            button_sqrt.Click += operation;
            // 
            // button_squaring
            // 
            button_squaring.BackColor = Color.FromArgb(50, 50, 50);
            button_squaring.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            button_squaring.FlatStyle = FlatStyle.Flat;
            button_squaring.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_squaring.ForeColor = Color.White;
            button_squaring.Location = new Point(86, 225);
            button_squaring.Margin = new Padding(2);
            button_squaring.Name = "button_squaring";
            button_squaring.Size = new Size(75, 45);
            button_squaring.TabIndex = 21;
            button_squaring.Text = "x²";
            button_squaring.UseVisualStyleBackColor = false;
            button_squaring.Click += operation;
            // 
            // button_procent
            // 
            button_procent.BackColor = Color.FromArgb(50, 50, 50);
            button_procent.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50);
            button_procent.FlatStyle = FlatStyle.Flat;
            button_procent.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_procent.ForeColor = Color.White;
            button_procent.Location = new Point(7, 225);
            button_procent.Margin = new Padding(2);
            button_procent.Name = "button_procent";
            button_procent.Size = new Size(75, 45);
            button_procent.TabIndex = 20;
            button_procent.Text = "%";
            button_procent.UseVisualStyleBackColor = false;
            button_procent.Click += operation;
            // 
            // temp_numstring
            // 
            temp_numstring.BackColor = Color.FromArgb(32, 32, 32);
            temp_numstring.BorderStyle = BorderStyle.None;
            temp_numstring.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            temp_numstring.ForeColor = Color.FromArgb(147, 147, 147);
            temp_numstring.Location = new Point(7, 76);
            temp_numstring.Margin = new Padding(3, 5, 3, 0);
            temp_numstring.MaxLength = 16;
            temp_numstring.Name = "temp_numstring";
            temp_numstring.ReadOnly = true;
            temp_numstring.Size = new Size(312, 29);
            temp_numstring.TabIndex = 24;
            temp_numstring.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(326, 477);
            Controls.Add(temp_numstring);
            Controls.Add(Current_numstring);
            Controls.Add(button_sqrt);
            Controls.Add(button_squaring);
            Controls.Add(button_procent);
            Controls.Add(button_division);
            Controls.Add(button_clear);
            Controls.Add(button_clearentry);
            Controls.Add(button_Backspace);
            Controls.Add(button_multiply);
            Controls.Add(button_minus);
            Controls.Add(button_plus);
            Controls.Add(button16);
            Controls.Add(num_9);
            Controls.Add(num_8);
            Controls.Add(num_7);
            Controls.Add(num_6);
            Controls.Add(num_5);
            Controls.Add(num_4);
            Controls.Add(num_3);
            Controls.Add(num_2);
            Controls.Add(num_1);
            Controls.Add(button_comma);
            Controls.Add(num_0);
            Controls.Add(button_plusminus);
            MaximumSize = new Size(342, 516);
            MinimumSize = new Size(342, 516);
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_plusminus;
        private Button num_0;
        private Button button_comma;
        private Button num_3;
        private Button num_2;
        private Button num_1;
        private Button num_6;
        private Button num_5;
        private Button num_4;
        private Button num_9;
        private Button num_8;
        private Button num_7;
        private Button button_multiply;
        private Button button_minus;
        private Button button_plus;
        private Button button16;
        private Button button_division;
        private Button button_clear;
        private Button button_clearentry;
        private Button button_Backspace;
        private Button button_sqrt;
        private Button button_squaring;
        private Button button_procent;
        private TextBox Current_numstring;
        private TextBox temp_numstring;
    }
}
