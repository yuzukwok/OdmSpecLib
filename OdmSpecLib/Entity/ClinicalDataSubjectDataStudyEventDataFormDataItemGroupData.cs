using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ClinicalDataSubjectDataStudyEventDataFormDataItemGroupData
    {
        private ClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemData[] itemDataField;

        private string itemGroupOIDField;

        /// <remarks />
        [XmlElement("ItemData")]
        public ClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemData[] ItemData
        {
            get => itemDataField;
            set => itemDataField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string ItemGroupOID
        {
            get => itemGroupOIDField;
            set => itemGroupOIDField = value;
        }
    }
}