// See https://aka.ms/new-console-template for more
namespace program
{
    class listclass
    {
        const int MaxSize = 100;
        public string[] data;
        public int length;
        public listclass()
        {
            data = new string[MaxSize];
            length = 0;
        }
        public void createlist(string[] split)
        {
            int i;
            for(i = 0; i < split.Length; i++)
            {
                data[i] = split[i];
            }
            length = i;
        }
        public string displist()
        {
            if (length > 0)
            {
                string mystr = data[0];
                for (int i = 1; i < length; i++)
                {
                    mystr += " " + data[i];
                }

                return mystr;
            }
            else
                return "空串";
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            listclass listclass = new listclass();
            string[] split = { "a","b","c","d" };
            listclass.createlist(split);
            Console.WriteLine(listclass.displist());
        }
    }


}