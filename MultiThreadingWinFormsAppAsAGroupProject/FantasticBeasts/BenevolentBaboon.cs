/*****************************************************************
 * John Adkerson
 * Assignmnet06
 * 11/04/2020
 * adkersjv@mail.uc.edu
 * Contemporary Programming IT3045C
 * I chose my unique beast based off the google form sent out to the entire team
 * request was factored seuccessfully
 * ***************************************************************/
using System;
using System.Collections.Generic;

using System.Threading;


namespace MultiThreadingWinFormsAppAsAGroupProject
{
    /// <summary>
    /// A Fantastic Beast that will help us maintain a secure world
    /// </summary>
    class BenevolentBaboon : FantasticBeast
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello from " + this.GetType());
        }
        public override void RunThread()
        {
            msg = "Hello from BenevolentBaboon.RunThread()";
            Thread.Sleep(2000);
            long num = Convert.ToInt64(request);
            response = Convert.ToString(maxfactor(num));
        }

        static private long maxfactor(long request)
        {
            int potentialFactor = 2;
            while (potentialFactor * potentialFactor <= request)
            {
                if (request % potentialFactor == 0)
                {
                    request /= potentialFactor;
                }
                else
                {
                    ++potentialFactor;
                }
            }

            return request;
        }
    }

}

