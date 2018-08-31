using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace video_locadora
{
    public class Filmes
    {

        public int CODIGO;
        public string TITULO;
        public string GENERO;
        public string CLASSIFICACAO;
        public string CATEGORIA;
        public string TIPO_MIDIA;
        public string STATUS;


        public Filmes(int COD, string TIT, string GEN, string CLA, string TIP, string CAT, string STA)
        {
            this.CODIGO = COD;
            this.TITULO = TIT;
            this.GENERO = GEN;
            this.CLASSIFICACAO = CLA;
            this.CATEGORIA = CAT;
            this.TIPO_MIDIA = TIP;
            this.STATUS = STA;        
        }



    }
}
