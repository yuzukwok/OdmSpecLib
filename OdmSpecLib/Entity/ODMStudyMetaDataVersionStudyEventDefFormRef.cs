using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionStudyEventDefFormRef
    {
        private string formOIDField;

        private string mandatoryField;

        /// <remarks />
        [XmlAttribute]
        public string FormOID
        {
            get => formOIDField;
            set => formOIDField = value;
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