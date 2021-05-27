using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionItemDefRangeCheck
    {
        private byte checkValueField;

        private string comparatorField;

        private string softHardField;

        /// <remarks />
        public byte CheckValue
        {
            get => checkValueField;
            set => checkValueField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string Comparator
        {
            get => comparatorField;
            set => comparatorField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string SoftHard
        {
            get => softHardField;
            set => softHardField = value;
        }
    }
}