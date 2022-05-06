using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreDataLocally;

public partial class App : Application
{
	string dbPath => FileAccessHelper.GetLocalFilePath("people.db3");

	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
