namespace Patterns
{
    public class CommandExecutor
    {
        private static CommandExecutor instance;

        public ICommand Command { get; set; }

        private CommandExecutor() { }
 
        public void ExecuteCommand() => Command.Execute();

        public static CommandExecutor GetInstance()
        {
            if (instance == null)
            {
                instance = new CommandExecutor();
            }

            return instance;
        }
    }
}
