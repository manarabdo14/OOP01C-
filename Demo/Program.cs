using static Demo.Program;

namespace Demo
{
    internal class Program
    {

        public enum Gender
        {
            Male,
            Female,
        }

        public enum Grade
        {
            A,
            B,
            C,
            D,
            F
        }
        [Flags]
        public enum Permissions : byte
        {
            Delete = 1 , Excute  = 2 , Read = 4 , Write = 8
        }

        class EMP
        {
            public string Name;
            public int Age;
            public Permissions Permissions;
        }
        static void Main(string[] args)
        {

            //Gender gender = Gender.Male;
            //Console.WriteLine(gender);

            //Gender gender = (Gender) 1;
            //Console.WriteLine(gender);


            //Days days = new Days();
            //Console.WriteLine(days.ToString());


            //Console.WriteLine("Enter your grade");
            ////Grade x = (Grade)Enum.Parse(typeof(Grade), Console.ReadLine());
            //bool RES = Enum.TryParse(typeof(Grade), Console.ReadLine(), out object x);
            //Grade grade;
            ////Enum.TryParse<Grade>(Console.ReadLine(), out grade);
            //Enum.TryParse(Console.ReadLine(), true ,out grade);
            //Console.WriteLine($"Your grade is {grade}");


            EMP eMP = new EMP();
            eMP.Name = "Manar";
            eMP.Age = 24;
            eMP.Permissions = (Permissions) 3;
            Console.WriteLine($"{eMP.Permissions}");
            eMP.Permissions ^= Permissions.Read;
            Console.WriteLine($"{eMP.Permissions}");
            eMP.Permissions ^= Permissions.Read;
            Console.WriteLine($"{eMP.Permissions}");

            if ((eMP.Permissions & Permissions.Excute )== Permissions.Excute)
            {
                
            }
            else
            {
                eMP.Permissions ^= Permissions.Excute;
                Console.WriteLine($"{eMP.Permissions}");
            }
        }
    }
}
