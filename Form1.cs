using System.Diagnostics;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GTDownloaderV2
{
    public partial class Form1 : Form
    {
        //Window dragging code is ChatGPT
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private string selectedManifest = null;
        private readonly string appid = "1533390";
        private readonly string depotid = "1533391";

        public Form1()
        {
            InitializeComponent();
            panel2.MouseDown += Panel2_MouseDown;
        }

        //please please please do not read this

        private void Form1_Load(object sender, EventArgs e)
        {
            welcomePanel.Enabled = true;
            welcomePanel.Visible = true;
            underConstruction.Enabled = false;
            underConstruction.Visible = false;
            downloadsPanel.Enabled = false;
            downloadsPanel.Visible = false;
            panel3.Enabled = false;
            panel3.Visible = false;


            wireButtons();

            //im warning you





        }


        //please just try to ignore whatever the fuck you call this

        private void wireButtons()
        {
            button7.Click += verButton;
            button8.Click += verButton;
            button9.Click += verButton;
            button10.Click += verButton;
            button11.Click += verButton;
            button12.Click += verButton;
            button13.Click += verButton;
            button14.Click += verButton;
            button15.Click += verButton;
            button16.Click += verButton;
            button17.Click += verButton;
            button18.Click += verButton;
            button19.Click += verButton;
            button20.Click += verButton;
            button21.Click += verButton;
            button22.Click += verButton;
            button23.Click += verButton;
            button24.Click += verButton;
            button25.Click += verButton;
            button26.Click += verButton;
            button27.Click += verButton;
            button28.Click += verButton;
            button29.Click += verButton;
            button30.Click += verButton;
            button31.Click += verButton;
            button32.Click += verButton;
            button33.Click += verButton;
            button34.Click += verButton;
            button35.Click += verButton;
            button36.Click += verButton;
            button37.Click += verButton;
            button38.Click += verButton;
            button39.Click += verButton;
            button40.Click += verButton;
            button41.Click += verButton;
            button42.Click += verButton;
            button43.Click += verButton;
            button44.Click += verButton;
            button45.Click += verButton;
            button46.Click += verButton;
            button47.Click += verButton;
            button48.Click += verButton;
            button49.Click += verButton;
            button50.Click += verButton;
            button51.Click += verButton;
            button52.Click += verButton;
            button53.Click += verButton;
            button54.Click += verButton;
            button55.Click += verButton;
            button56.Click += verButton;
            button57.Click += verButton;
            button58.Click += verButton;
            button59.Click += verButton;
            button60.Click += verButton;
            button61.Click += verButton;
            button62.Click += verButton;
            button63.Click += verButton;
            button64.Click += verButton;
            button65.Click += verButton;
            button66.Click += verButton;
            button67.Click += verButton;
            button68.Click += verButton;
            button69.Click += verButton;
            button70.Click += verButton;
            button71.Click += verButton;
            button72.Click += verButton;
            button73.Click += verButton;
            button74.Click += verButton;
            button75.Click += verButton;
            button76.Click += verButton;
            button77.Click += verButton;
            button78.Click += verButton;
            button79.Click += verButton;
            button80.Click += verButton;
            button81.Click += verButton;
            button82.Click += verButton;
            button83.Click += verButton;
            button84.Click += verButton;
            button85.Click += verButton;
            button86.Click += verButton;
            button87.Click += verButton;
            button88.Click += verButton;
            button89.Click += verButton;
            button90.Click += verButton;
            button91.Click += verButton;
            button92.Click += verButton;
            button93.Click += verButton;
            button94.Click += verButton;
            button95.Click += verButton;
            button96.Click += verButton;
            button97.Click += verButton;
            button98.Click += verButton;
            button99.Click += verButton;
            button100.Click += verButton;
            button101.Click += verButton;
            button102.Click += verButton;
            button103.Click += verButton;
            button104.Click += verButton;
            button105.Click += verButton;
            button106.Click += verButton;
            button107.Click += verButton;
            button108.Click += verButton;
            button109.Click += verButton;
            button110.Click += verButton;
            button111.Click += verButton;
            button112.Click += verButton;
            button113.Click += verButton;
            button114.Click += verButton;
            button115.Click += verButton;
            button116.Click += verButton;
            button117.Click += verButton;
            button118.Click += verButton;
            button119.Click += verButton;
            button120.Click += verButton;
            button121.Click += verButton;
            button122.Click += verButton;
            button123.Click += verButton;
            button124.Click += verButton;
            button125.Click += verButton;
            button126.Click += verButton;
            button127.Click += verButton;
            button128.Click += verButton;
            button129.Click += verButton;
            button130.Click += verButton;
            button131.Click += verButton;
            button132.Click += verButton;
            button133.Click += verButton;
            button134.Click += verButton;
        }


        private void verButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (btn == button7) selectedManifest = "6362658578435958263";
            else if (btn == button8) selectedManifest = "2165851274764079687";
            else if (btn == button9) selectedManifest = " 8867345169491200319";
            else if (btn == button10) selectedManifest = "3910221862130980014";
            else if (btn == button11) selectedManifest = "3910221862130980014";
            else if (btn == button12) selectedManifest = "9125835949007504429";
            else if (btn == button13) selectedManifest = "1990798142845591378";
            else if (btn == button14) selectedManifest = "2299045476431056353";
            else if (btn == button15) selectedManifest = "7415758057019556819";
            else if (btn == button16) selectedManifest = "1741725465156764391";
            else if (btn == button17) selectedManifest = "7035427218624337664";
            else if (btn == button18) selectedManifest = "25233329490798591";
            else if (btn == button19) selectedManifest = "926556172233653734";
            else if (btn == button20) selectedManifest = "8210450424725085756";
            else if (btn == button21) selectedManifest = "1523091660495421347";
            else if (btn == button22) selectedManifest = "3104309093268171733";
            else if (btn == button23) selectedManifest = "5385499363164934424";
            else if (btn == button24) selectedManifest = "2552844524420898535";
            else if (btn == button25) selectedManifest = "202914490659752858";
            else if (btn == button26) selectedManifest = "4532732456967865565";
            else if (btn == button27) selectedManifest = "6584850097575841067";
            else if (btn == button28) selectedManifest = "5172583449547504771";
            else if (btn == button29) selectedManifest = "1109136838068279011";
            else if (btn == button30) selectedManifest = "6508817049216964550";
            else if (btn == button31) selectedManifest = "1330880993914803895";
            else if (btn == button32) selectedManifest = "7343208627140783610";
            else if (btn == button33) selectedManifest = "6835551769932497179";
            else if (btn == button34) selectedManifest = "504013107999205640";
            else if (btn == button35) selectedManifest = "872909814478720200";
            else if (btn == button36) selectedManifest = "3071126083813386889";
            else if (btn == button37) selectedManifest = "5180500033267025309";
            else if (btn == button38) selectedManifest = "5012696091798757559";
            else if (btn == button39) selectedManifest = "5043232171428676962";
            else if (btn == button40) selectedManifest = "8612738834665184533";
            else if (btn == button41) selectedManifest = "8322576807180634055";
            else if (btn == button42) selectedManifest = "8529762468897318010";
            else if (btn == button43) selectedManifest = "2588790404729352981";
            else if (btn == button44) selectedManifest = "674120886711990235";
            else if (btn == button45) selectedManifest = "8527275474402577505";
            else if (btn == button46) selectedManifest = "2012969860441050604";
            else if (btn == button47) selectedManifest = "2240085398563766746";
            else if (btn == button48) selectedManifest = "8911265080531929218";
            else if (btn == button49) selectedManifest = "1173566194760021436";
            else if (btn == button50) selectedManifest = "8167245949716432329";
            else if (btn == button51) selectedManifest = "5880049732455398541";
            else if (btn == button52) selectedManifest = "1859927980973502206";
            else if (btn == button53) selectedManifest = "5594721279486364761";
            else if (btn == button54) selectedManifest = "8431433515001536429";
            else if (btn == button55) selectedManifest = "2378291872476521279";
            else if (btn == button56) selectedManifest = "5259520484793818217";
            else if (btn == button57) selectedManifest = "5702136978519485499";
            else if (btn == button58) selectedManifest = "4421572682511140788";
            else if (btn == button59) selectedManifest = "7362717951501930919";
            else if (btn == button60) selectedManifest = "413034153916417182";
            else if (btn == button61) selectedManifest = "3182699544820941765";
            else if (btn == button62) selectedManifest = "4181352281504426901";
            else if (btn == button63) selectedManifest = "3530923920245697258";
            else if (btn == button64) selectedManifest = "3030091361693161265";
            else if (btn == button65) selectedManifest = "2939400519675033898";
            else if (btn == button66) selectedManifest = "5178239895382560605";
            else if (btn == button67) selectedManifest = "910642836555163397";
            else if (btn == button68) selectedManifest = "2269080217743564656";
            else if (btn == button69) selectedManifest = "4598513446787189059";
            else if (btn == button70) selectedManifest = "1161533665635074987";
            else if (btn == button71) selectedManifest = "3531652495070235275";
            else if (btn == button72) selectedManifest = "5436404089937199520";
            else if (btn == button73) selectedManifest = "5909999775995420795";
            else if (btn == button74) selectedManifest = "3011977307304060721";
            else if (btn == button75) selectedManifest = "3197800337588223997";
            else if (btn == button76) selectedManifest = "6583276257667612942";
            else if (btn == button77) selectedManifest = "5296372619910715608";
            else if (btn == button78) selectedManifest = "5487763777743744746";
            else if (btn == button79) selectedManifest = "3656866934728343993";
            else if (btn == button80) selectedManifest = "8953216585901271401";
            else if (btn == button81) selectedManifest = "2836752869553824621";
            else if (btn == button82) selectedManifest = "5941115482047217695";
            else if (btn == button83) selectedManifest = "7202638651152606548";
            else if (btn == button84) selectedManifest = "4849975928796061895";
            else if (btn == button85) selectedManifest = "8226996632576406070";
            else if (btn == button86) selectedManifest = "1024065649513604747";
            else if (btn == button87) selectedManifest = "5272615492296865291";
            else if (btn == button88) selectedManifest = "1775104031317287137";
            else if (btn == button89) selectedManifest = "9211530748056500720";
            else if (btn == button90) selectedManifest = "7858704770131804870";
            else if (btn == button91) selectedManifest = "2826399377161966619";
            else if (btn == button92) selectedManifest = "3151533928486249672";
            else if (btn == button93) selectedManifest = "3195133226763662362";
            else if (btn == button94) selectedManifest = "6724256960126827536";
            else if (btn == button95) selectedManifest = "479866392706460246";
            else if (btn == button96) selectedManifest = "6212573569393666544";
            else if (btn == button97) selectedManifest = "5065295983577395850";
            else if (btn == button98) selectedManifest = "4435887754547797182";
            else if (btn == button99) selectedManifest = "1944409202482538955";
            else if (btn == button100) selectedManifest = "179363100641937740";
            else if (btn == button101) selectedManifest = "5263946335923032692";
            else if (btn == button102) selectedManifest = "3335121328833824494";
            else if (btn == button103) selectedManifest = "8786639128413977059";
            else if (btn == button104) selectedManifest = "3587467932664632345";
            else if (btn == button105) selectedManifest = "100037988040314385";
            else if (btn == button106) selectedManifest = "2472938543210547501";
            else if (btn == button107) selectedManifest = "9222093099666950138";
            else if (btn == button108) selectedManifest = "7171810605217611623";
            else if (btn == button109) selectedManifest = "3644302578111614762";
            else if (btn == button110) selectedManifest = "4474688531816461034";
            else if (btn == button111) selectedManifest = "8111326296022235960";
            else if (btn == button112) selectedManifest = "977662270706390562";
            else if (btn == button113) selectedManifest = "1790232358016968157";
            else if (btn == button114) selectedManifest = "2952807174378250716";
            else if (btn == button115) selectedManifest = "6301279862503136259";
            else if (btn == button116) selectedManifest = "769327410266909938";
            else if (btn == button117) selectedManifest = "3791532127930956811";
            else if (btn == button118) selectedManifest = "8796064944490370744";
            else if (btn == button119) selectedManifest = "960269214136590756";
            else if (btn == button120) selectedManifest = "2272834128493042718";
            else if (btn == button121) selectedManifest = "8773026304241958081";
            else if (btn == button122) selectedManifest = "8486188048224112520";
            else if (btn == button123) selectedManifest = "8786485081868183496";
            else if (btn == button124) selectedManifest = "8234126159354437183";
            else if (btn == button125) selectedManifest = "8743855303106200649";
            else if (btn == button126) selectedManifest = "1361357891413913381";
            else if (btn == button127) selectedManifest = "2519821153393002943";
            else if (btn == button128) selectedManifest = "7345723381055924397";
            else if (btn == button129) selectedManifest = "5830392302374695549";
            else if (btn == button130) selectedManifest = "manifest_for_button130";
            else if (btn == button131) selectedManifest = "manifest_for_button131";
            else if (btn == button132) selectedManifest = "5830392302374695549";
            else if (btn == button133) selectedManifest = "8480223242740007278";
            else if (btn == button134) selectedManifest = "2218992975128065135";
        }



        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            underConstruction.Enabled = true;
            underConstruction.Visible = true;
            downloadsPanel.Enabled = false;
            downloadsPanel.Visible = false;
            panel3.Visible = false;
            panel3.Enabled = false;
            welcomePanel.Enabled = false;
            welcomePanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            downloadsPanel.Enabled = true;
            downloadsPanel.Visible = true;
            underConstruction.Enabled = false;
            underConstruction.Visible = false;
            panel3.Enabled = false;
            panel3.Visible = false;
            welcomePanel.Enabled = false;
            welcomePanel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            welcomePanel.Enabled = true;
            welcomePanel.Visible = true;
            downloadsPanel.Enabled = false;
            downloadsPanel.Visible = false;
            underConstruction.Enabled = false;
            underConstruction.Visible = false;
            panel3.Enabled = false;
            panel3.Visible = false;
        }

        private void downloadsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button136_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Misc.openGit.openGitHub();
        }

        private void button137_Click(object sender, EventArgs e)
        {
            Misc.depotdownloaderDownloader depotdownloaderDownloader = new Misc.depotdownloaderDownloader();
            depotdownloaderDownloader.Show();
        }

        private void button135_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedManifest))
            {
                MessageBox.Show("Please select a version before downloading.");
                return;
            }
            RunDepotDownloader(appid, depotid, selectedManifest);
        }

        private void RunDepotDownloader(string appid, string depotid, string manifest)
        {
            string downloadDir = textBox1.Text;
            string depotDownloaderPath = Path.Combine(Environment.CurrentDirectory, "DepotDownloader.exe");
            string username = textBox2.Text;
            string password = textBox3.Text;

            try
            {
                string args = $"-app {appid} -depot {depotid} -manifest {manifest} -username {username} -password {password} -dir \"{downloadDir}\"";

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = depotDownloaderPath,
                    Arguments = args,
                    UseShellExecute = true,
                    CreateNoWindow = false
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading: " + ex.Message, "Error downloading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            underConstruction.Enabled = true;
            underConstruction.Visible = true;
            downloadsPanel.Enabled = false;
            downloadsPanel.Visible = false;
            panel3.Visible = false;
            panel3.Enabled = false;
            welcomePanel.Enabled = false;
            welcomePanel.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            underConstruction.Enabled = true;
            underConstruction.Visible = true;
            downloadsPanel.Enabled = false;
            downloadsPanel.Visible = false;
            panel3.Visible = false;
            panel3.Enabled = false;
            welcomePanel.Enabled = false;
            welcomePanel.Visible = false;
        }
    }
}

