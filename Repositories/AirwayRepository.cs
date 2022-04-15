using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using TransportManager.Models;

namespace TransportManager.Repositories
{
    public interface IAirwayRepository
    {
        void Insert(Airway airway);
        void Update(Airway airway, int airway_id);
        void Delete(int airway_id);
        List<Airway> GetAirways();
        Airway GetAirwayById(int id);
        List<Airway> GetAirwayListById(int id);
        List<Airway> GetAirwayByAirplaneType(string type);
        List<Airway> GetAirwayByAirfieldType(string type);
        List<Airway> GetAirwayByStrict(string strict);
        List<Airway> GetAirwayByLength(int min_length, int max_length);
        List<Airway> GetAirwayByCapacity(int min_capacity, int max_capacity);
        void UpdateAirwayByAirplaneType(Airway airway, string type);
        void UpdateAirwayByAirfieldType(Airway airway, string type);
        void UpdateAirwayByStrict(Airway airway, string strict);
        void UpdateAirwayByLength(Airway airway, int length);
        void UpdateAirwayByCapacity(Airway airway, int capacity);
    }

    public class AirwayRepository : IAirwayRepository
    {
        string connStr = null;

        public AirwayRepository(string connection)
        {
            connStr = connection;
        }

        public void Delete(int airway_id)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                var sqlQuery = $"DELETE FROM [Airway] WHERE Id = { airway_id }";
                db.Execute(sqlQuery, new { airway_id });
            }
        }

        public List<Airway> GetAirwayByAirfieldType(string type)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                return db.Query<Airway>($"SELECT * FROM [Airway] WHERE [Airway].[AirfieldType] = '{ type }';").ToList();
            }
        }

        public List<Airway> GetAirwayByAirplaneType(string type)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                return db.Query<Airway>($"SELECT * FROM [Airway] WHERE [Airway].[AirplaneType] = '{ type }';").ToList();
            }
        }

        public List<Airway> GetAirwayByCapacity(int min_capacity, int max_capacity)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                return db.Query<Airway>($"SELECT * FROM [Airway] WHERE [Airway].[Capacity] BETWEEN { min_capacity } AND { max_capacity };").ToList();
            }
        }

        public Airway GetAirwayById(int id)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                return db.Query<Airway>($"SELECT * FROM [Airway] WHERE [Airway].[Id] = { id };").FirstOrDefault();
            }
        }

        public List<Airway> GetAirwayListById(int id)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                return db.Query<Airway>($"SELECT * FROM [Airway] WHERE [Airway].[Id] = { id };").ToList();
            }
        }

        public List<Airway> GetAirwayByLength(int min_length, int max_length)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                return db.Query<Airway>($"SELECT * FROM [Airway] WHERE [Airway].[Length] BETWEEN { min_length } AND { max_length };").ToList();
            }
        }

        public List<Airway> GetAirwayByStrict(string strict)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                return db.Query<Airway>($"SELECT * FROM [Airway] WHERE [Airway].[Strict] = '{ strict }';").ToList();
            }
        }

        public List<Airway> GetAirways()
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                return db.Query<Airway>($"SELECT * FROM [Airway];").ToList();
            }
        }

        public void Insert(Airway airway)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var sqlQuery = "INSERT INTO [Airway]([AirplaneType], [AirfieldType], [Strict], [Length], [Capacity]) " +
                            "VALUES(@AirplaneType, @AirfieldType, @Strict, @Length, @Capacity);";
                        db.Execute(sqlQuery,
                           new
                           {
                               AirplaneType = airway.AirplaneType,
                               AirfieldType = airway.AirfieldType,
                               Strict = airway.Strict,
                               Length = airway.Length,
                               Capacity = airway.Capacity
                           },
                           transaction);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public void Update(Airway airway, int airway_id)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var sqlQuery = "UPDATE [Airway] SET " +
                            "[Airway].[AirplaneType] = @AirplaneType, " +
                            "[Airway].[AirfieldType] = @AirfieldType, " +
                            "[Airway].[Strict] = @Strict, " +
                            "[Airway].[Length] = @Length, " +
                            "[Airway].[Capacity] = @Capacity " +
                            $"WHERE [Airway].[Id] = { airway_id };";
                        db.Execute(sqlQuery,
                           new
                           {
                               AirplaneType = airway.AirplaneType,
                               AirfieldType = airway.AirfieldType,
                               Strict = airway.Strict,
                               Length = airway.Length,
                               Capacity = airway.Capacity
                           },
                           transaction);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public void UpdateAirwayByAirfieldType(Airway airway, string type)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var sqlQuery = "UPDATE [Airway] SET " +
                            "[Airway].[AirplaneType] = @AirplaneType, " +
                            "[Airway].[AirfieldType] = @AirfieldType, " +
                            "[Airway].[Strict] = @Strict, " +
                            "[Airway].[Length] = @Length, " +
                            "[Airway].[Capacity] = @Capacity " +
                            $"WHERE [Airway].[AirfieldType] = '{ type }';";
                        db.Execute(sqlQuery,
                           new
                           {
                               AirplaneType = airway.AirplaneType,
                               AirfieldType = airway.AirfieldType,
                               Strict = airway.Strict,
                               Length = airway.Length,
                               Capacity = airway.Capacity
                           },
                           transaction);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public void UpdateAirwayByAirplaneType(Airway airway, string type)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var sqlQuery = "UPDATE [Airway] SET " +
                            "[Airway].[AirplaneType] = @AirplaneType, " +
                            "[Airway].[AirfieldType] = @AirfieldType, " +
                            "[Airway].[Strict] = @Strict, " +
                            "[Airway].[Length] = @Length, " +
                            "[Airway].[Capacity] = @Capacity " +
                            $"WHERE [Airway].[AirplaneType] = '{ type }';";
                        db.Execute(sqlQuery,
                           new
                           {
                               AirplaneType = airway.AirplaneType,
                               AirfieldType = airway.AirfieldType,
                               Strict = airway.Strict,
                               Length = airway.Length,
                               Capacity = airway.Capacity
                           },
                           transaction);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public void UpdateAirwayByCapacity(Airway airway, int capacity)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var sqlQuery = "UPDATE [Airway] SET " +
                            "[Airway].[AirplaneType] = @AirplaneType, " +
                            "[Airway].[AirfieldType] = @AirfieldType, " +
                            "[Airway].[Strict] = @Strict, " +
                            "[Airway].[Length] = @Length, " +
                            "[Airway].[Capacity] = @Capacity " +
                            $"WHERE [Airway].[Capacity] = { capacity };";
                        db.Execute(sqlQuery,
                           new
                           {
                               AirplaneType = airway.AirplaneType,
                               AirfieldType = airway.AirfieldType,
                               Strict = airway.Strict,
                               Length = airway.Length,
                               Capacity = airway.Capacity
                           },
                           transaction);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public void UpdateAirwayByLength(Airway airway, int length)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var sqlQuery = "UPDATE [Airway] SET " +
                            "[Airway].[AirplaneType] = @AirplaneType, " +
                            "[Airway].[AirfieldType] = @AirfieldType, " +
                            "[Airway].[Strict] = @Strict, " +
                            "[Airway].[Length] = @Length, " +
                            "[Airway].[Capacity] = @Capacity " +
                            $"WHERE [Airway].[Length] = { length };";
                        db.Execute(sqlQuery,
                           new
                           {
                               AirplaneType = airway.AirplaneType,
                               AirfieldType = airway.AirfieldType,
                               Strict = airway.Strict,
                               Length = airway.Length,
                               Capacity = airway.Capacity
                           },
                           transaction);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public void UpdateAirwayByStrict(Airway airway, string strict)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                db.Open();
                using (var transaction = db.BeginTransaction())
                {
                    try
                    {
                        var sqlQuery = "UPDATE [Airway] SET " +
                            "[Airway].[AirplaneType] = @AirplaneType, " +
                            "[Airway].[AirfieldType] = @AirfieldType, " +
                            "[Airway].[Strict] = @Strict, " +
                            "[Airway].[Length] = @Length, " +
                            "[Airway].[Capacity] = @Capacity " +
                            $"WHERE [Airway].[Strict] = '{ strict }';";
                        db.Execute(sqlQuery,
                           new
                           {
                               AirplaneType = airway.AirplaneType,
                               AirfieldType = airway.AirfieldType,
                               Strict = airway.Strict,
                               Length = airway.Length,
                               Capacity = airway.Capacity
                           },
                           transaction);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }
    }
}
