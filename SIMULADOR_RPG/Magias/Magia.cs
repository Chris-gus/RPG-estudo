﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMULADOR_RPG.Magias
{
    internal class Magia
    {
        public string Nome { get; }
        public List<IEfeito> Efeitos { get; }

        public Magia(string nome, List<IEfeito> efeitos)
        {
            Nome = nome;
            Efeitos = efeitos;
        }

        public void Usar(Personagem alvo) 
        {
            foreach (var efeito in Efeitos) 
            {
                efeito.Aplicar(alvo);
            }

        }
    }
}
