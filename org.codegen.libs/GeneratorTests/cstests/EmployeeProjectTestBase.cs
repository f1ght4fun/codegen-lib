﻿
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using org.model.lib.Model;
using CsModelObjects;

///<comments>
/// Template: TestTemplate.csharp.txt
///************************************************************
/// Class autogenerated on 5/16/2015 8:03:27 AM by ModelGenerator
/// DO NOT MODIFY CODE IN THIS CLASS!!
///************************************************************
///</comments>
[TestClass()] public class EmployeeProjectTestBase {

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


    [TestMethod()] public void TestLoadAndSaveEmployeeProject() {
		
		ModelContext.beginTrans();
		try {

			object pid  = ModelContext.CurrentDBUtils.getObjectValue("select top 1 EmployeeProjectId from EmployeeProject");
			if (pid == null) {
				Assert.Inconclusive("No EmployeeProject in database, table is empty");
			} else {

				CsModelMappers.EmployeeProjectDBMapper pdb = new CsModelMappers.EmployeeProjectDBMapper();
				EmployeeProject p = pdb.findByKey(pid);
				EmployeeProject p2 = (EmployeeProject)p.copy();

				//Test equality and hash codes
				Assert.AreEqual(p.GetHashCode(), p2.GetHashCode());
				Assert.AreEqual(p, p2);
						
				p.isDirty = true ; // force save
				pdb.save(p);
			
				// now reload object from database
				p = null;
				p = pdb.findByKey(pid);
            
				//test fields to be equal before and after save
						Assert.IsTrue(p.PrEmployeeProjectId == p2.PrEmployeeProjectId,"Expected Field EmployeeProjectId to be equal");
		Assert.IsTrue(p.PrEPEmployeeId.GetValueOrDefault() == p2.PrEPEmployeeId.GetValueOrDefault(),"Expected Field EPEmployeeId to be equal");
		Assert.IsTrue(p.PrEPProjectId.GetValueOrDefault() == p2.PrEPProjectId.GetValueOrDefault(),"Expected Field EPProjectId to be equal");
		Assert.IsTrue(p.PrAssignDate.GetValueOrDefault() == p2.PrAssignDate.GetValueOrDefault(),"Expected Field AssignDate to be equal");
		Assert.IsTrue(p.PrEndDate.GetValueOrDefault() == p2.PrEndDate.GetValueOrDefault(),"Expected Field EndDate to be equal");
		Assert.IsTrue(p.PrRate.GetValueOrDefault() == p2.PrRate.GetValueOrDefault(),"Expected Field Rate to be equal");

					Assert.IsTrue(p.PrProject != null);

				
				p.isDirty = true; //to force save
				ModelContext.Current.saveModelObject(p);

				p = ModelContext.Current.loadModelObject< EmployeeProject >(p.Id);
				
			}

		} finally {
            ModelContext.rollbackTrans(); // 'Nothing should be saved to the database!
        }

   }

}

