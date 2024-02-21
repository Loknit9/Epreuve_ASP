using System;
using System.Collections.Generic;
using System.Text;
using DAL = DAL_Epreuve.Entities;
using BLL = BLL_Epreuve.Entities;

namespace BLL_Epreuve.Mappers
{
    internal static class Mapper
    {
        #region Produit

        public static BLL.Produit ToBLL(this DAL.Produit entity)
        {
            if (entity is null) return null;
            return new BLL.Produit(
                entity.Id_Produit,
                entity.Nom,
                entity.Description,
                entity.Prix,
                entity.Ecoscore,
                entity.Categorie);
        }

        public static DAL.Produit ToDAL(this DAL.Produit entity)
        {
            if (entity is null) return null;
            return new DAL.Produit()
            {
                Id_Produit = entity.Id_Produit,
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                Ecoscore = entity.Ecoscore,
                Categorie = entity.Categorie
            };
        }

        #endregion
    }
}
