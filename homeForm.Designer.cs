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
            this.roundedPanel1 = new Gestione_Libreria.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.esciButton = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.White;
            this.roundedPanel1.Edge = 20;
            this.roundedPanel1.Location = new System.Drawing.Point(12, 61);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(371, 388);
            this.roundedPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestione Libreria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestione_Libreria.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // esciButton
            // 
            this.esciButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.esciButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.esciButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.esciButton.BorderRadius = 10;
            this.esciButton.BorderSize = 0;
            this.esciButton.FlatAppearance.BorderSize = 0;
            this.esciButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.esciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.esciButton.ForeColor = System.Drawing.Color.White;
            this.esciButton.Location = new System.Drawing.Point(638, 8);
            this.esciButton.Name = "esciButton";
            this.esciButton.Size = new System.Drawing.Size(150, 45);
            this.esciButton.TabIndex = 3;
            this.esciButton.Text = "Esci";
            this.esciButton.TextColor = System.Drawing.Color.White;
            this.esciButton.UseVisualStyleBackColor = false;
            this.esciButton.Click += new System.EventHandler(this.esciButton_Click);
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.esciButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundedPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "homeForm";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gestione_Libreria.RoundedPanel roundedPanel1;
        private Label label1;
        private PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton esciButton;
    }
}