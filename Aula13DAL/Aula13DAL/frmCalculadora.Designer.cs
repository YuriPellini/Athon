namespace Aula13DAL
{
    partial class frmCalculadora
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
            this.rbtnSoma = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnSub = new System.Windows.Forms.RadioButton();
            this.rbtnMult = new System.Windows.Forms.RadioButton();
            this.rbtnDiv = new System.Windows.Forms.RadioButton();
            this.rbtnResto = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro Número:";
            // 
            // rbtnSoma
            // 
            this.rbtnSoma.AutoSize = true;
            this.rbtnSoma.Checked = true;
            this.rbtnSoma.Location = new System.Drawing.Point(290, 85);
            this.rbtnSoma.Name = "rbtnSoma";
            this.rbtnSoma.Size = new System.Drawing.Size(67, 17);
            this.rbtnSoma.TabIndex = 1;
            this.rbtnSoma.TabStop = true;
            this.rbtnSoma.Text = "Soma (+)";
            this.rbtnSoma.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Segundo Número:";
            // 
            // rbtnSub
            // 
            this.rbtnSub.AutoSize = true;
            this.rbtnSub.Location = new System.Drawing.Point(290, 108);
            this.rbtnSub.Name = "rbtnSub";
            this.rbtnSub.Size = new System.Drawing.Size(88, 17);
            this.rbtnSub.TabIndex = 3;
            this.rbtnSub.TabStop = true;
            this.rbtnSub.Text = "Subitração (-)";
            this.rbtnSub.UseVisualStyleBackColor = true;
            // 
            // rbtnMult
            // 
            this.rbtnMult.AutoSize = true;
            this.rbtnMult.Location = new System.Drawing.Point(290, 131);
            this.rbtnMult.Name = "rbtnMult";
            this.rbtnMult.Size = new System.Drawing.Size(100, 17);
            this.rbtnMult.TabIndex = 4;
            this.rbtnMult.TabStop = true;
            this.rbtnMult.Text = "Multiplicação (*)";
            this.rbtnMult.UseVisualStyleBackColor = true;
            // 
            // rbtnDiv
            // 
            this.rbtnDiv.AutoSize = true;
            this.rbtnDiv.Location = new System.Drawing.Point(290, 154);
            this.rbtnDiv.Name = "rbtnDiv";
            this.rbtnDiv.Size = new System.Drawing.Size(74, 17);
            this.rbtnDiv.TabIndex = 5;
            this.rbtnDiv.TabStop = true;
            this.rbtnDiv.Text = "Divisão (/)";
            this.rbtnDiv.UseVisualStyleBackColor = true;
            // 
            // rbtnResto
            // 
            this.rbtnResto.AutoSize = true;
            this.rbtnResto.Location = new System.Drawing.Point(290, 177);
            this.rbtnResto.Name = "rbtnResto";
            this.rbtnResto.Size = new System.Drawing.Size(70, 17);
            this.rbtnResto.TabIndex = 6;
            this.rbtnResto.TabStop = true;
            this.rbtnResto.Text = "Resto (%)";
            this.rbtnResto.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(159, 154);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calacular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(184, 86);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 8;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(184, 112);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 9;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 280);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rbtnResto);
            this.Controls.Add(this.rbtnDiv);
            this.Controls.Add(this.rbtnMult);
            this.Controls.Add(this.rbtnSub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnSoma);
            this.Controls.Add(this.label1);
            this.Name = "frmCalculadora";
            this.Text = "frmCalculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnSoma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnSub;
        private System.Windows.Forms.RadioButton rbtnMult;
        private System.Windows.Forms.RadioButton rbtnDiv;
        private System.Windows.Forms.RadioButton rbtnResto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
    }
}