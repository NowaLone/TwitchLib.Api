using Newtonsoft.Json;

namespace TwitchLib.Api.V5.Models.Games
{
    public class TopGame
    {
        #region Channels
        [JsonProperty(PropertyName = "channels")]
        public int Channels { get; set; }
        #endregion
        #region Viewers
        [JsonProperty(PropertyName = "viewers")]
        public int Viewers { get; set; }
        #endregion
        #region Game
        [JsonProperty(PropertyName = "game")]
        public Game Game { get; set; }
        #endregion
    }
}
