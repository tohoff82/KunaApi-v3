﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using KunaApi.POCO.Requests;
using KunaApi.DTO.Answers;
using KunaApi.POCO;

namespace KunaApi.Services.Implements
{
    public class OrdersService : KunaHttp, IOrdersService
    {
        private readonly IModelbuilderService _builder;
        private readonly IOptionsService _options;

        public OrdersService(IModelbuilderService builder,
                             IOptionsService options) : base()
        {
            _builder = builder;
            _options = options;
        }

        public async Task<IEnumerable<Order>> GetActiveOrdersAsync(string marketMarker)
        {
            string[][] crudeOrders = await HttpPostAsync<string[][]>(
                        new ActiveOrdersRequest(marketMarker),
                       _options.PublicKey, _options.SecretKey);

            return _builder.CreateOrders(crudeOrders);
        }

        public async Task<IEnumerable<Order>> GetAllExecutedOrdersAsync(
            DateTime start, DateTime end, ushort limit, sbyte sort)
        {
            string[][] crudeOrders = await HttpPostAsync<string[][]>(
                        new ExecutedOrdersRequest(start, end, limit, sort),
                       _options.PublicKey, _options.SecretKey);

            return _builder.CreateOrders(crudeOrders);
        }

        public async Task<IEnumerable<Order>> GetExecutedOrdersAsync(string marketMarker,
            DateTime start, DateTime end, ushort limit, sbyte sort)
        {
            string[][] crudeOrders = await HttpPostAsync<string[][]>(
                        new ExecutedOrdersRequest(marketMarker, start, end, limit, sort),
                       _options.PublicKey, _options.SecretKey);

            return _builder.CreateOrders(crudeOrders);
        }
    }
}
