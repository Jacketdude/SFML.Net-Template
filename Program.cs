using SFML;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace sfmlnet
{
    static class Program
    {
        static void Main(string[] args)
        {
            const int WIDTH = 900;
            const int HEIGHT = 600;

            RenderWindow app = new RenderWindow(new VideoMode(WIDTH, HEIGHT), "SFML.Net Window");
            app.Closed += (sender, e) => app.Close();

            while (app.IsOpen)
            {
                app.DispatchEvents();
                app.Clear(Color.Cyan);
                app.Display();
            }
        }
    }
}