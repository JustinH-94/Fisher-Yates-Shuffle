using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace FisherYatesShuffleDemo
{
    class FisherYatesShuffle
    {
        //Created a string Array that will be latered shuffled.
        string[] cardDeck = {"A","2","3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
        //These values are for setting the values of the card for the high/low game
        int value = 0 , nextValue = 0;
        //randNum will be used to setting the randomizer of the deck
        Random randNum = new Random();
        public FisherYatesShuffle()
        {
            ShuffleDeck();
            HighLow();
            ClearPage();
        }

        int randomizNum(int i) { return randNum.Next(i); } //The function will return a value that is greater than 0 or last than the given value i (unless i is zero in which it will return 0)

        void ShuffleDeck()
        { //The for loop will randomize the the deck.
            for(int i = 0; i < cardDeck.Length; i++)
            {
                int j = randomizNum(i); //method randomizNum will take int i and store it into j
                shuffleArr(cardDeck, i, j); // method takes the array and int i and j to shuffle the deck
            }
        }
        void shuffleArr(string [] cardDeck, int i , int j)
        {
            string temp = cardDeck[i];//temporarily storing the value in i into temp
            cardDeck[i] = cardDeck[j];//taking the randomized value in cardDeck[j] and storing it into cardDeck[i], replacing it.
            cardDeck[j] = temp;//Then taking value of temp, formerly cardDeck[i] before getting replaced, and storing it into what is essentially the next value of the array. 
        }
            
        void HighLow()
        {
            for(int i = 0; i < cardDeck.Length-1; i++)
            {
                int j = i + 1;

                setValue(cardDeck, i, j);

                WriteLine(cardDeck[i]);
                WriteLine("Will the next card be high or low: ");
                string playAns = ReadLine().ToLower();
                WriteLine("\n\n" + cardDeck[j]);

                Result(playAns);
                ClearPage();
            }
        }

        void Result(string playAns)
        {

            if(playAns == "high")
            {
                if (value < nextValue)
                    WriteLine("Correct!");
                else
                    WriteLine("Incorrect :(");
            }
            else if(playAns == "low")
            {
                if (value > nextValue)
                    WriteLine("Correct!");
                else
                    WriteLine("Incorrect :(");
            }

        }

        void ClearPage()
        {
            WriteLine("Press Any Key To Continue");
            ReadKey(true);
            Clear();
        }

        void setValue(string [] carDeck, int i, int j)
        {
            if(carDeck[i] == "K")
                value = 13;
            if (carDeck[i] == "Q")
                value = 12;
            if (carDeck[i] == "J")
                value = 11;
            if (carDeck[i] == "10")
                value = 10;
            if (carDeck[i] == "9")
                value = 9;
            if (carDeck[i] == "8")
                value = 8;
            if (carDeck[i] == "7")
                value = 7;
            if (carDeck[i] == "6")
                value = 6;
            if (carDeck[i] == "5")
                value = 5;
            if (carDeck[i] == "4")
                value = 4;
            if (carDeck[i] == "3")
                value = 3;
            if (carDeck[i] == "2")
                value = 2;
            if (carDeck[i] == "1")
                value = 1;
            if (carDeck[i] == "A")
                value = 14;

            if (carDeck[j] == "K")
                nextValue = 13;
            if (carDeck[j] == "Q")
                nextValue = 12;
            if (carDeck[j] == "J")
                nextValue = 11;
            if (carDeck[j] == "10")
                nextValue = 10;
            if (carDeck[j] == "9")
                nextValue = 9;
            if (carDeck[j] == "8")
                nextValue = 8;
            if (carDeck[j] == "7")
                nextValue = 7;
            if (carDeck[j] == "6")
                nextValue = 6;
            if (carDeck[j] == "5")
                nextValue = 5;
            if (carDeck[j] == "4")
                nextValue = 4;
            if (carDeck[j] == "3")
                nextValue = 3;
            if (carDeck[j] == "2")
                nextValue = 2;
            if (carDeck[j] == "1")
                nextValue = 1;
            if (carDeck[j] == "A")
                nextValue = 14;
        }
    }
}
