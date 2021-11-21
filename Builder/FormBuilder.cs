using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FormBuilder : IViewModelBuilder
    {
        private Form _form;

        public Form Build()
        {
            if (FormIsComplete())
            {
                return _form;
            }

            return null;
        }

        private bool FormIsComplete()
        {
            return true;
        }

        public Form Clone(in Form form)
        {
            var f = new Form()
            {
                Body = new StringBuilder(_form.Body).ToString(),
                Header = new StringBuilder(_form.Header).ToString(),
                Buttons = new List<Button>()
            };

            for (int i = 0; i < _form.Buttons.Count; i++)
            {
                f.Buttons.Add(new(_form.Buttons[i].ButtonName, _form.Buttons[i].ButtonText, _form.Buttons[i].ButtonIsActive));
            }

            return f;
        }

        public void Reset()
        {
            _form = new();
        }

        public void SetBodySection(string body)
        {
            _form.Body = body;
        }

        public void SetButtons(State state)
        {
            _form.Buttons = new List<Button>();
            _form.Buttons.Add(new Button("OK", "Accept", state is State.Create or State.Edit));
            _form.Buttons.Add(new Button("Cancel", "Cancel", true));
        }

        public void SetHeaderSection(string title)
        {
            _form.Header = title;
        }

        public void SetState(State state)
        {
            _form.State = state;
        }
    }
}
