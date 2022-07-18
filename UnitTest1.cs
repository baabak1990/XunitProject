using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Xunit.Abstractions;

namespace XunitProject
{
    public class UnitTest1
    {
        //Fourth:Add Driver manager in coinstructor 
        private readonly ITestOutputHelper _output;
        private readonly ChromeDriver _chrome;
        public UnitTest1(ITestOutputHelper output)
        {
            this._output = output;
            //setup web drive manager here like this
            var driver = new DriverManager().SetUpDriver(new ChromeConfig());
            //and like that we can add firefox driver here . var driver=new DriverManager().SetUpDriver(new FirefoxConfig())
            _chrome = new ChromeDriver();
        }

        [Fact]
        public void Test1()
        {
            //First :If We here we say console.writeline its not gone work because this is unit testing
            //Console.WriteLine("Hello World ...."); here where we cant see any output without this interface I used later
            // Second :So We should Use OutPutHelper here in constructor
            //with that we wont see the console as usually but we see the result in out test explore tab
            //Third :and Then instal selenium package and web driver manager from nuget
            _output.WriteLine("Hello World ...");
            //With Driver manager we can use facilities like this also you can add your localhost address
            _chrome.Navigate().GoToUrl("http://Gamefa.com");
        }

    }
}