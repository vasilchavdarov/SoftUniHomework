using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IManager
{
    string AddHero(IList<string> arguments);
    
    string Quit(IList<string> args);

    string Inspect(IList<string> args);

    string AddItem(IList<string> args);

    string AddRecipe(IList<string> args);
}
