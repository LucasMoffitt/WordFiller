using System.Collections.Generic;
using System.Windows.Forms;

namespace WordFiller.Framework
{
    internal class ManageWindows
    {
        private static List<Form> _forms = new List<Form>();

        public static List<Form> Forms
        {
            get { return _forms; }
        }
    }
}
