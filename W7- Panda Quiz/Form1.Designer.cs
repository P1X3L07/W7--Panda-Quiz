
namespace W7__Panda_Quiz
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.txtBoxInputChar = new System.Windows.Forms.TextBox();
            this.txtBoxOutputChar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(226, 180);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(314, 35);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Konversi";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(74, 56);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(138, 20);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "Masukan Kalimat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Masukan Huruf :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Menjadi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hasil :";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(349, 243);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(21, 20);
            this.labelOutput.TabIndex = 5;
            this.labelOutput.Text = "...";
            this.labelOutput.Click += new System.EventHandler(this.labelOutput_Click);
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(226, 56);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(314, 26);
            this.txtBoxInput.TabIndex = 6;
            this.txtBoxInput.TextChanged += new System.EventHandler(this.txtBoxInput_TextChanged);
            // 
            // txtBoxInputChar
            // 
            this.txtBoxInputChar.Location = new System.Drawing.Point(226, 114);
            this.txtBoxInputChar.Name = "txtBoxInputChar";
            this.txtBoxInputChar.Size = new System.Drawing.Size(100, 26);
            this.txtBoxInputChar.TabIndex = 7;
            this.txtBoxInputChar.TextChanged += new System.EventHandler(this.txtBoxInputChar_TextChanged);
            // 
            // txtBoxOutputChar
            // 
            this.txtBoxOutputChar.Location = new System.Drawing.Point(440, 114);
            this.txtBoxOutputChar.Name = "txtBoxOutputChar";
            this.txtBoxOutputChar.Size = new System.Drawing.Size(100, 26);
            this.txtBoxOutputChar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxOutputChar);
            this.Controls.Add(this.txtBoxInputChar);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.btnConvert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.TextBox txtBoxInputChar;
        private System.Windows.Forms.TextBox txtBoxOutputChar;
    }
}

