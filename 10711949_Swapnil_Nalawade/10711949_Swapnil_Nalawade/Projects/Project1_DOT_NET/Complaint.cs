namespace Bank_Complaint_Queries {
    class Complaint {
        public string Date_Received { get; set; }
        public string Product { get; set; }
        public string SubProduct { get; set; }
        public string Issue { get; set; }
        public string SubIssue { get; set; }
        public string Company { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string MethodOfSubmission { get; set; }
        public string DateSentToCompany { get; set; }
        public string CompanyResponseToConsumer { get; set; }
        public bool IsResponseOnTime { get; set; }
        public bool IsConsumerDisputed { get; set; }
        public string ComplaintId { get; set; }

        public override string ToString() {
            string record = $"\nComplaint Id : {ComplaintId}\n" +
                $"Data Received : {Date_Received}\n" +
                $"Product : {Product}\n" +
                $"Sub Product : {SubProduct}\n" +
                $"Issue : {Issue}\n" +
                $"Sub Issue : {SubIssue}\n" +
                $"Company : {Company}\n" +
                $"State : {State}\n" +
                $"Zip Code : {ZipCode}\n" +
                $"Method of Submission : {MethodOfSubmission}\n" +
                $"Data Sent To Company : {DateSentToCompany}\n" +
                $"Company Response To Consumer : {CompanyResponseToConsumer}\n" +
                $"Is Response On Time : {IsResponseOnTime}\n" +
                $"Is Consumer Disputed : {IsConsumerDisputed}\n";
            return record;
        }

    }
}
