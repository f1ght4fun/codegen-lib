﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using org.model.lib.Model;
using org.model.lib;
using System.Threading;
using System.Globalization;
using org.codegen.lib;
using System.IO;
using Microsoft.CSharp;
using System.CodeDom.Compiler;


namespace GeneratorTests {

	[TestClass]
	public class GenAndRunObjectTests {

        [TestMethod]
        public void runObjectTests() {
            
            DirectoryInfo d = new DirectoryInfo("..\\..\\");
            string path = d.FullName + "VbObjectTestsTmp.cs";

            File.Delete(path);

            File.Copy( d.FullName + "CSharpObjectTests.cs",  path) ;
            string readText = File.ReadAllText(path);
            //using ModelLibVBGenCode.VbBusObjects;
            //using ModelLibVBGenCode.VbBusObjects.DBMappers;
            readText = readText.Replace("using CsModelObjects;", "using ModelLibVBGenCode.VbBusObjects;");
            readText = readText.Replace("using CsModelMappers;", "using ModelLibVBGenCode.VbBusObjects.DBMappers;");
            File.WriteAllText(path, readText);

        }


		[TestMethod]
		public void runGenerateCodeTests() {

			DirectoryInfo d = new DirectoryInfo("..\\..\\..\\");
			System.Diagnostics.Debug.WriteLine(d.FullName);

			XMLClassGenerator.GenerateClassesFromFile(d.FullName + "ModelLibCSharpGeneratedCode\\CSharpModelGenerator.xml");
						
			CSharpCodeProvider provider = new CSharpCodeProvider();
			CompilerParameters parameters = new CompilerParameters();
			parameters.ReferencedAssemblies.Add("Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll");
			// True - memory generation, false - external file generation
			parameters.GenerateInMemory = true;
			// True - exe file generation, false - dll file generation
			parameters.GenerateExecutable = true;
			CompilerResults results = provider.CompileAssemblyFromSource(parameters);

			XMLClassGenerator.GenerateClassesFromFile(d.FullName + "ModelLibTestsVisualBasicGeneratedCode\\VisualBasicModelGenerator.xml");

			XMLClassGenerator.GenerateClassesFromFile(d.FullName + "ModelLibCSharpOracleGenCode\\OracleCSharpModelGenerator.xml");

		}
		
	}
}
