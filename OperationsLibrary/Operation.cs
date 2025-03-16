using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OperationsLibrary
{

    public interface Iedit
    {
        void EditFile(string filePath, string newContent);
    }

    public class Edit : Iedit
    {
        public void EditFile(string x, string z)
        {

        }
    }
}
