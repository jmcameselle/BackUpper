using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackUpper
{
    public partial class frm : Form
    {
        bool bOriSel = false, bPatSel = false, bDestSel = false;
       
        public frm()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            fbr.ShowDialog();
            lblOrigen.Text = fbr.SelectedPath;
            if (lblOrigen.Text != "")
            {
                if ((lblOrigen.Text == lblPatron.Text) || (lblOrigen.Text == lblDestino.Text)) {
                    lblOrigen.Text = "Origen No seleccionado";
                    bOriSel = false;
                    MessageBox.Show("No puede seleccionar dos fuentes con el mismo directorio", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;                
                }
                bOriSel = true;
            }
            else
            {
                lblOrigen.Text = "Origen No seleccionado";
                bOriSel = false;
            }
            if (bOriSel && bPatSel && bDestSel) btnCopiar.Enabled = true;
            else btnCopiar.Enabled = false;
        }

        private void btnPatron_Click(object sender, EventArgs e)
        {
            fbr.ShowDialog();
            lblPatron.Text = fbr.SelectedPath;
            if (lblPatron.Text != "")
            {
                if ((lblPatron.Text == lblOrigen.Text) || (lblPatron.Text == lblDestino.Text))
                {
                    lblPatron.Text = "Patrón No seleccionado";
                    bPatSel = false;
                    MessageBox.Show("No puede seleccionar dos fuentes con el mismo directorio", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                bPatSel = true;
            }
            else
            {
                lblPatron.Text = "Patrón No seleccionado";
                bPatSel = false;
            }
            if (bOriSel && bPatSel && bDestSel) btnCopiar.Enabled = true;
            else btnCopiar.Enabled = false;
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            fbr.ShowDialog();
            lblDestino.Text = fbr.SelectedPath;
            if (lblDestino.Text != "")
            {
                if ((lblDestino.Text == lblOrigen.Text) || (lblDestino.Text == lblPatron.Text))
                {
                    lblDestino.Text = "Destino No seleccionado";
                    bDestSel = false;
                    MessageBox.Show("No puede seleccionar dos fuentes con el mismo directorio", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                bDestSel = true;
            }
            else
            {
                lblDestino.Text = "Destino No seleccionado";
                bDestSel = false;
            }
            if (bOriSel && bPatSel && bDestSel) btnCopiar.Enabled = true;
            else btnCopiar.Enabled = false;
        }

        private void lblOrigen_Click(object sender, EventArgs e)
        {
            btnSource.PerformClick();   
        }

        private void lblPatron_Click(object sender, EventArgs e)
        {
            btnPatron.PerformClick();
        }

        private void lblDestino_Click(object sender, EventArgs e)
        {
            btnDestino.PerformClick();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {        
            DirectoryInfo dirPat = new DirectoryInfo(lblPatron.Text);

            DoCopyFromOrigyn(dirPat);

            if (MessageBox.Show("Copia Terminada. Abrir Destino?", "BackUpper", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                System.Diagnostics.Process.Start("explorer.exe", lblDestino.Text);
            }

        }

        private void DoCopyFromOrigyn(DirectoryInfo dPat)
        {
           //ruta en la que nos encontramos a partir de la raiz del Patrón
           string sCurrentRelativePath = dPat.FullName.Replace(lblPatron.Text,"");
           bool bExistPath = Directory.Exists(lblDestino.Text + sCurrentRelativePath);
            try
            {

               FileInfo[] oFiles = dPat.GetFiles();
                foreach (FileInfo oFile in oFiles)
                {

                    //selecciona el mismo archivo de el origen
                    FileInfo fOri = new FileInfo(lblOrigen.Text + sCurrentRelativePath + "\\" + oFile.Name);
                    if (fOri.Exists)
                    {
                        //crea el nuevo path en destino si aún no existe. Se hace aquí para solo crearlo en caso de
                        //que haya almenos una correspondencia
                        if (!bExistPath)
                        {
                            Directory.CreateDirectory(lblDestino.Text + sCurrentRelativePath);
                            bExistPath = true;
                        }
                        //lo copia en el path destino
                        fOri.CopyTo(lblDestino.Text + sCurrentRelativePath + "\\" + fOri.Name);
                    }
                }             
                //procesa las subcarpetas 
                foreach (DirectoryInfo dSubFolder in dPat.GetDirectories())
                {
                   DoCopyFromOrigyn(dSubFolder);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                //sin permisos para la selección
            }
        }

    
    }
}
