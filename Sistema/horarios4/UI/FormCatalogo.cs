using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using horarios4.BE;
using horarios4.BR;

namespace horarios4
{
    public partial class FormCatalogo : Form
    {

        #region Funciones
        private void LlenarCombo(ComboBox cboCombo, object DataSource, Boolean blankSelection = false)
        {
            SetCombo(cboCombo, DataSource, "Description", "Value");
            if (blankSelection)
            {
                cboCombo.SelectedIndex = -1;
            }
        }

        private void SetCombo(ComboBox cboCombo, object DataSource, String DisplayMember, String ValueMember, Boolean blankSelection = false)
        {
            if (cboCombo.DataSource != null)
            {
                cboCombo.DataSource = null;
            }
            cboCombo.DisplayMember = DisplayMember;
            cboCombo.ValueMember = ValueMember;
            cboCombo.DataSource = DataSource;
            if (blankSelection)
            {
                cboCombo.SelectedIndex = -1;
            }
        }
        #endregion

        int Estado1 = 1;
        int Estado2 = 1;
        int Estado3 = 1;

        DocenteBE oDocente;
        AsignaturaBE oAsignatura;
        AmbienteBE oAmbiente;

        public FormCatalogo()
        {
            InitializeComponent();
            InicializarData();
        }

        private void InicializarData()
        {
            CargarDgv();
            LlenarCombo(cboCategoría1, DocenteBR.GetCategoria());
            LlenarCombo(cboCurricula2, AsignaturaBR.GetCurricula());
            LlenarCombo(cboTipoAmbiente3, AmbienteBR.GetTipoAmbiente());
            setDocente(1);
            setAmbiente(1);
            setAsignatura(1);
        }

        public void CargarDgv()
        {
            bsrDocentes.DataSource = DocenteBR.GetDocente();
            bsrAsignaturas.DataSource = AsignaturaBR.GetAsignatura();
            bsrAmbiente.DataSource = AmbienteBR.GetAmbiente();
        }

        #region Docente
        private void setDocente(int estado)
        {
            if (estado == 1)//navegando
            {
                gbxDocentes.Enabled = false;
                dgvDocentes.Enabled = true;
            }
            else if (estado == 2) //Insertando
            {
                gbxDocentes.Enabled = true;
                dgvDocentes.Enabled = false;
            }
            else if (estado == 3) //modificando
            {
                gbxDocentes.Enabled = true;
                dgvDocentes.Enabled = false;
            }
            Estado1 = estado;
        }

        public void LimpiarDocente()
        {
            txtNombres1.Text = string.Empty;
            txtApellidos1.Text = string.Empty;
            txtGrado1.Text = string.Empty;
            cboCategoría1.SelectedIndex = -1;
        }

        private void dgvDocentes_SelectionChanged(object sender, EventArgs e)
        {
            if (bsrDocentes.Count > 0 && dgvDocentes.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvDocentes.CurrentRow.Cells[gcIdDocente.Index].Value);

                txtNombres1.Text = dgvDocentes.CurrentRow.Cells[gcNombres.Index].Value.ToString();
                txtApellidos1.Text = dgvDocentes.CurrentRow.Cells[gcApellidos.Index].Value.ToString();
                txtGrado1.Text = dgvDocentes.CurrentRow.Cells[gcGrado.Index].Value.ToString();
                cboCategoría1.SelectedValue = (int)dgvDocentes.CurrentRow.Cells[gcIdCategoria.Index].Value;
            }
        }

        private void btnNuevo1_Click(object sender, EventArgs e)
        {
            if (Estado1 == 1)
            {
                oDocente = new DocenteBE();
                LimpiarDocente();
                setDocente(2);
            }
        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            if (Estado1 == 1)
            {
                if (dgvDocentes != null && dgvDocentes.DataSource != null && dgvDocentes.CurrentRow != null && bsrDocentes.Count > 0)
                {
                    int id = Convert.ToInt32(dgvDocentes.CurrentRow.Cells[gcIdDocente.Index].Value);
                    oDocente = DocenteBR.GetDocentebyId(id);
                    setDocente(3);
                }
            }
        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            if (Estado1 == 2 || Estado1 == 3)
            {
                if (CamposValidosDocente() == string.Empty)
                {
                    if (MessageBox.Show("¿Desea Guardar el Registro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LlenarDocente();
                        if (Estado1 == 2)
                        {
                            DocenteBR.InsDocente(oDocente);
                        }
                        else if (Estado1 == 3)
                        {
                            DocenteBR.UpdDocente(oDocente);
                        }
                        MessageBox.Show("Se guardó Satisfactoriamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setDocente(1);
                        bsrDocentes.DataSource = DocenteBR.GetDocente();
                    }
                }
                else
                {
                    MessageBox.Show(CamposValidosDocente(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void LlenarDocente()
        {
            oDocente.Nombres = txtNombres1.Text.Trim().ToUpper().ToString();
            oDocente.Apellidos = txtApellidos1.Text.Trim().ToUpper().ToString();
            oDocente.Grado = txtGrado1.Text.Trim().ToUpper().ToString();
            oDocente.IdCategoria = (int)cboCategoría1.SelectedValue;
        }

        private string CamposValidosDocente()
        {
            string mensaje = string.Empty;
            if (txtNombres1.Text.Trim().ToString() == string.Empty)
            {
                mensaje += "No ha colocado el Nombre del Docente." + Environment.NewLine;
            }
            if (txtApellidos1.Text.Trim().ToString() == string.Empty)
            {
                mensaje += "No ha colocado el Apellido del Docente." + Environment.NewLine;
            }
            if (cboCategoría1.SelectedIndex == -1)
            {
                mensaje += "No ha seleccionado la categoría del Docente." + Environment.NewLine;
            }
            return mensaje;
        }
        #endregion

        #region Asignatura
        private void setAsignatura(int estado)
        {
            if (estado == 1)//navegando
            {
                gbxAsignatura.Enabled = false;
                dgvAsignaturas.Enabled = true;
            }
            else if (estado == 2) //Insertando
            {
                gbxAsignatura.Enabled = true;
                dgvAsignaturas.Enabled = false;
            }
            else if (estado == 3) //modificando
            {
                gbxAsignatura.Enabled = true;
                dgvAsignaturas.Enabled = false;
            }
            Estado2 = estado;
        }

        public void LimpiarAsignatura()
        {
            txtDescripcion2.Text = string.Empty;
            cboCurricula2.SelectedIndex = -1;
        }

        private void dgvAsignatura_SelectionChanged(object sender, EventArgs e)
        {
            if (bsrAsignaturas.Count > 0 && dgvAsignaturas.CurrentRow != null)
            {
                cboCurricula2.SelectedValue = (int)dgvAsignaturas.CurrentRow.Cells[gcIdCurricula.Index].Value;
                txtDescripcion2.Text = dgvAsignaturas.CurrentRow.Cells[gcAsignatura.Index].Value.ToString();
            }
        }

        private void btnNuevo2_Click(object sender, EventArgs e)
        {
            if (Estado2 == 1)
            {
                oAsignatura = new AsignaturaBE();
                LimpiarAsignatura();
                setAsignatura(2);
            }
        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            if (Estado2 == 1)
            {
                if (dgvAsignaturas != null && dgvAsignaturas.DataSource != null && dgvAsignaturas.CurrentRow != null && bsrAsignaturas.Count > 0)
                {
                    int id = (int)(dgvAsignaturas.CurrentRow.Cells[gcIdAsignatura.Index].Value);
                    oAsignatura = AsignaturaBR.GetAsignaturabyId(id);
                    setAsignatura(3);
                }
            }
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            if (Estado2 == 2 || Estado2 == 3)
            {
                if (CamposValidosAsignatura() == string.Empty)
                {
                    if (MessageBox.Show("¿Desea Guardar el Registro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LlenarAsignatura();
                        if (Estado2 == 2)
                        {
                            AsignaturaBR.InsAsignatura(oAsignatura);
                        }
                        else if (Estado2 == 3)
                        {
                            AsignaturaBR.UpdAsignatura(oAsignatura);
                        }
                        MessageBox.Show("Se guardó Satisfactoriamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setAsignatura(1);
                        bsrAsignaturas.DataSource = AsignaturaBR.GetAsignatura();
                    }
                }
                else
                {
                    MessageBox.Show(CamposValidosAsignatura(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void LlenarAsignatura()
        {
            oAsignatura.IdCurricula = (int)cboCurricula2.SelectedValue;
            oAsignatura.Descripcion = txtDescripcion2.Text.Trim().ToUpper().ToString();
        }

        private string CamposValidosAsignatura()
        {
            string mensaje = string.Empty; 
            if (txtDescripcion2.Text.Trim().ToString() == string.Empty)
            {
                mensaje += "No ha colocado el Nombre de la Asignatura." + Environment.NewLine;
            }
            if (cboCurricula2.SelectedIndex == -1)
            {
                mensaje += "No ha seleccionado la Curricula de la Asignatura." + Environment.NewLine;
            }
            return mensaje;
        }
        #endregion

        #region Ambientes
        private void setAmbiente(int estado)
        {
            if (estado == 1)//navegando
            {
                gbxAmbiente.Enabled = false;
                dgvAmbiente.Enabled = true;
            }
            else if (estado == 2) //Insertando
            {
                gbxAmbiente.Enabled = true;
                dgvAmbiente.Enabled = false;
            }
            else if (estado == 3) //modificando
            {
                gbxAmbiente.Enabled = true;
                dgvAmbiente.Enabled = false;
            }
            Estado3 = estado;
        }

        public void LimpiarAmbiente()
        {
            txtDescripcion3.Text = string.Empty;
            cboTipoAmbiente3.SelectedIndex = -1;
        }

        private void dgvAmbiente_SelectionChanged(object sender, EventArgs e)
        {
            if (bsrAmbiente.Count > 0 && dgvAmbiente.CurrentRow != null)
            {
                cboTipoAmbiente3.SelectedValue = (int)dgvAmbiente.CurrentRow.Cells[gcIdTipoAmbiente.Index].Value;
                txtDescripcion3.Text = dgvAmbiente.CurrentRow.Cells[gcAmbiente.Index].Value.ToString();
            }
        }

        private void btnNuevo3_Click(object sender, EventArgs e)
        {
            if (Estado3 == 1)
            {
                oAmbiente = new AmbienteBE();
                LimpiarAmbiente();
                setAmbiente(2);
            }
        }

        private void btnModificar3_Click(object sender, EventArgs e)
        {
            if (Estado3 == 1)
            {
                if (dgvAmbiente != null && dgvAmbiente.DataSource != null && dgvAmbiente.CurrentRow != null && bsrAmbiente.Count > 0)
                {
                    int id = (int)(dgvAmbiente.CurrentRow.Cells[gcIdAmbiente.Index].Value);
                    oAmbiente = AmbienteBR.GetAmbientebyId(id);
                    setAmbiente(3);
                }
            }
        }

        private void btnGuardar3_Click(object sender, EventArgs e)
        {
            if (Estado3 == 2 || Estado3 == 3)
            {
                if (CamposValidosAmbiente() == string.Empty)
                {
                    if (MessageBox.Show("¿Desea Guardar el Registro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LlenarAmbiente();
                        if (Estado3 == 2)
                        {
                            AmbienteBR.InsAmbiente(oAmbiente);
                        }
                        else if (Estado3 == 3)
                        {
                            AmbienteBR.UpdAmbiente(oAmbiente);
                        }
                        MessageBox.Show("Se guardó Satisfactoriamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setAmbiente(1);
                        bsrAmbiente.DataSource = AmbienteBR.GetAmbiente();
                    }
                }
                else
                {
                    MessageBox.Show(CamposValidosAmbiente(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void LlenarAmbiente()
        {
            oAmbiente.IdTipoAmbiente = (int)cboTipoAmbiente3.SelectedValue;
            oAmbiente.Descripcion = txtDescripcion3.Text.Trim().ToUpper().ToString();
        }

        private string CamposValidosAmbiente()
        {
            string mensaje = string.Empty;
            if (txtDescripcion3.Text.Trim().ToString() == string.Empty)
            {
                mensaje += "No ha colocado el Nombre de el Ambiente." + Environment.NewLine;
            }
            if (cboTipoAmbiente3.SelectedIndex == -1)
            {
                mensaje += "No ha seleccionado el Tipo de Ambiente." + Environment.NewLine;
            }
            return mensaje;
        }
        #endregion


                  
    }
}
