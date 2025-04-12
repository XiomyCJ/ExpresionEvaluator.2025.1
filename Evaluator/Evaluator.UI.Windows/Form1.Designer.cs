﻿namespace Evaluator.UI.Windows
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnOpenParenthesis = new Button();
            btnCloseParenthesis = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnResult = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnPow = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.FromArgb(0, 192, 0);
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(420, 23);
            txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(1, 54);
            btn7.Name = "btn7";
            btn7.Size = new Size(67, 41);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(74, 54);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 41);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(147, 54);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 41);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.Yellow;
            btnDivide.Font = new Font("Segoe UI", 15.75F);
            btnDivide.Location = new Point(220, 54);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(67, 41);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.Yellow;
            btnMultiply.Font = new Font("Segoe UI", 15.75F);
            btnMultiply.Location = new Point(300, 54);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(67, 41);
            btnMultiply.TabIndex = 5;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(1, 101);
            btn4.Name = "btn4";
            btn4.Size = new Size(67, 41);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(74, 101);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 41);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(147, 101);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 41);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Yellow;
            btnPlus.Font = new Font("Segoe UI", 15.75F);
            btnPlus.Location = new Point(220, 101);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(67, 41);
            btnPlus.TabIndex = 9;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Yellow;
            btnMinus.Font = new Font("Segoe UI", 15.75F);
            btnMinus.Location = new Point(300, 101);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(67, 41);
            btnMinus.TabIndex = 10;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(1, 148);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 41);
            btn1.TabIndex = 11;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(74, 148);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 41);
            btn2.TabIndex = 12;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(147, 148);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 41);
            btn3.TabIndex = 13;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.Yellow;
            btnOpenParenthesis.Font = new Font("Segoe UI", 15.75F);
            btnOpenParenthesis.Location = new Point(220, 148);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(67, 41);
            btnOpenParenthesis.TabIndex = 14;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.Yellow;
            btnCloseParenthesis.Font = new Font("Segoe UI", 15.75F);
            btnCloseParenthesis.Location = new Point(300, 148);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(67, 41);
            btnCloseParenthesis.TabIndex = 15;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(1, 195);
            btn0.Name = "btn0";
            btn0.Size = new Size(140, 41);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(147, 195);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(67, 41);
            btnDot.TabIndex = 17;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnPow_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.Yellow;
            btnResult.Font = new Font("Segoe UI", 15.75F);
            btnResult.Location = new Point(220, 195);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(220, 41);
            btnResult.TabIndex = 18;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Yellow;
            btnDelete.Font = new Font("Segoe UI", 15.75F);
            btnDelete.Location = new Point(373, 54);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(67, 41);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Font = new Font("Segoe UI", 15.75F);
            btnClear.Location = new Point(373, 101);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(67, 41);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.Yellow;
            btnPow.Font = new Font("Segoe UI", 15.75F);
            btnPow.Location = new Point(373, 148);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(67, 41);
            btnPow.TabIndex = 21;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(444, 250);
            Controls.Add(btnPow);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnResult);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnPlus;
        private Button btnMinus;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnOpenParenthesis;
        private Button btnCloseParenthesis;
        private Button btn0;
        private Button btnDot;
        private Button btnResult;
        private Button btnDelete;
        private Button btnClear;
        private Button btnPow;
    }
}
