
Imports System.Data.SqlClient

''' <summary>
''' 各ノードのインデックスを管理して、新しいノードのインデックスを生成するクラスです。
''' </summary>
''' <remarks></remarks>
Public Class cCodeManager

    Private blnArray(1) As Boolean

    Private Sub add(ByVal strCode As Integer)

        ReDim Preserve blnArray(Val(strCode))

        blnArray(Val(strCode) - 1) = True

    End Sub

    Public Function getNewCode() As Integer

        Dim intIndex As Integer
        For intIndex = 0 To UBound(blnArray)

            If blnArray(intIndex) = False Then
                Exit For
            End If

        Next

        If intIndex > UBound(blnArray) Then
            ReDim Preserve blnArray(intIndex)
        End If

        blnArray(intIndex) = True

        getNewCode = intIndex + 1

    End Function

    Public Sub delete(ByVal intIndex As Integer)

        blnArray(intIndex) = False

    End Sub

End Class
