using System;
using System.Text;
using System.Data.SqlClient;
using vesl00_4IT449_semestralka;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using vesl00_4IT449_semestralka.Models;

namespace vesl00_4IT449_semestralka.DataObjects
{
    class HighscoreDO
    {
        public int Score { get; set; }
        public string Nick { get; set; }

        public static List<HighscoreDO> GetHighscores()
        {
            using (HighscoreEntities context =
                new HighscoreEntities())
            {
                return context.highscore
                    .Select(x => new HighscoreDO()
                    {
                        Nick = x.nick,
                        Score = x.score
                    })
                    .OrderByDescending(x => x.Score)
                    .ToList();
            }
        }
    }
}
