using System;
using System.Net;
using System.IO;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;


namespace QRCodeStyle
{
    #region Enums
    public static class QRCodePatterns
    {
        public enum Body
        {
            Square,
            Mosaic,
            Dot,
            Circle,
            CircleZebra,
            CircleZebraVertical,
            CircleZebraHorizontal,
            Circular,
            EdgeCut,
            EdgeCutSmooth,
            Japanese,
            Leaf,
            Pointed,
            PointedEdgeCut,
            PointedIn,
            PointedInSmooth,
            PointedSmooth,
            Round,
            RoundedIn,
            RoundedInSmooth,
            RoundedPointed,
            Star,
            Diamond
        }


        public enum Eye
        {
            Frame0,
            Frame1,
            Frame2,
            Frame3,
            Frame4,
            Frame5,
            Frame6,
            Frame7,
            Frame8,
            Frame9,
            Frame10,
            Frame11,
            Frame12,
            Frame13,
            Frame14,
            Frame15,
            Frame16
        }

        public enum Ball
        {
            Ball0,
            Ball1,
            Ball2,
            Ball3,
            Ball4,
            Ball5,
            Ball6,
            Ball7,
            Ball8,
            Ball9,
            Ball10,
            Ball11,
            Ball12,
            Ball13,
            Ball14,
            Ball15,
            Ball16,
            Ball17,
            Ball18
        }

        public enum Gradient
        {
            Linear,
            Radial
        }

        public enum Logo
        {
            Default,
            Clean
        }
    }
    #endregion

    #region Pattern Converters
    public static class PatternConverter
    {
        public static string GetBodyString(QRCodePatterns.Body pattern)
        {
            switch (pattern)
            {
                case QRCodePatterns.Body.Square: return "square";
                case QRCodePatterns.Body.Mosaic: return "mosaic";
                case QRCodePatterns.Body.Dot: return "dot";
                case QRCodePatterns.Body.Circle: return "circle";
                case QRCodePatterns.Body.CircleZebraVertical: return "circle-zebra-vertical";
                case QRCodePatterns.Body.CircleZebraHorizontal: return "circle-zebra-horizontal";
                case QRCodePatterns.Body.Circular: return "circular";
                case QRCodePatterns.Body.EdgeCut: return "edge-cut";
                case QRCodePatterns.Body.EdgeCutSmooth: return "edge-cut-smooth";
                case QRCodePatterns.Body.Japanese: return "japnese";
                case QRCodePatterns.Body.Leaf: return "leaf";
                case QRCodePatterns.Body.Pointed: return "pointed";
                case QRCodePatterns.Body.PointedEdgeCut: return "pointed-edge-cut";
                case QRCodePatterns.Body.PointedIn: return "pointed-in";
                case QRCodePatterns.Body.PointedInSmooth: return "pointed-in-smooth";
                case QRCodePatterns.Body.PointedSmooth: return "pointed-smooth";
                case QRCodePatterns.Body.Round: return "round";
                case QRCodePatterns.Body.RoundedIn: return "rounded-in";
                case QRCodePatterns.Body.RoundedInSmooth: return "rounded-in-smooth";
                case QRCodePatterns.Body.RoundedPointed: return "rounded-pointed";
                case QRCodePatterns.Body.Star: return "star";
                case QRCodePatterns.Body.Diamond: return "diamond";
                default: return "square";
            }

        }

        public static string GetEyeString(QRCodePatterns.Eye eye)
        {
            return "frame" + ((int)eye).ToString();
        }

        public static string GetBallString(QRCodePatterns.Ball ball)
        {
            return "ball" + ((int)ball).ToString();
        }

        public static string GetGradientString(QRCodePatterns.Gradient gradient)
        {
            return gradient.ToString().ToLower();
        }

        public static string GetLogoString(QRCodePatterns.Logo logo)
        {
            return logo.ToString().ToLower();
        }
    }
    #endregion

    #region Configuration Classes
    public class QRConfig
    {
        private QRCodePatterns.Body _bodyPattern;
        private QRCodePatterns.Eye _eyePattern;
        private QRCodePatterns.Ball _ballPattern;
        private QRCodePatterns.Gradient _gradientPattern;
        private QRCodePatterns.Logo _logoPattern;

        private string _body;
        private string _eye;
        private string _eyeBall;
        private string _gradientType;
        private string _logoMode;

        public QRCodePatterns.Body BodyPattern
        {
            get { return _bodyPattern; }
            set
            {
                _bodyPattern = value;
                _body = PatternConverter.GetBodyString(value);
            }
        }

        public QRCodePatterns.Eye EyePattern
        {
            get { return _eyePattern; }
            set
            {
                _eyePattern = value;
                _eye = PatternConverter.GetEyeString(value);
            }
        }

        public QRCodePatterns.Ball BallPattern
        {
            get { return _ballPattern; }
            set
            {
                _ballPattern = value;
                _eyeBall = PatternConverter.GetBallString(value);
            }
        }

        public QRCodePatterns.Gradient GradientPattern
        {
            get { return _gradientPattern; }
            set
            {
                _gradientPattern = value;
                _gradientType = PatternConverter.GetGradientString(value);
            }
        }

        public QRCodePatterns.Logo LogoPattern
        {
            get { return _logoPattern; }
            set
            {
                _logoPattern = value;
                _logoMode = PatternConverter.GetLogoString(value);
            }
        }

        public string body { get { return _body; } }
        public string eye { get { return _eye; } }
        public string eyeBall { get { return _eyeBall; } }
        public string[] erf1 { get; set; }
        public string[] erf2 { get; set; }
        public string[] erf3 { get; set; }
        public string[] brf1 { get; set; }
        public string[] brf2 { get; set; }
        public string[] brf3 { get; set; }
        public string bodyColor { get; set; }
        public string bgColor { get; set; }
        public string eye1Color { get; set; }
        public string eye2Color { get; set; }
        public string eye3Color { get; set; }
        public string eyeBall1Color { get; set; }
        public string eyeBall2Color { get; set; }
        public string eyeBall3Color { get; set; }
        public string gradientColor1 { get; set; }
        public string gradientColor2 { get; set; }
        public string gradientType { get { return _gradientType; } }
        public bool gradientOnEyes { get; set; }
        public string logo { get; set; }
        public string logoMode { get { return _logoMode; } }

        public QRConfig()
        {
            BodyPattern = QRCodePatterns.Body.Square;
            EyePattern = QRCodePatterns.Eye.Frame0;
            BallPattern = QRCodePatterns.Ball.Ball0;
            GradientPattern = QRCodePatterns.Gradient.Linear;
            LogoPattern = QRCodePatterns.Logo.Default;

            erf1 = new string[] { };
            erf2 = new string[] { };
            erf3 = new string[] { };
            brf1 = new string[] { };
            brf2 = new string[] { };
            brf3 = new string[] { };

            bodyColor = "#000000";
            bgColor = "#FFFFFF";
            eye1Color = "#000000";
            eye2Color = "#000000";
            eye3Color = "#000000";
            eyeBall1Color = "#000000";
            eyeBall2Color = "#000000";
            eyeBall3Color = "#000000";
            gradientOnEyes = false;
            logo = "";
        }
    }

    public class QRRequest
    {
        public string data { get; set; }
        public QRConfig config { get; set; }
        public int size { get; set; }
        public string download { get; set; }
        public string file { get; set; }

        public QRRequest()
        {
            size = 1000;
            download = "imageUrl";
            file = "png";
        }
    }
    #endregion

    #region QR Code Generator
    public class QRGenerator
    {
        private const string API_URL = "https://api.qrcode-monkey.com/qr/custom";
        private Dictionary<int, QRConfig> customStyles;

        public QRGenerator()
        {
            customStyles = new Dictionary<int, QRConfig>();
            InitializeDefaultStyles();
        }

        private void InitializeDefaultStyles()
        {
            customStyles[1] = new QRConfig
            {
                BodyPattern = QRCodePatterns.Body.Square,
                EyePattern = QRCodePatterns.Eye.Frame13,
                BallPattern = QRCodePatterns.Ball.Ball14,
                bodyColor = "#000000",
                bgColor = "#FFFFFF",
                eye1Color = "#021326",
                eye2Color = "#021326",
                eye3Color = "#021326",
                eyeBall1Color = "#074f03",
                eyeBall2Color = "#074f03",
                eyeBall3Color = "#074f03",
                gradientColor1 = "#12a637",
                gradientColor2 = "#0b509e",
                GradientPattern = QRCodePatterns.Gradient.Linear,
                gradientOnEyes = true
            };

        }

        public void AddStyle(int styleNumber, QRConfig config)
        {
            if (customStyles.ContainsKey(styleNumber))
            {
                customStyles[styleNumber] = config;
            }
            else
            {
                customStyles.Add(styleNumber, config);
            }
        }

        public class GenerationResult
        {
            public bool Success { get; set; }
            public string Message { get; set; }
            public string ImageUrl { get; set; }
        }

        public GenerationResult Generate(string data, int styleNumber, string savePath)
        {
            try
            {
                QRConfig config = customStyles.ContainsKey(styleNumber)
                    ? customStyles[styleNumber]
                    : customStyles[1];

                var request = new QRRequest
                {
                    data = data,
                    config = config
                };

                var serializer = new JavaScriptSerializer();
                string jsonRequest = serializer.Serialize(request);

                var webRequest = (HttpWebRequest)WebRequest.Create(API_URL);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/json";

                using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
                {
                    streamWriter.Write(jsonRequest);
                }

                using (var response = (HttpWebResponse)webRequest.GetResponse())
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    string jsonResponse = reader.ReadToEnd();
                    var responseData = serializer.Deserialize<Dictionary<string, object>>(jsonResponse);

                    if (responseData.ContainsKey("imageUrl"))
                    {
                        string imageUrl = "http:" + responseData["imageUrl"].ToString();

                        if (!string.IsNullOrEmpty(savePath))
                        {
                            using (WebClient webClient = new WebClient())
                            {
                                webClient.DownloadFile(imageUrl, savePath);
                            }
                        }

                        return new GenerationResult
                        {
                            Success = true,
                            Message = "Success",
                            ImageUrl = imageUrl
                        };
                    }
                }

                return new GenerationResult
                {
                    Success = false,
                    Message = "Failed to get image URL",
                    ImageUrl = null
                };
            }
            catch (WebException ex)
            {
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    return new GenerationResult
                    {
                        Success = false,
                        Message = "Error: " + reader.ReadToEnd(),
                        ImageUrl = null
                    };
                }
            }
            catch (Exception ex)
            {
                return new GenerationResult
                {
                    Success = false,
                    Message = "Error: " + ex.Message,
                    ImageUrl = null
                };
            }
        }
        public Image Generate(string data, int styleNumber)
        {
            try
            {
                QRConfig config = customStyles.ContainsKey(styleNumber)
                    ? customStyles[styleNumber]
                    : customStyles[1];

                var request = new QRRequest
                {
                    data = data,
                    config = config
                };

                var serializer = new JavaScriptSerializer();
                string jsonRequest = serializer.Serialize(request);

                var webRequest = (HttpWebRequest)WebRequest.Create(API_URL);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/json";

                using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
                {
                    streamWriter.Write(jsonRequest);
                }

                using (var response = (HttpWebResponse)webRequest.GetResponse())
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    string jsonResponse = reader.ReadToEnd();
                    var responseData = serializer.Deserialize<Dictionary<string, object>>(jsonResponse);

                    if (responseData.ContainsKey("imageUrl"))
                    {
                        string imageUrl = "http:" + responseData["imageUrl"].ToString();

                        using (WebClient webClient = new WebClient())
                        {
                            byte[] imageData = webClient.DownloadData(imageUrl);

                            using (MemoryStream memoryStream = new MemoryStream(imageData))
                            {
                                return Image.FromStream(memoryStream);
                            }
                        }
                    }
                }

                return null;
            }
            catch (WebException ex)
            {
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    Console.WriteLine("Error: " + reader.ReadToEnd());
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        public async Task<Image> GenerateAsync(string data, int styleNumber)
        {
            try
            {
                QRConfig config = customStyles.ContainsKey(styleNumber)
                    ? customStyles[styleNumber]
                    : customStyles[1];

                var request = new QRRequest
                {
                    data = data,
                    config = config
                };

                var serializer = new JavaScriptSerializer();
                string jsonRequest = serializer.Serialize(request);

                var webRequest = (HttpWebRequest)WebRequest.Create(API_URL);
                webRequest.Method = "POST";
                webRequest.ContentType = "application/json";

                using (var requestStream = await Task.Factory.FromAsync(
                    webRequest.BeginGetRequestStream, webRequest.EndGetRequestStream, null))
                using (var streamWriter = new StreamWriter(requestStream))
                {
                    await streamWriter.WriteAsync(jsonRequest);
                }

                using (var response = (HttpWebResponse)await Task.Factory.FromAsync(
                    webRequest.BeginGetResponse, webRequest.EndGetResponse, null))
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    string jsonResponse = await reader.ReadToEndAsync();
                    var responseData = serializer.Deserialize<Dictionary<string, object>>(jsonResponse);

                    if (responseData.ContainsKey("imageUrl"))
                    {
                        string imageUrl = "http:" + responseData["imageUrl"].ToString();

                        using (WebClient webClient = new WebClient())
                        {
                            byte[] imageData = await webClient.DownloadDataTaskAsync(imageUrl);

                            using (MemoryStream memoryStream = new MemoryStream(imageData))
                            {
                                return Image.FromStream(memoryStream);
                            }
                        }
                    }
                }

                return null;
            }
            catch (WebException ex)
            {
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    Console.WriteLine("Error: " + await reader.ReadToEndAsync());
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        public string UploadImage(string imagePath)
        {
            string url = "https://api.qrcode-monkey.com//qr/uploadimage";
            string boundary = "------------------------" + DateTime.Now.Ticks.ToString("x");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "multipart/form-data; boundary=" + boundary;

            using (Stream requestStream = request.GetRequestStream())
            {
                byte[] boundaryBytes = System.Text.Encoding.ASCII.GetBytes("--" + boundary + "\r\n");
                requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);

                byte[] headerBytes = System.Text.Encoding.UTF8.GetBytes(
                    "Content-Disposition: form-data; name=\"file\"; filename=\"" + Path.GetFileName(imagePath) + "\"\r\n" +
                    "Content-Type: application/octet-stream\r\n\r\n");
                requestStream.Write(headerBytes, 0, headerBytes.Length);

                using (FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    fileStream.CopyTo(requestStream);
                }

                byte[] trailerBytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
                requestStream.Write(trailerBytes, 0, trailerBytes.Length);
            }

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                using (StreamReader reader = new StreamReader(ex.Response.GetResponseStream()))
                {
                    return "Error: " + reader.ReadToEnd();
                }
            }
        }
    }
}
#endregion
