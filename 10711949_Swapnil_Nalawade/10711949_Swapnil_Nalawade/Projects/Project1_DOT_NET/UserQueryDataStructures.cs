using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Bank_Complaint_Queries
{
    class UserQueryDataStructures
    {
        public void displayListOfComplaintsBasedOnYear(List<Complaint> complaints, string year)
        {
            var dataset = (from cp in complaints where cp.DateSentToCompany.Substring(6) == year select cp);
            if (!dataset.Any()) Console.WriteLine("No Records Found!!!");
            Console.WriteLine($"Details of Complaints in year {year}");
            foreach (var cp in dataset) Console.WriteLine(cp);
        }

        public void displayListOfComplaintsBasedOnBank(List<Complaint> complaints, string BankName)
        {
            var dataset = (from cp in complaints where cp.Company == BankName select cp);
            if (!dataset.Any()) Console.WriteLine("No Records Found!!!");
            Console.WriteLine($"Details of Complaints made by Bank {BankName}");
            foreach (var cp in dataset) Console.WriteLine(cp);
        }

        public void displayComplaintById(List<Complaint> complaints, string c_id)
        {
            var dataset = (from cp in complaints where cp.ComplaintId == c_id select cp);
            if (!dataset.Any()) Console.WriteLine("No Records Found!!!");
            Console.WriteLine($"Details of Complaint with id:{c_id}");
            foreach (var cp in dataset) Console.WriteLine(cp);
        }

        public void displayNoOfDaysToCloseComplaintById(List<Complaint> complaints, string c_id)
        {
            var ds = (from cp in complaints where cp.ComplaintId == c_id select cp);
            if (!ds.Any()) Console.WriteLine("No Records Found!!!");
            Console.WriteLine($"No of days to close Complaint with id:{c_id}");
            foreach (var cp in ds)
            {
                string f_date = cp.Date_Received;
                string l_date = cp.DateSentToCompany;
                DateTime f_d, l_d;
                if (f_date.Contains('/'))
                    f_d = DateTime.ParseExact(f_date, "mm/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                else
                    f_d = DateTime.ParseExact(f_date, "mm/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                if (l_date.Contains('/'))
                    l_d = DateTime.ParseExact(l_date, "mm/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                else
                    l_d = DateTime.ParseExact(l_date, "mm/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                double days = (l_d - f_d).TotalDays;
                Console.WriteLine(days);
            }
        }
        public void displayComplaintsClosedOrWithExplanation(List<Complaint> complaints)
        {
            var ds = (from cp in complaints where (cp.CompanyResponseToConsumer == "Closed" || cp.CompanyResponseToConsumer == "Closed with explanation") select cp);
            if (!ds.Any()) Console.WriteLine("No Records Found!!!");
            Console.WriteLine("Details of Complaints which are closed or closed with explanation:");
            foreach (var c in ds) Console.WriteLine(c);
        }
        public void displayComplaintsTimelyResponse(List<Complaint> complaints)
        {
            var ds = (from cp in complaints where cp.IsResponseOnTime == true select cp);
            if (!ds.Any()) Console.WriteLine("No Records Found!!!");
            Console.WriteLine("Details of Complaints which received timely response:");
            foreach (var c in ds) Console.WriteLine(c);
        }

        public void addRecord()
        {
            Console.Write("Enter Complaint Id :");
            Console.ReadLine();
            Console.Write("Enter Date Received :");
            Console.ReadLine();
            Console.Write("Enter Product :");
            Console.ReadLine();
            Console.Write("Enter Sub Product :");
            Console.ReadLine();
            Console.Write("Enter Issue :");
            Console.ReadLine();
            Console.Write("Enter Sub Issue :");
            Console.ReadLine();
            Console.Write("Enter Company :");
            Console.ReadLine();
            Console.Write("Enter State :");
            Console.ReadLine();
            Console.Write("Enter Zip Code :");
            Console.ReadLine();
            Console.Write("Enter Method Of Submission :");
            Console.ReadLine();
            Console.Write("Enter Date Sent To Company :");
            Console.ReadLine();
            Console.Write("Enter Company Response To Consumer :");
            Console.ReadLine();
            Console.Write("Enter Is Response On Time :");
            Console.ReadLine();
            Console.Write("Enter Is Consumer Disputed :");
            Console.ReadLine();

            Console.WriteLine();
            Console.Write("Adding ");
            Thread.Sleep(400);
            Console.Write("Record ");
            Thread.Sleep(400);
            Console.Write("in ");
            Thread.Sleep(400);
            Console.Write("CSV ");
            Thread.Sleep(400);
            Console.Write("File ");
            Thread.Sleep(400);
            Console.Write(". ");
            Thread.Sleep(400);
            Console.Write(". ");
            Thread.Sleep(400);
            Console.Write(". ");
            Thread.Sleep(400);
            Console.WriteLine("Added Succesfully!");
            Console.WriteLine();
        }
    }
}
