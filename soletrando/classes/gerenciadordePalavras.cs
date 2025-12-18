using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace soletrando.classes
{
    public class GerenciadorPalavras
    {
        private List<Palavras> palavras = new List<Palavras>();
        private List<int> ordemIndices;
        private int indiceAtual = 0;

        public List<Palavras> Erros { get; private set; } = new List<Palavras>();
        public Palavras PalavraAtual { get; private set; }

        // -------------------
        // Métodos de inicialização
        // -------------------
        public void LimparPalavras()
        {
            palavras.Clear();
            Erros.Clear();
            PalavraAtual = null;
            indiceAtual = 0;
        }

        public string TotalDePalavras()
        {
            return $"Total de palavras: {Math.Min(indiceAtual, palavras.Count)}/{palavras.Count}";
        }

        public bool TemPalavras()
        {
            return palavras != null && palavras.Count > 0;
        }


        public void PrepararOrdem()
        {
            ordemIndices = Enumerable.Range(0, palavras.Count).ToList();
            Random rnd = new Random();
            ordemIndices = ordemIndices.OrderBy(x => rnd.Next()).ToList();
            indiceAtual = 0;
        }

        public Palavras MostrarProximaPalavra()
        {
            if (indiceAtual < ordemIndices.Count)
            {
                int i = ordemIndices[indiceAtual];
                PalavraAtual = palavras[i];
                indiceAtual++;
                return PalavraAtual;
            }
            else
            {
                PalavraAtual = null;
                return null;
            }
        }
        // Exemplo de carregar erros para a lista principal
        public void AdicionarPalavraAtualAosErros()
        {
            // Verifica se PalavraAtual não é nula
            if (PalavraAtual == null)
                return;

            // Verifica se a palavra já não está na lista de erros
            if (!Erros.Exists(p => p.Texto == PalavraAtual.Texto))
            {
                // Adiciona uma cópia da PalavraAtual à lista de erros
                Erros.Add(new Palavras(PalavraAtual.Texto, PalavraAtual.Imagem, PalavraAtual.AudioBytes));
            }
         
        }
  
        public void AdicionarErrosAPalavras(List<Palavras> Erros2)
        {
         
            // Garante que a lista palavras existe
            if (palavras == null)
                palavras = new List<Palavras>();

            foreach (var erro in Erros2)
            {
                // Adiciona somente se ainda não existir na lista palavras
                if (!palavras.Exists(p => p.Texto == erro.Texto))
                {
                    palavras.Add(new Palavras(erro.Texto, erro.Imagem, erro.AudioBytes));
                }
                
            }
        }
        public void AdicionarErrosAErros2(List<Palavras> Erros2)
        {
           // int countAntes = Erros.Count;
            // Garante que a lista palavras existe
            if (Erros2 == null)
                Erros2 = new List<Palavras>();

            foreach (var erro in Erros)
            {
                // Adiciona somente se ainda não existir na lista palavras
                if (!Erros2.Exists(p => p.Texto == erro.Texto))
                {
                    Erros2.Add(new Palavras(erro.Texto, erro.Imagem, erro.AudioBytes));
                }
              //  MessageBox.Show($"Palavras antes: {countAntes}, agora: {Erros2.Count}");
            }
        }


        // -------------------
        // Métodos de carregamento de recursos
        // -------------------
        public Image CarregarImagem(string nomeArquivo)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames()
                .FirstOrDefault(r => r.EndsWith("." + nomeArquivo, StringComparison.OrdinalIgnoreCase));

            if (resourceName == null)
                throw new Exception($"Imagem '{nomeArquivo}' não encontrada!");

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                return Image.FromStream(stream);
            }
        }

        public byte[] CarregarAudio(string nomeArquivo)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames()
                .FirstOrDefault(r => r.EndsWith("." + nomeArquivo, StringComparison.OrdinalIgnoreCase));

            if (resourceName == null)
                throw new Exception($"Áudio '{nomeArquivo}' não encontrado!");

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                return ms.ToArray();
            }
        }

        public void TocarAudio(Palavras palavra)
        {
            if (palavra.AudioBytes != null)
            {
                using (var ms = new MemoryStream(palavra.AudioBytes))
                {
                    SoundPlayer player = new SoundPlayer(ms);
                    player.PlaySync(); // PlaySync para rodar na thread do Task
                }
            }
        }

        // -------------------
        // Métodos de carregamento de palavras
        // -------------------
        public void CarregarPalavrasMapa()
        {
            palavras.AddRange(new List<Palavras>
            {
               new Palavras("pilar", CarregarImagem("pilar.png"), CarregarAudio("pilar.wav")),
               new Palavras("murici", CarregarImagem("murici.png"), CarregarAudio("murici.wav")),
               new Palavras("penedo", CarregarImagem("penedo.png"), CarregarAudio("penedo.wav")),
               new Palavras("pará", CarregarImagem("para.png"), CarregarAudio("para.wav")),
               new Palavras("amapá", CarregarImagem("amapa.png"), CarregarAudio("amapa.wav")),
               new Palavras("paraná", CarregarImagem("parana.png"), CarregarAudio("parana.wav")),
            });
        }

        public void CarregarPalavrasTransporte()
        {
           /* if (palavras == null)
                palavras = new List<Palavras>(); // inicializa se estiver null  */

            palavras.AddRange(new List<Palavras>
            {
                  new Palavras("jipe", CarregarImagem("jipe.png"),CarregarAudio("jipe.wav")),
                  new Palavras("moto", CarregarImagem("moto.png"),CarregarAudio("moto.wav")),
                  new Palavras("barco", CarregarImagem("barco.png"),CarregarAudio("barco.wav")),
                  new Palavras("táxi", CarregarImagem("taxi.png"),CarregarAudio("taxi.wav")),

            });
        }
        public void CarregarPalavrasAnimaisMarinhos()
        {
          

            palavras.AddRange(new List<Palavras>
            {
                 new Palavras("foca", CarregarImagem("foca.png"),CarregarAudio("foca.wav")),
                 new Palavras("lula", CarregarImagem("lula.png"),CarregarAudio("lula.wav")),
                 new Palavras("peixe", CarregarImagem("peixe.png"),CarregarAudio("peixe.wav")),
                 new Palavras("orca", CarregarImagem("orca.png"),CarregarAudio("orca.wav")),
                 new Palavras("cavala", CarregarImagem("cavala.png"),CarregarAudio("cavala.wav")),
                 new Palavras("tilápia", CarregarImagem("tilapia.png"),CarregarAudio("tilapia.wav")),


            });
        }

        public void CarregarPalavrasFloress()
        {
         

            palavras.AddRange(new List<Palavras>
            {

                 
                   new Palavras("rosa", CarregarImagem("rosa.png"),CarregarAudio("rosa.wav")),
                   new Palavras("violeta", CarregarImagem("violeta.png"),CarregarAudio("violeta.wav")),
                   new Palavras("lírio", CarregarImagem("lirio.png"),CarregarAudio("lirio.wav")),


            });
        }
        public void CarregarPalavrasVestuarios()
        {
      

            palavras.AddRange(new List<Palavras>
            {
                    new Palavras("bota", CarregarImagem("bota.png"),CarregarAudio("bota.wav")),
                    new Palavras("luva", CarregarImagem("luva.png"),CarregarAudio("luva.wav")),
                    new Palavras("meia", CarregarImagem("meia.png"),CarregarAudio("meia.wav")),
                    new Palavras("camisa", CarregarImagem("camisa.png"),CarregarAudio("camisa.wav")),
                    new Palavras("sapato", CarregarImagem("sapato.png"),CarregarAudio("sapato.wav")),
                    new Palavras("boné", CarregarImagem("bone.png"),CarregarAudio("bone.wav")),

            });
        }

        public void CarregarPalavrasOutrosAnimais()
        {
      

            palavras.AddRange(new List<Palavras>
            { new Palavras("sapo", CarregarImagem("sapo.png"),CarregarAudio("sapo.wav")),
             new Palavras("leoa", CarregarImagem("leoa.png"),CarregarAudio("leoa.wav")),
            new Palavras("mula", CarregarImagem("mula.png"),CarregarAudio("mula.wav")),
            new Palavras("zebu", CarregarImagem("zebu.png"),CarregarAudio("zebu.wav")),
            new Palavras("vaca", CarregarImagem("vaca.png"),CarregarAudio("vaca.wav")),
            new Palavras("pato", CarregarImagem("pato.png"),CarregarAudio("pato.wav")),
            new Palavras("boi", CarregarImagem("boi.png"),CarregarAudio("boi.wav")),
              new Palavras("lobo", CarregarImagem("lobo.png"),CarregarAudio("lobo.wav")),
            new Palavras("girafa", CarregarImagem("girafa.png"),CarregarAudio("girafa.wav")),
            new Palavras("ema", CarregarImagem("ema.png"),CarregarAudio("ema.wav")),
            new Palavras("urubu", CarregarImagem("urubu.png"),CarregarAudio("urubu.wav")),
            new Palavras("sabiá", CarregarImagem("sabia.png"),CarregarAudio("sabia.wav")),
            new Palavras("peru", CarregarImagem("peru.png"),CarregarAudio("peru.wav")),
            new Palavras("tucano", CarregarImagem("tucano.png"),CarregarAudio("tucano.wav")),
             new Palavras("cobra", CarregarImagem("cobra.png"),CarregarAudio("cobra.wav")),
            new Palavras("jabuti", CarregarImagem("jabuti.png"),CarregarAudio("jabuti.wav")),
            new Palavras("jacaré", CarregarImagem("jacare.png"),CarregarAudio("jacare.wav")),
            new Palavras("rato", CarregarImagem("rato.png"),CarregarAudio("rato.wav")),
            new Palavras("cutia", CarregarImagem("cutia.png"),CarregarAudio("cutia.wav")),

            });
        }

        public void CarregarPalavras()
        {
           

            palavras.AddRange(new List<Palavras>
        {

           
            new Palavras("bolo", CarregarImagem("bolo.png"),CarregarAudio("bolo.wav")),
            new Palavras("pipoca", CarregarImagem("pipoca.png"),CarregarAudio("pipoca.wav")),
            new Palavras("ovo", CarregarImagem("ovo.png"),CarregarAudio("ovo.wav")),
            new Palavras("bife", CarregarImagem("bife.png"),CarregarAudio("bife.wav")),
            new Palavras("suco", CarregarImagem("suco.png"),CarregarAudio("suco.wav")),
            new Palavras("doce", CarregarImagem("doce.png"),CarregarAudio("doce.wav")),
            new Palavras("sopa", CarregarImagem("sopa.png"),CarregarAudio("sopa.wav")),
            new Palavras("salada", CarregarImagem("salada.png"),CarregarAudio("salada.wav")),
            new Palavras("neve", CarregarImagem("neve.png"),CarregarAudio("neve.wav")),
            new Palavras("lua", CarregarImagem("lua.png"),CarregarAudio("lua.wav")),



            new Palavras("faca", CarregarImagem("faca.png"),CarregarAudio("faca.wav")),

            new Palavras("saci", CarregarImagem("saci.png"),CarregarAudio("saci.wav")),
            new Palavras("iara", CarregarImagem("iara.png"),CarregarAudio("iara.wav")),
            new Palavras("cuca", CarregarImagem("cuca.png"),CarregarAudio("cuca.wav")),

            new Palavras("figo", CarregarImagem("figo.png"),CarregarAudio("figo.wav")),
            new Palavras("coco", CarregarImagem("coco.png"),CarregarAudio("coco.wav")),
            new Palavras("rua", CarregarImagem("rua.png"),CarregarAudio("rua.wav")),

            new Palavras("seta", CarregarImagem("seta.png"),CarregarAudio("seta.wav")),
            new Palavras("casa", CarregarImagem("casa.png"),CarregarAudio("casa.wav")),
            new Palavras("muro", CarregarImagem("muro.png"),CarregarAudio("muro.wav")),
            new Palavras("cabeça", CarregarImagem("cabeca.png"),CarregarAudio("cabeca.wav")),
            new Palavras("boca", CarregarImagem("boca.png"),CarregarAudio("boca.wav")),
            new Palavras("barata", CarregarImagem("barata.png"),CarregarAudio("barata.wav")),
            new Palavras("bola", CarregarImagem("bola.png"),CarregarAudio("bola.wav")),
            new Palavras("caneta", CarregarImagem("caneta.png"),CarregarAudio("caneta.wav")),
            new Palavras("vela", CarregarImagem("vela.png"),CarregarAudio("vela.wav")),
            new Palavras("dado", CarregarImagem("dado.png"),CarregarAudio("dado.wav")),


            new Palavras("navio", CarregarImagem("navio.png"),CarregarAudio("navio.wav")),

           

            new Palavras("uva", CarregarImagem("uva.png"),CarregarAudio("uva.wav")),
            new Palavras("mapa", CarregarImagem("mapa.png"),CarregarAudio("mapa.wav")),

        
           
            // Adicione mais palavras aqui
        });
        }

    
    }
}
