using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
namespace Bank_Complaint_Queries {
    class ComplaintCsvReader {
        // method to read the CSV file and return the List of Complaints
        public List<Complaint> GetComplaints() {

            // 1. defining the path of the csv file
            string path = @"C:\Users\akbte\OneDrive\Desktop\Mini Projects\1_Complaints_Project\complaints.csv";
            
            List<Complaint> complaints = new List<Complaint>();
            
            // 2. initializing TextField Parser Object with Path
             
            using (TextFieldParser parser = new TextFieldParser(path)) {
                parser.TextFieldType = FieldType.Delimited;

                //    setting delimiters 
                parser.SetDelimiters(",");

                // reading the rows of the file
                while (!parser.EndOfData) {
                    string[] fields = parser.ReadFields();
                    Complaint c = new Complaint();
                    c.Date_Received = fields[0];
                    c.Product = fields[1];
                    c.SubProduct = fields[2];
                    c.Issue = fields[3];
                    c.SubIssue = fields[4];
                    c.Company = fields[5];
                    c.State = fields[6];
                    c.ZipCode = fields[7];
                    c.MethodOfSubmission = fields[8];
                    c.DateSentToCompany = fields[9];
                    c.CompanyResponseToConsumer = fields[10];
                    c.IsResponseOnTime = fields[11] == "Yes" ? true : false;
                    c.IsConsumerDisputed = fields[12] == "Yes" ? true : false;
                    c.ComplaintId = fields[13];
                    
                    // adding the complaint object in the list
                    complaints.Add(c);
                }
                // Console.WriteLine("NewLine");
            }
            return complaints;
        }
    }
}
