using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebstroidsApi.Entities
{
    /// <summary>
    /// An Account class tracks a users game stats. 
    /// </summary>
    public class Account
    {
        public int HighScore { get; set; }

        public string Id { get; }

        public int gamesPlayed { get; set; }

        public long timePlayed { get; set; }

        public string userId { get; set; }
    }
}
