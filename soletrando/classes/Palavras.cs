using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;

namespace soletrando.classes
{
    public class Palavras
    {
        public string Texto { get; set; }
        public Image Imagem { get; set; }
        public byte[] AudioBytes { get; set; }  // agora é byte[], não Stream


        

       // private List<Palavras> palavras = new List<Palavras>();
        public List<Palavras> erros { get; private set; } = new List<Palavras>();

        public Palavras palavraAtual;
       // private List<int> ordemIndices;
        //public List<Palavras> erros;// ordem embaralhada
      //  private int indiceAtual = 0;

        public Palavras() { }
        public Palavras(string texto, Image imagem, byte[] audioBytes)
        {
            Texto = texto;
            Imagem = imagem;
            AudioBytes = audioBytes;
        }
       

       

       
       

        public void TocarAudio()
        {
            if (AudioBytes != null && AudioBytes.Length > 0)
            {
                using (var ms = new MemoryStream(AudioBytes))
                {
                    SoundPlayer player = new SoundPlayer(ms);
                    player.Play();
                }
            }
        }

     

       /* public void PrepararOrdem()
        {
            // cria lista de índices
            ordemIndices = Enumerable.Range(0, palavras.Count).ToList();
            // embaralha
            Random rnd = new Random();
            ordemIndices = ordemIndices.OrderBy(x => rnd.Next()).ToList();
            indiceAtual = 0;
        }

        public Palavras MostrarProximaPalavra()
        {
            if (indiceAtual < ordemIndices.Count)
            {
                int indice = ordemIndices[indiceAtual];
                palavraAtual = palavras[indice];
                indiceAtual++;
                return palavraAtual; // retorna o objeto completo para o Form atualizar a interface
            }
            else
            {
                indiceAtual = 0; // reseta, opcional
                return null; // indica que acabou
            }
        }


        public void LimparPalavras()
        {
            palavras.Clear();
            erros.Clear();
            indiceAtual = 0; // limpa a lista
        }
        public string TotaldePalavras()
        {
            return "Falta " + palavras.Count.ToString() + " palavras";
        }

        public void RecuperarErrosParaPalavras(List<string> textos)
        {
            if (palavras == null)
                palavras = new List<Palavras>();
            if (erros == null || erros.Count == 0 || textos.Count == 0)
                return;

            List<Palavras> temp = new List<Palavras>();

            foreach (var texto in textos)
            {
                var erro = erros.Find(e => e.Texto.Equals(texto, StringComparison.OrdinalIgnoreCase));
                if (erro != null)
                {
                    temp.Add(erro);
                }
            }

            foreach (var p in temp)
            {
                if (!palavras.Exists(x => x.Texto.Equals(p.Texto, StringComparison.OrdinalIgnoreCase)))
                {
                    palavras.Add(p);
                }
            }
        }




       public Image CarregarImagem(string nomeArquivo)
        {
            var assembly = Assembly.GetExecutingAssembly();
            // Ajuste o nome completo do recurso
            string resourceName = assembly.GetManifestResourceNames()
                .FirstOrDefault(r => r.EndsWith("." + nomeArquivo, StringComparison.OrdinalIgnoreCase));

            if (resourceName == null)
                throw new Exception($"Imagem '{nomeArquivo}' não encontrada! Verifique o namespace e pasta.");

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                Image imgTemp = Image.FromStream(stream);
                return new Bitmap(imgTemp); // cópia independente
            }
        }

        public byte[] CarregarAudio(string nomeArquivo)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames()
                .FirstOrDefault(r => r.EndsWith("." + nomeArquivo, StringComparison.OrdinalIgnoreCase));

            if (resourceName == null) throw new Exception($"Áudio '{nomeArquivo}' não encontrado!");

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                return ms.ToArray();
            }
        }*/



  
    }
}

