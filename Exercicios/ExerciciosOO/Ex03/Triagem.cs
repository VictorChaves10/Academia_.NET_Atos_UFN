using System;

namespace ConsoleApp1
{
    internal class Triagem
    {
        //public string[] unidadeSaude = new string[4];



        
        private double _altura;
        private int _pressaoSistolica;
        private int _pressaoDiastolica;
        private double _temperatura;
        private int _nivelUrgencia = 0;
        private int _pesoKg;


        public Triagem()
        {

        }

        //public void UnidadesDeSaude()
        //{
        //    unidadeSaude[0] = "UPA Londrina - Zona Norte";
        //    unidadeSaude[1] = "UPA Londrina - Zona Oeste";
        //    unidadeSaude[2] = "UPA Londrina - Zona Leste";
        //    unidadeSaude[3] = "UPA Londrina - Zona Sul";

        //}

        public int Peso
        {
            get { return _pesoKg; }
            set
            {
                if (value != 0)
                {
                    _pesoKg = value;
                }


            }
        }

        public double Altura
        {
            get { return _altura; }
            set
            {
                if (value > 0.0)
                {
                    _altura = value;
                }
            }
        }

        public int PressaoSistolica
        {
            get { return _pressaoSistolica; }
            set
            {
                if (value >= 120)
                {
                    _pressaoSistolica = value;
                }
            }
        }

        public int PressaoDiastolica
        {
            get { return _pressaoDiastolica; }
            set
            {
                if (value >= 120)
                {
                    _pressaoDiastolica = value;
                }
            }
        }

        public double Temperatura
        {
            get { return _temperatura; }
            set
            {
                if (value > 34)
                {
                    _temperatura = value;
                }
            }
        }

        public string Febre()
        {
            string temperatura;

            if (_temperatura >= 41.0)
            {
                temperatura = "Hipertermia";
                _nivelUrgencia += 7;
            }
            else if (_temperatura >= 39.6 && _temperatura < 41)
            {
                temperatura = "Febre Alta";
                _nivelUrgencia += 3;
            }
            else if (_temperatura >= 37.6 && _temperatura <= 39.5)
            {
                temperatura = "Febre";
                _nivelUrgencia += 2;
            }
            else if (_temperatura >= 36.0 && _temperatura <= 37.5)
            {
                temperatura = "Normal";
                _nivelUrgencia += 1;
            }
            else
            {
                temperatura = "Hipotermia";
                _nivelUrgencia += 7;
            }

            return temperatura;
        }

        public string Pressao()
        {
            string pressao;

            if (_pressaoSistolica <= 120 && _pressaoDiastolica <= 80)
            {
                pressao = "Normal";
                _nivelUrgencia += 1;
            }
            else if (_pressaoSistolica > 120 && _pressaoSistolica < 140 || _pressaoDiastolica > 80 && _pressaoDiastolica < 90)
            {
                pressao = "Pré-Hipertensão";
                _nivelUrgencia += 2;

            }
            else if (_pressaoSistolica >= 140 && _pressaoSistolica < 160 || _pressaoDiastolica >= 90 && _pressaoDiastolica < 100)
            {
                pressao = "Hipertensão estágio 1";
                _nivelUrgencia += 3;
            }
            else if (_pressaoSistolica > 160 && _pressaoSistolica < 180 || _pressaoDiastolica >= 100 && _pressaoDiastolica < 110)
            {
                pressao = "Hipertensão estágio 2";
                _nivelUrgencia += 4;
            }
            else if (_pressaoSistolica >= 180 || _pressaoDiastolica >= 110)
            {
                pressao = "Crise hierptensiva";
                _nivelUrgencia += 7;
            }
            else
            {
                pressao = "Normal";
                _nivelUrgencia += 1;
            }

            return pressao;

        }




        //public string SelecionarUnidade(int x)
        //{
        //    return unidadeSaude[x];
        //}

        public string NivelUrgência()
        {

            if (_nivelUrgencia <= 4)
            {
                return "Verde";
            }
            else if (_nivelUrgencia < 8)
            {
                return "Amarelo";
            }
            else
            {
                return "Vermelho";
            }
        }


        public override string ToString()
        {
            return $"//DADOS DA TRIAGEM//\n\n*Medidadas corporais*\n\n Altura:{_altura.ToString("F2")}\t\tPeso: {_pesoKg}kg\n\n*Dados Vitais* \n\nPressão Arterial: {Pressao()}, {_pressaoSistolica}/{_pressaoDiastolica}\t\tTemperatura: {Febre()}, {_temperatura.ToString("F2")}\n\nPrioridade de Atendimento: {NivelUrgência()}\tLocal de Atendimento: \n\n\n";
        }







    }
}
