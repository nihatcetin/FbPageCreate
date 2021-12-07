using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FbPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IWebDriver driver = null;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");

            IWebElement username = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[1]/input"));
            username.SendKeys("aliveli15456@hotmail.com");
           // username.SendKeys(textBox1.Text);

            Thread.Sleep(2500);

            IWebElement password = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[2]/div/input"));
            password.SendKeys("13579aliveli");
           // password.SendKeys(textBox2.Text);
            Thread.Sleep(2500);

            IWebElement login = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[2]/button"));
            login.Click();

            Thread.Sleep(2500);

            driver.Navigate().GoToUrl("https://www.facebook.com/pages/creation/?ref_type=launch_point");

            Thread.Sleep(2500);

            IWebElement pageName = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div[1]/div/div[2]/div[1]/div[2]/div/div/div[1]/div/div[2]/label/div/div/input"));

            pageName.SendKeys("Hediyelik1");

            Thread.Sleep(2500);

            IWebElement categori = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div[1]/div/div[2]/div[1]/div[2]/div/div/div[2]/div/div[1]/div/div/div/label/div/div/div/input"));
            categori.Click();
            Thread.Sleep(2500);
            categori.SendKeys("Eğlence Sitesi");
            Thread.Sleep(2500);
            IWebElement categoriSelect = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[2]/div/div/div[1]/div[1]/div/div[1]/div/ul/li[1]/div/div[1]/div/div/div/div/span"));
            categoriSelect.Click();

            IWebElement PageCreteLogin = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div[1]/div/div[3]/div[2]/div/div/div/div[1]"));
            PageCreteLogin.Click();

            
        }
    }
}
