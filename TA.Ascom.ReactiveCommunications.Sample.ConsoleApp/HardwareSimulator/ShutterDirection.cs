﻿// This file is part of the TA.Ascom.ReactiveCommunications project
// 
// Copyright © 2015-2020 Tigra Astronomy, all rights reserved.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so. The Software comes with no warranty of any kind.
// You make use of the Software entirely at your own risk and assume all liability arising from your use thereof.
// 
// File: ShutterDirection.cs  Last modified: 2020-07-16@02:26 by Tim Long

namespace TA.Ascom.ReactiveCommunications.Sample.ConsoleApp.HardwareSimulator
    {
    /// <summary>
    ///     Shutter movement directions. Note: ordinal values are important and are used for parsing
    ///     received data within <c>DeviceController</c>.
    /// </summary>
    public enum ShutterDirection
        {
        /// <summary>The shutter is not moving, or the direction is unknown</summary>
        None = 0,
        /// <summary>The shutter is closing.</summary>
        Closing = 1,
        /// <summary>The shutter is opening.</summary>
        Opening = 2
        }
    }