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
    public partial class CeldaHorario : Form
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

        CeldaHorarioBE oCelda = new CeldaHorarioBE();

        public CeldaHorario(CeldaHorarioBE nuevo)
        {
            InitializeComponent();
            oCelda = nuevo;
            CargarDatos();
        }

        private void CargarDatos()
        {
            LlenarCombo(cboDocente, DocenteBR.ListDocente());
            LlenarCombo(cboAsignatura, AsignaturaBR.ListAsignatura());
            LlenarCombo(cboAmbiente, AmbienteBR.ListAmbiente());
            LlenarCombo(cboTipoClase, HorarioBR.ListTipoClase());

            if (oCelda.IdDia != 0 && oCelda.IdHora != 0)
            {
                CargarClase(oCelda);
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validar() == string.Empty)
            {
                GuardarClase(oCelda);
            }
            else
            {
                MessageBox.Show(Validar(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private string Validar()
        {
            string mensaje = string.Empty;

            if (cboDocente.SelectedValue == null)
            {
                mensaje += "No ha elegido un Docente." + Environment.NewLine;
            }
            if (cboAsignatura.SelectedValue == null)
            {
                mensaje += "No ha elegido una Asignatura." + Environment.NewLine;
            }
            if (cboAmbiente.SelectedValue == null)
            {
                mensaje += "No ha elegido un Ambiente." + Environment.NewLine;
            }
            if (cboTipoClase.SelectedValue == null)
            {
                mensaje += "No ha elegido un Tipo de Clase." + Environment.NewLine;
            }
            return mensaje;
        }

        private void GuardarClase(CeldaHorarioBE Celda)
        {
            Celda.IdDocente= (int)cboDocente.SelectedValue;
            Celda.IdAsignatura = (int)cboAsignatura.SelectedValue;
            Celda.IdAmbiente = (int)cboAmbiente.SelectedValue;
            Celda.IdTipoClase = (int)cboTipoClase.SelectedValue;
        }

        private void CargarClase(CeldaHorarioBE Celda)
        {
            cboDocente.SelectedValue = Celda.IdDocente;
            cboAsignatura.SelectedValue = Celda.IdAsignatura;
            cboAmbiente.SelectedValue = Celda.IdAmbiente;
            cboTipoClase.SelectedValue = Celda.IdTipoClase;
        }
    }
}
