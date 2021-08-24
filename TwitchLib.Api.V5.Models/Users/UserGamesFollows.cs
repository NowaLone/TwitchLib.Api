using Newtonsoft.Json;

namespace TwitchLib.Api.V5.Models.Users
{
    public class UserGamesFollows
    {
        #region Follows

        [JsonProperty(PropertyName = "follows")]
        public UserGameFollow[] Follows { get; protected set; }

        #endregion Follows

        #region Total

        [JsonProperty(PropertyName = "_total")]
        public int Total { get; protected set; }

        #endregion Total

        #region Cursor

        /// <summary>Property representing the cursor.</summary>
        [JsonProperty(PropertyName = "_cursor")]
        public string Cursor { get; protected set; }

        #endregion Cursor
    }
}