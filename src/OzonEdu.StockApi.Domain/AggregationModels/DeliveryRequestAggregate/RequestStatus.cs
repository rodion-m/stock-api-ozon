﻿using OzonEdu.StockApi.Domain.Models;

namespace OzonEdu.StockApi.Domain.AggregationModels.DeliveryRequestAggregate
{
    public class RequestStatus : Enumeration
    {
        public static RequestStatus InWork = new(1, "InWork");
        public static RequestStatus Done = new(2, "Done");

        public RequestStatus(int id, string name) : base(id, name)
        {
        }
    }
}