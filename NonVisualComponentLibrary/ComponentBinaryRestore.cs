using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace NonVisualComponentLibrary
{
    public partial class ComponentBinaryRestore : Component
    {
        public ComponentBinaryRestore()
        {
            InitializeComponent();
        }

        public ComponentBinaryRestore(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        public List<T> RecoveryBackUp<T>(string path)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new Exception($"Класс {typeof(T).Name} не сериализуем");
            }
            BinaryFormatter binFormatter = new BinaryFormatter();
            List<T> restoredData = new List<T>();
            using (FileStream fileStream = new FileStream(Decompress(path,
                Path.GetDirectoryName(path) + @"\unpacked"), FileMode.Open))
            {
                restoredData = (List<T>)binFormatter.Deserialize(fileStream);
            }
            return restoredData;
        }

        private string Decompress(string file, string output)
        {
            if (Directory.Exists(output))
            {
                Directory.Delete(output, true);
            }
            ZipFile.ExtractToDirectory(file, output);
            return output + @"\file.dat";
        }

    }
}
