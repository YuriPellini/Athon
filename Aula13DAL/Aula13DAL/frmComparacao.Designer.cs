namespace Aula13DAL
{
    partial class frmComparacao
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
            this.nupNum1 = new System.Windows.Forms.NumericUpDown();
            this.nupNum2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNum2)).BeginInit();
            this.SuspendLayout();
            // 
            // nupNum1
            // 
            this.nupNum1.Location = new System.Drawing.Point(203, 92);
            this.nupNum1.Name = "nupNum1";
            this.nupNum1.Size = new System.Drawing.Size(120, 20);
            this.nupNum1.TabIndex = 0;
            // 
            // nupNum2
            // 
            this.nupNum2.Location = new System.Drawing.Point(203, 118);
            this.nupNum2.Name = "nupNum2";
            this.nupNum2.Size = new System.Drawing.Size(120, 20);
            this.nupNum2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primeiro Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segundo Número:";
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(203, 144);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 4;
            this.btnRes.Text = "Confirmar";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // frmComparacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 275);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupNum2);
            this.Controls.Add(this.nupNum1);
            this.Name = "frmComparacao";
            this.Text = "Comparação";
            ((System.ComponentModel.ISupportInitialize)(this.nupNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNum2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupNum1;
        private System.Windows.Forms.NumericUpDown nupNum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRes;
    }
}