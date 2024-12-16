using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fp_EmilySierra
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int count = 0;
            int choice;
            Car[] carArray = new Car[5];


            Boolean keepGoing = true;


            while(keepGoing) {
                //prompt user for input
                Console.WriteLine("Emily's car shop ");
                Console.WriteLine("Option 1: Add a car");
                Console.WriteLine("Option 2: Display all cars");
                Console.WriteLine("Option 3: Remove a car");
                Console.WriteLine("Option 4: Write to file");
                Console.WriteLine("Option 5: Exit");
                Console.WriteLine("Enter your choice: ");
                //read the input
                choice = Convert.ToInt32(Console.ReadLine());
            
                switch (choice)
            {
                case 1:


                        Console.WriteLine("Enter the name of the car: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the model of the car: ");
                        string model = Console.ReadLine();
                        Console.WriteLine("Enter the color of the car: ");
                        string color = Console.ReadLine();
                        Console.WriteLine("Enter the year of the car: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the price of the car: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        //add the car to the array
                        carArray[count] = new Car(name, model, color, year, price);
                        count++;
                        Console.WriteLine("Car added to the shop!");

                        break;
                case 2:

                        try { 
                    Console.WriteLine("All the cars in the shop:");
                        bool isEmpty = true;
                            for (int i = 0; i < carArray.Length; i++)
                        {
                            if (carArray[i] != null)
                            {
                                Console.WriteLine(carArray[i].ToString());
                            }
                        }
                        if(isEmpty)
                            {
                                Console.WriteLine("No cars currently in the shop");
                            }
                        } //end of try
                       catch (Exception e) {
                            Console.WriteLine("Exception: " + e.Message);
                        }
                        //keepGoing = true;
                        break;
                case 3:
                        //remove a car
                        Console.WriteLine("Enter the name of the car you want to remove: ");
                        string carName = Console.ReadLine();
                        for (int i = 0; i < carArray.Length; i++)
                        {
                            if (carArray[i] != null && carArray[i].getName().Equals(carName))
                            {
                                carArray[i] = null;
                                Console.WriteLine("Car removed from the shop!");
                                break;
                            }
                        }
                        //keepGoing = true;
                        break;
                        
                case 4:

                        //did not have time to check if it did write to file
                        WriteCarToFile(carArray);
                        break;


                    case 5:
                        Console.WriteLine("Exiting.Goodbye!");
                        keepGoing = false;
                        break;

                 default:
                        Console.WriteLine("Invalid input. Please enter a number between 1&5");
                        break;
                } //end of switch

            } //end of while loop



        }
        //methods
        static void WriteCarToFile(Car[] carArray)
        {
            string filePath = "carData.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < carArray.Length; i++)
                {
                    if (carArray[i] != null)
                    {
                        writer.WriteLine(carArray[i].ToString());
                    }
                }
            }
            Console.WriteLine("Car was added to " + filePath);
        }
    }


    //car class
    class Car
    {
        //variables
        string name;
        string model;
        string color;
        int year;
        double price;


        public Car()
        {
            name = "";
            model = "";
            color = "";
            year = 0;
            price = 0.0;
        }
        public Car(string name, string model, string color, int year, double price)
        {
            this.name = name;
            this.model = model;
            this.color = color;
            this.year = year;
            this.price = price;
        }


        //getterrs and setters
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getModel()
        {
            return model;
        }
        public void setModel(string model)
        {
            this.model = model;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public int getYear()
        {
            return year;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public double getPrice()
        {
            return price;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }

        public string toString()
        {
            return "Name: " + name + "," + " Model: " + model + "," + " Color: " + color + "," + " Year: " + year + "," + " Price: " + price;
        }



    }

}
