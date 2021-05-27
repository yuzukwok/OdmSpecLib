using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionFormDefItemGroupRef
    {
        private string itemGroupOIDField;

        private string mandatoryField;

        /// <remarks />
        [XmlAttribute]
        public string ItemGroupOID
        {
            get => itemGroupOIDField;
            set => itemGroupOIDField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string Mandatory
        {
            get => mandatoryField;
            set => mandatoryField = value;
        }
    }
}