using System;

namespace BaumbetExercise.Models
{
    public class Fixture
    {
        public int Id { get; set; }
        public int LeagueId { get; set; }
        public DateTime Date { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }

        public Fixture(int id, int leagueId, DateTime date, string homeTeam, string awayTeam)
        {
            this.Id = id;
            this.LeagueId = leagueId;
            this.Date = date;
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
        }
    }
}