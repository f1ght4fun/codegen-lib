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
namespace OracleModel {

	[Table(Name = "REGIONS")]
	[DataContract][SelectObject("REGIONS")][KeyFieldName("REGION_ID")]
	[DefaultMapperAttr(typeof(OracleMappers.RegionDBMapper)), ComVisible(false), Serializable(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
	partial class Region:ModelObject,IEquatable<Region>  {

		#region "Constructor"

		public Region() {
			this.Id = ModelObjectKeyGen.nextId();
			this.addValidator(new RegionRequiredFieldsValidator());
		}

		#endregion

		#region "Children and Parents"
		
		[OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context) {
            this.IsObjectLoading = true;
        }

		[OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context) {

			this.IsObjectLoading = false;
			this.isDirty = true;
        }

		public override void loadObjectHierarchy() {

		}

		/// <summary>
		/// Returns the *loaded* children of this model object.
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

					public const String STR_FLD_REGION_ID = "RegionId";
			public const String STR_FLD_REGION_NAME = "RegionName";


				public const int FLD_REGION_ID = 0;
		public const int FLD_REGION_NAME = 1;



		///<summary> Returns the names of fields in the object as a string array.
		/// Useful in automatically setting/getting values from UI objects (windows or web Form)</summary>
		/// <returns> string array </returns>	 
		public override string[] getFieldList()
		{
			return new string[] {
				STR_FLD_REGION_ID,STR_FLD_REGION_NAME
			};
		}

		#endregion

		#region "Field Declarations"

	private System.Int64 _RegionId;
	private System.String _RegionName;

		#endregion

		#region "Field Properties"

		//Field REGION_ID
		[Required]
		[Column(Name="REGION_ID",Storage = "_RegionId", IsPrimaryKey=true,DbType = " NOT NULL",CanBeNull = false)]
		[DataMember]
		public virtual System.Int64 PrRegionId{
			get{			
				return _RegionId;
			}
			set {
				if (ModelObject.valueChanged(_RegionId, value)){
					if (!this.IsObjectLoading) {
						this.isDirty = true; //
						this.setFieldChanged(STR_FLD_REGION_ID);
					}
					this._RegionId = value;
					this.raiseBroadcastIdChange();
				}
			}
		}
		//Field REGION_NAME
		[Key]
		[StringLength(25, ErrorMessage="REGION_NAME must be 25 characters or less")]
		[Column(Name="REGION_NAME",Storage = "_RegionName", IsPrimaryKey=false,DbType = "",CanBeNull = true)]
		[DataMember]
		public virtual System.String PrRegionName{
			get{			
				return _RegionName;
			}
			set {
				if (ModelObject.valueChanged(_RegionName, value)){
					if (value != null && value.Length > 25){
						throw new ModelObjectFieldTooLongException("REGION_NAME");
					}
					if (!this.IsObjectLoading) {
						this.isDirty = true; //
						this.setFieldChanged(STR_FLD_REGION_NAME);
					}
					this._RegionName = value;
				}
			}
		}

		#endregion

		#region "Getters/Setters of values by field index/name"
		public override object getAttribute(int fieldKey){

		switch (fieldKey) {
		case FLD_REGION_ID:
			return this.PrRegionId;
		case FLD_REGION_NAME:
			return this.PrRegionName;
		default:
			return null;
		} //end switch

		}

		public override object getAttribute(string fieldKey) {
			fieldKey = fieldKey.ToLower();

		if (fieldKey==STR_FLD_REGION_ID.ToLower() ) {
			return this.PrRegionId;
		} else if (fieldKey==STR_FLD_REGION_NAME.ToLower() ) {
			return this.PrRegionName;
		} else {
			return null;
		}
		}

		public override void setAttribute(int fieldKey, object val){
			try {
		switch (fieldKey) {
		case FLD_REGION_ID:
			if (val == DBNull.Value || val == null ){
				throw new ApplicationException("Can't set Primary Key to null");
			} else {
				this.PrRegionId=(System.Int64)val;
			} //
			return;
		case FLD_REGION_NAME:
			if (val == DBNull.Value || val == null ){
				this.PrRegionName = null;
			} else {
				this.PrRegionName=(System.String)val;
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
		if ( fieldKey==STR_FLD_REGION_ID.ToLower()){
			if (val == DBNull.Value || val ==null ){
				throw new ApplicationException("Can't set Primary Key to null");
			} else {
				this.PrRegionId=Convert.ToInt64(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_REGION_NAME.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrRegionName = null;
			} else {
				this.PrRegionName=Convert.ToString(val);
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
		public bool Equals(Region other)
		{

			//typesafe equals, checks for equality of fields
			if (other == null)
				return false;
			if (object.ReferenceEquals(other, this))
				return true;

			return this.PrRegionId == other.PrRegionId
				&& this.PrRegionName == other.PrRegionName;;

		}

		public override int GetHashCode()
		{
			//using Xor has the advantage of not overflowing the integer.
			return this.PrRegionId.GetHashCode()
				 ^ this.getStringHashCode(this.PrRegionName);;

		}

		public override bool Equals(object Obj) {

			if (Obj != null && Obj is Region) {

				return this.Equals((Region)Obj);

			} else {
				return false;
			}

		}

		public static bool operator ==(Region obj1, Region obj2)
		{
			return object.Equals(obj1, obj2);
		}

		public static bool operator !=(Region obj1, Region obj2) {
			return !(obj1 == obj2);
		}

		#endregion

		#region "Copy and sort"

		public override IModelObject copy() {
			//creates a copy
			Region ret = new Region();
		ret.PrRegionId = this.PrRegionId;
		ret.PrRegionName = this.PrRegionName;

			return ret;

		}

		#endregion




		#region "ID Property"

		[DataMember]public sealed override object Id {
			get { return this._RegionId; }
			set {
				this._RegionId = Convert.ToInt64(value);
				this.raiseBroadcastIdChange();
			}
		}
		#endregion

		#region "Extra Code"

		#endregion

	}

	#region "Req Fields validator"
	[System.Runtime.InteropServices.ComVisible(false)]
	public class RegionRequiredFieldsValidator : IModelObjectValidator {

		public void validate(org.model.lib.Model.IModelObject imo) {
			Region mo = (Region)imo;
			
		}

	}
	#endregion

}


