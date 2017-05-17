﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using tinyERP.Dal;
using tinyERP.Dal.Entities;
using tinyERP.UI.Factories;
using tinyERP.UI.Views;

namespace tinyERP.UI.ViewModels
{
    class EditTemplateViewModel : ViewModelBase
    {
        private string _offer;
        private string _confirmation;
        private string _invoice;
        private RelayCommand _uploadTemplateCommand;
        private RelayCommand _chooseFileCommand;

        public EditTemplateViewModel(IUnitOfWorkFactory factory) : base(factory)
        {
        }

        public const string OfferTemplateType = "Offer";
        public const string ConfirmationTemplateType = "Confirmation";
        public const string InvoiceTemplateType = "Invoice";

        public string Offer
        {
            get { return _offer; }
            set { SetProperty(ref _offer, value, nameof(Offer)); }
        }

        public string Confirmation
        {
            get { return _confirmation; }
            set { SetProperty(ref _confirmation, value, nameof(Confirmation)); }
        }

        public string Invoice
        {
            get { return _invoice; }
            set { SetProperty(ref _invoice, value, nameof(Invoice)); }
        }
        public override void Load()
        {
            
        }

        #region Upload-Template-Command

        public ICommand UploadTemplateCommand
        {
            get { return _uploadTemplateCommand ?? (_uploadTemplateCommand = new RelayCommand(UploadTemplate, CanUploadTemplate)); }
        }

        private void UploadTemplate(object templateType)
        {
            var template = (string)templateType;

            switch (template)
            {
                case OfferTemplateType:
                    FileAccess.Add(Offer, FileAccess.TemplatePath);
                    break;
                case ConfirmationTemplateType:
                    FileAccess.Add(Confirmation, FileAccess.TemplatePath);
                    break;
                case InvoiceTemplateType:
                    FileAccess.Add(Invoice, FileAccess.TemplatePath);
                    break;
                default:
                    throw new ArgumentException("Invalid Template Instance");
            }
        }

        private bool CanUploadTemplate(object filePath)
        {
            // ReSharper disable once PossibleNullReferenceException - won't be null, because of prior condition
            return filePath != null;
        }

        #endregion

        #region ChooseFile-Command

        public ICommand ChooseFileCommand
        {
            get { return _chooseFileCommand ?? (_chooseFileCommand = new RelayCommand(ChooseFile)); }
        }

        private void ChooseFile(object templateType)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                if (templateType == null)
                {
                    MessageBox.Show("oops");
                }
                else
                {
                    var template = (string) templateType;
                    switch (template)
                    {
                        case OfferTemplateType:
                            Offer = openFileDialog.FileName;
                            break;
                        case ConfirmationTemplateType:
                            Confirmation = openFileDialog.FileName;
                            break;
                        case InvoiceTemplateType:
                            Invoice = openFileDialog.FileName;
                            break;
                        default:
                            throw new ArgumentException("Invalid Template Instance");
                    }
                }
            }
        }

        #endregion


    }
}
