using BaumbetExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;



namespace BaumbetExercise.Repository
{
    public class FixtureRepository
    {

        public List<Fixture> GetMatchByIdOfLeagueAndDate(Fixture fixture)
        {
            var filteredList = GetAllFixtures().Where(x => x.LeagueId == fixture.LeagueId && x.Date == fixture.Date).OrderBy(x => x.Id).ToList();

            return filteredList;
        }
        public List<Fixture> GetAllFixtures()
        {
            List<Fixture> mockList = new List<Fixture>
            {
                new Fixture(5, 1, new DateTime(2021, 04, 21), "UTA ARAD", "CFR CLUJ"),
                new Fixture(1, 1, new DateTime(2021, 04, 21), "FCSB", "Dinamo"),
                new Fixture(2, 2, new DateTime(2021, 04, 22), "Manchester UTD", "London FC"),
                new Fixture(3, 3, new DateTime(2021, 04, 23), "Borusssia Dortmund", "RB Leipzig"),
                new Fixture(4, 4, new DateTime(2021, 04, 23), "Juventus Torino", "Inter Milano"),
                new Fixture(6, 5, new DateTime(2021, 04, 21), "Barcelona", "Real Madrid")
            };
            return mockList;
        }
    }
}