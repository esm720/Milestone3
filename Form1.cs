using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone3
{/*
  * Enrique Sanchezmurillo
  * CST-150
  * Milestone 3
  * 14 AUG 2022
  */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //******************************USER INVENTORY BUTTONS****************************//
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            //Below we created the object to display our inventory
            inventoryManager inventoryManager = new inventoryManager();
            inventoryManager.showInventory();
        }
    //ADD DRIVER METHOD
        public void AddItemButton_Click(object sender, EventArgs e)
        {
            //Declare Variables for the search
            string searchName;
            int searchPrice;
            int quantity;
            //Beflow we create an object for the inventory
            inventoryManager inventory = new inventoryManager();
            //Below we check to see if the user has input the information needed to search and add the item
            try
            {
                searchName = NameInputText.Text;
            }
            catch (Exception)
            {
                searchName = " ";
            }

            try
            {
                searchPrice = int.Parse(PriceInputText.Text);
            }
            catch(Exception)
            {
                searchPrice = 0;
            }
            try
            {
                quantity = int.Parse(QuantityInputText.Text);
            }
            catch (Exception)
            {
                quantity = 0;
            }
            //Below we determine if we are able to pass a value to add to our inventory
            if (quantity > 0)
            {

                if (searchName.Length > 0)
                {
                    inventory.addInventory(searchName, 0, quantity);
                }
                else if (searchPrice > 0)
                {
                    inventory.addInventory(" ", searchPrice, quantity);
                }
                else
                {
                    MessageBox.Show("Please include a name or price.");
                }
            }
            else
            {
                MessageBox.Show("Quantity can not be empty.");
            }

        }
        //Below, remove button is EXACTLY the same as the add button but functions are reversed.
    //REMOVE DRIVER METHOD
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string searchName;
            int searchPrice;
            int quantity;
            inventoryManager inventory = new inventoryManager();
            try
            {
                searchName = NameInputText.Text;
            }
            catch (Exception)
            {
                searchName = " ";
            }

            try
            {
                searchPrice = int.Parse(PriceInputText.Text);
            }
            catch (Exception)
            {
                searchPrice = 0;
            }
            try
            {
                quantity = int.Parse(QuantityInputText.Text);
            }
            catch (Exception)
            {
                quantity = 0;
            }

            if (quantity > 0)
            {

                if (searchName.Length > 0)
                {
                    inventory.removeInventory(searchName, 0, quantity);
                }
                else if (searchPrice > 0)
                {
                    inventory.removeInventory(" ", searchPrice, quantity);
                }
                else
                {
                    MessageBox.Show("Please include a name or price.");
                }
            }
            else
            {
                MessageBox.Show("Quantity can not be empty.");
            }
        }

        //*********************************USER INVENTORY CLASS**************************//
        class inventoryManager
        {
        //Below we created the variables needed to keep track of our inventory through the ENTIRE class
            const int ROWS = 2;
            const int COLS = 4;
            static string[,] inventoryArray = new string[ROWS,COLS];
            static int xQuant = 0;
            static int psQuant = 0;

        //Below we create the inventory
        public void createInventory()
            {
            StoreInventory storeInventory = new StoreInventory();
            //Below we fill the inventory array

                inventoryArray[0, 0] = storeInventory.Xbox("name", 0);
                inventoryArray[0, 1] = storeInventory.Xbox("description", 0);
                inventoryArray[0, 2] = storeInventory.Xbox("price", 0);
                inventoryArray[0, 3] = xQuant.ToString();
                inventoryArray[1, 0] = storeInventory.PlayStation("name", 0);
                inventoryArray[1, 1] = storeInventory.PlayStation("description", 0);
                inventoryArray[1, 2] = storeInventory.PlayStation("price", 0);
                inventoryArray[1, 3] = psQuant.ToString();
            }

        //Below we created a method to show our inventory by displaying the 2D array.
   //DISPLAY DRIVER METHOD
        public void showInventory()
            {
                
                StoreInventory storeInventory = new StoreInventory();

                    int xboxQuant = int.Parse(inventoryArray[0,3]);
                    int playStationQuant = int.Parse(inventoryArray[1,3]);
                    int totalItems = xboxQuant + playStationQuant;
          //As long as the inventory is not empty, we can show the items
                if (totalItems > 0) 
                {
                    MessageBox.Show("Name: " + inventoryArray[0, 0] + "\nDescription: " + inventoryArray[0, 1]+ "\n Price: " + inventoryArray[0,2] + "\nQuantity: "+ inventoryArray[0,3]);
                    MessageBox.Show("Name: " + inventoryArray[1, 0] + "\nDescription: " + inventoryArray[1, 1] + "\n Price: " + inventoryArray[1, 2] + "\nQuantity: " + inventoryArray[1, 3]);
                }
                else
                {
                    MessageBox.Show("Empty");
                }

            }
    //ADD AND SEARCH METHOD
        public void addInventory(string prodName, int price, int quantity)
            {
                inventoryManager inventoryManager = new inventoryManager();
                StoreInventory storeInventory = new StoreInventory();
                int storeQuant;
                //We use a nested for loop to search for an item match
                for(int row = 0; row < ROWS; row++)
                {
                    for(int col = 0; col < ROWS; col++)
                    {
                        //We search for the item based on name or price
                        if (inventoryArray[row, col].Equals(prodName) || inventoryArray[row, col].Equals(price.ToString()))
                        {
                         
                            if (inventoryArray[row, 0].Equals("Xbox"))
                            {
                                storeQuant = int.Parse(storeInventory.Xbox("quantity", 0));

                                if (storeQuant - quantity >= 0)
                                {
                                    //We change the xQuant value, store value and update the array
                                    xQuant += quantity;
                                    inventoryArray[0, 3] = xQuant.ToString();
                                    storeInventory.Xbox("quantChangeRem", quantity);
                                    MessageBox.Show(xQuant + " Item(s) added");
                                }
                                else
                                {
                                    MessageBox.Show("Not enough store inventory to add items.");
                                }
                            }
                            //Same as the Xbox logic but with Playstation
                           else if (inventoryArray[row, 0].Equals("PlayStation 5"))
                            {
                                storeQuant = int.Parse(storeInventory.PlayStation("quantity", 0));

                                if (storeQuant - quantity >= 0)
                                {

                                    psQuant += quantity;
                                    inventoryArray[1,3] = psQuant.ToString();
                                    storeInventory.PlayStation("quantChangeRem", quantity);
                                    MessageBox.Show(quantity + "Item(s) added");
                                }
                                else
                                {
                                    MessageBox.Show("Not enough store inventory to add items.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Item not found.");
                            }

                        }
                        
                    }
                }
            
            }
            
        //Same as the addInventory but actions are reversed
        public void removeInventory(string prodName, int price, int quantity)
        {
            inventoryManager inventoryManager = new inventoryManager();
            StoreInventory storeInventory = new StoreInventory();
            int storeQuant;

            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < ROWS; col++)
                {
                    if (inventoryArray[row, col].Equals(prodName) || inventoryArray[row, col].Equals(price.ToString()))
                    {
                        
                        if (inventoryArray[row, 0].Equals("Xbox"))
                        {
                            storeQuant = int.Parse(storeInventory.Xbox("quantity", 0));

                            if (xQuant - quantity >= 0)
                            {
                                    xQuant -= quantity;
                                    inventoryArray[0, 3] = xQuant.ToString();
                                storeInventory.Xbox("quantChangeAdd", quantity);
                                    MessageBox.Show(quantity + " Item(s) removed");
                            }
                            else
                            {
                                MessageBox.Show("Not enough inventory to remove items.");
                            }
                        }
                        else if (inventoryArray[row, 0].Equals("PlayStation 5"))
                        {
                            storeQuant = int.Parse(storeInventory.PlayStation("quantity", 0));

                            if (psQuant - quantity >= 0)
                            {
                                 psQuant -= quantity;
                                    inventoryArray[1, 3] = psQuant.ToString();
                                storeInventory.PlayStation("quantChangeAdd", quantity);
                                    MessageBox.Show(quantity + " Item(s) removed");
                            }
                            else
                            {
                                MessageBox.Show("Not enough inventory to remove items.");
                            }
                        }
                            else
                            {
                                MessageBox.Show("Item not found");
                            }
                    }
                }
            }

        }


    }


    //****************BUTTONS FOR ITEMS SHOP****************************//
    //Below we display our store inventory
    private void StoreInvButton_Click(object sender, EventArgs e)
        {
            StoreInventory storeInventory = new StoreInventory();
            ShopInventoryLabel.Text = "Name: " + storeInventory.PlayStation("name", 0) +"\n" + "Description: " + storeInventory.PlayStation("description", 0) + "\n" + "Price: $" + storeInventory.PlayStation("price", 0) + "\n" +"Stock: " + storeInventory.PlayStation("quantity", 0) +
                "\n \n" + "Name: " + storeInventory.Xbox("name", 0) + "\n"+ "Description: " + storeInventory.Xbox("description", 0) + "\n"+ "Price: $" + storeInventory.Xbox("price", 0) + "\n" + "Stock: " + storeInventory.Xbox("quantity", 0);
        }
//RESTOCK DRIVER METHOD
        private void RestockButton_Click(object sender, EventArgs e)
        {
            StoreInventory storeInventory = new StoreInventory();

            //quantChangeAdd to restock
            storeInventory.PlayStation("quantChangeAdd", 3);
            storeInventory.Xbox("quantChangeAdd", 3);
        }
        //Method to create our inventory when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            inventoryManager inventoryManager = new inventoryManager();
            inventoryManager.createInventory();
          
        }

    //**************ITEMS SHOP INVENTORY CLASS**************************//
        class StoreInventory
        {
            //Here we initiated the variables needed for the ENTIRE class
            static int xboxQuant = 5;
            static int playStationQuant = 5;
            //Below we have a method that accepts a string that we use to determien what to do w/ quantity
            public string PlayStation(string request, int quantChange)
            { 
            string name = "PlayStation 5";
            string description = "Video Game Console";
            decimal price = 500;
                
                if (request.Equals("name"))
                {
                    request = name;
                }
                if (request.Equals("description"))
                {
                    request = description;
                }
                if (request.Equals("price"))
                {
                    request = price.ToString();
                }
                if (request.Equals("quantity"))
                {
                    request = playStationQuant.ToString();
                }
                if (request.Equals("quantChangeAdd"))
                {
                    playStationQuant += quantChange;
                    request = playStationQuant.ToString();
                }
                if (request.Equals("quantChangeRem"))
                {
                    playStationQuant -= quantChange;
                    request = playStationQuant.ToString();
                }
                return request;
            }
            //Exact same method as the Playstation but with Xbox.
            public string Xbox(string request, int quantChange)
            {
             string name = "Xbox";
             string description = "Video Game Console";
             decimal price = 400;

                if (request.Equals("name"))
                {
                    request = name;
                }
                if (request.Equals("description"))
                {
                    request = description;
                }
                if (request.Equals("price"))
                {
                    request = price.ToString();
                }
                if (request.Equals("quantity"))
                {
                    request = xboxQuant.ToString();
                }
                if (request.Equals("quantChangeAdd"))
                {
                    xboxQuant += quantChange;
                    request = " ";
                }
                if (request.Equals("quantChangeRem"))
                {
                    xboxQuant -= quantChange;
                    request = " ";

                }
                return request;
            }

        }
        //***************Exit Button***************************************//
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
