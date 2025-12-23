namespace MauiStepper
{
    public partial class MainPage : ContentPage
    {
        private double m_MyStepperValue;
        public MainPage()
        {
            InitializeComponent();

            m_MyStepperValue = 1;

            BindingContext = this;
        }

        public double MyStepperValue
        {
            get => m_MyStepperValue;
            set
            {
                m_MyStepperValue = value;

                OnPropertyChanged();
            }
        }
    }
}
