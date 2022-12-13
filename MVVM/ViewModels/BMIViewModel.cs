namespace BMI.MVVM.ViewModels
{
    public class BMIViewModel
    {
        public Models.BMI BMI { get; set; }

        public BMIViewModel()
        {
            BMI = new()
            {
                Weight = 80,
                Height = 174
            };
        }
    }
}
