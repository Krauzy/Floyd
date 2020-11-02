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
    public partial class Resolve : Form
    {
        private int[][] distance;
        private int[][] solution;
        private int TL;
        private readonly char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K' };

        public Resolve(int[][] mat)
        {
            InitializeComponent();
            this.distance = mat;
            this.TL = mat.Length;
            Solve();
        }

        private void Solve()
        {
            solution = new int[distance.Length][];
            for(int i = 0; i < distance.Length; i++)
            {
                solution[i] = new int[distance[i].Length];
                for(int j = 0; j < distance[i].Length; j++)                
                    solution[i][j] = 0;                
            }
            //
            for(int k = 0; k < TL; k++)
            {
                for(int i = 0; i < TL; i++)
                {
                    for(int j = 0; j < TL; j++)
                    {
                        if (distance[i][j] > (distance[i][k] + distance[k][j]))
                        {
                            distance[i][j] = distance[i][k] + distance[k][j];
                            solution[i][j] = k + 1;
                        }
                    }
                }
            }
            //
            int size = 350 / TL;
            for(int i = 0; i < TL; i++)
            {
                int d = dataDist.Columns.Add("dist" + letters[i], letters[i].ToString());
                dataDist.Columns[d].Width = size;
                int s = dataSolve.Columns.Add("solve" + letters[i], letters[i].ToString());
                dataSolve.Columns[s].Width = size;
            }
            //
            for(int i = 0; i < TL; i++)
            {
                int d = dataDist.Rows.Add();
                int s = dataSolve.Rows.Add();
                for (int j = 0; j < TL; j++)
                {
                    dataDist.Rows[d].Cells[j].Value = distance[i][j];
                    if (solution[i][j] > 0)
                        dataSolve.Rows[s].Cells[j].Value = letters[solution[i][j] - 1].ToString();
                    else
                        dataSolve.Rows[s].Cells[j].Value = solution[i][j];
                }
            }
            group.Location = new Point(group.Location.X, group.Location.Y + (TL * 30));
            this.Height = this.Height + (TL * 30);
        }

        private void btCalcula_Click(object sender, EventArgs e)
        {
            if(txtDestino.Text != string.Empty && txtOrigem.Text != string.Empty)
            {
                char dest = txtDestino.Text[0];
                char orig = txtOrigem.Text[0];
                int d = 0;
                int o = 0;
                for(int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == dest)
                        d = i;

                    if (letters[i] == orig)
                        o = i;
                }
                txtCusto.Text = this.distance[o][d].ToString();
                string path = orig + " -> ";
                int x = o;
                do
                {
                    if (this.solution[x][d] == 0)
                    {
                        path += dest.ToString();
                        x = 0;
                    }
                    else
                    {
                        x = this.solution[x][d];
                        path += letters[x - 1] + " -> ";
                    }
                } while (x != 0);
                txtPath.Text = path;
            }
        }
    }
}
