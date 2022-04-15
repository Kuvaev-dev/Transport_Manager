using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using TransportManager.Models;

namespace TransportManager.Repositories
{
    public interface ITaskRepository
    {
        int FirstTask(string place);
        List<Highway> SecondTask(int capacity);
        List<Airway> ThirdTask(string type, string place);
    }

    public class TaskRepository : ITaskRepository
    {
        string connStr = null;

        public TaskRepository(string connection)
        {
            connStr = connection;
        }

        public int FirstTask(string place)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                return db.Query<int>("SELECT SUM([Railway].[Length]) + SUM([Highway].[Length]) " +
                    "FROM [Railway], [Highway] " +
                    $"WHERE [Railway].[Strict] = '{ place }' " +
                    $"AND [Highway].[Strict] = '{ place }';").FirstOrDefault();
            }
        }

        public List<Highway> SecondTask(int capacity)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                return db.Query<Highway>($"SELECT * FROM [Highway] WHERE [Highway].[Capacity] > { capacity };").ToList();
            }
        }

        public List<Airway> ThirdTask(string type, string place)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                return db.Query<Airway>($"SELECT * FROM [Airway] " +
                    $"WHERE [Airway].[AirplaneType] = '{ type }' AND [Airway].[Strict] = '{ place }';").ToList();
            }
        }
    }
}
