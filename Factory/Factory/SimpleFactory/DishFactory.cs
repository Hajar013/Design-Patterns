using Factory.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.SimpleFactory { 

    public class DishFactory
    {
        public static IAppetizer CreateAppetizer(string dishType)

        {
            switch (dishType)
            {
                case "ChickenSalad":
                   return new ChickenSalad("Small", "350-450", 08.99m, new List<string>() { "Chicken", "Lettuce", "Tomatoes", "Cucumbers", "Salad dressing" });
                    break;
                case "ButterCracker":
                    return new ButterCracker("Small", "70-80", 09.99m, new List<string>() { "Flour", "Butter", "Salt" });
                    break;
                case "CheeseTwist":
                    return new CheeseTwist("Small", "100-150", 07.99m, new List<string>() { "Puff pastry", "Cheese", "Egg", "Salt" });
                    break;
                case "PotatoBite":
                    return new PotatoBite("Small", "200-250", 05.99m, new List<string>() { "Potato", "Cheese", "Breadcrumbs", "Egg" });
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

           

        }

        public static IMainCourse CreateMainCourse(string dishType)
        {
            switch (dishType)
            {
                case "Lasagna":
                   return new Lasagna("Large", "300-600", 14.99m, new List<string>() { "Pasta", "Cheese", "Tomato", "Beef" });
                    break;
                case "Steak":
                    return new Steak("Medium", "500-700", 17.99m, new List<string>() { "Beef steak", "Salt", "Pepper" });
                    break;
                case "Molokhiya":
                   return new Molokhiya("Medium", "100-200", 16.99m, new List<string>() { "Molokhiya leaves", "Chicken broth", "Garlic", "Coriander" });
                    break;
                case "GrilledChicken":
                    return new GrilledChicken("Large", "200-300", 15.99m, new List<string>() { "Chicken", "Salt", "Pepper", "Paprika" });
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

           
        }

        public static IDessert CreateDessert(string dishType)
        {
            switch (dishType)
            {
                case "FruitSalad":
                    return new FruitSalad("Medium", "100-150", 07.99m, new List<string>() { "Apple", "Banana", "Orange", "Berries" });
                    break;
                case "Tiramisu":
                    return new Tiramisu("Small", "400-600", 08.99m, new List<string>() { "Ladyfingers", "Coffee", "Egg yolks", "Mascarpone cheese", "Cocoa powder" });
                    break;
                case "Browny":
                   return new Browny("Medium", "150-250", 07.99m, new List<string>() { "Sugar", "Butter", "Cocoa powder", "Eggs", "Flour", "Vanilla extract" });
                    break;
                case "IceCream":
                    return new IceCream("Small", "200-250", 06.99m, new List<string>() { "Milk", "Sugar", "Cream", "Egg yolks", "Vanilla extract" });
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            
        }
    }
}
