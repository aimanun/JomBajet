using Prism.Mvvm;

namespace JomBajet.Models
{
    public class Commitment : BindableBase
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

        private int typeId;
        public int TypeId
        {
            get { return typeId; }
            set { SetProperty(ref typeId, value); }
        }

        private string remarks;
        public string Remarks
        {
            get { return remarks; }
            set { SetProperty(ref remarks, value); }
        }
    }
}
