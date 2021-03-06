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
using eExNetworkLibrary.Utilities;
using eExNetworkLibrary;
using eExNLML.IO;
using eExNLML.IO.HandlerConfigurationWriters;
using eExNLML.IO.HandlerConfigurationLoaders;
using eExNLML.Extensibility;

namespace eExNLML.DefaultControllers
{
    public class EthernetInterfaceController : HandlerController
    {
        private WinPcapInterface wpcInt;

        public EthernetInterfaceController(WinPcapInterface wpcInt, IHandlerDefinition hbDefinition, IEnvironment env)
            : base(hbDefinition, env, wpcInt)
        {
            this.wpcInt = wpcInt;
        }

        protected override eExNetworkLibrary.TrafficHandler Create(object param)
        {
            return new EthernetInterface((WinPcapInterface)param);
        }

        public string InterfaceGUID
        {
            get { return wpcInt.Name; }
        }

        protected override HandlerConfigurationLoader CreateConfigurationLoader(TrafficHandler h, object param)
        {
            return new EthernetInterfaceConfigurationLoader((EthernetInterface)h);
        }

        protected override HandlerConfigurationWriter CreateConfigurationWriter(TrafficHandler h, object param)
        {
            return new EthernetInterfaceConfigurationWriter((EthernetInterface)h);
        }

        protected override TrafficHandlerPort[] CreateTrafficHandlerPorts(TrafficHandler h, object param)
        {
            return CreateDefaultPorts(h, false, false, false, true, true);
        }
       
    }
}
