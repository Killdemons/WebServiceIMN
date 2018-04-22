using DemoWebService.WebServiceIMN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWebService
{
    public partial class FrmPronosticos : Form
    {
        public FrmPronosticos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void FrmPronostico_Load(object sender, EventArgs e)
        {
            CargarEfemerides();
            CargarRegiones();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

        }

        private void CargarRegiones()
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            PRONOSTICO_REGIONAL reg = ws.pronosticoRegional(new pronosticoRegion()).ParseXML<PRONOSTICO_REGIONAL>();
            boxRegiones.DataSource = reg.REGIONES;
        }

        private void CargarEfemerides()
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            EFEMERIDES ef = ws.efemerides(new efemerides()).ParseXML<EFEMERIDES>();
            lblSolSale.Text = String.Format("Sale: {0}", Convert.ToDateTime(ef.EFEMERIDE_SOL.SALE).ToString("hh:mm tt"));
            lblSolPone.Text = String.Format("Pone: {0}", Convert.ToDateTime(ef.EFEMERIDE_SOL.SEPONE).ToString("hh:mm tt"));

            lblLunaSale.Text = String.Format("Sale: {0}", Convert.ToDateTime(ef.EFEMERIDE_LUNA.SALE).ToString("hh:mm tt"));
            if (!ef.EFEMERIDE_LUNA.SEPONE.Equals("null"))
            {
                lblLunaPone.Text = String.Format("Pone: {0}", Convert.ToDateTime(ef.EFEMERIDE_LUNA.SEPONE).ToString("hh:mm tt"));
            }
            

            lblFaseLunar.Text = ef.FASELUNAR.Value;
        }

        private void SeleccionRegion(object sender, EventArgs e)
        {
            WSMeteorologicoClient ws = new WSMeteorologicoClient("WSMeteorologico");
            if (boxRegiones.SelectedIndex >= 0)
            {
                int id = (boxRegiones.SelectedItem as PRONOSTICO_REGIONALREGION)?.idRegion ?? -1;
                if (id != -1)
                {
                    pnlMañanaR.Hide();
                    pnlTardeR.Hide();
                    pnlNocheR.Hide();
                    PRONOSTICO_REGIONAL reg = ws.pronosticoRegionalxID(id).ParseXML<PRONOSTICO_REGIONAL>();
                    if (reg.REGIONES[0].ESTADOMANANA != null)
                    {
                        pbxImagenM.ImageLocation = String.Format("https://www.imn.ac.cr{0}", reg.REGIONES[0].ESTADOMANANA.imgPath);
                        lblComentarioM.Text = reg.REGIONES[0].COMENTARIOMANANA;
                        lblTituloM.Text = reg.REGIONES[0].ESTADOMANANA.Value;
                        pnlMañanaR.Show();
                    }

                    if (reg.REGIONES[0].ESTADOTARDE != null)
                    {
                        pbxImagenT.ImageLocation = String.Format("https://www.imn.ac.cr{0}", reg.REGIONES[0].ESTADOTARDE.imgPath);
                        lblComentarioT.Text = reg.REGIONES[0].COMENTARIOTARDE;
                        lblTituloT.Text = reg.REGIONES[0].ESTADOTARDE.Value;
                        pnlTardeR.Show();
                    }
                    if (reg.REGIONES[0].ESTADONOCHE != null)
                    {
                        pbxImagenN.ImageLocation = String.Format("https://www.imn.ac.cr{0}", reg.REGIONES[0].ESTADONOCHE.imgPath);
                        lblComentarioN.Text = reg.REGIONES[0].COMENTARIONOCHE;
                        lblTituloN.Text = reg.REGIONES[0].ESTADONOCHE.Value;
                        pnlNocheR.Show();
                    }
                    CargarCiudades(reg.REGIONES[0].CIUDADES);
                }
            }
        }

        private void CargarCiudades(PRONOSTICO_REGIONALREGIONCIUDAD[] ciudades)
        {
            boxCiudad.DataSource = ciudades;
        }


        private void SeleccionCiudad(object sender, EventArgs e)
        {
            PRONOSTICO_REGIONALREGIONCIUDAD ciudad = boxCiudad.SelectedItem as PRONOSTICO_REGIONALREGIONCIUDAD;
            pnlMañanaC.Hide();
            pnlTardeC.Hide();
            pnlNocheC.Hide();
            if (ciudad.ESTADOMANANA != null) {
                pbxCM.ImageLocation = String.Format("https://www.imn.ac.cr{0}", ciudad.ESTADOMANANA.imgPath);
                lblCCM.Text = ciudad.COMENTARIOMANANA;
                lblCTM.Text = ciudad.ESTADOMANANA.Value;
                pnlMañanaC.Show();
            }

            if (ciudad.ESTADOTARDE != null)
            {
                pbxCT.ImageLocation = String.Format("https://www.imn.ac.cr{0}", ciudad.ESTADOTARDE.imgPath);
                lblCCT.Text = ciudad.COMENTARIOTARDE;
                lblCTT.Text = ciudad.ESTADOTARDE.Value;
                pnlTardeC.Show();
            }

            if (ciudad.ESTADONOCHE != null)
            {
                pbxCN.ImageLocation = String.Format("https://www.imn.ac.cr{0}", ciudad.ESTADONOCHE.imgPath);
                lblCCN.Text = ciudad.COMENTARIONOCHE;
                lblCTN.Text = ciudad.ESTADONOCHE.Value;
                pnlNocheC.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea Salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
                Close();
            }

        }

        private void boxEfeSol_CheckedChanged(object sender, EventArgs e)
        {
            if (boxEfeSol.Checked)
            {
                groupBox1.Visible = true;
                this.Size = new Size(797, this.Size.Height);
            }
            if (!boxEfeSol.Checked)
            {
                groupBox1.Visible = false;
                if (!boxEfeLuna.Checked && !boxFaseLunar.Checked)
                {
                    this.Size = new Size(629, this.Size.Height);
                }
            }
        }

        private void boxEfeLuna_CheckedChanged(object sender, EventArgs e)
        {
            if (boxEfeLuna.Checked)
            {
                groupBox2.Visible = true;
                this.Size = new Size(797, this.Size.Height);
            }
            if (!boxEfeLuna.Checked)
            {
                groupBox2.Visible = false;
                if (!boxFaseLunar.Checked && !boxEfeSol.Checked)
                {
                    this.Size = new Size(629, this.Size.Height);
                }
            }
        }

        private void boxFaseLunar_CheckedChanged(object sender, EventArgs e)
        {
            if (boxFaseLunar.Checked)
            {
                groupBox3.Visible = true;
                this.Size = new Size(797, this.Size.Height);
            }
            if (!boxFaseLunar.Checked)
            {
                groupBox3.Visible = false;
                if(!boxEfeLuna.Checked && !boxEfeSol.Checked)
                {
                    this.Size = new Size(629, this.Size.Height);
                }
            }
        }
    }

}
