namespace DesignPatterns
{
    public class CompositeExecution
    {
        public static void Execute()
        {
            Message registrationValidation = new Message("The registration was not successful!");

            Message userFormError = new Message("User entered an invalid name");

            InputFormMessage nameLengthForm = new InputFormMessage("Name must be more than 2 characters");
            InputFormMessage emptyNameForm = new InputFormMessage("The name cannot have numbers");

            userFormError.AddChild(nameLengthForm);
            userFormError.AddChild(emptyNameForm);

            registrationValidation.AddChild(userFormError);

            Message userDomainError = new Message("Problems processing user registration");

            DomainMessage userCpfDomain = new DomainMessage("The CPF informed is in use!");
            DomainMessage userEmailDomain = new DomainMessage("The Email entered is in use!");

            userDomainError.AddChild(userCpfDomain);
            userDomainError.AddChild(userEmailDomain);

            registrationValidation.AddChild(userDomainError);

            Message msgLevel1 = new Message("Level 1");
            Message msgLevel2 = new Message("Level 2");
            Message msgLevel3 = new Message("Level 3");
            Message msgLevel4 = new Message("Level 4");
            Message msgLevel5 = new Message("Level 5");

            msgLevel4.AddChild(msgLevel5);
            msgLevel3.AddChild(msgLevel4);
            msgLevel2.AddChild(msgLevel3);
            msgLevel1.AddChild(msgLevel2);

            registrationValidation.AddChild(msgLevel1);

            registrationValidation.ShowMessages(2);
        }
    }
}