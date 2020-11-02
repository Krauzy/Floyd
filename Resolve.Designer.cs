namespace Floyd
{
    partial class Resolve
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.group = new System.Windows.Forms.GroupBox();
            this.dataDist = new System.Windows.Forms.DataGridView();
            this.dataSolve = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.Label();
            this.btCalcula = new System.Windows.Forms.Button();
            this.txtCusto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSolve)).BeginInit();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.Controls.Add(this.txtCusto);
            this.group.Controls.Add(this.label7);
            this.group.Controls.Add(this.btCalcula);
            this.group.Controls.Add(this.txtPath);
            this.group.Controls.Add(this.label5);
            this.group.Controls.Add(this.txtDestino);
            this.group.Controls.Add(this.label4);
            this.group.Controls.Add(this.txtOrigem);
            this.group.Controls.Add(this.label3);
            this.group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group.Location = new System.Drawing.Point(216, 38);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(376, 98);
            this.group.TabIndex = 3;
            this.group.TabStop = false;
            // 
            // dataDist
            // 
            this.dataDist.AllowUserToAddRows = false;
            this.dataDist.AllowUserToDeleteRows = false;
            this.dataDist.AllowUserToResizeColumns = false;
            this.dataDist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataDist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDist.BackgroundColor = System.Drawing.Color.White;
            this.dataDist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataDist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDist.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataDist.EnableHeadersVisualStyles = false;
            this.dataDist.Location = new System.Drawing.Point(48, 38);
            this.dataDist.Name = "dataDist";
            this.dataDist.ReadOnly = true;
            this.dataDist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataDist.RowHeadersVisible = false;
            this.dataDist.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataDist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataDist.Size = new System.Drawing.Size(350, 300);
            this.dataDist.TabIndex = 4;
            // 
            // dataSolve
            // 
            this.dataSolve.AllowUserToAddRows = false;
            this.dataSolve.AllowUserToDeleteRows = false;
            this.dataSolve.AllowUserToResizeColumns = false;
            this.dataSolve.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataSolve.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataSolve.BackgroundColor = System.Drawing.Color.White;
            this.dataSolve.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSolve.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSolve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataSolve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataSolve.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataSolve.EnableHeadersVisualStyles = false;
            this.dataSolve.Location = new System.Drawing.Point(404, 38);
            this.dataSolve.Name = "dataSolve";
            this.dataSolve.ReadOnly = true;
            this.dataSolve.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataSolve.RowHeadersVisible = false;
            this.dataSolve.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataSolve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataSolve.Size = new System.Drawing.Size(350, 300);
            this.dataSolve.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(185, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Distância";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(543, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Solução";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "ORIGEM:";
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(71, 15);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(30, 20);
            this.txtOrigem.TabIndex = 9;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(184, 15);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(30, 20);
            this.txtDestino.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(119, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "DESTINO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(10, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "CAMINHO:";
            // 
            // txtPath
            // 
            this.txtPath.AutoSize = true;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPath.Location = new System.Drawing.Point(82, 70);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(35, 15);
            this.txtPath.TabIndex = 13;
            this.txtPath.Text = "path";
            // 
            // btCalcula
            // 
            this.btCalcula.BackColor = System.Drawing.Color.Green;
            this.btCalcula.FlatAppearance.BorderSize = 0;
            this.btCalcula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCalcula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcula.ForeColor = System.Drawing.Color.White;
            this.btCalcula.Location = new System.Drawing.Point(267, 13);
            this.btCalcula.Name = "btCalcula";
            this.btCalcula.Size = new System.Drawing.Size(88, 23);
            this.btCalcula.TabIndex = 14;
            this.btCalcula.Text = "CALCULAR";
            this.btCalcula.UseVisualStyleBackColor = false;
            this.btCalcula.Click += new System.EventHandler(this.btCalcula_Click);
            // 
            // txtCusto
            // 
            this.txtCusto.AutoSize = true;
            this.txtCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCusto.Location = new System.Drawing.Point(67, 48);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(15, 15);
            this.txtCusto.TabIndex = 16;
            this.txtCusto.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(10, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "CUSTO:";
            // 
            // Resolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 147);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.group);
            this.Controls.Add(this.dataSolve);
            this.Controls.Add(this.dataDist);
            this.Name = "Resolve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floyd";
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSolve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.DataGridView dataDist;
        private System.Windows.Forms.DataGridView dataSolve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtPath;
        private System.Windows.Forms.Button btCalcula;
        private System.Windows.Forms.Label txtCusto;
        private System.Windows.Forms.Label label7;
    }
}