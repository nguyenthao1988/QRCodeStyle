using Newtonsoft.Json;
using QRCodeStyle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMultiQR
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInit();
        }
        private void PopulateComboBox<T>(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (var pattern in Enum.GetValues(typeof(T)))
            {
                comboBox.Items.Add(pattern.ToString());
            }

            comboBox.SelectedIndex = 0;
        }

        private T GetSelectedEnum<T>(ComboBox comboBox) where T : Enum
        {
            if (comboBox.SelectedItem != null)
            {
                return (T)Enum.Parse(typeof(T), comboBox.SelectedItem.ToString());
            }
            throw new InvalidOperationException("No item selected in the ComboBox.");
        }

        private void LoadInit()
        {
            PopulateComboBox<QRCodePatterns.Body>(cb_bodyShape);
            PopulateComboBox<QRCodePatterns.Eye>(cb_eyeFrame);
            PopulateComboBox<QRCodePatterns.Ball>(cb_eyeBall);
        }

        private void btnColor1_Click(object sender, EventArgs e)
        {
            var color1 = btnColor1.BackColor;
            colorDialog1.Color = color1;
            var dlg = colorDialog1.ShowDialog();

            if (dlg == DialogResult.OK)
            {
                btnColor1.BackColor = colorDialog1.Color;
                var htmlText = ColorTranslator.ToHtml(btnColor1.BackColor);
                btnColor1.Text = htmlText;
            }

        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            var color2 = btnColor2.BackColor;
            colorDialog1.Color = color2;
            var dlg = colorDialog1.ShowDialog();

            if (dlg == DialogResult.OK)
            {
                btnColor2.BackColor = colorDialog1.Color;
                var htmlText = ColorTranslator.ToHtml(btnColor2.BackColor);
                btnColor2.Text = htmlText;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var body = GetSelectedEnum<QRCodePatterns.Body>(cb_bodyShape);
            var frame = GetSelectedEnum<QRCodePatterns.Eye>(cb_eyeFrame);
            var ball = GetSelectedEnum<QRCodePatterns.Ball>(cb_eyeBall);

            var color1 = ColorTranslator.ToHtml(btnColor1.BackColor);
            var color2 = ColorTranslator.ToHtml(btnColor2.BackColor);

            var generator = new QRGenerator();


            var customConfig = new QRConfig
            {
                BodyPattern = body,
                EyePattern = frame,
                BallPattern = ball,
                GradientPattern = QRCodePatterns.Gradient.Linear,
                bodyColor = "#FF0000",
                bgColor = "#FFFFFF",
                gradientColor1 = color1,
                gradientColor2 = color2,
                gradientOnEyes = true,
                LogoPattern = QRCodePatterns.Logo.Clean,
                logo = logoFile
            };

            // Add custom style
            generator.AddStyle(2, customConfig);
            var text = txtText.Text;
            var image = await generator.GenerateAsync(text, 2);
            picResult.Image = image;
        }
        public string logoFile;
        private void button2_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var path = dlg.FileName;
                var generator = new QRGenerator();
                var jsonData = generator.UploadImage(path);
                logoFile = JsonConvert.DeserializeObject<LogoURL>(jsonData).file;
                piclogo.LoadAsync(path);
                MessageBox.Show(logoFile);
            }
        }

        public class LogoURL
        {
            public string file { get; set; }
        }
    }
}
