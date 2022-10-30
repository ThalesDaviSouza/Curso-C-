using System;


namespace Exercicio3 {
    public class AlunoTeste {
        public void Run() {
            Aluno student;

            Console.WriteLine("Digite as três notas do aluno: ");
            student = new Aluno(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("Nota final: {0}", student.FinalGrade().ToString("F2"));
            Console.WriteLine("{0}", student.Aproved() == true ? "Aprovado" : "Reprovado");
            if (!student.Aproved()){
                Console.WriteLine("Falta: {0} pontos", 60 - student.FinalGrade());
            }
        }
    }
}
