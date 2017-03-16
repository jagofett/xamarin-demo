using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3.Data
{
    public static class Data
    {
        //DlABOErIqW23nD5XzeUCeuKxUjXIKYnUVCI5TXzr
        static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "DlABOErIqW23nD5XzeUCeuKxUjXIKYnUVCI5TXzr",
            BasePath = "https://filmlister-166c9.firebaseio.com/"
        };
        static IFirebaseClient client = new FirebaseClient(config);

        public static async Task<List<FilmsDatabase>> GetFilmsAsync()
        {

            var films = await client.GetAsync("films");
            return films.ResultAs<Dictionary<string, FilmsDatabase>>().Select(x => new FilmsDatabase { id = x.Key, title = x.Value.title, year = x.Value.year }).ToList();

        }
    }

    public class FilmsDatabase
    {
        public string id { get; set; }

        public string title { get; set; }

        public int year { get; set; }

    }
}
