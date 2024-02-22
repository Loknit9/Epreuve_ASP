//using Microsoft.Extensions.Configuration;
//using Shared_epreuve.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using DAL_Epreuve.Entities;
//using System.Data.SqlClient;

//namespace DAL_Epreuve.Services
//{
//    public class DetailCommandeService : BaseService, IDetailCommandeRepository<DetailCommande>
//    {
//        public DetailCommandeService(IConfiguration configuration, string dbname) : base(configuration, dbname)
//        {
//        }

        

//        public IEnumerable<DetailCommande> Get()
//        {
//            using (SqlConnection connection = new SqlConnection(_connectionString))
//            {
//                using (SqlCommand command = connection.CreateCommand())
//                {
//                    command.CommandText = "SP_DetailCommande_GetAll";
//                    command.CommandType = System.Data.CommandType.StoredProcedure;
//                    connection.Open();
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            yield return reader.ToDetailCommande();
//                        }
//                    }
//                }
//            }
//        }

//        public DetailCommande Get(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public int Insert(DetailCommande entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(DetailCommande entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void Delete(int id)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
