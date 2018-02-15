using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        //string message1 = "blablabla";
        static void Main(string[] args)
        {
            Personne[] personnes = new Personne[10];
            Console.BackgroundColor = ConsoleColor.Green;
            for(int i = 0 ; i < personnes.Length;i++){
                string nom = "nom" + i;
                string prenom = "prenom" + i;
                int age = i * 2;
                personnes[i] = new Personne(nom,prenom,age);
            }
            foreach( Personne p in personnes){
                EcrireSurEcran(p,2,2);
            }
            
           // Console.WriteLine(personnes[0].ToString());

            Console.ReadKey();
        }
        static void EcrireSurEcran(Personne p,int x ,int y)
        {
            for (int u = 0; u < y; u++)
            {
                for (int i = 0; i < x; i++)
                {

                    Console.Write(p.ToString());
                }
                Console.WriteLine("");
            }
        }
    }
    class Personne
    {
        public string Nom="nom_a_inserer";
        public string Prenom="prenom_a_inserer";
        private int Age=0;
        public Personne(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }
        public int DelegateAge
        {
            get
            {
                return Age;
            }
            set
            {
                Age = value;
            }
        }
        public override string ToString()
        {

            return Nom + " " + Prenom + " " + Age                ;
        } 
    }
}
