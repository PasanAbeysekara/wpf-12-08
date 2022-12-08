namespace dec_eight.ViewModels
{
    public class ModelBindingVm
    {
        public ModelBindingVm()
        {
            FirstName = "Tom";
            LastName = "Brown";
            Age = 35;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}