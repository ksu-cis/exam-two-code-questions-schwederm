using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the all radio button clicks and changes the size of the CowboyCoffee.
        /// </summary>
        /// <param name="sender">The radio button clicked</param>
        /// <param name="e">The event argument</param>
        private void RadioButtonClick(object sender, RoutedEventArgs e)
        {
            Cobbler cobbler = DataContext as Cobbler;
            switch (((RadioButton)sender).Name)
            {
                case "PeachRB":
                    cobbler.Fruit = FruitFilling.Peach;
                    break;
                case "CherryRB":
                    cobbler.Fruit = FruitFilling.Cherry;
                    break;
                case "BlueberryRB":
                    cobbler.Fruit = FruitFilling.Blueberry;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
