using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Abstract;
using TelefonRehberi.Concreate;

namespace TelefonRehberi
{
    public static class RehberProgram
    {
        public static void Start()
        {
            RehberManager rehberManager = new RehberManager();

            Person p1 = new Person { FirstName = "Vahap", LastName = "Yıldırım" };
            PhoneNumber ph1 = new PhoneNumber { Number = "542314163496", PersonId = p1.Id };
            RehberDto r1 = new RehberDto { PhoneNumber = ph1, Person = p1 };
            rehberManager.Add(r1);

            Person p2 = new Person { FirstName = "Beyza", LastName = "Yıldırım" };
            PhoneNumber ph2 = new PhoneNumber { Number = "978545663496", PersonId = p2.Id };
            RehberDto r2 = new RehberDto { PhoneNumber = ph2, Person = p2 };
            rehberManager.Add(r2);

            Person p3 = new Person { FirstName = "Hamit", LastName = "Yıldırım" };
            PhoneNumber ph3 = new PhoneNumber { Number = "542314163496", PersonId = p3.Id };
            RehberDto r3 = new RehberDto { Person = p3, PhoneNumber = ph3 };
            rehberManager.Add(r3);

            Person p4 = new Person { FirstName = "Sema", LastName = "Yıldırım" };
            PhoneNumber ph4 = new PhoneNumber { Number = "542314163496", PersonId = p4.Id };
            RehberDto r4 = new RehberDto { Person = p4, PhoneNumber = ph4 };
            rehberManager.Add(r4);

            GirisEkraniBas();

            int secim;
            do
            {
                secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case (int)Islem.Add:
                        Add(rehberManager);
                        break;
                    case (int)Islem.Delete:
                        Delete(rehberManager);
                        break;
                    case (int)Islem.Update:
                        Update(rehberManager);
                        break;
                    case (int)Islem.GetAll:
                        ListAll(rehberManager);
                        break;
                    case (int)Islem.GetBySearh:
                        Search(rehberManager);
                        break;
                    default:
                        break;
                }

            } while (secim != 6);
        }
        public static void GirisEkraniBas()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("****************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(6) Çıkış Yap");
        }
        public static void Add(IRehberService rehberService)
        {
            Console.Write("Lütfen isim giriniz: ");
            string firstName = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz: ");
            string lastName = Console.ReadLine();
            Person p = new Person { FirstName = firstName, LastName = lastName };

            Console.Write("Numarayı giriniz: ");
            string number = Console.ReadLine();
            PhoneNumber pn = new PhoneNumber { Number = number, PersonId = p.Id };

            RehberDto rehberDto = new RehberDto { Person = p, PhoneNumber = pn };
            rehberService.Add(rehberDto);
            Console.WriteLine("Eklendi.***");
            Console.WriteLine("**********");
            GirisEkraniBas();

        }
        public static void Delete(IRehberService rehberService)
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string name = Console.ReadLine();
            var bulunan = rehberService.GetByName(name);
            if (bulunan == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("*Silmeyi sondlandırmak için (1)");
                Console.WriteLine("*Yeniden denemek için (2)");
                var num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    GirisEkraniBas();
                }
                if (num == 2)
                {
                    Delete(rehberService);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} isimli kişiyi rehberden silmek istiyor musunuz? (y/n)", bulunan.Person.FirstName, bulunan.Person.LastName);
                char secim = Console.ReadLine()[0];
                if (Char.ToUpper(secim) == 'Y')
                {
                    rehberService.Delete(bulunan);
                }
                GirisEkraniBas();
            }
        }
        public static void Update(IRehberService rehberService)
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string name = Console.ReadLine();
            var bulunan = rehberService.GetByName(name);
            if (bulunan == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("*Silmeyi sondlandırmak için (1)");
                Console.WriteLine("*Yeniden denemek için (2)");
                var num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    GirisEkraniBas();
                }
                if (num == 2)
                {
                    Update(rehberService);
                }
            }
            else
            {
                Console.WriteLine("Yeni numarayı giriniz");
                string numara = Console.ReadLine();
                RehberDto rehberDto = new RehberDto { Person = bulunan.Person, PhoneNumber = new PhoneNumber { Id = bulunan.PhoneNumber.Id, Number = numara, PersonId = bulunan.PhoneNumber.PersonId } };
                rehberService.Update(rehberDto);
                GirisEkraniBas();
            }

        }
        public static void ListAll(IRehberService rehberService)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("****************************");
            foreach (var item in rehberService.GetAll())
            {
                Console.WriteLine("İsim: {0}", item.Person.FirstName);
                Console.WriteLine("Soyisim: {0}", item.Person.LastName);
                Console.WriteLine("Telefon Numarası: {0}", item.PhoneNumber.Number);
                Console.WriteLine("------");
            }
            GirisEkraniBas();
        }
        public static void Search(IRehberService rehberService)
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz");
            Console.WriteLine("****************");
            Console.WriteLine();
            Console.WriteLine("İsim veya soyisime göre arama yapmak için (1)");
            Console.WriteLine("Telefon nosuna göre arama yapmak için (2)");
            int secim = int.Parse(Console.ReadLine());
            if (secim==1)
            {
                Console.WriteLine("İsim veya soyisim giriniz");
                string name = Console.ReadLine();
                foreach (var item in rehberService.GetAllByName(name))
                {
                    Console.WriteLine("İsim: "+item.Person.FirstName);
                    Console.WriteLine("Soyisim: "+item.Person.LastName);
                    Console.WriteLine("Telefon Numarası: "+item.PhoneNumber.Number);
                    Console.WriteLine("------");
                }
               
                GirisEkraniBas();
            }
            if (secim==2)
            {
                Console.WriteLine("Numara giriniz");
                string number = Console.ReadLine();
                var item = rehberService.GetByNumber(number);
                Console.WriteLine("İsim: " + item.Person.FirstName);
                Console.WriteLine("Soyisim: " + item.Person.LastName);
                Console.WriteLine("Telefon Numarası: " + item.PhoneNumber.Number);
                GirisEkraniBas();
            }
            else
            GirisEkraniBas();
        }
        public enum Islem
        {
            Add = 1,
            Delete = 2,
            Update = 3,
            GetAll = 4,
            GetBySearh = 5
        }
    }
}
