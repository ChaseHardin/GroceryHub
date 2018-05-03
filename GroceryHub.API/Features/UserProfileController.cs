using System.Web.Http;
using GroceryHub.Business.Features.UserProfile;

namespace GroceryHub.API.Features
{
    [RoutePrefix("api/userProfiles")]
    public class UserProfileController : ApiController
    {
        [HttpGet, Route("")]
        public virtual IHttpActionResult Get()
        {
            return Ok(new UserProfileService().GetProfile());
        }
    }
}
