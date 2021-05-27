using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudy
    {
        private ODMStudyMeasurementUnit[] basicDefinitionsField;

        private ODMStudyGlobalVariables globalVariablesField;

        private ODMStudyMetaDataVersion metaDataVersionField;

        private string oIDField;

        /// <remarks />
        public ODMStudyGlobalVariables GlobalVariables
        {
            get => globalVariablesField;
            set => globalVariablesField = value;
        }

        /// <remarks />
        [XmlArrayItem("MeasurementUnit", IsNullable = false)]
        public ODMStudyMeasurementUnit[] BasicDefinitions
        {
            get => basicDefinitionsField;
            set => basicDefinitionsField = value;
        }

        /// <remarks />
        public ODMStudyMetaDataVersion MetaDataVersion
        {
            get => metaDataVersionField;
            set => metaDataVersionField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string OID
        {
            get => oIDField;
            set => oIDField = value;
        }
    }
}