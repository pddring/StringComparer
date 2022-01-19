namespace StringComparer
{
    partial class StringComparer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStringX = new System.Windows.Forms.TextBox();
            this.txtStringY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "String Comparer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "String X";
            // 
            // txtStringX
            // 
            this.txtStringX.Location = new System.Drawing.Point(170, 91);
            this.txtStringX.Name = "txtStringX";
            this.txtStringX.Size = new System.Drawing.Size(536, 20);
            this.txtStringX.TabIndex = 2;
            // 
            // txtStringY
            // 
            this.txtStringY.Location = new System.Drawing.Point(170, 129);
            this.txtStringY.Name = "txtStringY";
            this.txtStringY.Size = new System.Drawing.Size(536, 20);
            this.txtStringY.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "String Y";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(332, 164);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(145, 31);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(66, 223);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(489, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Enter two strings and press calculate to see the longest substring which is share" +
    "d between both strings";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(643, 407);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(145, 31);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // StringComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtStringY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStringX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StringComparer";
            this.Text = "String Comparer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStringX;
        private System.Windows.Forms.TextBox txtStringY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnHelp;
    }
}

