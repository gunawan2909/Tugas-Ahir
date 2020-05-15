using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Ahir
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel4.Height = button1.Height;
            groupBoxDataInduk.BringToFront();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void raport1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Height = button1.Height;
            panel4.Top = button1.Top; 
            groupBoxDataInduk.BringToFront();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxRapot_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
            groupBoxSiswa.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.BringToFront();
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            this.N1.Text = this.Nama1.Text;
            this.N2.Text = this.Nama2.Text;
            this.N3.Text = this.Nama3.Text;
            this.N4.Text = this.Nama4.Text;
            this.N5.Text = this.Nama5.Text;
            this.N6.Text = this.Nama6.Text;
            this.N7.Text = this.Nama7.Text;
            this.N8.Text = this.Nama8.Text;
            this.N9.Text = this.Nama9.Text;
            this.N10.Text = this.Nama10.Text;
            this.N11.Text = this.Nama11.Text;
            this.N12.Text = this.Nama12.Text;
            this.N13.Text = this.Nama13.Text;
            this.N14.Text = this.Nama14.Text;
            this.N15.Text = this.Nama15.Text;
            this.N16.Text = this.Nama16.Text;
            this.N17.Text = this.Nama17.Text;
            this.N18.Text = this.Nama18.Text;
            this.N19.Text = this.Nama19.Text;
            this.N20.Text = this.Nama20.Text;
            this.richTextBoxNamaMP1.Text = this.MataPelajaran1.Text;
            this.richTextBoxNamaMP2.Text = this.MataPelajaran2.Text;
            this.richTextBoxNamaMP3.Text = this.MataPelajaran3.Text;
            this.richTextBoxNamaMP4.Text = this.MataPelajaran4.Text;
            this.richTextBoxNamaMP5.Text = this.MataPelajaran5.Text;
            this.richTextBoxNamaMP6.Text = this.MataPelajaran6.Text;
            this.richTextBoxNamaMP7.Text = this.MataPelajaran7.Text;
            this.richTextBoxNamaMP8.Text = this.MataPelajaran8.Text;
            this.richTextBoxNamaMP9.Text = this.MataPelajaran9.Text;
            this.richTextBoxNamaMP10.Text = this.MataPelajaran10.Text;





        }


        

        private void button14_Click(object sender, EventArgs e)
        {
            groupBoxDataInduk.BringToFront();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

            {
                

            }


        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            groupBoxDataIndukInput.BringToFront();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxDataIndukInput_Enter(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void MataPelajaran16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            groupBoxDataInduk.BringToFront();
            this.LabelSekolah.Text = this.NamaSekolah.Text;
            this.labelKelas.Text = this.Kelas.Text;
            this.labelSemestet.Text = this.SemesterIn.Text;
            this.labelTahunAjar.Text= this.TahunAjar.Text;
            String a, b,c,d,z,f,g,h,i,j,k,A,B,C,D,E,F,G,H,I,J,K;
            DataBesar masuk = new DataBesar();
            a = this.MataPelajaran1.Text;
            b = this.MataPelajaran2.Text;
            c = this.MataPelajaran3.Text;
            d= this.MataPelajaran4.Text;
            z= this.MataPelajaran5.Text;
            f= this.MataPelajaran6.Text;
            g= this.MataPelajaran7.Text;
            h = this.MataPelajaran8.Text;
            i = this.MataPelajaran9.Text;
            j = this.MataPelajaran10.Text;
            k = this.MataPelajaran11.Text;
           
            A = this.KKM1.Text;
            B = this.KKM2.Text;
            C = this.KKM3.Text;
            D = this.KKM4.Text;
            E = this.KKM5.Text;
            F = this.KKM6.Text;
            G = this.KKM7.Text;
            H = this.KKM8.Text;
            I = this.KKM9.Text;
            J = this.KKM10.Text;
            K = this.KKM11.Text;
          

            masuk.tambahMP(a);
            masuk.tambahMP(b);
            masuk.tambahMP(c);
            masuk.tambahMP(d);
            masuk.tambahMP(z);
            masuk.tambahMP(f);
            masuk.tambahMP(g);
            masuk.tambahMP(h);
            masuk.tambahMP(i);
            masuk.tambahMP(j);
            masuk.tambahMP(k);
           
            masuk.tambahKKM(A);
            masuk.tambahKKM(B);
            masuk.tambahKKM(C);
            masuk.tambahKKM(D);
            masuk.tambahKKM(E);
            masuk.tambahKKM(F);
            masuk.tambahKKM(G);
            masuk.tambahKKM(I);
            masuk.tambahKKM(J);
            masuk.tambahKKM(K);
          

            this.MataPelajaran.Text = masuk.cetakMP();
            this.KKM.Text = masuk.cetakKKm();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBoxNamaInput.BringToFront();


        }

     

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            groupBoxSiswa.BringToFront();
            DataBesar masuk = new DataBesar();
            masuk.tambahnama(this.Nama1.Text);
            masuk.tambahnama(this.Nama2.Text);
            masuk.tambahnama(this.Nama3.Text);
            masuk.tambahnama(this.Nama4.Text);
            masuk.tambahnama(this.Nama5.Text);
            masuk.tambahnama(this.Nama6.Text);
            masuk.tambahnama(this.Nama7.Text);
            masuk.tambahnama(this.Nama8.Text);
            masuk.tambahnama(this.Nama9.Text);
            masuk.tambahnama(this.Nama10.Text);
            masuk.tambahnama(this.Nama11.Text);
            masuk.tambahnama(this.Nama12.Text);
            masuk.tambahnama(this.Nama13.Text);
            masuk.tambahnama(this.Nama14.Text);
            masuk.tambahnama(this.Nama15.Text);
            masuk.tambahnama(this.Nama16.Text);
            masuk.tambahnama(this.Nama17.Text);
            masuk.tambahnama(this.Nama18.Text);
            masuk.tambahnama(this.Nama19.Text);
            masuk.tambahnama(this.Nama20.Text);
            this.labelNama.Text = masuk.cetakNama();
            this.labelNoAbsn.Text = masuk.NoAbsn();
            



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox175_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox92_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox110_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox83_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox73_TextChanged(object sender, EventArgs e)
        {


        }

        public void button5_Click(object sender, EventArgs e)
        {
            DataBesar masuk = new DataBesar();
            masuk.tambahnama(this.Nama1.Text);
            masuk.tambahnama(this.Nama2.Text);
            masuk.tambahnama(this.Nama3.Text);
            masuk.tambahnama(this.Nama4.Text);
            masuk.tambahnama(this.Nama5.Text);
            masuk.tambahnama(this.Nama6.Text);
            masuk.tambahnama(this.Nama7.Text);
            masuk.tambahnama(this.Nama8.Text);
            masuk.tambahnama(this.Nama9.Text);
            masuk.tambahnama(this.Nama10.Text);
            masuk.tambahnama(this.Nama11.Text);
            masuk.tambahnama(this.Nama12.Text);
            masuk.tambahnama(this.Nama13.Text);
            masuk.tambahnama(this.Nama14.Text);
            masuk.tambahnama(this.Nama15.Text);
            masuk.tambahnama(this.Nama16.Text);
            masuk.tambahnama(this.Nama17.Text);
            masuk.tambahnama(this.Nama18.Text);
            masuk.tambahnama(this.Nama19.Text);
            masuk.tambahnama(this.Nama20.Text);
            switch (this.textBoxNoAbsn.Text)
            {
                case "1":
                    masuk.tambahNilai(this.MP1.Text);
                    masuk.tambahNilai(this.MP21.Text);
                    masuk.tambahNilai(this.MP41.Text);
                    masuk.tambahNilai(this.MP61.Text);
                    masuk.tambahNilai(this.MP81.Text);
                    masuk.tambahNilai(this.MP101.Text);
                    masuk.tambahNilai(this.MP121.Text);
                    masuk.tambahNilai(this.MP141.Text);
                    masuk.tambahNilai(this.MP161.Text);
                    masuk.tambahNilai(this.MP181.Text);
                    this.textNama.Text = masuk.NAMA(0);
                    break;
                case "2":
                    masuk.tambahNilai(this.MP2.Text);
                    masuk.tambahNilai(this.MP22.Text);
                    masuk.tambahNilai(this.MP42.Text);
                    masuk.tambahNilai(this.MP62.Text);
                    masuk.tambahNilai(this.MP82.Text);
                    masuk.tambahNilai(this.MP102.Text);
                    masuk.tambahNilai(this.MP122.Text);
                    masuk.tambahNilai(this.MP142.Text);
                    masuk.tambahNilai(this.MP162.Text);
                    masuk.tambahNilai(this.MP182.Text);
                    this.textNama.Text = masuk.NAMA(1);
                    break;
                case "3":
                    masuk.tambahNilai(this.MP3.Text);
                    masuk.tambahNilai(this.MP23.Text);
                    masuk.tambahNilai(this.MP43.Text);
                    masuk.tambahNilai(this.MP63.Text);
                    masuk.tambahNilai(this.MP83.Text);
                    masuk.tambahNilai(this.MP103.Text);
                    masuk.tambahNilai(this.MP123.Text);
                    masuk.tambahNilai(this.MP143.Text);
                    masuk.tambahNilai(this.MP163.Text);
                    masuk.tambahNilai(this.MP183.Text);
                    this.textNama.Text = masuk.NAMA(2);
                    break;
                case "4":
                    masuk.tambahNilai(this.MP4.Text);
                    masuk.tambahNilai(this.MP24.Text);
                    masuk.tambahNilai(this.MP44.Text);
                    masuk.tambahNilai(this.MP64.Text);
                    masuk.tambahNilai(this.MP84.Text);
                    masuk.tambahNilai(this.MP104.Text);
                    masuk.tambahNilai(this.MP124.Text);
                    masuk.tambahNilai(this.MP144.Text);
                    masuk.tambahNilai(this.MP164.Text);
                    masuk.tambahNilai(this.MP184.Text);
                    this.textNama.Text = masuk.NAMA(3);
                    break;
                case "5":
                    masuk.tambahNilai(this.MP5.Text);
                    masuk.tambahNilai(this.MP25.Text);
                    masuk.tambahNilai(this.MP45.Text);
                    masuk.tambahNilai(this.MP65.Text);
                    masuk.tambahNilai(this.MP85.Text);
                    masuk.tambahNilai(this.MP105.Text);
                    masuk.tambahNilai(this.MP125.Text);
                    masuk.tambahNilai(this.MP145.Text);
                    masuk.tambahNilai(this.MP165.Text);
                    masuk.tambahNilai(this.MP185.Text);
                    this.textNama.Text = masuk.NAMA(4);
                    break;
                case "6":
                    masuk.tambahNilai(this.MP6.Text);
                    masuk.tambahNilai(this.MP26.Text);
                    masuk.tambahNilai(this.MP46.Text);
                    masuk.tambahNilai(this.MP66.Text);
                    masuk.tambahNilai(this.MP86.Text);
                    masuk.tambahNilai(this.MP106.Text);
                    masuk.tambahNilai(this.MP126.Text);
                    masuk.tambahNilai(this.MP146.Text);
                    masuk.tambahNilai(this.MP166.Text);
                    masuk.tambahNilai(this.MP186.Text);
                    this.textNama.Text = masuk.NAMA(5);
                    break;
                case "7":
                    masuk.tambahNilai(this.MP7.Text);
                    masuk.tambahNilai(this.MP27.Text);
                    masuk.tambahNilai(this.MP47.Text);
                    masuk.tambahNilai(this.MP67.Text);
                    masuk.tambahNilai(this.MP87.Text);
                    masuk.tambahNilai(this.MP107.Text);
                    masuk.tambahNilai(this.MP127.Text);
                    masuk.tambahNilai(this.MP147.Text);
                    masuk.tambahNilai(this.MP167.Text);
                    masuk.tambahNilai(this.MP187.Text);
                    this.textNama.Text = masuk.NAMA(6);
                    break;
                case "8":
                    masuk.tambahNilai(this.MP8.Text);
                    masuk.tambahNilai(this.MP28.Text);
                    masuk.tambahNilai(this.MP48.Text);
                    masuk.tambahNilai(this.MP68.Text);
                    masuk.tambahNilai(this.MP88.Text);
                    masuk.tambahNilai(this.MP108.Text);
                    masuk.tambahNilai(this.MP128.Text);
                    masuk.tambahNilai(this.MP148.Text);
                    masuk.tambahNilai(this.MP168.Text);
                    masuk.tambahNilai(this.MP188.Text);
                    this.textNama.Text = masuk.NAMA(7);
                    break;
                case "9":
                    masuk.tambahNilai(this.MP9.Text);
                    masuk.tambahNilai(this.MP29.Text);
                    masuk.tambahNilai(this.MP49.Text);
                    masuk.tambahNilai(this.MP69.Text);
                    masuk.tambahNilai(this.MP89.Text);
                    masuk.tambahNilai(this.MP109.Text);
                    masuk.tambahNilai(this.MP129.Text);
                    masuk.tambahNilai(this.MP149.Text);
                    masuk.tambahNilai(this.MP169.Text);
                    masuk.tambahNilai(this.MP189.Text);
                    this.textNama.Text = masuk.NAMA(8);
                    break;
                case "10":
                    masuk.tambahNilai(this.MP10.Text);
                    masuk.tambahNilai(this.MP30.Text);
                    masuk.tambahNilai(this.MP50.Text);
                    masuk.tambahNilai(this.MP70.Text);
                    masuk.tambahNilai(this.MP90.Text);
                    masuk.tambahNilai(this.MP110.Text);
                    masuk.tambahNilai(this.MP130.Text);
                    masuk.tambahNilai(this.MP150.Text);
                    masuk.tambahNilai(this.MP170.Text);
                    masuk.tambahNilai(this.MP190.Text);
                    this.textNama.Text = masuk.NAMA(9);
                    break;
                case "11":
                    masuk.tambahNilai(this.MP11.Text);
                    masuk.tambahNilai(this.MP31.Text);
                    masuk.tambahNilai(this.MP51.Text);
                    masuk.tambahNilai(this.MP71.Text);
                    masuk.tambahNilai(this.MP91.Text);
                    masuk.tambahNilai(this.MP111.Text);
                    masuk.tambahNilai(this.MP131.Text);
                    masuk.tambahNilai(this.MP151.Text);
                    masuk.tambahNilai(this.MP171.Text);
                    masuk.tambahNilai(this.MP191.Text);
                    this.textNama.Text = masuk.NAMA(10);
                    break;
                case "12":
                    masuk.tambahNilai(this.MP12.Text);
                    masuk.tambahNilai(this.MP32.Text);
                    masuk.tambahNilai(this.MP52.Text);
                    masuk.tambahNilai(this.MP72.Text);
                    masuk.tambahNilai(this.MP92.Text);
                    masuk.tambahNilai(this.MP112.Text);
                    masuk.tambahNilai(this.MP132.Text);
                    masuk.tambahNilai(this.MP152.Text);
                    masuk.tambahNilai(this.MP172.Text);
                    masuk.tambahNilai(this.MP192.Text);
                    this.textNama.Text = masuk.NAMA(11);
                    break;
                case "13":
                    masuk.tambahNilai(this.MP3.Text);
                    masuk.tambahNilai(this.MP23.Text);
                    masuk.tambahNilai(this.MP43.Text);
                    masuk.tambahNilai(this.MP63.Text);
                    masuk.tambahNilai(this.MP83.Text);
                    masuk.tambahNilai(this.MP103.Text);
                    masuk.tambahNilai(this.MP123.Text);
                    masuk.tambahNilai(this.MP143.Text);
                    masuk.tambahNilai(this.MP163.Text);
                    masuk.tambahNilai(this.MP183.Text);
                    this.textNama.Text = masuk.NAMA(12);
                    break;
                case "14":
                    masuk.tambahNilai(this.MP14.Text);
                    masuk.tambahNilai(this.MP34.Text);
                    masuk.tambahNilai(this.MP44.Text);
                    masuk.tambahNilai(this.MP74.Text);
                    masuk.tambahNilai(this.MP94.Text);
                    masuk.tambahNilai(this.MP114.Text);
                    masuk.tambahNilai(this.MP134.Text);
                    masuk.tambahNilai(this.MP154.Text);
                    masuk.tambahNilai(this.MP175.Text);
                    masuk.tambahNilai(this.MP194.Text);
                    this.textNama.Text = masuk.NAMA(13);
                    break;
                case "15":
                    masuk.tambahNilai(this.MP15.Text);
                    masuk.tambahNilai(this.MP35.Text);
                    masuk.tambahNilai(this.MP55.Text);
                    masuk.tambahNilai(this.MP75.Text);
                    masuk.tambahNilai(this.MP95.Text);
                    masuk.tambahNilai(this.MP115.Text);
                    masuk.tambahNilai(this.MP135.Text);
                    masuk.tambahNilai(this.MP155.Text);
                    masuk.tambahNilai(this.MP175.Text);
                    masuk.tambahNilai(this.MP195.Text);
                    this.textNama.Text = masuk.NAMA(14);
                    break;
                case "16":
                    masuk.tambahNilai(this.MP16.Text);
                    masuk.tambahNilai(this.MP36.Text);
                    masuk.tambahNilai(this.MP56.Text);
                    masuk.tambahNilai(this.MP76.Text);
                    masuk.tambahNilai(this.MP96.Text);
                    masuk.tambahNilai(this.MP116.Text);
                    masuk.tambahNilai(this.MP136.Text);
                    masuk.tambahNilai(this.MP156.Text);
                    masuk.tambahNilai(this.MP176.Text);
                    masuk.tambahNilai(this.MP196.Text);
                    this.textNama.Text = masuk.NAMA(15);
                    break;
                case "17":
                    masuk.tambahNilai(this.MP17.Text);
                    masuk.tambahNilai(this.MP37.Text);
                    masuk.tambahNilai(this.MP57.Text);
                    masuk.tambahNilai(this.MP77.Text);
                    masuk.tambahNilai(this.MP97.Text);
                    masuk.tambahNilai(this.MP117.Text);
                    masuk.tambahNilai(this.MP137.Text);
                    masuk.tambahNilai(this.MP157.Text);
                    masuk.tambahNilai(this.MP177.Text);
                    masuk.tambahNilai(this.MP197.Text);
                    this.textNama.Text = masuk.NAMA(16);
                    break;
                case "18":
                    masuk.tambahNilai(this.MP18.Text);
                    masuk.tambahNilai(this.MP38.Text);
                    masuk.tambahNilai(this.MP58.Text);
                    masuk.tambahNilai(this.MP78.Text);
                    masuk.tambahNilai(this.MP98.Text);
                    masuk.tambahNilai(this.MP118.Text);
                    masuk.tambahNilai(this.MP138.Text);
                    masuk.tambahNilai(this.MP158.Text);
                    masuk.tambahNilai(this.MP178.Text);
                    masuk.tambahNilai(this.MP198.Text);
                    this.textNama.Text = masuk.NAMA(17);
                    break;
                case "19":
                    masuk.tambahNilai(this.MP19.Text);
                    masuk.tambahNilai(this.MP39.Text);
                    masuk.tambahNilai(this.MP59.Text);
                    masuk.tambahNilai(this.MP79.Text);
                    masuk.tambahNilai(this.MP99.Text);
                    masuk.tambahNilai(this.MP119.Text);
                    masuk.tambahNilai(this.MP139.Text);
                    masuk.tambahNilai(this.MP159.Text);
                    masuk.tambahNilai(this.MP179.Text);
                    masuk.tambahNilai(this.MP199.Text);
                    this.textNama.Text = masuk.NAMA(18);
                    break;
                case "20":
                    masuk.tambahNilai(this.MP20.Text);
                    masuk.tambahNilai(this.MP40.Text);
                    masuk.tambahNilai(this.MP60.Text);
                    masuk.tambahNilai(this.MP80.Text);
                    masuk.tambahNilai(this.MP100.Text);
                    masuk.tambahNilai(this.MP120.Text);
                    masuk.tambahNilai(this.MP140.Text);
                    masuk.tambahNilai(this.MP160.Text);
                    masuk.tambahNilai(this.MP180.Text);
                    masuk.tambahNilai(this.MP200.Text);
                    this.textNama.Text = masuk.NAMA(19);
                    break;


            }
            this.labelNilai.Text=masuk.CetakNilai();
            
            




        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataBesar masuk = new DataBesar();
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
            groupBoxRapot.BringToFront();

            this.label9.Text = this.LabelSekolah.Text;
            this.textKelas.Text = this.labelKelas.Text;
            this.textSemester.Text = this.labelSemestet.Text;
            this.textTahunAjar.Text = this.labelTahunAjar.Text;
            this.labelMataPelajaran.Text = this.MataPelajaran.Text;
            this.labelKKM.Text = this.KKM.Text;
            



        }
    }
}
