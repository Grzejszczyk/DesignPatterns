using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IViewModelBuilder
    {
        void Reset();
        Form Clone(in Form form);
        Form Build();
        void SetState(State state);
        void SetButtons(State state);
        void SetHeaderSection(string title);
        void SetBodySection(string body);
    }
}
