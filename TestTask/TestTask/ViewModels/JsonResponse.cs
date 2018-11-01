using Newtonsoft.Json;

namespace TestTask.ViewModels
{
    [JsonObject(MemberSerialization.OptOut)]
    public class JsonResponse
    {
        #region Constructor

        public JsonResponse(object data, string errorMessage = null)
        {
            Data = data;
            Error = errorMessage;
        }

        #endregion Constructor

        #region Properties

        public object Data { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        #endregion Properties
    }
}