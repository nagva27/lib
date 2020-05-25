﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    interface PluginFactory
    {
        int PluginsCount { get; }
        string[] GetPluginNames { get; }
        IPlugin GetPlugin(string pluginName);
    }
}
