﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;
using org.model.lib.Model;
using org.model.lib;

using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;


//<comments>
//************************************************************
// Template: ModelBase2.csharp.txt
// Class autogenerated on 09/06/2013 8:02:57 AM by ModelGenerator
// Extends base model object class
// *** DO NOT change code in this class.  
//     It will be re-generated and 
//     overwritten by the code generator ****
//</comments>
namespace CsModelObjects {

	[Table(Name = "Project")]
	[DataContract][SelectObject("Project")][KeyFieldName("ProjectId")]
	[DefaultMapperAttr(typeof(CsModelMappers.ProjectDBMapper)), ComVisible(false), Serializable(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
	partial class Project:ModelObject,IEquatable<Project>  {

		#region "Constructor"

		public Project() {
			this.Id = ModelObjectKeyGen.nextId();
			this.addValidator(new ProjectRequiredFieldsValidator());
		}

		#endregion

		#region "Children and Parents"
		
		[OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context) {
            this.IsObjectLoading = true;
        }

		[OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context) {
			if (this._EmployeeProjects!=null){
				foreach (CsModelObjects.EmployeeProject ep in this._EmployeeProjects) {
					this.IDChanged += ep.handleParentIdChanged;
				}
			}

			this.IsObjectLoading = false;
			this.isDirty = true;
        }

		public override void loadObjectHierarchy() {
		LoadPrEmployeeProjects();

		}

		/// <summary>
		/// Returns the *loaded* children of this model object.
		/// Any records that are not loaded (ie the getter method was not called) are not returned.
		/// To get all child records tied to this object, call loadObjectHierarchy() method
		/// </summary>
		public override List<ModelObject> getChildren() {
			List<ModelObject> ret = new List<ModelObject>();
				if  (this.EmployeeProjectsLoaded) { // check if loaded first!
		List< ModelObject > lp = this._EmployeeProjects.ConvertAll(
				new Converter< CsModelObjects.EmployeeProject, ModelObject>((
			CsModelObjects.EmployeeProject pf )=> {				return (ModelObject)pf;}));
		ret.AddRange(lp);
	}

			return ret;
		}

		/// <summary>
		/// Returns the **loaded** parent objects of this model object.
		/// Any records are not loaded (ie the getter method was not called) are not returned.
		/// To get all parent records tied to this object, call loadObjectHierarchy() method
		/// </summary>
		public override List<ModelObject> getParents() {
			List<ModelObject> ret = new List<ModelObject>();
			
			return ret;
		}

		#endregion
		#region "Field CONSTANTS"

					public const String STR_FLD_PROJECTID = "ProjectId";
			public const String STR_FLD_PROJECTNAME = "ProjectName";
			public const String STR_FLD_ISACTIVE = "IsActive";
			public const String STR_FLD_PROJECTTYPEID = "ProjectTypeId";


				public const int FLD_PROJECTID = 0;
		public const int FLD_PROJECTNAME = 1;
		public const int FLD_ISACTIVE = 2;
		public const int FLD_PROJECTTYPEID = 3;



		///<summary> Returns the names of fields in the object as a string array.
		/// Useful in automatically setting/getting values from UI objects (windows or web Form)</summary>
		/// <returns> string array </returns>	 
		public override string[] getFieldList()
		{
			return new string[] {
				STR_FLD_PROJECTID,STR_FLD_PROJECTNAME,STR_FLD_ISACTIVE,STR_FLD_PROJECTTYPEID
			};
		}

		#endregion

		#region "Field Declarations"

	private System.Int64 _ProjectId;
	private System.String _ProjectName;
	private System.Int64? _IsActive;
	private System.Int64? _ProjectTypeId = null;
	// ****** Associated OBJECTS ********************
[DataMember(Name="PrEmployeeProjects")]	private List< CsModelObjects.EmployeeProject> _EmployeeProjects = null;  //initialize to nothing, for lazy load logic below !!!
	 private List< CsModelObjects.EmployeeProject> _deletedEmployeeProjects = new List< CsModelObjects.EmployeeProject>();// initialize to empty list !!!
	// ****** END Associated OBJECTS ********************

		#endregion

		#region "Field Properties"

		//Field ProjectId
		[Required]
		[Column(Name="ProjectId",Storage = "_ProjectId", IsPrimaryKey=true,DbType = "int NOT NULL",CanBeNull = false)]
		[DataMember]
		public virtual System.Int64 PrProjectId{
			get{			
				return _ProjectId;
			}
			set {
				if (ModelObject.valueChanged(_ProjectId, value)){
					if (!this.IsObjectLoading) {
						this.isDirty = true; //
						this.setFieldChanged(STR_FLD_PROJECTID);
					}
					this._ProjectId = value;
					this.raiseBroadcastIdChange();
				}
			}
		}
		//Field ProjectName
		[Key]
		[Required]
		[StringLength(250, ErrorMessage="ProjectName must be 250 characters or less")]
		[Column(Name="ProjectName",Storage = "_ProjectName", IsPrimaryKey=false,DbType = "nvarchar NOT NULL",CanBeNull = false)]
		[DataMember]
		public virtual System.String PrProjectName{
			get{			
				return _ProjectName;
			}
			set {
				if (ModelObject.valueChanged(_ProjectName, value)){
					if (value != null && value.Length > 250){
						throw new ModelObjectFieldTooLongException("ProjectName");
					}
					if (!this.IsObjectLoading) {
						this.isDirty = true; //
						this.setFieldChanged(STR_FLD_PROJECTNAME);
					}
					this._ProjectName = value;
				}
			}
		}
		//Field isActive
		[Key]
		[Required]
		[Column(Name="isActive",Storage = "_IsActive", IsPrimaryKey=false,DbType = "int NOT NULL",CanBeNull = false)]
		[DataMember]
		public virtual bool PrIsActive{
			get{			
				return _IsActive.GetValueOrDefault() != 0 ? true: false;
			}
			set {
				if (ModelObject.valueChanged(_IsActive, value)){
					if (!this.IsObjectLoading) {
						this.isDirty = true; //
						this.setFieldChanged(STR_FLD_ISACTIVE);
					}
					this._IsActive = value ? 1 : 0;
				}
			}
		}
		//Field ProjectTypeId
		[Key]
		[Column(Name="ProjectTypeId",Storage = "_ProjectTypeId", IsPrimaryKey=false,DbType = "int",CanBeNull = true)]
		[DataMember]
		public virtual EnumProjectType? PrProjectTypeId{
			get{			
				return (EnumProjectType?)_ProjectTypeId;
			}
			set {
				if (ModelObject.valueChanged(_ProjectTypeId, value)){
					if (!this.IsObjectLoading) {
						this.isDirty = true; //
						this.setFieldChanged(STR_FLD_PROJECTTYPEID);
					}
					this._ProjectTypeId=(System.Int64?)value;
				}
			}
		}
		#endregion
		#region "Associations"
		
		#region "Association EmployeeProjects"
		// associationChildManyCSharp.txt
		[System.Runtime.Serialization.DataMember]
		public bool EmployeeProjectsLoaded  {get; private set;}

		public virtual CsModelObjects.EmployeeProject PrEmployeeProjectGetAt( int i ) {

            this.LoadPrEmployeeProjects();
            if( this._EmployeeProjects.Count >= (i - 1)) {
                return this._EmployeeProjects[i];
            }
            return null;

        } 
		
		public virtual void PrEmployeeProjectAdd( CsModelObjects.EmployeeProject val )  {
			// 1-Many , add a single item!
			this.LoadPrEmployeeProjects();
			val.PrEPProjectId = this.PrProjectId;
			this.IDChanged += val.handleParentIdChanged;
			this._EmployeeProjects.Add(val);

        }

		public virtual void PrEmployeeProjectsClear() {

            this.LoadPrEmployeeProjects();
            this._deletedEmployeeProjects.AddRange(this._EmployeeProjects);
            this._EmployeeProjects.Clear();

        }

		public virtual void EmployeeProjectRemove( CsModelObjects.EmployeeProject val ) {
			
			this.LoadPrEmployeeProjects();
			this._deletedEmployeeProjects.Add(val);
			this._EmployeeProjects.Remove(val);

        }
		
		public virtual IEnumerable< CsModelObjects.EmployeeProject >PrEmployeeProjectsGetDeleted() {
			
			return this._deletedEmployeeProjects;

        }
				
        public virtual IEnumerable< CsModelObjects.EmployeeProject > PrEmployeeProjects {

            get {
				//'1 to many relation
                //'LAZY LOADING! Only hit the database to get the child object if we need it
                if ( this._EmployeeProjects == null ) {
                    this.LoadPrEmployeeProjects();
                } 
				
                return this._EmployeeProjects;
            }
            
			set {
				if (value == null ) {
					this._EmployeeProjects = null;
                } else {
                    this._EmployeeProjects = new List< CsModelObjects.EmployeeProject >();
                    this.addToEmployeeProjectsList(value);
                }
			}
        }

		/// <summary>
        /// Private method to add to the EmployeeProjects List. 
		/// The list must have aldready been initialized
        /// </summary>
		private void addToEmployeeProjectsList( IEnumerable< CsModelObjects.EmployeeProject> value ) {

			IEnumerator< CsModelObjects.EmployeeProject> enumtor = value.GetEnumerator();
        
		    while (enumtor.MoveNext()) {
                CsModelObjects.EmployeeProject v = enumtor.Current;
                v.IDChanged += this.handleParentIdChanged;
                this._EmployeeProjects.Add(v);
            }

        } //End Sub
        
        /// <summary>
        /// Loads child objects from dabatabase, if not loaded already
        /// </summary>
        private void LoadPrEmployeeProjects() {
			
			if (this.EmployeeProjectsLoaded)return;
			//init list
			this._EmployeeProjects = new List< CsModelObjects.EmployeeProject>();

			if (! this.isNew ) {
                this.addToEmployeeProjectsList( new CsModelMappers.EmployeeProjectDBMapper().findList("EPProjectId=?", this.PrProjectId));
            }
            
			this.EmployeeProjectsLoaded = true;
        } 
		#endregion


		#endregion

		#region "Getters/Setters of values by field index/name"
		public override object getAttribute(int fieldKey){

		switch (fieldKey) {
		case FLD_PROJECTID:
			return this.PrProjectId;
		case FLD_PROJECTNAME:
			return this.PrProjectName;
		case FLD_ISACTIVE:
			return this.PrIsActive;
		case FLD_PROJECTTYPEID:
			return this.PrProjectTypeId;
		default:
			return null;
		} //end switch

		}

		public override object getAttribute(string fieldKey) {
			fieldKey = fieldKey.ToLower();

		if (fieldKey==STR_FLD_PROJECTID.ToLower() ) {
			return this.PrProjectId;
		} else if (fieldKey==STR_FLD_PROJECTNAME.ToLower() ) {
			return this.PrProjectName;
		} else if (fieldKey==STR_FLD_ISACTIVE.ToLower() ) {
			return this.PrIsActive;
		} else if (fieldKey==STR_FLD_PROJECTTYPEID.ToLower() ) {
			return this.PrProjectTypeId;
		} else {
			return null;
		}
		}

		public override void setAttribute(int fieldKey, object val){
			try {
		switch (fieldKey) {
		case FLD_PROJECTID:
			if (val == DBNull.Value || val == null ){
				throw new ApplicationException("Can't set Primary Key to null");
			} else {
				this.PrProjectId=(System.Int64)val;
			} //
			return;
		case FLD_PROJECTNAME:
			if (val == DBNull.Value || val == null ){
				this.PrProjectName = null;
			} else {
				this.PrProjectName=(System.String)val;
			} //
			return;
		case FLD_ISACTIVE:
			if (val == DBNull.Value || val == null ){
				this.PrIsActive = false;
			} else {
				this.PrIsActive=(bool)val;
			} //
			return;
		case FLD_PROJECTTYPEID:
			if (val == DBNull.Value || val == null ){
				this.PrProjectTypeId = null;
			} else {
				this.PrProjectTypeId=(EnumProjectType?)val;
			} //
			return;
		default:
			return;
		}

			} catch ( Exception ex ) {
				throw new ApplicationException(
						String.Format("Error setting field with index {0}, value \"{1}\" : {2}", 
								fieldKey, val, ex.Message));
			}
		}

		public override void setAttribute(string fieldKey, object val) {
			fieldKey = fieldKey.ToLower();
			try {
		if ( fieldKey==STR_FLD_PROJECTID.ToLower()){
			if (val == DBNull.Value || val ==null ){
				throw new ApplicationException("Can't set Primary Key to null");
			} else {
				this.PrProjectId=Convert.ToInt64(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_PROJECTNAME.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrProjectName = null;
			} else {
				this.PrProjectName=Convert.ToString(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_ISACTIVE.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrIsActive = false;
			} else {
				this.PrIsActive=(bool)val;
			}
			return;
		} else if ( fieldKey==STR_FLD_PROJECTTYPEID.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrProjectTypeId = null;
			} else {
				this.PrProjectTypeId=(EnumProjectType?)val;
			}
			return;
		}
			} catch ( Exception ex ) {
				throw new ApplicationException(
					String.Format("Error setting field with index {0}, value \"{1}\" : {2}", 
							fieldKey, val, ex.Message));
			}
		}

		#endregion
		#region "Overrides of GetHashCode and Equals "
		public bool Equals(Project other)
		{

			//typesafe equals, checks for equality of fields
			if (other == null)
				return false;
			if (object.ReferenceEquals(other, this))
				return true;

			return this.PrProjectId == other.PrProjectId
				&& this.PrProjectName == other.PrProjectName
				&& this.PrIsActive == other.PrIsActive
				&& this.PrProjectTypeId.GetValueOrDefault() == other.PrProjectTypeId.GetValueOrDefault();;

		}

		public override int GetHashCode()
		{
			//using Xor has the advantage of not overflowing the integer.
			return this.PrProjectId.GetHashCode()
				 ^ this.getStringHashCode(this.PrProjectName)
				 ^ this.PrIsActive.GetHashCode()
				 ^ this.PrProjectTypeId.GetHashCode();;

		}

		public override bool Equals(object Obj) {

			if (Obj != null && Obj is Project) {

				return this.Equals((Project)Obj);

			} else {
				return false;
			}

		}

		public static bool operator ==(Project obj1, Project obj2)
		{
			return object.Equals(obj1, obj2);
		}

		public static bool operator !=(Project obj1, Project obj2) {
			return !(obj1 == obj2);
		}

		#endregion

		#region "Copy and sort"

		public override IModelObject copy() {
			//creates a copy
			Project ret = new Project();
		ret.PrProjectId = this.PrProjectId;
		ret.PrProjectName = this.PrProjectName;
		ret.PrIsActive = this.PrIsActive;
		ret.PrProjectTypeId = this.PrProjectTypeId;

			return ret;

		}

		#endregion




		#region "ID Property"

		[DataMember]public sealed override object Id {
			get { return this._ProjectId; }
			set {
				this._ProjectId = Convert.ToInt64(value);
				this.raiseBroadcastIdChange();
			}
		}
		#endregion

		#region "Extra Code"

		#endregion

	}

	#region "Req Fields validator"
	[System.Runtime.InteropServices.ComVisible(false)]
	public class ProjectRequiredFieldsValidator : IModelObjectValidator {

		public void validate(org.model.lib.Model.IModelObject imo) {
			Project mo = (Project)imo;
			if (string.IsNullOrEmpty( mo.PrProjectName)) {
		throw new ModelObjectRequiredFieldException("ProjectName");
}

		}

	}
	#endregion

}


