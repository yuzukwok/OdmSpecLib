using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ClinicalDataSubjectDataStudyEventDataFormDataAnnotationFlag
    {
        private ClinicalDataSubjectDataStudyEventDataFormDataAnnotationFlagFlagValue flagValueField;

        /// <remarks />
        public ClinicalDataSubjectDataStudyEventDataFormDataAnnotationFlagFlagValue FlagValue
        {
            get => flagValueField;
            set => flagValueField = value;
        }
    }
}