﻿using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;


namespace Electricity.Context
{
    public class LastTwoMonthContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public LastTwoMonthContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
        }
        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
