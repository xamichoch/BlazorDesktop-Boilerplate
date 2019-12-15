using System;
using WebWindows.Blazor;

namespace BlazorLinux
{
    public class Program
    {
        static void Main(string[] args)
        {
            ComponentsDesktop.Run<Startup>("My Blazor App", "wwwroot/index.html");
        }
        
    }
        
}
