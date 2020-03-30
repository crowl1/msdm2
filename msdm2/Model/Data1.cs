using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msdm2.Model
{
    /*
    public interface IData
    {
        List<List<string>> LoadData();
        void SaveData(List<List<string>> orders);
    }
    class Data : IData
    {
        private readonly string PATH;

        public List<List<string>> LoadData()
        {
            var FileExists = File.Exists(PATH);
            if (!FileExists)
            {
                File.CreateText(PATH).Dispose();
                return new List<List<string>>();
            }
            using (var reader = File.OpenText(PATH))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<List<string>>>(fileText);
            }
        }
        public void SaveData(List<List<string>> orders)
        {
            using(StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(orders);
                writer.Write(output);
            }
        }
    }*/
}
