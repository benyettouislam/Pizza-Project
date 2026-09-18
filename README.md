# 🍕 Pizza Order Management System (Pizza Project)

[![C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET Framework](https://img.shields.io/badge/Framework-.NET%20Windows%20Forms-purple.svg)](https://dotnet.microsoft.com/)
[![IDE](https://img.shields.io/badge/IDE-Visual%20Studio-violet.svg)](https://visualstudio.microsoft.com/)
[![GitHub repo size](https://img.shields.io/github/repo-size/benyettouislam/Pizza-Project)](https://github.com/benyettouislam/Pizza-Project)

A high-performance desktop application built using **C#** and **Windows Forms** on the **.NET Framework**. The project demonstrates event-driven programming, object-oriented concepts, dynamic UI state synchronization, and real-time pricing calculation logic for pizza order customization.

---

## ✨ Key Features

* **Dynamic Size Selection:** Choose between Small, Medium, and Large sizes with immediate base price adjustment.
* **Crust Type Customization:** Support for Thin, Thick, or Stuffed Crust with individual pricing rules.
* **Multi-Topping Selection:** Checkbox-based topping additions (Extra Cheese, Mushrooms, Olives, Tomatoes, Onions, Green Peppers) with instant cumulative cost updates.
* **Order Type / Location:** Toggle between **Dine-In** and **Takeaway / Delivery**.
* **Real-time Summary Panel:** Live GUI updating displaying selected items, order details, and total cost dynamically upon any UI state change.
* **Order Confirmation & Lock:** Simulates order processing by locking active controls and prompting confirmation.
* **Form Reset Mechanism:** Flushes inputs, restores default states, and unlocks the control suite for new orders.

---

## 🛠️ Tech Stack & Prerequisites

* **Language:** C# 
* **UI Framework:** Windows Forms (.NET Framework)
* **IDE:** Microsoft Visual Studio 2019 / 2022
* **Target Runtime:** .NET Framework 4.7.2+ / .NET Desktop SDK

---

## 🔬 Technical Implementation & Architecture

### 1. Event-Driven Architecture
The application utilizes an **event-driven GUI paradigm** where user interaction with form controls triggers event handlers that re-evaluate the order state:
* **`CheckedChanged` Events:** Bound to `RadioButton` and `CheckBox` controls to capture user selections immediately.
* **Centralized Calculation Engine:** Instead of calculating prices in isolated handlers, a core method (`UpdateOrderSummary()` / `CalculateTotalPrice()`) is executed whenever any choice changes. This ensures single-responsibility design and prevents state desynchronization.

### 2. Pricing & Cost Calculation Logic
The total price is calculated dynamically using a modular mathematical formula:

$$\text{Total Price} = \text{Base Price (Size)} + \text{Crust Fee} + \sum \text{Selected Topping Fees}$$

* **Base Prices:** Assigned using control tags (`Tag` property) or conditional logic mapped to selected sizes.
* **Cumulative Topping Fees:** Iterates through active `CheckBox` controls, adding fixed unit costs per enabled topping.

### 3. UI Control Flow & State Management
* **Control Tagging / Enums:** Leverages strongly typed logic and control properties (`Tag` or custom data structures) to map UI elements directly to numerical value definitions.
* **Control Grouping:** Uses `GroupBox` containers (`gbSize`, `gbCrust`, `gbToppings`, `gbWhereToEat`, `gbOrderSummary`) to maintain logical separation of UI layers and manage control hierarchy.
* **Form Lock & Reset State Machine:**
  * When an order is placed (`btnOrderPizza_Click`), all selection controls are disabled (`Enabled = false`) to lock the finalized order state.
  * The Reset action (`btnReset_Click`) re-enables controls, unchecks active boxes, restores default `RadioButton` selections, and clears summary labels.

https://github.com/user-attachments/assets/2fdace92-ff77-496d-ad4b-d149d5f22dfd

<img width="845" height="259" alt="Capture" src="https://github.com/user-attachments/assets/a24ec11d-98ac-4586-951f-d4a700546813" />

---

## 📁 Project File Structure

```text
Pizza-Project-main/
├── 14projectpizza.slnx       # Solution metadata & project mapping
├── 14projectpizza.csproj     # C# Project configuration file & dependencies
├── Program.cs                 # Main entry point (Application.Run(new Form1()))
├── Form1.cs                   # Core business logic, event handlers, & pricing engine
├── Form1.Designer.cs          # Auto-generated GUI layout and control definitions
├── Form1.resx                 # Embedded resources, icons, and localized string assets
└── App.config                 # Application configuration runtime settings


