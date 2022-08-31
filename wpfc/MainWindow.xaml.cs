using GerenciamentoFuncionario.AcessoDados;
using GerenciamentoFuncionario.ViewModel;
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

namespace wpfc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           

            InitializeComponent();
            _viewModel = new MainWindowViewModel(
                new FuncionarioProvedorDados(),
                new CargoProvedorDados()
                );

            Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RouterEventArgs e) { 
            _viwlModel.Carregar()
        }
    }
}
