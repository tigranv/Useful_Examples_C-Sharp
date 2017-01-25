using System;
using System.Windows;

namespace MVPCalculate
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }
        # region События
        private EventHandler addEvent = null;
        private EventHandler subEvent = null;
        private EventHandler mulEvent = null;
        private EventHandler divEvent = null;

        public event EventHandler AddEvent
        {
            add { addEvent += value; }
            remove { addEvent -= value; }
        }

        public event EventHandler SubEvent
        {
            add { subEvent += value; }
            remove { subEvent -= value; }
        }

        public event EventHandler MulEvent
        {
            add { mulEvent += value; }
            remove { mulEvent -= value; }
        }

        public event EventHandler DivEvent
        {
            add { divEvent += value; }
            remove { divEvent -= value; }
        }
        #endregion

        #region Вызов методов подписаных на события
        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

       private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            addEvent.Invoke(sender, e);
        }

        private void SubButtonClick(object sender, RoutedEventArgs e)
        {
            subEvent.Invoke(sender, e);
        }

        private void MulButtonClick(object sender, RoutedEventArgs e)
        {
            mulEvent.Invoke(sender, e);
        }

        private void DivButtonClick(object sender, RoutedEventArgs e)
        {
            divEvent.Invoke(sender, e);
        }
        #endregion
    }
}
