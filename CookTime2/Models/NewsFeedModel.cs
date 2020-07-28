namespace CookTime2.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class NewsFeedModel
    {
        [JsonProperty("porciones")]
        public long Porciones { get; set; }

        [JsonProperty("ingredientes")]
        public string[] Ingredientes { get; set; }

        [JsonProperty("calificacion")]
        public long Calificacion { get; set; }

        [JsonProperty("autor")]
        public string Autor { get; set; }

        [JsonProperty("tiempo")]
        public string Tiempo { get; set; }

        [JsonProperty("tipoPlato")]
        public object TipoPlato { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("duracion")]
        public string Duracion { get; set; }

        [JsonProperty("mes")]
        public long Mes { get; set; }

        [JsonProperty("dia")]
        public long Dia { get; set; }

        [JsonProperty("dificultad")]
        public long Dificultad { get; set; }

        [JsonProperty("pasos")]
        public string[] Pasos { get; set; }

        [JsonProperty("dieta")]
        public string[] Dieta { get; set; }
    }

    public partial class NewsFeedModel
    {
        public static NewsFeedModel[] FromJson(string json) => JsonConvert.DeserializeObject<NewsFeedModel[]>(json, CookTime2.Models.Converter.Settings);
    }

}