using System;

namespace MVP_StopWatch
{
    class Presenter
    {
        private readonly Model model;
        private readonly Form1 view;
        
        public Presenter(Form1 v)
        {
            model = new Model();
            view = v;
            view.Start += ViewStart;
            view.Stop += ViewStop;
            view.Reset += ViewReset;
            view.timer1.Tick += TimerTick;
            view.timer1.Start();
            view.timer1.Enabled = false;

        }

        #region Event handler
        void ViewReset(object sender, EventArgs e)
        {
            view.timer1.Stop();
            view.SecondsTextBox.Clear();
            model.Reset();
        }

        private void ViewStop(object sender, EventArgs e)
        {
            view.timer1.Enabled = false;
        }

        private void ViewStart(object sender, EventArgs e)
        {
            view.timer1.Enabled = true;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            view.SecondsTextBox.Text = model.Tick();
        }
        #endregion

    }
}
