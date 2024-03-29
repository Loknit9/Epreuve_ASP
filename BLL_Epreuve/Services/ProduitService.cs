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
            _produitRepository = produitRepository;
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

        public int Insert(Produit data)
        {
            return _produitRepository.Insert(data.ToDAL());
        }

        public void Update(Produit data)
        {
            _produitRepository.Update(data.ToDAL());
        }

        public void Delete(int id)
        {
            _produitRepository.Delete(id);
        }

        public IEnumerable<Produit> GetByCategorie(string Categorie)
        {
            
            return _produitRepository.GetByCategorie(Categorie).Select(d => d.ToBLL());
        }

        public IEnumerable<Produit> GetByEcoscore(string Ecoscore)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produit> GetByName(string Nom)
        {
            return _produitRepository.GetByName(Nom).Select(d =>d.ToBLL());
        }

        public IEnumerable<Produit> GetByFavoris(int id)
        {
            throw new NotImplementedException();
        }
    }
}
