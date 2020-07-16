using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace CookTime2.Models
{
    class User
    {
        private string email { set; get; }
        private string name { set; get; }
        private string lastname { set; get; }
        private int age { set; get; }
        private Profile profile { set; get; }
        private List<User> follow { set; get; }
        private List<User> followers { set; get; }
        private List<Recipe> myMenu { set; get; }
    }
}
