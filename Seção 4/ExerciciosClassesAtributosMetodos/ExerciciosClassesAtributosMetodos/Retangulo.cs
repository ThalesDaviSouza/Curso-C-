namespace Exercicio1 {
    public class Retangulo {
        private double _largura;
        private double _altura;

        public Retangulo(double largura, double altura) {
            _largura = largura;
            _altura = altura;
        }

        public double getLargura() {
            return _largura;
        }
        public double getAltura() {
            return _altura;
        }


        public double CalcularArea() {
            return _altura * _largura;
        }

        public double CalcularPerimetro() {
            return (2 * _largura + 2 * _altura);
        }

        public double CalcularDiagonal() {
            return (Math.Sqrt(Math.Pow(_largura, 2) + Math.Pow(_altura, 2)));
        }

    }
}
