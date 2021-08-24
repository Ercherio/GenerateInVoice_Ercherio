using System;
using System.Collections.Generic;

namespace StringManipulationTask
{
    class Program
    {

        //Tugas String Manipulation
        //    1. FORMAT : INV/202108/TH/XIX/XXI/10983
        //    2. INV => STATIS
        //    3. 202108, 2021 Tahun sekarang; 08 Bulan sekarang, (agustus 8 => 08, december 12 => 12)
        //    4. TH, Hari THURSDAY, 2 Karakter TH
        //    5. XIX, 19 Tanggal Romawi
        //    6. XXI, 2021, tahun belakang 21 Romawi
        //    7. 10983, counter

        static void Main(string[] args)
        {
            int counter = 10982;
            Console.WriteLine(GenerateInVoice(counter)); 
        }

        static String GenerateInVoice(int c)
        {

            DateTime now = DateTime.Now;
            int day = now.Day;
            String month = now.Month.ToString().PadLeft(2,'0');     
            String year = now.Year.ToString();
            String dayName= now.DayOfWeek.ToString().ToUpper().Substring(0,2);
            int yearInt = Convert.ToInt32(year.Substring(2, 2));
          
            

            
            
            //Console.WriteLine(month);
            //localized version
            //System.DateTime.Now.ToString("dddd");
            
            return $"INV/{year}{month}/{dayName}/{GetRomawi(day)}/{GetRomawi(yearInt)}/{++c}";

        }
        
        static String GetRomawi(int number)
        {
            String chRoman;
            String romawis;
            var sb = new System.Text.StringBuilder();
            int resultDevide = 0;
            while (number != 0)
            {
                if (number >= 10)
                {
                    resultDevide = number / 10;
                    number %= 10;
                    switch (resultDevide)
                    {
                        case 1:
                            chRoman = "X";
                            sb.Append(chRoman);
                            break;
                         case 2:
                            chRoman = "XX";
                            sb.Append(chRoman);
                            break;
                        case 3:
                            chRoman = "XXX";
                            sb.Append(chRoman);
                            break;
                        default:
                            break;

                    }
                   
                    //GetRomawi(resultDevide);

                }
                else if (number == 9)
                {
                    number %= 9;
                    chRoman = "IX";
                    sb.Append(chRoman);
                }
                else if (number >= 5)
                {
                    //int resultdevide = number / 5;
                    number %= 5;
                    chRoman = "V";
                    sb.Append(chRoman);
                    //GetRomawi(resultDevide);
                }
                else
                {
                    switch (number)
                    {
                        case 1:
                            number %= 1;
                            chRoman = "I";
                            sb.Append(chRoman);
                            //GetRomawi(resultDevide);
                            break;
                        case 2:
                            number %= 2;
                            chRoman = "II";
                            sb.Append(chRoman);
                            //GetRomawi(resultDevide);
                            break;
                        case 3:
                            number %= 3;
                            chRoman = "III";
                            sb.Append(chRoman);
                            //GetRomawi(resultDevide);
                            break;
                        case 4:
                            number %= 2;
                            chRoman = "IV";
                            sb.Append(chRoman);
                            //GetRomawi(resultDevide);
                            break;
                        default:
                            break;
                    }
                }
            }
            //{
            //    if (number >= 10)
            //    {
            //        //resultDevide = number / 10;
            //        number %= 10;
            //        chRoman = "X";
            //        romawischRoman;
            //        //GetRomawi(resultDevide);

            //    }else if (number == 9)
            //    {
            //        number %= 9;
            //        chRoman = "IX";
            //        romawis.Add(chRoman);
            //    }
            //    else if (number >= 5)
            //    {
            //        //int resultdevide = number / 5;
            //        number %= 5;
            //        chRoman = "V";
            //        romawis.Add(chRoman);
            //        //GetRomawi(resultDevide);
            //    }
            //    else
            //    {
            //        switch (number)
            //        {
            //            case 1:
            //                number %= 1;
            //                chRoman = "I";
            //                romawis.Add(chRoman);
            //                //GetRomawi(resultDevide);
            //                break;
            //            case 2:
            //                number %= 2;
            //                chRoman = "II";
            //                romawis.Add(chRoman);
            //                //GetRomawi(resultDevide);
            //                break;
            //            case 3:
            //                number %= 3;
            //                chRoman = "III";
            //                romawis.Add(chRoman);
            //                //GetRomawi(resultDevide);
            //                break;
            //            case 4:
            //                number %= 2;
            //                chRoman = "IV";
            //                romawis.Add(chRoman);
            //                //GetRomawi(resultDevide);
            //                break;
            //            default:
            //                break;
            //        }
            //    }

            return romawis=sb.ToString();
            }
        //    int resultDevide = data / 10;

        //    if (resultDevide <= 5)
        //    {
        //        switch (resultDevide)
        //        {
        //            case 1:
        //                return roman = "I";
        //                break;
        //            case 2:
        //                return roman = "II";
        //                break;
        //            case 3:
        //                return roman = "III";
        //                break;
        //            case 4:
        //                return roman = "IX";
        //                break;
        //            default:
        //                break;
        //        }

        //        resultDevide /= 5;
        //    }
        //    else if (data > 5)
        //    {
                
        //    }
 //       }

    }


}
