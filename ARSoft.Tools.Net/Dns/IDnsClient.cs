﻿#region Copyright and License
// Copyright 2010..2017 Alexander Reinert
// 
// This file is part of the ARSoft.Tools.Net - C# DNS client/server and SPF Library (https://github.com/alexreinert/ARSoft.Tools.Net)
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System.Threading;
using System.Threading.Tasks;

namespace ARSoft.Tools.Net.Dns
{
    /// <summary>
    ///   Defines a client for querying dns records
    /// </summary>
    public interface IDnsClient : IDnsClientBase
	{
		/// <summary>
		///   Queries a dns server for specified records as an asynchronous operation.
		/// </summary>
		/// <param name="name"> Domain, that should be queried </param>
		/// <param name="recordType"> Type the should be queried </param>
		/// <param name="recordClass"> Class the should be queried </param>
		/// <param name="options"> Options for the query </param>
		/// <param name="token"> The token to monitor cancellation requests </param>
		/// <returns> The complete response of the dns server </returns>
		Task<DnsMessage> ResolveAsync(DomainName name, RecordType recordType = RecordType.A, RecordClass recordClass = RecordClass.INet, DnsQueryOptions options = null, CancellationToken token = default(CancellationToken));

	}
}
