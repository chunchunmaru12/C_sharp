using System;


namespace ChapterThree
{
    class AccessModifier
    {
        private string name = "md";
        public int age = 26;
        protected string state = "KTM";
        public int add(int a, int b) => (a + b);
        int subtract(int a, int b) => (a - b);
        public string GetName() => name;

    }
    class ClassExample
    {
        static void Main(string[] args)
        {
            AccessModifier obj = new AccessModifier();
            obj.add(1, 2);
            

        }
    }
}

