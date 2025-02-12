//grading id: S2312
//Program 4
//due 4/17/2023
//cis-199-02-4232
//this program is used to display a list of dogs and cats at a shelter and all of their relevant information for anyone who wants to adopt them
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    public class Dogs
    {

        private string DogName; //dog name string
        private string DogBreed; // dog breed string 
        private string DogGender; //dog gender string
        private int DogAge; //dog age integer
        private string DogFurColor; // dog fur color string
        private double DogPrice; //dog price as a double
        private bool DogAvailability; //dog availability as a boolean


        //precondition: none
        //postcondition: Dogs is constructed using the name, breed, gender, age, fur color, price
        public Dogs(string DogName, string DogBreed, string DogGender, int DogAge, string DogFurColor, double DogPrice)
        {
            this.DogName = DogName; 
            this.DogBreed = DogBreed;
            this.DogGender = DogGender;
            this.DogAge = DogAge;
            this.DogFurColor = DogFurColor;
            this.DogPrice = DogPrice;
            isAvailable();//setting all the dogs to be available
        }

        public string dogName
        {
            //precondition: none
            //postcondition: dog name is returned
            get { return DogName; }
            //precondition: none
            //postcondition: dog name is set to a specified value
            set { DogName = value; }
        }
        public string dogBreed
        {
            //precondition: none
            //postcondition: dog breed is returned
            get { return DogBreed; }
            //precondition: none
            //postcondition: dog breed is set to a specified value
            set { DogBreed = value; }
        }
        public string dogGender
        {
            //precondition: none
            //postcondition: dog gender is returned
            get { return DogGender; }
            //precondition: none
            //postcondition: dog gender is set to a specified value
            set { DogGender = value; }
        }
        public int dogAge
        {
            //precondition: none 
            //postcondition: dog age is returned
            get { return DogAge; }
            //precondition: dog age >= 0
            //postcondition: dog age is set to a specified value if >= 0
            set
            {
                if (DogAge >= 0)
                {
                    DogAge = value;
                }
                else //if dog age <0 then dog age is set to 3
                {
                    DogAge = 3;
                }
            }
        }
        public string dogFurColor
        {
            //precondition: none 
            //postcondition: dog fur color is returned
            get { return DogFurColor; }
            //precondition: none
            //postcondition: dog fur color set to a specified value
            set { DogFurColor = value; }
        }
        public double dogPrice
        {
            //precondition: none
            //postcondition: dog price is returned
            get { return DogPrice; }
            //precondition: none
            //postcondition: dog price is set to a specified value
            set { DogPrice = value; }
        }


        //precondition: none
        //postcondition: dog availability is changed to true
        public void isAvailable()
        {
            DogAvailability = true;
        }
        //precondition: none
        //postcondition: dog availability is changed to false
        public void isAdopted()
        {
            DogAvailability = false;
        }
        //precondition: none
        //postcondition: dog availability is returned
        public bool Availability()
        {
            return DogAvailability;
        }



        //precondition: none
        //postcondition: the dog info is returned as a string
        public override string ToString()
        {
            return $"Name: {dogName}{Environment.NewLine}" +
                   $"Breed: {dogBreed}{Environment.NewLine}" +
                   $"Gender: {dogGender}{Environment.NewLine}" +
                   $"Age: {dogAge}{Environment.NewLine}" +
                   $"Fur Color: {dogFurColor}{Environment.NewLine}" +
                   $"Price: {dogPrice:C}{Environment.NewLine}" +
                   $"Is available: {Availability()}{Environment.NewLine}"
                   ;

        }
    }
}
