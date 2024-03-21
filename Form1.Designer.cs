
namespace temperaturasNacional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_departamentos = new System.Windows.Forms.ComboBox();
            this.txt_temperatura = new System.Windows.Forms.TextBox();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.lbl_temperatura = new System.Windows.Forms.Label();
            this.button_registrarTemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_departamentos
            // 
            this.comboBox_departamentos.FormattingEnabled = true;
            this.comboBox_departamentos.Location = new System.Drawing.Point(124, 53);
            this.comboBox_departamentos.Name = "comboBox_departamentos";
            this.comboBox_departamentos.Size = new System.Drawing.Size(121, 21);
            this.comboBox_departamentos.TabIndex = 1;
            // 
            // txt_temperatura
            // 
            this.txt_temperatura.Location = new System.Drawing.Point(124, 100);
            this.txt_temperatura.Name = "txt_temperatura";
            this.txt_temperatura.Size = new System.Drawing.Size(121, 20);
            this.txt_temperatura.TabIndex = 2;
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Location = new System.Drawing.Point(39, 61);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(74, 13);
            this.lbl_departamento.TabIndex = 3;
            this.lbl_departamento.Text = "Departamento";
            // 
            // lbl_temperatura
            // 
            this.lbl_temperatura.AutoSize = true;
            this.lbl_temperatura.Location = new System.Drawing.Point(39, 107);
            this.lbl_temperatura.Name = "lbl_temperatura";
            this.lbl_temperatura.Size = new System.Drawing.Size(67, 13);
            this.lbl_temperatura.TabIndex = 4;
            this.lbl_temperatura.Text = "Temperatura";
            // 
            // button_registrarTemp
            // 
            this.button_registrarTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_registrarTemp.Location = new System.Drawing.Point(72, 139);
            this.button_registrarTemp.Name = "button_registrarTemp";
            this.button_registrarTemp.Size = new System.Drawing.Size(151, 26);
            this.button_registrarTemp.TabIndex = 5;
            this.button_registrarTemp.Text = "Registrar tempratura";
            this.button_registrarTemp.UseVisualStyleBackColor = true;
            this.button_registrarTemp.Click += new System.EventHandler(this.button_registrarTemp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_registrarTemp);
            this.Controls.Add(this.lbl_temperatura);
            this.Controls.Add(this.lbl_departamento);
            this.Controls.Add(this.txt_temperatura);
            this.Controls.Add(this.comboBox_departamentos);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_departamentos;
        private System.Windows.Forms.TextBox txt_temperatura;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.Label lbl_temperatura;
        private System.Windows.Forms.Button button_registrarTemp;
    }
}

