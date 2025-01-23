﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.CategoryDtos;
using System.Net.Http;

namespace SignalRWebUI.ViewComponents.MenuComponents
{
    public class _MenuCategoryFilterPartialComponent:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _MenuCategoryFilterPartialComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task< IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7242/api/Category/");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
            return View(values);
            
        }
    }
}
