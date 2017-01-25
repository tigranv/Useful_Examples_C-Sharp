using System;

namespace MVPCalculate
{
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;

        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.AddEvent += MainWindowAdd;
            this.mainWindow.SubEvent += MainWindowSub;
            this.mainWindow.MulEvent += MainWindowMul;
            this.mainWindow.DivEvent += MainWindowDiv;
        }

        #region Event handler 
        void MainWindowAdd(object sender, EventArgs e)
        {
            string variable = model.Add(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                        Convert.ToInt32(mainWindow.Operand2_textBox.Text));
            mainWindow.Result_textBox.Text = variable;
        }
        void MainWindowSub(object sender, EventArgs e)
        {
            string variable = model.Sub(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                        Convert.ToInt32(mainWindow.Operand2_textBox.Text));
            mainWindow.Result_textBox.Text = variable;
        }
        void MainWindowMul(object sender, EventArgs e)
        {
            string variable = model.Multi(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                          Convert.ToInt32(mainWindow.Operand2_textBox.Text));
            mainWindow.Result_textBox.Text = variable;
        }
        void MainWindowDiv(object sender, EventArgs e)
        {
            string variable = model.Div(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                        Convert.ToInt32(mainWindow.Operand2_textBox.Text));
            mainWindow.Result_textBox.Text = variable;
        }
        #endregion
    }
}
