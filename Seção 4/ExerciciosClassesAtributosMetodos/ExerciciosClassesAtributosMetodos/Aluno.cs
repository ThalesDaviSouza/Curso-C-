namespace Exercicio3 {
    public class Aluno {
        private double[] _notas;

        public Aluno() {
            _notas = new double[3];
        }
        public Aluno(double nota1 , double nota2, double nota3) {
            _notas = new double[3];
            _notas[0] = nota1;
            _notas[1] = nota2;
            _notas[2] = nota3;
        }

        public double FinalGrade() {
            double finalGrade = 0;
            foreach(double grade in _notas) {
                finalGrade += grade;
            }
            return finalGrade;
        }
        public bool Aproved() {
            return (FinalGrade() >= 60 ? true : false);
        }


    }
}
