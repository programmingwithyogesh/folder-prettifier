﻿#pragma checksum "A:\UWP\Folder Prettifier\Folder Prettifier\Pages\Settings.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "65313CD08A8B3EB30126EC99899D476F4BD3F7280A3A6E81312EA2703457500C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Folder_Prettifier.Pages
{
    partial class Settings : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ToggleSwitch_IsOn(global::Windows.UI.Xaml.Controls.ToggleSwitch obj, global::System.Boolean value)
            {
                obj.IsOn = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Settings_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISettings_Bindings
        {
            private global::Folder_Prettifier.Pages.Settings dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ToggleSwitch obj7;
            private global::Windows.UI.Xaml.Controls.ToggleSwitch obj8;
            private global::Windows.UI.Xaml.Controls.ToggleSwitch obj9;
            private global::Windows.UI.Xaml.Controls.ToggleSwitch obj10;
            private global::Windows.UI.Xaml.Controls.ComboBox obj11;

            public Settings_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7: // Pages\Settings.xaml line 40
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ToggleSwitch)target;
                        break;
                    case 8: // Pages\Settings.xaml line 26
                        this.obj8 = (global::Windows.UI.Xaml.Controls.ToggleSwitch)target;
                        break;
                    case 9: // Pages\Settings.xaml line 29
                        this.obj9 = (global::Windows.UI.Xaml.Controls.ToggleSwitch)target;
                        break;
                    case 10: // Pages\Settings.xaml line 32
                        this.obj10 = (global::Windows.UI.Xaml.Controls.ToggleSwitch)target;
                        break;
                    case 11: // Pages\Settings.xaml line 16
                        this.obj11 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    default:
                        break;
                }
            }

            // ISettings_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Folder_Prettifier.Pages.Settings)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Folder_Prettifier.Pages.Settings obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_isAutoManage(obj.isAutoManage, phase);
                        this.Update_isAddToPath(obj.isAddToPath, phase);
                        this.Update_isInContextMenu(obj.isInContextMenu, phase);
                        this.Update_isAutoStart(obj.isAutoStart, phase);
                        this.Update_theme(obj.theme, phase);
                    }
                }
            }
            private void Update_isAutoManage(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Settings.xaml line 40
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ToggleSwitch_IsOn(this.obj7, obj);
                }
            }
            private void Update_isAddToPath(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Settings.xaml line 26
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ToggleSwitch_IsOn(this.obj8, obj);
                }
            }
            private void Update_isInContextMenu(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Settings.xaml line 29
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ToggleSwitch_IsOn(this.obj9, obj);
                }
            }
            private void Update_isAutoStart(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Settings.xaml line 32
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ToggleSwitch_IsOn(this.obj10, obj);
                }
            }
            private void Update_theme(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Settings.xaml line 16
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(this.obj11, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\Settings.xaml line 109
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.ResetSettings;
                }
                break;
            case 3: // Pages\Settings.xaml line 96
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.OpenAbout;
                }
                break;
            case 4: // Pages\Settings.xaml line 98
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.OpenLicense;
                }
                break;
            case 5: // Pages\Settings.xaml line 100
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.OpenPrivacyPolicy;
                }
                break;
            case 6: // Pages\Settings.xaml line 102
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.OpenWebsite;
                }
                break;
            case 7: // Pages\Settings.xaml line 40
                {
                    global::Windows.UI.Xaml.Controls.ToggleSwitch element7 = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)element7).Toggled += this.ToggleAutoManage;
                }
                break;
            case 8: // Pages\Settings.xaml line 26
                {
                    global::Windows.UI.Xaml.Controls.ToggleSwitch element8 = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)element8).Toggled += this.ToggleAddToPath;
                }
                break;
            case 9: // Pages\Settings.xaml line 29
                {
                    global::Windows.UI.Xaml.Controls.ToggleSwitch element9 = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)element9).Toggled += this.ToggleInContextMenu;
                }
                break;
            case 10: // Pages\Settings.xaml line 32
                {
                    global::Windows.UI.Xaml.Controls.ToggleSwitch element10 = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)element10).Toggled += this.ToggleAutoStart;
                }
                break;
            case 11: // Pages\Settings.xaml line 16
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element11 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element11).SelectionChanged += this.ChangeTheme;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Pages\Settings.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Settings_obj1_Bindings bindings = new Settings_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
