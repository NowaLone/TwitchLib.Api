using System.Collections.Generic;
using System.Threading.Tasks;
using TwitchLib.Api.Core;
using TwitchLib.Api.Core.Enums;
using TwitchLib.Api.Core.Exceptions;
using TwitchLib.Api.Core.Interfaces;
using TwitchLib.Api.V5.Models.Games;

namespace TwitchLib.Api.V5
{
    public class Games : ApiBase
    {
        public Games(IApiSettings settings, IRateLimiter rateLimiter, IHttpCallHandler http) : base(settings, rateLimiter, http)
        {
        }

        #region GetTopGames

        public Task<TopGames> GetTopGamesAsync(int? limit = null, int? offset = null)
        {
            var getParams = new List<KeyValuePair<string, string>>();
            if (limit.HasValue)
                getParams.Add(new KeyValuePair<string, string>("limit", limit.Value.ToString()));
            if (offset.HasValue)
                getParams.Add(new KeyValuePair<string, string>("offset", offset.Value.ToString()));

            return TwitchGetGenericAsync<TopGames>("/games/top", ApiVersion.V5, getParams);
        }

        #endregion

        #region GetGame

        public Task<TopGame> GetGameAsync(string game)
        {
            if (string.IsNullOrWhiteSpace(game))
                throw new BadParameterException("The game name is not valid for fetching game. It is not allowed to be null, empty or filled with whitespaces.");

            return TwitchGetGenericAsync<TopGame>($"/game/{game}", ApiVersion.V5);
        }

        #endregion
    }


}