using Config.Net;

namespace ConfigINPCTesting
{
    public partial class Form1 : Form
    {
        IMySettings mySettings;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mySettings = new ConfigurationBuilder<IMySettings>()
                .UseInMemoryDictionary()
                .Build();

            textBox1.DataBindings.Add("Text", mySettings, "Setting1");

            mySettings.PropertyChanged += MySettings_PropertyChanged;
        }

        private void MySettings_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySettings.Setting1 += "1";
        }
    }
}