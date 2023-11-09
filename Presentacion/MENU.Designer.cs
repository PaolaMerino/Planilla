namespace Presentacion
{
    partial class MENU
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
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnISR = new System.Windows.Forms.Button();
            this.btnRDLEY = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(34, 70);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(115, 31);
            this.btnEmpleado.TabIndex = 120;
            this.btnEmpleado.Text = "EMPLEADOS";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnISR
            // 
            this.btnISR.Location = new System.Drawing.Point(153, 70);
            this.btnISR.Margin = new System.Windows.Forms.Padding(2);
            this.btnISR.Name = "btnISR";
            this.btnISR.Size = new System.Drawing.Size(124, 31);
            this.btnISR.TabIndex = 121;
            this.btnISR.Text = "RENTA";
            this.btnISR.UseVisualStyleBackColor = true;
            this.btnISR.Click += new System.EventHandler(this.btnISR_Click);
            // 
            // btnRDLEY
            // 
            this.btnRDLEY.Location = new System.Drawing.Point(34, 117);
            this.btnRDLEY.Margin = new System.Windows.Forms.Padding(2);
            this.btnRDLEY.Name = "btnRDLEY";
            this.btnRDLEY.Size = new System.Drawing.Size(152, 31);
            this.btnRDLEY.TabIndex = 122;
            this.btnRDLEY.Text = "RETENCIONES DE LEY";
            this.btnRDLEY.UseVisualStyleBackColor = true;
            this.btnRDLEY.Click += new System.EventHandler(this.btnRDLEY_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 117);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 31);
            this.button1.TabIndex = 123;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 191);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRDLEY);
            this.Controls.Add(this.btnISR);
            this.Controls.Add(this.btnEmpleado);
            this.Name = "MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnISR;
        private System.Windows.Forms.Button btnRDLEY;
        private System.Windows.Forms.Button button1;
    }
}