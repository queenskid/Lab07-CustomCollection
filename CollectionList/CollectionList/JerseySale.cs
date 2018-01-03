using System;

namespace CollectionList
{
    class JerseySale
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Visitors");
        }

        public static void StoreLoop(Inventory<Product> inventory, Inventory<Product> cart)
        {
            Console.Clear();


            Inventory<Product> myCart = new Inventory<Product>();
            Inventory<Product> saveShop = inventory;
            Inventory<Product> saveCart = myCart;


            int index = 0;
            int cartIndex = 0;


            Console.WriteLine("");
            Console.WriteLine();

            try
            {
                foreach (Product item in inventory)
                {
                    Console.WriteLine($"{index}): ITEM: {item.ProductName} - {item.Category}");
                    index++;
                }


                Console.WriteLine();
                Console.WriteLine("Your Cart:");
                Console.WriteLine();


                foreach (Product item in cart)
                {
                    Console.WriteLine($"{cartIndex}): ITEM: {item.ProductName} - {item.Category}");
                    cartIndex++;
                }


                int input = Convert.ToInt32(Console.ReadLine());

                cart.Add(inventory.Remove(input));
                StoreLoop(inventory, cart);
            }
            catch (Exception)
            {
                Console.WriteLine("");
                StoreLoop(saveShop, saveCart);
            }
        }
    }
}
