﻿using CliningContoraFromValera.DAL;

namespace CliningContoraFromValera.Bll.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Dictionary<int, ServiceDTO>? Services { get; set; }
        public Dictionary<int, WorkAreaDTO>? WorkAreas { get; set; }
        public Dictionary<int, OrderDTO>? Orders { get; set; }
        public WorkTimeDTO? WorkTime { get; set; }
    }
}
