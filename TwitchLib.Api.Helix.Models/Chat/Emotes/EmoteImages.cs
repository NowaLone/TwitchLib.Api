﻿using Newtonsoft.Json;

namespace TwitchLib.Api.Helix.Models.Chat.Emotes
{
    public class EmoteImages
    {
        [JsonProperty("url_1x")]
        public string Url1X { get; protected set; }
        [JsonProperty("url_2x")]
        public string Url2X { get; protected set; }
        [JsonProperty("url_4x")]
        public string Url4X { get; protected set; }
    }
}