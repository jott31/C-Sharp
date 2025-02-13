//grading id: S2312
//Program 4
//due 4/17/2023
//cis-199-02-4232
//this program is used to display a list of dogs and cats at a shelter and all of their relevant information for anyone who wants to adopt them
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    internal class Program
    {
        //precondition: none
        //postcondition: everthing is combined to output the entire program when calling the display methods
        static void Main(string[] args)
        {
            //giving each cat their properties
            Cats cat1 = new Cats("Doug", "CatDog", "F", 4, "Orange", 2000);
            Cats cat2 = new Cats("Garfield", "Tabby", "M", 7, "Orange", 55000);
            Cats cat3 = new Cats("Jerome", "Bombay", "M", 2, "Black", 400);
            Cats cat4 = new Cats("Harold", "Sphinx", "M", 4, "Pink", 2300);
            Cats cat5 = new Cats("Cathie", "Siamese", "F", 10, "Yellow", 5555);

            //creating an array for the cats
            Cats[] cat = {cat1, cat2, cat3, cat4, cat5};

            //giving each dog their properties
            Dogs dog1 = new Dogs("Gerald", "Pitbull", "M", 2, "Teal", 320);
            Dogs dog2 = new Dogs("Princess", "Terrior", "F", 15, "Brown", 2);
            Dogs dog3 = new Dogs("Juanita", "Bulldog", "F", 4, "White", 32);
            Dogs dog4 = new Dogs("Elvis", "Golden Doodle", "M", 12, "Golden", 50);
            Dogs dog5 = new Dogs("Brian", "Labrador Retriever", "M", 6, "White", 440);

            //creating an array for the dogs
            Dogs[] dog = {dog1, dog2, dog3, dog4, dog5 };


            //displaying the list of pets title
            Console.WriteLine("List of pets: ");
            Console.WriteLine("-----------------------");

            //diplsaying the cats with all their properties
            DisplayCats(cat);
            Console.WriteLine("-----------------------");
            //displaying each dog and all their properties
            DisplayDogs(dog);

            //displaying the title for the first change
            Console.WriteLine("After First change: ");
            Console.WriteLine("-----------------------");

            //changing one property from each cat
            cat1.catName = "Freddy";
            cat2.isAdopted();
            cat3.catAge = 3;
            cat4.isAdopted();
            cat5.catAge = 11;

            //changing one property from each dog
            dog1.dogAge = 3;
            dog2.isAdopted();
            dog3.dogAge = 5;
            dog4.isAdopted();
            dog5.isAdopted();

            //displaying each cat after their first change
            DisplayCats(cat);
            Console.WriteLine("-----------------------");
            //displaying each dog after their first change
            DisplayDogs(dog);


            //displaying the title for the second change
            Console.WriteLine("After second change: ");
            Console.WriteLine("-----------------------");
            
            //changing a different property from each cat
            cat1.catAge = 5;
            cat2.catPrice = .50;
            cat3.isAdopted();
            cat4.catAge = 5;
            cat5.catName = "Berry";

            //changing a different property from each dog
            dog1.dogName = "Olive";
            dog2.dogAge = 16;
            dog3.dogName = "Thanos";
            dog4.dogAge = 13;
            dog5.dogPrice = 12873894789237408297;

            //displaying the cats after their second change
            DisplayCats(cat);
            Console.WriteLine("-----------------------");
            //displaying the dogs after their second change
            DisplayDogs(dog);

        }
        //method used to diplay the cats and their information
        //precondition: none
        //postcondition: displays the cats and their information
        public static void DisplayCats(Cats[] cats)
        {
            Console.WriteLine("Our Cats: ");
            foreach(Cats cat in cats)//finding each cat wihtin the array and displaying their information
            {
                Console.WriteLine(cat.ToString());
            }
        }
        //method used to displat the dogs and their information
        //precondition: none
        //postcondition: outputs each dog and their information
        public static void DisplayDogs(Dogs[] dogs)
        {
            Console.WriteLine("Our Dogs: ");
            foreach(Dogs dog in dogs)// finding each dog within the array and displaying their information
            {
                Console.WriteLine(dog.ToString());
            }
        }
    }
}
