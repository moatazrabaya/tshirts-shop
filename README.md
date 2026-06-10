# 🧵 T-Shirt Shop — Design Patterns Project

A console application built in **C#** that simulates a T-shirt shop ordering system. The project demonstrates four core design patterns: **Abstract Factory**, **Decorator**, **Observer**, and **Singleton**.

---

## 📋 Table of Contents

- [Overview](#overview)
- [Design Patterns](#design-patterns)
- [Project Structure](#project-structure)
- [Architecture](#architecture)
- [Design Decisions](#design-decisions)
- [How to Run](#how-to-run)
- [Test Drive](#test-drive)

---

## Overview

The shop produces T-shirts in three sizes (Small, Medium, Large) for three regions (Middle East, China, Asia). Customers can customize their T-shirt with features such as a logo, text, or colors. The shop owner is automatically notified of any changes in sold items.

---

## Design Patterns

### 🏭 Abstract Factory
Used to create T-shirt objects based on **region and size**. Each regional factory (MiddleEast, China, Asia) produces its own Small, Medium, and Large T-shirts without exposing the instantiation logic to the client.

```
TShirtFactory (abstract)
    ├── MiddleEastFactory → MiddleEastSmallTShirt, MiddleEastMediumTShirt, MiddleEastLargeTShirt
    ├── ChinaFactory      → ChinaSmallTShirt, ChinaMediumTShirt, ChinaLargeTShirt
    └── AsiaFactory       → AsiaSmallTShirt, AsiaMediumTShirt, AsiaLargeTShirt
```

### 🎨 Decorator
Used to add features to a T-shirt **dynamically at runtime**. Each feature (Logo, Text, Red Color, Blue Color) wraps the T-shirt object and extends its `FullDescription` without modifying the original class.

```
TShirt (base)
    └── wrapped by RedColorDecorator
            └── wrapped by LogoDecorator
                    → FullDescription: "... + Red Color + Bird Logo"
```

### 🔒 Singleton
Applied to both `Order` and `SalesTracker` to ensure **only one instance** exists throughout the application.

- `Order` — ensures one active order at a time. A new order cannot be placed until the current one is completed.
- `SalesTracker` — ensures one central sales record for the entire shop.

### 👁️ Observer
Used to **automatically notify** the shop owner whenever a sale is completed. `SalesTracker` acts as the Subject and `ShopOwner` acts as the Observer.

```
SalesTracker (Subject)
    └── notifies → ShopOwner (Observer)
                    └── updates and stores sold counts per size
```

---

## Project Structure

```
TShirtShop/
├── TShirtShop.sln
├── TShirtShop/
│   ├── TShirtShop.csproj
│   ├── Program.cs
│   ├── AbstractFactory/
│   │   ├── TShirtFactory.cs
│   │   ├── ChinaFactory.cs
│   │   ├── MiddleEastFactory.cs
│   │   └── AsiaFactory.cs
│   ├── Models/
│   │   ├── TShirt.cs
│   │   ├── ChinaSmallTShirt.cs
│   │   ├── ChinaMediumTShirt.cs
│   │   ├── ChinaLargeTShirt.cs
│   │   ├── MiddleEastSmallTShirt.cs
│   │   ├── MiddleEastMediumTShirt.cs
│   │   ├── MiddleEastLargeTShirt.cs
│   │   ├── AsiaSmallTShirt.cs
│   │   ├── AsiaMediumTShirt.cs
│   │   └── AsiaLargeTShirt.cs
│   ├── Decorator/
│   │   ├── TShirtDecorator.cs
│   │   ├── LogoDecorator.cs
│   │   ├── TextDecorator.cs
│   │   ├── RedColorDecorator.cs
│   │   └── BlueColorDecorator.cs
│   ├── Observer/
│   │   ├── IObserver.cs
│   │   ├── ISubject.cs
│   │   ├── SalesTracker.cs
│   │   └── ShopOwner.cs
│   ├── Singleton/
│   │   └── Order.cs
│   └── Enums/
│       ├── TShirtSize.cs
│       └── TShirtRegion.cs
└── README.md
```

---

## Architecture

### Class Hierarchy

```
TShirt (abstract)
    ├── ChinaSmallTShirt
    ├── ChinaMediumTShirt
    ├── ChinaLargeTShirt
    ├── MiddleEastSmallTShirt
    ├── MiddleEastMediumTShirt
    ├── MiddleEastLargeTShirt
    ├── AsiaSmallTShirt
    ├── AsiaMediumTShirt
    ├── AsiaLargeTShirt
    └── TShirtDecorator (abstract)
            ├── LogoDecorator
            ├── TextDecorator
            ├── RedColorDecorator
            └── BlueColorDecorator
```

### Order Flow

```
1. Customer selects region        → Abstract Factory creates correct TShirt
2. Customer selects size          → Factory method called (CreateSmall/Medium/Large)
3. Customer adds features         → Decorator wraps TShirt dynamically
4. Customer confirms order        → Singleton Order holds one active TShirt
5. Order completed                → SalesTracker.AddSale() called
6. ShopOwner notified             → Observer pattern triggers Update()
```

---

## Design Decisions

### Why Abstract Factory over Simple Factory
A simple Factory with a `switch` statement for both region and size would violate the **Open/Closed Principle** — adding a new region means modifying existing code. Abstract Factory separates the concern: the **factory class = region**, the **factory method = size**.

### Why Singleton on SalesTracker
`SalesTracker` is the more natural Singleton in this project — there should only ever be **one central sales record** for the shop. `Order` also uses Singleton to enforce the one-active-order-at-a-time rule.

> ⚠️ Note: In a real-world multi-threaded environment (e.g. a web API), both Singleton classes would require thread-safe implementation using `lock` or `Lazy<T>` to prevent race conditions. This is a console app with a single thread, so locking is not needed here.

### Why Size and Region Are Enums
Using `TShirtSize` and `TShirtRegion` enums instead of strings provides **type safety**, eliminates typo risks, and gives full IntelliSense support. A string-based approach like `"small"` vs `"Small"` vs `"SMALL"` can cause silent bugs.

---

## How to Run

```bash
git clone https://github.com/moataz-rabaya/TShirtShop.git
cd TShirtShop
dotnet run --project TShirtShop
```

---

## Test Drive

### Scenario A — China customer orders a Blue Medium T-Shirt with Bird Logo

```csharp
TShirtFactory factory = new ChinaFactory();
TShirt shirt = factory.CreateMedium();
shirt = new BlueColorDecorator(shirt);
shirt = new LogoDecorator(shirt);
Console.WriteLine(shirt.FullDescription);
// Output: China Medium T-Shirt - A Medium T-shirt designed for the China region + Blue Color + Bird Logo
```

### Scenario B — Middle East customer orders a Red Large T-Shirt with Text

```csharp
TShirtFactory factory = new MiddleEastFactory();
TShirt shirt = factory.CreateLarge();
shirt = new RedColorDecorator(shirt);
shirt = new TextDecorator(shirt);
Console.WriteLine(shirt.FullDescription);
// Output: Middle East Large T-Shirt - A Large T-shirt designed for the MiddleEast region + Red Color + "Nice Day!"
```

### Scenario C — Shop Owner tracks sold items

```csharp
SalesTracker tracker = SalesTracker.Instance;
ShopOwner owner = new ShopOwner("Moataz");
tracker.RegisterObserver(owner);

tracker.AddSale(TShirtSize.Medium); // owner notified automatically
tracker.AddSale(TShirtSize.Large);  // owner notified automatically

owner.PrintReport();
// Output:
// Small  sold: 0
// Medium sold: 1
// Large  sold: 1
// Total  sold: 2
```
