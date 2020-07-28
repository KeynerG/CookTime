using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CookTime2.Models;
using Newtonsoft.Json;

namespace CookTime2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            RegisterUser register = new RegisterUser(EntryName.Text, EntryPassword.Text, EntryEmail.Text, int.Parse(EntryAge.Text));
            HttpClient client = new HttpClient();
            string url = "http://192.168.0.102:8080/Project2CE1103_war_exploded/resource/USUARIOS/NUEVOUSUARIO";

            var json = JsonConvert.SerializeObject(register);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var result = await client.PostAsync(url, content);

            label1.Text = result.ReasonPhrase;

            await Navigation.PushAsync(new MainPage());

        }
    }
}