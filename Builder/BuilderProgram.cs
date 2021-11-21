using System;

namespace Builder
{
    public class BuilderProgram
    {
        public static void Start()
        {
            IViewModelBuilder builder = new FormBuilder();

            builder.Reset();
            builder.SetHeaderSection("tytuł");
            builder.SetBodySection("body");
            builder.SetButtons(State.View);

            var form1 = builder.Build();

            Console.WriteLine("Form header:");
            Console.WriteLine(form1.Header);
            Console.WriteLine("Form body:");
            Console.WriteLine(form1.Body);
            Console.WriteLine("Form buttons:");
            foreach (var b in form1.Buttons)
            {
                Console.WriteLine($"Button 1: {b.ButtonText}, is active: {b.ButtonIsActive}");
            }
            Console.WriteLine();
            Console.WriteLine();


            builder.Reset();
            builder.SetHeaderSection("tytuł2");
            builder.SetBodySection("body2");
            builder.SetButtons(State.Create);

            var form2 = builder.Build();

            Console.WriteLine("Form header:");
            Console.WriteLine(form2.Header);
            Console.WriteLine("Form body:");
            Console.WriteLine(form2.Body);
            Console.WriteLine("Form buttons:");
            foreach (var b in form2.Buttons)
            {
                Console.WriteLine($"Button 1: {b.ButtonText}, is active: {b.ButtonIsActive}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
