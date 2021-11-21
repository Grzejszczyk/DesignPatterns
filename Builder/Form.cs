using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Form
    {
        State _state;
        string _header;
        string _body;
        List<Button> _buttons;

        public State State { get => _state; set { _state = value; } }
        public string Header { get => _header; set { _header = value; } }
        public string Body { get => _body; set { _body = value; } }
        public List<Button> Buttons { get => _buttons; set { _buttons = value; } }
    }
}
