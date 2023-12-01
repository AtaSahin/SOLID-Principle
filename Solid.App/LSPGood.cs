using System;

namespace Solid.App.LSP.Good
{
    public interface ITakePhoto
    {
        void TakePhoto();
    }

    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Calling...");
        }
    }

    public class Iphone : BasePhone, ITakePhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Taking photo...");
        }
    }

    public class Nokia3310 : BasePhone
    {

    }
}
