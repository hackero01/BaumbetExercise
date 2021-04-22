using BaumbetExercise.Models;
using BaumbetExercise.Repository;
using System.Web.Http;
using System.Web.Http.Cors;


namespace BaumbetExercise.Controllers
{
    public class FixturesController : ApiController
    {
       
        [System.Web.Http.HttpPost]
        [System.Web.Script.Services.ScriptMethod(UseHttpGet = true)]
        [EnableCors(origins: "*", headers: "*", methods: "*")]


        public IHttpActionResult getFixtures([FromBody] Fixture fix)
        {

            FixtureRepository fixtureRepo = new FixtureRepository();

            return Json(fixtureRepo.GetMatchByIdOfLeagueAndDate(fix));

        }
    }
}
