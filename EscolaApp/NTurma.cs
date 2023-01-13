using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaApp
{
    static class NTurma
    {
        //private Turma[] turmas = new Turma[10];
        private static List<Turma> turmas = new List<Turma>();
        public static void Inserir(Turma t) {
            Abrir();
            turmas.Add(t);
            Salvar();
        }
        public static List<Turma> Listar()
        {
            Abrir();
            return turmas;
        }
        public static void Atualizar(Turma t)
        {
            Abrir();
            foreach(Turma obj in turmas)
                if (obj.Id == t.Id)
                {
                    obj.Curso = t.Curso;
                    obj.Descricao = t.Descricao;
                    obj.AnoLetivo = t.AnoLetivo;
                }
            Salvar();
        }

        public static void Excluir(Turma t)
        {
            Abrir();
            Turma x = null;
            foreach (Turma obj in turmas)
                if (obj.Id == t.Id) x = obj;
            if (x != null) turmas.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
                f = new StreamReader("./turmas.xml");
                turmas = (List<Turma>)xml.Deserialize(f);
            }
            catch
            {
                turmas = new List<Turma>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
            StreamWriter f = new StreamWriter("./turmas.xml", false);
            xml.Serialize(f, turmas);
            f.Close();
        }
    }
}
