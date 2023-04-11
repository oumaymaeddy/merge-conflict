using System;
namespace appBancaire
{
    public class compte_bancaire
    {
        public string Id;
        public string Nom;
        public string Prenom;
        public int Numero_telephone;
        public string Adresse;

        public compte_bancaire(string nom, string prenom, int numero_telephone, string adresse)
        {
            
            Random rand = new Random();
            int NUMBER = rand.Next(100000, 999999);
            Id = $"001{NUMBER:D6}";
            
            Nom = nom;
            Prenom = prenom;
            Numero_telephone = numero_telephone;
            Adresse = adresse;


        }



    }
}

