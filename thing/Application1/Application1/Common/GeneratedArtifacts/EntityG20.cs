

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
    public sealed partial class WorkshopTeacher : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the WorkshopTeacher entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public WorkshopTeacher()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public WorkshopTeacher(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.WorkshopTeacher> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.WorkshopTeacher.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void WorkshopTeacher_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void WorkshopTeacher_AllowSaveWithErrors(ref bool result);
    
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
                return global::LightSwitchApplication.WorkshopTeacher.DetailsClass.GetValue(this, global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Id);
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
        public string Workshop
        {
            get
            {
                return global::LightSwitchApplication.WorkshopTeacher.DetailsClass.GetValue(this, global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Workshop);
            }
            set
            {
                global::LightSwitchApplication.WorkshopTeacher.DetailsClass.SetValue(this, global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Workshop, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Workshop_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Workshop_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Workshop_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string c_Date
        {
            get
            {
                return global::LightSwitchApplication.WorkshopTeacher.DetailsClass.GetValue(this, global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.c_Date);
            }
            set
            {
                global::LightSwitchApplication.WorkshopTeacher.DetailsClass.SetValue(this, global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.c_Date, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void c_Date_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void c_Date_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void c_Date_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Notes
        {
            get
            {
                return global::LightSwitchApplication.WorkshopTeacher.DetailsClass.GetValue(this, global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Notes);
            }
            set
            {
                global::LightSwitchApplication.WorkshopTeacher.DetailsClass.SetValue(this, global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Notes, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Notes_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Notes_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Notes_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Contact Contact
        {
            get
            {
                return global::LightSwitchApplication.WorkshopTeacher.DetailsClass.GetValue(this, global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Contact);
            }
            set
            {
                global::LightSwitchApplication.WorkshopTeacher.DetailsClass.SetValue(this, global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Contact, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contact_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contact_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Contact_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.WorkshopTeacher,
                global::LightSwitchApplication.WorkshopTeacher.DetailsClass,
                global::LightSwitchApplication.WorkshopTeacher.DetailsClass.IImplementation,
                global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass>.Entry
                __WorkshopTeacherEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass>.Entry(
                    global::LightSwitchApplication.WorkshopTeacher.DetailsClass.__WorkshopTeacher_CreateNew,
                    global::LightSwitchApplication.WorkshopTeacher.DetailsClass.__WorkshopTeacher_Created,
                    global::LightSwitchApplication.WorkshopTeacher.DetailsClass.__WorkshopTeacher_AllowSaveWithErrors);
            private static global::LightSwitchApplication.WorkshopTeacher __WorkshopTeacher_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.WorkshopTeacher> es)
            {
                return new global::LightSwitchApplication.WorkshopTeacher(es);
            }
            private static void __WorkshopTeacher_Created(global::LightSwitchApplication.WorkshopTeacher e)
            {
                e.WorkshopTeacher_Created();
            }
            private static bool __WorkshopTeacher_AllowSaveWithErrors(global::LightSwitchApplication.WorkshopTeacher e)
            {
                bool result = false;
                e.WorkshopTeacher_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySet Properties
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
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string> Workshop
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Workshop) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string> c_Date
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.c_Date) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string> Notes
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Notes) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, global::LightSwitchApplication.Contact> Contact
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Contact) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, global::LightSwitchApplication.Contact>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; }
                new string Workshop { get; set; }
                new string c_Date { get; set; }
                new string Notes { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Contact { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        null,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.WorkshopTeacher.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, int>.Data> c, global::LightSwitchApplication.WorkshopTeacher.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.WorkshopTeacher e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.WorkshopTeacher e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.WorkshopTeacher.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.WorkshopTeacher e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>.Entry
                    Workshop = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>.Entry(
                        "Workshop",
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Workshop_Stub,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Workshop_ComputeIsReadOnly,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Workshop_Validate,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Workshop_GetImplementationValue,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Workshop_SetImplementationValue,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Workshop_OnValueChanged);
                private static void _Workshop_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.WorkshopTeacher.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>.Data> c, global::LightSwitchApplication.WorkshopTeacher.DetailsClass d, object sf)
                {
                    c(d, ref d._Workshop, sf);
                }
                private static bool _Workshop_ComputeIsReadOnly(global::LightSwitchApplication.WorkshopTeacher e)
                {
                    bool result = false;
                    e.Workshop_IsReadOnly(ref result);
                    return result;
                }
                private static void _Workshop_Validate(global::LightSwitchApplication.WorkshopTeacher e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Workshop_Validate(r);
                }
                private static string _Workshop_GetImplementationValue(global::LightSwitchApplication.WorkshopTeacher.DetailsClass d)
                {
                    return d.ImplementationEntity.Workshop;
                }
                private static void _Workshop_SetImplementationValue(global::LightSwitchApplication.WorkshopTeacher.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Workshop = v;
                }
                private static void _Workshop_OnValueChanged(global::LightSwitchApplication.WorkshopTeacher e)
                {
                    e.Workshop_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>.Entry
                    c_Date = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>.Entry(
                        "c_Date",
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._c_Date_Stub,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._c_Date_ComputeIsReadOnly,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._c_Date_Validate,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._c_Date_GetImplementationValue,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._c_Date_SetImplementationValue,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._c_Date_OnValueChanged);
                private static void _c_Date_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.WorkshopTeacher.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>.Data> c, global::LightSwitchApplication.WorkshopTeacher.DetailsClass d, object sf)
                {
                    c(d, ref d._c_Date, sf);
                }
                private static bool _c_Date_ComputeIsReadOnly(global::LightSwitchApplication.WorkshopTeacher e)
                {
                    bool result = false;
                    e.c_Date_IsReadOnly(ref result);
                    return result;
                }
                private static void _c_Date_Validate(global::LightSwitchApplication.WorkshopTeacher e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.c_Date_Validate(r);
                }
                private static string _c_Date_GetImplementationValue(global::LightSwitchApplication.WorkshopTeacher.DetailsClass d)
                {
                    return d.ImplementationEntity.c_Date;
                }
                private static void _c_Date_SetImplementationValue(global::LightSwitchApplication.WorkshopTeacher.DetailsClass d, string v)
                {
                    d.ImplementationEntity.c_Date = v;
                }
                private static void _c_Date_OnValueChanged(global::LightSwitchApplication.WorkshopTeacher e)
                {
                    e.c_Date_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>.Entry
                    Notes = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>.Entry(
                        "Notes",
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Notes_Stub,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Notes_ComputeIsReadOnly,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Notes_Validate,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Notes_GetImplementationValue,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Notes_SetImplementationValue,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Notes_OnValueChanged);
                private static void _Notes_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.WorkshopTeacher.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>.Data> c, global::LightSwitchApplication.WorkshopTeacher.DetailsClass d, object sf)
                {
                    c(d, ref d._Notes, sf);
                }
                private static bool _Notes_ComputeIsReadOnly(global::LightSwitchApplication.WorkshopTeacher e)
                {
                    bool result = false;
                    e.Notes_IsReadOnly(ref result);
                    return result;
                }
                private static void _Notes_Validate(global::LightSwitchApplication.WorkshopTeacher e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Notes_Validate(r);
                }
                private static string _Notes_GetImplementationValue(global::LightSwitchApplication.WorkshopTeacher.DetailsClass d)
                {
                    return d.ImplementationEntity.Notes;
                }
                private static void _Notes_SetImplementationValue(global::LightSwitchApplication.WorkshopTeacher.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Notes = v;
                }
                private static void _Notes_OnValueChanged(global::LightSwitchApplication.WorkshopTeacher e)
                {
                    e.Notes_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, global::LightSwitchApplication.Contact>.Entry
                    Contact = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, global::LightSwitchApplication.Contact>.Entry(
                        "Contact",
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Contact_Stub,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Contact_ComputeIsReadOnly,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Contact_Validate,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Contact_GetCoreImplementationValue,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Contact_GetImplementationValue,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Contact_SetImplementationValue,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Contact_Refresh,
                        global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties._Contact_OnValueChanged);
                private static void _Contact_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.WorkshopTeacher.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, global::LightSwitchApplication.Contact>.Data> c, global::LightSwitchApplication.WorkshopTeacher.DetailsClass d, object sf)
                {
                    c(d, ref d._Contact, sf);
                }
                private static bool _Contact_ComputeIsReadOnly(global::LightSwitchApplication.WorkshopTeacher e)
                {
                    bool result = false;
                    e.Contact_IsReadOnly(ref result);
                    return result;
                }
                private static void _Contact_Validate(global::LightSwitchApplication.WorkshopTeacher e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Contact_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Contact_GetCoreImplementationValue(global::LightSwitchApplication.WorkshopTeacher.DetailsClass d)
                {
                    return d.ImplementationEntity.Contact;
                }
                private static global::LightSwitchApplication.Contact _Contact_GetImplementationValue(global::LightSwitchApplication.WorkshopTeacher.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Contact, global::LightSwitchApplication.Contact.DetailsClass>(global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Contact, ref d._Contact);
                }
                private static void _Contact_SetImplementationValue(global::LightSwitchApplication.WorkshopTeacher.DetailsClass d, global::LightSwitchApplication.Contact v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Contact, ref d._Contact, (i, ev) => i.Contact = ev, v);
                }
                private static void _Contact_Refresh(global::LightSwitchApplication.WorkshopTeacher.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.WorkshopTeacher.DetailsClass.PropertySetProperties.Contact, ref d._Contact);
                }
                private static void _Contact_OnValueChanged(global::LightSwitchApplication.WorkshopTeacher e)
                {
                    e.Contact_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>.Data _Workshop;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>.Data _c_Date;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, string>.Data _Notes;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.WorkshopTeacher, global::LightSwitchApplication.WorkshopTeacher.DetailsClass, global::LightSwitchApplication.Contact>.Data _Contact;
            
        }
    
        #endregion
    }
    
    #endregion
}
