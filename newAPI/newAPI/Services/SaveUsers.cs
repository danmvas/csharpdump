using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static WebAPI.Controllers.CrudController;
using WebAPI.Model;
using System.Text.Json;

namespace WebAPI.Services
{
    public class SaveUsers
    {
        public static void WriteBD()
        {
            StreamWriter write = new StreamWriter("Services/db.txt");

            foreach (User user in _users)
            {
                write.WriteLine(JsonSerializer.Serialize(user));
            }

            write.Close();
        }

    }
}
