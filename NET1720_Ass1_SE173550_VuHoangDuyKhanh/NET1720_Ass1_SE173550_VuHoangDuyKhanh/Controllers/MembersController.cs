using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using NET1720_Ass1_SE173550_VuHoangDuyKhanh.Database;

namespace NET1720_Ass1_SE173550_VuHoangDuyKhanh.Controllers
{
    [Route("odata/[controller]")]
    public class MembersController : Controller
    {
        private readonly MemberManager _memberManager;
        public MembersController(MemberManager memberManager)
        {
            _memberManager = memberManager;
        }
        [HttpGet]
        [EnableQuery]
        public IActionResult Get()
        {
            var list = _memberManager.GetAll();
            var result = list.AsQueryable();
            return Ok(result);
        }

        [HttpGet("({id})")]
        [EnableQuery]
        public IActionResult Get(int id)
        {
            var member = _memberManager.GetAll().FirstOrDefault(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }
            return Ok(member);
        }
        [HttpGet("me")]
        [Authorize]
        public IActionResult GetCurrentMember()
        {
            var username = User.Identity.Name;

            var member = _memberManager.GetAll().FirstOrDefault(m => m.UserName == username);
            if (member == null)
            {
                return NotFound();
            }
            return Ok(member);
        }
    }
}
