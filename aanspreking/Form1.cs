//Enrick De Munter 5ITN nr3 
/*
 * ANALYSE
 * ========
 * Aanspreking.Load:
 * TOON     titels
 * TOON     
 * VRAAG voornaam fammilienaam 
 * 
 * BEREKEN  aanspreking
 *          BEREKEN     voorinitiaal 
 *          
 * TOON     voornaam.famillienaam wanneer op knop geduwt word
 * 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aanspreking
{
    public partial class Aanspreking_Form : Form
    {
        public Aanspreking_Form()
        {
            InitializeComponent();
        }

        private void Voornaam_Texbox_TextChanged(object sender, EventArgs e)
        {
            string voornaam;
            voornaam = Voornaaminvoer.Text;
            
        }

        private void famillienaam_Textbox_TextChanged(object sender, EventArgs e)
        {
            string famillienaam;
            famillienaam = famillienaaminvoer.Text;
            
        }

        private void Aanspreking_Button_Click(object sender, EventArgs e)
        {
            // VARIABELEN
            string voornaam, familienaam, aanspreking, toonAanspreking;
            string voorInitiaal, familieInitiaal, familieRest;

            // INPUT
            // LEES voornaam
            voornaam = Voornaaminvoer.Text;
            // LEES familienaam
            familienaam = famillienaaminvoer.Text;

            // PROCESSING
            // BEREKEN AANSPREKING
            // BEREKEN voorInitiaal (= eerst letter voornaam in hoofdletter)
            voorInitiaal = voornaam.Substring(0, 1).ToUpper();
            // BEREKEN FamilieInitiaal (= eerst letter familienaam in hoofdletter)
            familieInitiaal = familienaam.Substring(0, 1).ToUpper();

            familieRest = familienaam.Substring(1);
            //BEREKEN FamilieRest
            aanspreking = $"{voorInitiaal}. {familieInitiaal}{familieRest}";
          
            aanspreking_Textbox.Text = aanspreking;

        }

        private void aanspreking_Textbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Sluiten_Click(object sender, EventArgs e)
        {
            Close();


        }
        private void Aanspreking_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult antwoord = MessageBox.Show("sluit dit!");
            if (antwoord!=DialogResult.Yes)
            {
                e.Cancel = true;
            }
            
        }

    }
}
