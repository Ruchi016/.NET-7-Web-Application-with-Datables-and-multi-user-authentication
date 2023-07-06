namespace DTWebApp.Models
{
    public class TransactionViewModel
    {
        public TransactionModel TransactionModel { get; set; } = new TransactionModel();    
        public List<TransactionModel> Transactions { get; set; } = new List<TransactionModel>();

        public List<TransactionModel> TransactionList
        {
            get { return Transactions; }
            set { Transactions = value; }
        }
    }
}
