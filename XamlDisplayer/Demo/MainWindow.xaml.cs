//https://stackoverflow.com/questions/32690299/looping-through-all-nodes-in-xml-file-with-c-sharp\
//https://github.com/Xavalon/XamlStyler
namespace DisplayXamlDemo
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

    }
  }

  public class BoolToDisplayModeConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      var input = (bool)value;
      if (input)
      {
        return XamlDisplayer.DisplayModeEnum.TopBottom;
      }
      else
      {
        return XamlDisplayer.DisplayModeEnum.LeftRight;
      }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
