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

	[Table(Name = "EmployeeRank")]
	[DataContract][SelectObject("EmployeeRank")][KeyFieldName("RankId")]
	[DefaultMapperAttr(typeof(CsModelMappers.EmployeeRankDBMapper)), ComVisible(false), Serializable(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
	partial class EmployeeRank:ModelObject,IEquatable<EmployeeRank>  {

		#region "Constructor"

		public EmployeeRank() {
			this.Id = ModelObjectKeyGen.nextId();
			this.addValidator(new EmployeeRankRequiredFieldsValidator());
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

					public const String STR_FLD_RANKID = "RankId";
			public const String STR_FLD_RANK = "Rank";


				public const int FLD_RANKID = 0;
		public const int FLD_RANK = 1;



		///<summary> Returns the names of fields in the object as a string array.
		/// Useful in automatically setting/getting values from UI objects (windows or web Form)</summary>
		/// <returns> string array </returns>	 
		public override string[] getFieldList()
		{
			return new string[] {
				STR_FLD_RANKID,STR_FLD_RANK
			};
		}

		#endregion

		#region "Field Declarations"

	private System.Int64 _RankId;
	private System.String _Rank;

		#endregion

		#region "Field Properties"

		//Field RankId
		[Required]
		[Column(Name="RankId",Storage = "_RankId", IsPrimaryKey=true,DbType = "int NOT NULL",CanBeNull = false)]
		[DataMember]
		public virtual System.Int64 PrRankId{
			get{			
				return _RankId;
			}
			set {
				if (ModelObject.valueChanged(_RankId, value)){
					if (!this.IsObjectLoading) {
						this.isDirty = true; //
						this.setFieldChanged(STR_FLD_RANKID);
					}
					this._RankId = value;
					this.raiseBroadcastIdChange();
				}
			}
		}
		//Field Rank
		[Key]
		[Required]
		[StringLength(50, ErrorMessage="Rank must be 50 characters or less")]
		[Column(Name="Rank",Storage = "_Rank", IsPrimaryKey=false,DbType = "nvarchar NOT NULL",CanBeNull = false)]
		[DataMember]
		public virtual System.String PrRank{
			get{			
				return _Rank;
			}
			set {
				if (ModelObject.valueChanged(_Rank, value)){
					if (value != null && value.Length > 50){
						throw new ModelObjectFieldTooLongException("Rank");
					}
					if (!this.IsObjectLoading) {
						this.isDirty = true; //
						this.setFieldChanged(STR_FLD_RANK);
					}
					this._Rank = value;
				}
			}
		}

		#endregion

		#region "Getters/Setters of values by field index/name"
		public override object getAttribute(int fieldKey){

		switch (fieldKey) {
		case FLD_RANKID:
			return this.PrRankId;
		case FLD_RANK:
			return this.PrRank;
		default:
			return null;
		} //end switch

		}

		public override object getAttribute(string fieldKey) {
			fieldKey = fieldKey.ToLower();

		if (fieldKey==STR_FLD_RANKID.ToLower() ) {
			return this.PrRankId;
		} else if (fieldKey==STR_FLD_RANK.ToLower() ) {
			return this.PrRank;
		} else {
			return null;
		}
		}

		public override void setAttribute(int fieldKey, object val){
			try {
		switch (fieldKey) {
		case FLD_RANKID:
			if (val == DBNull.Value || val == null ){
				throw new ApplicationException("Can't set Primary Key to null");
			} else {
				this.PrRankId=(System.Int64)val;
			} //
			return;
		case FLD_RANK:
			if (val == DBNull.Value || val == null ){
				this.PrRank = null;
			} else {
				this.PrRank=(System.String)val;
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
		if ( fieldKey==STR_FLD_RANKID.ToLower()){
			if (val == DBNull.Value || val ==null ){
				throw new ApplicationException("Can't set Primary Key to null");
			} else {
				this.PrRankId=Convert.ToInt64(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_RANK.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrRank = null;
			} else {
				this.PrRank=Convert.ToString(val);
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
		public bool Equals(EmployeeRank other)
		{

			//typesafe equals, checks for equality of fields
			if (other == null)
				return false;
			if (object.ReferenceEquals(other, this))
				return true;

			return this.PrRankId == other.PrRankId
				&& this.PrRank == other.PrRank;;

		}

		public override int GetHashCode()
		{
			//using Xor has the advantage of not overflowing the integer.
			return this.PrRankId.GetHashCode()
				 ^ this.getStringHashCode(this.PrRank);;

		}

		public override bool Equals(object Obj) {

			if (Obj != null && Obj is EmployeeRank) {

				return this.Equals((EmployeeRank)Obj);

			} else {
				return false;
			}

		}

		public static bool operator ==(EmployeeRank obj1, EmployeeRank obj2)
		{
			return object.Equals(obj1, obj2);
		}

		public static bool operator !=(EmployeeRank obj1, EmployeeRank obj2) {
			return !(obj1 == obj2);
		}

		#endregion

		#region "Copy and sort"

		public override IModelObject copy() {
			//creates a copy
			EmployeeRank ret = new EmployeeRank();
		ret.PrRankId = this.PrRankId;
		ret.PrRank = this.PrRank;

			return ret;

		}

		#endregion




		#region "ID Property"

		[DataMember]public sealed override object Id {
			get { return this._RankId; }
			set {
				this._RankId = Convert.ToInt64(value);
				this.raiseBroadcastIdChange();
			}
		}
		#endregion

		#region "Extra Code"

		#endregion

	}

	#region "Req Fields validator"
	[System.Runtime.InteropServices.ComVisible(false)]
	public class EmployeeRankRequiredFieldsValidator : IModelObjectValidator {

		public void validate(org.model.lib.Model.IModelObject imo) {
			EmployeeRank mo = (EmployeeRank)imo;
			if (string.IsNullOrEmpty( mo.PrRank)) {
		throw new ModelObjectRequiredFieldException("Rank");
}

		}

	}
	#endregion

}


