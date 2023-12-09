namespace PigeonholeSort1._0
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSort_Click = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSort_Click
            // 
            this.btnSort_Click.Location = new System.Drawing.Point(242, 272);
            this.btnSort_Click.Name = "btnSort_Click";
            this.btnSort_Click.Size = new System.Drawing.Size(75, 23);
            this.btnSort_Click.TabIndex = 0;
            this.btnSort_Click.Text = "button1";
            this.btnSort_Click.UseVisualStyleBackColor = true;
            this.btnSort_Click.Click += new System.EventHandler(this.btnSort_Click_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(263, 229);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(218, 22);
            this.tbOutput.TabIndex = 1;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(263, 187);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(218, 22);
            this.tbInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "INGRESA LOS  NUMEROS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "NUMEROS ORDENADOS:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btnSort_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSort_Click;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

