﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //for(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;
            //for (i=1; i<=5 ; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}


            //for (int i = 0; i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 3; i<=50 ; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen Ekrana Yazılmasını İstediğiniz Sayıyı Giriniz: ");
            //int finishvalue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishvalue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü İle Karar Yapıları

            //for (int i = 0; i <= 100 ; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;
            //for (int i = 1; i<= 10; i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("-------------------");
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 1; i <= 50 ; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        totalValue++;
            //    }

            //}
            //Console.WriteLine(totalValue);



            //1-2-4-8-16 -.........

            //int bakteri = 1;

            //for (int i = 1; i <=24 ; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i + ".saat Sonunda: " + bakteri);
            //}

            #endregion

            #region While Döngüsü

            //while(şart)
            //{
            //işlemler
            //}
            //int i = 1; 
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);



            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakalrı toplamını hesaplayan kodu yazınız.

            // 456
            Console.Write("Sayıyı Giriniz: ");
            int number = int.Parse(Console.ReadLine());

            int ones, tens, hundred;
            int sum;
            ones = number % 10;
            tens = (number % 100) / 10;
            hundred = number / 100; //4.56 --> 4
            sum = ones + tens + hundred;

            Console.WriteLine(ones + "-" + tens+"-" + hundred);
       Console.WriteLine(sum);

            
            #endregion
            Console.Read();

        }
    }
}
