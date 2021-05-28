
namespace Projekt1.Forms.MenuMovie
{
    partial class AddNewArtist
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
            this.artistCountryOrginTextBox = new System.Windows.Forms.TextBox();
            this.artistBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.artistCountryOrginCheckBox = new System.Windows.Forms.CheckBox();
            this.artistBrithDateCheckBox = new System.Windows.Forms.CheckBox();
            this.artistListBox = new System.Windows.Forms.ListBox();
            this.addNewArtistButton = new System.Windows.Forms.Button();
            this.artistNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // artistCountryOrginTextBox
            // 
            this.artistCountryOrginTextBox.Enabled = false;
            this.artistCountryOrginTextBox.Location = new System.Drawing.Point(174, 77);
            this.artistCountryOrginTextBox.Name = "artistCountryOrginTextBox";
            this.artistCountryOrginTextBox.Size = new System.Drawing.Size(176, 22);
            this.artistCountryOrginTextBox.TabIndex = 15;
            // 
            // artistBirthDateTimePicker
            // 
            this.artistBirthDateTimePicker.Enabled = false;
            this.artistBirthDateTimePicker.Location = new System.Drawing.Point(157, 48);
            this.artistBirthDateTimePicker.Name = "artistBirthDateTimePicker";
            this.artistBirthDateTimePicker.Size = new System.Drawing.Size(193, 22);
            this.artistBirthDateTimePicker.TabIndex = 14;
            // 
            // artistCountryOrginCheckBox
            // 
            this.artistCountryOrginCheckBox.AutoSize = true;
            this.artistCountryOrginCheckBox.Location = new System.Drawing.Point(23, 76);
            this.artistCountryOrginCheckBox.Name = "artistCountryOrginCheckBox";
            this.artistCountryOrginCheckBox.Size = new System.Drawing.Size(144, 21);
            this.artistCountryOrginCheckBox.TabIndex = 13;
            this.artistCountryOrginCheckBox.Text = "Kraj pochodzenia:";
            this.artistCountryOrginCheckBox.UseVisualStyleBackColor = true;
            this.artistCountryOrginCheckBox.CheckedChanged += new System.EventHandler(this.artistCountryOrginCheckBox_CheckedChanged);
            // 
            // artistBrithDateCheckBox
            // 
            this.artistBrithDateCheckBox.AutoSize = true;
            this.artistBrithDateCheckBox.Location = new System.Drawing.Point(23, 48);
            this.artistBrithDateCheckBox.Name = "artistBrithDateCheckBox";
            this.artistBrithDateCheckBox.Size = new System.Drawing.Size(127, 21);
            this.artistBrithDateCheckBox.TabIndex = 12;
            this.artistBrithDateCheckBox.Text = "Data urodzenia";
            this.artistBrithDateCheckBox.UseVisualStyleBackColor = true;
            this.artistBrithDateCheckBox.CheckedChanged += new System.EventHandler(this.artistBrithDateCheckBox_CheckedChanged);
            // 
            // artistListBox
            // 
            this.artistListBox.FormattingEnabled = true;
            this.artistListBox.ItemHeight = 16;
            this.artistListBox.Location = new System.Drawing.Point(23, 147);
            this.artistListBox.Name = "artistListBox";
            this.artistListBox.Size = new System.Drawing.Size(417, 228);
            this.artistListBox.TabIndex = 11;
            this.artistListBox.SelectedIndexChanged += new System.EventHandler(this.artistListBox_SelectedIndexChanged);
            // 
            // addNewArtistButton
            // 
            this.addNewArtistButton.Location = new System.Drawing.Point(365, 15);
            this.addNewArtistButton.Name = "addNewArtistButton";
            this.addNewArtistButton.Size = new System.Drawing.Size(75, 84);
            this.addNewArtistButton.TabIndex = 10;
            this.addNewArtistButton.Text = "Dodaj";
            this.addNewArtistButton.UseVisualStyleBackColor = true;
            this.addNewArtistButton.Click += new System.EventHandler(this.addNewArtistButton_Click);
            // 
            // artistNameTextBox
            // 
            this.artistNameTextBox.Location = new System.Drawing.Point(131, 17);
            this.artistNameTextBox.Name = "artistNameTextBox";
            this.artistNameTextBox.Size = new System.Drawing.Size(219, 22);
            this.artistNameTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Imię i nazwisko:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Aktualna lista artystów:";
            // 
            // AddNewArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 390);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.artistCountryOrginTextBox);
            this.Controls.Add(this.artistBirthDateTimePicker);
            this.Controls.Add(this.artistCountryOrginCheckBox);
            this.Controls.Add(this.artistBrithDateCheckBox);
            this.Controls.Add(this.artistListBox);
            this.Controls.Add(this.addNewArtistButton);
            this.Controls.Add(this.artistNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddNewArtist";
            this.Text = "AddNewArtist";
            this.Load += new System.EventHandler(this.AddNewArtist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox artistCountryOrginTextBox;
        private System.Windows.Forms.DateTimePicker artistBirthDateTimePicker;
        private System.Windows.Forms.CheckBox artistCountryOrginCheckBox;
        private System.Windows.Forms.CheckBox artistBrithDateCheckBox;
        private System.Windows.Forms.ListBox artistListBox;
        private System.Windows.Forms.Button addNewArtistButton;
        private System.Windows.Forms.TextBox artistNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}