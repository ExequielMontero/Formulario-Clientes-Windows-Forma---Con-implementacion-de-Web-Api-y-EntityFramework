namespace Consumiendo_API_Clientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.rbActualizar = new System.Windows.Forms.RadioButton();
            this.rbBuscar = new System.Windows.Forms.RadioButton();
            this.rbAgregar = new System.Windows.Forms.RadioButton();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostar = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostar);
            this.groupBox1.Controls.Add(this.rbEliminar);
            this.groupBox1.Controls.Add(this.rbActualizar);
            this.groupBox1.Controls.Add(this.rbBuscar);
            this.groupBox1.Controls.Add(this.rbAgregar);
            this.groupBox1.Controls.Add(this.tbBuscar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar cliente";
            // 
            // rbEliminar
            // 
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(6, 114);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(69, 17);
            this.rbEliminar.TabIndex = 5;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            // 
            // rbActualizar
            // 
            this.rbActualizar.AutoSize = true;
            this.rbActualizar.Location = new System.Drawing.Point(6, 91);
            this.rbActualizar.Name = "rbActualizar";
            this.rbActualizar.Size = new System.Drawing.Size(81, 17);
            this.rbActualizar.TabIndex = 4;
            this.rbActualizar.TabStop = true;
            this.rbActualizar.Text = "Actualizar";
            this.rbActualizar.UseVisualStyleBackColor = true;
            // 
            // rbBuscar
            // 
            this.rbBuscar.AutoSize = true;
            this.rbBuscar.Location = new System.Drawing.Point(6, 68);
            this.rbBuscar.Name = "rbBuscar";
            this.rbBuscar.Size = new System.Drawing.Size(64, 17);
            this.rbBuscar.TabIndex = 3;
            this.rbBuscar.TabStop = true;
            this.rbBuscar.Text = "Buscar";
            this.rbBuscar.UseVisualStyleBackColor = true;
            // 
            // rbAgregar
            // 
            this.rbAgregar.AutoSize = true;
            this.rbAgregar.Location = new System.Drawing.Point(6, 45);
            this.rbAgregar.Name = "rbAgregar";
            this.rbAgregar.Size = new System.Drawing.Size(69, 17);
            this.rbAgregar.TabIndex = 2;
            this.rbAgregar.TabStop = true;
            this.rbAgregar.Text = "Agregar";
            this.rbAgregar.UseVisualStyleBackColor = true;
            this.rbAgregar.CheckedChanged += new System.EventHandler(this.rbAgregar_CheckedChanged);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(84, 19);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 20);
            this.tbBuscar.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(3, 16);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 263);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnMostar
            // 
            this.btnMostar.AutoSize = true;
            this.btnMostar.Location = new System.Drawing.Point(93, 45);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(106, 17);
            this.btnMostar.TabIndex = 6;
            this.btnMostar.TabStop = true;
            this.btnMostar.Text = "Mostrar Todos";
            this.btnMostar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.RadioButton rbActualizar;
        private System.Windows.Forms.RadioButton rbBuscar;
        private System.Windows.Forms.RadioButton rbAgregar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton btnMostar;
    }
}

