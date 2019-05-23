using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADKP_LABSTORE
{
    class Class1
    {
        int merk, ukuran;    // deklarasi atribut merk dan ukuran bertipe data interger

        public void setmerk(int var)   //method set atribut
        {
            this.merk = var;    //menentukan nilai atribut
        }
        public int getmerk()   //method get atribut
        {
            return merk;     // mendapatkan nilai atribut dan mengembalikan ke fungsi yang memanggilnya
        }

        public void setukuran(int var)  //method set atribut
        {
            this.ukuran = var;   //menentukan nilai atribut
        }
        public int getukuran()  //method get atribut
        {

            return ukuran;  //mendapatkan nilai atribut
        }
    }
}
