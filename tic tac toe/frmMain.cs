using System.Media;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class frmMain : Form
    {
        public int[,] Matris;
        public int Kazanan = 0;

        public frmMain()
        {
            InitializeComponent();

            // Oyun kontrol� i�in 2 boyutlu diziyi tan�mla.
            Matris = new int[3, 3];
        }

        public void OyunuResetle()
        {
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";

            rbPlayer1.Enabled = true;
            rbPlayer2.Enabled = true;

            Kazanan = 0;
            Matris = new int[3, 3];
        }

        public void MatrisiIsaretle(int x, int y)
        {
            if (rbPlayer1.Checked) // Player 1 ise
            {
                Matris[x, y] = 1;

                // Player 1 i�in i�aretle
                rbPlayer1.Checked = false;
                rbPlayer2.Checked = true;

                var player = new SoundPlayer()
                {
                    Stream = Resources.Tick
                };

                player.Play();
            }
            else // Player 2 ise
            {
                Matris[x, y] = 2;

                // Player 1 i�in i�aretle
                rbPlayer1.Checked = true;
                rbPlayer2.Checked = false;

                var player = new SoundPlayer()
                {
                    Stream = Resources.Tock
                };

                player.Play();
            }

            // oyun ba�lad��� i�in art�k player manuel se�ilmesin!
            rbPlayer1.Enabled = false;
            rbPlayer2.Enabled = false;

            if (OyunKontrolu() == true)
            {
                MessageBox.Show("Tekbrikler! Player " + Kazanan + " kazand�!", "OYUN B�TT�");
                OyunuResetle();
            }
        }

        public bool OyunKontrolu()
        {
            var result = false;

            for (int i = 0; i < 3; i++)
            {
                // i-inci s�tunlar� se�er
                var s1 = Matris[0, i];
                var s2 = Matris[1, i];
                var s3 = Matris[2, i];

                // i-inci sat�lar� se�er.
                var k1 = Matris[i, 0];
                var k2 = Matris[i, 1];
                var k3 = Matris[i, 2];

                // i-inci s�tuna g�re kazanan var m�?
                var sutunlar = KazananVarmi(s1, s2, s3);

                // i-inci sat�ra g�re kazanan var m�?
                var satirlar = KazananVarmi(k1, k2, k3);

                if (satirlar == true || sutunlar == true)
                {
                    result = true;
                    break;
                }
            }


            // diyagonal
            var d1 = Matris[0, 0];
            var d2 = Matris[1, 1];
            var d3 = Matris[2, 2];

            // ters diyagonal
            var t1 = Matris[0, 2];
            var t2 = Matris[1, 1];
            var t3 = Matris[2, 0];

            // diyagonele g�re kazanan var m�?
            var D = KazananVarmi(d1, d2, d3);

            // ters diyagonele g�re kazanan var m�?
            var T = KazananVarmi(t1, t2, t3);

            if (T == true || D == true)
            {
                result = true;
            }

            return
                result;
        }

        public bool KazananVarmi(int a, int b, int c)
        {
            // ilk �nce hepsinin s�f�rdan farkl� olup olmad���n� kontrol et.
            if (a > 0 && b > 0 && c > 0)
            {
                if (a == b && b == c)
                {
                    Kazanan = a;
                    return true;
                }
                else
                    return false;
            }
            else
                return
                    false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var player = new SoundPlayer()
            {
                Stream = Resources.GameStart
            };

            player.Play();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            btn11.Text = (rbPlayer1.Checked ? "X" : "O");
            MatrisiIsaretle(0, 0);
        }

        private void btn12_Click(object sender, EventArgs e)
        {

            btn12.Text = (rbPlayer1.Checked ? "X" : "O");
            MatrisiIsaretle(0, 1);
        }

        private void btn13_Click(object sender, EventArgs e)
        {

            btn13.Text = (rbPlayer1.Checked ? "X" : "O");
            MatrisiIsaretle(0, 2);
        }

        private void btn21_Click(object sender, EventArgs e)
        {

            btn21.Text = (rbPlayer1.Checked ? "X" : "O");
            MatrisiIsaretle(1, 0);
        }

        private void btn22_Click(object sender, EventArgs e)
        {

            btn22.Text = (rbPlayer1.Checked ? "X" : "O");
            MatrisiIsaretle(1, 1);
        }

        private void btn23_Click(object sender, EventArgs e)
        {

            btn23.Text = (rbPlayer1.Checked ? "X" : "O");
            MatrisiIsaretle(1, 2);
        }

        private void btn31_Click(object sender, EventArgs e)
        {

            btn31.Text = (rbPlayer1.Checked ? "X" : "O");
            MatrisiIsaretle(2, 0);
        }

        private void btn32_Click(object sender, EventArgs e)
        {

            btn32.Text = (rbPlayer1.Checked ? "X" : "O");
            MatrisiIsaretle(2, 1);
        }

        private void btn33_Click(object sender, EventArgs e)
        {

            btn33.Text = (rbPlayer1.Checked ? "X" : "O");
            MatrisiIsaretle(2, 2);
        }
    }
}
