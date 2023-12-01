using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.LSP.Bad
{

public  abstract class BasePhone
{
  public void Call()
        {
    Console.WriteLine("Calling...");
  }
        public abstract void TakePhoto();

}
    public class Iphone: BasePhone
    {
        public override void TakePhoto()
        {
            Console.WriteLine("Taking photo with Iphone");
        }
    }
    public class Nokia3310 : BasePhone 
    {
        public override void TakePhoto()
    {
            throw new NotImplementedException("you cant use this method in this");
        }
    }
}
