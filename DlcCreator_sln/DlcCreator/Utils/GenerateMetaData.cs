using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace DlcCreator.Utils
{
    public static class GenerateMetaData
    {
        public static string GenerateContentXML(string DlcName)
        {
            //XmlDocument doc = new XmlDocument();

            string path = ":/%PLATFORM%/levels/gta5/";
            string rpfPath = "dlc_" + DlcName + path + DlcName + ".rpf";
            string metaRpfPath = "dlc_" + DlcName + path + DlcName + "_metadata.rpf";
            string changeSetsName = "CCS_" + DlcName + "_NG_STREAMING_MAP";

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sb.AppendLine("<CDataFileMgr__ContentsOfDataFileXml>");
            sb.AppendLine("\t<disabledFiles />");
            sb.AppendLine("\t<includedXmlFiles />");
            sb.AppendLine("\t<includedDataFiles />");
            sb.AppendLine("\t<dataFiles>");

            sb.AppendLine("\t\t<Item>");
            sb.AppendLine("\t\t\t<filename>" + rpfPath + "</filename>");
            sb.AppendLine("\t\t\t<fileType>RPF_FILE</fileType>");
            sb.AppendLine("\t\t\t<overlay value=\"false\" />");
            sb.AppendLine("\t\t\t<disabled value=\"false\" />");
            sb.AppendLine("\t\t\t<persistent value=\"false\" />");
            sb.AppendLine("\t\t</Item>");

            sb.AppendLine("\t\t<Item>");
            sb.AppendLine("\t\t\t<filename>" + metaRpfPath + "</filename>");
            sb.AppendLine("\t\t\t<fileType>RPF_FILE</fileType>");
            sb.AppendLine("\t\t\t<overlay value=\"false\" />");
            sb.AppendLine("\t\t\t<disabled value=\"false\" />");
            sb.AppendLine("\t\t\t<persistent value=\"false\" />");
            sb.AppendLine("\t\t\t<contents>CONTENTS_DLC_MAP_DATA</contents>");
            sb.AppendLine("\t\t</Item>");

            sb.AppendLine("\t</dataFiles>");
            sb.AppendLine("\t<contentChangeSets>");
            sb.AppendLine("\t\t<Item>");
            sb.AppendLine("\t\t\t<changeSetName>" + changeSetsName + "</changeSetName>");

            sb.AppendLine("\t\t\t<filesToEnable>");
            sb.AppendLine("\t\t\t\t<Item>" + rpfPath + "</Item>");
            sb.AppendLine("\t\t\t\t<Item>" + metaRpfPath + "</Item>");
            sb.AppendLine("\t\t\t</filesToEnable>");

            sb.AppendLine("\t\t\t<executionConditions>");
            sb.AppendLine("\t\t\t\t<activeChangesetConditions>");
            sb.AppendLine("\t\t\t\t</activeChangesetConditions>");
            sb.AppendLine("\t\t\t\t<genericConditions>$level=MO_JIM_L11</genericConditions>");
            sb.AppendLine("\t\t\t</executionConditions>");
            sb.AppendLine("\t\t</Item>");
            sb.AppendLine("\t</contentChangeSets>");
            sb.AppendLine("\t<patchFiles />");
            //sb.AppendLine("\t<ExportedBY>Skylumz Dlc Meta Creator</ExportedBY>");
            sb.AppendLine("</CDataFileMgr__ContentsOfDataFileXml>");

            return sb.ToString();
        }

        public static string GenerateSetup2XML(string DlcName)
        {

            var Timestamp = new DateTime();
            Timestamp = DateTime.Now;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sb.AppendLine("<SSetupData>");
            sb.AppendLine("\t<deviceName>dlc_" + DlcName + "</deviceName>");
            sb.AppendLine("\t<datFile>content.xml</datFile>");
            sb.AppendLine("\t<timeStamp>" + Timestamp + "</timeStamp>");
            sb.AppendLine("\t<nameHash>" + DlcName + "</nameHash>");
            sb.AppendLine("\t<contentChangeSets />");
            sb.AppendLine("\t<contentChangeSetGroups>");

            sb.AppendLine("\t\t<Item>");
            sb.AppendLine("\t\t\t<NameHash>GROUP_EARLY_ON</NameHash>");
            sb.AppendLine("\t\t\t<ContentChangeSets>");
            sb.AppendLine("\t\t\t\t<Item>CCS_" + DlcName + "_NG_INIT</Item>");
            sb.AppendLine("\t\t\t</ContentChangeSets>");
            sb.AppendLine("\t\t</Item>");

            sb.AppendLine("\t\t<Item>");
            sb.AppendLine("\t\t\t<NameHash>GROUP_TITLEUPDATE_STARTUP</NameHash>");
            sb.AppendLine("\t\t\t<ContentChangeSets />");
            sb.AppendLine("\t\t</Item>");

            sb.AppendLine("\t\t<Item>");
            sb.AppendLine("\t\t\t<NameHash>GROUP_UPDATE_STREAMING</NameHash>");
            sb.AppendLine("\t\t\t<ContentChangeSets>");
            sb.AppendLine("\t\t\t\t<Item>CCS_" + DlcName + "_NG_STREAMING</Item>");
            sb.AppendLine("\t\t\t\t<Item>CCS_" + DlcName + "_NG_STREAMING_MAP</Item>");
            sb.AppendLine("\t\t\t</ContentChangeSets>");
            sb.AppendLine("\t\t</Item>");

            sb.AppendLine("\t\t<Item>");
            sb.AppendLine("\t\t\t<NameHash>GROUP_UPDATE_TEXT</NameHash>");
            sb.AppendLine("\t\t\t<ContentChangeSets>");
            sb.AppendLine("\t\t\t\t<Item>CCS_" + DlcName + "_NG_TEXT</Item>");
            sb.AppendLine("\t\t\t</ContentChangeSets>");
            sb.AppendLine("\t\t</Item>");

            sb.AppendLine("\t\t<Item>");
            sb.AppendLine("\t\t\t<NameHash>GROUP_UPDATE_DLC_PATCH</NameHash>");
            sb.AppendLine("\t\t\t<ContentChangeSets />");
            sb.AppendLine("\t\t</Item>");

            sb.AppendLine("\t\t<Item>");
            sb.AppendLine("\t\t\t<NameHash>GROUP_UPDATE_DLC_METADATA</NameHash>");
            sb.AppendLine("\t\t\t<ContentChangeSets />");
            sb.AppendLine("\t\t</Item>");

            sb.AppendLine("\t\t<Item>");
            sb.AppendLine("\t\t\t<NameHash>GROUP_UPDATE_WEAPON_PATCH</NameHash>");
            sb.AppendLine("\t\t\t<ContentChangeSets />");
            sb.AppendLine("\t\t</Item>");

            sb.AppendLine("\t\t<Item>");
            sb.AppendLine("\t\t\t<NameHash>GROUP_STARTUP</NameHash>");
            sb.AppendLine("\t\t\t<ContentChangeSets />");
            sb.AppendLine("\t\t</Item>");

            sb.AppendLine("\t\t<Item>");
            sb.AppendLine("\t\t\t<NameHash>GROUP_ON_DEMAND</NameHash>");
            sb.AppendLine("\t\t\t<ContentChangeSets />");
            sb.AppendLine("\t\t</Item>");

            sb.AppendLine("\t</contentChangeSetGroups>");
            sb.AppendLine("\t<startupScript />");
            sb.AppendLine("\t<scriptCallstackSize value=\"0\" />");
            sb.AppendLine("\t<type>EXTRACONTENT_LEVEL_PACK</type>");
            sb.AppendLine("\t<order value=\"2\" />");
            sb.AppendLine("\t<minorOrder value=\"0\" />");
            sb.AppendLine("\t<isLevelPack value=\"true\" />");
            sb.AppendLine("\t<dependencyPackHash />");
            sb.AppendLine("\t<requiredVersion />");
            sb.AppendLine("\t<subPackCount value=\"0\" />");
            sb.AppendLine("</SSetupData>");


            return sb.ToString();
        }
    }
}
