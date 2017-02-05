namespace MVP_StopWatch
{
    class Model
    {
        private int s;
       
        public string Tick()
        {
            s++;
            return s >= 60 ? (s/60) + " min " + s%60 + " sec" : s.ToString();
        }
        public void Reset()
        {
            s = 0;
        }

    }
}
