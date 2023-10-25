using RestSharp.Authenticators;
using RestSharp;

namespace HarmanHomeTask
{
    internal static class RestSharpFacade
    {
        public static bool UploadFile(string fileName)
        {
            var options = new RestClientOptions("https://byshop89.free.beeceptor.com/files")
            {
                Authenticator = new HttpBasicAuthenticator("username", "password")
            };
            var client = new RestClient(options);

            var request = new RestRequest(Path.GetFileName(fileName));
            request.AddParameter("Filename", fileName);
            request.AddParameter("File Content", File.ReadAllText(fileName));
            request.AddParameter("Timestamp", DateTime.Now);

            RestResponse response = client.Put(request);

            return response.IsSuccessful;
        }
    }
}
