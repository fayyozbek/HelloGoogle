using Microsoft.Extensions.Logging;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


class Program{

		static void Main(string[] arg){
		ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder.AddConsole();
                });
                ILogger logger = loggerFactory.CreateLogger<Program>();
				IWebDriver driver= new FirefoxDriver();
				driver.Url="https://www.google.ru/";
				driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
				driver.	FindElement(By.Name("q")).SendKeys("Hello World"+Keys.Enter);
				WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
				wait.Until(driver => driver.Title.Contains("Hello"));
				logger.LogInformation(driver.Title);


		}
	}



