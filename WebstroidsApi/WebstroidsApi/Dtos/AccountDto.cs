using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebstroidsApi.Dtos
{
    public class AccountDto
    {
        public int HighScore { get; set; }

        public string Id { get; }

        public int gamesPlayed { get; set; }

        public long timePlayed { get; set; }
    }
}
