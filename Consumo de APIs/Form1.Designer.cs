namespace Consumo_de_APIs
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
            this.piturePokemon = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.buttonBus = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.btnClima = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.piturePokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // piturePokemon
            // 
            this.piturePokemon.Location = new System.Drawing.Point(483, 86);
            this.piturePokemon.Name = "piturePokemon";
            this.piturePokemon.Size = new System.Drawing.Size(247, 233);
            this.piturePokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piturePokemon.TabIndex = 0;
            this.piturePokemon.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(52, 193);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(375, 150);
            this.dataGridView.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(97, 56);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(256, 22);
            this.txtBuscar.TabIndex = 2;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(26, 59);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(56, 16);
            this.labelN.TabIndex = 3;
            this.labelN.Text = "Nombre";
            // 
            // buttonBus
            // 
            this.buttonBus.Location = new System.Drawing.Point(225, 97);
            this.buttonBus.Name = "buttonBus";
            this.buttonBus.Size = new System.Drawing.Size(128, 26);
            this.buttonBus.TabIndex = 4;
            this.buttonBus.Text = "Buscar Pokemon";
            this.buttonBus.UseVisualStyleBackColor = true;
            this.buttonBus.Click += new System.EventHandler(this.buttonBus_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(59, 174);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(56, 16);
            this.labelNom.TabIndex = 5;
            this.labelNom.Text = "Nombre";
            // 
            // btnClima
            // 
            this.btnClima.Location = new System.Drawing.Point(62, 100);
            this.btnClima.Name = "btnClima";
            this.btnClima.Size = new System.Drawing.Size(128, 23);
            this.btnClima.TabIndex = 6;
            this.btnClima.Text = "Buscar Clima";
            this.btnClima.UseVisualStyleBackColor = true;
            this.btnClima.Click += new System.EventHandler(this.btnClima_ClickAsync);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(140, 364);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(173, 58);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar Informacion";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Consumo_de_APIs.Properties.Resources._80553371_fondo_tecnológico_abstracto_con_elementos_fondo_de_tecnología;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClima);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.buttonBus);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.piturePokemon);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.piturePokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piturePokemon;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Button buttonBus;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button btnClima;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGuardar;
    }
}

