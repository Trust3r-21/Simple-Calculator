namespace Simple_Calculator
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
            this.Seven = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.RichTextBox();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(12, 66);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(54, 56);
            this.Seven.TabIndex = 0;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(235, 48);
            this.Display.TabIndex = 1;
            this.Display.Text = "";
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(72, 66);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(54, 56);
            this.Eight.TabIndex = 2;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(132, 66);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(54, 56);
            this.Nine.TabIndex = 3;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(193, 66);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(54, 56);
            this.Plus.TabIndex = 4;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(12, 128);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(54, 56);
            this.Four.TabIndex = 5;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(72, 128);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(54, 56);
            this.Five.TabIndex = 6;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(132, 128);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(54, 56);
            this.Six.TabIndex = 7;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(192, 128);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(54, 56);
            this.Minus.TabIndex = 8;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.One.Location = new System.Drawing.Point(12, 190);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(54, 56);
            this.One.TabIndex = 9;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(72, 190);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(54, 56);
            this.Two.TabIndex = 10;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(132, 190);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(54, 56);
            this.Three.TabIndex = 11;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(193, 190);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(54, 56);
            this.Multiply.TabIndex = 12;
            this.Multiply.Text = "X";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Dot
            // 
            this.Dot.Location = new System.Drawing.Point(12, 252);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(54, 56);
            this.Dot.TabIndex = 13;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(72, 252);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(54, 56);
            this.Zero.TabIndex = 14;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Equals
            // 
            this.Equals.Location = new System.Drawing.Point(132, 252);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(54, 56);
            this.Equals.TabIndex = 15;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Division.Location = new System.Drawing.Point(193, 252);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(54, 56);
            this.Division.TabIndex = 16;
            this.Division.Text = "÷";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(101, 314);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(54, 56);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 367);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Seven);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Seven;
        private RichTextBox Display;
        private Button Eight;
        private Button Nine;
        private Button Plus;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button Minus;
        private Button One;
        private Button Two;
        private Button Three;
        private Button Multiply;
        private Button Dot;
        private Button Zero;
        private Button Equals;
        private Button Division;
        private Button Clear;
    }
}