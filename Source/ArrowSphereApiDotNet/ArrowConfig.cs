namespace ArrowSphereApiDotNet
{
    public class ArrowConfig
    {
        private string _apiKey;
        private string _apiBasePath;

        public ArrowConfig(
            string apiKey,
            string apiBasePath)
        {
            _apiKey = apiKey;
            _apiBasePath = apiBasePath;
        }

        public string ApiKey => _apiKey;
        public string ApiBasePath => _apiBasePath;
    }
}
