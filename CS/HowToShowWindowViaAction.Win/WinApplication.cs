using DevExpress.ExpressApp.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;

namespace HowToShowWindowViaAction.Win {
	public partial class HowToShowWindowViaActionWindowsFormsApplication : WinApplication {
        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            args.ObjectSpaceProvider = new XPObjectSpaceProvider(args.ConnectionString, args.Connection);
        }
		public HowToShowWindowViaActionWindowsFormsApplication() {
			InitializeComponent();
            InitializeDefaults();
        }
        private void InitializeDefaults() {
            LinkNewObjectToParentImmediately = false;
            OptimizedControllersCreation = true;
            UseLightStyle = true;
            ExecuteStartupLogicBeforeClosingLogonWindow = true;
        }
        private void HowToShowWindowViaActionWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
			if(System.Diagnostics.Debugger.IsAttached) {
				e.Updater.Update();
				e.Handled = true;
			}
			else {
				throw new InvalidOperationException(
					"The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application.\r\n" +
					"The automatical update is disabled, because the application was started without debugging.\r\n" +
					"You should start the application under Visual Studio, or modify the " +
					"source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " +
					"or manually create a database with the help of the 'DBUpdater' tool.");
			}
		}
	}
}
