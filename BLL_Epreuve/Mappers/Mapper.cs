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

        public static DAL.Produit ToDAL(this BLL.Produit entity)
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

        #region Media

        public static BLL.Media ToBLL(this DAL.Media entity)
        {
            if (entity is null) return null;
            return new BLL.Media(
                entity.Id_Media,
                entity.ImageUrl,
                entity.Id_Produit);     
        }

        public static DAL.Media ToDAL(this BLL.Media entity)
        {
            if (entity is null) return null;
            return new DAL.Media()
            {
                ImageUrl = entity.ImageUrl,
                Id_Media = entity.Id_Media,
                Id_Produit = entity.Id_Produit,
            };
        }

        #endregion
    }
}
