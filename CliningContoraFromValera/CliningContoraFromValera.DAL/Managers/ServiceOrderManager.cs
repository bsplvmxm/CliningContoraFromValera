﻿using CliningContoraFromValera.DAL.Dtos;
using Dapper;
using System.Data.SqlClient;

namespace CliningContoraFromValera.DAL.Managers
{
    public class ServiceOrderManager
    {
        public void AddServiceFromOrder(int orderId, int serviceId, int count)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingleOrDefault<OrderDto>(
                    StoredProcedures.Service_Order_Add,
                    param: new { OrderId = orderId, ServiceId = serviceId, Count = count },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void DeleteServiceFromOrder(int orderId, int serviceId)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingleOrDefault<OrderDto>(
                    StoredProcedures.Service_Order_DeleteByValue,
                    param: new { OrderId = orderId, ServiceId = serviceId },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
