using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionItemGroupDefItemRef
    {
        private string collectionExceptionConditionOIDField;

        private string itemOIDField;

        private string mandatoryField;

        /// <remarks />
        [XmlAttribute]
        public string ItemOID
        {
            get => itemOIDField;
            set => itemOIDField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string Mandatory
        {
            get => mandatoryField;
            set => mandatoryField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string CollectionExceptionConditionOID
        {
            get => collectionExceptionConditionOIDField;
            set => collectionExceptionConditionOIDField = value;
        }
    }
}