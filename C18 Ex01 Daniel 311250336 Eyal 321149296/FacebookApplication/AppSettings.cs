﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public class AppSettings
    {
        public string AccessToken { get; set; }

        public Size WindowSize { get; set; }

        public Point WindowLocation { get; set; }

        public bool RememberMe { get; set; }

        public static AppSettings LoadFromFile()
        {
            AppSettings saved;

            try
            {
                using (Stream stream = new FileStream(@"C:\temp\appSettings.xml", FileMode.Open))
                {
                    XmlSerializer serlizer = new XmlSerializer(typeof(AppSettings));

                    saved = serlizer.Deserialize(stream) as AppSettings;
                }
            }
            catch (Exception ex)
            {
                saved = new AppSettings();
            }

            return saved;
        }

        public AppSettings()
        {
            AccessToken = null;
            WindowSize = new Size(500, 800);
            WindowLocation = new Point(50, 50);
            RememberMe = false;
        }

        public void SaveToFile()
        {
            if (File.Exists(@"C:\temp\appSettings.xml"))
            {
                createXML(FileMode.Truncate);
            }
            else
            {
                createXML(FileMode.Create);
            }
        }

        private void createXML(FileMode mode)
        {
            using (Stream stream = new FileStream(@"C:\temp\appSettings.xml", mode))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
