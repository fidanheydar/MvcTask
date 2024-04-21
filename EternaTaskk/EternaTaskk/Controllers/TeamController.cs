using EternaTaskk.Models;
using Microsoft.AspNetCore.Mvc;

namespace EternaTaskk.Controllers
{
    public class TeamController : Controller
    {
        private List<TeamMember> GetTeamMembers()
        {
            var teamMembers = new List<TeamMember>
            {
                new TeamMember { Id = 1, Name = "Walter White", Position = "Chief Executive Officer", Description = "Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut" },
                new TeamMember { Id = 2, Name = "Sarah Jhinson", Position = "Product Manager", Description = "Repellat fugiat adipisci nemo illum nesciunt voluptas repellendus. In architecto rerum rerum temporibus" },
                new TeamMember { Id = 3, Name = "William Anderson", Position = "CTO", Description = "Voluptas necessitatibus occaecati quia. Earum totam consequuntur qui porro et laborum toro des clara" }
            };

            return teamMembers;
        }

        public IActionResult Index()
        {
            var teamMembers = GetTeamMembers();
            return View(teamMembers);
        }
    }
}
