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
        #region Produit

        public static Produit ToProduit(this IDataRecord record)
        {
            if (record is null) return null;
            return new Produit()
            {
                Id_Produit = (int)record["Id_produit"],
                Nom = (string)record["Nom"],
                Description = (string)record["Description"],
                Prix = (decimal)record["Prix"],
                Ecoscore = record["Ecoscore"].ToString()[0],
                Categorie = (string)record["Categorie"]
            };
        }

        #endregion
    }
}
