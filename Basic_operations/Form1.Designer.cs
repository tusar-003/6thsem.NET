using System;
using System.Windows.Forms;

namespace Basic_operations
{
    public partial class Form1 : Form
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
            this.box1 = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.divition = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(197, 47);
            this.box1.Multiline = true;
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(110, 30);
            this.box1.TabIndex = 2;
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(197, 115);
            this.box2.Multiline = true;
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(110, 30);
            this.box2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AmazonEmber-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AmazonEmber-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input2";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("AmazonEmber-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(96, 204);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(52, 17);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "Output";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(197, 197);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(110, 31);
            this.answer.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("AmazonEmber-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(626, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Addition";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Add_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.Highlight;
            this.sub.Font = new System.Drawing.Font("AmazonEmber-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.ForeColor = System.Drawing.SystemColors.Control;
            this.sub.Location = new System.Drawing.Point(626, 110);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(113, 30);
            this.sub.TabIndex = 10;
            this.sub.Text = "Subtraction";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.SystemColors.Highlight;
            this.multiplication.Font = new System.Drawing.Font("AmazonEmber-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication.ForeColor = System.Drawing.SystemColors.Control;
            this.multiplication.Location = new System.Drawing.Point(626, 164);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(113, 30);
            this.multiplication.TabIndex = 11;
            this.multiplication.Text = "Multiplication";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // divition
            // 
            this.divition.BackColor = System.Drawing.SystemColors.Highlight;
            this.divition.Font = new System.Drawing.Font("AmazonEmber-Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divition.ForeColor = System.Drawing.SystemColors.Control;
            this.divition.Location = new System.Drawing.Point(626, 219);
            this.divition.Name = "divition";
            this.divition.Size = new System.Drawing.Size(113, 30);
            this.divition.TabIndex = 12;
            this.divition.Text = "Division";
            this.divition.UseVisualStyleBackColor = false;
            this.divition.Click += new System.EventHandler(this.divition_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button6.Location = new System.Drawing.Point(222, 314);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 35);
            this.button6.TabIndex = 13;
            this.button6.Text = "CLEAR";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button7.Location = new System.Drawing.Point(543, 313);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 36);
            this.button7.TabIndex = 14;
            this.button7.Text = "EXIT";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.divition);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Name = "Form1";
            this.Text = "Arithmetic Operations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox box1;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button divition;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}
