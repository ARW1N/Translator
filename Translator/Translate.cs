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
        private bool moving = false;
        private Point start = new Point(0, 0);

        RestSharp.RestClient client = null;
        RestSharp.RestClient tekstclient = null;
        RestRequest request;
        RestRequest tekstrequest;
        IRestResponse response = null;


        public class Detection
        {
            public string language { get; set; }
            public bool isReliable { get; set; }
            public double confidence { get; set; }
        }

        public class Translation
        {
            public string translatedText { get; set; }
        }
        

        public class Data
        {
            public List<Translation> translations { get; set; }
            public List<Detection>  detections { get; set; }
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
           
            
        Root dmyDeserializedClass = JsonConvert.DeserializeObject<Root>(response.Replace("[[","[").Replace("]]","]"));


            if (dmyDeserializedClass.data != null)
                return dmyDeserializedClass.data.detections[0].language;

            return dmyDeserializedClass.message;



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
            request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("accept-encoding", "application/gzip");
            /*
            request.AddHeader("x-rapidapi-key", "46f250600bmsh13cde30995680f2p1e28c6jsnd8182d05243f");
            */
            request.AddHeader("x-rapidapi-key", "230e6a3282mshdd39f5b3046ad09p1898e6jsn04c87becad77");
            request.AddHeader("x-rapidapi-host", "google-translate1.p.rapidapi.com");
            string TextToTranslate = InputTextBox.Text;
            string InputLang = InputLanguage.Text;
            string OutputLang = OutputLanguage.Text;
            request.AddParameter("application/x-www-form-urlencoded", $"q={TextToTranslate}&source={InputLang}&target={OutputLang}", ParameterType.RequestBody);
            //string TextToTranslate = "q=" + InputTextBox.Text + "&source=en&target=nl";
            //request.AddParameter("application/x-www-form-urlencoded", TextToTranslate, ParameterType.RequestBody);
            response = client.Execute(request);

            OutputTextBox.Text = Deserialize(response.Content);
        }

        private void IdentifyButton_Click(object sender, EventArgs e)
        {
            tekstrequest = new RestRequest(Method.POST);
            tekstrequest.AddHeader("content-type", "application/x-www-form-urlencoded");
            tekstrequest.AddHeader("accept-encoding", "application/gzip");
            tekstrequest.AddHeader("x-rapidapi-key", "230e6a3282mshdd39f5b3046ad09p1898e6jsn04c87becad77");
            tekstrequest.AddHeader("x-rapidapi-host", "google-translate1.p.rapidapi.com");
            string textToIdentify = IdentifyTextBox.Text;
            tekstrequest.AddParameter("application/x-www-form-urlencoded", $"q={textToIdentify}", ParameterType.RequestBody);
           
            response = tekstclient.Execute(tekstrequest);
            OutputIdentify.Text = DetectDeserialize(response.Content);
        }

        private void Translate_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            start = new Point(e.X, e.Y);
        }

        private void Translate_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }

        private void Translate_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                Point pos = PointToScreen(e.Location);
                Location = new Point(pos.X - this.start.X, pos.Y - this.start.Y);
            }
        }
    }
}
    