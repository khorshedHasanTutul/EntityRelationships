using EntityRelationship.Data;
using EntityRelationship.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityRelationship.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharecterController : ControllerBase
    {
        private readonly DataContext _context;

        public CharecterController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Charecter>>>GetCharecters(int userId)
        {
            var response = await _context.Charecters.Where(x => x.UserId == userId).ToListAsync();
            return response;
        }
    }
}
