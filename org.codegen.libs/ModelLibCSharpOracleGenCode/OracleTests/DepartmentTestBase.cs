﻿
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using org.model.lib.Model;
using OracleModel;

///<comments>
/// Template: TestTemplate.csharp.txt
///************************************************************
/// Class autogenerated on 5/16/2015 8:08:32 AM by ModelGenerator
/// DO NOT MODIFY CODE IN THIS CLASS!!
///************************************************************
///</comments>
[TestClass()] public class DepartmentTestBase {

    ///<summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext {get;set;}
    

#region "Additional test attributes"
    ///
    /// You can use the following additional attributes as you write your tests:
    ///
    /// Use ClassInitialize to run code before running the first test in the class
    [ClassInitialize()] public static void MyClassInitialize(TestContext testContext ) {
        ModelContext.newForUnitTests();
    }
    
    /// Use ClassCleanup to run code after all tests in a class have run
    [ClassCleanup()] public static void MyClassCleanup() {
        ModelContext.release();
    }


    //Use TestInitialize to run code before running each test
    [TestInitialize()]
    public void MyTestInitialize() {
    }
    
    // Use TestCleanup to run code after each test has run
    [TestCleanup()] public void MyTestCleanup() {
    
	}
    
#endregion


    [TestMethod()] public void TestLoadAndSaveDepartment() {
		
		ModelContext.beginTrans();
		try {

			object pid  = ModelContext.CurrentDBUtils.getObjectValue("select top 1 DEPARTMENT_ID from DEPARTMENTS");
			if (pid == null) {
				Assert.Inconclusive("No Department in database, table is empty");
			} else {

				OracleMappers.DepartmentDBMapper pdb = new OracleMappers.DepartmentDBMapper();
				Department p = pdb.findByKey(pid);
				Department p2 = (Department)p.copy();

				//Test equality and hash codes
				Assert.AreEqual(p.GetHashCode(), p2.GetHashCode());
				Assert.AreEqual(p, p2);
						
				p.isDirty = true ; // force save
				pdb.save(p);
			
				// now reload object from database
				p = null;
				p = pdb.findByKey(pid);
            
				//test fields to be equal before and after save
						Assert.IsTrue(p.PrDepartmentId == p2.PrDepartmentId,"Expected Field DepartmentId to be equal");
		Assert.IsTrue(p.PrDepartmentName == p2.PrDepartmentName,"Expected Field DepartmentName to be equal");
		Assert.IsTrue(p.PrManagerId.GetValueOrDefault() == p2.PrManagerId.GetValueOrDefault(),"Expected Field ManagerId to be equal");
		Assert.IsTrue(p.PrLocationId.GetValueOrDefault() == p2.PrLocationId.GetValueOrDefault(),"Expected Field LocationId to be equal");
		Assert.IsTrue(p.CreateDate.GetValueOrDefault() == p2.CreateDate.GetValueOrDefault(),"Expected Field CreateDate to be equal");
		Assert.IsFalse(p.UpdateDate.GetValueOrDefault() == p2.UpdateDate.GetValueOrDefault(),"Expected Field UpdateDate NOT to be equal");
		Assert.IsTrue(p.CreateUser == p2.CreateUser,"Expected Field CreateUser to be equal");
		// skip update user!

				
				
				p.isDirty = true; //to force save
				ModelContext.Current.saveModelObject(p);

				p = ModelContext.Current.loadModelObject< Department >(p.Id);
				
			}

		} finally {
            ModelContext.rollbackTrans(); // 'Nothing should be saved to the database!
        }

   }

}

