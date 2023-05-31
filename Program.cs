using System;
using System.Collections.Generic;

class Program
{
    static List<string> itemList = new List<string>();

    static void Main(string[] args) {  
        int exit = 0;
        do {
            Console.WriteLine("Selecione uma operação:");
            Console.WriteLine("1 - Criar item");
            Console.WriteLine("2 - Ler itens");
            Console.WriteLine("3 - Atualizar item");
            Console.WriteLine("4 - Deletar item");
            Console.WriteLine("5 - Sair");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) {
                case 1:
                    CreateItem();
                    break;
                case 2:
                    ReadItems();
                    break;
                case 3:
                    UpdateItem();
                    break;
                case 4:
                    DeleteItem();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (exit != 5)
    }

    static void CreateItem() {
        Console.WriteLine("Digite o item a ser criado:");
        string item = Console.ReadLine();
        itemList.Add(item);
        Console.WriteLine("Item criado com sucesso!");
    }

    static void ReadItems() {
        if (itemList.Count > 0) {
            Console.WriteLine("Itens na lista:");
            foreach (string item in itemList)
            {
                Console.WriteLine(item);
            }
        } else {
            Console.WriteLine("A lista está vazia.");
        }
    }

    static void UpdateItem() {
        Console.WriteLine("Digite o índice do item a ser atualizado:");
        int index = Convert.ToInt32(Console.ReadLine());
        if (index >= 0 && index < itemList.Count) {
            Console.WriteLine("Digite o novo valor do item:");
            string newItem = Console.ReadLine();
            itemList[index] = newItem;
            Console.WriteLine("Item atualizado com sucesso!");
        } else {
            Console.WriteLine("Índice inválido.");
        }
    }

    static void DeleteItem() {
        Console.WriteLine("Digite o índice do item a ser deletado:");
        int index = Convert.ToInt32(Console.ReadLine());
        if (index >= 0 && index < itemList.Count) {
            itemList.RemoveAt(index);
            Console.WriteLine("Item deletado com sucesso!");
        } else {
            Console.WriteLine("Índice inválido.");
        }
    }
}
