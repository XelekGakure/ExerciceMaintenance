﻿using System;
using CentralTrainDB;

namespace EnregistrementVoyageur
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Bienvunu sur l'inregistrement voyageur !");

            Console.WriteLine("Quel est votre login ?");
            var login = Console.ReadLine();

            var user = UserProvider.Register(login);

            Console.WriteLine($"Merci vous êtes inscrit {user}");
        }
    }
}
