using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace TeamBattle.Data
{
    public class ApplicationUser : IdentityUser 
    {
        public DateTime DateOfBirth { get; set; }
        public ICollection<BattleTeam> BattleTeams { get; set; }
    }
}