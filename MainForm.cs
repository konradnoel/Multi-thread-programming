using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace MultiThreadedApp
{
    public partial class MainForm : Form
    {
        public EventWaitHandle wait = new ManualResetEvent(false);
        public EventWaitHandle wait2 = new AutoResetEvent(false);
        public object sync = new object();

        public long distanceCounter = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        public void BikeThreadFunction(object param)
        {
            try
            {
                var bike = (Button)param;
                int i = 0;
                bike.Tag = Thread.CurrentThread;




                while (bike.Left < pTarget.Left)
                {
                    MoveBike(bike);
                    Thread.Sleep(100);
                    
                    //Ha beértünk az első panelba, várunk
                    if (bike.Left > pStart.Left)
                    {
                        wait.WaitOne();

                    }

                    //Ha beértünk a második panelba, akkor az első alkalommal még megállunk, gombnyomás után már nem,
                    //hiszen nem megyünk be az if-ágba.
                    if (bike.Left > pDepoPanel.Left && i == 0)
                    {
                        wait2.WaitOne();
                        i=1;
                    }


                }
            }
            //Lenyeljük az errort, hogy fusson tovább a program
            catch 
            { 
            
            }

        }

        Random random = new Random();

        public void MoveBike(Button bike)
        {
            if (InvokeRequired)
            {
                Invoke(MoveBike, bike);
            }
            else
            {
                //Eltároljuk a random értékét, és meghívjuk vele az IncreasePixelst, biztonságosan :)
                int x = random.Next(2, 8);
                bike.Left += x;
                lock (sync)
                {
                    IncreasePixels(x);
                }
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            StartBike(bBike1);
            StartBike(bBike2);
            StartBike(bBike3);
        }

        private void StartBike(Button bBike)
        {
            var t = new Thread(BikeThreadFunction)
            {
                IsBackground = true, // Ne blokkolja a szál a processz megszűnését
            };

            bBike.Tag = t;
            t.Start(bBike);
        }

        private void bStep1_Click(object sender, EventArgs e)
        {
            wait.Set();
        }

        private void bStep2_Click(object sender, EventArgs e)
        {

            wait2.Set();

        }

        
        private void bCounter_Click(object sender, EventArgs e)
        {
            //Biztonságos kiolvasás :)
            bCounter.Text = GetPixels();
        }

        //Biztonságos kiolvasás :)
        private string GetPixels()
        {
            return distanceCounter.ToString();
        }
        //Biztonságos írás :)
        private void IncreasePixels(long dist)
        {
            distanceCounter += dist;
        }


        private void bBike1_Click(object sender, EventArgs e)
        {
            Button bike = (Button)sender;
            Thread thread = (Thread)bike.Tag;

            // Ha még nem indítottuk ez a szálat, ez null.
            if (thread == null)
                return;

            // Megszakítjuk a szál várakozását,
            // ez az adott szálban egy ThreadInterruptedException-t fog kiváltani
            // A függvény leírásáról részleteket az előadás anyagaiban találsz
            thread.Interrupt();

            // Megvárjuk, amíg a szál leáll
            thread.Join();

            //Visszadobjuk a startra (nem akartam a legszélére mert milyen ronda az már)
            bike.Left = 10;

            //Indítunk egy új szálat
            StartBike(bike);
        }
    }
}