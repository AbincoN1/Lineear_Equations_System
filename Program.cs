List<List<string>> sl = new List<List<string>>();
inputXY();
elimination();
Calculate();



void inputXY()
{
    int num = 1;
    string inptText;
    List<string> inptList = new List<string>();
    while (true)
    {
        Console.Write("Eq #" + num.ToString() + ": ");
        num++;
        inptText = Console.ReadLine();

        if(inptText == "END")
        {
            break;
        }
        else
        {
            inptList = inptText.Split(' ').ToList();
            sl.Add(inptList);
        }   
    }
}

void elimination()
{
    List<string> newList = new List<string>();

    double k = Convert.ToDouble(sl[0][0]) / Convert.ToDouble(sl[1][0]);
    newList.Add((Convert.ToDouble(sl[1][0]) - (Convert.ToDouble(sl[0][0]) / k)).ToString());
    newList.Add((Convert.ToDouble(sl[1][1]) - (Convert.ToDouble(sl[0][1]) / k)).ToString());
    newList.Add((Convert.ToDouble(sl[1][2]) - (Convert.ToDouble(sl[0][2]) / k)).ToString());
    sl[1] = newList;



}

void Calculate()
{
    double x2, x1;
    x2 = Convert.ToDouble(sl[1][2])  / Convert.ToDouble(sl[1][1]);
    x1 = (Convert.ToDouble(sl[0][2])  -  (Convert.ToDouble(sl[0][1]) * x2)) / Convert.ToDouble(sl[0][0]);


    Console.WriteLine("x1: " + x1.ToString());
    Console.WriteLine("x2: " + x2.ToString());

}

