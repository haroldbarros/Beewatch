using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace Beewatch.Hubs
{
      public class VideoPlayerHub : Hub
    {

        public override async Task OnConnectedAsync()
        {
             Console.WriteLine("OnConnectedAsync");
            //await Clients.All.SendAsync("SendAction", "User joined");
        }

        public override async Task OnDisconnectedAsync(Exception ex)
        {
             Console.WriteLine("OnDisconnectedAsync");
            //await Clients.All.SendAsync("SendAction", Context.User.Identity.Name, "User left");
        }

        public async Task loadVideoById(string mediaContentID,string startSeconds)
        { 
            Console.WriteLine("loadVideoById");
            Console.WriteLine("mediaContentID:"+mediaContentID);
            Console.WriteLine("startSeconds:"+startSeconds);
            await Clients.All.SendAsync("SendloadVideoById",mediaContentID,startSeconds);
        }

        public async Task seekTo(string seconds)
        {
            Console.WriteLine("seekTo");
            Console.WriteLine("seconds:"+seconds);
            await Clients.All.SendAsync("SendseekTo",seconds );
        }

        public async Task playVideo()
        {
            Console.WriteLine("playVideo");
            await Clients.All.SendAsync("SendplayVideo");
        }

        public async Task pauseVideo()
        {
            Console.WriteLine("pauseVideo");
            await Clients.All.SendAsync("SendpauseVideo");
        }

        public async Task stopVideo()
        {
            Console.WriteLine("stopVideo");
            await Clients.All.SendAsync("SendstopVideo");
        }

        public async Task mute()
        {
            Console.WriteLine("mute");
            await Clients.All.SendAsync("Sendmute");
        }        

        public async Task unMute()
        {
            Console.WriteLine("unMute");
            await Clients.All.SendAsync("SendunMute");
        }

    }
}