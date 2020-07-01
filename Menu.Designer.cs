namespace Login2
{
    partial class Menu
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
            this.Pizzas = new System.Windows.Forms.GroupBox();
            this.BotonIndividual = new System.Windows.Forms.RadioButton();
            this.BotonMediana = new System.Windows.Forms.RadioButton();
            this.BotonFamiliar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BebidaFamiliar = new System.Windows.Forms.RadioButton();
            this.BebidaIndividual = new System.Windows.Forms.RadioButton();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.Tabla_Venta = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CajaCantidadPizza = new System.Windows.Forms.TextBox();
            this.CajaCantidadBebida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pizzas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Venta)).BeginInit();
            this.SuspendLayout();
            // 
            // Pizzas
            // 
            this.Pizzas.Controls.Add(this.BotonIndividual);
            this.Pizzas.Controls.Add(this.BotonMediana);
            this.Pizzas.Controls.Add(this.BotonFamiliar);
            this.Pizzas.Location = new System.Drawing.Point(12, 33);
            this.Pizzas.Name = "Pizzas";
            this.Pizzas.Size = new System.Drawing.Size(200, 159);
            this.Pizzas.TabIndex = 0;
            this.Pizzas.TabStop = false;
            this.Pizzas.Text = "Pizzas";
            // 
            // BotonIndividual
            // 
            this.BotonIndividual.AutoSize = true;
            this.BotonIndividual.Location = new System.Drawing.Point(21, 116);
            this.BotonIndividual.Name = "BotonIndividual";
            this.BotonIndividual.Size = new System.Drawing.Size(106, 17);
            this.BotonIndividual.TabIndex = 2;
            this.BotonIndividual.TabStop = true;
            this.BotonIndividual.Text = "Individual $8.000";
            this.BotonIndividual.UseVisualStyleBackColor = true;
            // 
            // BotonMediana
            // 
            this.BotonMediana.AutoSize = true;
            this.BotonMediana.Location = new System.Drawing.Point(21, 79);
            this.BotonMediana.Name = "BotonMediana";
            this.BotonMediana.Size = new System.Drawing.Size(108, 17);
            this.BotonMediana.TabIndex = 1;
            this.BotonMediana.TabStop = true;
            this.BotonMediana.Text = "Mediana $12.000";
            this.BotonMediana.UseVisualStyleBackColor = true;
            // 
            // BotonFamiliar
            // 
            this.BotonFamiliar.AutoSize = true;
            this.BotonFamiliar.Location = new System.Drawing.Point(21, 37);
            this.BotonFamiliar.Name = "BotonFamiliar";
            this.BotonFamiliar.Size = new System.Drawing.Size(102, 17);
            this.BotonFamiliar.TabIndex = 0;
            this.BotonFamiliar.TabStop = true;
            this.BotonFamiliar.Text = "Familiar $22.000";
            this.BotonFamiliar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BebidaFamiliar);
            this.groupBox2.Controls.Add(this.BebidaIndividual);
            this.groupBox2.Location = new System.Drawing.Point(228, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bebidas";
            // 
            // BebidaFamiliar
            // 
            this.BebidaFamiliar.AutoSize = true;
            this.BebidaFamiliar.Location = new System.Drawing.Point(44, 98);
            this.BebidaFamiliar.Name = "BebidaFamiliar";
            this.BebidaFamiliar.Size = new System.Drawing.Size(96, 17);
            this.BebidaFamiliar.TabIndex = 1;
            this.BebidaFamiliar.TabStop = true;
            this.BebidaFamiliar.Text = "Familiar $5.000";
            this.BebidaFamiliar.UseVisualStyleBackColor = true;
            // 
            // BebidaIndividual
            // 
            this.BebidaIndividual.AutoSize = true;
            this.BebidaIndividual.Location = new System.Drawing.Point(44, 54);
            this.BebidaIndividual.Name = "BebidaIndividual";
            this.BebidaIndividual.Size = new System.Drawing.Size(106, 17);
            this.BebidaIndividual.TabIndex = 0;
            this.BebidaIndividual.TabStop = true;
            this.BebidaIndividual.Text = "Individual $1.500";
            this.BebidaIndividual.UseVisualStyleBackColor = true;
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Location = new System.Drawing.Point(66, 260);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(92, 36);
            this.BotonAgregar.TabIndex = 2;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Location = new System.Drawing.Point(239, 260);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(92, 36);
            this.BotonCerrar.TabIndex = 3;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = true;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // Tabla_Venta
            // 
            this.Tabla_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3});
            this.Tabla_Venta.Location = new System.Drawing.Point(434, 14);
            this.Tabla_Venta.Name = "Tabla_Venta";
            this.Tabla_Venta.Size = new System.Drawing.Size(364, 325);
            this.Tabla_Venta.TabIndex = 4;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cant";
            this.Column4.Name = "Column4";
            this.Column4.Width = 35;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ped_Piz";
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cant";
            this.Column5.Name = "Column5";
            this.Column5.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ped_Beb";
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // CajaCantidadPizza
            // 
            this.CajaCantidadPizza.Location = new System.Drawing.Point(36, 227);
            this.CajaCantidadPizza.Name = "CajaCantidadPizza";
            this.CajaCantidadPizza.Size = new System.Drawing.Size(25, 20);
            this.CajaCantidadPizza.TabIndex = 7;
            // 
            // CajaCantidadBebida
            // 
            this.CajaCantidadBebida.Location = new System.Drawing.Point(256, 227);
            this.CajaCantidadBebida.Name = "CajaCantidadBebida";
            this.CajaCantidadBebida.Size = new System.Drawing.Size(25, 20);
            this.CajaCantidadBebida.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CajaCantidadBebida);
            this.Controls.Add(this.CajaCantidadPizza);
            this.Controls.Add(this.Tabla_Venta);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Pizzas);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Pizzas.ResumeLayout(false);
            this.Pizzas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Venta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Pizzas;
        private System.Windows.Forms.RadioButton BotonIndividual;
        private System.Windows.Forms.RadioButton BotonMediana;
        private System.Windows.Forms.RadioButton BotonFamiliar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton BebidaFamiliar;
        private System.Windows.Forms.RadioButton BebidaIndividual;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.DataGridView Tabla_Venta;
        private System.Windows.Forms.TextBox CajaCantidadPizza;
        private System.Windows.Forms.TextBox CajaCantidadBebida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}