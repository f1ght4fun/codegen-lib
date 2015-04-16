﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

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
// Instead, change code in the extender class EmployeeInfo
//
//************************************************************
//</comments>
namespace CsModelObjects
{

	#region "Interface"
[System.Runtime.InteropServices.ComVisible(false)] 
	public interface IEmployeeInfo: IModelObject {
	System.Int64 PrEmployeeInfoId {get;set;} 
	System.Int64? PrEIEmployeeId {get;set;} 
	System.Decimal? PrSalary {get;set;} 
	System.String PrAddress {get;set;} 
}
#endregion

	
	[DefaultMapperAttr(typeof(CsModelMappers.EmployeeInfoDBMapper)), ComVisible(false), Serializable(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
	public class EmployeeInfoBase : ModelObject, IEquatable<EmployeeInfoBase>, IEmployeeInfo {

		#region "Constructor"

		public EmployeeInfoBase() {
			this.addValidator(new EmployeeInfoRequiredFieldsValidator());
		}

		#endregion

		#region "Children and Parents"
		
		public override void loadObjectHierarchy() {

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
			
			return ret;
		}

		#endregion
		#region "Field CONSTANTS"

					public const String STR_FLD_EMPLOYEEINFOID = "EmployeeInfoId";
			public const String STR_FLD_EIEMPLOYEEID = "EIEmployeeId";
			public const String STR_FLD_SALARY = "Salary";
			public const String STR_FLD_ADDRESS = "Address";


				public const int FLD_EMPLOYEEINFOID = 0;
		public const int FLD_EIEMPLOYEEID = 1;
		public const int FLD_SALARY = 2;
		public const int FLD_ADDRESS = 3;



		///<summary> Returns the names of fields in the object as a string array.
		/// Useful in automatically setting/getting values from UI objects (windows or web Form)</summary>
		/// <returns> string array </returns>	 
		public override string[] getFieldList()
		{
			return new string[] {
				STR_FLD_EMPLOYEEINFOID,STR_FLD_EIEMPLOYEEID,STR_FLD_SALARY,STR_FLD_ADDRESS
			};
		}

		#endregion

		#region "Field Declarations"

	private System.Int64 _EmployeeInfoId;
	private System.Int64? _EIEmployeeId = null;
	private System.Decimal? _Salary = null;
	private System.String _Address = null;

		#endregion

		#region "Field Properties"

	public virtual System.Int64 PrEmployeeInfoId  {
	get {
		return _EmployeeInfoId;
	} 
	set {
		if (ModelObject.valueChanged(_EmployeeInfoId, value)) {
			if (!this.IsObjectLoading ) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_EMPLOYEEINFOID);
			}
			this._EmployeeInfoId = value;

			this.raiseBroadcastIdChange();

		}
	}  
	}
public void setEmployeeInfoId(String val){
	if (Information.IsNumeric(val)) {
		this.PrEmployeeInfoId = Convert.ToInt64(val);
	} else if (String.IsNullOrEmpty(val)) {
		throw new ApplicationException("Cant update Primary Key to Null");
	} else {
		throw new ApplicationException("Invalid Integer Number, field:EmployeeInfoId, value:" + val);
	}
}
	public virtual System.Int64? PrEIEmployeeId  {
	get {
		return _EIEmployeeId;
	} 
	set {
		if (ModelObject.valueChanged(_EIEmployeeId, value)) {
			if (!this.IsObjectLoading ) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_EIEMPLOYEEID);
			}
			this._EIEmployeeId = value;

		}
	}  
	}
public void setEIEmployeeId(String val){
	if (Information.IsNumeric(val)) {
		this.PrEIEmployeeId = Convert.ToInt64(val);
	} else if (String.IsNullOrEmpty(val)) {
		this.PrEIEmployeeId = null;
	} else {
		throw new ApplicationException("Invalid Integer Number, field:EIEmployeeId, value:" + val);
	}
}
	public virtual System.Decimal? PrSalary  {
	get {
		return _Salary;
	} 
	set {
		if (ModelObject.valueChanged(_Salary, value)) {
			if (!this.IsObjectLoading ) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_SALARY);
			}
			this._Salary = value;

		}
	}  
	}
public void setSalary(String val ){
	if (Information.IsNumeric(val)) {
		this.PrSalary =  Convert.ToDecimal(val);
	} else if ( string.IsNullOrEmpty(val) ) {
		this.PrSalary = null;
	} else {
		throw new ApplicationException("Invalid Decimal Number, field:Salary, value:" + val);
	}
}
	public virtual System.String PrAddress  {
	get {
		return _Address;
	} 
	set {
		if (ModelObject.valueChanged(_Address, value)) {
			if (!this.IsObjectLoading ) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_ADDRESS);
			}
			this._Address = value;

		}
	}  
	}
public void setAddress( String val ) {
	if (! string.IsNullOrEmpty(val)) {
		this.PrAddress = val;
	} else {
		this.PrAddress = null;
	}
}

		#endregion

		#region "Getters/Setters of values by field index/name"
		public override object getAttribute(int fieldKey){

		switch (fieldKey) {
		case FLD_EMPLOYEEINFOID:
			return this.PrEmployeeInfoId;
		case FLD_EIEMPLOYEEID:
			return this.PrEIEmployeeId;
		case FLD_SALARY:
			return this.PrSalary;
		case FLD_ADDRESS:
			return this.PrAddress;
		default:
			return null;
		} //end switch

		}

		public override object getAttribute(string fieldKey) {
			fieldKey = fieldKey.ToLower();

		if (fieldKey==STR_FLD_EMPLOYEEINFOID.ToLower() ) {
			return this.PrEmployeeInfoId;
		} else if (fieldKey==STR_FLD_EIEMPLOYEEID.ToLower() ) {
			return this.PrEIEmployeeId;
		} else if (fieldKey==STR_FLD_SALARY.ToLower() ) {
			return this.PrSalary;
		} else if (fieldKey==STR_FLD_ADDRESS.ToLower() ) {
			return this.PrAddress;
		} else {
			return null;
		}
		}

		public override void setAttribute(int fieldKey, object val){
		switch (fieldKey) {
		case FLD_EMPLOYEEINFOID:
			if (val == DBNull.Value || val == null ){
				throw new ApplicationException("Can't set Primary Key to null");
			}else{
				this.PrEmployeeInfoId=(System.Int64)val;
			} //
			return;
		case FLD_EIEMPLOYEEID:
			if (val == DBNull.Value || val == null ){
				this.PrEIEmployeeId = null;
			}else{
				this.PrEIEmployeeId=(System.Int64)val;
			} //
			return;
		case FLD_SALARY:
			if (val == DBNull.Value || val == null ){
				this.PrSalary = null;
			}else{
				this.PrSalary=(System.Decimal)val;
			} //
			return;
		case FLD_ADDRESS:
			if (val == DBNull.Value || val == null ){
				this.PrAddress = null;
			}else{
				this.PrAddress=(System.String)val;
			} //
			return;
		default:
			return;
		}

		}

		public override void setAttribute(string fieldKey, object val) {
			fieldKey = fieldKey.ToLower();
		if ( fieldKey==STR_FLD_EMPLOYEEINFOID.ToLower()){
			if (val == DBNull.Value || val ==null ){
				throw new ApplicationException("Can't set Primary Key to null");
			} else {
				this.PrEmployeeInfoId=(System.Int64)val;
			}
			return;
		} else if ( fieldKey==STR_FLD_EIEMPLOYEEID.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrEIEmployeeId = null;
			} else {
				this.PrEIEmployeeId=(System.Int64)val;
			}
			return;
		} else if ( fieldKey==STR_FLD_SALARY.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrSalary = null;
			} else {
				this.PrSalary=(System.Decimal)val;
			}
			return;
		} else if ( fieldKey==STR_FLD_ADDRESS.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrAddress = null;
			} else {
				this.PrAddress=(System.String)val;
			}
			return;
		}
		}

		#endregion
		#region "Overrides of GetHashCode and Equals "
		public bool Equals(EmployeeInfoBase other)
		{

			//typesafe equals, checks for equality of fields
			if (other == null)
				return false;
			if (object.ReferenceEquals(other, this))
				return true;

			return this.PrEmployeeInfoId == other.PrEmployeeInfoId
				&& this.PrEIEmployeeId.GetValueOrDefault() == other.PrEIEmployeeId.GetValueOrDefault()
				&& this.PrSalary.GetValueOrDefault() == other.PrSalary.GetValueOrDefault()
				&& this.PrAddress == other.PrAddress;;

		}

		public override int GetHashCode()
		{
			//using Xor has the advantage of not overflowing the integer.
			return this.PrEmployeeInfoId.GetHashCode()
				 ^ this.PrEIEmployeeId.GetHashCode()
				 ^ this.PrSalary.GetHashCode()
				 ^ this.getStringHashCode(this.PrAddress);;

		}

		public override bool Equals(object Obj) {

			if (Obj != null && Obj is EmployeeInfoBase) {

				return this.Equals((EmployeeInfoBase)Obj);

			} else {
				return false;
			}

		}

		public static bool operator ==(EmployeeInfoBase obj1, EmployeeInfoBase obj2)
		{
			return object.Equals(obj1, obj2);
		}

		public static bool operator !=(EmployeeInfoBase obj1, EmployeeInfoBase obj2)
		{
			return !(obj1 == obj2);
		}

		#endregion

		#region "Copy and sort"

		public override IModelObject copy()
		{
			//creates a copy

			//NOTE: we can't cast from EmployeeInfoBase to EmployeeInfo, so below we 
			//instantiate a EmployeeInfo, NOT a EmployeeInfoBase object
			EmployeeInfo ret = EmployeeInfoFactory.Create();

		ret.PrEmployeeInfoId = this.PrEmployeeInfoId;
		ret.PrEIEmployeeId = this.PrEIEmployeeId;
		ret.PrSalary = this.PrSalary;
		ret.PrAddress = this.PrAddress;



			return ret;

		}

		public override void merge(IModelObject other)
		{
			//merges this EmployeeInfo model object (me) with the "other" instance 

			EmployeeInfo o = (EmployeeInfo)other;

if ( o.PrEIEmployeeId != null && 
		 this.PrEIEmployeeId == null){
		this.PrEIEmployeeId = o.PrEIEmployeeId;
}
if ( o.PrSalary != null && 
		 this.PrSalary == null){
		this.PrSalary = o.PrSalary;
}
if (! string.IsNullOrEmpty(o.PrAddress) && 
		 string.IsNullOrEmpty(this.PrAddress)){
		this.PrAddress = o.PrAddress;
}


		}

		

		#endregion

#region "parentIdChanged"
	//below sub is called when parentIdChanged
	public override void handleParentIdChanged(IModelObject parentMo ){
		// Assocations from CsModelObjects.Employee
		if ( parentMo is CsModelObjects.Employee) {
			this.PrEIEmployeeId= ((CsModelObjects.Employee)parentMo).PrEmployeeId;
		}
	}
#endregion



		#region "ID Property"

		public override object Id {
			get { return this._EmployeeInfoId; }
			set {
				this._EmployeeInfoId = Convert.ToInt64(value);
				this.raiseBroadcastIdChange();
			}
		}
		#endregion

		#region "Extra Code"

		#endregion

	}

	#region "Req Fields validator"
	[System.Runtime.InteropServices.ComVisible(false)]
	public class EmployeeInfoRequiredFieldsValidator : IModelObjectValidator
	{


		public void validate(org.model.lib.Model.IModelObject imo) {
			EmployeeInfo mo = (EmployeeInfo)imo;
if (mo.PrEIEmployeeId == null ) {
		throw new ModelObjectRequiredFieldException("EIEmployeeId");
}

		}

	}
	#endregion

}


