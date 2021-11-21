using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Button
    {
        string _buttonName;
        string _buttonText;
        bool _buttonIsActive;

        public Button(string name, string text, bool isActive)
        {
            _buttonName = name;
            _buttonText = text;
            _buttonIsActive = isActive;
        }

        public string ButtonName { get => _buttonName; }
        public string ButtonText { get => _buttonText; }
        public bool ButtonIsActive { get => _buttonIsActive; }

    }
}
