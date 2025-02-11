using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test_2
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private DataTable datacontact = new DataTable(); // Déclaration DataTable
        public Form1()
        {
            InitializeComponent();
            button1.MouseEnter += new EventHandler(button1_MouseEnter);

            // Initialisation des colonnes
            datacontact.Columns.Add("Nom");
            datacontact.Columns.Add("Email");

            //mise en place du boutons dans les colonne
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Action";
            btnColumn.Text = "Suprimmer";
            btnColumn.Name = "btnSupprimer";
            btnColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnColumn);

            // Initialisation de la liste contact
            List<string[]> contact = new List<string[]>
            {
                new string[] {"Armand", "armand@gmail.com"},
                new string[] {"Oscar", "oscar@gmail.com"},
                new string[] {"Paul", "paul@gmail.com"},
                new string[] {"Tiago", "tiago@gmail.com"}
            };

            foreach (string[] contacte in contact)
            {
                datacontact.Rows.Add(contacte[0], contacte[1]);

            }

            // Lier la DataTable au DataGridView
            dataGridView1.DataSource = datacontact;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //int maxX = this.ClientSize.Width - button1.Width;
            //int maxY = this.ClientSize.Height - button1.Height;
            //button1.Location = new Point(random.Next(maxX), random.Next(maxY));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string email = textBox2.Text;

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                MessageBox.Show("L'adresse mail ne contient pas de '@' ou est vide.");
            }
            else
            {
                // Ajouter un nouveau contact à la DataTable
                datacontact.Rows.Add(nom, email);
                MessageBox.Show($"Le contact , {email} a bien été ajouté !");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("I m here!!");
            if (e.ColumnIndex == dataGridView1.Columns["btnSupprimer"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string nom = row.Cells["nom"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("La ligne suprimmée est " + nom + "(nom) " + email + "(email)");
            }
        }
    }
}
