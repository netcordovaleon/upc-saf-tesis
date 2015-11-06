﻿namespace SAF.AccesoDatos.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using System.Data.EntityClient;
    using System.Data.EntityModel;
    using SAF.Entidad;
    public interface IUnitOfWork : IDisposable
    {
   
        /// <summary>
        /// Call this to commit the unit of work
        /// </summary>
        void Commit();

        /// <summary>
        /// Return the database reference for this UOW
        /// </summary>
        DbContext Db { get; }

        /// <summary>
        /// Starts a transaction on this unit of work
        /// </summary>
        void StartTransaction();

        SI_SOCAUDEntities DataContext();

    }
}
