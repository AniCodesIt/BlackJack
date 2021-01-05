using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackGameRepo;

namespace BlackJackGame
{
    class BlackJackGameUI
    {
        GameRepo repoWindow = new GameRepo();
        public void RunMenu()
        {
            int dealtCard = repoWindow.DealACard();
            repoWindow.AssignToDealerHand(dealtCard);
            dealtCard = repoWindow.DealACard();
            repoWindow.AssignToPlayerHand(dealtCard);
            dealtCard = repoWindow.DealACard();
            repoWindow.AssignToDealerHand(dealtCard);
            dealtCard = repoWindow.DealACard();
            repoWindow.AssignToPlayerHand(dealtCard);

            List<int> dealer = repoWindow.DisplayDealerHand();
            List<int> player = repoWindow.DisplayPlayerHand();
            bool firstTime = true;
            foreach (int card in dealer)
            {
                if (firstTime == true)
                {
                    Console.WriteLine("X");
                }
                else
                {
                    Console.WriteLine(card);
                }

            }
            foreach (int card in player)
            {
                Console.WriteLine(card);
            }




            bool isRunning = true;
            while (isRunning)
            {

                Console.ReadLine();
                Console.Clear();
            }
        }
