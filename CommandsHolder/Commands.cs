namespace Main
{
    public class IGetCommands<T>
    {
        private T man;
        
        
        public T myValue
        {
            get
            {
                return this.man;
            }
            set
            {
                this.man = myValue;
            }
        }
    }
    
    
    class Commands : IGetCommands<string>
    {
        public void Commands1(string one)
        {
            Console.WriteLine("Command 1: " + one);
        }

        public void Commands2(string two)
        {
            Console.WriteLine("Command 2: " + two);
        }

        public void Commands3(string three)
        {
            Console.WriteLine("Command 3: " + three);
        }
        
        
    }
    
    
}