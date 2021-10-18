namespace DesignPatterns
{
    public class ExecutionComposite
    {
        public static void Execute()
        {
            Message registerValidation = new Message("Registration was not accomplished!");

            Message userFormError = new Message("User entered an invalid name");

            InputFormMessage nameSizeForm = new InputFormMessage("The name must have more than 2 characters.");
            InputFormMessage emptyNameForm = new InputFormMessage("The name cannot have numbers");

            userFormError.AddChild(nameSizeForm);
            userFormError.AddChild(emptyNameForm);

            registerValidation.AddChild(userFormError);

            Message domainUserError = new Message("Problems processing user registration");

            DomainMessage cpfUserDomain = new DomainMessage("The CPF informed is already in use!");
            DomainMessage emailUserDomain = new DomainMessage("The Email informed is already in use!");

            domainUserError.AddChild(cpfUserDomain);
            domainUserError.AddChild(emailUserDomain);

            registerValidation.AddChild(domainUserError);

            Message msgLevel1 = new Message("Level 1");
            Message msgLevel2 = new Message("Level 2");
            Message msgLevel3 = new Message("Level 3");
            Message msgLevel4 = new Message("Level 4");
            Message msgLevel5 = new Message("Level 5");

            msgLevel4.AddChild(msgLevel5);
            msgLevel3.AddChild(msgLevel4);
            msgLevel2.AddChild(msgLevel3);
            msgLevel1.AddChild(msgLevel2);

            registerValidation.AddChild(msgLevel1);

            registerValidation.ShowMessages(2);
        }
    }
}