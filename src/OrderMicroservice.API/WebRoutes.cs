﻿namespace OrderMicroservice.API
{
    public static class WebRoutes
    {
        public const string BasePath = "api/orders";
        public const string Create = BasePath + "/create";
        public const string GetById = BasePath + "/{id}";
        public const string Cancel = BasePath + "/{id}/cancel";
        public const string GetByFilter = BasePath + "/by-filter";
        public const string GetStatusById = BasePath + "/{id}/status";
    }
}
