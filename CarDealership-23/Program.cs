// See https://aka.ms/new-console-template for more information
using CarDealership_23;


Car mycar = new Car(12000, 2015, "Honda", "oddydey", "Grey");

Car car2 = new Car(22000, 2022, "Kia", "Sole", "Blue");
Car car3 = new Car(32000, 2023, "Tesla", "NewOne", "White");
Car car4 = new Car(45000, 2020, "Honda", "Pilot", "Black");
Car car5 = new Car(8000, 1995, "Lex", "Something", "Gold");
Car car6 = new Car(17400, 2005, "Toyota", "Sienna", "Pink");


List<Car> carInventory = new List<Car>();
carInventory.Add(mycar);
carInventory.Add(car2);
carInventory.Add(car3);
carInventory.Add(car4);
carInventory.Add(car5);
carInventory.Add(car6);
mycar.SetPrice(mycar.Price, "winter");
//Used with collections such as array, list, dictionary
foreach(Car car in carInventory)
{
    Console.WriteLine(car.Color);
}
//Know the set amount of times you want to iterate
for (int i = 0; i < carInventory.Count; i++)
{
    Console.WriteLine(carInventory[i].Make);
}

int num = 0;
while(num < 6) //must be true to execute at all
{
    Console.WriteLine(num);
    num++;
}
int num2 = 0; 
do //Will execute at least once
{
    Console.WriteLine(num);
    num2++;
}
while (num2 < 6);

