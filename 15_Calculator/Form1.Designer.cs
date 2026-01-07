
namespace WindowsFormsApp1
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
            this.opBox1 = new System.Windows.Forms.TextBox();
            this.opBox = new System.Windows.Forms.TextBox();
            this.opBox2 = new System.Windows.Forms.TextBox();
            this.resBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Calcbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opBox1
            // 
            this.opBox1.Location = new System.Drawing.Point(152, 234);
            this.opBox1.Name = "opBox1";
            this.opBox1.Size = new System.Drawing.Size(54, 20);
            this.opBox1.TabIndex = 0;
            // 
            // opBox
            // 
            this.opBox.Location = new System.Drawing.Point(232, 234);
            this.opBox.Name = "opBox";
            this.opBox.Size = new System.Drawing.Size(54, 20);
            this.opBox.TabIndex = 1;
            // 
            // opBox2
            // 
            this.opBox2.Location = new System.Drawing.Point(308, 234);
            this.opBox2.Name = "opBox2";
            this.opBox2.Size = new System.Drawing.Size(54, 20);
            this.opBox2.TabIndex = 2;
            // 
            // resBox
            // 
            this.resBox.Location = new System.Drawing.Point(436, 234);
            this.resBox.Name = "resBox";
            this.resBox.ReadOnly = true;
            this.resBox.Size = new System.Drawing.Size(54, 20);
            this.resBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Op1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Operator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Op2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Result";
            // 
            // Calcbtn
            // 
            this.Calcbtn.Location = new System.Drawing.Point(319, 328);
            this.Calcbtn.Name = "Calcbtn";
            this.Calcbtn.Size = new System.Drawing.Size(75, 23);
            this.Calcbtn.TabIndex = 9;
            this.Calcbtn.Text = "Calculate";
            this.Calcbtn.UseVisualStyleBackColor = true;
            this.Calcbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calcbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.opBox2);
            this.Controls.Add(this.opBox);
            this.Controls.Add(this.opBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox opBox1;
        private System.Windows.Forms.TextBox opBox;
        private System.Windows.Forms.TextBox opBox2;
        private System.Windows.Forms.TextBox resBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Calcbtn;
    }
}

