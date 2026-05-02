🍔 Restaurant POS System - Los Pollos Hermanos
This was my first ever project in C# that I recieved 90%+ for in my first year of uni so I holds sentimental value. It's 
obviously a work in progress so be kind lmao.

A Windows desktop-based Point of Sale (POS) application for fast food and beverage ordering, built with C# and Windows Forms.

📋 Features
  Menu Categories
    -Fast Meals (Burgers, Fries, Sandwiches, Salads, Chicken, Cheese Burgers)
    -Drinks & Desserts (Cola, Tea, Water, Milkshakes, Orange Juice, Pancakes)
    
  Order Management
    -Checkbox selection for each menu item
    -Quantity input for selected items

  Real-time date and time display
    -Subtotal, VAT, and Total calculation

  User Controls
    -Reset order
    -Add items to receipt
    -Print receipt functionality
    -Visual food icons for each menu item

🛠️ Tech Stack

-Language: C#
-Framework: .NET Framework 4.7.2
-UI: Windows Forms
-IDE: Visual Studio

🚀 Getting Started

  Prerequisites
    -Windows OS
    -Visual Studio (2017 or later)
    -.NET Framework 4.7.2

  Installation
    -Clone the repository

  bash
  git clone https://github.com/yourusername/RestaurantPOS-v1.git

  -Open RestaurantPOS-v1.sln in Visual Studio

  -Build the solution (Ctrl+Shift+B)

  -Run the application (F5)

📁 Project Structure
text
RestaurantPOS-v1/
├── Form1.cs                 # Main POS form logic
├── Form1.Designer.cs        # UI component layout
├── Program.cs               # Application entry point
├── Properties/
│   ├── AssemblyInfo.cs      # Assembly metadata
│   ├── Resources.Designer.cs # Image resources
│   └── Settings.Designer.cs  # Application settings
└── Resources/               # Food item icons (burger, fries, drinks, etc.)

🎯 Usage

1. Launch the application
2. Check the box next to any menu item you want to order
3. Enter the quantity in the corresponding text field
4. Click ADD to calculate the order total
5. Use PRINT to generate a receipt
6. Click RESET to clear the current order
7. Click X in the top-right corner to exit



Future Improvements:
1. Complete calculation logic for prices and VAT

2. Database integration for order history

3. User authentication for staff

4. Barcode scanner support

Receipt printer integration

📄 License
Copyright © 2024 - All Rights Reserved

Author
Kabelo Monnakgotla
