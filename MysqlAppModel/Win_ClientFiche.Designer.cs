namespace MysqlAppModel
{
    partial class Win_ClientFiche
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
            this.Lab_CodeClient = new System.Windows.Forms.Label();
            this.Txt_CodeClient = new System.Windows.Forms.TextBox();
            this.Lab_NomClient = new System.Windows.Forms.Label();
            this.Txt_NomClient = new System.Windows.Forms.TextBox();
            this.Lab_Adresse = new System.Windows.Forms.Label();
            this.Txt_Adresse = new System.Windows.Forms.TextBox();
            this.Lab_CodePostal = new System.Windows.Forms.Label();
            this.Txt_CodePostal = new System.Windows.Forms.TextBox();
            this.Lab_Ville = new System.Windows.Forms.Label();
            this.Txt_Ville = new System.Windows.Forms.TextBox();
            this.Lab_Tel = new System.Windows.Forms.Label();
            this.Txt_Tel = new System.Windows.Forms.TextBox();
            this.Lab_Email = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Lab_DateNaiss = new System.Windows.Forms.Label();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Txt_NoteMoy = new System.Windows.Forms.TextBox();
            this.Lab_NoteMoy = new System.Windows.Forms.Label();
            this.Txt_DateContact = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Lab_CodeClient
            // 
            this.Lab_CodeClient.AutoSize = true;
            this.Lab_CodeClient.Location = new System.Drawing.Point(16, 25);
            this.Lab_CodeClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_CodeClient.Name = "Lab_CodeClient";
            this.Lab_CodeClient.Size = new System.Drawing.Size(41, 17);
            this.Lab_CodeClient.TabIndex = 0;
            this.Lab_CodeClient.Text = "Code";
            // 
            // Txt_CodeClient
            // 
            this.Txt_CodeClient.Location = new System.Drawing.Point(135, 21);
            this.Txt_CodeClient.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_CodeClient.MaxLength = 15;
            this.Txt_CodeClient.Name = "Txt_CodeClient";
            this.Txt_CodeClient.Size = new System.Drawing.Size(100, 22);
            this.Txt_CodeClient.TabIndex = 1;
            this.Txt_CodeClient.TextChanged += new System.EventHandler(this.Txt_CodeClient_TextChanged);
            this.Txt_CodeClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_CodeClient_KeyPress);
            // 
            // Lab_NomClient
            // 
            this.Lab_NomClient.AutoSize = true;
            this.Lab_NomClient.Location = new System.Drawing.Point(16, 57);
            this.Lab_NomClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_NomClient.Name = "Lab_NomClient";
            this.Lab_NomClient.Size = new System.Drawing.Size(37, 17);
            this.Lab_NomClient.TabIndex = 2;
            this.Lab_NomClient.Text = "Nom";
            // 
            // Txt_NomClient
            // 
            this.Txt_NomClient.Location = new System.Drawing.Point(135, 53);
            this.Txt_NomClient.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_NomClient.MaxLength = 255;
            this.Txt_NomClient.Name = "Txt_NomClient";
            this.Txt_NomClient.Size = new System.Drawing.Size(296, 22);
            this.Txt_NomClient.TabIndex = 3;
            this.Txt_NomClient.TextChanged += new System.EventHandler(this.Txt_NomClient_TextChanged);
            // 
            // Lab_Adresse
            // 
            this.Lab_Adresse.AutoSize = true;
            this.Lab_Adresse.Location = new System.Drawing.Point(16, 89);
            this.Lab_Adresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Adresse.Name = "Lab_Adresse";
            this.Lab_Adresse.Size = new System.Drawing.Size(60, 17);
            this.Lab_Adresse.TabIndex = 4;
            this.Lab_Adresse.Text = "Adresse";
            // 
            // Txt_Adresse
            // 
            this.Txt_Adresse.Location = new System.Drawing.Point(135, 85);
            this.Txt_Adresse.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Adresse.MaxLength = 255;
            this.Txt_Adresse.Name = "Txt_Adresse";
            this.Txt_Adresse.Size = new System.Drawing.Size(405, 22);
            this.Txt_Adresse.TabIndex = 5;
            // 
            // Lab_CodePostal
            // 
            this.Lab_CodePostal.AutoSize = true;
            this.Lab_CodePostal.Location = new System.Drawing.Point(16, 121);
            this.Lab_CodePostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_CodePostal.Name = "Lab_CodePostal";
            this.Lab_CodePostal.Size = new System.Drawing.Size(84, 17);
            this.Lab_CodePostal.TabIndex = 6;
            this.Lab_CodePostal.Text = "Code Postal";
            // 
            // Txt_CodePostal
            // 
            this.Txt_CodePostal.Location = new System.Drawing.Point(135, 117);
            this.Txt_CodePostal.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_CodePostal.MaxLength = 5;
            this.Txt_CodePostal.Name = "Txt_CodePostal";
            this.Txt_CodePostal.Size = new System.Drawing.Size(71, 22);
            this.Txt_CodePostal.TabIndex = 7;
            this.Txt_CodePostal.TextChanged += new System.EventHandler(this.Txt_CodePostal_TextChanged);
            this.Txt_CodePostal.Leave += new System.EventHandler(this.Txt_CodePostal_Leave);
            // 
            // Lab_Ville
            // 
            this.Lab_Ville.AutoSize = true;
            this.Lab_Ville.Location = new System.Drawing.Point(16, 153);
            this.Lab_Ville.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Ville.Name = "Lab_Ville";
            this.Lab_Ville.Size = new System.Drawing.Size(34, 17);
            this.Lab_Ville.TabIndex = 8;
            this.Lab_Ville.Text = "Ville";
            // 
            // Txt_Ville
            // 
            this.Txt_Ville.Location = new System.Drawing.Point(135, 149);
            this.Txt_Ville.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Ville.MaxLength = 80;
            this.Txt_Ville.Name = "Txt_Ville";
            this.Txt_Ville.Size = new System.Drawing.Size(296, 22);
            this.Txt_Ville.TabIndex = 9;
            // 
            // Lab_Tel
            // 
            this.Lab_Tel.AutoSize = true;
            this.Lab_Tel.Location = new System.Drawing.Point(16, 185);
            this.Lab_Tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Tel.Name = "Lab_Tel";
            this.Lab_Tel.Size = new System.Drawing.Size(76, 17);
            this.Lab_Tel.TabIndex = 10;
            this.Lab_Tel.Text = "Telephone";
            // 
            // Txt_Tel
            // 
            this.Txt_Tel.Location = new System.Drawing.Point(135, 181);
            this.Txt_Tel.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Tel.MaxLength = 15;
            this.Txt_Tel.Name = "Txt_Tel";
            this.Txt_Tel.Size = new System.Drawing.Size(143, 22);
            this.Txt_Tel.TabIndex = 11;
            // 
            // Lab_Email
            // 
            this.Lab_Email.AutoSize = true;
            this.Lab_Email.Location = new System.Drawing.Point(16, 217);
            this.Lab_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Email.Name = "Lab_Email";
            this.Lab_Email.Size = new System.Drawing.Size(42, 17);
            this.Lab_Email.TabIndex = 12;
            this.Lab_Email.Text = "Email";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(135, 213);
            this.Txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Email.MaxLength = 70;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(296, 22);
            this.Txt_Email.TabIndex = 13;
            this.Txt_Email.Text = "example@mail.com";
            this.Txt_Email.Leave += new System.EventHandler(this.Txt_Email_Leave);
            // 
            // Lab_DateNaiss
            // 
            this.Lab_DateNaiss.AutoSize = true;
            this.Lab_DateNaiss.Location = new System.Drawing.Point(16, 249);
            this.Lab_DateNaiss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_DateNaiss.Name = "Lab_DateNaiss";
            this.Lab_DateNaiss.Size = new System.Drawing.Size(90, 17);
            this.Lab_DateNaiss.TabIndex = 14;
            this.Lab_DateNaiss.Text = "Date Contact";
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OK.Location = new System.Drawing.Point(333, 319);
            this.Btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(100, 28);
            this.Btn_OK.TabIndex = 16;
            this.Btn_OK.Text = "OK";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.Location = new System.Drawing.Point(443, 319);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(100, 28);
            this.Btn_Cancel.TabIndex = 17;
            this.Btn_Cancel.Text = "Annuler";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Txt_NoteMoy
            // 
            this.Txt_NoteMoy.Location = new System.Drawing.Point(135, 277);
            this.Txt_NoteMoy.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_NoteMoy.MaxLength = 12;
            this.Txt_NoteMoy.Name = "Txt_NoteMoy";
            this.Txt_NoteMoy.Size = new System.Drawing.Size(144, 22);
            this.Txt_NoteMoy.TabIndex = 19;
            this.Txt_NoteMoy.Text = "10";
            // 
            // Lab_NoteMoy
            // 
            this.Lab_NoteMoy.AutoSize = true;
            this.Lab_NoteMoy.Location = new System.Drawing.Point(16, 281);
            this.Lab_NoteMoy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_NoteMoy.Name = "Lab_NoteMoy";
            this.Lab_NoteMoy.Size = new System.Drawing.Size(100, 17);
            this.Lab_NoteMoy.TabIndex = 18;
            this.Lab_NoteMoy.Text = "Note Moyenne";
            // 
            // Txt_DateContact
            // 
            this.Txt_DateContact.Location = new System.Drawing.Point(135, 245);
            this.Txt_DateContact.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_DateContact.Mask = "00/00/0000";
            this.Txt_DateContact.Name = "Txt_DateContact";
            this.Txt_DateContact.Size = new System.Drawing.Size(132, 22);
            this.Txt_DateContact.TabIndex = 20;
            this.Txt_DateContact.ValidatingType = typeof(System.DateTime);
            this.Txt_DateContact.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_DateContact_MaskInputRejected);
            this.Txt_DateContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_DateContact_KeyPress);
            this.Txt_DateContact.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_DateContact_Validating);
            // 
            // Win_ClientFiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 358);
            this.Controls.Add(this.Txt_DateContact);
            this.Controls.Add(this.Txt_NoteMoy);
            this.Controls.Add(this.Lab_NoteMoy);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Lab_DateNaiss);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Lab_Email);
            this.Controls.Add(this.Txt_Tel);
            this.Controls.Add(this.Lab_Tel);
            this.Controls.Add(this.Txt_Ville);
            this.Controls.Add(this.Lab_Ville);
            this.Controls.Add(this.Txt_CodePostal);
            this.Controls.Add(this.Lab_CodePostal);
            this.Controls.Add(this.Txt_Adresse);
            this.Controls.Add(this.Lab_Adresse);
            this.Controls.Add(this.Txt_NomClient);
            this.Controls.Add(this.Lab_NomClient);
            this.Controls.Add(this.Txt_CodeClient);
            this.Controls.Add(this.Lab_CodeClient);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(567, 395);
            this.Name = "Win_ClientFiche";
            this.Text = "Fiche Client";
            this.Load += new System.EventHandler(this.Win_ClientFiche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_CodeClient;
        private System.Windows.Forms.TextBox Txt_CodeClient;
        private System.Windows.Forms.Label Lab_NomClient;
        private System.Windows.Forms.TextBox Txt_NomClient;
        private System.Windows.Forms.Label Lab_Adresse;
        private System.Windows.Forms.TextBox Txt_Adresse;
        private System.Windows.Forms.Label Lab_CodePostal;
        private System.Windows.Forms.TextBox Txt_CodePostal;
        private System.Windows.Forms.Label Lab_Ville;
        private System.Windows.Forms.TextBox Txt_Ville;
        private System.Windows.Forms.Label Lab_Tel;
        private System.Windows.Forms.TextBox Txt_Tel;
        private System.Windows.Forms.Label Lab_Email;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label Lab_DateNaiss;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.TextBox Txt_NoteMoy;
        private System.Windows.Forms.Label Lab_NoteMoy;
        private System.Windows.Forms.MaskedTextBox Txt_DateContact;
    }
}