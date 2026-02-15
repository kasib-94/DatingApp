using API.Data;
using DatingApp.Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController(AppDbContext context) : ControllerBase
	{
		[HttpGet]
		public ActionResult<IReadOnlyList<AppUser>> GetMembers()
		{
			var members = context.Users.ToList();
			return members;
		}

		[HttpGet("{id}")]
		public ActionResult<AppUser> GetMember(int id)
		{
			var member = context.Users.FirstOrDefault(x => x.Id == id);

			if (member == null)return NotFound();

			return member;
		}
	}
}
