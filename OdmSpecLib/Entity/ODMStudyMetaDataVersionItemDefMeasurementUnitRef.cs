using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionItemDefMeasurementUnitRef
    {
        private string measurementUnitOIDField;

        /// <remarks />
        [XmlAttribute]
        public string MeasurementUnitOID
        {
            get => measurementUnitOIDField;
            set => measurementUnitOIDField = value;
        }
    }
}