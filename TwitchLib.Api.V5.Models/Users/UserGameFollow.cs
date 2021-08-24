using Newtonsoft.Json;
using TwitchLib.Api.V5.Models.Games;

namespace TwitchLib.Api.V5.Models.Users
{
    public class UserGameFollow
    {
        #region Game

        [JsonProperty(PropertyName = "game")]
        public Game Game { get; protected set; }

        #endregion Game
    }
}