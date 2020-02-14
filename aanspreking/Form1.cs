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
            string voornaam, famillienaam, aanspreking;
            string voorinitiaal, famillieInitiaal, famillierest;

            voornaam = Voornaaminvoer.Text;

            famillienaam = famillienaaminvoer.Text;

            voorinitiaal = voornaam.Substring(0, 1).ToUpper();
            famillieInitiaal = famillienaam.Substring(0,1)

        }

        private void aanspreking_Textbox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
