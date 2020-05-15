using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Ahir
{
    class DataBesar
    {
        
        Queue<string> MataPelajaran = new Queue<string>();
        Queue<String> KKM = new Queue<String>();
        Queue<String> Nama = new Queue<string>();
        Queue<String> Nilai = new Queue<string>();
        

             
        public void tambahMP(String a)
        {

            MataPelajaran.Enqueue(a);                              
        }
        public void tambahKKM(String b)
        {
            KKM.Enqueue(b);
        }

        public String  cetakKKm()
        {
            String x = " ";
            foreach (String value in KKM)
            {
                x = x + value + "\n";
            }
            return x;

        }
        public  String cetakMP()
        {

            String x = " ";
            foreach (String value in MataPelajaran)
            {
                x = x + value + "\n";
            }
             return x;
        }
        public void tambahnama(String a)
        {
            Nama.Enqueue(a);
        }
        public String cetakNama()
        {
            String x = " ";
            foreach (String value in Nama)
            {
                x = x + value + "\n";
            }
            return x;
        }
        public String NoAbsn()
        {
            String x = " ";
            int y = 0;
            foreach (String value in Nama)
            {
                y = y+1;
                x = x + y + "\n";
            }
            return x;
        }
        public void tambahNilai(String a)
        {
            Nilai.Enqueue(a);
         }
        public String CetakNilai()
        {
            String x = " ";            
            foreach (String value in Nilai)
            {
                
                x = x + value + "\n";
            }
            return x;
        }
        public String NAMA (int a)
        {
            String[] NaMA = Nama.ToArray();           
            return NaMA[a]; 
        }

    }
}
