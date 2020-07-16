﻿using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CookTime2.Models
{
    public partial class RegisterUser
    {
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("edad")]
        public long Edad { get; set; }

        public RegisterUser(string name, string password, string email, int age) 
        {
            this.Nombre = name;
            this.Password = password;
            this.Email = email;
            this.Edad = age;
        }
    }

    public partial class RegisterUser
    {
        public static RegisterUser FromJson(string json) => JsonConvert.DeserializeObject<RegisterUser>(json, CookTime2.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RegisterUser self) => JsonConvert.SerializeObject(self, CookTime2.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
