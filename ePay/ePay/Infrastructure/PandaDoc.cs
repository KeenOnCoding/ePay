using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ePay.Infrastructure
{
    public class PandaDoc
    {
        public static HttpClient client = new HttpClient();

        //public static string clientId = "e9a7358b2b7ea50a98d5";
        //public static string clientSecret = "b61f52f468e056e71a1dd556d6d014f6ab5b9650";
        //public static string redirectUrl = "https://www.getpostman.com/oauth2/callback";
        public static string acsesToken = "fa8aa0e7d2819bb0e76c20978f8d25ae7601a6d7";
        //public static string refresh_token = "f62ce12119b39019b2dd4d8ea13762f2b190ab87";
        //public static string code = "492a6ea54f2808db03dbb42345a741a34352779d";

        //public static string authorizePandaDocUser = "https://app.pandadoc.com/oauth2/authorize?client_id=2c8926c1c6d4b30371ef&redirect_uri=https://www.getpostman.com/oauth2/callback&scope=read+write&response_type=code";
        //public static string createAcessToken = "https://app.getpostman.com/oauth2/callback?state=&code=f028f801ecc7646f03358dfbe297f84231a07252";

        public static async Task<string> GetDocument(string str)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", acsesToken);

            HttpResponseMessage response = new HttpResponseMessage();

            response = await client.GetAsync("https://api.pandadoc.com/public/v1/documents?q=" + str);

            JObject jObject = JObject.Parse(await response.Content.ReadAsStringAsync());

            JToken memberName = jObject["results"].First["id"];

            return memberName.ToString();

            //return response.StatusCode.ToString();
        }

        public static async Task<string> GetDocumentDetailsAsync(string str)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", acsesToken);

            HttpResponseMessage response = new HttpResponseMessage();

            response = await client.GetAsync("https://api.pandadoc.com/public/v1/documents/" + str + "/details");

            JObject jObject = JObject.Parse(await response.Content.ReadAsStringAsync());

            return jObject.ToString();
        }
    }
}