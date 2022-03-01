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
        /// Записать значения цели(макимальная каллорийность, БЖУ в процентах )
        /// </summary>
        private void InputValueInTextBlockAimPercent()
        {
            textBoxCal.Text = aimInput.MaxCalories.ToString();
            textBoxProtein.Text = aimInput.ProteinPercent.ToString();
            TextBoxFat.Text = aimInput.FatPercent.ToString();
            TextBoxCar.Text = aimInput.CarbohydratePercent.ToString();
        }

        /// <summary>
        /// Записать значения цели(макимальная каллорийность, БЖУ в граммх)
        /// </summary>
        private void InputValueInTextBlockAimGram()
        {
            textBlockAim.Text = aimInput.MaxCalories.ToString();
            textBlockMaxProtein.Text = aimInput.ProteinGram.ToString();
            textBlockMaxFlat.Text = aimInput.FatGram.ToString();
            textBlockMaxUglev.Text = aimInput.CarbohydrateGram.ToString();
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
        }
       

        private void buttonAddDish1_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
        /// <summary>
        /// Сохранение значения цели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAim_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                aimInput = new AimInput(int.Parse(textBoxCal.Text), int.Parse(textBoxProtein.Text), int.Parse(TextBoxFat.Text), int.Parse(TextBoxCar.Text));
                InputValueInTextBlockAimGram();
                MessageBox.Show("Запись сохранена!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddDish2_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void buttonAddDish3_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void buttonAddDish4_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}
