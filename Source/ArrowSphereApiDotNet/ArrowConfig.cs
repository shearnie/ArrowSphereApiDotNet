namespace ArrowSphereApiDotNet
{
    public class ArrowConfig
    {
        private string _apiKey;
        private string _apiBasePath = "https://xsp.arrow.com/index.php/api/";

        public ArrowConfig(
            string apiKey)
        {
            _apiKey = apiKey;
        }

        public string ApiKey => _apiKey;
        public string ApiBasePath => _apiBasePath;
    }
}
