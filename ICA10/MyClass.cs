﻿/*
 * Name: Kevin George
 * Teac: Prof. Gordon
 * Clas: CST-135 900A
 * Date: Nov 10, 2018
 */
using System;
using System.IO;
using System.Collections.Generic;
namespace ICA10
{
    public class MyClass
    {
        void CheckText(string[] tOrE)       //class to perform the counting of words that have t or e as the last letter
        {

            int count = 0;          //integer to count how many words have e or t at the end
            for (int i = 0; i < tOrE.Length; i++)   //for each word in the array
            {
                String tempWord = tOrE[i];      //temporary word each time the loop comes back
                if (tempWord[tempWord.Length - 1] == 't' || tempWord[tempWord.Length - 1] == 'e')       //does the last word have t or e?
                {
                    count++;        //increment count?
                }
            }
            Console.WriteLine("There are " + count + " words that end in t or e.");         //print result
        }

        public static void Main(string[] args)
        {
            MyClass words = new MyClass();      //new type created to call the method
            String input = System.IO.File.ReadAllText(@"/home/kevin/Kevin/school/CST117/workspace/ICA10/txt.txt");  //read in the file
            string[] strArray;      //array created to store string
            strArray = input.Split(' ');        //stringArray indices filled with string and cut off at space delimeter
            words.CheckText(strArray);      //pass the array into the method
        }
    }
}