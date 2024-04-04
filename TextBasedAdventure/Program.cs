namespace TextBasedAdventure
 
{
  using System.Windows.Forms;
  internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var hello = new Character();
            Console.WriteLine("Name is " + hello.Name);
            Console.WriteLine("Your MaxHealth is " + hello.Health);
            Console.WriteLine("Can Swim is " + hello.CanSwim);
            Console.WriteLine("You weapon is the " + hello.Weapon);
            Console.WriteLine("Your station point coardination is a " + hello.Coardination);
        }
  }

    class Character
    {
     
      public string Name {get;}
      public Double Coardination {get; set;}
      public bool CanSwim {get; set;}
      public int Health { get; set; }
      public string Weapon { get; set; }
      public List<string> Weapons { get; set; }
      public ByteArrayContent Image { get; set; }







    public Character()
        {
            this.Coardination = 0.5;
            this.Health = 4;
            this.Weapon = "Hand";
            
            this.Weapons = new List<string>();
            this.Weapons.Add(this.Weapon);


            Console.WriteLine("Can you swin Yes or No");
            Console.WriteLine("Y for Yes N For No");
            var contine = true;
            while (contine)
            {
              var pressedKey = Console.ReadKey();
              var keyChar = pressedKey.KeyChar;
              var upperCaseKeyChar = Char.ToUpper(keyChar);
          

              if (upperCaseKeyChar.Equals('Y'))
              {
                this.CanSwim = true;
                break;
              }
              else if (upperCaseKeyChar.Equals('N'))
              {
                this.CanSwim = false;
                break;
              }
            }
            Console.WriteLine("Your name:");
            string name = Console.ReadLine();
   
            this.Name = name;
      

      using (OpenFileDialog openFileDialog = new OpenFileDialog())
        }




    }
}