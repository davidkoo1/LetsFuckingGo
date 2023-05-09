using appTutorial.Domain.Commands;
using appTutorial.Domain.Queries;
using appTutorial.EntityFramework;
using appTutorial.EntityFramework.Commands;
using appTutorial.EntityFramework.Queries;
using appTutorial.Stores;
using appTutorial.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace appTutorial
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedTestStore _selectedTestStore;
        private readonly SelectedUserStore _selectedUserStore;
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly TestsStore _testStore;
        private readonly TestsDbContextFactory _testsDbContextFactory;
        private readonly IGetAllTestsQuery _getAllTestsQuery;
        private readonly ICreateTestCommand _createTestCommand;
        private readonly IUpdateTestCommand _updateTestCommand;
        private readonly IDeleteTestCommand _deleteTestCommand;


        public App()
        {
            string connectionString = "Data Source=appTutotial.db";

            _testStore = new TestsStore(_getAllTestsQuery, _createTestCommand, _updateTestCommand, _deleteTestCommand);
            _modalNavigationStore = new ModalNavigationStore();
            _selectedTestStore = new SelectedTestStore(_testStore);
            _selectedUserStore = new SelectedUserStore();
            _testsDbContextFactory = new TestsDbContextFactory(new DbContextOptionsBuilder().UseSqlite(connectionString).Options);
            _getAllTestsQuery = new GetAllTestsQuery(_testsDbContextFactory);
            _createTestCommand = new CreateTestCommand(_testsDbContextFactory);
            _updateTestCommand = new UpdateTestCommand(_testsDbContextFactory);
            _deleteTestCommand = new DeleteTestCommand(_testsDbContextFactory);
            
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            using(TestsDbContext context = _testsDbContextFactory.Create())
            {
                context.Database.Migrate();
            }

            TestsViewModel testsViewModel = new TestsViewModel(_testStore, _selectedTestStore, _modalNavigationStore);
            UsersViewModel usersViewModel = new UsersViewModel(_selectedUserStore, _modalNavigationStore);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, testsViewModel, usersViewModel),
                //DataContext = usersViewModel

            };
            MainWindow.Show();
            base.OnStartup(e);  
        }
    }
}
