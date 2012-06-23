using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    public static class Note
    {
        /// <summary>
        /// Création d'une note
        /// </summary>
        public static string NewNote(DBO.Note note)
        {
            try
            {
                using (CuisineEntities cuisineEntities = new CuisineEntities())
                {
                    cuisineEntities.T_Note.AddObject(ConvertToEntity(note));
                    cuisineEntities.SaveChanges();
                    return string.Empty;
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        /// <summary>
        /// Retourne la note d'un utilisateur pour une recette
        /// </summary>
        public static DBO.Note GetNoteByUserForRecette(DBO.User user, DBO.Recette recette)
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                T_Note note = cuisineEntities.T_Note.Where(e => e.idUser == user.Id && e.idRecette == recette.Id).SingleOrDefault();
                if (note == null)
                    return null;
                else
                    return ConvertToDBO(note);
            }
        }

        /// <summary>
        /// Retourne la liste des notes d'un utilisateur
        /// </summary>
        public static List<DBO.Note> GetNoteByUser(DBO.User user)
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                return ConvertToDBO(cuisineEntities.T_Note.Where(e => e.idUser == user.Id).ToList());
            }
        }

        /// <summary>
        /// Retourne la note totale de la recette
        /// </summary>
        public static int GetNoteTotaleByRecette(DBO.Recette recette)
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                return Convert.ToInt32(cuisineEntities.T_Note.Where(e => e.idRecette == recette.Id).Sum(e => e.note));
            }
        }

        /// <summary>
        /// Conversion DBO -> Entity
        /// </summary>
        public static T_Note ConvertToEntity(DBO.Note note)
        {
            T_Note entity = new T_Note();

            if (note != null)
            {
                entity.idRecette = note.idRecette;
                entity.idUser = note.idUser;
                entity.note = note.NoteRecette;
            }

            return entity;
        }

        /// <summary>
        /// Conversion Entity -> DBO
        /// </summary>
        public static DBO.Note ConvertToDBO(T_Note note)
        {
            DBO.Note dbo = new DBO.Note();

            if (note != null)
            {
                dbo.idUser = Convert.ToInt16(note.idUser);
                dbo.idRecette = Convert.ToInt16(note.idUser);
                dbo.NoteId = Convert.ToInt16(note.id);
                dbo.NoteRecette = Convert.ToInt16(note.note);
            }

            return dbo;
        }

        /// <summary>
        /// Conversion List Entity -> DBO
        /// </summary>
        public static List<DBO.Note> ConvertToDBO(List<T_Note> listNote)
        {
            List<DBO.Note> listDbo = new List<DBO.Note>();

            foreach (var item in listNote)
            {
                listDbo.Add(ConvertToDBO(item));
            }

            return listDbo;
        }
    }
}