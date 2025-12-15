using Microsoft.AspNetCore.Mvc;

namespace Precub_Oana_Lab1.Controllers
{
    public class PrimulController : Controller
    {
        public string Index()
        {
            return "Bun venit pe pagina mea!";
        }

        public string Salut()
        {
            return "Salut";
        }
        
        public string MesajPersonalizat(string nume, int varsta)
        {
            return $"Salut {nume}, ai varsta de {varsta} ani.";
        }
    }
}
