﻿using LoginPage.Models;
using LoginPage.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginPage.ViewModels
{
    public class ContactsPageViewModel : INotifyPropertyChanged
    {
        public Contact contact { get; set; } = new Contact();
        public ICommand AddItem { get; set; } 

        public ContactsPageViewModel()
        {
            AddItem = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new AddContactPage());
            });
        }
       // public ICommand 
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
