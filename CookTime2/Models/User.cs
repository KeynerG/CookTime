using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace CookTime2.Models
{
    public partial class User
    {
        [JsonProperty("email")]
        private string email { set; get; }
        [JsonProperty("name")]
        private string name { set; get; }
        [JsonProperty("age")]
        private int age { set; get; }
        [JsonProperty("profile")]
        private Profile profile { set; get; }
        [JsonProperty("follow")]
        private User[] follow { set; get; }
        [JsonProperty("followers")]
        private User[] followers { set; get; }

        public User(string name, string email, int age)
        {
            this.name = name;
            this.profile = profile;
            this.email = email;
            this.age = age;
        }
    }

    public partial class User
    {
        public static User FromJson(string json) => JsonConvert.DeserializeObject<User>(json, CookTime2.Models.Converter.Settings);
    }
}
