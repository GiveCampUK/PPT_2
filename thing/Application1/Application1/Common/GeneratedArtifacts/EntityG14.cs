

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    public sealed partial class PurposeType : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the PurposeType entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public PurposeType()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public PurposeType(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.PurposeType> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.PurposeType.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void PurposeType_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void PurposeType_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.PurposeType.DetailsClass.GetValue(this, global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties.Id);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Name
        {
            get
            {
                return global::LightSwitchApplication.PurposeType.DetailsClass.GetValue(this, global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties.Name);
            }
            set
            {
                global::LightSwitchApplication.PurposeType.DetailsClass.SetValue(this, global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties.Name, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Name_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Name_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Name_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string ShortCode
        {
            get
            {
                return global::LightSwitchApplication.PurposeType.DetailsClass.GetValue(this, global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties.ShortCode);
            }
            set
            {
                global::LightSwitchApplication.PurposeType.DetailsClass.SetValue(this, global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties.ShortCode, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ShortCode_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ShortCode_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ShortCode_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.PurposeType,
                global::LightSwitchApplication.PurposeType.DetailsClass,
                global::LightSwitchApplication.PurposeType.DetailsClass.IImplementation,
                global::LightSwitchApplication.PurposeType.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass>.Entry
                __PurposeTypeEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass>.Entry(
                    global::LightSwitchApplication.PurposeType.DetailsClass.__PurposeType_CreateNew,
                    global::LightSwitchApplication.PurposeType.DetailsClass.__PurposeType_Created,
                    global::LightSwitchApplication.PurposeType.DetailsClass.__PurposeType_AllowSaveWithErrors);
            private static global::LightSwitchApplication.PurposeType __PurposeType_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.PurposeType> es)
            {
                return new global::LightSwitchApplication.PurposeType(es);
            }
            private static void __PurposeType_Created(global::LightSwitchApplication.PurposeType e)
            {
                e.PurposeType_Created();
            }
            private static bool __PurposeType_AllowSaveWithErrors(global::LightSwitchApplication.PurposeType e)
            {
                bool result = false;
                e.PurposeType_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.PurposeType.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, string> Name
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties.Name) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, string> ShortCode
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties.ShortCode) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, string>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; }
                new string Name { get; set; }
                new string ShortCode { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        null,
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.PurposeType.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, int>.Data> c, global::LightSwitchApplication.PurposeType.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.PurposeType e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.PurposeType e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.PurposeType.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.PurposeType e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, string>.Entry
                    Name = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, string>.Entry(
                        "Name",
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._Name_Stub,
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._Name_ComputeIsReadOnly,
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._Name_Validate,
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._Name_GetImplementationValue,
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._Name_SetImplementationValue,
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._Name_OnValueChanged);
                private static void _Name_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.PurposeType.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, string>.Data> c, global::LightSwitchApplication.PurposeType.DetailsClass d, object sf)
                {
                    c(d, ref d._Name, sf);
                }
                private static bool _Name_ComputeIsReadOnly(global::LightSwitchApplication.PurposeType e)
                {
                    bool result = false;
                    e.Name_IsReadOnly(ref result);
                    return result;
                }
                private static void _Name_Validate(global::LightSwitchApplication.PurposeType e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Name_Validate(r);
                }
                private static string _Name_GetImplementationValue(global::LightSwitchApplication.PurposeType.DetailsClass d)
                {
                    return d.ImplementationEntity.Name;
                }
                private static void _Name_SetImplementationValue(global::LightSwitchApplication.PurposeType.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Name = v;
                }
                private static void _Name_OnValueChanged(global::LightSwitchApplication.PurposeType e)
                {
                    e.Name_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, string>.Entry
                    ShortCode = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, string>.Entry(
                        "ShortCode",
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._ShortCode_Stub,
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._ShortCode_ComputeIsReadOnly,
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._ShortCode_Validate,
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._ShortCode_GetImplementationValue,
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._ShortCode_SetImplementationValue,
                        global::LightSwitchApplication.PurposeType.DetailsClass.PropertySetProperties._ShortCode_OnValueChanged);
                private static void _ShortCode_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.PurposeType.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, string>.Data> c, global::LightSwitchApplication.PurposeType.DetailsClass d, object sf)
                {
                    c(d, ref d._ShortCode, sf);
                }
                private static bool _ShortCode_ComputeIsReadOnly(global::LightSwitchApplication.PurposeType e)
                {
                    bool result = false;
                    e.ShortCode_IsReadOnly(ref result);
                    return result;
                }
                private static void _ShortCode_Validate(global::LightSwitchApplication.PurposeType e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.ShortCode_Validate(r);
                }
                private static string _ShortCode_GetImplementationValue(global::LightSwitchApplication.PurposeType.DetailsClass d)
                {
                    return d.ImplementationEntity.ShortCode;
                }
                private static void _ShortCode_SetImplementationValue(global::LightSwitchApplication.PurposeType.DetailsClass d, string v)
                {
                    d.ImplementationEntity.ShortCode = v;
                }
                private static void _ShortCode_OnValueChanged(global::LightSwitchApplication.PurposeType e)
                {
                    e.ShortCode_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, string>.Data _Name;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.PurposeType, global::LightSwitchApplication.PurposeType.DetailsClass, string>.Data _ShortCode;
            
        }
    
        #endregion
    }
    
    #endregion
}
