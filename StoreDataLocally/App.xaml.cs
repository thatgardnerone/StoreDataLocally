using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreDataLocally;

public partial class App : Application
{
    private string dbPath => FileAccessHelper.GetLocalFilePath("people.db3");

    public static PersonRepository PersonRepository { get; set; }

    public App()
	{
		InitializeComponent();

        PersonRepository = new PersonRepository(dbPath);

        MainPage = new AppShell();
	}

    protected override void OnStart()
    {
        // Handle app start
    }
    protected override void OnSleep()
    {
        // Handle app sleep
    }
    protected override void OnResume()
    {
        // Handle app resume
    }
}
