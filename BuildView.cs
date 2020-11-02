using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floyd
{
    public partial class BuildView : Form
    {
        public BuildView()
        {
            InitializeComponent();
            rbEspaco.Checked = true;
        }

        private bool check(int[][] mat)
        {
            for(int i = 0; i < mat.Length; i++)
            {
                if(mat.Length != mat[i].Length)
                {
                    MessageBox.Show("O número de linhas é diferente que o número de colunas!", "Erro na construção da matriz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
            
        private void btResolve_Click(object sender, EventArgs e)
        {
            string[] split = txtBuild.Text.Split('\n');
            int[][] mat = new int[split.Length][];
            for(int i = 0; i < split.Length; i++)
            {
                string[] values = split[i].Split(rbEspaco.Checked ? ' ' : ',');
                mat[i] = new int[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    if (values[j].Trim() == "-")
                        mat[i][j] = 150000;
                    else
                        mat[i][j] = Convert.ToInt32(values[j].Trim());
                }
            }

            if (this.check(mat))
            {
                Resolve ex = new Resolve(mat);
                this.Visible = false;
                ex.ShowDialog();
                this.Visible = true;
            }                
        }
    }
}
