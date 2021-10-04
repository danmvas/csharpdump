using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static WebAPI.Controllers.CrudController;

namespace WebAPI.Services
{
    public class CheckUsers
    {
        public static bool ExistentUsers(long id)
        {
            return _users.Any(f => f.Id == id);
        }
    }
}
