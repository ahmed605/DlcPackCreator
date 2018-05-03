using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DlcCreator.Utils;
using System.Windows.Forms;
using System.IO;
using CodeWalker.GameFiles;
using System.Xml;

namespace DlcCreator.Utils
{
    class Dlc
    {
        public static void Create(string Type ,string dlcName, string savePath)
        {
            try
            {
                Directory.CreateDirectory(savePath);

                var dlcRpf = RpfFile.CreateNew(savePath, "dlc.rpf", RpfEncryption.OPEN);

                var x64folder = RpfFile.CreateDirectory(dlcRpf.Root, "x64");

                //create metas
                RpfFile.CreateFile(dlcRpf.Root, "content.xml", CreateContent(Type, dlcName));
                RpfFile.CreateFile(dlcRpf.Root, "setup2.xml", CreateSetup(Type, dlcName));


                //Dlc Map Pack
                if (Type == "Map")
                {
                    var levelsFolder = RpfFile.CreateDirectory(x64folder, "levels");

                    var gta5Fodler = RpfFile.CreateDirectory(levelsFolder, "gta5");

                    var dlcChildRpf = RpfFile.CreateNew(gta5Fodler, dlcName + ".rpf", RpfEncryption.OPEN);

                    var dlcMetaChildRpf = RpfFile.CreateNew(gta5Fodler, dlcName + "_metadata.rpf", RpfEncryption.OPEN);
                }

                if (Type == "Vehicle")
                {

                }

                MessageBox.Show("Successfully created dlc pack at: " + savePath);
            }
            catch
            {
                MessageBox.Show("Error dlc pack already exist at: " + savePath);
            }
        }

        private static Byte[] CreateContent(string Type, string dlcName)
        {
            string data = null;
            byte[] file = null;

            if (Type == "Map")
            {
                data = GenerateMetaData.GenerateContentXML(dlcName);
                file = Encoding.ASCII.GetBytes(data);
            }

            return file;
        }

        private static Byte[] CreateSetup(string Type, string dlcName)
        {
            string data = null;
            byte[] file = null;

            if(Type == "Map")
            {
                data = GenerateMetaData.GenerateSetup2XML(dlcName);
                file = Encoding.ASCII.GetBytes(data);
            }

            return file;
        }
    }
}
