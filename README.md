# AspDotNetMvcAreaTutorial

This project is a multi-page ASP.NET Core MVC web application built as part of an assignment. It demonstrates the use of **Areas**, **nested Razor layouts**, **layout sections**, and **Bootstrap-based UI**.

---

## 📂 Project Structure

```
/Controllers
  └── HomeController.cs

/Views
  └── Home/
      ├── Index.cshtml
      ├── About.cshtml
      ├── Contact.cshtml
  └── Shared/
      └── _Layout.cshtml
  └── _ViewImports.cshtml
  └── _ViewStart.cshtml

/Areas
  └── Help/
      ├── Controllers/
      │   ├── HomeController.cs
      │   └── TutorialController.cs
      ├── Views/
          ├── Home/
              └── Index.cshtml
          ├── Tutorial/
              ├── Page1.cshtml
              ├── Page2.cshtml
              ├── Page3.cshtml
          ├── Shared/
              └── _HelpLayout.cshtml
          ├── _ViewImports.cshtml
          ├── _ViewStart.cshtml
```

---

## ✅ Features

- 📌 Uses `Areas` to separate Help content from the main website
- 🧩 Main layout and nested layout with Razor sections
- 🔗 Bootstrap navigation with active link highlighting
- 📚 Help section with tutorial pages and tabbed navigation
- 🧭 Tutorial routing handled via route `id` in the controller
- 📞 Contact page pulls contact info using `ViewBag` (no model needed)

---

## 🚀 Getting Started

### Prerequisites

- [.NET SDK 8.0+](https://dotnet.microsoft.com/download)
- Visual Studio 2022 or VS Code

### Run the App

1. Clone the repository:
   ```bash
   git clone https://github.com/kishankumar2607/AspDotNetMvcAreaTutorial.git
   cd AspDotNetMvcAreaTutorial
   ```

2. Run the project:
   ```bash
   dotnet run
   ```

3. Open browser and visit:
   ```
   https://localhost:5001/
   ```

---

## 👨‍💻 Author

**Kishan Kumar Das**  
Conestoga College  
Advanced Programming with .NET — Assignment 2
