using CookTime2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookTime2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateRecipe : ContentPage
    {
        public CreateRecipe()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            int indiceTipo = PickerTipo.SelectedIndex;

            string tipo = Convert.ToString(PickerTipo.ItemsSource[indiceTipo]);

            string[] pasos = new string[] { EntryPasos.Text };
            string[] ingredientes = new string[] { EntryIngredientes.Text };

            Recipe recipe = new Recipe(EntryNombre.Text, EntryAutor.Text,Convert.ToString(PickerTipo.SelectedItem), int.Parse(EntryDificultad.Text), Convert.ToString(PickerTiempo.SelectedItem), int.Parse(EntryPorciones.Text), Convert.ToString(PickerDuracion.SelectedItem), ingredientes, pasos);
            HttpClient client = new HttpClient();
            string url = "http://192.168.0.102:8080/Project2CE1103_war_exploded/resource/USUARIOS/agregarReceta";

            var json = JsonConvert.SerializeObject(recipe);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var result = await client.PostAsync(url, content);

            limpiar();
        }

        public void limpiar() {
            EntryNombre.Text = "";
            PickerTipo.SelectedItem = null;
            EntryPorciones.Text = "";
            PickerTiempo.SelectedItem = null;
            PickerDuracion.SelectedItem = null;
            EntryDificultad.Text = "";
            EntryIngredientes.Text = "";
            EntryPasos.Text = "";
            EntryAutor.Text = "";

        }

    }
}