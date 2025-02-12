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
    public class Cats
    {

        private string CatName;//the variable for each cat name
        private string CatBreed;//variable for cat breed
        private string CatGender;//variable for cat gender
        private int CatAge;//variable for cat age
        private string CatFurColor;//variable for cat fur color
        private double CatPrice;//variable for cat price
        private bool CatAvailability;//variable for cat availability

        //precondition: none
        //postcondition: Cats is constructed using the name, breed, gender, age, fur color, and price
        public Cats (string CatName, string CatBreed, string CatGender, int CatAge, string CatFurColor, double CatPrice)
        {
            this.CatName = CatName;
            this.CatBreed = CatBreed;
            this.CatGender = CatGender; 
            this.CatAge = CatAge;
            this.CatFurColor= CatFurColor;
            this.CatPrice = CatPrice;
            isAvailable();//setting all the cats to be available
        }

        public string catName
        {
            //precondition: none
            //postcondition: cat name is returned
            get { return CatName; }
            //precondition: none
            //postcondition: cat name is set to a specified value
            set { CatName = value; }
        }
        public string catBreed
        {
            //precondition: none
            //postcondition: cat breed is returned
            get { return CatBreed; }
            //precondition: none
            //postcondition: cat breed is set to specified value
            set { CatBreed = value; }
        }
        public string catGender
        {
            //precondition: none
            //postcondition: cat Gender is returned
            get { return CatGender; }
            //precondition: none
            //postcondition: cat gender is set to specified value
            set { CatGender = value; }
        }
        public int catAge
        {
            //precondition: none 
            //postcondition: cat age is returned
            get { return CatAge; }
            //precondition: Cat age is >= 0
            //postcondition:The cat age has been set to a specified value
            set
            {
                if (catAge >= 0)
                {
                    CatAge = value;
                }
                else // cat age is set to 3 if value is less then 0
                {
                    CatAge = 3;
                }
            }
        }
        public string catFurColor
        {
            //precondition: none
            //postcondition: The cat fur color has been returned
            get { return CatFurColor;}
            //precondition: none 
            //postcondition: cat fur color is set to specified value
            set { CatFurColor = value; }
        }
        public double catPrice
        {
            //precondition: none
            //postcondition: cat price is returned
            get { return CatPrice; }
            //precondition: none
            //postcondition: cat price is set to specified value
            set { CatPrice = value; }
        }


        //precondition: none
        //postcondition: cat availability is changed to true
        public void isAvailable()
        {
            CatAvailability = true;
        }
        //precondition: none
        //postcondition: cat availability is changed to false
        public void isAdopted()
        {
            CatAvailability= false;
        }
        //precondition: none
        //postcondition: cat availability is returned
        public bool Availability()
        {
            return CatAvailability;
        }

        //precondition: none
        //postcondition: The cat info is returned as a string
        public override string ToString()
        {
            return $"Name: {catName}{Environment.NewLine}" +
                   $"Breed: {catBreed}{Environment.NewLine}" +
                   $"Gender: {catGender}{Environment.NewLine}" +
                   $"Age: {catAge}{Environment.NewLine}" +
                   $"Fur Color: {catFurColor}{Environment.NewLine}" +
                   $"Price: {catPrice:C}{Environment.NewLine}" +
                   $"Is available: {Availability()}{Environment.NewLine}"
                   ;
        }

    }
}
