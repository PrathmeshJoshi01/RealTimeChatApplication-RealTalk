﻿using Microsoft.AspNetCore.SignalR;

namespace MyChatApplication.Hubs
{
    public class ConnectedHub : Hub
    {

        public override Task OnConnectedAsync()
        {
            ConnectedUser.myConnectedUsers.Add(Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            ConnectedUser.myConnectedUsers.Remove(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);

        }
        public async Task SendMessage(string user, string message) 
        {
            if (string.IsNullOrEmpty(user))
                await Clients.All.SendAsync("ReceiveMessage", user, message);
            else
                await Clients.Client(user).SendAsync("ReceiveMessage", user, message);
        }
    }
}
