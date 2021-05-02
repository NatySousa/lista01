using Lista01.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Lista01.Repositories
{
    public class FuncinarioRepository
    {
        public void ExportarDados(Funcionario funcionario)
        {
            var path = $"c:\\temp\\funcionario_{funcionario.Id}.txt";

            var streamWriter = new StreamWriter(path);

            streamWriter.WriteLine("\n*** DADOS DO FUNCIONÁRIO *** ");
            streamWriter.WriteLine("ID......................:" + funcionario.Id);
            streamWriter.WriteLine("Nome....................:" + funcionario.Nome);
            streamWriter.WriteLine("Cpf.....................:" + funcionario.Cpf);
            streamWriter.WriteLine("Matricula...............:" + funcionario.Matricula);
            streamWriter.WriteLine("Data de Admissão....... :" + funcionario.DataAdmissao);
            streamWriter.WriteLine("Cargo...................:" + funcionario.Cargo);
            streamWriter.WriteLine("Salário.................:" + funcionario.Salario);

            streamWriter.Close();

        }
    }
}


