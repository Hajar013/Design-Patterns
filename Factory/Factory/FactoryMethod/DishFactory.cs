using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod
{

    public abstract class DishFactory
    {
        public abstract IDish CreateDish();

    }

    public class ChickenSaladFactory : DishFactory
    {
        //  public override IAppetizer CreateDish()
        public override IDish CreateDish()
        {
            return new ChickenSalad("Small", "350-450", 08.99m, new List<string>() { "Chicken", "Lettuce", "Tomatoes", "Cucumbers", "Salad dressing" });
        }
    }

    public class ButterCrackerFactory : DishFactory
    {
        //  public override IAppetizer CreateDish()
        public override IDish CreateDish()
        {
            return new ButterCracker("Small", "70-80", 09.99m, new List<string>() { "Flour", "Butter", "Salt" });
        }
    }

    public class CheeseTwistFactory : DishFactory
    {
        //public override IAppetizer CreateDish()
        public override IDish CreateDish()
        {
            return new CheeseTwist("Small", "100-150", 07.99m, new List<string>() { "Puff pastry", "Cheese", "Egg", "Salt" });
        }
    }

    public class PotatoBiteFactory : DishFactory
    {
       /// public override IAppetizer CreateDish()
      public override IDish CreateDish()
        {
            return new PotatoBite("Small", "200-250", 05.99m, new List<string>() { "Potato", "Cheese", "Breadcrumbs", "Egg" });
        }
    }

    public class LasagnaFactory : DishFactory
    {
        public override IDish CreateDish()
        //public override IMainCourse CreateDish()
        {
            return new Lasagna("Large", "300-600", 14.99m, new List<string>() { "Pasta", "Cheese", "Tomato", "Beef" });
        }
    }

    public class SteakFactory : DishFactory
    {
        //public override IMainCourse CreateDish()
        public override IDish CreateDish()
        {
            return new Steak("Medium", "500-700", 17.99m, new List<string>() { "Beef steak", "Salt", "Pepper" });
        }
    }

    public class MolokhiyaFactory : DishFactory
    {
        //  public override IMainCourse CreateDish()
        public override IDish CreateDish()
        {
            return new Molokhiya("Medium", "100-200", 16.99m, new List<string>() { "Molokhiya leaves", "Chicken broth", "Garlic", "Coriander" });
        }
    }

    public class GrilledChickenFactory : DishFactory
    {
        //public override IMainCourse CreateDish()
        public override IDish CreateDish()
        {
            return new GrilledChicken("Large", "200-300", 15.99m, new List<string>() { "Chicken", "Salt", "Pepper", "Paprika" });
        }
    }

    public class FruitSaladFactory : DishFactory
    {
        //public override IDessert CreateDish()
        public override IDish CreateDish()
        {
            return new FruitSalad("Medium", "100-150", 07.99m, new List<string>() { "Apple", "Banana", "Orange", "Berries" });
        }
    }

    public class TiramisuFactory : DishFactory
    {
        //public override IDessert CreateDish()
        public override IDish CreateDish()
        {
            return new Tiramisu("Small", "400-600", 08.99m, new List<string>() { "Ladyfingers", "Coffee", "Egg yolks", "Mascarpone cheese", "Cocoa powder" });
        }
    }

    public class BrownyFactory : DishFactory
    {
        //public override IDessert CreateDish()

        public override IDessert CreateDish()
        {
            return new Browny("Medium", "150-250", 07.99m, new List<string>() { "Sugar", "Butter", "Cocoa powder", "Eggs", "Flour", "Vanilla extract" });
        }
    }

    public class IceCreamFactory : DishFactory
    {
        //public override IDessert CreateDish()
        public override IDish CreateDish()
        {
            return new IceCream("Small", "200-250", 06.99m, new List<string>() { "Milk", "Sugar", "Cream", "Egg yolks", "Vanilla extract" });
        }
    }
}
    