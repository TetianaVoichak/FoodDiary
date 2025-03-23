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
using System.Windows.Shapes;
using FoodDiary.Presenter;
using System.Linq;

namespace FoodDiary
{
    /// <summary>
    /// Interaction logic for WindowRepast.xaml
    /// </summary>
    public partial class WindowRepast : Window
    {
        /// <summary>
        /// We add the added products (or dishes) to the list to transfer to the first window
        /// in the menu of the day
        /// </summary>

        IngredientsInput ingredientsInput;
        EnumRepast currentRepast;
        DateTime currentDate;
        Repastes repastes;

        public WindowRepast()
        {
            InitializeComponent();
            ingredientsInput = new IngredientsInput();
            tableIngredientsOrDishes.ItemsSource = ingredientsInput.IngredientLoad();
        }
        public WindowRepast(EnumRepast er, DateTime d)
        {
            InitializeComponent();
            currentRepast = er;
            currentDate = d;
            ingredientsInput = new IngredientsInput();
            tableIngredientsOrDishes.ItemsSource = ingredientsInput.IngredientLoad();

        }
        private void buttonAddDish_Click(object sender, RoutedEventArgs e)
        {
            DishesDB dishesDB = new DishesDB();
        }

        private void tableIngredientsOrDishes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            textBoxInputWeight.Text = "";
            IngredientDB ingr = (IngredientDB)tableIngredientsOrDishes.SelectedItem;
        }


        private void buttonInputLineWithProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Repastes repastes = new Repastes();
                repastes.IdProduct = int.Parse(tableIngredientsOrDishes.CurrentItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxProtein_MouseEnter(object sender, MouseEventArgs e)
        {
            textBoxProtein.Text = "";
        }


        /// <summary>
        /// Adding a record to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                ingredientsInput.AddIngredients(textBoxName.Text, Convert.ToSingle(textBoxProtein.Text), Convert.ToSingle(textBoxFat.Text), Convert.ToSingle(textBoxCarb.Text));
                tableIngredientsOrDishes.ItemsSource = ingredientsInput.IngredientLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Deleting a record from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                ingredientsInput.RemoveIngredient((IngredientDB)tableIngredientsOrDishes.SelectedItem);
                tableIngredientsOrDishes.ItemsSource = ingredientsInput.IngredientLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
