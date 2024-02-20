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
                Prix = (int)record["Prix"],
                Ecoscore = (char)record["Ecoscore"],
                Categorie = (string)record["Categorie"]
            };
        }

        #endregion
    }
}
