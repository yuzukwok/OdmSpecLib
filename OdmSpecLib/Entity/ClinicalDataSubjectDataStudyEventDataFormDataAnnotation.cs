using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ClinicalDataSubjectDataStudyEventDataFormDataAnnotation
    {
        private ClinicalDataSubjectDataStudyEventDataFormDataAnnotationFlag flagField;

        private byte seqNumField;

        /// <remarks />
        public ClinicalDataSubjectDataStudyEventDataFormDataAnnotationFlag Flag
        {
            get => flagField;
            set => flagField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public byte SeqNum
        {
            get => seqNumField;
            set => seqNumField = value;
        }
    }
}