Module mCodeManager

    Public objCustomerCodeManager As New cCodeManager()

    Public objBusinessCodeManager As New cCodeManager()

    Public objClassCodeManager As New cCodeManager()

    Public objDetailCodeManager As New cCodeManager()

    Public objWorkTimeCodeManager As New cCodeManager()

    Public Function getNewCustomerCode() As String
        getNewCustomerCode = "CS" + Format(objCustomerCodeManager.getNewCode(), "00000")
    End Function

    Public Function getNewBusinessCode() As String
        getNewBusinessCode = "BS" + Format(objBusinessCodeManager.getNewCode(), "00000")
    End Function

    Public Function getNewClassCode() As String
        getNewClassCode = "CL" + Format(objClassCodeManager.getNewCode(), "00000")
    End Function

    Public Function getNewDetailCode() As String
        getNewDetailCode = "DT" + Format(objDetailCodeManager.getNewCode(), "00000")
    End Function

    Public Function getNewWorkTimeCode() As String
        getNewWorkTimeCode = "WT" + Format(objWorkTimeCodeManager.getNewCode(), "00000")
    End Function

End Module
