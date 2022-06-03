﻿namespace CliningContoraFromValera.DAL.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EstimatedEndTime { get; set; }
        public TimeSpan? FinishTime { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public int CountOfEmployees { get; set; }
        public bool IsCommercial { get; set; }
        public int ClientId { get; set; }
        public int AddressId { get; set; }
        public ClientDto? Client { get; set; }
        public AddressDto? Address { get; set; }
        public List<ServiceDto>? Services { get; set; }


        public override string ToString()
        {
            return $"Id={Id} Date={Date} StartTime={StartTime} EstimatedEndTime={EstimatedEndTime} EndTime={FinishTime}" +
                $"SummOfOrder={Price} Status={Status} CountOfEmployees={CountOfEmployees} IsCommercial={IsCommercial}" +
                $"CliendId={ClientId} AddressId={AddressId}";
        }
    }
}
