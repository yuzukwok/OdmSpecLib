using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionConditionDefDescription
    {
        private ODMStudyMetaDataVersionConditionDefDescriptionTranslatedText translatedTextField;

        /// <remarks />
        public ODMStudyMetaDataVersionConditionDefDescriptionTranslatedText TranslatedText
        {
            get => translatedTextField;
            set => translatedTextField = value;
        }
    }
}