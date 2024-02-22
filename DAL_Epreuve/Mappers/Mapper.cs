using System;
using System.Collections.Generic;
using System.Text;
using DAL = DAL_Epreuve.Entities;
using System.Data;
using DAL_Epreuve.Entities;


namespace DAL_Epreuve.Mappers
{
    internal static class Mapper
    {
      

        public static Produit ToProduit(this IDataRecord record)
        {
            if (record is null) return null;
            return new Produit()
            {
                Id_Produit = (int)record["Id_Produit"],
                Nom = (string)record["Nom"],
                Description = (string)record["Description"],
                Prix = (decimal)record["Prix"],
                Ecoscore = record["Ecoscore"].ToString()[0],
                Categorie = (string)record["Categorie"]
            };
        }

        public static Media ToMedia (this IDataRecord record)
        {
            if (record is null) return null;
            return new Media()
            {
                Id_Media = (int)record["Id_Media"],
                ImageUrl = (string)record["ImageUrl"],
                Id_Produit = (int)record["Id_produit"]
            };
        }
    }
}
