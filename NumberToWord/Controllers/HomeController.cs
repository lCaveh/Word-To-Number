using Microsoft.AspNetCore.Mvc;
using NumberToWord.Models;

namespace NumberToWord.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Result(string userNumber)
    {
      NumbertoWord numbertoWord = new NumbertoWord(userNumber);
      numbertoWord.FixMainNumber();
      numbertoWord.CreateArrays();
      return View(numbertoWord);
    }
  }
}
