using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.IO;
using System.Net;
using OpenQA.Selenium.Interactions;
using Instadown;

namespace IG_explore_downloader
{
    public partial class Form1 : Form
    {
        MediaClass mediaClass;
        Source Source = new Source();
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            imageRadioBtn.Checked = true;
            mediaClass = new MediaClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(explore);
            thread.Start();
            //thread.Start(Source.Start(usernameTxtBox, passwordTxtBox, postCountNum, listBox1, progressBar1));
            //Source.Start();
        }
        public void explore()
        {
            Source.ExploreDownload(usernameTxtBox, passwordTxtBox, postCountNum, console, progressBar1);
        }

        private void hashtagDownloadBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(hashtag);
            thread.Start();
        }
        public void hashtag()
        {
            Source.hashTagDownload(usernameTxtBox, passwordTxtBox, postCountNum, console, progressBar1,hashtagTxtBox);
        }

        private void downloadPost_Click(object sender, EventArgs e)
        {
            Source.linkDownload(imageRadioBtn, videoRadioBtn, urlDownloadTxtBox,console,progressBar1,mediaClass);
        }

        private void profileDownloadBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(profile);
            thread.Start();
        }
        public void profile()
        {
            Source.profileDownload(usernameTxtBox, passwordTxtBox, postCountNum, console, progressBar1, profileTxtBox);
        }
    }
}
class Source
{
    ChromeDriverService service = ChromeDriverService.CreateDefaultService();
    OpenQA.Selenium.Chrome.ChromeOptions chromeoptions = new ChromeOptions();
    public void ExploreDownload(TextBox userNameTxtBox, TextBox passwordTxtBox, NumericUpDown postCountNum, ListBox lst1, ProgressBar progressBar)
    {
        try
        {
            lst1.Items.Clear();
            //Configs
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "IG Media Download"; //Final path
            //chromeoptions.AddArguments("headless", "disable-gpu");
            service.HideCommandPromptWindow = true;
            IWebDriver web = new ChromeDriver(service);
            int rowCount = 1;
            int postCount = (int)postCountNum.Value;
            progressBar.Maximum = postCount;
            string userName = userNameTxtBox.Text;
            string password = passwordTxtBox.Text;
            string URL = "https://instagram.com";
            //Configs

            lst1.Items.Add("Configs are loaded");

            //Login
            web.Navigate().GoToUrl(URL); //OpenURL
            Thread.Sleep(2500);
            IWebElement userNameElement = web.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[1]/div/label/input"));
            IWebElement passwordElement = web.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[2]/div/label/input"));
            userNameElement.SendKeys(userName);//Enter account informations
            passwordElement.SendKeys(password);
            IWebElement loginBtnElement = web.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[3]/button/div"));
            loginBtnElement.Click(); //Login Button click
            Thread.Sleep(7000);
            IWebElement exploreBtnElement = web.FindElement(By.XPath("/html/body/div[1]/section/nav/div[2]/div/div/div[3]/div/div[4]/a"));
            exploreBtnElement.Click(); //Explore Button click
            //Login

            lst1.Items.Add("Login successful");

            //Create Folder
            createFolderToDesktop();
            //Create Folder

            lst1.Items.Add("Folder successfully created");
            lst1.Items.Add("Downloading Posts");

            //Download Posts
            Thread.Sleep(4000);
            for (int i = 1; i <= postCount; i++)
            {
                for (int y = 1; y < 4; y++)
                {
                    Thread.Sleep(50);
                    IWebElement postXPath = web.FindElement(By.XPath("/html/body/div[1]/section/main/div/div[1]/div/div[" + rowCount + "]/div[" + y + "]/div/a/div/div[1]/img"));
                    var x = postXPath.GetAttribute("src");
                    Thread.Sleep(50);
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(new Uri(x), folderPath + "/" + i + ".png");
                    }
                    i++;
                    progressBar.Value ++;
                    Thread.Sleep(50);
                    lst1.Items.Add("Downloaded: " + i + "/" + postCount);
                    if (y == 3)
                    {
                        rowCount++;
                        y = 1;
                    }
                    if (rowCount == 7)
                    {
                        web.Navigate().Refresh();
                        Thread.Sleep(6000);
                        rowCount = 1;
                    }
                    if (i == postCount)
                    {
                        progressBar.Value = progressBar.Maximum;
                        web.Close();
                        break;
                    }
                }
            }
            //Download Posts
            lst1.Items.Add("Posts successfully downloaded");
        }
        catch (Exception)
        {
            lst1.Items.Add("Error, Please restart progress");
            return;
        }
    }


    public void hashTagDownload(TextBox userNameTxtBox, TextBox passwordTxtBox, NumericUpDown postCountNum, ListBox lst1, ProgressBar progressBar, TextBox hashtagTxtBox)
    {
        try
        {
            lst1.Items.Clear();
            //Configs
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "IG Media Download"; //Final path
            //chromeoptions.AddArguments("headless", "disable-gpu");
            service.HideCommandPromptWindow = true;
            IWebDriver web = new ChromeDriver(service);
            int postCount = (int)postCountNum.Value;
            progressBar.Maximum = postCount;
            string userName = userNameTxtBox.Text;
            string password = passwordTxtBox.Text;
            string baseURL = "https://instagram.com";
            string URL = "https://instagram.com/explore/tags/" + hashtagTxtBox.Text;
            int rowCount = 1;
            //Configs

            lst1.Items.Add("Configs are loaded");

            //Login
            web.Navigate().GoToUrl(baseURL); //OpenURL
            Thread.Sleep(2500);
            IWebElement userNameElement = web.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[1]/div/label/input"));
            IWebElement passwordElement = web.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[2]/div/label/input"));
            userNameElement.SendKeys(userName);//Enter account informations
            passwordElement.SendKeys(password);
            IWebElement loginBtnElement = web.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[3]/button/div"));
            loginBtnElement.Click(); //Login Button click
            Thread.Sleep(7000);
            web.Navigate().GoToUrl(URL); //Go to Hashtag Page
            //Login

            lst1.Items.Add("Login successful");

            //Create Folder
            createFolderToDesktop();
            //Create Folder

            lst1.Items.Add("Folder successfully created");
            lst1.Items.Add("Downloading Posts");

            //Preparing Posts
            int postRowCount = postCount / 3;
            for (int amount = 1; amount <= postRowCount; amount++)
            {
                Thread.Sleep(1000);
                var element = web.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div/div[" + amount + "]/div[1]/a/div/div[1]/img"));
                Actions actions = new Actions(web);
                actions.MoveToElement(element);
                actions.Perform();
                //if (amount == postRowCount)
                //{
                //    break;
                //}
            }
            //Preparing Posts

            //Download Posts
            Thread.Sleep(4000);
            for (int i = 1; i <= postCount; i++)
            {
                for (int y = 1; y < 4; y++)
                {
                    Thread.Sleep(50);
                    IWebElement postXPath = web.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div/div[" + rowCount + "]/div[" + y + "]/a/div/div[1]/img"));
                    var x = postXPath.GetAttribute("src");
                    Thread.Sleep(50);
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(new Uri(x), folderPath + "/" + i + ".png");
                    }
                    i++;
                    progressBar.Value++;
                    Thread.Sleep(50);
                    lst1.Items.Add("Downloaded: " + i + "/" + postCount);
                    if (y == 3)
                    {
                        rowCount++;
                        y = 1;
                    }
                    if (rowCount == 7)
                    {
                        web.Navigate().Refresh();
                        Thread.Sleep(6000);
                        rowCount = 1;
                    }
                    if (i == postCount)
                    {
                        progressBar.Value = progressBar.Maximum;
                        web.Close();
                        break;
                    }
                }
            }
            //Download Posts
            lst1.Items.Add("Posts successfully downloaded");
        }
        catch (Exception)
        {
            lst1.Items.Add("Error, Please restart progress");
            return;
        }
    }

    public void profileDownload(TextBox userNameTxtBox, TextBox passwordTxtBox, NumericUpDown postCountNum, ListBox console, ProgressBar progressBar, TextBox profileName)
    {
        try
        {
            console.Items.Clear();

            //Configs
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "IG Media Download"; //Final path
            //chromeoptions.AddArguments("headless", "disable-gpu");
            service.HideCommandPromptWindow = true;
            IWebDriver web = new ChromeDriver(service);
            int postCount = (int)postCountNum.Value;
            progressBar.Maximum = postCount;
            string userName = userNameTxtBox.Text;
            string password = passwordTxtBox.Text;
            string baseURL = "https://instagram.com";
            string URL = "https://instagram.com/" + profileName.Text;
            int rowCount = 1;
            //Configs

            console.Items.Add("Configs are loaded");

            //Login
            web.Navigate().GoToUrl(baseURL); //OpenURL
            Thread.Sleep(2500);
            IWebElement userNameElement = web.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[1]/div/label/input"));
            IWebElement passwordElement = web.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[2]/div/label/input"));
            userNameElement.SendKeys(userName);//Enter account informations
            passwordElement.SendKeys(password);
            IWebElement loginBtnElement = web.FindElement(By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[3]/button/div"));
            loginBtnElement.Click(); //Login Button click
            Thread.Sleep(7000);
            web.Navigate().GoToUrl(URL); //Go to Hashtag Page
                                         //Login

            //Create Folder
            createFolderToDesktop();
            //Create Folder

            console.Items.Add("Folder successfully created");

            //Preparing Posts
            int postRowCount = postCount / 3;
            for (int amount = 1; amount <= postRowCount; amount++)
            {
                Thread.Sleep(1000);
                var element = web.FindElement(By.XPath("/html/body/div[1]/section/main/div/div[3]/article/div[1]/div/div["+amount+"]/div[3]/a/div[1]/div[1]/img"));
                Actions actions = new Actions(web);
                actions.MoveToElement(element);
                actions.Perform();
            }
            //Preparing Posts

            //Download Posts
            Thread.Sleep(4000);
            for (int i = 1; i <= postCount; i++)
            {
                for (int y = 1; y < 4; y++)
                {
                    Thread.Sleep(50);
                    IWebElement postXPath = web.FindElement(By.XPath("/html/body/div[1]/section/main/div/div[3]/article/div[1]/div/div[" + rowCount + "]/div["+y+"]/a/div[1]/div[1]/img"));
                    var x = postXPath.GetAttribute("src");
                    Thread.Sleep(50);
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(new Uri(x), folderPath + "/" + profileName.Text + i + ".png");
                    }
                    i++;
                    progressBar.Value++;
                    Thread.Sleep(50);
                    console.Items.Add("Downloaded: " + i + "/" + postCount);
                    if (y == 3)
                    {
                        rowCount++;
                        y = 1;
                    }
                    if (rowCount == 7)
                    {
                        web.Navigate().Refresh();
                        Thread.Sleep(6000);
                        rowCount = 1;
                    }
                    if (i == postCount)
                    {
                        progressBar.Value = progressBar.Maximum;
                        web.Close();
                        break;
                    }
                }
            }
            console.Items.Add("Posts successfully downloaded");
            //Download Posts
        }
        catch (Exception)
        {
            console.Items.Add("Error, Please try again");
        }
    }

    public void linkDownload(RadioButton imageRadioBtn, RadioButton videoRadioBtn, TextBox urlTxtBox, ListBox console, ProgressBar progressBar, MediaClass mediaClass)
    {
        console.Items.Clear();
        progressBar.Maximum = 100;

        //Variables
        string mediaURL = urlTxtBox.Text;
        char slash = '/';
        string[] splits = mediaURL.Split(slash);
        //MessageBox.Show(splits[4]); //File name debug
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "IG Media Download"; //Final path
        //Variables

        //Create Folder
        createFolderToDesktop();
        //Create Folder

        console.Items.Add("Folder Created");
        progressBar.Value = 25;

        progressBar.Value = 50;
        console.Items.Add("Preparing post..");

        if (imageRadioBtn.Checked == true && videoRadioBtn.Checked == false)
        {
            //using (WebClient client = new WebClient())
            //{
            //    client.DownloadFile(new Uri(mediaURL), folderPath + "/" + splits[4] + ".png");
            //}

            mediaClass.inputUrl = urlTxtBox.Text;
            mediaClass.DownloadImage(folderPath);
        }
        if (videoRadioBtn.Checked == true && imageRadioBtn.Checked == false)
        {
            //using (WebClient client = new WebClient())
            //{
                mediaClass.inputUrl = urlTxtBox.Text;
                mediaClass.DownloadVideo(folderPath);
                //client.DownloadFile(new Uri(mediaURL), folderPath + "/" + splits[4] + ".mp4");
            //}
        }
        progressBar.Value = 100;
        console.Items.Add("Finished Succesfully");
    }

    public void createFolderToDesktop()
    {
        //Create Folder to Desktop
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "IG Media Download"; //Final path
        var filecheck = System.IO.Directory.Exists(folderPath);
        if (filecheck == true)
        {

        }
        else
        {
            System.IO.Directory.CreateDirectory(folderPath); //Create Folder
        }
        //Create Folder to Desktop
    }
}