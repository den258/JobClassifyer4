
Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Module mUtils

    Public Function getDateFromNumber(ByVal dblDate As Double) As Date

        Dim dblYear As Double = _
            getNumber( _
                dblDate.ToString("0").Substring(0, 4))

        Dim dblMonth As Double = _
            getNumber( _
                dblDate.ToString("0").Substring(4, 2))

        Dim dblDay As Double = _
            getNumber( _
                dblDate.ToString("0").Substring(6, 2))

        getDateFromNumber = New Date(dblYear, dblMonth, dblDay)

    End Function

    Public Function getNumberFromDate(ByVal objDate As Date) As Double

        getNumberFromDate = objDate.Year * 10000 + objDate.Month * 100 + objDate.Day

    End Function

    Public Function getMoreOldDate(ByVal intDate1 As Double, ByVal intDate2 As Double) As Double

        If intDate1 >= intDate2 Then
            getMoreOldDate = intDate2
        Else
            getMoreOldDate = intDate1
        End If

    End Function

    Public Function getMoreNewDate(ByVal intDate1 As Double, ByVal intDate2 As Double) As Double

        If intDate1 <= intDate2 Then
            getMoreNewDate = intDate2
        Else
            getMoreNewDate = intDate1
        End If

    End Function

    Public Function getIntDateFromDate(ByVal objArgDate As Date) As Integer

        getIntDateFromDate = objArgDate.Year * 10000 + objArgDate.Month * 100 + objArgDate.Day

    End Function

#Region "ToolStripMenu"

    Public Sub setShowMenu(ByVal objForm As fClassyfier, ByVal strType As String, ByVal strAddOr As String)

        Select Case strAddOr

            Case "Add"

                Select Case strType

                    Case "Customer"

                        objForm.objToolStripMenuItemAddCustomer.Visible = True

                    Case "Business"

                        objForm.objToolStripMenuItemAddBusiness.Visible = True

                    Case "Class"

                        objForm.objToolStripMenuItemAddClass.Visible = True

                    Case "Detail"

                        objForm.objToolStripMenuItemAddDetail.Visible = True

                End Select

            Case "Delete"

                Select Case strType

                    Case "Customer"

                        objForm.objToolStripMenuItemDeleteCustomer.Visible = True

                    Case "Business"

                        objForm.objToolStripMenuItemDeleteBusiness.Visible = True

                    Case "Class"

                        objForm.objToolStripMenuItemDeleteClass.Visible = True

                    Case "Detail"

                        objForm.objToolStripMenuItemDeleteDetail.Visible = True

                    Case "WorkTime"

                        objForm.objToolStripMenuItemDeleteWorkTime.Visible = True

                End Select

        End Select

    End Sub

    Public Sub setHideMenuAll(ByVal objForm As fClassyfier)

        objForm.objToolStripMenuItemAddCustomer.Visible = False
        objForm.objToolStripMenuItemDeleteCustomer.Visible = False
        objForm.objToolStripMenuItemAddBusiness.Visible = False
        objForm.objToolStripMenuItemAddClass.Visible = False
        objForm.objToolStripMenuItemAddDetail.Visible = False
        objForm.objToolStripMenuItemDeleteBusiness.Visible = False
        objForm.objToolStripMenuItemDeleteClass.Visible = False
        objForm.objToolStripMenuItemDeleteDetail.Visible = False
        objForm.objToolStripMenuItemDeleteWorkTime.Visible = False

    End Sub

#End Region

#Region "ポップアップメッセージ"

    Public Function showMessage(ByVal strType As String, ByVal strMessage As String) As DialogResult

        Select Case strType

            Case "Info"
                showMessage = MessageBox.Show( _
                    strMessage, strMessageTitle, _
                    MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case "Question"
                showMessage = MessageBox.Show( _
                    strMessage, strMessageTitle, _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                    MessageBoxDefaultButton.Button2)

            Case "withCancel"
                showMessage = MessageBox.Show( _
                    strMessage, strMessageTitle, _
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, _
                    MessageBoxDefaultButton.Button3)

            Case Else
                showMessage = MessageBox.Show( _
                    strMessage, strMessageTitle, MessageBoxButtons.OK)

        End Select

    End Function

#End Region

#Region "判定"

    Public Function isNothingOrEmptyString(ByVal strValue As String) As Boolean

        If strValue = "" Or strValue Is Nothing Then
            isNothingOrEmptyString = True
        Else
            isNothingOrEmptyString = False
        End If

    End Function

    Public Function isNothing(ByVal objObject As Object) As Boolean

        If objObject Is Nothing Then
            isNothing = True
        Else
            isNothing = False
        End If

    End Function

    Public Function isCorrectTimeString(ByVal strValue As String) As Boolean

        If strValue.IndexOf(":") = -1 Then
            showMessage("Info", "時間は、'09:00'の形式で入力してください。")
            isCorrectTimeString = False
            Exit Function
        End If

        If strValue.Length <> 5 Then
            showMessage("Info", "時間は、'09:00'の形式で入力してください。")
            isCorrectTimeString = False
            Exit Function
        End If

        If getNumber(strValue.Substring(3)) Mod 15 <> 0 Then
            showMessage("Info", "時間は、15分単位で入力してください。")
            isCorrectTimeString = False
            Exit Function
        End If

        If getNumber(strValue.Substring(0, 2)) < 0 _
        Or getNumber(strValue.Substring(0, 2)) > 23 Then
            showMessage("Info", "時間が、間違っています。")
            isCorrectTimeString = False
            Exit Function
        End If

        If getNumber(strValue.Substring(3)) < 0 _
        Or getNumber(strValue.Substring(3)) > 45 Then
            showMessage("Info", "時間が、間違っています。")
            isCorrectTimeString = False
            Exit Function
        End If

        isCorrectTimeString = True

    End Function

#End Region

    Public Function getNumber(ByVal strValue As String) As Double

        If isNothingOrEmptyString(strValue) = True Then
            getNumber = 0.0
        Else
            getNumber = Double.Parse(strValue)
        End If

    End Function

    Public Function getDoubleFromTimeString(ByVal strTime As String) As Double

        If isNothingOrEmptyString(strTime) = True Then
            getDoubleFromTimeString = 0
            Exit Function
        End If

        Dim dblHour As Double = _
            Double.Parse(strTime.Substring(0, 2))

        Dim dblMinute As Double = _
            Double.Parse(strTime.Substring(3)) / 60

        getDoubleFromTimeString = dblHour + dblMinute

    End Function

    Public Function getWorkedTime(ByVal strStart As String, ByVal strEnd As String) As Double
        getWorkedTime = getDoubleFromTimeString(strEnd) - getDoubleFromTimeString(strStart)
    End Function

    Public Function SetQuautation(ByVal strValue As String) As String
        SetQuautation = """" + strValue + """"
    End Function

    Public Function GetStartOfMonth(ByVal objDateStart As Date) As Date

        GetStartOfMonth = New Date(objDateStart.Year, objDateStart.Month, 1)

    End Function

    Public Function GetEndOfMonth(ByVal objDateStart As Date) As Date

        Dim objNextMonth As Date = objDateStart.AddMonths(1)
        Dim objEndOfMonth As Date = _
            Date.Parse( _
                objNextMonth.Year.ToString + "/" + objNextMonth.Month.ToString + "/1")

        GetEndOfMonth = objEndOfMonth.AddDays(-1)

    End Function

End Module
