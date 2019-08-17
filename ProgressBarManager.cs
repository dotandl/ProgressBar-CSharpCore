/*
 * ========================================
 * [---------ProgressBarManager.cs--------]
 * ========================================
 * Contains ProgressBarManager class with methods which can set and clear progress bars.
 * 
 * Created by andl on 17.08.2019
 * Last Modified by andl on 17.08.2019
 */

using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProgressBar
{
    /// <summary>
    /// Progress bar's management class
    /// </summary>
    public class ProgressBarManager
    {
        /// <summary>
        /// Variable showing state of progress indicator working
        /// </summary>
        private bool? progressIndicatorOn = null;

        #region ProgressBar
        /// <summary>
        /// Method displaying a progress bar
        /// </summary>
        /// <param name="percents">Percentage value which will be displayed</param>
        /// <param name="text">Text which will be displayed at the start of widget</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when percents' value is more than 100</exception>
        public static void SetProgressBar(byte percents, string text)
        {
            string progressIndicator = "[";

            if (percents > 100)
                throw new ArgumentOutOfRangeException("percents", "Cannot be more than 100 percents!");
            else if (percents == 0)
                progressIndicator += "--------------------";
            else if (percents >= 1 && percents <= 5)
                progressIndicator += "#-------------------";
            else if (percents >= 6 && percents <= 10)
                progressIndicator += "##------------------";
            else if (percents >= 11 && percents <= 15)
                progressIndicator += "###-----------------";
            else if (percents >= 16 && percents <= 20)
                progressIndicator += "####----------------";
            else if (percents >= 21 && percents <= 25)
                progressIndicator += "#####---------------";
            else if (percents >= 26 && percents <= 30)
                progressIndicator += "######--------------";
            else if (percents >= 31 && percents <= 35)
                progressIndicator += "#######-------------";
            else if (percents >= 36 && percents <= 40)
                progressIndicator += "########------------";
            else if (percents >= 41 && percents <= 45)
                progressIndicator += "#########-----------";
            else if (percents >= 46 && percents <= 50)
                progressIndicator += "##########----------";
            else if (percents >= 51 && percents <= 55)
                progressIndicator += "###########---------";
            else if (percents >= 56 && percents <= 60)
                progressIndicator += "############--------";
            else if (percents >= 61 && percents <= 65)
                progressIndicator += "#############-------";
            else if (percents >= 66 && percents <= 70)
                progressIndicator += "##############------";
            else if (percents >= 71 && percents <= 75)
                progressIndicator += "###############-----";
            else if (percents >= 76 && percents <= 80)
                progressIndicator += "################----";
            else if (percents >= 81 && percents <= 85)
                progressIndicator += "#################---";
            else if (percents >= 86 && percents <= 90)
                progressIndicator += "##################--";
            else if (percents >= 91 && percents <= 95)
                progressIndicator += "###################-";
            else if (percents >= 96 && percents <= 100)
                progressIndicator += "####################";

            progressIndicator += "]";

            string progressBar = text + " " + percents.ToString() + "% " + progressIndicator;
            int top = Console.CursorTop, left = Console.CursorLeft;
            ConsoleColor background = Console.BackgroundColor, foreground = Console.ForegroundColor;

            int startPosition = (Console.WindowWidth - progressBar.Length) / 2;
            bool parity = (Console.WindowWidth - progressBar.Length) % 2 == 0;
            string finalProgressBar = string.Format("{0}{1}{2}",
                new string(' ', startPosition + (parity ? 0 : 1)),
                progressBar,
                new string(' ', startPosition));

            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write(finalProgressBar);

            Console.CursorTop = top;
            Console.CursorLeft = left;
            Console.BackgroundColor = background;
            Console.ForegroundColor = foreground;
        }

        /// <summary>
        /// Method displaying a progress bar with additional text
        /// </summary>
        /// <param name="percents">Percentage value which will be displayed</param>
        /// <param name="text">Text which will be displayed at the start of widget</param>
        /// <param name="additionalText">Text which will be displayed in brackets as additional information</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when percents' value is more than 100</exception>
        public static void SetProgressBar(byte percents, string text, string additionalText)
        {
            string progressIndicator = "[";

            if (percents > 100)
                throw new ArgumentOutOfRangeException("percents", "Cannot be more than 100 percents!");
            else if (percents == 0)
                progressIndicator += "--------------------";
            else if (percents >= 1 && percents <= 5)
                progressIndicator += "#-------------------";
            else if (percents >= 6 && percents <= 10)
                progressIndicator += "##------------------";
            else if (percents >= 11 && percents <= 15)
                progressIndicator += "###-----------------";
            else if (percents >= 16 && percents <= 20)
                progressIndicator += "####----------------";
            else if (percents >= 21 && percents <= 25)
                progressIndicator += "#####---------------";
            else if (percents >= 26 && percents <= 30)
                progressIndicator += "######--------------";
            else if (percents >= 31 && percents <= 35)
                progressIndicator += "#######-------------";
            else if (percents >= 36 && percents <= 40)
                progressIndicator += "########------------";
            else if (percents >= 41 && percents <= 45)
                progressIndicator += "#########-----------";
            else if (percents >= 46 && percents <= 50)
                progressIndicator += "##########----------";
            else if (percents >= 51 && percents <= 55)
                progressIndicator += "###########---------";
            else if (percents >= 56 && percents <= 60)
                progressIndicator += "############--------";
            else if (percents >= 61 && percents <= 65)
                progressIndicator += "#############-------";
            else if (percents >= 66 && percents <= 70)
                progressIndicator += "##############------";
            else if (percents >= 71 && percents <= 75)
                progressIndicator += "###############-----";
            else if (percents >= 76 && percents <= 80)
                progressIndicator += "################----";
            else if (percents >= 81 && percents <= 85)
                progressIndicator += "#################---";
            else if (percents >= 86 && percents <= 90)
                progressIndicator += "##################--";
            else if (percents >= 91 && percents <= 95)
                progressIndicator += "###################-";
            else if (percents >= 96 && percents <= 100)
                progressIndicator += "####################";

            progressIndicator += "]";

            string progressBar = text + " " + percents.ToString() + "% " + progressIndicator + " (" + additionalText + ")";
            int top = Console.CursorTop, left = Console.CursorLeft;
            ConsoleColor background = Console.BackgroundColor, foreground = Console.ForegroundColor;

            int startPosition = (Console.WindowWidth - progressBar.Length) / 2;
            bool parity = (Console.WindowWidth - progressBar.Length) % 2 == 0;
            string finalProgressBar = string.Format("{0}{1}{2}",
                new string(' ', startPosition + (parity ? 0 : 1)),
                progressBar,
                new string(' ', startPosition));

            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write(finalProgressBar);

            Console.CursorTop = top;
            Console.CursorLeft = left;
            Console.BackgroundColor = background;
            Console.ForegroundColor = foreground;
        }

        /// <summary>
        /// Method clearing a progress bar
        /// </summary>
        public static void ClearProgressBar()
        {
            int top = Console.CursorTop, left = Console.CursorLeft;

            Console.CursorTop = 0;
            Console.CursorLeft = 0;

            Console.Write(new string(' ', Console.WindowWidth));

            Console.CursorTop = top;
            Console.CursorLeft = left;
        }
        #endregion

        #region ProgressIndicator
        /// <summary>
        /// Method displaying a progress indicator
        /// </summary>
        /// <param name="text">Text which will be displayed at the start of widget</param>
        /// <returns>Object of Task class for asynchronious working</returns>
        public Task SetProgressIndicator(string text)
        {
            progressIndicatorOn = true;

            return Task.Run(() =>
            {
                for (;;)
                {
                    if (progressIndicatorOn == false)
                    {
                        progressIndicatorOn = null;
                        break;
                    }

                    for (byte i = 0; i < 4; i++)
                    {
                        if (progressIndicatorOn == false)
                            break;

                        char c = ' ';

                        switch (i)
                        {
                            case 0:
                                c = '-';
                                break;
                            case 1:
                                c = '\\';
                                break;
                            case 2:
                                c = '|';
                                break;
                            case 3:
                                c = '/';
                                break;
                        }

                        string progressBar = text + " [" + c + "]";
                        int top = Console.CursorTop, left = Console.CursorLeft;
                        ConsoleColor background = Console.BackgroundColor, foreground = Console.ForegroundColor;

                        int startPosition = (Console.WindowWidth - progressBar.Length) / 2;
                        bool parity = (Console.WindowWidth - progressBar.Length) % 2 == 0;

                        string finalProgressBar = string.Format("{0}{1}{2}",
                            new string(' ', startPosition + (parity ? 0 : 1)),
                            progressBar,
                            new string(' ', startPosition));

                        Console.CursorTop = 0;
                        Console.CursorLeft = 0;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Write(finalProgressBar);


                        Console.CursorTop = top;
                        Console.CursorLeft = left;
                        Console.BackgroundColor = background;
                        Console.ForegroundColor = foreground;

                        Thread.Sleep(250);
                    }
                }
            });
        }

        /// <summary>
        /// Method displaying a progress indicator with additional text
        /// </summary>
        /// <param name="text">Text which will be displayed at the start of widget</param>
        /// <param name="additionalText">Text which will be displayed in brackets as additional information</param>
        /// <returns>Object of Task class for asynchronious working</returns>
        public Task SetProgressIndicator(string text, string additionalText)
        {
            progressIndicatorOn = true;

            return Task.Run(() =>
            {
                for (;;)
                {
                    if (progressIndicatorOn == false)
                    {
                        progressIndicatorOn = null;
                        break;
                    }

                    for (byte i = 0; i < 4; i++)
                    {
                        if (progressIndicatorOn == false)
                            break;

                        char c = ' ';

                        switch (i)
                        {
                            case 0:
                                c = '-';
                                break;
                            case 1:
                                c = '\\';
                                break;
                            case 2:
                                c = '|';
                                break;
                            case 3:
                                c = '/';
                                break;
                        }

                        string progressBar = text + " [" + c + "] (" + additionalText + ")";
                        int top = Console.CursorTop, left = Console.CursorLeft;
                        ConsoleColor background = Console.BackgroundColor, foreground = Console.ForegroundColor;

                        int startPosition = (Console.WindowWidth - progressBar.Length) / 2;
                        bool parity = (Console.WindowWidth - progressBar.Length) % 2 == 0;

                        string finalProgressBar = string.Format("{0}{1}{2}",
                            new string(' ', startPosition + (parity ? 0 : 1)),
                            progressBar,
                            new string(' ', startPosition));

                        Console.CursorTop = 0;
                        Console.CursorLeft = 0;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.Write(finalProgressBar);


                        Console.CursorTop = top;
                        Console.CursorLeft = left;
                        Console.BackgroundColor = background;
                        Console.ForegroundColor = foreground;

                        Thread.Sleep(250);
                    }
                }
            });
        }

        /// <summary>
        /// Method updating text on progress indicator
        /// </summary>
        /// <param name="text">Text which will be displayed at the start of widget</param>
        /// <returns>Object of Task class for asynchronious working</returns>
        public Task UpdateProgressIndicator(string text)
        {
            ClearProgressIndicator();
            Thread.Sleep(100);
            return Task.Run(() => SetProgressIndicator(text));
        }

        /// <summary>
        /// Method updating text and additional text on progress indicator
        /// </summary>
        /// <param name="text">Text which will be displayed at the start of widget</param>
        /// <param name="additionalText">Text which will be displayed in brackets as additional information</param>
        /// <returns>Object of Task class for asynchronious working</returns>
        public Task UpdateProgressIndicator(string text, string additionalText)
        {
            ClearProgressIndicator();
            Thread.Sleep(100);
            return Task.Run(() => SetProgressIndicator(text, additionalText));
        }

        /// <summary>
        /// Method clearing a progress indicator
        /// </summary>
        public void ClearProgressIndicator()
        {
            progressIndicatorOn = false;

            int top = Console.CursorTop, left = Console.CursorLeft;

            Console.CursorTop = 0;
            Console.CursorLeft = 0;

            Console.Write(new string(' ', Console.WindowWidth));

            Console.CursorTop = top;
            Console.CursorLeft = left;
        }
        #endregion
    }
}