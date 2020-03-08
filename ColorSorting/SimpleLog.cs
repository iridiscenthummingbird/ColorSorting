using System;
using System.Diagnostics;
using System.IO;

namespace ColorSorting
{
	class SimpleLog
	{
		private static Stopwatch GlobalSW;
		private static Stopwatch stopwatch;

		private static String path;
		private static StreamWriter logOut;

		static SimpleLog()
		{
			stopwatch = new Stopwatch();
			path = "logs\\log.txt";
		}

		public static void newSession()
		{
			if (!Directory.Exists("logs"))
			{
				Directory.CreateDirectory("logs");
			}
			logOut = new StreamWriter(path, false);
			logOut.WriteLine("Start time: " + DateTime.Now.ToString() + '\n');

			GlobalSW = new Stopwatch();
			GlobalSW.Start();
		}

		public static void endSession()
		{
			GlobalSW.Stop();

			logOut.WriteLine("\nRuntime: " + GlobalSW.Elapsed.ToString());
			logOut.Dispose();
		}

		public static void SWatch_start(String info)
		{
			stopwatch.Restart();

			logOut.WriteLine(GlobalSW.Elapsed.ToString() + "\n\t" + info);
		}

		public static void SWatch_stop(String cause = "")
		{
			stopwatch.Stop();
				String elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", stopwatch.Elapsed.Hours,
																				  stopwatch.Elapsed.Minutes,
																				  stopwatch.Elapsed.Seconds,
																				  stopwatch.Elapsed.Milliseconds);

				if(cause.Length == 0) 
				{
					logOut.WriteLine("\tDone in " + elapsedTime);
				}
				else
				{
					logOut.WriteLine("\tError: " + cause);
				}
		}
	}
}
