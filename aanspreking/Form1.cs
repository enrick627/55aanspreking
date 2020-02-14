//Enrick De Munter 5ITN nr3 
/*
 * ANALYSE
 * ========
 * VRAAG voornaam fammilienaam 
 * 
 * BEREKEN  eerste letter van voornaam (string.substring(0,1).toupper)
 *          famillienaam in hoofdletters(string.toupper)
 *          
 * TOON     voornaam.famillienaam wanneer op knop geduwt word
 // VRAAG voornaam fammilienaam 
 // 
 // BEREKEN  eerste letter van voornaam (string.substring(0,1).toupper)
 //          famillienaam in hoofdletters(string.toupper)
 //          
 // TOON     voornaam.famillienaam wanneer op knop geduwt word
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
            voornaam = Console.ReadLine();
        }

        private void famillienaam_Textbox_TextChanged(object sender, EventArgs e)
        {
            string famillienaam;
            famillienaam = Console.ReadLine();
            
        }

        private void Aanspreking_Button_Click(object sender, EventArgs e)
        {
            

        }

        private void aanspreking_Textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
