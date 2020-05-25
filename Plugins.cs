using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    public class Plugins : PluginFactory                /**static classes cannot implement interfaces*/
    {
        private List<IPlugin> pluginList;

        public Plugins()
        {
            pluginList = new List<IPlugin>();
            pluginList.Add(new exp());
            pluginList.Add(new multiply());
            pluginList.Add(new sin());
            pluginList.Add(new divide());
            pluginList.Add(new add());
        }

        public int PluginsCount { get 
            { 
                return pluginList.Count(); 
            } 
        }
        public string[] GetPluginNames { get
            {
                List<string> names = new List<string>();
                pluginList.ForEach(delegate (IPlugin i) {
                    names.Add(i.ToString());
                });
                return names.ToArray();
            }
        }

        public IPlugin GetPlugin(string pluginName)
        {
            foreach(IPlugin plugin in pluginList)
            {
                if (plugin.ToString().ToUpper() == pluginName.ToUpper())
                {
                    return plugin;
                }
            }
            return null;
        }
    }
}
