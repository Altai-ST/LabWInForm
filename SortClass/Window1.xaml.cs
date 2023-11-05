using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SortClass
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            comboSort.ItemsSource = new SortItem[]
        {
            new SortItem { Name = "Блинная сортировка" },
            new SortItem { Name = "Рандомная сортировка" },
            new SortItem { Name = "Циклическая сортировка" }
        };
           
            comboSort.SelectedIndex = 0;
        }

        private void ChangeItem(object sender, SelectionChangedEventArgs e)
        {
            if (comboSort.SelectedValue is { })
            {
                nameSort.Text = comboSort.SelectedValue.ToString();
                if(infoMode.IsChecked.Value && !sortMode.IsChecked.Value)
                {
                    switch (comboSort.SelectedIndex)
                    {
                         case 0:
                            discription.Text = "это необычный метод сортировки массива, который заключается в том, чтобы \"переворачивать\" элементы массива так, чтобы наибольший элемент находился в правильной позиции. Процесс поворота элементов похож на переворачивание блинцов в стопке.";
                            Uri backgroundImageUri = new Uri("D:\\FormImg#1\\BackPancake.jpg");
                            ImageBrush imageBrush = new ImageBrush(new BitmapImage(backgroundImageUri));
                            bgChanger.Background = imageBrush;
                            break;
                         case 1:
                            discription.Text = " это алгоритм сортировки, который использует случайные операции для перестановки элементов в массиве в попытке упорядочить их. Каждая итерация алгоритма случайным образом выбирает пару элементов и меняет их местами.";
                            Uri backgroundImageUri2 = new Uri("D:\\FormImg#1\\randomBack.jpeg");
                            ImageBrush imageBrush2 = new ImageBrush(new BitmapImage(backgroundImageUri2));
                            bgChanger.Background = imageBrush2;
                            break;
                         case 2:
                            discription.Text = "это алгоритм сортировки, который работает путем нахождения циклов перестановок в массиве и последовательной коррекции этих циклов, пока все элементы не окажутся на своих правильных позициях.";
                            Uri backgroundImageUri3 = new Uri("D:\\FormImg#1\\cycleBack.jpg");
                            ImageBrush imageBrush3 = new ImageBrush(new BitmapImage(backgroundImageUri3));
                            bgChanger.Background = imageBrush3; 
                            break;
                    }
                }else if (sortMode.IsChecked.Value)
                {

                }
                
            }
        }

        private void generateArr(object sender, RoutedEventArgs e)
        {
            string inputText = sizeArr.Text;

            // Попробуйте преобразовать введенный текст в число
            if (int.TryParse(inputText, out int arraySize))
            {
                // Теперь у вас есть размер массива, и вы можете создать массив
                int[] arr = PancakeSort.NotSortArr(arraySize);
                if (comboSort.SelectedIndex == 0 && arr != null && arraySize <= 20)
                {
                    stepSort.ItemsSource = new String[]
                    {
                    "1. Начните с исходного массива, который нужно отсортировать.",
                    "2. Найдите наибольший элемент в несортированной части массива.",
                    "3. Поверните массив так, чтобы этот наибольший элемент стал первым элементом (выше всех остальных).",
                    "4. Теперь поверните весь массив так, чтобы наибольший элемент стал последним в несортированной части массива.",
                    "5. Повторяйте этот процесс поиска наибольшего элемента и поворота массива до тех пор, пока весь массив не будет отсортирован."
                    };
                    notSortText.Content = string.Join(", ", arr);
                    arr = PancakeSort.PanSort(arr);
                    sortText.Content = string.Join(", ", arr);
                    errorSize.Content = "";
                }
                else if (comboSort.SelectedIndex == 1 && arr != null && arraySize <= 20)
                {
                    stepSort.ItemsSource = new String[]
                    {
                    "1. Начинается с выбора неотсортированного элемента в массиве.",
                    "2. Затем находится цикл перестановок, перемещаясь от текущего элемента до исходного.",
                    "3. Когда цикл завершается, массив считается частично отсортированным, и процесс повторяется для остальных неотсортированных элементов.",
                    "4. Алгоритм продолжает итерации до тех пор, пока все элементы не окажутся на своих правильных позициях."
                    };

                    notSortText.Content = string.Join(", ", arr);

                    arr = Class1.RandSort(arr);

                    sortText.Content= string.Join(", ", arr);
                    errorSize.Content = "";
                }
                else if (comboSort.SelectedIndex == 2 && arr != null && arraySize <= 20)
                {
                    stepSort.ItemsSource = new String[]
                    {
                    "1. Начните с неотсортированного массива.",
                    "2. Выберите два случайных элемента в массиве и поменяйте их местами. Это действие называется \"перестановкой\" или \"тасованием\".",
                    "3. Повторяйте шаг 2 до тех пор, пока массив не станет отсортированным (что может занять множество случайных перестановок)."
                    };

                    notSortText.Content = string.Join(", ", arr);

                    arr = Class2.CycleSortFn(arr);

                    sortText.Content = string.Join(", ", arr);
                    errorSize.Content = "";
                }
                else
                {
                    errorSize.Content = "Ошибка превышен размер массива. Он должен быть меньше 20";
                }
            }

        }
    }
    
}
public class SortItem
    {
        public string Name { get; set; } = "";
        public override string ToString() => $"{Name}";
    }

