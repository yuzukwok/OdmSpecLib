using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemData
    {
        private string itemOIDField;

        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string ItemOID
        {
            get => itemOIDField;
            set => itemOIDField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string Value
        {
            get => valueField;
            set => valueField = value;
        }
    }
}