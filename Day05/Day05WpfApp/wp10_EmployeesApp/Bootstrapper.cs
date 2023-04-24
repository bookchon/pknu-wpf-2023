using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using wp10_EmployeesApp.ViewModels;

namespace wp10_EmployeesApp
{
    // Caliburn으로 MVVM실행 시 주요설정 진행
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper() 
        { 
            Initialize(); // Caliburn MVVM 초기화
        }

        protected async override void OnStartup(object sender, StartupEventArgs e)
        {
            // base.OnStartup(sender, e);
            await DisplayRootViewForAsync<MainViewModel>();
        }
    }
}
