﻿using System;
using System.Collections.Generic;

namespace Bolao.Cup.Domain.Entities
{
    public class Campeonato
    {
        public int cod_campeonato { get; set; }

        public string nom_campeonato { get; set; }

        public DateTime ini_campeonato { get; set; }

        public DateTime fim_campeonato { get; set; }

        public string sit_campeonato { get; set; }

        public ICollection<Rodada> Rodada { get; set; }

        public Pontuacao Pontuacao { get; set; }
    }
}
