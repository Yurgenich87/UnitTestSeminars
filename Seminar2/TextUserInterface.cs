using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar2
{
    using System;
using System.Collections.Generic;

public class TextUserInterface
{
    private Shop shop;
    private Cart cart;
    private int userChoice = 0;

    public TextUserInterface(Shop shop)
    {
        this.shop = shop;
        cart = new Cart(shop);
        Menu();
    }

    public void StartScreen()
    {
        Console.WriteLine("Выберите одно из действий:");
        Console.WriteLine("1. Показать список доступных продуктов");
        Console.WriteLine("2. Перейти в корзину");
        Console.WriteLine("0. Выход");
    }

    public void StoreProductsMenu()
    {
        Console.WriteLine("Выберите одно из действий:");
        Console.WriteLine("1. Добавить в корзину");
        Console.WriteLine("2. Удалить из корзины");
        Console.WriteLine("0. Выход");
    }

    public void Menu()
    {
        do
        {
            StartScreen();
            GetUserInput();

            switch (userChoice)
            {
                case 1:
                    DisplayStoreProducts();
                    StoreProductsMenu();
                    GetUserInput();
                    InnerChoice();
                    break;
                case 2:
                    ShowCart();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        } while (userChoice != 0);
    }

    private void InnerChoice()
    {
        switch (userChoice)
        {
            case 1:
                AddProductToCart();
                ShowCart();
                break;
            case 2:
                RemoveProductFromCart();
                ShowCart();
                break;
            default:
                break;
        }
    }

    private int GetUserInput()
    {
        userChoice = int.Parse(Console.ReadLine());
        return userChoice;
    }

    private void DisplayStoreProducts()
    {
        List<Product> products = shop.GetProductsShop();
        string format = "{0,-3}| {1,-20}| {2,-9}| {3,-3}\n"; // Ширина строк
        Console.WriteLine(string.Format(format, "ID", "Название", "Цена, р.", "Кол-во в магазине, шт."));
        foreach (Product prod in products)
        {
            Console.WriteLine(string.Format(format, prod.GetId(), prod.GetName(), prod.GetPrice(), prod.GetQuantity()));
        }
        Console.WriteLine();
    }

    private void AddProductToCart()
    {
        Console.WriteLine("Введите ID продукта, который хотите добавить в корзину:");
        int id = GetUserInput();
        cart.AddProductToCartById(id);
    }

    private void ShowCart()
    {
        cart.PrintCartItems();
    }

    private void RemoveProductFromCart()
    {
        Console.WriteLine("Введите ID продукта, который хотите удалить:");
        int id = GetUserInput();
        cart.RemoveProductById(id);
    }
}

}
