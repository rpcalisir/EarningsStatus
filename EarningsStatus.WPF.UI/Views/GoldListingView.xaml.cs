using EarningsStatus.WPF.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EarningsStatus.WPF.UI.Views
{
    /// <summary>
    /// Interaction logic for GoldListinView.xaml
    /// </summary>
    public partial class GoldListingView : UserControl
    {
        private readonly GoldListingViewModel goldListingViewModel;
        public GoldListingView()
        {
            InitializeComponent();
            goldListingViewModel = new GoldListingViewModel();
            this.dgGoldListingView.ItemsSource = goldListingViewModel.Golds;
        }

        private void dgGoldListingView_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            int zeroBasedIndex = Convert.ToInt32((e.Row.GetIndex()).ToString());
            e.Row.Header = zeroBasedIndex + 1;
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {

        }
    }
}
