using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using NoteKeeper.Models;
using NoteKeeper.ViewModels;
using System.Collections.Generic;
using NoteKeeper.Services;

namespace NoteKeeper.Views
{
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            this.viewModel = viewModel;
            BindingContext = this.viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
        }

        private void Cancel_clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void Save_clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "SaveNote", viewModel.Note);

            Navigation.PopModalAsync();
        }
    }
}