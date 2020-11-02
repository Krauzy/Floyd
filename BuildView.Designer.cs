namespace Floyd
{
    partial class BuildView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuild = new System.Windows.Forms.TextBox();
            this.btResolve = new System.Windows.Forms.Button();
            this.rbVirgula = new System.Windows.Forms.RadioButton();
            this.rbEspaco = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtBuild
            // 
            this.txtBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuild.Location = new System.Drawing.Point(12, 12);
            this.txtBuild.Multiline = true;
            this.txtBuild.Name = "txtBuild";
            this.txtBuild.Size = new System.Drawing.Size(248, 203);
            this.txtBuild.TabIndex = 0;
            // 
            // btResolve
            // 
            this.btResolve.BackColor = System.Drawing.Color.Green;
            this.btResolve.FlatAppearance.BorderSize = 0;
            this.btResolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btResolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResolve.ForeColor = System.Drawing.Color.White;
            this.btResolve.Location = new System.Drawing.Point(12, 277);
            this.btResolve.Name = "btResolve";
            this.btResolve.Size = new System.Drawing.Size(248, 32);
            this.btResolve.TabIndex = 1;
            this.btResolve.Text = "Resolver";
            this.btResolve.UseVisualStyleBackColor = false;
            this.btResolve.Click += new System.EventHandler(this.btResolve_Click);
            // 
            // rbVirgula
            // 
            this.rbVirgula.AutoSize = true;
            this.rbVirgula.Location = new System.Drawing.Point(12, 221);
            this.rbVirgula.Name = "rbVirgula";
            this.rbVirgula.Size = new System.Drawing.Size(130, 17);
            this.rbVirgula.TabIndex = 2;
            this.rbVirgula.TabStop = true;
            this.rbVirgula.Text = "Separado por vírgulas";
            this.rbVirgula.UseVisualStyleBackColor = true;
            // 
            // rbEspaco
            // 
            this.rbEspaco.AutoSize = true;
            this.rbEspaco.Location = new System.Drawing.Point(12, 244);
            this.rbEspaco.Name = "rbEspaco";
            this.rbEspaco.Size = new System.Drawing.Size(133, 17);
            this.rbEspaco.TabIndex = 3;
            this.rbEspaco.TabStop = true;
            this.rbEspaco.Text = "Separado por Espaços";
            this.rbEspaco.UseVisualStyleBackColor = true;
            // 
            // BuildView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(272, 317);
            this.Controls.Add(this.rbVirgula);
            this.Controls.Add(this.rbEspaco);
            this.Controls.Add(this.btResolve);
            this.Controls.Add(this.txtBuild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BuildView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floyd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuild;
        private System.Windows.Forms.Button btResolve;
        private System.Windows.Forms.RadioButton rbVirgula;
        private System.Windows.Forms.RadioButton rbEspaco;
    }
}

