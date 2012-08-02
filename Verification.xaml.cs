using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;


namespace SecureText
{
    public partial class Page1 : PhoneApplicationPage
    {
        
        string phone, username;
        int step;
        Status1 retVal;
        public Page1()
        {
            InitializeComponent();

            InputScopeNameValue numeric = InputScopeNameValue.Number;
            textBox1.InputScope = new InputScope()
            {
                Names = { new InputScopeName() { NameValue = numeric } }
            };
            step = 0;
            Country1 coun = App.curCoun;
            string code = coun.Code;
            int posplus = code.IndexOf('+');
            int poscb = code.IndexOf(')');
            string fcode = code.Substring(posplus + 1, (poscb - posplus) - 1);
            System.Diagnostics.Debug.WriteLine(fcode);
            phone = fcode + App.phoneNumber;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (step == 0) {
            
                //VERIFY SMS CODE!
                //VERIFY CODE!!
                //////

                textBlock1.Text = "Enter your desired screen name:";
                InputScopeNameValue text = InputScopeNameValue.Text;
                textBox1.InputScope = new InputScope()
                {
                    Names = { new InputScopeName() { NameValue = text } }
                };
                step = 1;
            }

            else if(step==1) {
                username= textBox1.Text;

                //ADD TO DATABASE

                SendPost();


            }
    
        }


        void SendPost()
        {
            var url = "http://192.168.1.5/securetext/index.php/register";

            // Create the web request object
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";

            // Start the request
            webRequest.BeginGetRequestStream(new AsyncCallback(GetRequestStreamCallback), webRequest);
        }

        void GetRequestStreamCallback(IAsyncResult asynchronousResult)
        {
            HttpWebRequest webRequest = (HttpWebRequest)asynchronousResult.AsyncState;
            // End the stream request operation
            Stream postStream = webRequest.EndGetRequestStream(asynchronousResult);

            // Create the post data
            // Demo POST data 
            string postData = "username="+username+"&phone="+phone;

            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            // Add the post data to the web request
            postStream.Write(byteArray, 0, byteArray.Length);
            postStream.Close();

            // Start the web request
            webRequest.BeginGetResponse(new AsyncCallback(GetResponseCallback), webRequest);
        }

        void GetResponseCallback(IAsyncResult asynchronousResult)
        {
            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)asynchronousResult.AsyncState;
                HttpWebResponse response;

                // End the get response operation
                response = (HttpWebResponse)webRequest.EndGetResponse(asynchronousResult);
                Stream streamResponse = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(streamResponse);
                var Response = streamReader.ReadToEnd();

                string jsontext = Response;
                retVal = JsonConvert.DeserializeObject<Status1>(jsontext);
               

               

                streamResponse.Close();
                streamReader.Close();
                response.Close();

            }
            catch (WebException e)
            {
                // Error treatment
                // ...
            }

            if (retVal.value.Equals("1"))
            {
                //REGISTRATION SUCCESSFULL
            }
            else if (retVal.value.Equals("-1"))
            {
                //PHONE NUMBER EXSITS
            }
        }

    }


    public class Status1
    {
        public string action { get; set; }
        public string value { get; set; }
        public string reason { get; set; }
    }
}