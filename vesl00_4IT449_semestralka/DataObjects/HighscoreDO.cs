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
    // Hoghscore - nicks and points pairs
    class HighscoreDO
    {
        public int Score { get; set; }
        public string Nick { get; set; }

        // Get top scores
        public static List<HighscoreDO> GetHighscores()
        {
            using (HighscoreEntities context =
                new HighscoreEntities())
            {
                return context.Highscores
                    .Select(x => new HighscoreDO()
                    {
                        Nick = x.Nick,
                        Score = x.Score
                    })
                    .OrderByDescending(x => x.Score)
                    .Take(10)
                    .ToList();
            }
        }

        // Add new score
        public static void Store(string Nick, int Score)
        {
            using (HighscoreEntities context =
                new HighscoreEntities())
            {
                Highscore newItem = new Highscore();
                newItem.Nick = Nick;
                newItem.Score = Score;
                context.Highscores.Add(newItem);
                context.SaveChanges();
            }
        }
    }
}
