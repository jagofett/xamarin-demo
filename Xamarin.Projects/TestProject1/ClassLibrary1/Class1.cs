using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public static class Class1
    {
        static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "AIzaSyB6adgBHjVlMCNzohiXzpWxZjUEffc5mUo",
            BasePath = "https://filmlister-166c9.firebaseio.com"
        };

        static IFirebaseClient _client = new FirebaseClient(config);


        public static void GetFilmsAsync()
        {
            FirebaseResponse response = _client.Get("films/get");
            //Todo todo = response.ResultAs<Todo>(); //The response will contain the data being retreived
        }
    }
}
