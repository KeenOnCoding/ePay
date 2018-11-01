﻿using Newtonsoft.Json;

namespace TestTask.ViewModels
{
    [JsonObject(MemberSerialization.OptOut)]
    public class TokenResponseViewModel
    {
        #region Constructor

        public TokenResponseViewModel()
        {
        }

        #endregion Constructor

        #region Properties

        public string token { get; set; }
        public int expiration { get; set; }
        public string refresh_token { get; set; }

        #endregion Properties
    }
}