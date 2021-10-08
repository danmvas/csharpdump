using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static WebAPI.Controllers.CrudController;
using WebAPI.Model;
using Newtonsoft.Json;

namespace WebAPI.Services
{
    public class GetUsers
    {
        public static void GetBD()
        {
            var readBD = File.ReadAllLines("Services/db.txt");

            foreach (var user in readBD)
            {
                var userGet = JsonConvert.DeserializeObject<User>(user);
                _users.Add(userGet);
            }
            
        }
    }
}
