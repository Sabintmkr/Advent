using System.Linq;
using Advent.Models;

namespace Advent.Library
{
    public static class Config
    {
        public static bool AdventInstalled
        {
            get
            {
                using (var db = new AdventDbContext())
                    return db.Users.Any();
            }
        }

        public static string WebsiteName
        {
            get { return "MyWebsiteName"; }
        }
    }
}