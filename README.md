# CloudQA Developer Internship Assignment

##  Task Description

As part of the CloudQA Developer Internship application process, I was given the following task:

> Go to this web page: [https://app.cloudqa.io/home/AutomationPracticeForm](https://app.cloudqa.io/home/AutomationPracticeForm).  
> Write a program or algorithm using C# and Selenium to automatically test any three fields on that page.  
> The main goal of your program is to make sure it still works even if the position or any other properties of the HTML elements for those three fields change.

##  What This Project Does

This automation script:
- Launches Chrome using ChromeDriver
- Opens the CloudQA Automation Practice Form
- Switches to the **iframe with ID** (`iframeResult`)
- Automatically fills the following 3 fields:
  - First Name
  - Last Name
  - Email

These fields are selected in a way that they remain accessible even if the page layout changes.

##  Tech Stack

- .NET SDK 8.0
- C#
- Selenium WebDriver
- ChromeDriver

##  Setup Instructions

### 1. Prerequisites
-  Visual Studio Code or any C# IDE
-  .NET 8 SDK: [Download .NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
-  Google Chrome installed
-  ChromeDriver (same version as Chrome): [Download ChromeDriver](https://sites.google.com/chromium.org/driver/)

### 2. Set Up Environment Variables (for Windows)
- Place `chromedriver.exe` in a folder like `C:\WebDriver\bin`
- Add that folder to **System Environment Variables > PATH**

### 3. Clone and Run This Project

```bash
git clone https://github.com/<your-username>/CloudQAAutomation.git
cd CloudQAAutomation
dotnet restore
dotnet run
