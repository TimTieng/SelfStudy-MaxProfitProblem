/*
Name: Tim Tieng
Date: October 21, 2020
Description: Weekly Whiteboard Challenge

Task: Say you have an array for which the ith element is the price of a given stock on day i.
 
If you were only permitted to complete at most one transaction (i.e., buy one and sell one share of the stock),
design a program to find the maximum profit.
 
*/

using System;

namespace Whiteboard_MaxStockProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            StockProfit();
        }
        public static void StockProfit()
        {
            //Prompt user of program purpose
            Console.WriteLine("This program takes stock prices provided by the user, and returns the max profit of when to buy and sell");

            //Since stock exchanges are only open on week days, prompt user to input 5 stock prices
            //Declare int[] to store prices
            double[] stockPrices = new double[5];
            for (int i = 0; i <stockPrices.Length; i++)//change iteration variables to reflect week
            {
                Console.Write("Please enter a stock price for day {0}: ", (i+1));
                stockPrices[i] = Convert.ToDouble(Console.ReadLine());
            }
            //Print stock prices to verfify proper input to the user
            Console.WriteLine("You entered the following prices: ");
            for (int i = 0; i <stockPrices.Length; i++)
            {
                Console.WriteLine("Day {0} stock is valued at {1} ", i+1, stockPrices[i]);
            }
 
            //Iterate and Evaluate = create a buy index and sell index value
            int buyIndex = 0;
            int sellIndex = buyIndex + 1; //Always starting one position ahead of buyindex since buy must occur first
            double maxProfit = 0;//initialize reassignment variable

            while (buyIndex < stockPrices.Length)//outer loop that focuses on buyIndex incrementation
            {
                for (sellIndex = buyIndex+1; sellIndex < stockPrices.Length; sellIndex++)//inner loop focusing on sellIndex incrementation
                {
                    if (stockPrices[sellIndex]-stockPrices[buyIndex] > 0 && stockPrices[sellIndex] - stockPrices[buyIndex] > maxProfit)
                    {
                        //reassign value of maxprofit based off difference at sell -buy indices
                        maxProfit = stockPrices[sellIndex] - stockPrices[buyIndex];
                    }
                }
                buyIndex++;//move buyIndex down the array
            }
            Console.WriteLine($"Your max profit is {maxProfit} dollars");
        }
    }
}
