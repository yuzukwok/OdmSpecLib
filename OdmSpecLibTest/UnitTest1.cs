using System.IO;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdmLib;

namespace OdmSpecLibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ODM odm = new ODM();
            odm.AdminData = new AdminData();
            odm.ClinicalData = new ClinicalData();
            odm.Study = new ODMStudy();
            odm.Study.MetaDataVersion = new ODMStudyMetaDataVersion();
            odm.Study.MetaDataVersion.OID = "oid";
            XmlSerializer serializer = new XmlSerializer(typeof(ODM));
            TextWriter writer = new StreamWriter("odm.xml");
            serializer.Serialize(writer, odm);
        }
    }
}
