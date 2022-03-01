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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        /// <summary>
        /// В список записываем добавленные продукты(или блюда) что бы передать на первое окно в меню дня
        /// </summary>

        IngredientsInput ingredientsInput; 

        public Window1()
        {
            InitializeComponent();
            ingredientsInput = new IngredientsInput();
            tableIngredientsOrDishes.ItemsSource = ingredientsInput.IngredientLoad();
        }
        /// <summary>
        /// Добавить в текущий день свое меню(продукты или блюда)
        /// </summary>
        /// <param name="listProduct">Список продуктов которые есть в меню</param>
        /// <param name="enum">Какая из трапез(завтрак, обед и тд)</param>
        //public void AddListMyIngriedientOrDishes(out List<IngredientDb> listProduct, out EnumRepast @enum)
        //{

        //}

        private void buttonAddDish_Click(object sender, RoutedEventArgs e)
        {

            DishesDB dishesDB = new DishesDB();
            //textBlockDish.Text = dishesDB.Name + " " + dishesDB.ingredients + " " + dishesDB;

          
        }



        private void tableIngredientsOrDishes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            textBoxInputWeight.Text = "";
            //IngredientDb ingr = new IngredientDb();
            //ingr.Id = tableIngredientsOrDishes.CurrentCell;

            //listIngr.Add( = tableIngredientsOrDishes.CurrentCell.Column[0] = 
            //listIngr.Add(tableIngredientsOrDishes.CurrentCell as IngredientDb);
            IngredientDB ingr = (IngredientDB)tableIngredientsOrDishes.SelectedItem;
           // listIngr.Add(ingr);
        }


        private void buttonInputLineWithProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //if (listIngr != null)
                //{
                //   /// using (DataBaseFoodDiaryContext context = new DataBaseFoodDiaryContext())
                //    //{
                //       // context.IngredientDb.AddRange(listIngr);
                //  //  }
                //}
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textBoxProtein_MouseEnter(object sender, MouseEventArgs e)
        {
            textBoxProtein.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }


        /// <summary>
        /// Добавление записи в бд
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
    }
}
