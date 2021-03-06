﻿// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using static Google.LongRunning.Operations;

namespace Google.Cloud.Speech.V1
{
    public static partial class Speech
    {
        public partial class SpeechClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="OperationsClient"/> using the same call invoker as this client. 
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual OperationsClient CreateOperationsClient() => new OperationsClient(CallInvoker);
        }
    }
}
