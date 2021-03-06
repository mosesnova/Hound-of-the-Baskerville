﻿// This source file is part of the eEx Network Library Management Layer (NLML)
//
// Author: 	    Emanuel Jöbstl <emi@eex-dev.net>
// Weblink: 	http://network.eex-dev.net
//		        http://eex.codeplex.com
//
// Licensed under the GNU Library General Public License (LGPL) 
//
// (c) eex-dev 2007-2011

using System;
using System.Collections.Generic;
using System.Text;
using eExNetworkLibrary.Monitoring;
using eExNLML.IO;
using eExNetworkLibrary;
using eExNLML.IO.HandlerConfigurationWriters;
using eExNLML.IO.HandlerConfigurationLoaders;
using eExNLML.Extensibility;
using eExNLML.DefaultControllers;

namespace eExNLML.DefaultDefinitions
{
    public class TrafficDumperControlDefinition : HandlerDefinition
    {
        public TrafficDumperControlDefinition()
        {
            Name = "Dumper";
            Description = "This traffic handler dumps all received frames into an file, readable for wireshark and other analyzers.\nIt also supports sending captures to a wireshark instance in realtime. This feature requires wireshark to be installed.";
            Author = "Emanuel Jöbstl";
            WebLink = "http://www.eex-dev.net";
            PluginType = PluginTypes.TrafficHandler;
            PluginKey = "eex_dumper";
        }

        public override IHandlerController Create(IEnvironment env)
        {
            return new TrafficDumperController(this, env);
        }
    }
}
