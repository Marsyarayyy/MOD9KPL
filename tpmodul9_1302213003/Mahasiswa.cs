﻿namespace tpmodul9_1302213003
{
    public class Mahasiswa
    {
        public String Nama { get; private set; }
        public String Nim { get; private set; }
        public Mahasiswa(String Nama, String Nim)
        {
            this.Nama = Nama;
            this.Nim = Nim;
        }
    }
}
