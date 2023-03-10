namespace MyClassLibrary2
{
    public class ElectricityBill
    {
        public int Units { get; set; }
        public int MeterNumber { get; set; }
        public string ServiceType { get; set; }
        public string CustomerName { get; set; }
        public double Bill { get; set; }
        public void ElectricityBillMethod()
        {
            //if (ServiceType.ToLower() == "d") 
            if (ServiceType == "d" || ServiceType == "D")
            {
                if (Units < 100)
                {
                    Bill = Units * 0.35;
                    Console.WriteLine("the Electricity bill is:" + Bill);
                }
                else if (Units > 100 && Units <= 200)
                {
                    Bill = Units * 0.85;
                    Console.WriteLine("the Electricity bill is:" + Bill);
                }
                else if (Units > 200 && Units <= 400)
                {
                    Bill = Units * 1.15;
                    Console.WriteLine("the Electricity bill is:" + Bill);
                }
                else if (Units > 400 && Units <= 700)
                {
                    Bill = Units * 2.05; ;
                    Console.WriteLine("the Electricity bill is:" + Bill);
                }
                else
                {
                    Bill = Units * 2.80;
                    Console.WriteLine("the Electricity bill is:" + Bill);
                }



            }
            else if (ServiceType == "c" || ServiceType == "C")
            {
                if (Units < 100)
                {
                    Bill = Units * 0.90;
                    Console.WriteLine("the Electricity bill is:" + Bill);
                }
                else if (Units > 100 && Units <= 200)
                {
                    Bill = Units * 1.35;
                    Console.WriteLine("the Electricity bill is:" + Bill);
                }
                else if (Units > 200 && Units <= 400)
                {
                    Bill = Units * 1.95;
                    Console.WriteLine("the Electricity bill is:" + Bill);
                }
                else if (Units > 400 && Units <= 700)
                {
                    Bill = Units * 2.45;
                    Console.WriteLine("the Electricity bill is:" + Bill);
                }
                else
                {
                    Bill = Units * 3.25;
                    Console.WriteLine("the Electricity bill is:" + Bill);
                }

            }

        }
    }
}