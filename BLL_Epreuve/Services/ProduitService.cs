﻿using BLL_Epreuve.Entities;
using BLL_Epreuve.Mappers;
using Shared_epreuve.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL = DAL_Epreuve.Entities;


namespace BLL_Epreuve.Services
{
    public class ProduitService : IProduitRepository<Produit>
    {

        private readonly IProduitRepository<DAL.Produit> _produitRepository;

        public ProduitService(IProduitRepository<DAL.Produit> produitRepository)
        {
            _produitRepository = _produitRepository;
        }
       

        public IEnumerable<Produit> Get()
        {
            return _produitRepository.Get().Select(d=>d.ToBLL());
        }

        public Produit Get(int id)
        {
            Produit entity = _produitRepository.Get(id).ToBLL();
            return entity;
        }

        public int Insert(Produit entity)
        {
            return _produitRepository.Insert(DataMisalignedException.ToDAL());
        }

        public void Update(Produit entity)
        {
            _produitRepository.Update(DataMisalignedException.ToDAL());
        }

        public void Delete(int id)
        {
            _produitRepository.Delete(id);
        }

        public IEnumerable<Produit> GetByCategorie(string Categorie)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produit> GetByEcoscore(string Ecoscore)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produit> GetByName(string Nom)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produit> GetByFavoris(int id)
        {
            throw new NotImplementedException();
        }
    }
}
