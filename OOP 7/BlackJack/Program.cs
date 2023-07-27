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
            bool game = true;
            while (game == true)
            {
                bool gameRunning = true;
                Deck deck = new Deck();
                Card playerCard;
                Card dealerCard;
                BlackJack player = new BlackJack();
                BlackJack dealer = new BlackJack();

                Console.WriteLine("Black Jack Game");

                deck.shuffle();

                Console.WriteLine("Dealer's first card is :-");
                dealerCard = deck.dealCard();
                Console.WriteLine(dealerCard.toString());
                dealer.addCard(dealerCard);
                dealerCard = deck.dealCard();
                dealer.addCard(dealerCard);

                Console.WriteLine("Your first two cards are :-");
                playerCard = deck.dealCard();
                Console.WriteLine(playerCard.toString());
                player.addCard(playerCard);
                playerCard = deck.dealCard();
                player.addCard(playerCard);
                Console.WriteLine(playerCard.toString());

                if (dealer.getJetBlackValue() == 21)
                {
                    Console.WriteLine("Dealer have BLACKJACK");
                }

                do
                {
                    if (player.getJetBlackValue() > 21)
                    {
                        Console.WriteLine("YOU ARE BUSTED !!!!");
                        gameRunning = false;
                    }

                    if (player.getJetBlackValue() == 21 && player.getCardsCount() == 2)
                    {
                        Console.WriteLine("BLACKJACK !!!!!");
                        gameRunning = false;
                    }

                    if (player.getJetBlackValue() == 21 && player.getCardsCount() == 2 && dealer.getJetBlackValue() == 21)
                    {
                        Console.WriteLine("TIE !!!");
                        gameRunning = false;
                    }

                    if (player.getJetBlackValue() == 21)
                    {
                        Console.WriteLine("YOU WON !!!");
                        gameRunning = false;
                    }

                    deck.shuffle();
                    Console.WriteLine("Do you want to HIT or STAND: ");
                    string user = Console.ReadLine();

                    if (user == "HIT")
                    {
                        playerCard = deck.dealCard();
                        Console.WriteLine("New Card: " + playerCard.toString());
                        player.addCard(playerCard);
                    }

                    if (user == "STAND")
                    {
                        while (dealer.getJetBlackValue() <= 17)
                        {
                            dealerCard = deck.dealCard();
                            dealer.addCard(dealerCard);
                        }

                        if(dealer.getJetBlackValue() > 21)
                        {
                            Console.WriteLine("Dealer BUSTED !!!");
                        }

                        else if(dealer.getJetBlackValue() >= 17 && dealer.getJetBlackValue() < 21)
                        {
                            if (dealer.getJetBlackValue() > player.getJetBlackValue())
                            {
                                Console.WriteLine("DEALER WON !!!");
                            }

                            else if(dealer.getJetBlackValue() < player.getJetBlackValue())
                            {
                                Console.WriteLine("PLAYER WON !!!");
                            }
                        }

                        else if(dealer.getJetBlackValue() >= 17 && dealer.getJetBlackValue() < 21)
                        {
                            if(dealer.getJetBlackValue() == player.getJetBlackValue())
                            {
                                Console.WriteLine("TIE !!!");
                            }
                        }

                        else if(dealer.getJetBlackValue() == 21)
                        {
                            Console.WriteLine("DEALER WON !!!");
                        }

                        else if (player.getJetBlackValue() == 21)
                        {
                            Console.WriteLine("PLAYER WON !!!");
                        }

                        gameRunning = false;
                    }

                    if (Keyboard.IsKeyPressed(Key.Escape))
                    {
                        gameRunning = false;
                    }
                    Console.ReadKey();
                }
                while (gameRunning);

                Console.Write("Wanna play again(Y/N): ");

                if(Console.ReadLine() == "N")
                {
                    game = false;
                }

                Console.ReadKey();
            }
        }
    }
}
