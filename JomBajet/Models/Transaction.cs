using Microsoft.VisualBasic;
using Prism.Mvvm;

namespace JomBajet.Models
{
    public class Transaction : BindableBase

    {
        private int id;
        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }

        private string name;
        public string Name  
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private float amount;
        public float Amount
        {
            get { return amount; }
            set { SetProperty(ref amount, value); }
        }

        private int cateogryID;
        public int CategoryID
        {
            get { return cateogryID; }
            set { SetProperty(ref cateogryID, value); }
        }

        private DateAndTime date;
        public DateAndTime Date
        {
            get { return date; }
            set { SetProperty(ref date, value); }
        }

        private string notes;
        public string Notes
        {
            get { return notes; }
            set { SetProperty(ref notes, value); }
        }
    }
}
