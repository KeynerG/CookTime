using CookTime2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace CookTime2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class LoginPage : ContentPage
    {
        public static string username { set; get; }
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            username = EntryUsername.Text;

            LoginUser login = new LoginUser(EntryEmail.Text, EntryPassword.Text, EntryUsername.Text);
            HttpClient client = new HttpClient();
            string url = "http://192.168.0.102:8080/Project2CE1103_war_exploded/resource/USUARIOS/IniciarSesion";

            var json = JsonConvert.SerializeObject(login);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var result = await client.PostAsync(url, content);

            label1.Text = result.StatusCode.ToString();

            if (result.StatusCode.ToString().Equals("OK")) {

                await Navigation.PushAsync(new MainPage());
            }
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
    }
}