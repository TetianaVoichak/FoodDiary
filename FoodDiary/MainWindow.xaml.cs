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
using FoodDiary.Presenter;
using FoodDiary.Model;

namespace FoodDiary
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DishesDB dishes;
        IngredientsInput ingredients;
        AimInput aimInput;

        public MainWindow()
        {
            InitializeComponent();
            textBlockDateToday.Text = DateTime.Now.Date.ToShortDateString();
            aimInput = new AimInput();
            InputValueInTextBlockAimGram();
            InputValueInTextBlockAimPercent();
        }


        /// <summary>
        /// enter the target values ​​(Maximum calories, 
        /// PFC(proteins, fats, carbohydrates) in percentages)
        /// </summary>
        private void InputValueInTextBlockAimPercent()
        {
            textBoxCal.Text = aimInput.MaxCalories.ToString();
            textBoxProtein.Text = aimInput.ProteinPercent.ToString();
            TextBoxFat.Text = aimInput.FatPercent.ToString();
            TextBoxCar.Text = aimInput.CarbohydratePercent.ToString();
        }

        /// <summary>
        /// enter the target values​​(Maximum calories, 
        /// PFC(proteins, fats, carbohydrates) in grams)
        /// </summary>
        private void InputValueInTextBlockAimGram()
        {
            textBlockAim.Text = aimInput.MaxCalories.ToString();
            textBlockMaxProtein.Text = aimInput.ProteinGram.ToString();
            textBlockMaxFlat.Text = aimInput.FatGram.ToString();
            textBlockMaxUglev.Text = aimInput.CarbohydrateGram.ToString();
        }


        /// <summary>
        /// A number of actions will add breakfast
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDish1_Click(object sender, RoutedEventArgs e)
        {
            WindowRepast window1 = new WindowRepast(EnumRepast.breakfast, elementChoiseDate.DisplayDate);
            window1.Show();

        }
        /// <summary>
        /// Saving the value of the goal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAim_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                aimInput = new AimInput(int.Parse(textBoxCal.Text), int.Parse(textBoxProtein.Text), int.Parse(TextBoxFat.Text), int.Parse(TextBoxCar.Text));
                InputValueInTextBlockAimGram();
                MessageBox.Show("The entry has been saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// A number of actions will add lanch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDish2_Click(object sender, RoutedEventArgs e)
        {
            WindowRepast window1 = new WindowRepast(EnumRepast.lanch, elementChoiseDate.DisplayDate);
            window1.Show();
        }
        /// <summary>
        /// A number of actions will add dinner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDish3_Click(object sender, RoutedEventArgs e)
        {
            WindowRepast window1 = new WindowRepast(EnumRepast.dinner, elementChoiseDate.DisplayDate);
            window1.Show();
        }
        /// <summary>
        /// A number of actions will add dinner evening
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddDish4_Click(object sender, RoutedEventArgs e)
        {
            WindowRepast window1 = new WindowRepast(EnumRepast.dinnerEvening, elementChoiseDate.DisplayDate);
            window1.Show();

        }
    }
}
