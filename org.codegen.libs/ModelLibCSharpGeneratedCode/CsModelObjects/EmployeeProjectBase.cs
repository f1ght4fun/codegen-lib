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

//<comments>
//************************************************************
// Template: ModelBase2.csharp.txt
// Class autogenerated on 09/06/2013 8:02:57 AM by ModelGenerator
// Extends base model object class
// *** DO NOT change code in this class.  
//     It will be re-generated and 
//     overwritten by the code generator ****
// Instead, change code in the extender class EmployeeProject
//
//************************************************************
//</comments>
namespace CsModelObjects
{

	#region "Interface"
[System.Runtime.InteropServices.ComVisible(false)] 
	public interface IEmployeeProject: IModelObject {
	System.Int64 PrEmployeeProjectId {get;set;} 
	System.Int64? PrEPEmployeeId {get;set;} 
	System.Int64? PrEPProjectId {get;set;} 
	System.DateTime? PrAssignDate {get;set;} 
	System.DateTime? PrEndDate {get;set;} 
	System.Decimal? PrRate {get;set;} 
	CsModelObjects.Project PrProject {get;set;} //association
}
#endregion

	
	[DefaultMapperAttr(typeof(CsModelMappers.EmployeeProjectDBMapper)), ComVisible(false), Serializable(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
	public class EmployeeProjectBase : ModelObject, IEquatable<EmployeeProjectBase>, IEmployeeProject {

		#region "Constructor"

		public EmployeeProjectBase() {
			this.addValidator(new EmployeeProjectRequiredFieldsValidator());
		}

		#endregion

		#region "Children and Parents"
		
		public override void loadObjectHierarchy() {
		loadProject();

		}

		/// <summary>
		/// Returns the **loaded** children of this model object.
		/// Any records that are not loaded (ie the getter method was not called) are not returned.
		/// To get all child records tied to this object, call loadObjectHierarchy() method
		/// </summary>
		public override List<ModelObject> getChildren() {
			List<ModelObject> ret = new List<ModelObject>();
			
			return ret;
		}

		/// <summary>
		/// Returns the **loaded** parent objects of this model object.
		/// Any records are not loaded (ie the getter method was not called) are not returned.
		/// To get all parent records tied to this object, call loadObjectHierarchy() method
		/// </summary>
		public override List<ModelObject> getParents() {
			List<ModelObject> ret = new List<ModelObject>();
			if  ( this._Project!=null && this.ProjectLoaded) {
	ret.Add(this.PrProject);
}

			return ret;
		}

		#endregion
		#region "Field CONSTANTS"

					public const String STR_FLD_EMPLOYEEPROJECTID = "EmployeeProjectId";
			public const String STR_FLD_EPEMPLOYEEID = "EPEmployeeId";
			public const String STR_FLD_EPPROJECTID = "EPProjectId";
			public const String STR_FLD_ASSIGNDATE = "AssignDate";
			public const String STR_FLD_ENDDATE = "EndDate";
			public const String STR_FLD_RATE = "Rate";


				public const int FLD_EMPLOYEEPROJECTID = 0;
		public const int FLD_EPEMPLOYEEID = 1;
		public const int FLD_EPPROJECTID = 2;
		public const int FLD_ASSIGNDATE = 3;
		public const int FLD_ENDDATE = 4;
		public const int FLD_RATE = 5;



		///<summary> Returns the names of fields in the object as a string array.
		/// Useful in automatically setting/getting values from UI objects (windows or web Form)</summary>
		/// <returns> string array </returns>	 
		public override string[] getFieldList()
		{
			return new string[] {
				STR_FLD_EMPLOYEEPROJECTID,STR_FLD_EPEMPLOYEEID,STR_FLD_EPPROJECTID,STR_FLD_ASSIGNDATE,STR_FLD_ENDDATE,STR_FLD_RATE
			};
		}

		#endregion

		#region "Field Declarations"

	private System.Int64 _EmployeeProjectId;
	private System.Int64? _EPEmployeeId = null;
	private System.Int64? _EPProjectId = null;
	private System.DateTime? _AssignDate = null;
	private System.DateTime? _EndDate = null;
	private System.Decimal? _Rate = null;
	// ****** CHILD OBJECTS ********************
	private CsModelObjects.Project _Project = null;  // initialize to nothing, for lazy load logic below !!!

	// *****************************************
	// ****** END CHILD OBJECTS ********************

		#endregion

		#region "Field Properties"

	[DataMember]public virtual System.Int64 PrEmployeeProjectId{
	get{
		return _EmployeeProjectId;
	}
	set {
		if (ModelObject.valueChanged(_EmployeeProjectId, value)){
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_EMPLOYEEPROJECTID);
			}
		this._EmployeeProjectId=value;

			this.raiseBroadcastIdChange();

		}
		}
	}
	[DataMember]public virtual System.Int64? PrEPEmployeeId{
	get{
		return _EPEmployeeId;
	}
	set {
		if (ModelObject.valueChanged(_EPEmployeeId, value)){
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_EPEMPLOYEEID);
			}
		this._EPEmployeeId=value;

		}
		}
	}
	[DataMember]public virtual System.Int64? PrEPProjectId{
	get{
		return _EPProjectId;
	}
	set {
		if (ModelObject.valueChanged(_EPProjectId, value)){
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_EPPROJECTID);
			}
		this._EPProjectId=value;

		}
		}
	}
	[DataMember]public virtual System.DateTime? PrAssignDate{
	get{
		return _AssignDate;
	}
	set {
		if (ModelObject.valueChanged(_AssignDate, value)){
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_ASSIGNDATE);
			}
		this._AssignDate=value;

		}
		}
	}
	[DataMember]public virtual System.DateTime? PrEndDate{
	get{
		return _EndDate;
	}
	set {
		if (ModelObject.valueChanged(_EndDate, value)){
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_ENDDATE);
			}
		this._EndDate=value;

		}
		}
	}
	[DataMember]public virtual System.Decimal? PrRate{
	get{
		return _Rate;
	}
	set {
		if (ModelObject.valueChanged(_Rate, value)){
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_RATE);
			}
		this._Rate=value;

		}
		}
	}

		// ASSOCIATIONS GETTERS/SETTERS BELOW!
		//associationParentCSharp.txt
		#region "Association Project"

		private bool ProjectLoaded {get;set;}

		/// <summary>
        /// Gets/Sets parent object
        /// </summary>
		public virtual CsModelObjects.Project PrProject {
		    //1-1 parent association
            set {
                this._Project = value;
				if ( value != null ) {
					this.PrEPProjectId = value.PrProjectId;
					//AddHandler value.IDChanged, AddressOf this.handleParentIdChanged;
					value.IDChanged += this.handleParentIdChanged;
                } else {
					this.PrEPProjectId = null;
				}

            }


            get {
                //LAZY LOADING! Only hit the database to get the child object if we need it
                if ( this._Project == null ) {
					this.loadProject();
                }
				
                return this._Project;
            }
        }
        
        /// <summary>
        /// Loads parent object and sets the appropriate properties
        /// </summary>
        private void loadProject() {
			
			if (this.ProjectLoaded) return;
			
			if ( this._Project == null && this.PrEPProjectId != null ) {
                
				//call the setter here, not the private variable!
                this.PrProject = new CsModelMappers.ProjectDBMapper().findByKey(this.PrEPProjectId);
                
            }

            this.ProjectLoaded=true;
			            
       }
		#endregion


		#endregion

		#region "Getters/Setters of values by field index/name"
		public override object getAttribute(int fieldKey){

		switch (fieldKey) {
		case FLD_EMPLOYEEPROJECTID:
			return this.PrEmployeeProjectId;
		case FLD_EPEMPLOYEEID:
			return this.PrEPEmployeeId;
		case FLD_EPPROJECTID:
			return this.PrEPProjectId;
		case FLD_ASSIGNDATE:
			return this.PrAssignDate;
		case FLD_ENDDATE:
			return this.PrEndDate;
		case FLD_RATE:
			return this.PrRate;
		default:
			return null;
		} //end switch

		}

		public override object getAttribute(string fieldKey) {
			fieldKey = fieldKey.ToLower();

		if (fieldKey==STR_FLD_EMPLOYEEPROJECTID.ToLower() ) {
			return this.PrEmployeeProjectId;
		} else if (fieldKey==STR_FLD_EPEMPLOYEEID.ToLower() ) {
			return this.PrEPEmployeeId;
		} else if (fieldKey==STR_FLD_EPPROJECTID.ToLower() ) {
			return this.PrEPProjectId;
		} else if (fieldKey==STR_FLD_ASSIGNDATE.ToLower() ) {
			return this.PrAssignDate;
		} else if (fieldKey==STR_FLD_ENDDATE.ToLower() ) {
			return this.PrEndDate;
		} else if (fieldKey==STR_FLD_RATE.ToLower() ) {
			return this.PrRate;
		} else {
			return null;
		}
		}

		public override void setAttribute(int fieldKey, object val){
		switch (fieldKey) {
		case FLD_EMPLOYEEPROJECTID:
			if (val == DBNull.Value || val == null ){
				throw new ApplicationException("Can't set Primary Key to null");
			} else {
				this.PrEmployeeProjectId=(System.Int64)val;
			} //
			return;
		case FLD_EPEMPLOYEEID:
			if (val == DBNull.Value || val == null ){
				this.PrEPEmployeeId = null;
			} else {
				this.PrEPEmployeeId=(System.Int64)val;
			} //
			return;
		case FLD_EPPROJECTID:
			if (val == DBNull.Value || val == null ){
				this.PrEPProjectId = null;
			} else {
				this.PrEPProjectId=(System.Int64)val;
			} //
			return;
		case FLD_ASSIGNDATE:
			if (val == DBNull.Value || val == null ){
				this.PrAssignDate = null;
			} else {
				this.PrAssignDate=(System.DateTime)val;
			} //
			return;
		case FLD_ENDDATE:
			if (val == DBNull.Value || val == null ){
				this.PrEndDate = null;
			} else {
				this.PrEndDate=(System.DateTime)val;
			} //
			return;
		case FLD_RATE:
			if (val == DBNull.Value || val == null ){
				this.PrRate = null;
			} else {
				this.PrRate=(System.Decimal)val;
			} //
			return;
		default:
			return;
		}

		}

		public override void setAttribute(string fieldKey, object val) {
			fieldKey = fieldKey.ToLower();
		if ( fieldKey==STR_FLD_EMPLOYEEPROJECTID.ToLower()){
			if (val == DBNull.Value || val ==null ){
				throw new ApplicationException("Can't set Primary Key to null");
			} else {
				this.PrEmployeeProjectId=(System.Int64)val;
			}
			return;
		} else if ( fieldKey==STR_FLD_EPEMPLOYEEID.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrEPEmployeeId = null;
			} else {
				this.PrEPEmployeeId=(System.Int64)val;
			}
			return;
		} else if ( fieldKey==STR_FLD_EPPROJECTID.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrEPProjectId = null;
			} else {
				this.PrEPProjectId=(System.Int64)val;
			}
			return;
		} else if ( fieldKey==STR_FLD_ASSIGNDATE.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrAssignDate = null;
			} else {
				this.PrAssignDate=(System.DateTime)val;
			}
			return;
		} else if ( fieldKey==STR_FLD_ENDDATE.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrEndDate = null;
			} else {
				this.PrEndDate=(System.DateTime)val;
			}
			return;
		} else if ( fieldKey==STR_FLD_RATE.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrRate = null;
			} else {
				this.PrRate=(System.Decimal)val;
			}
			return;
		}
		}

		#endregion
		#region "Overrides of GetHashCode and Equals "
		public bool Equals(EmployeeProjectBase other)
		{

			//typesafe equals, checks for equality of fields
			if (other == null)
				return false;
			if (object.ReferenceEquals(other, this))
				return true;

			return this.PrEmployeeProjectId == other.PrEmployeeProjectId
				&& this.PrEPEmployeeId.GetValueOrDefault() == other.PrEPEmployeeId.GetValueOrDefault()
				&& this.PrEPProjectId.GetValueOrDefault() == other.PrEPProjectId.GetValueOrDefault()
				&& this.PrAssignDate.GetValueOrDefault() == other.PrAssignDate.GetValueOrDefault()
				&& this.PrEndDate.GetValueOrDefault() == other.PrEndDate.GetValueOrDefault()
				&& this.PrRate.GetValueOrDefault() == other.PrRate.GetValueOrDefault();;

		}

		public override int GetHashCode()
		{
			//using Xor has the advantage of not overflowing the integer.
			return this.PrEmployeeProjectId.GetHashCode()
				 ^ this.PrEPEmployeeId.GetHashCode()
				 ^ this.PrEPProjectId.GetHashCode()
				 ^ this.PrAssignDate.GetHashCode()
				 ^ this.PrEndDate.GetHashCode()
				 ^ this.PrRate.GetHashCode();;

		}

		public override bool Equals(object Obj) {

			if (Obj != null && Obj is EmployeeProjectBase) {

				return this.Equals((EmployeeProjectBase)Obj);

			} else {
				return false;
			}

		}

		public static bool operator ==(EmployeeProjectBase obj1, EmployeeProjectBase obj2)
		{
			return object.Equals(obj1, obj2);
		}

		public static bool operator !=(EmployeeProjectBase obj1, EmployeeProjectBase obj2)
		{
			return !(obj1 == obj2);
		}

		#endregion

		#region "Copy and sort"

		public override IModelObject copy()
		{
			//creates a copy

			//NOTE: we can't cast from EmployeeProjectBase to EmployeeProject, so below we 
			//instantiate a EmployeeProject, NOT a EmployeeProjectBase object
			EmployeeProject ret = EmployeeProjectFactory.Create();

		ret.PrEmployeeProjectId = this.PrEmployeeProjectId;
		ret.PrEPEmployeeId = this.PrEPEmployeeId;
		ret.PrEPProjectId = this.PrEPProjectId;
		ret.PrAssignDate = this.PrAssignDate;
		ret.PrEndDate = this.PrEndDate;
		ret.PrRate = this.PrRate;



			return ret;

		}

		#endregion

#region "parentIdChanged"
	//below sub is called when parentIdChanged
	public override void handleParentIdChanged(IModelObject parentMo ){
		// Assocations from CsModelObjects.Employee
		if ( parentMo is CsModelObjects.Employee) {
			this.PrEPEmployeeId= ((CsModelObjects.Employee)parentMo).PrEmployeeId;
		}
		// Assocations from CsModelObjects.Project
		if ( parentMo is CsModelObjects.Project) {
			this.PrEPProjectId= ((CsModelObjects.Project)parentMo).PrProjectId;
		}
		// Assocations from CsModelObjects.Project
		if ( parentMo is CsModelObjects.Project) {
			this.PrEPProjectId= ((CsModelObjects.Project)parentMo).PrProjectId;
		}
	}
#endregion



		#region "ID Property"

		[DataMember]public override object Id {
			get { return this._EmployeeProjectId; }
			set {
				this._EmployeeProjectId = Convert.ToInt64(value);
				this.raiseBroadcastIdChange();
			}
		}
		#endregion

		#region "Extra Code"

		#endregion

	}

	#region "Req Fields validator"
	[System.Runtime.InteropServices.ComVisible(false)]
	public class EmployeeProjectRequiredFieldsValidator : IModelObjectValidator
	{


		public void validate(org.model.lib.Model.IModelObject imo) {
			EmployeeProject mo = (EmployeeProject)imo;
if (mo.PrEPEmployeeId == null ) {
		throw new ModelObjectRequiredFieldException("EPEmployeeId");
}
if (mo.PrEPProjectId == null ) {
		throw new ModelObjectRequiredFieldException("EPProjectId");
}

		}

	}
	#endregion

}


