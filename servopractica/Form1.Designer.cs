namespace servopractica
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
            this.components = new System.ComponentModel.Container();
            this.btnConectar_click = new System.Windows.Forms.Button();
            this.ArduinoPort = new System.IO.Ports.SerialPort(this.components);
            this.btnDesconetar_Clik = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lbConection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConectar_click
            // 
            this.btnConectar_click.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConectar_click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar_click.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar_click.Location = new System.Drawing.Point(155, 209);
            this.btnConectar_click.Name = "btnConectar_click";
            this.btnConectar_click.Size = new System.Drawing.Size(120, 23);
            this.btnConectar_click.TabIndex = 0;
            this.btnConectar_click.Text = "CONECTAR";
            this.btnConectar_click.UseVisualStyleBackColor = true;
            // 
            // ArduinoPort
            // 
            this.ArduinoPort.PortName = "COM8";
            // 
            // btnDesconetar_Clik
            // 
            this.btnDesconetar_Clik.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconetar_Clik.Location = new System.Drawing.Point(12, 209);
            this.btnDesconetar_Clik.Name = "btnDesconetar_Clik";
            this.btnDesconetar_Clik.Size = new System.Drawing.Size(117, 23);
            this.btnDesconetar_Clik.TabIndex = 1;
            this.btnDesconetar_Clik.Text = "DESCONECTAR";
            this.btnDesconetar_Clik.UseVisualStyleBackColor = true;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(107, 60);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(140, 22);
            this.txtTemp.TabIndex = 2;
            this.txtTemp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbConection
            // 
            this.lbConection.AutoSize = true;
            this.lbConection.BackColor = System.Drawing.Color.SlateGray;
            this.lbConection.Location = new System.Drawing.Point(62, 68);
            this.lbConection.Name = "lbConection";
            this.lbConection.Size = new System.Drawing.Size(0, 16);
            this.lbConection.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Temperatura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(356, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbConection);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.btnDesconetar_Clik);
            this.Controls.Add(this.btnConectar_click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar_click;
        private System.IO.Ports.SerialPort ArduinoPort;
        private System.Windows.Forms.Button btnDesconetar_Clik;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lbConection;
        private System.Windows.Forms.Label label1;
    }
}

