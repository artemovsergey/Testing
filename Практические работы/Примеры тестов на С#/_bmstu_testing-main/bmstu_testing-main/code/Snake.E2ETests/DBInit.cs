using System;
using NUnit.Framework;
using Microsoft.Data.Sqlite;

namespace Snake.E2ETests
{
    class DBInit
    {
        /// <summary>
        /// Shareable in-memory databases init
        /// </summary>
        [Test]
        public void InitDataBase()
        {
            const string connectionString = "Data Source=InMemorySample;Mode=Memory;Cache=Shared";

            // The in-memory database only persists while a connection is open to it. To manage
            // its lifetime, keep one open connection around for as long as you need it.
            var masterConnection = new SqliteConnection(connectionString);
            masterConnection.Open();
            
            string allCommands = System.IO.File.ReadAllText("../../../dbinit.sql");
            Assert.NotNull(allCommands);

            var createCommand = masterConnection.CreateCommand();
            createCommand.CommandText = allCommands;

            createCommand.ExecuteNonQuery();

            using (var secondConnection = new SqliteConnection(connectionString))
            {
                secondConnection.Open();
                var queryCommand = secondConnection.CreateCommand();
                queryCommand.CommandText =
                @"
                    SELECT *
                    FROM data
                ";
                var value = (string)queryCommand.ExecuteScalar();
                Assert.AreEqual("Hello, memory!", value);
            }

            // After all the connections are closed, the database is deleted.
            masterConnection.Close();
        }
    }
}
