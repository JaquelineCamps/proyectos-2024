namespace tsnp014224_tsnp217923_tsnp210223_peliculas
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
            System.Windows.Forms.Label idpeliculaLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label sinopsisLabel;
            System.Windows.Forms.Label duracionLabel;
            System.Windows.Forms.Label clasificacionLabel;
            this._db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet = new tsnp014224_tsnp217923_tsnp210223_peliculas._db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasTableAdapter = new tsnp014224_tsnp217923_tsnp210223_peliculas._db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSetTableAdapters.peliculasTableAdapter();
            this.tableAdapterManager = new tsnp014224_tsnp217923_tsnp210223_peliculas._db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSetTableAdapters.TableAdapterManager();
            this.idpeliculaLabel1 = new System.Windows.Forms.Label();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.sinopsisTextBox = new System.Windows.Forms.TextBox();
            this.duracionTextBox = new System.Windows.Forms.TextBox();
            this.clasificacionTextBox = new System.Windows.Forms.TextBox();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.peliculasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            idpeliculaLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            sinopsisLabel = new System.Windows.Forms.Label();
            duracionLabel = new System.Windows.Forms.Label();
            clasificacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            this.grbNavegacion.SuspendLayout();
            this.grbEdicion.SuspendLayout();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idpeliculaLabel
            // 
            idpeliculaLabel.AutoSize = true;
            idpeliculaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idpeliculaLabel.Location = new System.Drawing.Point(60, 44);
            idpeliculaLabel.Name = "idpeliculaLabel";
            idpeliculaLabel.Size = new System.Drawing.Size(26, 16);
            idpeliculaLabel.TabIndex = 1;
            idpeliculaLabel.Text = "ID:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloLabel.Location = new System.Drawing.Point(21, 109);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(80, 20);
            tituloLabel.TabIndex = 3;
            tituloLabel.Text = "TITULO:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autorLabel.Location = new System.Drawing.Point(21, 153);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(78, 20);
            autorLabel.TabIndex = 5;
            autorLabel.Text = "AUTOR:";
            // 
            // sinopsisLabel
            // 
            sinopsisLabel.AutoSize = true;
            sinopsisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sinopsisLabel.Location = new System.Drawing.Point(21, 206);
            sinopsisLabel.Name = "sinopsisLabel";
            sinopsisLabel.Size = new System.Drawing.Size(100, 20);
            sinopsisLabel.TabIndex = 7;
            sinopsisLabel.Text = "SINOPSIS:";
            // 
            // duracionLabel
            // 
            duracionLabel.AutoSize = true;
            duracionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            duracionLabel.Location = new System.Drawing.Point(21, 261);
            duracionLabel.Name = "duracionLabel";
            duracionLabel.Size = new System.Drawing.Size(112, 20);
            duracionLabel.TabIndex = 9;
            duracionLabel.Text = "DURACION:";
            // 
            // clasificacionLabel
            // 
            clasificacionLabel.AutoSize = true;
            clasificacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clasificacionLabel.Location = new System.Drawing.Point(21, 318);
            clasificacionLabel.Name = "clasificacionLabel";
            clasificacionLabel.Size = new System.Drawing.Size(154, 20);
            clasificacionLabel.TabIndex = 11;
            clasificacionLabel.Text = "CLASIFICACION:";
            // 
            // _db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet
            // 
            this._db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet.DataSetName = "_db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet";
            this._db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "peliculas";
            this.peliculasBindingSource.DataSource = this._db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.peliculasTableAdapter = this.peliculasTableAdapter;
            this.tableAdapterManager.UpdateOrder = tsnp014224_tsnp217923_tsnp210223_peliculas._db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idpeliculaLabel1
            // 
            this.idpeliculaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "Idpelicula", true));
            this.idpeliculaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpeliculaLabel1.Location = new System.Drawing.Point(239, 37);
            this.idpeliculaLabel1.Name = "idpeliculaLabel1";
            this.idpeliculaLabel1.Size = new System.Drawing.Size(100, 23);
            this.idpeliculaLabel1.TabIndex = 2;
            this.idpeliculaLabel1.Text = "label1";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(177, 109);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(399, 22);
            this.tituloTextBox.TabIndex = 4;
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(177, 151);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(368, 22);
            this.autorTextBox.TabIndex = 6;
            // 
            // sinopsisTextBox
            // 
            this.sinopsisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "sinopsis", true));
            this.sinopsisTextBox.Location = new System.Drawing.Point(177, 204);
            this.sinopsisTextBox.Name = "sinopsisTextBox";
            this.sinopsisTextBox.Size = new System.Drawing.Size(547, 22);
            this.sinopsisTextBox.TabIndex = 8;
            // 
            // duracionTextBox
            // 
            this.duracionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "duracion", true));
            this.duracionTextBox.Location = new System.Drawing.Point(177, 259);
            this.duracionTextBox.Name = "duracionTextBox";
            this.duracionTextBox.Size = new System.Drawing.Size(199, 22);
            this.duracionTextBox.TabIndex = 10;
            // 
            // clasificacionTextBox
            // 
            this.clasificacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "clasificacion", true));
            this.clasificacionTextBox.Location = new System.Drawing.Point(177, 318);
            this.clasificacionTextBox.Name = "clasificacionTextBox";
            this.clasificacionTextBox.Size = new System.Drawing.Size(529, 22);
            this.clasificacionTextBox.TabIndex = 12;
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblRegistros);
            this.grbNavegacion.Controls.Add(this.btnUltimo);
            this.grbNavegacion.Controls.Add(this.btnSiguiente);
            this.grbNavegacion.Controls.Add(this.btnAnterior);
            this.grbNavegacion.Controls.Add(this.btnPrimero);
            this.grbNavegacion.Location = new System.Drawing.Point(9, 394);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(351, 67);
            this.grbNavegacion.TabIndex = 13;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // lblRegistros
            // 
            this.lblRegistros.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peliculasBindingSource, "Idpelicula", true));
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(136, 30);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(99, 23);
            this.lblRegistros.TabIndex = 14;
            this.lblRegistros.Text = "x de n";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.Location = new System.Drawing.Point(279, 20);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(50, 39);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(226, 19);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(50, 39);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(80, 22);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(50, 39);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(27, 21);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(50, 39);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "|<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnModificar);
            this.grbEdicion.Controls.Add(this.btnEliminar);
            this.grbEdicion.Controls.Add(this.btnAgregar);
            this.grbEdicion.Location = new System.Drawing.Point(366, 394);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Size = new System.Drawing.Size(391, 67);
            this.grbEdicion.TabIndex = 14;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(124, 13);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(138, 48);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(268, 11);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 48);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(1, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 48);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(autorLabel);
            this.grbDatos.Controls.Add(this.clasificacionTextBox);
            this.grbDatos.Controls.Add(clasificacionLabel);
            this.grbDatos.Controls.Add(idpeliculaLabel);
            this.grbDatos.Controls.Add(this.duracionTextBox);
            this.grbDatos.Controls.Add(this.idpeliculaLabel1);
            this.grbDatos.Controls.Add(duracionLabel);
            this.grbDatos.Controls.Add(tituloLabel);
            this.grbDatos.Controls.Add(this.sinopsisTextBox);
            this.grbDatos.Controls.Add(this.tituloTextBox);
            this.grbDatos.Controls.Add(sinopsisLabel);
            this.grbDatos.Controls.Add(this.autorTextBox);
            this.grbDatos.Enabled = false;
            this.grbDatos.Location = new System.Drawing.Point(11, 28);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(746, 360);
            this.grbDatos.TabIndex = 15;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos de las peliculas";
            // 
            // peliculasDataGridView
            // 
            this.peliculasDataGridView.AllowUserToAddRows = false;
            this.peliculasDataGridView.AllowUserToDeleteRows = false;
            this.peliculasDataGridView.AutoGenerateColumns = false;
            this.peliculasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peliculasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.peliculasDataGridView.DataSource = this.peliculasBindingSource;
            this.peliculasDataGridView.Location = new System.Drawing.Point(788, 115);
            this.peliculasDataGridView.Name = "peliculasDataGridView";
            this.peliculasDataGridView.ReadOnly = true;
            this.peliculasDataGridView.RowHeadersWidth = 51;
            this.peliculasDataGridView.RowTemplate.Height = 24;
            this.peliculasDataGridView.Size = new System.Drawing.Size(554, 332);
            this.peliculasDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Idpelicula";
            this.dataGridViewTextBoxColumn1.HeaderText = "Idpelicula";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "TITULO";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "autor";
            this.dataGridViewTextBoxColumn3.HeaderText = "AUTOR";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sinopsis";
            this.dataGridViewTextBoxColumn4.HeaderText = "SINOPSIS";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "duracion";
            this.dataGridViewTextBoxColumn5.HeaderText = "DURACION";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "clasificacion";
            this.dataGridViewTextBoxColumn6.HeaderText = "CLASIFICACION";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(788, 72);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(536, 22);
            this.txtBuscar.TabIndex = 16;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 481);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.peliculasDataGridView);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            this.grbNavegacion.ResumeLayout(false);
            this.grbEdicion.ResumeLayout(false);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet _db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSet;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private _db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSetTableAdapters.peliculasTableAdapter peliculasTableAdapter;
        private _db_tsnp014224_tsnp217923_tsnp210223_peliculasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idpeliculaLabel1;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox sinopsisTextBox;
        private System.Windows.Forms.TextBox duracionTextBox;
        private System.Windows.Forms.TextBox clasificacionTextBox;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.DataGridView peliculasDataGridView;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

