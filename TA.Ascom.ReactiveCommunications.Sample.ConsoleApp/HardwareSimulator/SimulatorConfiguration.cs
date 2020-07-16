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
// File: SimulatorConfiguration.cs  Last modified: 2020-07-16@02:26 by Tim Long

using System;

namespace TA.Ascom.ReactiveCommunications.Sample.ConsoleApp.HardwareSimulator
    {
    internal class SimulatorConfiguration
        {
        public int DomeCircumferenceTicks { get; set; } = 500;

        public TimeSpan AzimuthEncoderTickInterval { get; set; } = TimeSpan.FromMilliseconds(250);

        public TimeSpan InterCharTimeout { get; set; } = TimeSpan.FromMilliseconds(1000);

        public bool Realtime { get; set; }
        }
    }