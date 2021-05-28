
namespace Projekt1.Forms
{
    partial class MenuMovieForm
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
            this.addNewArtistButton = new System.Windows.Forms.Button();
            this.movieTitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addNewMovieButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.movieListBox = new System.Windows.Forms.ListBox();
            this.movieDetalisListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CastListBox = new System.Windows.Forms.ListBox();
            this.artistListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.AddRoleButton = new System.Windows.Forms.Button();
            this.addMovieDetailsButton = new System.Windows.Forms.Button();
            this.deleteMovieButton = new System.Windows.Forms.Button();
            this.deleteArtistButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewArtistButton
            // 
            this.addNewArtistButton.Location = new System.Drawing.Point(639, 22);
            this.addNewArtistButton.Name = "addNewArtistButton";
            this.addNewArtistButton.Size = new System.Drawing.Size(149, 45);
            this.addNewArtistButton.TabIndex = 0;
            this.addNewArtistButton.Text = "Dodaj artyste";
            this.addNewArtistButton.UseVisualStyleBackColor = true;
            this.addNewArtistButton.Click += new System.EventHandler(this.addNewArtistButton_Click);
            // 
            // movieTitleTextBox
            // 
            this.movieTitleTextBox.Location = new System.Drawing.Point(104, 62);
            this.movieTitleTextBox.Name = "movieTitleTextBox";
            this.movieTitleTextBox.Size = new System.Drawing.Size(150, 22);
            this.movieTitleTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tytuł filmu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wprowadzanie nowego filmu";
            // 
            // addNewMovieButton
            // 
            this.addNewMovieButton.Location = new System.Drawing.Point(273, 58);
            this.addNewMovieButton.Name = "addNewMovieButton";
            this.addNewMovieButton.Size = new System.Drawing.Size(126, 26);
            this.addNewMovieButton.TabIndex = 4;
            this.addNewMovieButton.Text = "Dodaj film ";
            this.addNewMovieButton.UseVisualStyleBackColor = true;
            this.addNewMovieButton.Click += new System.EventHandler(this.addNewMovieButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aktualne filmy w bazie:";
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.ItemHeight = 16;
            this.movieListBox.Location = new System.Drawing.Point(12, 150);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(323, 292);
            this.movieListBox.TabIndex = 6;
            this.movieListBox.SelectedIndexChanged += new System.EventHandler(this.movieListBox_SelectedIndexChanged);
            // 
            // movieDetalisListBox
            // 
            this.movieDetalisListBox.FormattingEnabled = true;
            this.movieDetalisListBox.ItemHeight = 16;
            this.movieDetalisListBox.Location = new System.Drawing.Point(341, 150);
            this.movieDetalisListBox.Name = "movieDetalisListBox";
            this.movieDetalisListBox.Size = new System.Drawing.Size(240, 132);
            this.movieDetalisListBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Szczegóły filmu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Obsada:";
            // 
            // CastListBox
            // 
            this.CastListBox.FormattingEnabled = true;
            this.CastListBox.ItemHeight = 16;
            this.CastListBox.Location = new System.Drawing.Point(341, 326);
            this.CastListBox.Name = "CastListBox";
            this.CastListBox.Size = new System.Drawing.Size(240, 116);
            this.CastListBox.TabIndex = 10;
            // 
            // artistListBox
            // 
            this.artistListBox.FormattingEnabled = true;
            this.artistListBox.ItemHeight = 16;
            this.artistListBox.Location = new System.Drawing.Point(602, 150);
            this.artistListBox.Name = "artistListBox";
            this.artistListBox.Size = new System.Drawing.Size(186, 132);
            this.artistListBox.TabIndex = 12;
            this.artistListBox.SelectedIndexChanged += new System.EventHandler(this.artistListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(602, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Aktualni artysci w bazie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 51);
            this.label7.TabIndex = 14;
            this.label7.Text = "Aby dodać do filmu obsade \r\nwybierz film i aktora, a w oknie \r\nwpisz jego role w " +
    "filmie";
            // 
            // roleTextBox
            // 
            this.roleTextBox.Location = new System.Drawing.Point(605, 362);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(183, 22);
            this.roleTextBox.TabIndex = 15;
            // 
            // AddRoleButton
            // 
            this.AddRoleButton.Location = new System.Drawing.Point(605, 399);
            this.AddRoleButton.Name = "AddRoleButton";
            this.AddRoleButton.Size = new System.Drawing.Size(183, 39);
            this.AddRoleButton.TabIndex = 16;
            this.AddRoleButton.Text = "Dodaj role";
            this.AddRoleButton.UseVisualStyleBackColor = true;
            this.AddRoleButton.Click += new System.EventHandler(this.AddRoleButton_Click);
            // 
            // addMovieDetailsButton
            // 
            this.addMovieDetailsButton.Enabled = false;
            this.addMovieDetailsButton.Location = new System.Drawing.Point(12, 448);
            this.addMovieDetailsButton.Name = "addMovieDetailsButton";
            this.addMovieDetailsButton.Size = new System.Drawing.Size(323, 43);
            this.addMovieDetailsButton.TabIndex = 17;
            this.addMovieDetailsButton.Text = "Wprowadź informacje o filmie";
            this.addMovieDetailsButton.UseVisualStyleBackColor = true;
            this.addMovieDetailsButton.Click += new System.EventHandler(this.addMovieDetailsButton_Click);
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.Enabled = false;
            this.deleteMovieButton.Location = new System.Drawing.Point(344, 448);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(237, 43);
            this.deleteMovieButton.TabIndex = 18;
            this.deleteMovieButton.Text = "Usuń film";
            this.deleteMovieButton.UseVisualStyleBackColor = true;
            this.deleteMovieButton.Click += new System.EventHandler(this.deleteMovieButton_Click);
            // 
            // deleteArtistButton
            // 
            this.deleteArtistButton.Enabled = false;
            this.deleteArtistButton.Location = new System.Drawing.Point(467, 22);
            this.deleteArtistButton.Name = "deleteArtistButton";
            this.deleteArtistButton.Size = new System.Drawing.Size(149, 45);
            this.deleteArtistButton.TabIndex = 19;
            this.deleteArtistButton.Text = "Usuń artyste";
            this.deleteArtistButton.UseVisualStyleBackColor = true;
            this.deleteArtistButton.Click += new System.EventHandler(this.deleteArtistButton_Click);
            // 
            // MenuMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 503);
            this.Controls.Add(this.deleteArtistButton);
            this.Controls.Add(this.deleteMovieButton);
            this.Controls.Add(this.addMovieDetailsButton);
            this.Controls.Add(this.AddRoleButton);
            this.Controls.Add(this.roleTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.artistListBox);
            this.Controls.Add(this.CastListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.movieDetalisListBox);
            this.Controls.Add(this.movieListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addNewMovieButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieTitleTextBox);
            this.Controls.Add(this.addNewArtistButton);
            this.Name = "MenuMovieForm";
            this.Text = "MenuMovieForm";
            this.Load += new System.EventHandler(this.MenuMovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewArtistButton;
        private System.Windows.Forms.TextBox movieTitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNewMovieButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.ListBox movieDetalisListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox CastListBox;
        private System.Windows.Forms.ListBox artistListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.Button AddRoleButton;
        private System.Windows.Forms.Button addMovieDetailsButton;
        private System.Windows.Forms.Button deleteMovieButton;
        private System.Windows.Forms.Button deleteArtistButton;
    }
}