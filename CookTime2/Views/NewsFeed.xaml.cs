using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CookTime2.Models;

namespace CookTime2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsFeed : ContentPage
    {
        
        
        public NewsFeed()
        {
            InitializeComponent();
            
        }

        private async void getNewsFeed() {

            
            HttpClient client = new HttpClient();

            string url = "http://192.168.0.102:8080/Project2CE1103_war_exploded/resource/USUARIOS/newsFeed/"+LoginPage.username;

            var resultado = await client.GetAsync(url);
            var json = resultado.Content.ReadAsStringAsync().Result;

            NewsFeedModel[] feed = NewsFeedModel.FromJson(json);

            NewsList.ItemsSource = feed;
        }
    }
}