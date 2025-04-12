﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMULADOR_RPG
{
    public class Mago : Personagem
    {
        public Mago(string nome) : base(nome)
        {
            VidaTotal = 85;
            Vida=VidaTotal;
            ForcaBase = 20;
            ArmaEquipada = Arsenal.Cajado;
            Forca= ForcaBase + ArmaEquipada.BonusForca;
        }
        public override void Atacar(Personagem inimigo)
        {
            double dano = (0.5 + rand.NextDouble() * 1.0) * Forca;
            inimigo.ReceberDano(dano);
            MostrarDano(dano,inimigo);
            Console.ReadKey();

        }
    }
}
