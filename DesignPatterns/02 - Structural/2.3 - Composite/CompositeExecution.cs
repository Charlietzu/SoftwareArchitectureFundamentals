namespace DesignPatterns
{
    public class CompositeExecution
    {
        public static void Execute()
        {
            var registrationValidation = new Message("The registration was not successful!");

            var userFormError = new Message("User entered an invalid name");

            var nameLengthForm = new InputFormMessage("Name must be more than 2 characters");
            var emptyNameForm = new InputFormMessage("The name cannot have numbers");

            userFormError.AddChild(nameLengthForm);
            userFormError.AddChild(emptyNameForm);

            registrationValidation.AddChild(userFormError);

            var userDomainError = new Message("Problems processing user registration");

            var userCpfDomain = new DomainMessage("The CPF informed is in use!");
            var userEmailDomain = new DomainMessage("The Email entered is in use!");

            userDomainError.AddChild(userCpfDomain);
            userDomainError.AddChild(userEmailDomain);

            registrationValidation.AddChild(userDomainError);

            var msgLevel1 = new Message("Level 1");
            var msgLevel2 = new Message("Level 2");
            var msgLevel3 = new Message("Level 3");
            var msgLevel4 = new Message("Level 4");
            var msgLevel5 = new Message("Level 5");

            msgLevel4.AddChild(msgLevel5);
            msgLevel3.AddChild(msgLevel4);
            msgLevel2.AddChild(msgLevel3);
            msgLevel1.AddChild(msgLevel2);

            registrationValidation.AddChild(msgLevel1);

            registrationValidation.ShowMessages(2);
        }
    }
}