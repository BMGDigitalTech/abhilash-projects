using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonsoftJsonApp
{
    class JavaScriptSettings
    {
        public JRaw OnLoadFunction { get; set; }
        public  JRaw OnUnLoadFunction { get; set; }
    }
}
