namespace horarios4.UI
{
    partial class FormHorarios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHorarios));
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.gbxRegistro = new System.Windows.Forms.GroupBox();
            this.cboCiclo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.gcLunes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gcMartes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gcMiercoles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gcJueves = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gcViernes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.gcIdHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcIdCiclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcNombreCiclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsrHorario = new System.Windows.Forms.BindingSource(this.components);
            this.gcTextoHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcIdHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsrDetalle = new System.Windows.Forms.BindingSource(this.components);
            this.horaBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabGeneral.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.tabRegistro.SuspendLayout();
            this.gbxRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrHorario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaBEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabConsulta);
            this.TabGeneral.Controls.Add(this.tabRegistro);
            this.TabGeneral.Location = new System.Drawing.Point(12, 28);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(753, 326);
            this.TabGeneral.TabIndex = 4;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.btnActualizar);
            this.tabConsulta.Controls.Add(this.label1);
            this.tabConsulta.Controls.Add(this.dgvHorarios);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(745, 300);
            this.tabConsulta.TabIndex = 0;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(655, 18);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Horarios";
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            this.dgvHorarios.AutoGenerateColumns = false;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcIdHorario,
            this.gcIdCiclo,
            this.gcDescripcion,
            this.gcNombreCiclo});
            this.dgvHorarios.DataSource = this.bsrHorario;
            this.dgvHorarios.Location = new System.Drawing.Point(6, 57);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.ReadOnly = true;
            this.dgvHorarios.Size = new System.Drawing.Size(733, 237);
            this.dgvHorarios.TabIndex = 0;
            this.dgvHorarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.gbxRegistro);
            this.tabRegistro.Controls.Add(this.dgvRegistro);
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(745, 300);
            this.tabRegistro.TabIndex = 1;
            this.tabRegistro.Text = "Registro";
            this.tabRegistro.UseVisualStyleBackColor = true;
            // 
            // gbxRegistro
            // 
            this.gbxRegistro.Controls.Add(this.cboCiclo);
            this.gbxRegistro.Controls.Add(this.label3);
            this.gbxRegistro.Controls.Add(this.label2);
            this.gbxRegistro.Controls.Add(this.txtDescripcion);
            this.gbxRegistro.Location = new System.Drawing.Point(6, 6);
            this.gbxRegistro.Name = "gbxRegistro";
            this.gbxRegistro.Size = new System.Drawing.Size(732, 57);
            this.gbxRegistro.TabIndex = 9;
            this.gbxRegistro.TabStop = false;
            this.gbxRegistro.Text = "Datos";
            // 
            // cboCiclo
            // 
            this.cboCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiclo.FormattingEnabled = true;
            this.cboCiclo.Location = new System.Drawing.Point(61, 19);
            this.cboCiclo.Name = "cboCiclo";
            this.cboCiclo.Size = new System.Drawing.Size(221, 21);
            this.cboCiclo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ciclo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(391, 19);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(317, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToDeleteRows = false;
            this.dgvRegistro.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcTextoHora,
            this.gcLunes,
            this.gcMartes,
            this.gcMiercoles,
            this.gcJueves,
            this.gcViernes,
            this.gcIdHora});
            this.dgvRegistro.DataSource = this.bsrDetalle;
            this.dgvRegistro.Enabled = false;
            this.dgvRegistro.Location = new System.Drawing.Point(6, 69);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.Size = new System.Drawing.Size(732, 224);
            this.dgvRegistro.TabIndex = 4;
            this.dgvRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistro_CellContentClick);
            this.dgvRegistro.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRegistro_CellFormatting);
            // 
            // gcLunes
            // 
            this.gcLunes.HeaderText = "Lunes";
            this.gcLunes.Name = "gcLunes";
            this.gcLunes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gcLunes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gcMartes
            // 
            this.gcMartes.HeaderText = "Martes";
            this.gcMartes.Name = "gcMartes";
            // 
            // gcMiercoles
            // 
            this.gcMiercoles.HeaderText = "Miercoles";
            this.gcMiercoles.Name = "gcMiercoles";
            // 
            // gcJueves
            // 
            this.gcJueves.HeaderText = "Jueves";
            this.gcJueves.Name = "gcJueves";
            // 
            // gcViernes
            // 
            this.gcViernes.HeaderText = "Viernes";
            this.gcViernes.Name = "gcViernes";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnGuardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(776, 25);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(776, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(776, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            // 
            // gcIdHorario
            // 
            this.gcIdHorario.DataPropertyName = "IdHorario";
            this.gcIdHorario.HeaderText = "IdHorario";
            this.gcIdHorario.Name = "gcIdHorario";
            this.gcIdHorario.ReadOnly = true;
            this.gcIdHorario.Visible = false;
            // 
            // gcIdCiclo
            // 
            this.gcIdCiclo.DataPropertyName = "IdCiclo";
            this.gcIdCiclo.HeaderText = "IdCiclo";
            this.gcIdCiclo.Name = "gcIdCiclo";
            this.gcIdCiclo.ReadOnly = true;
            this.gcIdCiclo.Visible = false;
            // 
            // gcDescripcion
            // 
            this.gcDescripcion.DataPropertyName = "Descripcion";
            this.gcDescripcion.HeaderText = "Descripcion";
            this.gcDescripcion.Name = "gcDescripcion";
            this.gcDescripcion.ReadOnly = true;
            this.gcDescripcion.Width = 300;
            // 
            // gcNombreCiclo
            // 
            this.gcNombreCiclo.DataPropertyName = "NombreCiclo";
            this.gcNombreCiclo.HeaderText = "Ciclo";
            this.gcNombreCiclo.Name = "gcNombreCiclo";
            this.gcNombreCiclo.ReadOnly = true;
            this.gcNombreCiclo.Width = 300;
            // 
            // bsrHorario
            // 
            this.bsrHorario.DataSource = typeof(horarios4.BE.HorarioBE);
            // 
            // gcTextoHora
            // 
            this.gcTextoHora.DataPropertyName = "TextoHora";
            this.gcTextoHora.HeaderText = "Hora";
            this.gcTextoHora.Name = "gcTextoHora";
            // 
            // gcIdHora
            // 
            this.gcIdHora.DataPropertyName = "IdHora";
            this.gcIdHora.HeaderText = "IdHora";
            this.gcIdHora.Name = "gcIdHora";
            this.gcIdHora.Visible = false;
            // 
            // bsrDetalle
            // 
            this.bsrDetalle.DataSource = typeof(horarios4.BE.HoraBE);
            // 
            // horaBEBindingSource
            // 
            this.horaBEBindingSource.DataSource = typeof(horarios4.BE.HoraBE);
            // 
            // FormHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 365);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TabGeneral);
            this.MinimumSize = new System.Drawing.Size(792, 404);
            this.Name = "FormHorarios";
            this.Text = "Sistemas de Horarios";
            this.TabGeneral.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.tabRegistro.ResumeLayout(false);
            this.gbxRegistro.ResumeLayout(false);
            this.gbxRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsrHorario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaBEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.GroupBox gbxRegistro;
        private System.Windows.Forms.ComboBox cboCiclo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.BindingSource bsrHorario;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        //private System.Windows.Forms.DataGridViewTextBoxColumn gcIdHorario;
        //private System.Windows.Forms.DataGridViewTextBoxColumn gcIdCiclo;
        //private System.Windows.Forms.DataGridViewTextBoxColumn gcDescripcion;
        private System.Windows.Forms.BindingSource bsrDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcTextoHora;
        private System.Windows.Forms.DataGridViewButtonColumn gcLunes;
        private System.Windows.Forms.DataGridViewButtonColumn gcMartes;
        private System.Windows.Forms.DataGridViewButtonColumn gcMiercoles;
        private System.Windows.Forms.DataGridViewButtonColumn gcJueves;
        private System.Windows.Forms.DataGridViewButtonColumn gcViernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcIdHora;
        private System.Windows.Forms.BindingSource horaBEBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcIdHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcIdCiclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcNombreCiclo;
    }
}