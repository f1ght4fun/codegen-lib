﻿Option Strict On
Imports System.Runtime.InteropServices

'<comments>
'************************************************************
' Template: ModelBaseExtender2.visualBasic.txt
' Class autogenerated on 13-04-2015 09:55:54 by ModelGenerator
' Extends base model object class
' *** FELL FREE to change code in this class.  
'     It will NOT be re-generated and 
'     overwritten by the code generator ****
' 
'************************************************************
'</comments>

Namespace VbBusObjects
	<ComVisible(False)> _
	Public Class EmployeeInfoFactory
		
		'Shared function to create a new instance of the class and return it.
		'you can create other shared functions to return a new 
		'instance with parameters
		Public Shared Function Create() As EmployeeInfo
            Return New EmployeeInfo()
        End Function
    
	End Class

	<Serializable()> _
	Public class EmployeeInfo
		inherits EmployeeInfoBase

#Region "Constructor"
    
    Friend sub New()
        
		'Empty constructor.  
        
    End Sub

#End Region

#Region "Overrides"

#End Region
        
#Region "Custom Properties and Other Methods "

#End Region

	End Class

End Namespace

