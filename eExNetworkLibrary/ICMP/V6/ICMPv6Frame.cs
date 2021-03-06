﻿// This source file is part of the eEx Network Library
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

namespace eExNetworkLibrary.ICMP.V6
{
    /// <summary>
    /// Represents an ICMPv6 frame
    /// </summary>
    public class ICMPv6Frame : ICMPFrame
    {
        public static string DefaultFrameType { get { return FrameTypes.ICMPv6; } }

        /// <summary>
        /// Returns the type of this frame.
        /// </summary>
        public override string FrameType
        {
            get { return ICMPv6Frame.DefaultFrameType; }
        }

        /// <summary>
        /// Gets or sets the type of this ICMP frame
        /// </summary>
        public ICMPv6Type ICMPv6Type
        {
            get { return (ICMPv6Type)icmpType; }
            set { icmpType = (int)value; }
        }

        public ICMPv6Frame(byte[] bData)
            : base(bData)
        {
            Encapsulate(bData, 4);

            //Auto parse ICMP payload

         
        }
        public ICMPv6Frame() : base() { }

        /// <summary>
        /// Creates a new identical instance of this class
        /// </summary>
        /// <returns>A new identical instance of this class</returns>
        public override Frame Clone()
        {
            return new ICMPv6Frame(this.FrameBytes);
        }

    }
}
