﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VSEmbed;

namespace VSEmbed.DemoApp {
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application {
		public App() {
			VsLoader.Load(new Version(15, 0, 0, 0));
			VsServiceProvider.Initialize();
			BuildContainer();
		}
		// Must be JITted after VsLoader.Load so we can load ComponentModelHost
		void BuildContainer() { 
			VsMefContainerBuilder.CreateDefault().Build();
		}
		protected override void OnStartup(StartupEventArgs e) {
			base.OnStartup(e);
		}
	}
}
