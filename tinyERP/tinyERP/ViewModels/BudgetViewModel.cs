﻿using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MahApps.Metro;
using System.ComponentModel;

namespace tinyERP.UI.ViewModels
{
    class BudgetViewModel : ViewModelBase
    {
        public ObservableCollection<BudgetView> BudgetViews { get; set; }

        public BudgetViewModel()
        {

        }
        public override void Load()
        {
            BudgetViews = new ObservableCollection<BudgetView>
            {
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0),
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0),
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0),
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0),
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0),
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0),
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0),
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0),
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0),
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0),
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0),
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0),
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Drucker", new DateTime(2017, 03, 10), "Büromaterial", 50),
                new BudgetView(100.00, "Schreibmaterial", new DateTime(2017, 03, 12), "Büromaterial", 0)
            };
        }

        #region New-Command

        private RelayCommand newCommand;

        public ICommand NewCommand
        {
            get
            {
                return newCommand ?? (newCommand = new RelayCommand(param => New(), param => CanNew()));
            }
        }

        private void New()
        {
            //TODO: Add new Transaction
        }

        private bool CanNew()
        {
            //TODO: CanNew()
            return true;
        }

        #endregion
    }
    public class BudgetView
    {
        public BudgetView(double amount, string categorie, DateTime date, string description, int privatpart)
        {
            Amount = amount;
            Categorie = categorie;
            Date = date;
            Description = description;
            Privatpart = privatpart;
        }

        public double Amount { get; set; }
        public string Categorie { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Privatpart { get; set; }
    }
}
