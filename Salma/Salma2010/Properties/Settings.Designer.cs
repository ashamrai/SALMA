﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Salma2010.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" />")]
        public global::System.Collections.Specialized.StringCollection ConnectionURLs {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ConnectionURLs"]));
            }
            set {
                this["ConnectionURLs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SellectedConnectionUrl {
            get {
                return ((string)(this["SellectedConnectionUrl"]));
            }
            set {
                this["SellectedConnectionUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool isFullVerion {
            get {
                return ((bool)(this["isFullVerion"]));
            }
            set {
                this["isFullVerion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool isExpired {
            get {
                return ((bool)(this["isExpired"]));
            }
            set {
                this["isExpired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Obsolete_Title_Checked {
            get {
                return ((bool)(this["Obsolete_Title_Checked"]));
            }
            set {
                this["Obsolete_Title_Checked"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Obsolete_Tag_Checked {
            get {
                return ((bool)(this["Obsolete_Tag_Checked"]));
            }
            set {
                this["Obsolete_Tag_Checked"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[Obsolete]")]
        public string Obsolete_Title_Text {
            get {
                return ((string)(this["Obsolete_Title_Text"]));
            }
            set {
                this["Obsolete_Title_Text"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Obsolete")]
        public string Obsolete_Tag_Text {
            get {
                return ((string)(this["Obsolete_Tag_Text"]));
            }
            set {
                this["Obsolete_Tag_Text"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://\\S+;https://\\S+;ftp://\\S+")]
        public string Settings_docshare_pathpattern {
            get {
                return ((string)(this["Settings_docshare_pathpattern"]));
            }
            set {
                this["Settings_docshare_pathpattern"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Settings_docshare_link {
            get {
                return ((bool)(this["Settings_docshare_link"]));
            }
            set {
                this["Settings_docshare_link"] = value;
            }
        }
    }
}
