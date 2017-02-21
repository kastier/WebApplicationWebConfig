using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryV2
{
 public  class WebConfig
    {
        public static IConfigurationRoot AppSettingsConfiguration { get; set; }
        public static string rootPath { get; set; }


    }
}
