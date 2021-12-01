using System;

namespace OOPPet
{
    class Program
    {
        class Car
        {
            string name;
            string model;
            int number;
            string color;
            int odometer;
            int fuel;


        }
            public Car(string _name)
            {
            name = name;
            model = "rx7";
            number = "24124";
            color = "Red";
            odometer = 0;
            fuel = 60;


        }

        //getter for weight
        public double Weight
            {
                get { return weight; }
            }

            public void ShowPetInfo()
            {
                Console.WriteLine($"Name: {name}.");
                Console.WriteLine($"Age: {age}.");
                Console.WriteLine($"Weight: {weight}.");
            }

            public void Eat()
            {
                weight += 0.2; //weight = weight + 0.2
                Console.WriteLine("Omnomnom");
            }
            public void Run()
            {
                weight -= 0.1;
                Console.WriteLine("spin-spin-spin");
            }

            //desctructor
            //~Pet()
            //{
            //    Console.WriteLine($"RIP {name}");
            //}
            static void Main(string[] args)
            {
                Pet myPet = new Pet("Hamster");
                myPet.ShowPetInfo();

                for (int i = 0; i < 10; i++)
                {
                    myPet.Eat();
                    Console.WriteLine($"Current weigth: {myPet.Weight}");
                    if (myPet.Weight >= 0.7)
                    {
                        while (myPet.Weight > 0.7)
                        {
                            myPet.Run();
                            Console.WriteLine($"Weight after workout: {myPet.Weight}");
                        }
                    }
                }

                //GC.Collect();
            }
        }
    }