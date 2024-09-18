namespace PartialView.Models
{
    public class ListaDeModel
    {
        public List<ModeloProjectPartialView> listaDoModel {get; set;}
        public string corPrimaria { get; set; }
        public string corSecundaria { get; set; }

        public int idade { get; set; }
    }
}