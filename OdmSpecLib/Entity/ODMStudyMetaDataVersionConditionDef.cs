using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionConditionDef
    {
        private ODMStudyMetaDataVersionConditionDefDescription descriptionField;

        private ODMStudyMetaDataVersionConditionDefFormalExpression formalExpressionField;

        private string nameField;

        private string oIDField;

        /// <remarks />
        public ODMStudyMetaDataVersionConditionDefDescription Description
        {
            get => descriptionField;
            set => descriptionField = value;
        }

        /// <remarks />
        public ODMStudyMetaDataVersionConditionDefFormalExpression FormalExpression
        {
            get => formalExpressionField;
            set => formalExpressionField = value;
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
    }
}