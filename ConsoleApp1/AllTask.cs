﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AllTask
    {
        public static void Main(String[] args)
        {
            int NumberTask;
            do
            {
                NumberTask = int.Parse(Console.In.ReadLine());
                switch (NumberTask)
                {
                    case 1:
                        Task01.HelloWorld.main(); break;
                    case 2:
                        Task02.BinToInt.main(); break;
                    case 3:
                        Task03.Table.main(); break;
                    case 4:
                        Task04.Calc.main(); break;
                    case 5:
                        Task05.Const.main(); break;
                    case 6:
                        Task06.CicleNumber.main(); break;
                    case 7:
                        Task07.Massiv.main(); break;
                    case 8:
                        Task08.Matrix.main(); break;
                    case 9:
                        Task09.InputString.main(); break;
                    case 10:
                        Task10.DelitSpace.main(); break;
                    case 11:
                        Task11.EqString.main(); break;
                    case 12:
                        Task12.ConvertType.main(); break;
                    case 13:
                        Task13.SortBuble.main(); break;
                    case 14:
                        Task14.PrintFile.main(); break;
                    case 15:
                        Task15.SaveTXTFile.main(); break;
                    case 16:
                        Task16.Prov.main(); break;
                    case 17:
                        Calc.main(); break;
                    case 18:
                        Task3_1.main(); break;
                    case 19:
                        MainNew.main(); break;
                    case 20:
                        MainCalc.main(); break;
                    case 21:
                        MainTask.main(); break;
                    default: break;
                }

            } while (NumberTask != 0);
        }
            
            /*FinaleTask01.Bin_To_Int.main();
            FinaleTask02.SortMass.main();
            FinaleTask03.ConvertrValute.main();*/
        }

    }