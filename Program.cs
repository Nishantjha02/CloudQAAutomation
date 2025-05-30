using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        var options = new ChromeOptions();
        options.AddArgument("--start-maximized");

        IWebDriver driver = new ChromeDriver(options);

        try
        {
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Fill First Name
            var firstName = wait.Until(driver =>
                driver.FindElement(By.XPath("//label[contains(text(), 'First Name')]/following-sibling::input")));
            firstName.SendKeys("Nishant");

            // Fill Last Name
            var lastName = driver.FindElement(By.XPath("//label[contains(text(), 'Last Name')]/following-sibling::input"));
            lastName.SendKeys("Jha");

            // Fill Mobile #
            var mobile = driver.FindElement(By.XPath("//label[contains(text(), 'Mobile')]/following-sibling::input"));
            mobile.SendKeys("9876543210");

            Console.WriteLine("✅ Successfully filled fields. Browser will close in 5 seconds...");
            Thread.Sleep(15000);
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
        finally
        {
            driver.Quit();
        }
    }
}
