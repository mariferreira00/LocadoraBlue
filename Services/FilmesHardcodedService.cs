using LocadoraDeFilmesPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraDeFilmesPF.Services
{
    public class FilmesHardcodedService : IFilmesService
    {
        public bool Create(Filme p)
        {
            var pacientes = getAll();
            p.id = pacientes.Last().id + 1;
            pacientes.Add(p);
            return true;
        }

        public bool Delete(int? id)
        {
            var pacientes = getAll();
            var paciente = Get(id);
            if (paciente == null)
            {
                return false;
            }

            pacientes.Remove(paciente);
            return true;
        }

        public Filme Get(int? id) => getAll().Find(f => f.id == id);

        public List<Filme> getAll(string busca = null)
        {
            List<Filme> filmes = new();

            filmes.Add(new Filme(1, "O Destino de Júpter", "Jupiter Jones nasceu sob um céu noturno, com sinais de que estava destinada a algo maior...", 15.90, new DateTime(2015, 02, 15), 113));
            filmes.Add(new Filme(2, "Madrugada dos mortos", "Os zumbis desejam dominar uma cidade de Wisconsin e começam a atacar as pessoas...", 18.90, new DateTime(2020, 12, 25), 100));
            filmes.Add(new Filme(3, "Soul", "Em Soul, duas perguntas se destacam: Você já se perguntou de onde vêm sua paixão, seus sonhos e seus interesses?...", 19.90, new DateTime(2004, 04, 23), 100));
            filmes.Add(new Filme(4, "Convenção das Bruxas", "Um menino descobre uma conferência de bruxas enquanto fica hospedado em um hotel com a avó...", 21.90, new DateTime(2020, 11, 19), 105));
            filmes.Add(new Filme(5, "O Rei Leão", "Simba, um leão herdeiro do trono, precisará enfrentar seu tio Scar e escapar de suas artimanhas...", 14.90, new DateTime(2011, 08, 26), 90));
            filmes.Add(new Filme(6, "Viva - A Vida é uma Festa", "Um menino de 12 anos, na tentativa de ser um músico famoso,acaba por se envolver em um mistério de 100 anos...", 16.90, new DateTime(2018, 01, 04), 105));
            filmes.Add(new Filme(7, "Gladiador", "Nos dias finais do reinado de Marcus Aurelius (Richard Harris), o imperador desperta a ira de seu filho Commodus...", 10.90, new DateTime(2000, 05, 19), 155));
            filmes.Add(new Filme(8, "Coringa", "Arthur Fleck está lutando para se integrar à sociedade quebrada de Gotham e contra uma doença psiquiatríca...", 18.90, new DateTime(2019, 10, 03), 125));
            filmes.Add(new Filme(9, "Divertida Mente", "Dentro do cérebro de Riley, convivem várias emoções diferentes, como a Alegria, o Medo, a Raiva, o Nojinho e a Tristeza....", 17.90, new DateTime(2015, 06, 18), 95));
            filmes.Add(new Filme(10, "À Procura da Felicidade", "Um pai de família que enfrenta sérios problemas financeiros tentará de todas as maneiras manter sua família unida...", 18.90, new DateTime(2007, 02, 02), 118));

            return filmes;
        }

        public bool Update(Filme f)
        {
            var filme_existente = Get(f.id);
            if (filme_existente == null)
            {
                return false;
            }
            var filmes = getAll();
            var indice = filmes.IndexOf(filme_existente);
            filmes[indice] = f;
            return true;
        }
    }
}
