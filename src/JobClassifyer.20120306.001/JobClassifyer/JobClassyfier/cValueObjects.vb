Public Class cValueObjects

    Public Class VoWorkDetail
        Implements System.IComparable

        Public strText As String
        Public strDate As String
        Public strStart As String
        Public strEnd As String
        Public dblTime As Double

        Public Function CompareTo(ByVal other As Object) As Integer _
             Implements System.IComparable.CompareTo

            'Nothingより大きいとする
            If other Is Nothing Then
                Return 1
            End If

            '違う型とは比較できない
            If Not Me.GetType() Is other.GetType() Then
                Throw New ArgumentException()
            End If

            '比較する
            Return Me.strDate.CompareTo(CType(other, VoWorkDetail).strDate) * 10 + _
                Me.strStart.CompareTo(CType(other, VoWorkDetail).strStart)

        End Function

    End Class

    Public Class VoWorkAtDate

        Public strDate As String
        Public strStart As String
        Public strEnd As String

    End Class

    Public Class VoCountByBusiness

        Public strBusinessText As String
        Public dblValue As Double

    End Class

    Public Class VoDatePair

        Public objStart As Date
        Public objEnd As Date

    End Class

    Public Class VoTreeNodeAndDatePair

        Public objNode As TreeNode
        Public objDatePair As New VoDatePair

    End Class

End Class
