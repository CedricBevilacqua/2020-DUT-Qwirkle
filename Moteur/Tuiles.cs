using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QwirkleGame
{
    public class Tuile
    {
        //Attributs
        private string Form; //Star, Cross, Lozenge, Flower, Circle, Square
        private string Color; //Yellow, Blue, Pink, Green, Orange, Red

        // Constructeur
        public Tuile(string Form, string Color)
        {
            this.Form = Form;
            this.Color = Color;
        }

        //Méthodes
        public string GetForme()
        {
            return Form;
        }

        public string GetCouleur()
        {
            return Color;
        }
    }
}
