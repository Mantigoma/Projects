// Copyright 2007 Castle Project - http://www.castleproject.org/
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Castle.Core;

namespace Castle.Components.Scheduler.JobStores
{
    /// <summary>
    /// The SQL Server job store maintains all job state in a SQL Server database.
    /// </summary>
    [Singleton]
    public class SqlServerJobStore : AdoNetJobStore
    {
        /// <summary>
        /// Creates a SQL Server job store connected to a database.
        /// </summary>
        /// <param name="connectionString">The database connection string</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="connectionString"/> is null</exception>
        public SqlServerJobStore(string connectionString)
            : base(connectionString, "@")
        {
        }

        protected override IDbConnection CreateConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}