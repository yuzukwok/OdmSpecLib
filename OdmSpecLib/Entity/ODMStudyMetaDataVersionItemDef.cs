using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionItemDef
    {
        private ODMStudyMetaDataVersionItemDefCodeListRef codeListRefField;

        private string dataTypeField;

        private ODMStudyMetaDataVersionItemDefMeasurementUnitRef measurementUnitRefField;

        private string nameField;

        private string oIDField;

        private ODMStudyMetaDataVersionItemDefTranslatedText[] questionField;

        private ODMStudyMetaDataVersionItemDefRangeCheck[] rangeCheckField;

        /// <remarks />
        [XmlArrayItem("TranslatedText", IsNullable = false)]
        public ODMStudyMetaDataVersionItemDefTranslatedText[] Question
        {
            get => questionField;
            set => questionField = value;
        }

        /// <remarks />
        public ODMStudyMetaDataVersionItemDefMeasurementUnitRef MeasurementUnitRef
        {
            get => measurementUnitRefField;
            set => measurementUnitRefField = value;
        }

        /// <remarks />
        [XmlElement("RangeCheck")]
        public ODMStudyMetaDataVersionItemDefRangeCheck[] RangeCheck
        {
            get => rangeCheckField;
            set => rangeCheckField = value;
        }

        /// <remarks />
        public ODMStudyMetaDataVersionItemDefCodeListRef CodeListRef
        {
            get => codeListRefField;
            set => codeListRefField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string OID
        {
            get => oIDField;
            set => oIDField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string Name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string DataType
        {
            get => dataTypeField;
            set => dataTypeField = value;
        }
    }
}