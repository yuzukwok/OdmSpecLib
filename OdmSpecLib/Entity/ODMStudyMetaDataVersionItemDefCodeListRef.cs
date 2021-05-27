using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionItemDefCodeListRef
    {
        private string codeListOIDField;

        /// <remarks />
        [XmlAttribute]
        public string CodeListOID
        {
            get => codeListOIDField;
            set => codeListOIDField = value;
        }
    }
}