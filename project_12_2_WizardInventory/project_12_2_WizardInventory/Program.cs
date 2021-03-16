using bmdb_console;
using System;
using System.Collections.Generic;

namespace project_12_2_WizardInventory {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("The Wizard Inventory Game\n");
            //declare a wizard inventory with three items
            List<String> inventory = new List<string>();
            inventory.Add("wooden staff");
            inventory.Add("wizard hat");
            inventory.Add("cloth shoes");

            showMenu();
            string[] validChoices = new string[] { "show", "grab", "edit", "drop", "exit" };
            String choice = MyConsole.getChoiceString("Command: ", validChoices);
            while (choice != "exit") {
                switch (choice) {
                    case "show":
                        for (int i = 0; i < inventory.Count; i++) {
                            Console.WriteLine(i + 1 + ". " + inventory[i]);
                        }
                        Console.WriteLine(" ");
                        break;
                    case "grab":
                        if (inventory.Count == 4) {
                            Console.WriteLine("You can't carry any more items. Drop something first.");
                        } else {
                            String newItem = MyConsole.getRequiredString("Name: ");
                            inventory.Add(newItem);
                            Console.WriteLine(newItem + " was added.");
                        }
                        break;
                    case "edit":
                        int id = MyConsole.getInt("Number: ", 0, inventory.Count + 1);
                        //(items.get(itemNbr - 1) != null)
                        if (inventory[id - 1] == null) {
                            Console.WriteLine("Item number not valid.");
                        } else {
                            String newItem = MyConsole.getRequiredString("Updated name: ");
                            inventory[id - 1] = newItem;
                            Console.WriteLine("Item " + id + " was updated.");
                        }

                        break;
                    case "drop":
                        id = MyConsole.getInt("Number: ", 0, inventory.Count + 1);
                        //(items.get(itemNbr - 1) != null)
                        if (inventory[id - 1] == null) {
                            Console.WriteLine("Item number not valid.");
                        } else {
                            String droppedItemName = inventory[id - 1];
                            inventory.RemoveAt(id - 1);
                            Console.WriteLine(droppedItemName + " was dropped.");
                        }
                        break;
                    case "exit":
                        break;
                    default:
                        break;
                }

                choice = MyConsole.getChoiceString("Command: ", validChoices);

            }







            Console.WriteLine("bye");
        }
        public static void showMenu() {
            Console.WriteLine("COMMAND MENU");
            Console.WriteLine("show - Show all items");
            Console.WriteLine("grab - Grab an item");
            Console.WriteLine("edit - Edit an item");
            Console.WriteLine("drop - Drop an item");
            Console.WriteLine("exit - Exit program\n");
        }
    }


}
