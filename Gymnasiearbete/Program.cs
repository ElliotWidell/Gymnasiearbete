using System;
using Raylib_cs;


namespace Gymnasiearbete
{
    class Program
    {
        static void Main(string[] args)
        {

            string gameState = "waterLevel";
            


            Raylib.InitWindow(1200, 800, "GymnasieArbete");
            while (!Raylib.WindowShouldClose())
            {

                Raylib.BeginDrawing();
                Raylib.SetTargetFPS(60);

                while (gameState == "waterLevel")
                {


                    gameBoxes();

                    Console.ReadLine();
                    





                }

                Raylib.EndDrawing();



            }



            void gameBoxes()
            {


                Raylib.DrawRectangle(100,100,100,100, Color.BLACK);




            }
        }
    }
}
