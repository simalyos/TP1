﻿namespace NoteFee_GSB
{
    partial class SendDoc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendDoc));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_fichier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_fichier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_fichier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_fichier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.justificatifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notefee_gsbDataSet = new NoteFee_GSB.notefee_gsbDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.justificatifTableAdapter = new NoteFee_GSB.notefee_gsbDataSetTableAdapters.justificatifTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.justificatifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notefee_gsbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 245);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(490, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Location = new System.Drawing.Point(625, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Parcourir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(905, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 925);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Galaxy Swiss Bourdin NoteFee v1.0";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1182, 912);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(328, 31);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 37);
            this.label1.TabIndex = 44;
            this.label1.Text = "Envoyer un document";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_fichier,
            this.type_fichier,
            this.commentaire,
            this.nom_fichier,
            this.date_fichier,
            this.statut});
            this.dataGridView1.Location = new System.Drawing.Point(130, 335);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1374, 559);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_fichier
            // 
            this.id_fichier.HeaderText = "Column1";
            this.id_fichier.MinimumWidth = 10;
            this.id_fichier.Name = "id_fichier";
            // 
            // type_fichier
            // 
            this.type_fichier.HeaderText = "Column2";
            this.type_fichier.MinimumWidth = 10;
            this.type_fichier.Name = "type_fichier";
            // 
            // commentaire
            // 
            this.commentaire.HeaderText = "Column3";
            this.commentaire.MinimumWidth = 10;
            this.commentaire.Name = "commentaire";
            // 
            // nom_fichier
            // 
            this.nom_fichier.HeaderText = "Column4";
            this.nom_fichier.MinimumWidth = 10;
            this.nom_fichier.Name = "nom_fichier";
            // 
            // date_fichier
            // 
            this.date_fichier.HeaderText = "Column5";
            this.date_fichier.MinimumWidth = 10;
            this.date_fichier.Name = "date_fichier";
            // 
            // statut
            // 
            this.statut.HeaderText = "Column6";
            this.statut.MinimumWidth = 10;
            this.statut.Name = "statut";
            // 
            // justificatifBindingSource
            // 
            this.justificatifBindingSource.DataMember = "justificatif";
            this.justificatifBindingSource.DataSource = this.notefee_gsbDataSet;
            // 
            // notefee_gsbDataSet
            // 
            this.notefee_gsbDataSet.DataSetName = "notefee_gsbDataSet";
            this.notefee_gsbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 31);
            this.label6.TabIndex = 59;
            this.label6.Text = "Type de justificatif";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 31);
            this.label5.TabIndex = 58;
            this.label5.Text = "Commentaire";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(129, 170);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(344, 54);
            this.textBox6.TabIndex = 57;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(517, 170);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(987, 54);
            this.textBox5.TabIndex = 56;
            // 
            // justificatifTableAdapter
            // 
            this.justificatifTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1316, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 62);
            this.button3.TabIndex = 60;
            this.button3.Text = "supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1100, 245);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 62);
            this.button5.TabIndex = 62;
            this.button5.Text = "Modifier";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1344, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // SendDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1638, 1009);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SendDoc";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SendDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.justificatifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notefee_gsbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private notefee_gsbDataSet notefee_gsbDataSet;
        private System.Windows.Forms.BindingSource justificatifBindingSource;
        private notefee_gsbDataSetTableAdapters.justificatifTableAdapter justificatifTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fichier;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_fichier;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_fichier;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_fichier;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
    }
}