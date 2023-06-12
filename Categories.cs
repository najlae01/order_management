using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommerciale
{
    public partial class Categories : Form
    {
        Functions Con;
        public Categories()
        {
            InitializeComponent();
            Con = new Functions();
            ListerCategories();
        }

        private void ListerCategories()
        {
            string Req = "Select * from Categorie";
            CategorieList.DataSource = Con.RecupererDonnees(Req);
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(NomTb.Text == "" || RemTb.Text == "")
                {
                    MessageBox.Show("Please Fill In!");
                }
                else
                {
                    string Nom = NomTb.Text;
                    string Rem = RemTb.Text;
                    string Req = "insert into Categorie values('{0},'{1})";
                    Req = string .Format(Req, Nom, Rem);
                    Con.EnvoyerDonnees(Req);
                    ListerCategories();
                    MessageBox.Show("category added!");
                    NomTb.Text = "";
                    RemTb.Text = "";
                }
            }
            catch (Exception Ex){
                MessageBox.Show(Ex.Message);
            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {

        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {

        }

        int Key = 0;
        private void CategorieList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomTb.Text = CategorieList.SelectedRows[0].Cells[1].ToString();
            RemTb.Text = CategorieList.SelectedRows[1].Cells[2].ToString();
            if(NomTb.Text == "")
            {
                Key = Convert.ToInt32(CategorieList.SelectedRows[0].Cells[0].ToString());
            }
        }
    }
}
