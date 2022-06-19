using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DashboardEngine;


namespace CDash
{
    internal class Application
    {
        public Application()
        {

        }

        public void initialise()
        {
            
        }

        public void execution()
        {

        }

        public void gc()
        {

        }

        private Dashboard _dashboard = null;

        public Dashboard Dashboard
        {
            get
            {
                return this._dashboard;
            }
            set
            {
                this._dashboard = value;
            }
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
