namespace Gestione_Libreria
{
    partial class homeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            roundedPanel1 = new RoundedPanel();
            azzeraButton = new CustomControls.RJControls.RJButton();
            aggiugniButton = new CustomControls.RJControls.RJButton();
            prezzoTextBox = new CustomControls.RJControls.RJTextBox();
            autoreTextBox = new CustomControls.RJControls.RJTextBox();
            titoloTextBox = new CustomControls.RJControls.RJTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            esciButton = new CustomControls.RJControls.RJButton();
            roundedPanel2 = new RoundedPanel();
            libroeconomicoButton = new CustomControls.RJControls.RJButton();
            mediaprezziButton = new CustomControls.RJControls.RJButton();
            autoremaxButton = new CustomControls.RJControls.RJButton();
            roundedPanel3 = new RoundedPanel();
            dataGridView1 = new DataGridView();
            Titolo = new DataGridViewTextBoxColumn();
            Autore = new DataGridViewTextBoxColumn();
            Prezzo = new DataGridViewTextBoxColumn();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedPanel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(39, 60, 117);
            roundedPanel1.BorderColor = Color.White;
            roundedPanel1.Controls.Add(azzeraButton);
            roundedPanel1.Controls.Add(aggiugniButton);
            roundedPanel1.Controls.Add(prezzoTextBox);
            roundedPanel1.Controls.Add(autoreTextBox);
            roundedPanel1.Controls.Add(titoloTextBox);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Edge = 15;
            roundedPanel1.Location = new Point(15, 77);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(353, 273);
            roundedPanel1.TabIndex = 0;
            // 
            // azzeraButton
            // 
            azzeraButton.BackColor = Color.FromArgb(56, 79, 140);
            azzeraButton.BackgroundColor = Color.FromArgb(56, 79, 140);
            azzeraButton.BorderColor = Color.FromArgb(69, 97, 173);
            azzeraButton.BorderRadius = 10;
            azzeraButton.BorderSize = 2;
            azzeraButton.FlatAppearance.BorderSize = 0;
            azzeraButton.FlatStyle = FlatStyle.Flat;
            azzeraButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            azzeraButton.ForeColor = Color.White;
            azzeraButton.Location = new Point(23, 201);
            azzeraButton.Name = "azzeraButton";
            azzeraButton.Size = new Size(145, 50);
            azzeraButton.TabIndex = 9;
            azzeraButton.Text = "Azzera campi";
            azzeraButton.TextColor = Color.White;
            azzeraButton.UseVisualStyleBackColor = false;
            // 
            // aggiugniButton
            // 
            aggiugniButton.BackColor = Color.FromArgb(69, 173, 121);
            aggiugniButton.BackgroundColor = Color.FromArgb(69, 173, 121);
            aggiugniButton.BorderColor = Color.FromArgb(92, 230, 161);
            aggiugniButton.BorderRadius = 10;
            aggiugniButton.BorderSize = 2;
            aggiugniButton.FlatAppearance.BorderSize = 0;
            aggiugniButton.FlatStyle = FlatStyle.Flat;
            aggiugniButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aggiugniButton.ForeColor = Color.White;
            aggiugniButton.Location = new Point(184, 201);
            aggiugniButton.Name = "aggiugniButton";
            aggiugniButton.Size = new Size(145, 50);
            aggiugniButton.TabIndex = 8;
            aggiugniButton.Text = "Aggiunfi Libro";
            aggiugniButton.TextColor = Color.White;
            aggiugniButton.UseVisualStyleBackColor = false;
            aggiugniButton.Click += aggiugniButton_Click;
            // 
            // prezzoTextBox
            // 
            prezzoTextBox.BackColor = Color.FromArgb(56, 79, 140);
            prezzoTextBox.BorderColor = Color.FromArgb(69, 97, 173);
            prezzoTextBox.BorderFocusColor = Color.FromArgb(64, 115, 158);
            prezzoTextBox.BorderRadius = 10;
            prezzoTextBox.BorderSize = 2;
            prezzoTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prezzoTextBox.ForeColor = Color.White;
            prezzoTextBox.Location = new Point(103, 139);
            prezzoTextBox.Margin = new Padding(4);
            prezzoTextBox.Multiline = false;
            prezzoTextBox.Name = "prezzoTextBox";
            prezzoTextBox.Padding = new Padding(10, 7, 10, 7);
            prezzoTextBox.PasswordChar = false;
            prezzoTextBox.PlaceholderColor = Color.DarkGray;
            prezzoTextBox.PlaceholderText = "";
            prezzoTextBox.Size = new Size(225, 35);
            prezzoTextBox.TabIndex = 5;
            prezzoTextBox.Texts = "";
            prezzoTextBox.UnderlinedStyle = false;
            prezzoTextBox._TextChanged += prezzoTextBox__TextChanged;
            // 
            // autoreTextBox
            // 
            autoreTextBox.BackColor = Color.FromArgb(56, 79, 140);
            autoreTextBox.BorderColor = Color.FromArgb(69, 97, 173);
            autoreTextBox.BorderFocusColor = Color.FromArgb(64, 115, 158);
            autoreTextBox.BorderRadius = 10;
            autoreTextBox.BorderSize = 2;
            autoreTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            autoreTextBox.ForeColor = Color.White;
            autoreTextBox.Location = new Point(103, 80);
            autoreTextBox.Margin = new Padding(4);
            autoreTextBox.Multiline = false;
            autoreTextBox.Name = "autoreTextBox";
            autoreTextBox.Padding = new Padding(10, 7, 10, 7);
            autoreTextBox.PasswordChar = false;
            autoreTextBox.PlaceholderColor = Color.DarkGray;
            autoreTextBox.PlaceholderText = "";
            autoreTextBox.Size = new Size(225, 35);
            autoreTextBox.TabIndex = 4;
            autoreTextBox.Texts = "";
            autoreTextBox.UnderlinedStyle = false;
            autoreTextBox._TextChanged += autoreTextBox__TextChanged;
            // 
            // titoloTextBox
            // 
            titoloTextBox.BackColor = Color.FromArgb(56, 79, 140);
            titoloTextBox.BorderColor = Color.FromArgb(69, 97, 173);
            titoloTextBox.BorderFocusColor = Color.FromArgb(64, 115, 158);
            titoloTextBox.BorderRadius = 10;
            titoloTextBox.BorderSize = 2;
            titoloTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titoloTextBox.ForeColor = Color.White;
            titoloTextBox.Location = new Point(103, 23);
            titoloTextBox.Margin = new Padding(4);
            titoloTextBox.Multiline = false;
            titoloTextBox.Name = "titoloTextBox";
            titoloTextBox.Padding = new Padding(10, 7, 10, 7);
            titoloTextBox.PasswordChar = false;
            titoloTextBox.PlaceholderColor = Color.DarkGray;
            titoloTextBox.PlaceholderText = "";
            titoloTextBox.Size = new Size(225, 35);
            titoloTextBox.TabIndex = 3;
            titoloTextBox.Texts = "";
            titoloTextBox.UnderlinedStyle = false;
            titoloTextBox._TextChanged += titoloTextBox__TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 144);
            label4.Name = "label4";
            label4.Size = new Size(68, 24);
            label4.TabIndex = 2;
            label4.Text = "Prezzo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 85);
            label3.Name = "label3";
            label3.Size = new Size(66, 24);
            label3.TabIndex = 1;
            label3.Text = "Autore";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 28);
            label2.Name = "label2";
            label2.Size = new Size(56, 24);
            label2.TabIndex = 0;
            label2.Text = "Titolo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 21);
            label1.Name = "label1";
            label1.Size = new Size(255, 33);
            label1.TabIndex = 1;
            label1.Text = "Gestione Libreria";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Icon;
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // esciButton
            // 
            esciButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            esciButton.BackColor = Color.FromArgb(56, 79, 140);
            esciButton.BackgroundColor = Color.FromArgb(56, 79, 140);
            esciButton.BorderColor = Color.FromArgb(69, 97, 173);
            esciButton.BorderRadius = 10;
            esciButton.BorderSize = 2;
            esciButton.FlatAppearance.BorderSize = 0;
            esciButton.FlatStyle = FlatStyle.Flat;
            esciButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            esciButton.ForeColor = Color.White;
            esciButton.Location = new Point(434, 12);
            esciButton.Name = "esciButton";
            esciButton.Size = new Size(145, 50);
            esciButton.TabIndex = 3;
            esciButton.Text = "Esci";
            esciButton.TextColor = Color.White;
            esciButton.UseVisualStyleBackColor = false;
            esciButton.Click += esciButton_Click;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(39, 60, 117);
            roundedPanel2.BorderColor = Color.White;
            roundedPanel2.Controls.Add(libroeconomicoButton);
            roundedPanel2.Controls.Add(mediaprezziButton);
            roundedPanel2.Controls.Add(autoremaxButton);
            roundedPanel2.Edge = 15;
            roundedPanel2.Location = new Point(386, 77);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(190, 273);
            roundedPanel2.TabIndex = 10;
            // 
            // libroeconomicoButton
            // 
            libroeconomicoButton.BackColor = Color.FromArgb(56, 79, 140);
            libroeconomicoButton.BackgroundColor = Color.FromArgb(56, 79, 140);
            libroeconomicoButton.BorderColor = Color.FromArgb(69, 97, 173);
            libroeconomicoButton.BorderRadius = 10;
            libroeconomicoButton.BorderSize = 2;
            libroeconomicoButton.FlatAppearance.BorderSize = 0;
            libroeconomicoButton.FlatStyle = FlatStyle.Flat;
            libroeconomicoButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            libroeconomicoButton.ForeColor = Color.White;
            libroeconomicoButton.Location = new Point(23, 181);
            libroeconomicoButton.Name = "libroeconomicoButton";
            libroeconomicoButton.Size = new Size(145, 70);
            libroeconomicoButton.TabIndex = 11;
            libroeconomicoButton.Text = "Libro più economico";
            libroeconomicoButton.TextColor = Color.White;
            libroeconomicoButton.UseVisualStyleBackColor = false;
            libroeconomicoButton.Click += libroeconomicoButton_Click;
            // 
            // mediaprezziButton
            // 
            mediaprezziButton.BackColor = Color.FromArgb(56, 79, 140);
            mediaprezziButton.BackgroundColor = Color.FromArgb(56, 79, 140);
            mediaprezziButton.BorderColor = Color.FromArgb(69, 97, 173);
            mediaprezziButton.BorderRadius = 10;
            mediaprezziButton.BorderSize = 2;
            mediaprezziButton.FlatAppearance.BorderSize = 0;
            mediaprezziButton.FlatStyle = FlatStyle.Flat;
            mediaprezziButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mediaprezziButton.ForeColor = Color.White;
            mediaprezziButton.Location = new Point(23, 98);
            mediaprezziButton.Name = "mediaprezziButton";
            mediaprezziButton.Size = new Size(145, 70);
            mediaprezziButton.TabIndex = 10;
            mediaprezziButton.Text = "Media Prezzi";
            mediaprezziButton.TextColor = Color.White;
            mediaprezziButton.UseVisualStyleBackColor = false;
            mediaprezziButton.Click += mediaprezziButton_Click;
            // 
            // autoremaxButton
            // 
            autoremaxButton.BackColor = Color.FromArgb(56, 79, 140);
            autoremaxButton.BackgroundColor = Color.FromArgb(56, 79, 140);
            autoremaxButton.BorderColor = Color.FromArgb(69, 97, 173);
            autoremaxButton.BorderRadius = 10;
            autoremaxButton.BorderSize = 2;
            autoremaxButton.FlatAppearance.BorderSize = 0;
            autoremaxButton.FlatStyle = FlatStyle.Flat;
            autoremaxButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            autoremaxButton.ForeColor = Color.White;
            autoremaxButton.Location = new Point(23, 15);
            autoremaxButton.Name = "autoremaxButton";
            autoremaxButton.Size = new Size(145, 70);
            autoremaxButton.TabIndex = 9;
            autoremaxButton.Text = "Autore con libro più costoso";
            autoremaxButton.TextColor = Color.White;
            autoremaxButton.UseVisualStyleBackColor = false;
            autoremaxButton.Click += autoremaxButton_Click;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(39, 60, 117);
            roundedPanel3.BorderColor = Color.White;
            roundedPanel3.Controls.Add(dataGridView1);
            roundedPanel3.Edge = 15;
            roundedPanel3.Location = new Point(15, 362);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(563, 230);
            roundedPanel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Titolo, Autore, Prezzo });
            dataGridView1.Location = new Point(23, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(520, 199);
            dataGridView1.TabIndex = 0;
            // 
            // Titolo
            // 
            Titolo.HeaderText = "Titolo";
            Titolo.Name = "Titolo";
            // 
            // Autore
            // 
            Autore.HeaderText = "Autore";
            Autore.Name = "Autore";
            // 
            // Prezzo
            // 
            Prezzo.HeaderText = "Prezzo";
            Prezzo.Name = "Prezzo";
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 42, 86);
            ClientSize = new Size(595, 603);
            Controls.Add(roundedPanel3);
            Controls.Add(roundedPanel2);
            Controls.Add(esciButton);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(roundedPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "homeForm";
            Text = "Home";
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Gestione_Libreria.RoundedPanel roundedPanel1;
        private Label label1;
        private PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton esciButton;
        private CustomControls.RJControls.RJTextBox prezzoTextBox;
        private CustomControls.RJControls.RJTextBox autoreTextBox;
        private CustomControls.RJControls.RJTextBox titoloTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private CustomControls.RJControls.RJButton azzeraButton;
        private CustomControls.RJControls.RJButton aggiugniButton;
        private RoundedPanel roundedPanel2;
        private CustomControls.RJControls.RJButton libroeconomicoButton;
        private CustomControls.RJControls.RJButton mediaprezziButton;
        private CustomControls.RJControls.RJButton autoremaxButton;
        private RoundedPanel roundedPanel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Titolo;
        private DataGridViewTextBoxColumn Autore;
        private DataGridViewTextBoxColumn Prezzo;
    }
}