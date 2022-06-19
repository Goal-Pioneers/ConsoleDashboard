using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CDash
{
    internal class Application
    {
        public void initialise()
        {

        }

        public void execution()
        {

        }

        public void gc()
        {

        }


        public static void run()
        {
            Application application = new Application();

            application.initialise();
            application.execution();
            application.gc();
        }
    }
}
