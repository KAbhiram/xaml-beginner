using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Resources;

namespace ResourceLoaderDemo
{
    public class GreetingResourceLoader : CustomXamlResourceLoader
    {
        private Dictionary<string, string> _resourceDictionary = new Dictionary<string, string>
        {
            {"Dev", "Hello Developers" },
            {"IT", "Hello IT Pros" }
        };

        protected override object GetResource(string resourceId, string objectType, string propertyName, string propertyType)
        {
            return _resourceDictionary[resourceId];
        }
    }
}
