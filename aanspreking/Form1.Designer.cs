namespace aanspreking
{
    partial class Aanspreking_Form
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
            this.Voornaam = new System.Windows.Forms.Label();
            this.familienaam = new System.Windows.Forms.Label();
            this.Aanspreking = new System.Windows.Forms.Label();
            this.Voornaaminvoer = new System.Windows.Forms.TextBox();
            this.famillienaaminvoer = new System.Windows.Forms.TextBox();
            this.aanspreking_Textbox = new System.Windows.Forms.TextBox();
            this.Aanspreking_Button = new System.Windows.Forms.Button();
            this.Sluiten = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Voornaam
            // 
            this.Voornaam.AutoSize = true;
            this.Voornaam.Location = new System.Drawing.Point(16, 11);
            this.Voornaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Voornaam.Name = "Voornaam";
            this.Voornaam.Size = new System.Drawing.Size(71, 17);
            this.Voornaam.TabIndex = 0;
            this.Voornaam.Text = "voornaam";
            // 
            // familienaam
            // 
            this.familienaam.AutoSize = true;
            this.familienaam.Location = new System.Drawing.Point(16, 39);
            this.familienaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.familienaam.Name = "familienaam";
            this.familienaam.Size = new System.Drawing.Size(86, 17);
            this.familienaam.TabIndex = 1;
            this.familienaam.Text = "famillienaam";
            // 
            // Aanspreking
            // 
            this.Aanspreking.AutoSize = true;
            this.Aanspreking.Location = new System.Drawing.Point(16, 116);
            this.Aanspreking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Aanspreking.Name = "Aanspreking";
            this.Aanspreking.Size = new System.Drawing.Size(86, 17);
            this.Aanspreking.TabIndex = 2;
            this.Aanspreking.Text = "aanspreking";
            // 
            // Voornaaminvoer
            // 
            this.Voornaaminvoer.Location = new System.Drawing.Point(131, 7);
            this.Voornaaminvoer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Voornaaminvoer.Name = "Voornaaminvoer";
            this.Voornaaminvoer.Size = new System.Drawing.Size(171, 22);
            this.Voornaaminvoer.TabIndex = 3;
            this.Voornaaminvoer.TextChanged += new System.EventHandler(this.Voornaam_Texbox_TextChanged);
            // 
            // famillienaaminvoer
            // 
            this.famillienaaminvoer.Location = new System.Drawing.Point(131, 39);
            this.famillienaaminvoer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.famillienaaminvoer.Name = "famillienaaminvoer";
            this.famillienaaminvoer.Size = new System.Drawing.Size(171, 22);
            this.famillienaaminvoer.TabIndex = 4;
            this.famillienaaminvoer.TextChanged += new System.EventHandler(this.famillienaam_Textbox_TextChanged);
            // 
            // aanspreking_Textbox
            // 
            this.aanspreking_Textbox.Location = new System.Drawing.Point(131, 107);
            this.aanspreking_Textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aanspreking_Textbox.Name = "aanspreking_Textbox";
            this.aanspreking_Textbox.Size = new System.Drawing.Size(171, 22);
            this.aanspreking_Textbox.TabIndex = 5;
            this.aanspreking_Textbox.TextChanged += new System.EventHandler(this.aanspreking_Textbox_TextChanged);
            // 
            // Aanspreking_Button
            // 
            this.Aanspreking_Button.Location = new System.Drawing.Point(131, 71);
            this.Aanspreking_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Aanspreking_Button.Name = "Aanspreking_Button";
            this.Aanspreking_Button.Size = new System.Drawing.Size(172, 28);
            this.Aanspreking_Button.TabIndex = 6;
            this.Aanspreking_Button.Text = "Toon Aanspreking";
            this.Aanspreking_Button.UseVisualStyleBackColor = true;
            this.Aanspreking_Button.Click += new System.EventHandler(this.Aanspreking_Button_Click);
            // 
            // Sluiten
            // 
            this.Sluiten.Location = new System.Drawing.Point(131, 139);
            this.Sluiten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sluiten.Name = "Sluiten";
            this.Sluiten.Size = new System.Drawing.Size(172, 31);
            this.Sluiten.TabIndex = 7;
            this.Sluiten.Text = "Sluiten";
            this.Sluiten.UseVisualStyleBackColor = true;
            this.Sluiten.Click += new System.EventHandler(this.Sluiten_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(259, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 17);
            this.linkLabel1.TabIndex = 8;
            // 
            // Aanspreking_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 229);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Sluiten);
            this.Controls.Add(this.Aanspreking_Button);
            this.Controls.Add(this.aanspreking_Textbox);
            this.Controls.Add(this.famillienaaminvoer);
            this.Controls.Add(this.Voornaaminvoer);
            this.Controls.Add(this.Aanspreking);
            this.Controls.Add(this.familienaam);
            this.Controls.Add(this.Voornaam);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Aanspreking_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Voornaam;
        private System.Windows.Forms.Label familienaam;
        private System.Windows.Forms.Label Aanspreking;
        private System.Windows.Forms.TextBox Voornaaminvoer;
        private System.Windows.Forms.TextBox famillienaaminvoer;
        private System.Windows.Forms.TextBox aanspreking_Textbox;
        private System.Windows.Forms.Button Aanspreking_Button;
        private System.Windows.Forms.Button Sluiten;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

