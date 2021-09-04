using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using DAOGestionCommande.DAO.DAOImp;
using DAOGestionCommande.Entities;
namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        
        
        
        List<Commande> listCommande = new List<Commande>();
        List<Produit> listProduit = new List<Produit>();
        List<String> charge = new List<String>();
        List<exProduit> charge1 = new List<exProduit>();
        Int32[] qtee = new Int32[100];
        Client client;
       
        Produit p;
        String la = "datasource = localhost; username = root; password=; database = gestiondescommandes";
        BindingSource source = new BindingSource();
       

        MutatTextBox[][] tabTextBox = new MutatTextBox[100][];
        MutatComboBox[] tabComBox = new MutatComboBox[100];

        int nbt = 0;
        int LDown = 1;
        int longueurTextBox = 70;
        int largeurColonne = 100;
        int hauteurColonne = 25;
        public Form1()
        {
            InitializeComponent();
           modeconsol();
            
        }


        void newTextRow(int rowIndex)
        {
            tabTextBox[rowIndex] = new MutatTextBox[4];
            MutatComboBox tt = new MutatComboBox(rowIndex);

            tt.TextChanged += new EventHandler(TraiterComb);
            tt.Width = longueurTextBox;
            DAOImpProduit p = new DAOImpProduit(la);
            listProduit = p.Liste_produit();
            foreach(Produit pro in listProduit)
            {
                tt.Items.Add(pro.LibelleProd);
            }
           
            panel1.Controls.Add(tt);
            tabComBox[nbt] = tt;
            tt.Location = new Point(42 + (largeurColonne * 0), 30 + (hauteurColonne * rowIndex));
            for (int c = 1; c < 4; c++)
            {
                MutatTextBox txt = new MutatTextBox(rowIndex, c);
                txt.Width = longueurTextBox;
                panel1.Controls.Add(txt);
                txt.Location = new Point(42 + (largeurColonne * c), 30 + (hauteurColonne * rowIndex));
                tabTextBox[rowIndex][c] = txt;
                newC.Location = new Point(newC.Location.X, hauteurColonne * (LDown + 1));


            } tabTextBox[rowIndex][1].TextChanged += new EventHandler(TraiterText);
        }
        private void TraiterText(object sender, EventArgs e)
        {
            bool test;
            int a = 0, b;
            errorProvider1.Clear();

            try
            {
                a = Convert.ToInt32(((MutatTextBox)sender).Text);
                b = Convert.ToInt32(tabTextBox[((MutatTextBox)sender).colonne][2].Text);
                exProduit pppp = charge1.Last<exProduit>();
                pppp.qte = a;
                BindingSource source1 = new BindingSource();
                source1.DataSource = charge1;
                dataGridView2.DataSource = source1;
               
                dataGridView2.Rows[charge1.Count-1].Cells[3].Value = a;
                tabTextBox[nbt][3].Text = (a * b) + ""; test = true;
            }
            catch (FormatException)
            {
                errorProvider1.SetError(((MutatTextBox)sender), "entrez un numero svp");
                test = false;
            }
            if (test)
            {
                //  p = pproduit.rechercherProduit(((MutatComboBox)sender).Text);
                //  p.QteStock = --a;
                //cm = new Commande("1234" + nbt, System.DateTime.Now +"",client.CodeClt);
                //listCommande.Add(cm);
                // lc = new LigneCommande("1234" + nbt,p.CodeProd, Convert.ToInt32(((MutatTextBox)sender).Text));
                //   source.ResetBindings(false);
                //dataGridView1.Rows[dataGridView1.RowCount - 2].Selected = true;

            }
        }
        class exProduit:Produit
        {
            public Int32 qte;
            public exProduit(String y,String b,Double c,int d,Int32 g)
                :base(y,b,c,d)
            {
                qte = g;
            }

        }

        private void TraiterComb(object sender, EventArgs e)
        {
            tabTextBox[((MutatComboBox)sender).ligne][2].Enabled = tabTextBox[((MutatComboBox)sender).ligne][3].Enabled = false;
            DAOImpProduit pp = new DAOImpProduit(la);
            tabTextBox[((MutatComboBox)sender).ligne][1].Text = "";
            tabTextBox[((MutatComboBox)sender).ligne][3].Text = "0";
            p = pp.rechercherProduit(((MutatComboBox)sender).Text);
            tabTextBox[((MutatComboBox)sender).ligne][2].Text = Convert.ToString(p.PrixUnitaire);
            
            exProduit exp = new exProduit(p.CodeProd, p.LibelleProd, p.PrixUnitaire, p.QteStock,0);
            charge1.Add(exp);
            
        }
        /*    void affichecommande()
            {
                try
                {
                    listCompte = pcommade.afficheliste();
                    source.DataSource = listCompte;
                }
                catch (Exception e) { MessageBox.Show("problem de connection"); }
                dataGridView1.DataSource = source;
                dataGridView1.Rows[dataGridView1.RowCount - 2].Selected = true;
                CodeCm.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                datec.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
             
            }*/
        private void Form1_Load(object sender, EventArgs e)
        {
            newC.Visible = false;
           
        }

        private void newC_Click(object sender, EventArgs e)
        {
            if ((tabTextBox[nbt][1].Text == "") || (tabTextBox[nbt][1].Text == "0"))
            {
                errorProvider1.SetError(tabTextBox[nbt][1], "commande vide");
                errorProvider1.SetError(tabTextBox[nbt][2], "commande vide");
                errorProvider1.SetError(tabTextBox[nbt][3], "commande vide");
            }
            else
            {
                newTextRow(LDown++);
                tabTextBox[nbt][1].Enabled = false;
                tabComBox[nbt - 1].Enabled = false;
               total.Text=(Convert.ToInt32(total.Text)+(Convert.ToInt32((tabTextBox[nbt][3].Text))))+"";
               nbt++;
               /*label2.Text = tabComBox[nbt - 1].SelectedValue.ToString();
                    rech r = new rech(tabComBox[nbt - 1].Text,tabTextBox[nbt][1].Text);
                    charge.Add(r);*/
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        class MutatTextBox : TextBox
        {
            public int ligne;
            public int colonne;
            public MutatTextBox(int l, int c)
                : base()
            {
                ligne = l;
                colonne = c;
            }
        }
        class MutatComboBox : ComboBox
        {
            public int ligne;
            public MutatComboBox(int l)
                : base()
            {
                ligne = l;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void supprimercmd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous supprimer", "supprime", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAOImpCommand com = new DAOImpCommand(la);
                com.supprimerCommmande(CodeCm.Text);
                DAOImpLigneCommande li = new DAOImpLigneCommande(la);
                li.del();
                modeconsol();
            }
        }

        public void modeconsol()
        {
            tabTextBox = new MutatTextBox[100][];
          tabComBox = new MutatComboBox[100];

            nbt = 0;
           LDown = 1;
            valider.Visible = false;
            ajoutcmd.Visible = mdifiercmd.Visible = supprimercmd.Visible = true;
            ajoutcmd.Enabled = mdifiercmd.Enabled = supprimercmd.Enabled = false;
            DAOImpClient C = new DAOImpClient(la);
            client = C.rechercherClient("2341692");
            codeClient.Text = "2341692";
            nomCl.Text = client.Nom + " " + client.Prenom;
            DAOImpCommand com = new DAOImpCommand(la);
            listCommande = com.Liste_Commande();
            source.DataSource = listCommande;
            dataGridView1.DataSource = source;

        }
          
        private void ajoutcmd_Click(object sender, EventArgs e)
        {
            newTextRow(LDown++); nbt++;
            source.DataSource = listCommande;
            dataGridView1.DataSource = source;
            newC.Visible = true;
         panel1.AutoScroll = true;
         valider.Visible = true;
         ajoutcmd.Visible = mdifiercmd.Visible = supprimercmd.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ajoutcmd.Enabled = mdifiercmd.Enabled = supprimercmd.Enabled = true;
            CodeCm.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
          datec.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
        }

        private void valider_Click(object sender, EventArgs e)
        {
            
             for(int i=0;i<charge1.Count;i++)
             {
                 String lib =Convert.ToString(dataGridView2.Rows[i].Cells[1].Value);
                 Int32 count = Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
                 DAOImpProduit pp = new DAOImpProduit(la);
                 p=pp.rechercherProduit(lib);
                Int32 v=p.QteStock - count;
                if (v >= 0)
                {
                    LigneCommande lig = new LigneCommande(p.CodeProd, CodeCm.Text.ToString(), count);
                    DAOImpLigneCommande li = new DAOImpLigneCommande(la);
                    li.ajouterLigneCommande(lig);
                    
                    Produit pr = new Produit(p.CodeProd, p.LibelleProd, p.PrixUnitaire,v);
                    DAOImpProduit pro = new DAOImpProduit(la);
                    pro.modifProduit(pr);
                    MessageBox.Show("valide");
                }
                else
                {
                    MessageBox.Show("impossible car stock insuffisant" + lib);

                }
             }
             modeconsol();
           
            }

        }

    }
