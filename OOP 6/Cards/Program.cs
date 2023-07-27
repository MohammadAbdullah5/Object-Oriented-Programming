using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            bool gameRunning = true;
            Deck deck = new Deck();
            Card previous;
            Card next;
            Console.WriteLine("High-Low Game");
            do
            {
                deck.shuffle();
                previous = deck.dealCard();
                Console.WriteLine(previous.toString());
                Console.WriteLine("Predict the next Card(Up/Down): ");
                string nextCard = Console.ReadLine();
                next = deck.dealCard();
                Console.WriteLine(next.toString());
                if (nextCard == "Up")
                {
                    if (next.getValue() > previous.getValue())
                    {
                        score++;
                    }
                }

                else if (nextCard == "Down")
                {
                    if (next.getValue() < previous.getValue())
                    {
                        score++;
                    }
                }

                if (Keyboard.IsKeyPressed(Key.Escape))
                { 
                    gameRunning = false;
                }
                Console.Write("Score: " + score);
                Console.ReadKey();
            }
            while (gameRunning);
        }
    }
}
