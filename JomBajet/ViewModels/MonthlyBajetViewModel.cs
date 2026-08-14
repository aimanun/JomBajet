using System;
using Prism.Commands;
using Prism.Mvvm;

namespace JomBajet.ViewModels
{
    public class MonthlyBajetViewModel : BindableBase
    {
        private int netSalary;
        public int NetSalary
        {
            get { return netSalary; }
            set { SetProperty(ref netSalary, value); }
        }

        private int commitment;
        public int Commitment
        {
            get { return commitment; }
            set { SetProperty(ref commitment, value); }
        }

        private int spending;
        public int Spending
        {
            get { return spending; }
            set { SetProperty(ref spending, value); }
        }

        private int saving;
        public int Saving
        {
            get { return saving; }
            set { SetProperty(ref saving, value); }
        }

        private int commitmentSplit;
        public int CommitmentSplit
        {
            get { return commitmentSplit; }
            set { SetProperty(ref commitmentSplit, value); }
        }

        private int spendingSplit;
        public int SpendingSplit
        {
            get { return spendingSplit; }
            set { SetProperty(ref spendingSplit, value); }
        }

        private int savingSplit;
        public int SavingSplit
        {
            get { return savingSplit; }
            set { SetProperty(ref savingSplit, value); }
        }

        private bool enableCustomise;
        public bool EnableCustomise
        {
            get { return enableCustomise; }
            set
            {
                SetProperty(ref enableCustomise, value);
                FiftyCommand.RaiseCanExecuteChanged();
                SeventyCommand.RaiseCanExecuteChanged();
            }
        }

        public DelegateCommand FiftyCommand { get; }
        public DelegateCommand SeventyCommand { get; }
        public DelegateCommand ConfirmCommand { get; }
        public DelegateCommand AddCommand { get; }
        public DelegateCommand RemoveAllCommand { get; }

        public MonthlyBajetViewModel()
        {
            FiftyCommand = new DelegateCommand(Fifty, DisableDefaultSplit);
            SeventyCommand = new DelegateCommand(Seventy, DisableDefaultSplit);
            ConfirmCommand = new DelegateCommand(Confirm);
            AddCommand = new DelegateCommand(Add);
            RemoveAllCommand = new DelegateCommand(RemoveAll);
        }

        private void RemoveAll()
        {
            throw new NotImplementedException();
        }

        private void Add()
        {
            throw new NotImplementedException();
        }

        private bool DisableDefaultSplit() => EnableCustomise is false;

        private void Seventy()
        {
            Commitment = NetSalary * 70 / 100;
            Spending = NetSalary * 20 / 100;
            Saving = NetSalary * 10 / 100;
        }

        private void Fifty()
        {
            Commitment = NetSalary * 50/100;
            Spending = NetSalary * 30/100;
            Saving = NetSalary * 20/100;
        }

        private void Confirm()
        {
            if (CommitmentSplit + SpendingSplit + SavingSplit == 100)
            {
                Commitment = NetSalary * commitmentSplit / 100;
                Spending = NetSalary * SpendingSplit / 100;
                Saving = NetSalary * SavingSplit / 100;
            }
        }
    }
}
