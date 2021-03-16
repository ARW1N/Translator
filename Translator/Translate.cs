using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Xml;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Translator
{
    public partial class Translate : Form
    {
        RestSharp.RestClient client = null;
        RestSharp.RestClient tekstclient = null;
        RestRequest request = new RestRequest(Method.POST);
        RestRequest tekstrequest = new RestRequest(Method.POST);
        IRestResponse response = null;


        
        public class Translation
        {
            public string translatedText { get; set; }
        }
        

        public class Data
        {
            public List<Translation> translations { get; set; }
            public List<List<>>  detections { get; set; }
        }

        public class Root
        {
            public Data data { get; set; }
            public string message { get; set; }
        }


        public Translate()
        {
            InitializeComponent();

            client = new RestSharp.RestClient("https://google-translate1.p.rapidapi.com/language/translate/v2");
            tekstclient = new RestSharp.RestClient("https://google-translate1.p.rapidapi.com/language/translate/v2/detect");



        }

        public string Deserialize(string response)
        {
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(response);
           

            if (myDeserializedClass.data != null)
                return myDeserializedClass.data.translations[0].translatedText;

            return myDeserializedClass.message;

            
            
        }

        public string DetectDeserialize(string response)
        {
           

        Root dmyDeserializedClass = JsonConvert.DeserializeObject<Root>(response);


            if (dmyDeserializedClass.data != null)
                return dmyDeserializedClass.data.detections[0].

            return dmyDeserializedClass.message;



        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void Title_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You found the Easter egg!", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeProgram_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TranslateButton_Click(object sender, EventArgs e)
        {
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("accept-encoding", "application/gzip");
            /*
            request.AddHeader("x-rapidapi-key", "46f250600bmsh13cde30995680f2p1e28c6jsnd8182d05243f");
            */
            request.AddHeader("x-rapidapi-key", "230e6a3282mshdd39f5b3046ad09p1898e6jsn04c87becad77");
            request.AddHeader("x-rapidapi-host", "google-translate1.p.rapidapi.com");
            request.AddParameter("application/x-www-form-urlencoded", "q=Hello%2C%20world!&source=en&target=de", ParameterType.RequestBody);
            //string TextToTranslate = "q=" + InputTextBox.Text + "&source=en&target=nl";
            //request.AddParameter("application/x-www-form-urlencoded", TextToTranslate, ParameterType.RequestBody);
            response = client.Execute(request);

            OutputTextBox.Text = Deserialize(response.Content);
        }

        private void InputLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Output_Click(object sender, EventArgs e)
        {

        }

        private void IdentifyButton_Click(object sender, EventArgs e)
        {
            tekstrequest.AddHeader("content-type", "application/x-www-form-urlencoded");
            tekstrequest.AddHeader("accept-encoding", "application/gzip");
            tekstrequest.AddHeader("x-rapidapi-key", "230e6a3282mshdd39f5b3046ad09p1898e6jsn04c87becad77");
            tekstrequest.AddHeader("x-rapidapi-host", "google-translate1.p.rapidapi.com");
            string textToIdentify = IdentifyTextBox.Text;
            tekstrequest.AddParameter("application/x-www-form-urlencoded", $"q={textToIdentify}", ParameterType.RequestBody);
           
            response = tekstclient.Execute(tekstrequest);
            IdentifyTextBox.Text = DetectDeserialize(response.Content);
        }

        private void IdentifyLabel_Click(object sender, EventArgs e)
        {


        }
    }
}
    