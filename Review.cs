using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankSystemOOP
{
    class Review
    {
        public int AccountNumber { get; set; }
        public string Comment { get; set; }
        public DateTime Timestamp { get; set; }

        public Review(int accNum, string comment)
        {
            AccountNumber = accNum;
            Comment = comment;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{Timestamp:yyyy-MM-dd HH:mm}] Account {AccountNumber}: {Comment}";
        }
    }

    public static class ReviewManager
    {
        private static readonly string FilePath = "reviews.txt";

        public static void SubmitReview(int accNum)
        {
            Console.Write("Write your review: ");
            string comment = Console.ReadLine();

            Review review = new(accNum, comment);
            File.AppendAllText(FilePath, review + Environment.NewLine);

            Console.WriteLine("Review submitted successfully.");
        }










    }
}

    

