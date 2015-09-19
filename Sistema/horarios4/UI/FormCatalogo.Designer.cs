namespace horarios4
{
    partial class FormCatalogo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_categoriaLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label gradoLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnNuevo1 = new System.Windows.Forms.Button();
            this.gbxDocentes = new System.Windows.Forms.GroupBox();
            this.cboCategoría1 = new System.Windows.Forms.ComboBox();
            this.txtApellidos1 = new System.Windows.Forms.TextBox();
            this.txtNombres1 = new System.Windows.Forms.TextBox();
            this.txtGrado1 = new System.Windows.Forms.TextBox();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.btnModificar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.gbxAsignatura = new System.Windows.Forms.GroupBox();
            this.cboCurricula2 = new System.Windows.Forms.ComboBox();
            this.txtDescripcion2 = new System.Windows.Forms.TextBox();
            this.btnNuevo2 = new System.Windows.Forms.Button();
            this.btnGuardar2 = new System.Windows.Forms.Button();
            this.btnModificar2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbxAmbiente = new System.Windows.Forms.GroupBox();
            this.cboTipoAmbiente3 = new System.Windows.Forms.ComboBox();
            this.txtDescripcion3 = new System.Windows.Forms.TextBox();
            this.btnNuevo3 = new System.Windows.Forms.Button();
            this.btnGuardar3 = new System.Windows.Forms.Button();
            this.btnModificar3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAmbiente = new System.Windows.Forms.DataGridView();
            this.gcIdDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsrDocentes = new System.Windows.Forms.BindingSource(this.components);
            this.gcIdAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcIdCurricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcCurricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsrAsignaturas = new System.Windows.Forms.BindingSource(this.components);
            this.gcIdAmbiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcIdTipoAmbiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcAmbiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcTipoAmbiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsrAmbiente = new System.Windows.Forms.BindingSource(this.components);
            id_categoriaLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            gradoLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.gbxDocentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.gbxAsignatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.gbxAmbiente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmbiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrAsignaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrAmbiente)).BeginInit();
            this.SuspendLayout();
            // 
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.Location = new System.Drawing.Point(374, 50);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(54, 13);
            id_categoriaLabel.TabIndex = 3;
            id_categoriaLabel.Text = "Categoría";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(17, 50);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(49, 13);
            apellidosLabel.TabIndex = 9;
            apellidosLabel.Text = "Apellidos";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(17, 24);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(49, 13);
            nombresLabel.TabIndex = 7;
            nombresLabel.Text = "Nombres";
            // 
            // gradoLabel
            // 
            gradoLabel.AutoSize = true;
            gradoLabel.Location = new System.Drawing.Point(374, 24);
            gradoLabel.Name = "gradoLabel";
            gradoLabel.Size = new System.Drawing.Size(36, 13);
            gradoLabel.TabIndex = 5;
            gradoLabel.Text = "Grado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(9, 57);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 13);
            label5.TabIndex = 24;
            label5.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 31);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 13);
            label3.TabIndex = 22;
            label3.Text = "Curricula";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(12, 56);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(63, 13);
            label8.TabIndex = 27;
            label8.Text = "Descripción";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(12, 28);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(75, 13);
            label7.TabIndex = 25;
            label7.Text = "Tipo Ambiente";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(734, 399);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.btnNuevo1);
            this.tabPage5.Controls.Add(this.gbxDocentes);
            this.tabPage5.Controls.Add(this.dgvDocentes);
            this.tabPage5.Controls.Add(this.btnGuardar1);
            this.tabPage5.Controls.Add(this.btnModificar1);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(726, 373);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Docentes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnNuevo1
            // 
            this.btnNuevo1.Location = new System.Drawing.Point(215, 11);
            this.btnNuevo1.Name = "btnNuevo1";
            this.btnNuevo1.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo1.TabIndex = 22;
            this.btnNuevo1.Text = "Nuevo";
            this.btnNuevo1.UseVisualStyleBackColor = true;
            this.btnNuevo1.Click += new System.EventHandler(this.btnNuevo1_Click);
            // 
            // gbxDocentes
            // 
            this.gbxDocentes.Controls.Add(this.cboCategoría1);
            this.gbxDocentes.Controls.Add(id_categoriaLabel);
            this.gbxDocentes.Controls.Add(this.txtApellidos1);
            this.gbxDocentes.Controls.Add(apellidosLabel);
            this.gbxDocentes.Controls.Add(this.txtNombres1);
            this.gbxDocentes.Controls.Add(nombresLabel);
            this.gbxDocentes.Controls.Add(this.txtGrado1);
            this.gbxDocentes.Controls.Add(gradoLabel);
            this.gbxDocentes.Location = new System.Drawing.Point(3, 41);
            this.gbxDocentes.Name = "gbxDocentes";
            this.gbxDocentes.Size = new System.Drawing.Size(712, 95);
            this.gbxDocentes.TabIndex = 21;
            this.gbxDocentes.TabStop = false;
            this.gbxDocentes.Text = "Datos";
            // 
            // cboCategoría1
            // 
            this.cboCategoría1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoría1.FormattingEnabled = true;
            this.cboCategoría1.Location = new System.Drawing.Point(438, 47);
            this.cboCategoría1.Name = "cboCategoría1";
            this.cboCategoría1.Size = new System.Drawing.Size(230, 21);
            this.cboCategoría1.TabIndex = 11;
            // 
            // txtApellidos1
            // 
            this.txtApellidos1.Location = new System.Drawing.Point(79, 47);
            this.txtApellidos1.Name = "txtApellidos1";
            this.txtApellidos1.Size = new System.Drawing.Size(243, 20);
            this.txtApellidos1.TabIndex = 10;
            // 
            // txtNombres1
            // 
            this.txtNombres1.Location = new System.Drawing.Point(79, 21);
            this.txtNombres1.Name = "txtNombres1";
            this.txtNombres1.Size = new System.Drawing.Size(243, 20);
            this.txtNombres1.TabIndex = 8;
            // 
            // txtGrado1
            // 
            this.txtGrado1.Location = new System.Drawing.Point(438, 21);
            this.txtGrado1.Name = "txtGrado1";
            this.txtGrado1.Size = new System.Drawing.Size(230, 20);
            this.txtGrado1.TabIndex = 6;
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.AllowUserToOrderColumns = true;
            this.dgvDocentes.AutoGenerateColumns = false;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcIdDocente,
            this.gcIdCategoria,
            this.gcNombres,
            this.gcApellidos,
            this.gcGrado,
            this.gcCategoria});
            this.dgvDocentes.DataSource = this.bsrDocentes;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocentes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocentes.Location = new System.Drawing.Point(3, 142);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(712, 228);
            this.dgvDocentes.TabIndex = 20;
            this.dgvDocentes.SelectionChanged += new System.EventHandler(this.dgvDocentes_SelectionChanged);
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(377, 11);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar1.TabIndex = 13;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.btnGuardar1_Click);
            // 
            // btnModificar1
            // 
            this.btnModificar1.Location = new System.Drawing.Point(296, 11);
            this.btnModificar1.Name = "btnModificar1";
            this.btnModificar1.Size = new System.Drawing.Size(75, 23);
            this.btnModificar1.TabIndex = 12;
            this.btnModificar1.Text = "Modificar";
            this.btnModificar1.UseVisualStyleBackColor = true;
            this.btnModificar1.Click += new System.EventHandler(this.btnModificar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista de Docentes";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.gbxAsignatura);
            this.tabPage6.Controls.Add(this.btnNuevo2);
            this.tabPage6.Controls.Add(this.btnGuardar2);
            this.tabPage6.Controls.Add(this.btnModificar2);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.dgvAsignaturas);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(726, 373);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Asignaturas";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // gbxAsignatura
            // 
            this.gbxAsignatura.Controls.Add(this.cboCurricula2);
            this.gbxAsignatura.Controls.Add(this.txtDescripcion2);
            this.gbxAsignatura.Controls.Add(label5);
            this.gbxAsignatura.Controls.Add(label3);
            this.gbxAsignatura.Location = new System.Drawing.Point(3, 41);
            this.gbxAsignatura.Name = "gbxAsignatura";
            this.gbxAsignatura.Size = new System.Drawing.Size(720, 94);
            this.gbxAsignatura.TabIndex = 34;
            this.gbxAsignatura.TabStop = false;
            this.gbxAsignatura.Text = "Datos";
            // 
            // cboCurricula2
            // 
            this.cboCurricula2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurricula2.FormattingEnabled = true;
            this.cboCurricula2.Location = new System.Drawing.Point(133, 28);
            this.cboCurricula2.Name = "cboCurricula2";
            this.cboCurricula2.Size = new System.Drawing.Size(271, 21);
            this.cboCurricula2.TabIndex = 26;
            // 
            // txtDescripcion2
            // 
            this.txtDescripcion2.Location = new System.Drawing.Point(133, 55);
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Size = new System.Drawing.Size(271, 20);
            this.txtDescripcion2.TabIndex = 25;
            // 
            // btnNuevo2
            // 
            this.btnNuevo2.Location = new System.Drawing.Point(214, 12);
            this.btnNuevo2.Name = "btnNuevo2";
            this.btnNuevo2.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo2.TabIndex = 33;
            this.btnNuevo2.Text = "Nuevo";
            this.btnNuevo2.UseVisualStyleBackColor = true;
            this.btnNuevo2.Click += new System.EventHandler(this.btnNuevo2_Click);
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.Location = new System.Drawing.Point(376, 12);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar2.TabIndex = 32;
            this.btnGuardar2.Text = "Guardar";
            this.btnGuardar2.UseVisualStyleBackColor = true;
            this.btnGuardar2.Click += new System.EventHandler(this.btnGuardar2_Click);
            // 
            // btnModificar2
            // 
            this.btnModificar2.Location = new System.Drawing.Point(295, 12);
            this.btnModificar2.Name = "btnModificar2";
            this.btnModificar2.Size = new System.Drawing.Size(75, 23);
            this.btnModificar2.TabIndex = 31;
            this.btnModificar2.Text = "Modificar";
            this.btnModificar2.UseVisualStyleBackColor = true;
            this.btnModificar2.Click += new System.EventHandler(this.btnModificar2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Lista de Asignaturas";
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.AllowUserToAddRows = false;
            this.dgvAsignaturas.AllowUserToDeleteRows = false;
            this.dgvAsignaturas.AutoGenerateColumns = false;
            this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcIdAsignatura,
            this.gcIdCurricula,
            this.gcAsignatura,
            this.gcCurricula});
            this.dgvAsignaturas.DataSource = this.bsrAsignaturas;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsignaturas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsignaturas.Location = new System.Drawing.Point(3, 141);
            this.dgvAsignaturas.Name = "dgvAsignaturas";
            this.dgvAsignaturas.ReadOnly = true;
            this.dgvAsignaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignaturas.Size = new System.Drawing.Size(720, 229);
            this.dgvAsignaturas.TabIndex = 21;
            this.dgvAsignaturas.SelectionChanged += new System.EventHandler(this.dgvAsignatura_SelectionChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.gbxAmbiente);
            this.tabPage4.Controls.Add(this.btnNuevo3);
            this.tabPage4.Controls.Add(this.btnGuardar3);
            this.tabPage4.Controls.Add(this.btnModificar3);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.dgvAmbiente);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(726, 373);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Ambientes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gbxAmbiente
            // 
            this.gbxAmbiente.Controls.Add(this.cboTipoAmbiente3);
            this.gbxAmbiente.Controls.Add(this.txtDescripcion3);
            this.gbxAmbiente.Controls.Add(label8);
            this.gbxAmbiente.Controls.Add(label7);
            this.gbxAmbiente.Location = new System.Drawing.Point(3, 39);
            this.gbxAmbiente.Name = "gbxAmbiente";
            this.gbxAmbiente.Size = new System.Drawing.Size(717, 97);
            this.gbxAmbiente.TabIndex = 35;
            this.gbxAmbiente.TabStop = false;
            this.gbxAmbiente.Text = "Datos";
            // 
            // cboTipoAmbiente3
            // 
            this.cboTipoAmbiente3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoAmbiente3.FormattingEnabled = true;
            this.cboTipoAmbiente3.Location = new System.Drawing.Point(136, 25);
            this.cboTipoAmbiente3.Name = "cboTipoAmbiente3";
            this.cboTipoAmbiente3.Size = new System.Drawing.Size(262, 21);
            this.cboTipoAmbiente3.TabIndex = 29;
            // 
            // txtDescripcion3
            // 
            this.txtDescripcion3.Location = new System.Drawing.Point(136, 56);
            this.txtDescripcion3.Name = "txtDescripcion3";
            this.txtDescripcion3.Size = new System.Drawing.Size(262, 20);
            this.txtDescripcion3.TabIndex = 28;
            // 
            // btnNuevo3
            // 
            this.btnNuevo3.Location = new System.Drawing.Point(215, 11);
            this.btnNuevo3.Name = "btnNuevo3";
            this.btnNuevo3.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo3.TabIndex = 34;
            this.btnNuevo3.Text = "Nuevo";
            this.btnNuevo3.UseVisualStyleBackColor = true;
            this.btnNuevo3.Click += new System.EventHandler(this.btnNuevo3_Click);
            // 
            // btnGuardar3
            // 
            this.btnGuardar3.Location = new System.Drawing.Point(387, 11);
            this.btnGuardar3.Name = "btnGuardar3";
            this.btnGuardar3.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar3.TabIndex = 33;
            this.btnGuardar3.Text = "Guardar";
            this.btnGuardar3.UseVisualStyleBackColor = true;
            this.btnGuardar3.Click += new System.EventHandler(this.btnGuardar3_Click);
            // 
            // btnModificar3
            // 
            this.btnModificar3.Location = new System.Drawing.Point(300, 11);
            this.btnModificar3.Name = "btnModificar3";
            this.btnModificar3.Size = new System.Drawing.Size(75, 23);
            this.btnModificar3.TabIndex = 32;
            this.btnModificar3.Text = "Modificar";
            this.btnModificar3.UseVisualStyleBackColor = true;
            this.btnModificar3.Click += new System.EventHandler(this.btnModificar3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Lista de Ambientes";
            // 
            // dgvAmbiente
            // 
            this.dgvAmbiente.AllowUserToAddRows = false;
            this.dgvAmbiente.AllowUserToDeleteRows = false;
            this.dgvAmbiente.AutoGenerateColumns = false;
            this.dgvAmbiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmbiente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcIdAmbiente,
            this.gcIdTipoAmbiente,
            this.gcAmbiente,
            this.gcTipoAmbiente});
            this.dgvAmbiente.DataSource = this.bsrAmbiente;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAmbiente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAmbiente.Location = new System.Drawing.Point(3, 142);
            this.dgvAmbiente.Name = "dgvAmbiente";
            this.dgvAmbiente.ReadOnly = true;
            this.dgvAmbiente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAmbiente.Size = new System.Drawing.Size(717, 228);
            this.dgvAmbiente.TabIndex = 22;
            this.dgvAmbiente.SelectionChanged += new System.EventHandler(this.dgvAmbiente_SelectionChanged);
            // 
            // gcIdDocente
            // 
            this.gcIdDocente.DataPropertyName = "IdDocente";
            this.gcIdDocente.HeaderText = "IdDocente";
            this.gcIdDocente.Name = "gcIdDocente";
            this.gcIdDocente.ReadOnly = true;
            this.gcIdDocente.Visible = false;
            // 
            // gcIdCategoria
            // 
            this.gcIdCategoria.DataPropertyName = "IdCategoria";
            this.gcIdCategoria.HeaderText = "IdCategoria";
            this.gcIdCategoria.Name = "gcIdCategoria";
            this.gcIdCategoria.ReadOnly = true;
            this.gcIdCategoria.Visible = false;
            // 
            // gcNombres
            // 
            this.gcNombres.DataPropertyName = "Nombres";
            this.gcNombres.HeaderText = "Nombres";
            this.gcNombres.Name = "gcNombres";
            this.gcNombres.ReadOnly = true;
            this.gcNombres.Width = 200;
            // 
            // gcApellidos
            // 
            this.gcApellidos.DataPropertyName = "Apellidos";
            this.gcApellidos.HeaderText = "Apellidos";
            this.gcApellidos.Name = "gcApellidos";
            this.gcApellidos.ReadOnly = true;
            this.gcApellidos.Width = 200;
            // 
            // gcGrado
            // 
            this.gcGrado.DataPropertyName = "Grado";
            this.gcGrado.HeaderText = "Grado";
            this.gcGrado.Name = "gcGrado";
            this.gcGrado.ReadOnly = true;
            this.gcGrado.Width = 150;
            // 
            // gcCategoria
            // 
            this.gcCategoria.DataPropertyName = "NombreCategoria";
            this.gcCategoria.HeaderText = "Categoría";
            this.gcCategoria.Name = "gcCategoria";
            this.gcCategoria.ReadOnly = true;
            this.gcCategoria.Width = 150;
            // 
            // bsrDocentes
            // 
            this.bsrDocentes.DataSource = typeof(horarios4.BE.DocenteBE);
            // 
            // gcIdAsignatura
            // 
            this.gcIdAsignatura.DataPropertyName = "IdAsignatura";
            this.gcIdAsignatura.HeaderText = "IdAsignatura";
            this.gcIdAsignatura.Name = "gcIdAsignatura";
            this.gcIdAsignatura.ReadOnly = true;
            this.gcIdAsignatura.Visible = false;
            // 
            // gcIdCurricula
            // 
            this.gcIdCurricula.DataPropertyName = "IdCurricula";
            this.gcIdCurricula.HeaderText = "IdCurricula";
            this.gcIdCurricula.Name = "gcIdCurricula";
            this.gcIdCurricula.ReadOnly = true;
            this.gcIdCurricula.Visible = false;
            // 
            // gcAsignatura
            // 
            this.gcAsignatura.DataPropertyName = "Descripcion";
            this.gcAsignatura.HeaderText = "Asignatura";
            this.gcAsignatura.Name = "gcAsignatura";
            this.gcAsignatura.ReadOnly = true;
            this.gcAsignatura.Width = 200;
            // 
            // gcCurricula
            // 
            this.gcCurricula.DataPropertyName = "NombreCurricula";
            this.gcCurricula.HeaderText = "Currícula";
            this.gcCurricula.Name = "gcCurricula";
            this.gcCurricula.ReadOnly = true;
            this.gcCurricula.Width = 200;
            // 
            // bsrAsignaturas
            // 
            this.bsrAsignaturas.DataSource = typeof(horarios4.BE.AsignaturaBE);
            // 
            // gcIdAmbiente
            // 
            this.gcIdAmbiente.DataPropertyName = "IdAmbiente";
            this.gcIdAmbiente.HeaderText = "IdAmbiente";
            this.gcIdAmbiente.Name = "gcIdAmbiente";
            this.gcIdAmbiente.ReadOnly = true;
            this.gcIdAmbiente.Visible = false;
            // 
            // gcIdTipoAmbiente
            // 
            this.gcIdTipoAmbiente.DataPropertyName = "IdTipoAmbiente";
            this.gcIdTipoAmbiente.HeaderText = "IdTipoAmbiente";
            this.gcIdTipoAmbiente.Name = "gcIdTipoAmbiente";
            this.gcIdTipoAmbiente.ReadOnly = true;
            this.gcIdTipoAmbiente.Visible = false;
            // 
            // gcAmbiente
            // 
            this.gcAmbiente.DataPropertyName = "Descripcion";
            this.gcAmbiente.HeaderText = "Ambiente";
            this.gcAmbiente.Name = "gcAmbiente";
            this.gcAmbiente.ReadOnly = true;
            this.gcAmbiente.Width = 200;
            // 
            // gcTipoAmbiente
            // 
            this.gcTipoAmbiente.DataPropertyName = "NombreTipoAmbiente";
            this.gcTipoAmbiente.HeaderText = "Tipo de Ambiente";
            this.gcTipoAmbiente.Name = "gcTipoAmbiente";
            this.gcTipoAmbiente.ReadOnly = true;
            this.gcTipoAmbiente.Width = 200;
            // 
            // bsrAmbiente
            // 
            this.bsrAmbiente.DataSource = typeof(horarios4.BE.AmbienteBE);
            // 
            // FormCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 420);
            this.Controls.Add(this.tabControl2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(774, 459);
            this.MinimumSize = new System.Drawing.Size(774, 459);
            this.Name = "FormCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Horarios";
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.gbxDocentes.ResumeLayout(false);
            this.gbxDocentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.gbxAsignatura.ResumeLayout(false);
            this.gbxAsignatura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.gbxAmbiente.ResumeLayout(false);
            this.gbxAmbiente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmbiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrAsignaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrAmbiente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsrDocentes;
        private System.Windows.Forms.BindingSource bsrAsignaturas;
        private System.Windows.Forms.BindingSource bsrAmbiente;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnNuevo1;
        private System.Windows.Forms.GroupBox gbxDocentes;
        private System.Windows.Forms.ComboBox cboCategoría1;
        private System.Windows.Forms.TextBox txtApellidos1;
        private System.Windows.Forms.TextBox txtNombres1;
        private System.Windows.Forms.TextBox txtGrado1;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.Button btnModificar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox gbxAsignatura;
        private System.Windows.Forms.ComboBox cboCurricula2;
        private System.Windows.Forms.TextBox txtDescripcion2;
        private System.Windows.Forms.Button btnNuevo2;
        private System.Windows.Forms.Button btnGuardar2;
        private System.Windows.Forms.Button btnModificar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox gbxAmbiente;
        private System.Windows.Forms.ComboBox cboTipoAmbiente3;
        private System.Windows.Forms.TextBox txtDescripcion3;
        private System.Windows.Forms.Button btnNuevo3;
        private System.Windows.Forms.Button btnGuardar3;
        private System.Windows.Forms.Button btnModificar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAmbiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcIdDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcIdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcGrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcIdAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcIdCurricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcCurricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcIdAmbiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcIdTipoAmbiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcAmbiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcTipoAmbiente;
    }
}

