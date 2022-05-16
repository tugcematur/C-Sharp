using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad  { get; set; }
        public string KartNo1 { get => KartNo; set => KartNo = value.Substring(0,2) +"**********" +  value.Substring(value.Length - 4); } //Substring(1,5) 1'5 e kadar Substring(4) 4 başlayarak sona kadar yazar.
                                                                                 // son 4 hanesi                     KartNo'nun kullanılabilir halini tanımladık.
        private string KartNo; // sağ tıkla quick actions -> encapsulation          

    }
}
