using _8GroupAssignment.Main;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CS3280GroupProject.Main
{
    /// <summary>
    /// Interaction logic for wndMain.xaml
    /// </summary>
    public partial class wndMain : Window
    {

        /// <summary>
        /// Main Logic Object Declaration
        /// </summary>
        private clsMainLogic ML;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public wndMain()
        {
            try
            {
                InitializeComponent();
                ML = new clsMainLogic();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void HandleError(string name1, string name2, string message)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// OnClick handler of the AddInvoice Button
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event object</param>
        private void AddInvoiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Make the NewInvoice and InvoiceDetail grids visible
                InvoiceDetailGrid.Visibility = Visibility.Visible;
                NewInvoiceGrid.Visibility = Visibility.Visible;

                //Retrieve the active StackPanel style and apply it to the button stack panel
                Style st = (Style)this.FindResource("StackPanelActive");

                InvoiceBtnStack.Style = st;

                AddInvoiceBtn.IsEnabled = false;
                EditInvoiceBtn.IsEnabled = false;
                DeleteInvoiceBtn.IsEnabled = false;


                //Initialise ui elements
                ItemCmb.SelectedIndex = -1;
                QuantityBox.Text = "1";
                DateBox.Text = "";


            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// OnClick handler for the EditInvoice Button
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event object</param>
        private void EditInvoiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Toggle disabled status of various ui elements
                NewInvoiceGrid.Visibility = Visibility.Visible;
                ItemListMenu.IsEnabled = false;
                DateBox.IsEnabled = true;
                QuantityBox.IsEnabled = true;
                AddInvoiceBtn.IsEnabled = false;
                EditInvoiceBtn.IsEnabled = false;
                DeleteInvoiceBtn.IsEnabled = false;
                SaveInvoiceBtn.IsEnabled = true;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        
    }
}
