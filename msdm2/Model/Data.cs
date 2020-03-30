using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msdm2.Model
{
    public interface IData
    {
        List<List<string>> drivers_data { get; set; }
        List<List<string>> managers_data { get; set; }
        List<List<string>> storages_data { get; set; }
        List<List<string>> goodss_data { get; set; }


        void filling_list_drivers();
        void filling_list_managers();
        void filling_list_storages();
        void filling_list_goodss();

    }
    public class Data : IData
    {
        public List<List<string>> drivers_data { get; set; } = new List<List<string>>();
        public List<List<string>> managers_data { get; set; } = new List<List<string>>();
        public List<List<string>> storages_data { get; set; } = new List<List<string>>();
        public List<List<string>> goodss_data { get; set; } = new List<List<string>>();


        public void filling_list_drivers()
        {
            var sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Model\\Data\\\\drivers.txt")); //читаємо файл
            string file_cont = sr.ReadToEnd(); //переводимо в string

            string[] lines = file_cont.Split(' '); //розбиваємо на об'єкти
            var a = lines.Count();
            for (int k = 0; k < lines.Length; k++)
            {
                string[] bit = lines[k].Split('_');
                drivers_data.Add(new List<string>() { bit[0], Convert.ToString(DateTimeOffset.UtcNow.ToUnixTimeSeconds()), bit[1] }); //додаємо дані в список
            }
        }

        public void filling_list_managers()
        {
            var sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Model\\Data\\\\managers.txt"));
            string file_cont = sr.ReadToEnd();

            string[] lines = file_cont.Split(' ');
            var a = lines.Count();
            for (int k = 0; k < lines.Length; k++)
            {
                string[] bit = lines[k].Split('_');
                managers_data.Add(new List<string>() { bit[0], Convert.ToString(DateTimeOffset.UtcNow.ToUnixTimeSeconds()), bit[1] });
            }
        }

        public void filling_list_storages()
        {
            var sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Model\\Data\\\\storages.txt"));
            string file_cont = sr.ReadToEnd();

            string[] lines = file_cont.Split(' ');
            var a = lines.Count();
            for (int k = 0; k < lines.Length; k++)
            {
                string[] bit = lines[k].Split('_');
                storages_data.Add(new List<string>() { bit[0], bit[1] });
            }
        }

        public void filling_list_goodss()
        {
            var sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Model\\Data\\\\goodss.txt"));
            string file_cont = sr.ReadToEnd();

            string[] lines = file_cont.Split(' ');

            for (int k = 0; k < lines.Length; k++)
            {
                string[] bit = lines[k].Split('_');
                goodss_data.Add(new List<string>() { bit[0], bit[1] });
            }
        }
    }
}
