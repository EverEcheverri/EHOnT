namespace Employees.Repository.ResourceAccess
{
    using System.Net.Http;
    using System.Net.Http.Headers;

    public sealed class HttpClientSingleton
    {
        private static HttpClient instance = null;

        private HttpClientSingleton()
        {
        }

        public static HttpClient Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HttpClient();                    
                    instance.DefaultRequestHeaders.Accept.Clear();
                    instance.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                }
                return instance;
            }
        }
    }
}
