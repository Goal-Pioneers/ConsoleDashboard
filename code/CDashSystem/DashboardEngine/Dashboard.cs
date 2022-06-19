namespace DashboardEngine
{
    public class Dashboard
    {
        public Dashboard()
        {

        }

        public void start()
        {

        }

        private bool _continue = true;


        public bool Continue
        {
            get
            {
                return this._continue;
            }
            set
            {
                this._continue = value;
            }
        }
    }
}