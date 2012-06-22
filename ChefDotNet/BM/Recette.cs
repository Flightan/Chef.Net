﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM
{
    /// <summary>
    /// Class pour gérer les recettes
    /// </summary>
    public static class Recette
    {
        /// <summary>
        /// Création d'une recette
        /// Retourne un string vide si tout s'est bien passé, une string contenant les erreurs sinon
        /// </summary>
        public static string NewRecette(DBO.Recette recette)
        {
            return DA.Recette.NewRecette(recette);
        }

        /// <summary>
        /// Retourne toutes les recettes
        /// </summary>
        public static List<DBO.Recette> GetAll()
        {
            return DA.Recette.GetAll();
        }

        /// <summary>
        /// Retourne une recette selon son id
        /// </summary>
        public static DBO.Recette GetRecetteById(int id)
        {
            return DA.Recette.GetRecetteById(id);
        }

        /// <summary>
        /// Retourne une recette selon son nom
        /// </summary>
        public static DBO.Recette GetRecetteByNom(string nom)
        {
            return DA.Recette.GetRecetteByNom(nom);
        }

        /// <summary>
        /// Retourne les recettes favoris d'un utilisateur
        /// </summary>
        public static List<DBO.Recette> GetRecetteByUser(DBO.User user)
        {
            return DA.Recette.GetRecetteByUser(user);
        }

        /// <summary>
        /// Retourne une note totale sous forme html
        /// </summary>
        public static string GetNombrePersonneHtml(int nombre)
        {
            string html = "";

            string liBegin = "<li class='";
            string liEnd = "'></li>";

            string full = "spoon full";
            string empty = "spoon empty";

            for (int i = 0; i < nombre; i++)
                html += liBegin + full + liEnd;

            for (int i = 5; i > nombre; i--)
                html += liBegin + empty + liEnd;

            return html;
        }

        /// <summary>
        /// Retourne le temps total de confection pour une recette
        /// </summary>
        public static int GetTempsTotal(DBO.Recette recette)
        {
            return recette.TempsPreparation + recette.TempsCuisson + recette.TempsRepos;
        }

        /// <summary>
        /// Retourne la liste des difficultée
        /// </summary>
        public static ArrayList GetDifficulteList()
        {
            ArrayList items = new ArrayList();
            items.Add("Débutant");
            items.Add("Intermédiaire");
            items.Add("Expérimenté");
            items.Add("Expert");
            return items;
        }

        /// <summary>
        /// Retourne la liste des catégories
        /// </summary>
        public static ArrayList GetCategorieList()
        {
            ArrayList items = new ArrayList();
            items.Add("Déssert");
            items.Add("Entrée");
            return items;
        }
    }
}