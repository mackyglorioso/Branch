// See https://aka.ms/new-console-template for more information


class Branch

{

  
    public static void Main(String[] args)
    {

        int i;
        string s;


        List<Branch> branches = new List<Branch>();

        for(i = 1; i<= 5; i++)
        {
            //     Console.WriteLine(branches.Count);
            Console.WriteLine("\nEnter branch: ");
            Console.ReadLine(); branches.Add(new Branch());

        }

    }

}
