using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    public static  class WebConfig
    {


        public static IConfigurationRoot AppSettingsConfiguration { get; set; }


        public  static string getAppSettings(string key)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("/WebAppData/appdata.json");
            AppSettingsConfiguration = builder.Build();
            return AppSettingsConfiguration[key];

        }

    }
}
