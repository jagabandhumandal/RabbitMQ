﻿using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;

namespace MicroRabbit.MVC.Models.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;

        public TransferService(HttpClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task Transfer(TransferDTO transferDTO)
        {
            var url = "https://localhost:7283/api/banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDTO),
                System.Text.Encoding.UTF8,"application/json");
            var response = await _apiClient.PostAsync(url, transferContent);
            response.EnsureSuccessStatusCode();


        }
    }
}
