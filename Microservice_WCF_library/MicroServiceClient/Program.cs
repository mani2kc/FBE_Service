using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroServiceClient.GetEstimateService;
using MicroServiceClient.GetTaxes;


namespace MicroServiceClient
{
    class Program
    {
        static GetEstimateClient getEstimate = new GetEstimateClient("NetTcpBinding_IGetEstimate");

        static GetTaxesClient getTaxes = new GetTaxesClient("NetTcpBinding_IGetTaxes");


        static void Main(string[] args)
        { 
            while (true) // Loop indefinitely
            {
                Console.WriteLine("*******************************************************************************");
                Console.WriteLine("Enter input ==> 1 for GetEstimate ==> 2 for GetTaxes ==> anykey to exit the application"); // Prompt
                string line = Console.ReadLine(); // Get string from user
                int value = Int32.Parse(line);
                if(value == 1)
                {
                    getSOCEstimate();    
                }
                else if(value == 2)
                { 
                    getXTaxes(); 
                }
                else // Check string
                {
                    break;
                }
            }
           
            Console.ReadKey();

        }

        public static void getSOCEstimate()
        {
            List<GetEstimateService.ProductInfo> prodlst = new List<GetEstimateService.ProductInfo>(); 

            SOCRequest request = new SOCRequest();

            GetEstimateService.ProductInfo prodA = new GetEstimateService.ProductInfo();
            prodA.ProductIOSC = "A";
            prodA.Rate = 10.0M;

            GetEstimateService.ProductInfo prodB = new GetEstimateService.ProductInfo();
            prodB.ProductIOSC = "B";
            prodB.Rate = 20.0M;

            GetEstimateService.ProductInfo prodC = new GetEstimateService.ProductInfo();
            prodC.ProductIOSC = "C";
            prodC.Rate = 30.0M;

            GetEstimateService.ProductInfo prodD = new GetEstimateService.ProductInfo();
            prodD.ProductIOSC = "D";
            prodD.Rate = 40.0M;

            prodlst.Add(prodA);
            prodlst.Add(prodB);
            prodlst.Add(prodC);
            prodlst.Add(prodD);

            request.Products = prodlst.ToArray();

            //GetSOCEstimate
            SOCResponse response = getEstimate.GetSOCEstimate(request);

            if (response != null && response.SOCEstimate != null)
            {
                Console.WriteLine("\n");
                Console.WriteLine("SOC Estimate :");
                Console.WriteLine("SOC Monthly charges :" + response.SOCEstimate.Monthly);
                Console.WriteLine("SOC FirstBill charges :" + response.SOCEstimate.FirstBill);
                Console.WriteLine("SOC Monthly Taxes :" + response.SOCEstimate.TaxResponse.MonthlyTaxes);
                Console.WriteLine("SOC FirstBill Taxes :" + response.SOCEstimate.TaxResponse.FirstBillTaxes);
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("No SOCEstimate for the request");
                Console.WriteLine("\n");
            }

        }

        public static void getSOCTaxes()
        {
            GetEstimateService.TaxRequest request = new GetEstimateService.TaxRequest();
            request.MonthlyCharges = 100M;
            request.FirstBillCharges = 150M;

            GetEstimateService.TaxResponse response = getEstimate.GetTaxes(request);

            if (response != null)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Standalone TaxResponse :");
                Console.WriteLine("Monthly Taxes:" + response.MonthlyTaxes);
                Console.WriteLine("FirstBill Taxes" + response.FirstBillTaxes);
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("No Tax response");
                Console.WriteLine("\n");
            }
           
        }


        public static void getXTaxes()
        {
            GetTaxes.TaxRequest request = new GetTaxes.TaxRequest();


            List<GetTaxes.ProductInfo> prodlst = new List<GetTaxes.ProductInfo>();

            GetTaxes.ProductInfo prodA = new GetTaxes.ProductInfo();
            prodA.ProductIOSC = "A";
            prodA.Rate = 10.0M;

            GetTaxes.ProductInfo prodB = new GetTaxes.ProductInfo();
            prodB.ProductIOSC = "B";
            prodB.Rate = 20.0M;

            GetTaxes.ProductInfo prodC = new GetTaxes.ProductInfo();
            prodC.ProductIOSC = "C";
            prodC.Rate = 30.0M;

            GetTaxes.ProductInfo prodD = new GetTaxes.ProductInfo();
            prodD.ProductIOSC = "D";
            prodD.Rate = 40.0M;

            prodlst.Add(prodA);
            prodlst.Add(prodB);
            prodlst.Add(prodC);
            prodlst.Add(prodD);

            request.Products = prodlst.ToArray();

            GetTaxes.TaxResponse response = getTaxes.GetSOCTaxes(request);


            if (response != null)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Standalone TaxResponse :");
                Console.WriteLine("Monthly Taxes:" + response.MonthlyTaxes);
                Console.WriteLine("FirstBill Taxes" + response.FirstBillTaxes);
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("No Tax response");
                Console.WriteLine("\n");
            }


        }
    }
}
