﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace SharePoint.Modernization.Framework {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2018/01/PageTransformationSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.dev.office.com/PnP/2018/01/PageTransformationSchema", IsNullable=false)]
    public partial class PageTransformation {
        
        private BaseWebPart baseWebPartField;
        
        private WebPart[] webPartsField;
        
        /// <remarks/>
        public BaseWebPart BaseWebPart {
            get {
                return this.baseWebPartField;
            }
            set {
                this.baseWebPartField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public WebPart[] WebParts {
            get {
                return this.webPartsField;
            }
            set {
                this.webPartsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2018/01/PageTransformationSchema")]
    public partial class BaseWebPart {
        
        private Property[] propertiesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Property[] Properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2018/01/PageTransformationSchema")]
    public partial class Property {
        
        private string nameField;
        
        private PropertyType typeField;
        
        private string transformField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PropertyType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Transform {
            get {
                return this.transformField;
            }
            set {
                this.transformField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.dev.office.com/PnP/2018/01/PageTransformationSchema")]
    public enum PropertyType {
        
        /// <remarks/>
        @string,
        
        /// <remarks/>
        @bool,
        
        /// <remarks/>
        guid,
        
        /// <remarks/>
        integer,
        
        /// <remarks/>
        datetime,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2018/01/PageTransformationSchema")]
    public partial class ClientSideWebPart {
        
        private ClientSideWebPartType typeField;
        
        private string controlIdField;
        
        private string jsonControlDataField;
        
        private string orderField;
        
        private string mappingField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ClientSideWebPartType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ControlId {
            get {
                return this.controlIdField;
            }
            set {
                this.controlIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string JsonControlData {
            get {
                return this.jsonControlDataField;
            }
            set {
                this.jsonControlDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Mapping {
            get {
                return this.mappingField;
            }
            set {
                this.mappingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.dev.office.com/PnP/2018/01/PageTransformationSchema")]
    public enum ClientSideWebPartType {
        
        /// <remarks/>
        Custom,
        
        /// <remarks/>
        Text,
        
        /// <remarks/>
        ContentRollup,
        
        /// <remarks/>
        BingMap,
        
        /// <remarks/>
        ContentEmbed,
        
        /// <remarks/>
        DocumentEmbed,
        
        /// <remarks/>
        Image,
        
        /// <remarks/>
        ImageGallery,
        
        /// <remarks/>
        LinkPreview,
        
        /// <remarks/>
        NewsFeed,
        
        /// <remarks/>
        NewsReel,
        
        /// <remarks/>
        PowerBIReportEmbed,
        
        /// <remarks/>
        QuickChart,
        
        /// <remarks/>
        SiteActivity,
        
        /// <remarks/>
        VideoEmbed,
        
        /// <remarks/>
        YammerEmbed,
        
        /// <remarks/>
        Events,
        
        /// <remarks/>
        GroupCalendar,
        
        /// <remarks/>
        Hero,
        
        /// <remarks/>
        List,
        
        /// <remarks/>
        PageTitle,
        
        /// <remarks/>
        People,
        
        /// <remarks/>
        QuickLinks,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2018/01/PageTransformationSchema")]
    public partial class ClientSideText {
        
        private string textField;
        
        private string orderField;
        
        private string mappingField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Mapping {
            get {
                return this.mappingField;
            }
            set {
                this.mappingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2018/01/PageTransformationSchema")]
    public partial class Mapping {
        
        private ClientSideText[] clientSideTextField;
        
        private ClientSideWebPart[] clientSideWebPartField;
        
        private string nameField;
        
        private bool defaultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClientSideText")]
        public ClientSideText[] ClientSideText {
            get {
                return this.clientSideTextField;
            }
            set {
                this.clientSideTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClientSideWebPart")]
        public ClientSideWebPart[] ClientSideWebPart {
            get {
                return this.clientSideWebPartField;
            }
            set {
                this.clientSideWebPartField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.dev.office.com/PnP/2018/01/PageTransformationSchema")]
    public partial class WebPart {
        
        private Property[] propertiesField;
        
        private Mapping[] mappingsField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Property[] Properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Mapping[] Mappings {
            get {
                return this.mappingsField;
            }
            set {
                this.mappingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
}
