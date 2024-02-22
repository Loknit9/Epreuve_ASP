using ASP_Epreuve.Models;
using BLL_Epreuve.Entities;
using System.Runtime.CompilerServices;

namespace ASP_Epreuve.Handlers
{
    public static class Mapper
    {

        #region Produit
        public static ProduitListItemViewModel ToListItem(this Produit entity)
        {
            if (entity == null) return null;
            return new ProduitListItemViewModel()
            {
                Id_Produit = entity.Id_Produit,
                Nom = entity.Nom,
                Prix = entity.Prix,
                Ecoscore = entity.Ecoscore,
                Categorie = entity.Categorie
            };
        }

        public static ProduitDetailViewModel ToDetails(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitDetailViewModel()
            {
                Id_Produit = entity.Id_Produit,
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                Ecoscore = entity.Ecoscore,
                Categorie = entity.Categorie
            };
        }

        public static Produit ToBLL(this ProduitCreateForm entity)
        {
            if (entity is null) return null;
            return new Produit(
                0,
                entity.Nom,
                entity.Description,
                entity.Prix,
                entity.Ecoscore,
                entity.Categorie
                );
        }
        
        public static ProduitEditForm Update(this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitEditForm
            {
                Id_Produit = entity.Id_Produit,
                Nom = entity.Nom,
                Description = entity.Description,
                Prix = entity.Prix,
                Ecoscore = entity.Ecoscore,
                Categorie = entity.Categorie
            };
        }

        public static Produit ToBLL(this ProduitEditForm entity)
        {
            if (entity is null) return null;
            return new Produit(
                entity.Id_Produit,
                entity.Nom,
                entity.Description,
                entity.Prix,
                entity.Ecoscore,
                entity.Categorie);
        }

        public static ProduitDeleteViewModel Delete (this Produit entity)
        {
            if (entity is null) return null;
            return new ProduitDeleteViewModel()
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

        public static MediaListViewModel ToListItem(this Media entity)
        {
            if (entity == null) return null;
            return new MediaListViewModel()
            {
                ImageUrl = entity.ImageUrl,
                Id_Media = entity.Id_Media,
                Id_Produit = entity.Id_Produit
                
            };
        }


        public static MediaDetailsViewModel ToDetails(this Media entity)
        {
            if (entity is null) return null;
            return new MediaDetailsViewModel()
            {
                Id_Media = entity.Id_Media,
                ImageUrl = entity.ImageUrl,
                Id_Produit = entity.Id_Produit,
                
            };
        }


        public static Media ToBLL(this MediaCreateForm entity)
        {
            if (entity is null) return null;
            return new Media(
                0,
                entity.ImageUrl.FileName,
                entity.Id_Produit
                );
        }

        public static MediaDeleteViewModel Delete(this Media entity)
        {
            if (entity is null) return null;
            return new MediaDeleteViewModel()
            {
                ImageUrl = entity.ImageUrl,
                Id_Media = entity.Id_Media,
                Id_Produit = entity.Id_Produit

            };
        }

        #endregion
    }
}
