using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace test_2
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Armand\\source\\repos\\test 2\\Contactsdb.mdf\";Integrated Security=True";
        private Random random = new Random();

        public Form1()
        {

            InitializeComponent();
            leadtableau();
            //pour le bouton qui bouge tout seul
            Bajouter.MouseEnter += new EventHandler(button1_MouseEnter);

            //mise en place du boutons suprimer
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Action";
            btnColumn.Text = "Suprimmer";
            btnColumn.Name = "btnSupprimer";
            btnColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnColumn);

            //mise en place du boutons modifier
            DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
            btnedit.HeaderText = "Actions";
            btnedit.Text = "Modifier";
            btnedit.Name = "btnmodifier";
            btnedit.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnedit);
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //int maxX = this.ClientSize.Width - button1.Width;
            //int maxY = this.ClientSize.Height - button1.Height;
            //button1.Location = new Point(random.Next(maxX), random.Next(maxY));
        }
        //événement du bouton ajouter
        private void button1_Click_1(object sender, EventArgs e)
        {
            string nom = nomadd.Text;
            string email = emailadd.Text;
            nomadd.Text = ("");
            emailadd.Text = ("");

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                MessageBox.Show("L'adresse mail ne contient pas de '@' ou est vide.");
            }
            else
            {
                // Ajouter un nouveau contact à base de donnée
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Contacts (Nom, Email) VALUES (@Nom, @Email)", conn);
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                }
                leadtableau();
                MessageBox.Show($"Le contact , {nom} (nom) {email} (email) a bien été ajouté !");
            }
        }
        //événement des bouton du tableau
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //événement du bouton Supprime du tableau
            if (e.ColumnIndex == dataGridView1.Columns["btnSupprimer"].Index && e.RowIndex >= 0)
            {


                DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment supprimer cet élément ?",
                "Conffirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
                if (result == DialogResult.Yes)
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Contacts WHERE ID = @ID", conn);
                        cmd.Parameters.AddWithValue("@ID", id); ;
                        cmd.ExecuteNonQuery();
                    }
                    leadtableau();
                    MessageBox.Show("L'élément a été supprimé.");
                }
                else
                {
                    MessageBox.Show("L'élément n'a pas été supprimé.");
                }
            }
            //événement du bouton modifier du tableau
            if (e.ColumnIndex == dataGridView1.Columns["btnmodifier"].Index && e.RowIndex >= 0)
            {
                TBnomedit.Visible = true;
                TBemailedit.Visible = true;
                Lnomedit.Visible = true;
                Lemailedit.Visible = true;
                Bedit.Visible = true;

            }
        }
        //événement du bouton modifier
        private void Bedit_Click(object sender, EventArgs e)
        {
            string nomedit = TBnomedit.Text;
            string emailedit = TBemailedit.Text;
            TBnomedit.Text = "";
            TBemailedit.Text = "";

            if (!emailedit.Contains("@"))
            {
                MessageBox.Show("L'email n'a pas @");
            }
            else
            {
                string ID = (int)this.dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    ;
                    conn.Open();
                    string query = "UPDATE Contacts SET Nom = @Nom, Email = @Email WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nomedit);
                        cmd.Parameters.AddWithValue("@Email", emailedit);
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Le contact a été mis à jour avec succès !");
                        TBnomedit.Visible = false;
                        TBemailedit.Visible = false;
                        Lnomedit.Visible = false;
                        Lemailedit.Visible = false;
                        Bedit.Visible = false;
                    }
                }
            }

        }
        //fonction d'actualisation du tableau
        private void leadtableau()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Contacts", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //lier la datagridview aux résultats de la requête
                dataGridView1.DataSource = dt;
            }
        }
    }
}
