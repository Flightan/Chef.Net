﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    /// <summary>
    /// Class pour gérer les utilisateurs
    /// </summary>
    public static class User
    {
        private static CuisineEntities cuisineEntities = new CuisineEntities();

        /// <summary>
        /// Création d'un utilisateur
        /// </summary>
        public static bool NewUser(DBO.User user)
        {
            try
            {
                cuisineEntities.AddToT_User(ConvertToEntity(user));
                cuisineEntities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Retourne l'utilisateur qui possède ce nom
        /// </summary>
        public static DBO.User GetUserByName(string name)
        {
            return ConvertToDBO(cuisineEntities.T_User.SingleOrDefault(e => e.nom == name));
        }

        /// <summary>
        /// Retourne l'utilisateur qui possède cet id
        /// </summary>
        public static DBO.User GetUserById(int id)
        {
            return ConvertToDBO(cuisineEntities.T_User.SingleOrDefault(e => e.id == id));
        }

        /// <summary>
        /// Retourne true si le pseudo et le mot de passe sont valide
        /// </summary>
        public static bool IsValid(DBO.User user)
        {
            DBO.User tableUser = GetUserByName(user.Name);
            if (tableUser != null)
                return (tableUser.Password == user.Password);
            else
                return false;
        }

        /// <summary>
        /// Change le mot de passe de l'utilisateur
        /// </summary>
        public static bool ChangePassword(DBO.User user, string newPassword)
        {
            try
            {
                T_User t_user = cuisineEntities.T_User.SingleOrDefault(e => e.nom == user.Name);
                t_user.password = newPassword;
                cuisineEntities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Conversion DBO -> Entity
        /// </summary>
        public static T_User ConvertToEntity(DBO.User user)
        {
            T_User entity = new T_User();

            if (user != null)
            {
                entity.info = user.Info;
                entity.nom = user.Name;
                entity.password = user.Password;
                entity.email = user.Email;
            }

            return entity;
        }

        /// <summary>
        /// Conversion Entity -> DBO
        /// </summary>
        public static DBO.User ConvertToDBO(T_User user)
        {
            DBO.User dbo = new DBO.User();

            if (user != null)
            {
                dbo.Info = user.info;
                dbo.Name = user.nom;
                dbo.Password = user.password;
                dbo.Email = user.email;
            }

            return dbo;
        }
    }
}