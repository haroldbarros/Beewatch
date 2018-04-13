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


        public async Task Backward5()
        {
            Console.WriteLine("Backward5");
            await Clients.All.SendAsync("SendBackward5");
        }

        public async Task Backward10()
        {
            Console.WriteLine("Backward10");
            await Clients.All.SendAsync("SendBackward10");
        }


        public async Task Forward5()
        {
            Console.WriteLine("Forward5");
            await Clients.All.SendAsync("SendForward5");
        }

        public async Task Forward10()
        {
            Console.WriteLine("Forward10");
            await Clients.All.SendAsync("SendForward10");
        }



    }
}