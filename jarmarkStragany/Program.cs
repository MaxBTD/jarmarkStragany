namespace jarmarkStragany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] scianyStr = Console.ReadLine().Split(' ');
            List<double> scianyDbl = new List<double>();
            bool czyScianyNadaja = true;

            foreach (string s in scianyStr) {
                string pom = "";
                double x1 = -1;
                double x2 = -1;
                for(int i = 0; i < s.Length; i++){
                    if (s[i] != '/'){
                        pom += s[i];
                    } else {
                        double.TryParse(pom, out x1);
                        pom = "";
                    }
                }
                double.TryParse(pom, out x2);
                scianyDbl.Add(x1 / x2);
            }

            for(int i = 0; i < scianyDbl.Count - 1; i++){
                for(int j = 0; j < scianyDbl.Count - 1; j++){
                    if (i != j && scianyDbl[i] + scianyDbl[j] < scianyDbl.Max())
                        czyScianyNadaja = false;
                }
            }

            Console.WriteLine(czyScianyNadaja ? "TAK" : "NIE");
        }
    }
}
