using System;

namespace PPX_Pos
{
    public sealed class PassportX_POS :IPOS
    {
        public const string WELCOME_MESSAGE = "Hello Passport-X";
        public string DisplayWelcomeScreen()
        {
           return WELCOME_MESSAGE;
        }

        public void Load()
        {
            DisplayWelcomeScreen();
        }

        public Guid CreateCustomerOrder() { return Guid.NewGuid();}
    }
}