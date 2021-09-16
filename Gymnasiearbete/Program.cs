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




            }



            void gameBoxes()
            {

                Raylib.ClearBackground(Color.BROWN);


                Raylib.DrawRectangle(0,0,450,1200, Color.BLUE);

                Raylib.EndDrawing();





            }
            
        }
    }
}
