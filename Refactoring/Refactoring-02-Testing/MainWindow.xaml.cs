using Refactoring_02_Testing_Library;
using Refactoring_02_Testing_Library.DTO;
using System.Windows;
using System.Windows.Controls;

namespace Refactoring_02_Testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Province _province;

        public MainWindow()
        {
            InitializeComponent();

            _province = new Province(ProvinceData.SampleProvinceData());

            UpdateProvinceUI();
        }

        private void UpdateProvinceUI()
        {
            ProvinceNameText.Content = _province.Name;
            DemandText.Text = _province.Demand.ToString();
            PriceText.Text = _province.Price.ToString();

            ProducersListbox.Items.Clear();
            _province.Producers.ForEach(p =>
            {
                StackPanel stackPanel = new()
                {
                    Orientation = Orientation.Horizontal
                };

                Label label1 = new()
                {
                    Content = p.Name
                };
                stackPanel.Children.Add(label1);

                Label label2 = new()
                {
                    Content = "Cost:"
                };
                stackPanel.Children.Add(label2);

                TextBox textBox1 = new()
                {
                    Width = 100,
                    Text = p.Cost.ToString()
                };
                stackPanel.Children.Add(textBox1);

                Label label3 = new()
                {
                    Content = "Production:"
                };
                stackPanel.Children.Add(label3);

                TextBox textBox2 = new()
                {
                    Width = 100,
                    Text = p.Production.ToString()
                };
                stackPanel.Children.Add(textBox2);

                Label label4 = new()
                {
                    Content = "Full Revenue:"
                };
                stackPanel.Children.Add(label4);

                Label label5 = new()
                {
                    Content = p.Cost * p.Production
                };
                stackPanel.Children.Add(label5);

                ListBoxItem listBoxItem = new()
                {
                    Content = stackPanel
                };

                ProducersListbox.Items.Add(listBoxItem);
            });

            ShortfallText.Text = _province.Shortfall().ToString();
            ProfitText.Text = _province.Profit().ToString();
        }

        private void DemandText_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (int.TryParse(e.Text, out int demand))
            {
                _province.Demand = demand;
                UpdateProvinceUI();
            }
        }
    }
}