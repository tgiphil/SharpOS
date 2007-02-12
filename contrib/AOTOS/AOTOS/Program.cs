/**
 *  (C) 2006-2007 Mircea-Cristian Racasan <darx_kies@gmx.net>
 * 
 *  Licensed under the terms of the GNU GPL License version 2.
 * 
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using SharpOS;
using SharpOS.AOT.IR;
using SharpOS.AOT.X86;

namespace SharpOS
{
    public class AOTOS
    {
        public static byte value = 1;

        public static string message = "test 123";

        static void Main(string[] args)
        {
            //try
            {
                Engine engine = new Engine();
                string filename = "SharpOS.dll";

                Console.WriteLine(message);

                float x = value + 0x12345678;

                if (args.Length == 1)
                {
                    filename = args[0];
                }
                else if (args.Length > 0)
                {
                    Console.WriteLine("Usage: AOTOS [filename]");
                    
                    return;
                }

                if (System.IO.File.Exists(filename) == false)
                {
                    Console.WriteLine("File '" + filename + "' was not found.");

                    return;
                }

                engine.Run(new Assembly(), filename, "SharpOS.bin");
            }
            //catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
