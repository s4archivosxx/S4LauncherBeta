namespace S4LauncherBeta
{
    partial class S4LauncherBeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S4LauncherBeta));
            this.bntexit = new System.Windows.Forms.Button();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.Portada = new System.Windows.Forms.PictureBox();
            this.lblversion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Portada)).BeginInit();
            this.SuspendLayout();
            // 
            // bntexit
            // 
            this.bntexit.BackColor = System.Drawing.Color.DodgerBlue;
            this.bntexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntexit.Font = new System.Drawing.Font("Courier New", 13.25F, System.Drawing.FontStyle.Bold);
            this.bntexit.ForeColor = System.Drawing.Color.White;
            this.bntexit.Location = new System.Drawing.Point(161, 12);
            this.bntexit.Name = "bntexit";
            this.bntexit.Size = new System.Drawing.Size(34, 28);
            this.bntexit.TabIndex = 0;
            this.bntexit.Text = "X";
            this.bntexit.UseVisualStyleBackColor = false;
            this.bntexit.Click += new System.EventHandler(this.Bntexit_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Font = new System.Drawing.Font("Courier New", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnminimize.ForeColor = System.Drawing.Color.White;
            this.btnminimize.Location = new System.Drawing.Point(121, 12);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(34, 28);
            this.btnminimize.TabIndex = 1;
            this.btnminimize.Text = "-";
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.Btnminimize_Click);
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Font = new System.Drawing.Font("Courier New", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnstart.ForeColor = System.Drawing.Color.White;
            this.btnstart.Location = new System.Drawing.Point(12, 210);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(183, 34);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "START GAME";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.Btnstart_Click);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.Font = new System.Drawing.Font("Courier New", 15.25F, System.Drawing.FontStyle.Bold);
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.Location = new System.Drawing.Point(12, 250);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(183, 34);
            this.btnregister.TabIndex = 4;
            this.btnregister.Text = "REGISTER";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Visible = false;
            this.btnregister.Click += new System.EventHandler(this.Btnregister_Click);
            // 
            // Portada
            // 
            this.Portada.BackgroundImage = global::S4LauncherBeta.Properties.Resources.S4;
            this.Portada.Location = new System.Drawing.Point(12, 53);
            this.Portada.Name = "Portada";
            this.Portada.Size = new System.Drawing.Size(183, 69);
            this.Portada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Portada.TabIndex = 5;
            this.Portada.TabStop = false;
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.BackColor = System.Drawing.Color.Transparent;
            this.lblversion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblversion.ForeColor = System.Drawing.Color.White;
            this.lblversion.Location = new System.Drawing.Point(8, 140);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(180, 22);
            this.lblversion.TabIndex = 6;
            this.lblversion.Text = "Versión del Launcher :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Disfruta S4League \r\nen su versión BETA";
            // 
            // S4LauncherBeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(207, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblversion);
            this.Controls.Add(this.Portada);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.bntexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "S4LauncherBeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S4LBeta";
            this.Load += new System.EventHandler(this.S4LBeta_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.S4LBeta_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.S4LBeta_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.S4LBeta_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Portada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntexit;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.PictureBox Portada;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label label1;
    }
}

