using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.DataAccessLayer.Conctrete;

namespace SignalRApi.Hubs
{
    public class SignalRHub:Hub
    {
        SignalRContext contex = new SignalRContext();

        public async Task SendCategoryCount()
        {
            var value = contex.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        }
  

    }
}
