
Imports System.Xml
Imports System.IO
Imports System.Text

Public Class fExport

    Private Sub objButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles objButtonExec.Click

        Close()

    End Sub

    Private Sub objDateTimePickerStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles objDateTimePickerStart.ValueChanged

        objDateTimePickerEnd.Value = GetEndOfMonth(objDateTimePickerStart.Value)

    End Sub

    Private Sub FormJobReporterByMonth_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        objDateTimePickerStart.Value = GetStartOfMonth(Date.Today)
        objDateTimePickerEnd.Value = GetEndOfMonth(Date.Today)

    End Sub

    Private Sub objCheckBoxAllDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles objCheckBoxAllDate.Click

        If objCheckBoxAllDate.Checked = True Then

            objDateTimePickerStart.Enabled = False
            objDateTimePickerEnd.Enabled = False

        Else

            objDateTimePickerStart.Enabled = True
            objDateTimePickerEnd.Enabled = True

        End If

    End Sub

End Class