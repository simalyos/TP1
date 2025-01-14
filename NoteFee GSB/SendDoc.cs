﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using static NoteFee_GSB.Login;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteFee_GSB
{
    public partial class SendDoc : Form
    {
        private string connectionString = "Data Source=DESKTOP-TO2JDQ3\\SQLEXPRESS;Initial Catalog=notefee_gsb;Integrated Security=True;";
        private int id_fichier_modif = -1;

        private string loggedInUser;

        public SendDoc()
        {
            InitializeComponent();
            LoadData();
        }

        private void SendDoc_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'notefee_gsbDataSet.justificatif'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.justificatifTableAdapter.Fill(this.notefee_gsbDataSet.justificatif);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Mettre à jour le champ de texte avec le chemin du fichier sélectionné
                textBox1.Text = openFileDialog.FileName;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private DataTable dataTable;

        // Appeler LoadData() chaque fois que l'utilisateur se connecte

        public void LoadData()
        {
            {
                // Charger les données à partir de la base de données
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM justificatif", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    dataGridView1.Rows.Clear();
                    while (reader.Read())
                    {
                        int id_fichier = (int)reader["id_fichier"];
                        string type_fichier = reader["type_fichier"].ToString();
                        string commentaire = reader["commentaire"].ToString();
                        string nom_fichier = reader["nom_fichier"].ToString();
                        string date_fichier = reader["date_fichier"].ToString();
                        string statut = reader["statut"].ToString();
                        dataGridView1.Rows.Add(id_fichier, type_fichier, commentaire, nom_fichier, date_fichier, statut);
                    }
                }
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Vérifier que le fichier est sélectionné
            if (textBox1.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un fichier à envoyer.");
                return;
            }

            // Créer le dossier "Documents" s'il n'existe pas
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string sendFolder = Path.Combine(documentsFolder, "Justificatif fourni");
            if (!Directory.Exists(sendFolder))
            {
                Directory.CreateDirectory(sendFolder);
            }

            // Copier le fichier dans le dossier "SendFolder"
            string fileName = Path.GetFileName(textBox1.Text);
            string filePath = Path.Combine(sendFolder, fileName);
            //File.Copy(textBox1.Text, filePath);
            if (File.Exists(filePath))
            {
                var result = MessageBox.Show("Le fichier existe déjà dans le dossier. Voulez-vous le remplacer ?", "Fichier existant", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    File.Delete(filePath);
                    File.Copy(textBox1.Text, filePath);
                }
            }
            else
            {
                File.Copy(textBox1.Text, filePath);
            }

            string typeDoc = textBox6.Text;
            string commentaire = textBox5.Text;
            string statut = "En attente";
            string date_fichier = DateTime.Now.ToString("dd/MM/yyyy");
            // Ajouter une ligne avec les informations du fichier dans le DataGridView
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-TO2JDQ3\\SQLEXPRESS;Initial Catalog=notefee_gsb;Integrated Security=True;"))
            {
                connection.Open();

                string query = "INSERT INTO justificatif (type_fichier, commentaire, nom_fichier, date_fichier, statut) VALUES (@type_fichier, @commentaire, @nom_fichier, @date_fichier, @statut); SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@type_fichier", typeDoc);
                command.Parameters.AddWithValue("@commentaire", commentaire);
                command.Parameters.AddWithValue("@nom_fichier", fileName);
                command.Parameters.AddWithValue("@statut", statut);
                command.Parameters.AddWithValue("@date_fichier", date_fichier);
                int id_fichier = Convert.ToInt32(command.ExecuteScalar());

                command.CommandText = "SELECT * FROM justificatif WHERE id_fichier = @id_fichier";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id_fichier", id_fichier);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["id_fichier"], reader["type_fichier"], reader["commentaire"], reader["nom_fichier"], reader["date_fichier"], reader["statut"]);
                }
                reader.Close();
            }


            // Afficher un message de confirmation
            MessageBox.Show("Le fichier a été envoyé avec succès.");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            LoadData();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Désactiver la modification des données pour la ligne sélectionnée
            dataGridView1.Rows[e.RowIndex].ReadOnly = true;
            if (e.RowIndex >= 0)
            {
                // Sélectionner automatiquement la ligne correspondante
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
            // Changer le texte du bouton en "Modifier"
            dataGridView1.Rows[e.RowIndex].Cells["Modifier"].Value = "Modifier";

            // Enregistrer les modifications dans la base de données
            int idFichier = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_fichier"].Value);
            string type_fichier = dataGridView1.Rows[e.RowIndex].Cells["type_fichier"].Value.ToString();
            string commentaire = dataGridView1.Rows[e.RowIndex].Cells["commentaire"].Value.ToString();
            string nom_fichier = dataGridView1.Rows[e.RowIndex].Cells["nom_fichier"].Value.ToString();
            string date_fichier = dataGridView1.Rows[e.RowIndex].Cells["date_fichier"].Value.ToString();
            string statut = dataGridView1.Rows[e.RowIndex].Cells["statut"].Value.ToString();

            // Mettre à jour la base de données avec les nouvelles valeurs
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE justificatif SET type_fichier = @type_fichier, commentaire = @commentaire, nom_fichier = @nom_fichier, date_fichier = @date_fichier, statut = @statut WHERE id_fichier = @id_fichier";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@idFichier", idFichier);
                command.Parameters.AddWithValue("@type_fichier", type_fichier);
                command.Parameters.AddWithValue("@commentaire", commentaire);
                command.Parameters.AddWithValue("@nom_fichier", nom_fichier);
                command.Parameters.AddWithValue("@date_fichier", date_fichier);
                command.Parameters.AddWithValue("@statut", statut);


                command.ExecuteNonQuery();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int id_fichier = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["id_fichier"].Value);


                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer la note sélectionnée ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM justificatif WHERE id_fichier = @id_fichier";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@id_fichier", id_fichier);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("La note a été supprimée avec succès.");
                            dataGridView1.Rows.RemoveAt(selectedRowIndex);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            button5_Click(sender, e, dataGridView1);
        }

        //modif
        private void button5_Click(object sender, EventArgs e, DataGridView dataGridView1)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int id_fichier = Convert.ToInt32(row.Cells["id_fichier"].Value);
                string type_fichier = row.Cells["type_fichier"].Value.ToString();
                string commentaire = row.Cells["commentaire"].Value.ToString();
                string nom_fichier = row.Cells["nom_fichier"].Value.ToString();
                string date_fichier = row.Cells["date_fichier"].Value.ToString();
                string statut = row.Cells["statut"].Value.ToString();

                if (button5.Text == "Modifier")
                {
                    // Activer le mode modification
                    button5.Text = "Enregistrer";
                    dataGridView1.ReadOnly = false;
                    dataGridView1.Columns[0].ReadOnly = true; // Empêcher la modification de la première colonne (id_fichier)

                    // Activer la modification pour la ligne sélectionnée

                    row.ReadOnly = false;
                }
                else
                {
                    // Activer le mode enregistrement
                    button5.Text = "Modifier";
                    dataGridView1.ReadOnly = true;

                    // Désactiver la modification pour la ligne sélectionnée
                    row.ReadOnly = true;

                    // Enregistrer les modifications dans la base de données
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE justificatif SET type_fichier = @type_fichier, commentaire = @commentaire, nom_fichier = @nom_fichier, date_fichier = @date_fichier, statut = @statut WHERE id_fichier = @id_fichier";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@id_fichier", id_fichier);
                        command.Parameters.AddWithValue("@type_fichier", type_fichier);
                        command.Parameters.AddWithValue("@commentaire", commentaire);
                        command.Parameters.AddWithValue("@nom_fichier", nom_fichier);
                        command.Parameters.AddWithValue("@date_fichier", date_fichier);
                        command.Parameters.AddWithValue("@statut", statut);
                        command.ExecuteNonQuery();
                    }

                    // Actualiser la ligne modifiée dans le DataGridView
                    row.Cells["type_fichier"].Value = type_fichier;
                    row.Cells["commentaire"].Value = commentaire;
                    row.Cells["nom_fichier"].Value = nom_fichier;
                    row.Cells["date_fichier"].Value = date_fichier;
                    row.Cells["statut"].Value = statut;

                    MessageBox.Show("Les modifications ont été enregistrées avec succès.");
        
                    }

                    }
                    else
                    {
                    MessageBox.Show("Veuillez sélectionner une ligne à modifier.");
                    }
            }
        }
}
