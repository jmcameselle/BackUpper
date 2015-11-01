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
            if(lblOrigen.Text!="") bOriSel = true;
            if (bOriSel && bPatSel && bDestSel) btnCopiar.Enabled = true;
        }

        private void btnPatron_Click(object sender, EventArgs e)
        {
            fbr.ShowDialog();
            lblPatron.Text = fbr.SelectedPath;
            if (lblPatron.Text!= "") bPatSel=true;
            if (bOriSel && bPatSel && bDestSel) btnCopiar.Enabled = true;
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            fbr.ShowDialog();
            lblDestino.Text = fbr.SelectedPath;
            if (lblDestino.Text != "") bDestSel = true;
            if (bOriSel && bPatSel && bDestSel) btnCopiar.Enabled = true;
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
           //ruta en la que nos encontramos a partir de la raiz del patron
           string sCurrentRelativePath = dPat.FullName.Replace(lblPatron.Text,"");
           FileInfo[] oFiles = dPat.GetFiles();
            //crea el nuevo path en destino
            Directory.CreateDirectory(lblDestino.Text + sCurrentRelativePath);
            foreach (FileInfo oFile in oFiles)
            {

                //selecciona el mismo archivo de el origen
                FileInfo fOri = new FileInfo(lblOrigen.Text + sCurrentRelativePath + "\\" + oFile.Name);
                if (fOri.Exists)
                {
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

    
    }
}
