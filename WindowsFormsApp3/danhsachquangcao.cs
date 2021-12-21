using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class danhsachquangcao
    {
        private static danhsachquangcao instance;
        public static danhsachquangcao Instance
        {
            get
            {
                if (instance == null)
                    instance = new danhsachquangcao();
                return instance;
            }
            set => instance = value;
        }
        List<quangcao> quangcaos;
        public List<quangcao> Quangcaos { get => quangcaos; set => quangcaos = value; }

        private danhsachquangcao() 
        {
            quangcaos = new List<quangcao>();
            quangcaos.Add(new quangcao("1", "KT19ADS", "Kim Cuong", "HT12KUY", "Ly Minh Phat", "24:34:12", "45,000,000"));
            quangcaos.Add(new quangcao("2", "TV34UHG", "Dien Thoai", "DG23KDD", "Chu Duy Anh", "54:37:42", "90,360,000"));
            quangcaos.Add(new quangcao("3", "NH78HFG", "Xe", "JS34SFS", "Nguyen Hoai Tam", "48:23:50", "12,230,000"));
            quangcaos.Add(new quangcao("4", "JS90NSA", "Lo Nuong", "NS87JSV", "Tran Van Cao", "14:24:34", "125,200,000"));
            quangcaos.Add(new quangcao("5", "JS12KSI", "Giay", "HK23SCC", "Nguyen Tan Tu", "45:34:45", "67,040,000"));
            quangcaos.Add(new quangcao("6", "HA23JSA", "Chao", "HT12tyY", "Cao Anh Thu", "24:34:12", "34,300,000"));
            quangcaos.Add(new quangcao("7", "NF34ISF", "Day Chuyen", "HT18KUY", "Nguyen Van Nhan", "84:44:22", "42,340,000"));
            quangcaos.Add(new quangcao("8", "MS94SFV", "Nhan", "HT34KUY", "Tran Cao Minh", "12:23:57", "99,999,000"));
            quangcaos.Add(new quangcao("9", "KA12SSA", "Card Do Hoa", "AS12KUY", "Ho Gia The", "23:75:23", "533,000,000"));
            quangcaos.Add(new quangcao("10", "NS92SDF", "Ao Len", "HT14HTY", "Vo Binh Phu Duong", "49:34:12", "95,000,000"));
            quangcaos.Add(new quangcao("11", "KT19ADS", "Kim Cuong", "HT12KUY", "Ly Minh Phat", "24:34:12", "45,000,000"));
            quangcaos.Add(new quangcao("12", "TV34UHG", "Dien Thoai", "DG23KDD", "Chu Duy Anh", "54:37:42", "90,360,000"));
            quangcaos.Add(new quangcao("13", "NH78HFG", "Xe", "JS34SFS", "Nguyen Hoai Tam", "48:23:50", "12,230,000"));
            quangcaos.Add(new quangcao("14", "JS90NSA", "Lo Nuong", "NS87JSV", "Tran Van Cao", "14:24:34", "125,200,000"));
            quangcaos.Add(new quangcao("15", "JS12KSI", "Giay", "HK23SCC", "Nguyen Tan Tu", "45:34:45", "67,040,000"));
            quangcaos.Add(new quangcao("16", "HA23JSA", "Chao", "HT12tyY", "Cao Anh Thu", "24:34:12", "34,300,000"));
            quangcaos.Add(new quangcao("17", "NF34ISF", "Day Chuyen", "HT18KUY", "Nguyen Van Nhan", "84:44:22", "42,340,000"));
            quangcaos.Add(new quangcao("18", "MS94SFV", "Nhan", "HT34KUY", "Tran Cao Minh", "12:23:57", "99,999,000"));
            quangcaos.Add(new quangcao("19", "KA12SSA", "Card Do Hoa", "AS12KUY", "Ho Gia The", "23:75:23", "533,000,000"));
            quangcaos.Add(new quangcao("20", "NS92SDF", "Ao Len", "HT14HTY", "Vo Binh Phu Duong", "49:34:12", "95,000,000"));
            quangcaos.Add(new quangcao("21", "KT19ADS", "Kim Cuong", "HT12KUY", "Ly Minh Phat", "24:34:12", "45,000,000"));
            quangcaos.Add(new quangcao("22", "TV34UHG", "Dien Thoai", "DG23KDD", "Chu Duy Anh", "54:37:42", "90,360,000"));
            quangcaos.Add(new quangcao("23", "NH78HFG", "Xe", "JS34SFS", "Nguyen Hoai Tam", "48:23:50", "12,230,000"));
            quangcaos.Add(new quangcao("24", "JS90NSA", "Lo Nuong", "NS87JSV", "Tran Van Cao", "14:24:34", "125,200,000"));
            quangcaos.Add(new quangcao("25", "JS12KSI", "Giay", "HK23SCC", "Nguyen Tan Tu", "45:34:45", "67,040,000"));
            quangcaos.Add(new quangcao("26", "HA23JSA", "Chao", "HT12tyY", "Cao Anh Thu", "24:34:12", "34,300,000"));
            quangcaos.Add(new quangcao("27", "NF34ISF", "Day Chuyen", "HT18KUY", "Nguyen Van Nhan", "84:44:22", "42,340,000"));
            quangcaos.Add(new quangcao("28", "MS94SFV", "Nhan", "HT34KUY", "Tran Cao Minh", "12:23:57", "99,999,000"));
            quangcaos.Add(new quangcao("29", "KA12SSA", "Card Do Hoa", "AS12KUY", "Ho Gia The", "23:75:23", "533,000,000"));
            quangcaos.Add(new quangcao("30", "NS92SDF", "Ao Len", "HT14HTY", "Vo Binh Phu Duong", "49:34:12", "95,000,000"));

        }
    }
}
