﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using org.model.lib;
using org.model.lib.Model;
using org.model.lib.db;

using System.Linq;
using CsModelObjects;

//<comments>
// Template: DBMapperBase.csharp.txt
//************************************************************
// 
// Class autogenerated on06-Jul-15 3:49:49 PM by ModelGenerator
// Extends base DBMapperBase object class
// *** DO NOT change code in this class.  
//     It will be re-generated and 
//     overwritten by the code generator ****
// Instead, change code in the extender class EmployeeProjectDBMapper
//
//************************************************************
//</comments>

namespace CsModelMappers {

	[System.Runtime.InteropServices.ComVisible(false)][SelectObject("EmployeeProject")][KeyFieldName("EmployeeProjectId")]
	public class EmployeeProjectDBMapper : DBMapper {

		#region "Constructors "
		public EmployeeProjectDBMapper(DBUtils _dbConn) : base(_dbConn) {
		}


		public EmployeeProjectDBMapper() : base() {
		}
		#endregion

		#region "Overloaded Functions"

		public new EmployeeProject findWhere(string sWhereClause, params object[] @params) {

			return (EmployeeProject)base.findWhere(sWhereClause, @params);
		}


		public void saveEmployeeProject(EmployeeProject mo) {
			base.save(mo);
		}

		public new EmployeeProject findByKey(object keyval) {

			return (EmployeeProject)base.findByKey(keyval);

		}

		#endregion


		#region "getUpdateDBCommand"
		public override IDbCommand getUpdateDBCommand(IModelObject modelObj, string sql) {
			EmployeeProject obj = (EmployeeProject)modelObj;
			IDbCommand stmt = this.dbConn.getCommand(sql);
			stmt.Parameters.Add(this.dbConn.getParameter(EmployeeProject.STR_FLD_EPEMPLOYEEID,obj.PrEPEmployeeId));
			stmt.Parameters.Add(this.dbConn.getParameter(EmployeeProject.STR_FLD_EPPROJECTID,obj.PrEPProjectId));
			stmt.Parameters.Add(this.dbConn.getParameter(EmployeeProject.STR_FLD_ASSIGNDATE,obj.PrAssignDate));
			stmt.Parameters.Add(this.dbConn.getParameter(EmployeeProject.STR_FLD_ENDDATE,obj.PrEndDate));
			stmt.Parameters.Add(this.dbConn.getParameter(EmployeeProject.STR_FLD_RATE,obj.PrRate));

			if (obj.isNew){
			} else {
			//only add primary key if we are updating and as the last parameter
				stmt.Parameters.Add(this.dbConn.getParameter(EmployeeProject.STR_FLD_EMPLOYEEPROJECTID,obj.PrEmployeeProjectId));
			}

			return stmt;
		}
		#endregion

	public override void saveParents(IModelObject mo ){

		EmployeeProject thisMo  = ( EmployeeProject)mo;
		//*** Parent Association:project
		if ((thisMo.PrProject!=null) && (thisMo.PrProject.NeedsSave)) {
			CsModelMappers.ProjectDBMapper mappervar = new CsModelMappers.ProjectDBMapper(this.dbConn);
			mappervar.save(thisMo.PrProject);
			thisMo.PrEPProjectId = thisMo.PrProject.PrProjectId;
		}
		
	}

		#region "Find functions"

		///	<summary>Given an sql statement, it opens a result set, and for each record returned, 
		///	it creates and loads a ModelObject. </summary>
		///	<param name="sWhereClause">where clause to be applied to "selectall" statement 
		/// that returns one or more records from the database, corresponding to the ModelObject we are going to load </param>
		///	 <param name="params"> Parameter values to be passed to sql statement </param>
		///	 <returns> A List(Of EmployeeProject) object containing all objects loaded </returns>
		///	 
		public new List<EmployeeProject> findList(string sWhereClause, params object[] @params) {

			string sql = this.getSqlWithWhereClause(sWhereClause);
			IDataReader rs = null;
			List<EmployeeProject> molist = new List<EmployeeProject>();

			try {
				rs = dbConn.getDataReaderWithParams(sql, @params);
				this.Loader.DataSource = rs;

				while (rs.Read()) {
					IModelObject mo = this.getModelInstance();
					this.Loader.load(mo);
					molist.Add((EmployeeProject)mo);

				}


			} finally {
				this.dbConn.closeDataReader(rs);
			}

			return molist;

		}

		///    
		///	 <summary>Returns all records from database for a coresponding ModelObject </summary>
		/// <returns>List(Of EmployeeProject) </returns>
		public List<EmployeeProject> findAll()
		{
			return this.findList(string.Empty);
		}

		public override IModelObjectLoader Loader {
			get {
				if (this._loader == null) {
					this._loader = new EmployeeProjectDataReaderLoader();
				}
				return this._loader;
			}
			set { this._loader = value; }
		}

		#endregion

		public override IModelObject getModelInstance() {
			return new EmployeeProject();
		}

	}

	#region " EmployeeProject Loader "
	[System.Runtime.InteropServices.ComVisible(false)]
	public class EmployeeProjectDataReaderLoader : DataReaderLoader {
		public override void load(IModelObject mo) {
			const int DATAREADER_FLD_EMPLOYEEPROJECTID = 0;
			const int DATAREADER_FLD_EPEMPLOYEEID = 1;
			const int DATAREADER_FLD_EPPROJECTID = 2;
			const int DATAREADER_FLD_ASSIGNDATE = 3;
			const int DATAREADER_FLD_ENDDATE = 4;
			const int DATAREADER_FLD_RATE = 5;

			EmployeeProject obj = (EmployeeProject)mo;
			obj.IsObjectLoading = true;

			if (!this.reader.IsDBNull(DATAREADER_FLD_EMPLOYEEPROJECTID) ) {
				obj.PrEmployeeProjectId = Convert.ToInt64(this.reader.GetInt32(DATAREADER_FLD_EMPLOYEEPROJECTID));
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_EPEMPLOYEEID) ) {
				obj.PrEPEmployeeId = Convert.ToInt64(this.reader.GetInt32(DATAREADER_FLD_EPEMPLOYEEID));
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_EPPROJECTID) ) {
				obj.PrEPProjectId = Convert.ToInt64(this.reader.GetInt32(DATAREADER_FLD_EPPROJECTID));
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_ASSIGNDATE) ) {
				obj.PrAssignDate = this.reader.GetDateTime(DATAREADER_FLD_ASSIGNDATE);
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_ENDDATE) ) {
				obj.PrEndDate = this.reader.GetDateTime(DATAREADER_FLD_ENDDATE);
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_RATE) ) {
				obj.PrRate = this.reader.GetDecimal(DATAREADER_FLD_RATE);
			}


			obj.isNew = false;
			// since we've just loaded from database, we mark as "old"
			obj.isDirty = false;
			obj.IsObjectLoading = false;
			obj.afterLoad();

			return;

		}

	}

	#endregion

	///<summary>
	/// Final Class with convinience shared methods for loading/saving the EmployeeProjectRank ModelObject. 
	///</summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class EmployeeProjectDataUtils {

		#region "Shared ""get"" Functions "

		public static List<EmployeeProject> findList(string @where, params object[] @params){

			EmployeeProjectDBMapper dbm = new EmployeeProjectDBMapper();
			return dbm.findList(@where, @params);

		}

		public static EmployeeProject findOne(string @where, params object[] @params) {

			EmployeeProjectDBMapper dbm = new EmployeeProjectDBMapper();
			return (EmployeeProject)dbm.findWhere(@where, @params);

		}

		public static List<EmployeeProject> findList(){

			return new EmployeeProjectDBMapper().findAll();

		}

		public static EmployeeProject findByKey(object id) {

			return (EmployeeProject)new EmployeeProjectDBMapper().findByKey(id);

		}

		/// <summary>
		/// Reload the EmployeeProject from the database
		/// </summary>
		/// <remarks>
		/// use this method when you want to relad the EmployeeProject 
		/// from the database, discarding any changes
		/// </remarks>
		public static void reload(ref EmployeeProject mo) {

			if (mo == null) {
				throw new System.ArgumentNullException("null object past to reload function");
			}

			mo = (EmployeeProject)new EmployeeProjectDBMapper().findByKey(mo.Id);

		}

		#endregion

		#region "Shared Save and Delete Functions"
		/// <summary>
		/// Convinience method to save a EmployeeProject Object.
		/// Important note: DO NOT CALL THIS IN A LOOP!
		/// </summary>
		/// <param name="EmployeeProjectObj"></param>
		/// <remarks>
		/// Important note: DO NOT CALL THIS IN A LOOP!  
		/// This method simply instantiates a EmployeeProjectDBMapper and calls the save method
		/// </remarks>
		public static void saveEmployeeProject(params EmployeeProject[] EmployeeProjectObj)
		{

			EmployeeProjectDBMapper dbm = new EmployeeProjectDBMapper();
			dbm.saveList(EmployeeProjectObj.ToList());


		}


		public static void deleteEmployeeProject(EmployeeProject EmployeeProjectObj)
		{

			EmployeeProjectDBMapper dbm = new EmployeeProjectDBMapper();
			dbm.delete(EmployeeProjectObj);

		}
		#endregion

		#region "Data Table and data row load/save "

		public static void saveEmployeeProject(DataRow dr, ref EmployeeProject mo) {
			if (mo == null) {
				mo = new EmployeeProject();
			}

			foreach (DataColumn dc in dr.Table.Columns) {
				mo.setAttribute(dc.ColumnName, dr[dc.ColumnName]);
			}

			saveEmployeeProject(mo);

		}

		public static void saveEmployeeProject(DataTable dt, ref EmployeeProject mo) {
			foreach (DataRow dr in dt.Rows) {
				saveEmployeeProject(dr, ref mo);
			}

		}

		public static EmployeeProject loadFromDataRow(DataRow r) {

			DataRowLoader a = new DataRowLoader();
			IModelObject mo = new EmployeeProject();
			a.DataSource = r;
			a.load(mo);
			return (EmployeeProject)mo;

		}

		#endregion

	}

}


