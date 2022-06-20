using AutoMapper;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PLANTILLA_API_ODATA.DbContexts;
using PLANTILLA_API_ODATA.Models;
using PLANTILLA_API_ODATA.Models.DTO.Users;
using PLANTILLA_API_ODATA.Services.Helpers.Common;
using Spring.Objects.Factory.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PLANTILLA_API_ODATA.Services.Mesas
{
    public class OpeMesaService: IOpeMesaService
    {


        private DataContext db;
        public OpeMesaService(DataContext context)
        {
            db = context;
        }

        IQueryable<OpeMesa> IOpeMesaService.RetrieveAllMesas()
        {
            List<OpeMesa> _List = db.OpeMesas.ToList();
            IQueryable<OpeMesa> retrievedUsers = _List.AsQueryable();
            return retrievedUsers;
        }
    }
}
