using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。

    /// <remarks />
    [SerializableAttribute]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ClinicalData
    {
        private string metaDataVersionOIDField;

        private string studyOIDField;

        private ClinicalDataSubjectData subjectDataField;

        /// <remarks />
        public ClinicalDataSubjectData SubjectData
        {
            get => subjectDataField;
            set => subjectDataField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string StudyOID
        {
            get => studyOIDField;
            set => studyOIDField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string MetaDataVersionOID
        {
            get => metaDataVersionOIDField;
            set => metaDataVersionOIDField = value;
        }
    }
}