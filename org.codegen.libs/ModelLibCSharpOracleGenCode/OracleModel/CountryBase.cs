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
// Instead, change code in the extender class Country
//
//************************************************************
//</comments>
namespace OracleModel {

	[Table(Name = "COUNTRIES")]
	[DataContract]
	[DefaultMapperAttr(typeof(OracleMappers.CountryDBMapper)), ComVisible(false), Serializable(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
	partial class Country:ModelObject,IEquatable<Country>  {

		#region "Constructor"

		public Country() {
			this.Id = ModelObjectKeyGen.nextId();
			this.addValidator(new CountryRequiredFieldsValidator());
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

					public const String STR_FLD_COUNTRY_ID = "CountryId";
			public const String STR_FLD_COUNTRY_NAME = "CountryName";
			public const String STR_FLD_REGION_ID = "RegionId";
			public const String STR_FLD_SKIP_FIELD = "SkipField";
			public const String STR_FLD_LONG_FLD = "LongFld";
			public const String STR_FLD_LONG_FLD2 = "LongFld2";


				public const int FLD_COUNTRY_ID = 0;
		public const int FLD_COUNTRY_NAME = 1;
		public const int FLD_REGION_ID = 2;
		public const int FLD_SKIP_FIELD = 3;
		public const int FLD_LONG_FLD = 4;
		public const int FLD_LONG_FLD2 = 5;



		///<summary> Returns the names of fields in the object as a string array.
		/// Useful in automatically setting/getting values from UI objects (windows or web Form)</summary>
		/// <returns> string array </returns>	 
		public override string[] getFieldList()
		{
			return new string[] {
				STR_FLD_COUNTRY_ID,STR_FLD_COUNTRY_NAME,STR_FLD_REGION_ID,STR_FLD_SKIP_FIELD,STR_FLD_LONG_FLD,STR_FLD_LONG_FLD2
			};
		}

		#endregion

		#region "Field Declarations"

	private System.String _CountryId;
	private System.String _CountryName;
	private System.Int64? _RegionId = null;
	private System.String _SkipField;
	private System.Int64? _LongFld = null;
	private System.Int64? _LongFld2 = null;

		#endregion

		#region "Field Properties"

		//Field COUNTRY_ID
	[Required][StringLength(2, ErrorMessage="COUNTRY_ID must be 2 characters or less")][Column(Name="COUNTRY_ID",Storage = "_CountryId", IsPrimaryKey=true,DbType = " NOT NULL",CanBeNull = false)]
	[DataMember]public virtual System.String PrCountryId{
	get{
		return _CountryId;
	}
	set {
		if (ModelObject.valueChanged(_CountryId, value)){
		if (value != null && value.Length > 2){
			throw new ModelObjectFieldTooLongException("COUNTRY_ID");
		}
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_COUNTRY_ID);
			}
		this._CountryId = value;

			this.raiseBroadcastIdChange();

		}
		}
	}
		//Field COUNTRY_NAME
	[Key][StringLength(40, ErrorMessage="COUNTRY_NAME must be 40 characters or less")][Column(Name="COUNTRY_NAME",Storage = "_CountryName", IsPrimaryKey=false,DbType = "",CanBeNull = true)]
	[DataMember]public virtual System.String PrCountryName{
	get{
		return _CountryName;
	}
	set {
		if (ModelObject.valueChanged(_CountryName, value)){
		if (value != null && value.Length > 40){
			throw new ModelObjectFieldTooLongException("COUNTRY_NAME");
		}
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_COUNTRY_NAME);
			}
		this._CountryName = value;

		}
		}
	}
		//Field REGION_ID
	[Key][Column(Name="REGION_ID",Storage = "_RegionId", IsPrimaryKey=false,DbType = "",CanBeNull = true)]
	[DataMember]public virtual System.Int64? PrRegionId{
	get{
		return _RegionId;
	}
	set {
		if (ModelObject.valueChanged(_RegionId, value)){
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_REGION_ID);
			}
		this._RegionId = value;

		}
		}
	}
		//Field SKIP_FIELD
	[Key][StringLength(40, ErrorMessage="SKIP_FIELD must be 40 characters or less")][Column(Name="SKIP_FIELD",Storage = "_SkipField", IsPrimaryKey=false,DbType = "",CanBeNull = true)]
	[DataMember]public virtual System.String PrSkipField{
	get{
		return _SkipField;
	}
	set {
		if (ModelObject.valueChanged(_SkipField, value)){
		if (value != null && value.Length > 40){
			throw new ModelObjectFieldTooLongException("SKIP_FIELD");
		}
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_SKIP_FIELD);
			}
		this._SkipField = value;

		}
		}
	}
		//Field LONG_FLD
	[Key][Column(Name="LONG_FLD",Storage = "_LongFld", IsPrimaryKey=false,DbType = "",CanBeNull = true)]
	[DataMember]public virtual System.Int64? PrLongFld{
	get{
		return _LongFld;
	}
	set {
		if (ModelObject.valueChanged(_LongFld, value)){
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_LONG_FLD);
			}
		this._LongFld = value;

		}
		}
	}
		//Field LONG_FLD2
	[Key][Column(Name="LONG_FLD2",Storage = "_LongFld2", IsPrimaryKey=false,DbType = "",CanBeNull = true)]
	[DataMember]public virtual System.Int64? PrLongFld2{
	get{
		return _LongFld2;
	}
	set {
		if (ModelObject.valueChanged(_LongFld2, value)){
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_LONG_FLD2);
			}
		this._LongFld2 = value;

		}
		}
	}

		#endregion

		#region "Getters/Setters of values by field index/name"
		public override object getAttribute(int fieldKey){

		switch (fieldKey) {
		case FLD_COUNTRY_ID:
			return this.PrCountryId;
		case FLD_COUNTRY_NAME:
			return this.PrCountryName;
		case FLD_REGION_ID:
			return this.PrRegionId;
		case FLD_SKIP_FIELD:
			return this.PrSkipField;
		case FLD_LONG_FLD:
			return this.PrLongFld;
		case FLD_LONG_FLD2:
			return this.PrLongFld2;
		default:
			return null;
		} //end switch

		}

		public override object getAttribute(string fieldKey) {
			fieldKey = fieldKey.ToLower();

		if (fieldKey==STR_FLD_COUNTRY_ID.ToLower() ) {
			return this.PrCountryId;
		} else if (fieldKey==STR_FLD_COUNTRY_NAME.ToLower() ) {
			return this.PrCountryName;
		} else if (fieldKey==STR_FLD_REGION_ID.ToLower() ) {
			return this.PrRegionId;
		} else if (fieldKey==STR_FLD_SKIP_FIELD.ToLower() ) {
			return this.PrSkipField;
		} else if (fieldKey==STR_FLD_LONG_FLD.ToLower() ) {
			return this.PrLongFld;
		} else if (fieldKey==STR_FLD_LONG_FLD2.ToLower() ) {
			return this.PrLongFld2;
		} else {
			return null;
		}
		}

		public override void setAttribute(int fieldKey, object val){
			try {
		switch (fieldKey) {
		case FLD_COUNTRY_ID:
			if (val == DBNull.Value || val == null ){
				throw new ApplicationException("Can't set Primary Key to null");
			} else {
				this.PrCountryId=(System.String)val;
			} //
			return;
		case FLD_COUNTRY_NAME:
			if (val == DBNull.Value || val == null ){
				this.PrCountryName = null;
			} else {
				this.PrCountryName=(System.String)val;
			} //
			return;
		case FLD_REGION_ID:
			if (val == DBNull.Value || val == null ){
				this.PrRegionId = null;
			} else {
				this.PrRegionId=(System.Int64?)val;
			} //
			return;
		case FLD_SKIP_FIELD:
			if (val == DBNull.Value || val == null ){
				this.PrSkipField = null;
			} else {
				this.PrSkipField=(System.String)val;
			} //
			return;
		case FLD_LONG_FLD:
			if (val == DBNull.Value || val == null ){
				this.PrLongFld = null;
			} else {
				this.PrLongFld=(System.Int64?)val;
			} //
			return;
		case FLD_LONG_FLD2:
			if (val == DBNull.Value || val == null ){
				this.PrLongFld2 = null;
			} else {
				this.PrLongFld2=(System.Int64?)val;
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
		if ( fieldKey==STR_FLD_COUNTRY_ID.ToLower()){
			if (val == DBNull.Value || val ==null ){
				throw new ApplicationException("Can't set Primary Key to null");
			} else {
				this.PrCountryId=Convert.ToString(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_COUNTRY_NAME.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrCountryName = null;
			} else {
				this.PrCountryName=Convert.ToString(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_REGION_ID.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrRegionId = null;
			} else {
				this.PrRegionId=Convert.ToInt64(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_SKIP_FIELD.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrSkipField = null;
			} else {
				this.PrSkipField=Convert.ToString(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_LONG_FLD.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrLongFld = null;
			} else {
				this.PrLongFld=Convert.ToInt64(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_LONG_FLD2.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrLongFld2 = null;
			} else {
				this.PrLongFld2=Convert.ToInt64(val);
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
		public bool Equals(Country other)
		{

			//typesafe equals, checks for equality of fields
			if (other == null)
				return false;
			if (object.ReferenceEquals(other, this))
				return true;

			return this.PrCountryId == other.PrCountryId
				&& this.PrCountryName == other.PrCountryName
				&& this.PrRegionId.GetValueOrDefault() == other.PrRegionId.GetValueOrDefault()
				&& this.PrSkipField == other.PrSkipField
				&& this.PrLongFld.GetValueOrDefault() == other.PrLongFld.GetValueOrDefault()
				&& this.PrLongFld2.GetValueOrDefault() == other.PrLongFld2.GetValueOrDefault();;

		}

		public override int GetHashCode()
		{
			//using Xor has the advantage of not overflowing the integer.
			return this.getStringHashCode(this.PrCountryId)
				 ^ this.getStringHashCode(this.PrCountryName)
				 ^ this.PrRegionId.GetHashCode()
				 ^ this.getStringHashCode(this.PrSkipField)
				 ^ this.PrLongFld.GetHashCode()
				 ^ this.PrLongFld2.GetHashCode();;

		}

		public override bool Equals(object Obj) {

			if (Obj != null && Obj is Country) {

				return this.Equals((Country)Obj);

			} else {
				return false;
			}

		}

		public static bool operator ==(Country obj1, Country obj2)
		{
			return object.Equals(obj1, obj2);
		}

		public static bool operator !=(Country obj1, Country obj2) {
			return !(obj1 == obj2);
		}

		#endregion

		#region "Copy and sort"

		public override IModelObject copy() {
			//creates a copy
			Country ret = new Country();
		ret.PrCountryId = this.PrCountryId;
		ret.PrCountryName = this.PrCountryName;
		ret.PrRegionId = this.PrRegionId;
		ret.PrSkipField = this.PrSkipField;
		ret.PrLongFld = this.PrLongFld;
		ret.PrLongFld2 = this.PrLongFld2;

			return ret;

		}

		#endregion




		#region "ID Property"

		[DataMember]public sealed override object Id {
			get { return this._CountryId; }
			set {
				this._CountryId = Convert.ToString(value);
				this.raiseBroadcastIdChange();
			}
		}
		#endregion

		#region "Extra Code"

		#endregion

	}

	#region "Req Fields validator"
	[System.Runtime.InteropServices.ComVisible(false)]
	public class CountryRequiredFieldsValidator : IModelObjectValidator
	{


		public void validate(org.model.lib.Model.IModelObject imo) {
			Country mo = (Country)imo;

		}

	}
	#endregion

}


