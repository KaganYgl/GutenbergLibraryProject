using Newtonsoft.Json;

namespace gutenberg.Models
{
    public class Formats
    {
        [JsonProperty("text/html")]
        public string texthtml { get; set; }

        [JsonProperty("application/epub+zip")]
        public string applicationepubzip { get; set; }

        [JsonProperty("application/x-mobipocket-ebook")]
        public string applicationxmobipocketebook { get; set; }

        [JsonProperty("application/rdf+xml")]
        public string applicationrdfxml { get; set; }

        [JsonProperty("image/jpeg")]
        public string imagejpeg { get; set; }

        [JsonProperty("text/plain; charsetus-ascii")]
        public string textplaincharsetusascii { get; set; }

        [JsonProperty("application/octet-stream")]
        public string applicationoctetstream { get; set; }

        [JsonProperty("text/html; charsetutf-8")]
        public string texthtmlcharsetutf8 { get; set; }

        [JsonProperty("text/plain; charsetutf-8")]
        public string textplaincharsetutf8 { get; set; }

        [JsonProperty("text/html; charsetiso-8859-1")]
        public string texthtmlcharsetiso88591 { get; set; }

        [JsonProperty("text/plain; charsetiso-8859-1")]
        public string textplaincharsetiso88591 { get; set; }

        [JsonProperty("application/pdf")]
        public string applicationpdf { get; set; }

        [JsonProperty("application/prs.tex")]
        public string applicationprstex { get; set; }
    }
}
