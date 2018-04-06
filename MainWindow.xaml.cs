/*
 * Aiden Jolley Ruhn
 * March 31, 2018
 * U2GoodTimes 
 * User inputs a time and the program outputs an updated time for different time zones
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U2GoodTimes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        
            


        }

        private void findTime_Click(object sender, RoutedEventArgs e)
        {
            int time;

            int nflTime = 0;

            int lasttwo = 0;
            int cntTime = 0;
            int mtnTime = 0;
            int pcfTime = 0;
            int estTime = 0;
            int atlTime = 0;

            if (int.TryParse(timeEnt.Text, out time))
            {
           
                 lasttwo = time % 100;
                 cntTime = time - 100;
                 mtnTime = time - 200;
                 pcfTime = time - 300;
                 estTime = time;
                 atlTime = time + 100;

                MessageBox.Show(time.ToString());
                if(time < 0)
                {
                    MessageBox.Show("Error! Enter a time that is appropriate!!");

                }
                if (time > 2400){
                    MessageBox.Show("Error! Enter a time that is appropriate!!");
                }
                MessageBox.Show(lasttwo.ToString());
                if(lasttwo > 60)
                {
                    MessageBox.Show("Error! Enter a time that is appropriate!!");

                }
                if (lasttwo < 30)
                {

                    if (time < 100)
                    {
                        cntTime = 2400 - (100 - time);
                    }
                    if (time < 200)
                    {
                        mtnTime = 2400 - (200 - time);
                    }
                    if (time < 300)
                    {
                        pcfTime = 2400 - (300 - time);
                    }
                }
                else
                {

                    nflTime = time - lasttwo + (lasttwo - 30) + 200;
                    if (atlTime >= 2400)
                    {
                        nflTime = time - 2230;
                        atlTime = time - 2300;
                    }

                    if (time < 100)
                    {
                        cntTime = 2400 - (100 - time);
                    }
                    if (time < 200)
                    {
                        mtnTime = 2400 - (200 - time);
                    }
                    if (time < 300)
                    {
                        pcfTime = 2400 - (300 - time);

                    }
                }

            }
            lblnflTime.Content = nflTime.ToString();
            lblestTime.Content = estTime.ToString();
            lblatlTime.Content = atlTime.ToString();
            lblpacTime.Content = pcfTime.ToString();
            lblmntTime.Content = mtnTime.ToString();
            lblcntTime.Content = cntTime.ToString();
 



        }
    }
}
