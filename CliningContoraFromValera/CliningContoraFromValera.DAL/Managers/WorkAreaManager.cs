﻿using Dapper;
using System.Data.SqlClient;
using CliningContoraFromValera.DAL.DTOs;
using CliningContoraFromValera.DAL.Managers.ManagersInterfaces;

namespace CliningContoraFromValera.DAL.Managers
{
    public class WorkAreaManager : IWorkAreaManager
    {
        public List<WorkAreaDTO> GetAllWorkAreas()
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                return connection.Query<WorkAreaDTO>(
                    StoredProcedures.WorkArea_GetAll,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
            }
        }

        public WorkAreaDTO GetWorkAreaByID(int workAreaId)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                return connection.QuerySingle<WorkAreaDTO>(
                    StoredProcedures.WorkArea_GetById,
                    param: new { id = workAreaId },
                    commandType: System.Data.CommandType.StoredProcedure
                    );
            }
        }

        public void AddWorkArea(WorkAreaDTO newWorkArea)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingle<WorkAreaDTO>(
                    StoredProcedures.WorkArea_Add,
                    param: new
                    { newWorkArea.Name},
                    commandType: System.Data.CommandType.StoredProcedure
                    );
            }
        }

        public void UpdateWorkAreaById(WorkAreaDTO newWorkArea)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingleOrDefault<WorkAreaDTO>(
                    StoredProcedures.WorkArea_UpdateById,
                    param: new
                    {
                        newWorkArea.Id,
                        newWorkArea.Name,
                    },
                    commandType: System.Data.CommandType.StoredProcedure
                    );
            }
        }

        public void DeleteWorkAreaById(int workAreaId)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingleOrDefault<WorkAreaDTO>(
                    StoredProcedures.WorkArea_DeleteById,
                    param: new { id = workAreaId },
                    commandType: System.Data.CommandType.StoredProcedure
                    );
            }
        }
    }
}
