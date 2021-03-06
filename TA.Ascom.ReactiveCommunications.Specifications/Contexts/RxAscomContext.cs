﻿// This file is part of the TA.Ascom.ReactiveCommunications project
// 
// Copyright © 2018 Tigra Astronomy, all rights reserved.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so,. The Software comes with no warranty of any kind.
// You make use of the Software entirely at your own risk and assume all liability arising from your use thereof.
// 
// File: RxAscomContext.cs  Last modified: 2018-03-15@17:55 by Tim Long

namespace TA.Ascom.ReactiveCommunications.Specifications.Contexts
    {
    internal class RxAscomContext
        {
        public ICommunicationChannel Channel { get; set; }

        public ITransactionProcessor Processor { get; set; }

        public TransactionObserver Observer { get; set; }

        public DeviceTransaction Transaction { get; set; }
        }
    }