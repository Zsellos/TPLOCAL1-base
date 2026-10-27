using Microsoft.AspNetCore.Mvc;

using TPLOCAL1.Models;

//Subject is find at the root of the project and the logo in the wwwroot/ressources folders of the solution
//--------------------------------------------------------------------------------------
//Careful, the MVC model is a so-called convention model instead of configuration,
//The controller must imperatively be name with "Controller" at the end !!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
        //methode "naturally" call by router
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //retourn to the Index view (see routing in Program.cs)
                return View();
            else
            {
                //Call different pages, according to the id pass as parameter
                switch (id)
                {
                    case "OpinionList" or "AvisList":
                        //code reading of the xml files provide
                        var opinions = new OpinionList();
                        List<Opinion> OpList = opinions.GetAvis("XlmFile\\DataAvis.xml");
                        return View(id, OpList);
                    case "Form":
                        //call the Form view with data model empty
                        var information = new Information();
                        return View(id, information);
                    default:
                        //retourn to the Index view (see routing in Program.cs)
                        return View();
                }
            }
        }


        //methode to send datas from form to validation page
        [HttpPost]
        //public ActionResult ValidationFormulaire([Bind("Name,Forename,Gender,Address,ZipCode,Town,Email,StartDate,Training,ReviewCobol,ReviewCSharp")] Information information)
        public ActionResult ValidationFormulaire(Information information)
        {
            //test if model's fields are set
            //if not, display an error message and stay on the form page
            //else, call ValidationForm with the datas set by the user
            if (ModelState.IsValid)
            {
                return View("ValidationForm", information);
            }
            return View("Form");
        }
    }
}