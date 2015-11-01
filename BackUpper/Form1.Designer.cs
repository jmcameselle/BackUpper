namespace BackUpper
{
    partial class frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm));
            this.fbr = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSource = new System.Windows.Forms.Button();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblPatron = new System.Windows.Forms.Label();
            this.btnPatron = new System.Windows.Forms.Button();
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnDestino = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(12, 24);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 23);
            this.btnSource.TabIndex = 0;
            this.btnSource.Text = "ORIGEN";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // lblOrigen
            // 
            this.lblOrigen.Location = new System.Drawing.Point(116, 29);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(426, 13);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen No seleccionado";
            this.lblOrigen.Click += new System.EventHandler(this.lblOrigen_Click);
            // 
            // lblPatron
            // 
            this.lblPatron.Location = new System.Drawing.Point(116, 68);
            this.lblPatron.Name = "lblPatron";
            this.lblPatron.Size = new System.Drawing.Size(426, 13);
            this.lblPatron.TabIndex = 3;
            this.lblPatron.Text = "Patrón No seleccionado";
            this.lblPatron.Click += new System.EventHandler(this.lblPatron_Click);
            // 
            // btnPatron
            // 
            this.btnPatron.Location = new System.Drawing.Point(12, 63);
            this.btnPatron.Name = "btnPatron";
            this.btnPatron.Size = new System.Drawing.Size(75, 23);
            this.btnPatron.TabIndex = 2;
            this.btnPatron.Text = "PATRÓN";
            this.btnPatron.UseVisualStyleBackColor = true;
            this.btnPatron.Click += new System.EventHandler(this.btnPatron_Click);
            // 
            // lblDestino
            // 
            this.lblDestino.Location = new System.Drawing.Point(116, 103);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(426, 13);
            this.lblDestino.TabIndex = 5;
            this.lblDestino.Text = "Destino No seleccionado";
            this.lblDestino.Click += new System.EventHandler(this.lblDestino_Click);
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(12, 98);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(75, 23);
            this.btnDestino.TabIndex = 4;
            this.btnDestino.Text = "DESTINO";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Enabled = false;
            this.btnCopiar.Location = new System.Drawing.Point(12, 155);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(267, 23);
            this.btnCopiar.TabIndex = 6;
            this.btnCopiar.Text = "COPIAR";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(552, 261);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.lblPatron);
            this.Controls.Add(this.btnPatron);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.btnSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm";
            this.Text = "BackUpper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbr;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblPatron;
        private System.Windows.Forms.Button btnPatron;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Button btnCopiar;
    }
}

