
using System.ComponentModel;

namespace ATTObsolete
{
    public class BrowsableExample
    {
        //will be visible and editable in design-time property grids
        [Browsable(true)]
        public string Name { get; set; }

        //will not be visible and editable in design-time property grids
        [Browsable(false)]
        public int Age { get; set; }
    }
}
