using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CookTime2.Models
{
    public partial class Recipe
    {
        [JsonProperty("porciones")]
        public long Porciones { get; set; }

        [JsonProperty("ingredientes")]
        public string[] Ingredientes { get; set; }

        [JsonProperty("autor")]
        public string Autor { get; set; }

        [JsonProperty("tiempo")]
        public string Tiempo { get; set; }

        [JsonProperty("tipoPlato")]
        public string TipoPlato { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("duracion")]
        public string Duracion { get; set; }

        [JsonProperty("dificultad")]
        public long Dificultad { get; set; }

        [JsonProperty("pasos")]
        public string[] Pasos { get; set; }

        [JsonProperty("dieta")]
        public string[] Dieta { get; set; }



        public Recipe(string name, string author, string plateType, int difficulty, string time, int portions1, string duration, string[] ingredients, string[] steps)
        {
            this.Name = name;
            this.TipoPlato = plateType;
            this.Dificultad = difficulty;
            this.Porciones = portions1;
            this.Tiempo = time;
            this.Duracion = duration;
            this.Ingredientes = ingredients;
            this.Pasos = steps;
            this.Autor = author;
        }

    }


    public partial class Recipe
    {
        public static Recipe[] FromJson(string json) => JsonConvert.DeserializeObject<Recipe[]>(json, CookTime2.Models.Converter.Settings);
    }
}
