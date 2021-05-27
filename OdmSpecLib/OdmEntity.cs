using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks />
    [SerializableAttribute]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    [XmlRoot(Namespace = "http://www.cdisc.org/ns/odm/v1.3", IsNullable = false)]
    public class ODM
    {
        private DateTime creationDateTimeField;

        private string fileOIDField;

        private string fileTypeField;

        private string oDMVersionField;

        private string sourceSystemField;

        private ODMStudy studyField;

        private ClinicalData clinicalDataField;

        private AdminData adminDataField;


        /// <remarks />
        public ODMStudy Study
        {
            get => studyField;
            set => studyField = value;
        }

        public ClinicalData ClinicalData
        {
            get => clinicalDataField;
            set => clinicalDataField = value;
        }

        public AdminData AdminData
        {
            get => adminDataField;
            set => adminDataField = value;
        }


        /// <remarks />
        [XmlAttribute]
        public string FileType
        {
            get => fileTypeField;
            set => fileTypeField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string FileOID
        {
            get => fileOIDField;
            set => fileOIDField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public DateTime CreationDateTime
        {
            get => creationDateTimeField;
            set => creationDateTimeField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string ODMVersion
        {
            get => oDMVersionField;
            set => oDMVersionField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string SourceSystem
        {
            get => sourceSystemField;
            set => sourceSystemField = value;
        }
    }
}