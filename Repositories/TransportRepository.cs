using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransportManager.Models;
using Dapper;
using System.Linq;
using System.Windows.Forms;

namespace TransportManager.Repositories
{
    public interface ITransportRepository
    {
        List<Airway> GetAllAirways();
        List<Railway> GetAllRailways();
        List<Highway> GetAllHighways();
        void SortAirways(DataGridView table, ComboBox algorithm);
        void SortRailways(DataGridView table, ComboBox algorithm);
        void SortHighways(DataGridView table, ComboBox algorithm);
    }

    public class TransportRepository : ITransportRepository
    {
        string connStr = null;

        public TransportRepository(string connection)
        {
            connStr = connection;
        }

        public List<Airway> GetAllAirways()
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                return db.Query<Airway>("SELECT * FROM Airway").ToList();
            }
        }

        public List<Highway> GetAllHighways()
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                return db.Query<Highway>("SELECT * FROM Highway").ToList();
            }
        }

        public List<Railway> GetAllRailways()
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                return db.Query<Railway>("SELECT * FROM Railway").ToList();
            }
        }

        public void DeleteDatabase()
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                db.Query("DROP DATABASE Transport_db");
            }
        }

        public void SortAirways(DataGridView table, ComboBox algorithm)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                switch (algorithm.SelectedIndex)
                {
                    case 0:
                        table.DataSource = null;
                        table.DataSource = db.Query<Airway>("SELECT * FROM [Airway] ORDER BY [Airway].[Id] ASC").ToList();
                        break;
                    case 1:
                        table.DataSource = null;
                        table.DataSource = db.Query<Airway>("SELECT * FROM [Airway] ORDER BY [Airway].[Id] DESC").ToList();
                        break;
                    case 2:
                        table.DataSource = null;
                        table.DataSource = db.Query<Airway>("SELECT * FROM [Airway] ORDER BY [Airway].[AirplaneType] ASC").ToList();
                        break;
                    case 3:
                        table.DataSource = null;
                        table.DataSource = db.Query<Airway>("SELECT * FROM [Airway] ORDER BY [Airway].[AirplaneType] DESC").ToList();
                        break;
                    case 4:
                        table.DataSource = null;
                        table.DataSource = db.Query<Airway>("SELECT * FROM [Airway] ORDER BY [Airway].[AirfieldType] ASC").ToList();
                        break;
                    case 5:
                        table.DataSource = null;
                        table.DataSource = db.Query<Airway>("SELECT * FROM [Airway] ORDER BY [Airway].[AirfieldType] DESC").ToList();
                        break;
                    case 6:
                        table.DataSource = null;
                        table.DataSource = db.Query<Airway>("SELECT * FROM [Airway] ORDER BY [Airway].[Strict] ASC").ToList();
                        break;
                    case 7:
                        table.DataSource = null;
                        table.DataSource = db.Query<Airway>("SELECT * FROM [Airway] ORDER BY [Airway].[Strict] DESC").ToList();
                        break;
                    case 8:
                        table.DataSource = null;
                        table.DataSource = db.Query<Airway>("SELECT * FROM [Airway] ORDER BY [Airway].[Length] ASC").ToList();
                        break;
                    case 9:
                        table.DataSource = null;
                        table.DataSource = db.Query<Airway>("SELECT * FROM [Airway] ORDER BY [Airway].[Length] DESC").ToList();
                        break;
                    case 10:
                        table.DataSource = null;
                        table.DataSource = db.Query<Airway>("SELECT * FROM [Airway] ORDER BY [Airway].[Capacity] ASC").ToList();
                        break;
                    case 11:
                        table.DataSource = null;
                        table.DataSource = db.Query<Airway>("SELECT * FROM [Airway] ORDER BY [Airway].[Capacity] DESC").ToList();
                        break;
                }
            }
        }

        public void SortRailways(DataGridView table, ComboBox algorithm)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                switch (algorithm.SelectedIndex)
                {
                    case 0:
                        table.DataSource = null;
                        table.DataSource = db.Query<Railway>("SELECT * FROM [Railway] ORDER BY [Railway].[Id] ASC").ToList();
                        break;
                    case 1:
                        table.DataSource = null;
                        table.DataSource = db.Query<Railway>("SELECT * FROM [Railway] ORDER BY [Railway].[Id] DESC").ToList();
                        break;
                    case 2:
                        table.DataSource = null;
                        table.DataSource = db.Query<Railway>("SELECT * FROM [Railway] ORDER BY [Railway].[TrainType] ASC").ToList();
                        break;
                    case 3:
                        table.DataSource = null;
                        table.DataSource = db.Query<Railway>("SELECT * FROM [Railway] ORDER BY [Railway].[TrainType] DESC").ToList();
                        break;
                    case 4:
                        table.DataSource = null;
                        table.DataSource = db.Query<Railway>("SELECT * FROM [Railway] ORDER BY [Railway].[TrackType] ASC").ToList();
                        break;
                    case 5:
                        table.DataSource = null;
                        table.DataSource = db.Query<Railway>("SELECT * FROM [Railway] ORDER BY [Railway].[TrackType] DESC").ToList();
                        break;
                    case 6:
                        table.DataSource = null;
                        table.DataSource = db.Query<Railway>("SELECT * FROM [Railway] ORDER BY [Railway].[Strict] ASC").ToList();
                        break;
                    case 7:
                        table.DataSource = null;
                        table.DataSource = db.Query<Railway>("SELECT * FROM [Railway] ORDER BY [Railway].[Strict] DESC").ToList();
                        break;
                    case 8:
                        table.DataSource = null;
                        table.DataSource = db.Query<Railway>("SELECT * FROM [Railway] ORDER BY [Railway].[Length] ASC").ToList();
                        break;
                    case 9:
                        table.DataSource = null;
                        table.DataSource = db.Query<Railway>("SELECT * FROM [Railway] ORDER BY [Railway].[Length] DESC").ToList();
                        break;
                    case 10:
                        table.DataSource = null;
                        table.DataSource = db.Query<Railway>("SELECT * FROM [Railway] ORDER BY [Railway].[Capacity] ASC").ToList();
                        break;
                    case 11:
                        table.DataSource = null;
                        table.DataSource = db.Query<Railway>("SELECT * FROM [Railway] ORDER BY [Railway].[Capacity] DESC").ToList();
                        break;
                }
            }
        }

        public void SortHighways(DataGridView table, ComboBox algorithm)
        {
            using (IDbConnection db = new SqlConnection(connStr))
            {
                switch (algorithm.SelectedIndex)
                {
                    case 0:
                        table.DataSource = null;
                        table.DataSource = db.Query<Highway>("SELECT * FROM [Highway] ORDER BY [Highway].[Id] ASC").ToList();
                        break;
                    case 1:
                        table.DataSource = null;
                        table.DataSource = db.Query<Highway>("SELECT * FROM [Highway] ORDER BY [Highway].[Id] DESC").ToList();
                        break;
                    case 2:
                        table.DataSource = null;
                        table.DataSource = db.Query<Highway>("SELECT * FROM [Highway] ORDER BY [Highway].[TransportType] ASC").ToList();
                        break;
                    case 3:
                        table.DataSource = null;
                        table.DataSource = db.Query<Highway>("SELECT * FROM [Highway] ORDER BY [Highway].[TransportType] DESC").ToList();
                        break;
                    case 4:
                        table.DataSource = null;
                        table.DataSource = db.Query<Highway>("SELECT * FROM [Highway] ORDER BY [Highway].[CoatingType] ASC").ToList();
                        break;
                    case 5:
                        table.DataSource = null;
                        table.DataSource = db.Query<Highway>("SELECT * FROM [Highway] ORDER BY [Highway].[CoatingType] DESC").ToList();
                        break;
                    case 6:
                        table.DataSource = null;
                        table.DataSource = db.Query<Highway>("SELECT * FROM [Highway] ORDER BY [Highway].[Strict] ASC").ToList();
                        break;
                    case 7:
                        table.DataSource = null;
                        table.DataSource = db.Query<Highway>("SELECT * FROM [Highway] ORDER BY [Highway].[Strict] DESC").ToList();
                        break;
                    case 8:
                        table.DataSource = null;
                        table.DataSource = db.Query<Highway>("SELECT * FROM [Highway] ORDER BY [Highway].[Length] ASC").ToList();
                        break;
                    case 9:
                        table.DataSource = null;
                        table.DataSource = db.Query<Highway>("SELECT * FROM [Highway] ORDER BY [Highway].[Length] DESC").ToList();
                        break;
                    case 10:
                        table.DataSource = null;
                        table.DataSource = db.Query<Highway>("SELECT * FROM [Highway] ORDER BY [Highway].[Capacity] ASC").ToList();
                        break;
                    case 11:
                        table.DataSource = null;
                        table.DataSource = db.Query<Highway>("SELECT * FROM [Highway] ORDER BY [Highway].[Capacity] DESC").ToList();
                        break;
                }
            }
        }
    }
}
