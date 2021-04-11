using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;
using System.Runtime.Serialization;
using System.Threading;

namespace ClBot.Functions
{
    public static class Storage
    {
        private static string mainPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"ClBot/Settings.txt");

        public static void Save(Settings settings)
        {
            // сериализация и сохранение
            XmlTextWriter xmlWriter = new XmlTextWriter(mainPath, Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;

            XmlDictionaryWriter writer = XmlDictionaryWriter.CreateDictionaryWriter(xmlWriter);
            DataContractSerializer serialization = new DataContractSerializer(typeof(Settings));
            serialization.WriteObject(writer, settings);
            writer.Close();
            xmlWriter.Close();
        }

        public static Settings Load()
        {
            Settings settings = new Settings();

            // если нет файла для загрузки 
            if (!(File.Exists(mainPath)))
            {
                // сохранить стандартные значения 
                Save(settings);
            }
            else
            {
                // очистить настройки и загрузить из файла
                settings = null;

                using (FileStream fs = new FileStream(mainPath, FileMode.Open))
                {
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, Encoding.UTF8, new XmlDictionaryReaderQuotas(), null);
                    DataContractSerializer ser = new DataContractSerializer(typeof(Settings));
                    settings = (Settings)ser.ReadObject(reader);
                }

                settings.date = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
            }

            return settings;
        }
    }
}
