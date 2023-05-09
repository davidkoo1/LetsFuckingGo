﻿using appTutorial.Domain.Models;
using appTutorial.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace appTutorial.ViewModels
{
    public class TestsDitailsViewModel : ViewModelBase
    {
        private readonly SelectedTestStore _selectedTestStore;

        private Test SelectedTest => _selectedTestStore.SelectedTest;

        public bool HasSelectedTest => SelectedTest != null;

       // public int TestID => SelectedTest?.TestID ?? -1;
        public string Testname => SelectedTest?.Testname ?? "UnknowTestName";
        public string TestDiscription => SelectedTest?.TestDiscription ?? "UnknowTestDiscription";
        public int TestTime => SelectedTest?.TestTime ?? -1;
        public int AutorID => SelectedTest?.AutorID ?? -1;

        public TestsDitailsViewModel(SelectedTestStore selectedTestStore)
        {
            _selectedTestStore = selectedTestStore;

            _selectedTestStore.SelectedTestChanged += SelectedTestStore_SelectedTestChanged;
        }

        protected override void Dispose()
        {
            _selectedTestStore.SelectedTestChanged -= SelectedTestStore_SelectedTestChanged;

            base.Dispose();
        }
        private void SelectedTestStore_SelectedTestChanged()
        {
            OnPropertyChanged(nameof(HasSelectedTest));
           // OnPropertyChanged(nameof(TestID));
            OnPropertyChanged(nameof(Testname));
            OnPropertyChanged(nameof(TestDiscription));
            OnPropertyChanged(nameof(TestTime));
            OnPropertyChanged(nameof(AutorID));
        }
    }
}
