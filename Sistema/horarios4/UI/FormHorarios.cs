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

namespace horarios4.UI
{
    public partial class FormHorarios : Form
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

        int Estado = 1;
        HorarioBE oHorario;

        public FormHorarios()
        {
            InitializeComponent();
            InicializarData();
        }

        private void InicializarData()
        {
            bsrHorario.DataSource = HorarioBR.GetHorario();
            bsrDetalle.DataSource = HorarioBR.GetHora();
            LlenarCombo(cboCiclo, HorarioBR.GetCiclo());
            setHorario(1);
        }

        private void setHorario(int estado)
        {
            if (estado == 1)//navegando
            {
                gbxRegistro.Enabled = false;
                dgvRegistro.Enabled = false;
            }
            else if (estado == 2) //Insertando
            {
                gbxRegistro.Enabled = true;
                dgvRegistro.Enabled = true;
            }
            else if (estado == 3) //modificando
            {
                gbxRegistro.Enabled = true;
                dgvRegistro.Enabled = true;
            }
            Estado = estado;
        }

        private void CargarHorario(int IdHorario)
        {
            oHorario = HorarioBR.GetHorariobyId(IdHorario);
            cboCiclo.SelectedValue = oHorario.IdCiclo;
            txtDescripcion.Text = oHorario.Descripcion;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bsrHorario.DataSource = HorarioBR.GetHorario();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Estado == 1 && dgvHorarios.CurrentRow != null)
                {
                    CargarHorario((int)(dgvHorarios.CurrentRow.Cells[gcIdHorario.Index].Value));
                    TabGeneral.SelectTab(tabRegistro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los datos correctamente." + Environment.NewLine + ex.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= gcLunes.Index && e.ColumnIndex <= gcViernes.Index)
            { 
                var prueba = oHorario.Celdas.Where(o => o.IdDia == (e.ColumnIndex) && o.IdHora == (int)dgvRegistro.CurrentRow.Cells[gcIdHora.Index].Value).FirstOrDefault();

                if (prueba != null)
                {
                    CeldaHorario nuevo = new CeldaHorario(prueba);
                    nuevo.Show();
                }
                else
                {
                    CeldaHorarioBE o = new CeldaHorarioBE();
                    o.IdDia = e.ColumnIndex;
                    o.IdHora = (int)dgvRegistro.CurrentRow.Cells[gcIdHora.Index].Value;

                    oHorario.Celdas.Add(o);

                    CeldaHorario nuevo = new CeldaHorario(oHorario.Celdas.LastOrDefault());
                    nuevo.Show();
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {
                case "Nuevo": Nuevo(); break;
                case "Modificar": Modifcar(); break;
                case "Guardar": Guardar(); break;
            }
        }

        private void Limpiar()
        {
            cboCiclo.SelectedIndex = -1;
            txtDescripcion.Text = string.Empty;
        }

        private void LlenarDatos()
        {
            oHorario.IdCiclo = (int)cboCiclo.SelectedValue;
            oHorario.Descripcion = txtDescripcion.Text.Trim().ToUpper().ToString();
        }

        private string Validar()
        {
            string mensaje = string.Empty;

            if (txtDescripcion.Text.Trim().ToString() == string.Empty)
            {
                mensaje += "No ha Una Descripción." + Environment.NewLine;
            }
            if (cboCiclo.SelectedValue == null || (int)cboCiclo.SelectedValue == 0)
            {
                mensaje += "No ha selccionado un ciclo." + Environment.NewLine;
            }
            if (oHorario.Celdas.Count == 0)
            {
                mensaje += "Debe haber como mínimo una Clase." + Environment.NewLine;
            }
            return mensaje;
        }

        private void Nuevo()
        {
            if (Estado == 1)
            {
                oHorario = new HorarioBE();
                Limpiar();

                TabGeneral.SelectTab(tabRegistro);
                setHorario(2);
            }            
        }

        private void Modifcar()
        {
            if (Estado == 1)
            {
                if (oHorario != null)
                {
                    TabGeneral.SelectTab(tabRegistro);
                    setHorario(3);
                }
            }
        }

        private void Guardar()
        {
            if (Estado == 2 || Estado == 3)
            {
                if (oHorario.Celdas != null && Validar() == string.Empty)
                {
                    if (MessageBox.Show("¿Desea Guardar el Registro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LlenarDatos();
                        if (Estado == 2)
                        {
                            HorarioBR.InsHorario(oHorario);
                        }
                        else if (Estado == 3)
                        {
                            HorarioBR.UpdHorario(oHorario);
                        }
                        MessageBox.Show("Se guardó Satisfactoriamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setHorario(1);
                        CargarHorario(oHorario.IdHorario);
                        bsrHorario.DataSource = HorarioBR.GetHorario();
                    }
                }
                else
                {
                    MessageBox.Show(Validar(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dgvRegistro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (oHorario != null)
            //{
            //    foreach (var o in oHorario.Celdas)
            //    {
            //        if (o.IdAmbiente != 0 && o.IdAsignatura != 0 && o.IdDocente != 0 && o.IdTipoClase != 0)
            //        {
            //            dgvRegistro.Rows[o.IdDia].DefaultCellStyle.ForeColor = Color.Red;
            //            //dgvRegistro.Rows[1].DefaultCellStyle.ForeColor = Color.Red;
            //        }
            //    }
            //}
            
            //HoraBE drRow = (HoraBE)(dgvRegistro.Rows[e.RowIndex].DataBoundItem);
            //if (drRow.IdHora == 1)
            //{
            //    e.CellStyle.ForeColor = Color.Red;
            //}
            //else if (drRow.IdHora == 2)
            //{
            //    e.CellStyle.ForeColor = Color.DarkBlue;
            //}
        }
    }
}
