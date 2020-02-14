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
            this.SuspendLayout();
            // 
            // Voornaam
            // 
            this.Voornaam.AutoSize = true;
            this.Voornaam.Location = new System.Drawing.Point(12, 9);
            this.Voornaam.Name = "Voornaam";
            this.Voornaam.Size = new System.Drawing.Size(54, 13);
            this.Voornaam.TabIndex = 0;
            this.Voornaam.Text = "voornaam";
            // 
            // familienaam
            // 
            this.familienaam.AutoSize = true;
            this.familienaam.Location = new System.Drawing.Point(12, 32);
            this.familienaam.Name = "familienaam";
            this.familienaam.Size = new System.Drawing.Size(64, 13);
            this.familienaam.TabIndex = 1;
            this.familienaam.Text = "famillienaam";
            // 
            // Aanspreking
            // 
            this.Aanspreking.AutoSize = true;
            this.Aanspreking.Location = new System.Drawing.Point(12, 94);
            this.Aanspreking.Name = "Aanspreking";
            this.Aanspreking.Size = new System.Drawing.Size(65, 13);
            this.Aanspreking.TabIndex = 2;
            this.Aanspreking.Text = "aanspreking";
            // 
            // Voornaaminvoer
            // 
            this.Voornaaminvoer.Location = new System.Drawing.Point(98, 6);
            this.Voornaaminvoer.Name = "Voornaaminvoer";
            this.Voornaaminvoer.Size = new System.Drawing.Size(129, 20);
            this.Voornaaminvoer.TabIndex = 3;
            this.Voornaaminvoer.TextChanged += new System.EventHandler(this.Voornaam_Texbox_TextChanged);
            // 
            // famillienaaminvoer
            // 
            this.famillienaaminvoer.Location = new System.Drawing.Point(98, 32);
            this.famillienaaminvoer.Name = "famillienaaminvoer";
            this.famillienaaminvoer.Size = new System.Drawing.Size(129, 20);
            this.famillienaaminvoer.TabIndex = 4;
            this.famillienaaminvoer.TextChanged += new System.EventHandler(this.famillienaam_Textbox_TextChanged);
            // 
            // aanspreking_Textbox
            // 
            this.aanspreking_Textbox.Location = new System.Drawing.Point(98, 87);
            this.aanspreking_Textbox.Name = "aanspreking_Textbox";
            this.aanspreking_Textbox.Size = new System.Drawing.Size(129, 20);
            this.aanspreking_Textbox.TabIndex = 5;
            this.aanspreking_Textbox.TextChanged += new System.EventHandler(this.aanspreking_Textbox_TextChanged);
            // 
            // Aanspreking_Button
            // 
            this.Aanspreking_Button.Location = new System.Drawing.Point(98, 58);
            this.Aanspreking_Button.Name = "Aanspreking_Button";
            this.Aanspreking_Button.Size = new System.Drawing.Size(129, 23);
            this.Aanspreking_Button.TabIndex = 6;
            this.Aanspreking_Button.Text = "Toon Aanspreking";
            this.Aanspreking_Button.UseVisualStyleBackColor = true;
            this.Aanspreking_Button.Click += new System.EventHandler(this.Aanspreking_Button_Click);
            // 
            // Aanspreking_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aanspreking_Button);
            this.Controls.Add(this.aanspreking_Textbox);
            this.Controls.Add(this.famillienaaminvoer);
            this.Controls.Add(this.Voornaaminvoer);
            this.Controls.Add(this.Aanspreking);
            this.Controls.Add(this.familienaam);
            this.Controls.Add(this.Voornaam);
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
    }
}

