Module mUtilTreeNode

    ''' <summary>
    ''' getDateListFromTreeNode で取得した List から日付の最大と最小の組を取得する
    ''' </summary>
    ''' <param name="objVoList"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getDatePairFromTreeNode(ByVal objVoList As List(Of Double)) As cValueObjects.VoDatePair

        Dim dblStart As Double = objVoList(0)
        Dim dblEnd As Double = objVoList(0)

        For Each objDate As Double In objVoList

            dblStart = getMoreOldDate(dblStart, objDate)
            dblEnd = getMoreNewDate(dblEnd, objDate)

        Next

        Dim objVo As New cValueObjects.VoDatePair

        objVo.objStart = getDateFromNumber(dblStart)
        objVo.objEnd = getDateFromNumber(dblEnd)

        getDatePairFromTreeNode = objVo

    End Function

    ''' <summary>
    ''' TreeNode 配下の WorkTime の日付のリストを取得する
    ''' </summary>
    ''' <param name="objTreeNode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getDateListFromTreeNode(ByVal objTreeNode As TreeNode) As List(Of Double)

        Dim objVoList As New List(Of Double)

        If isNodeType(eNodeType.vRoot, objTreeNode) = True _
        Or isNodeType(eNodeType.vCustomer, objTreeNode) = True _
        Or isNodeType(eNodeType.vBusiness, objTreeNode) = True _
        Or isNodeType(eNodeType.vClass, objTreeNode) = True Then

            For Each objNode As TreeNode In objTreeNode.Nodes

                objVoList.AddRange(getDateListFromTreeNode(objNode))

            Next

        End If

        If isNodeType(eNodeType.vDetail, objTreeNode) = True Then

            For Each objNode As TreeNode In objTreeNode.Nodes

                objVoList.Add(getDateFromWorkDetail(objNode.Tag))

            Next

        End If

        If isNodeType(eNodeType.vWorkTime, objTreeNode) = True Then

            objVoList.Add(getDateFromWorkDetail(objTreeNode.Tag))

        End If

        getDateListFromTreeNode = objVoList

    End Function

    Public Function isParent(ByVal objParent As TreeNode, ByVal objChild As TreeNode) As Boolean

        Do While Not objChild Is Nothing
            If Not objParent Is objChild.Parent Then
                objChild = objChild.Parent
                isParent = False
            Else
                isParent = True
                Exit Do
            End If
        Loop

    End Function

    ''' <summary>
    ''' 渡された TreeNode が指定された NodeType かどうか判定する
    ''' </summary>
    ''' <param name="objType"></param>
    ''' <param name="objTreeNode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function isNodeType(ByVal objType As eNodeType, ByVal objTreeNode As TreeNode) As Boolean

        If getNodeTypeLongStringFromTag(objTreeNode) = getNodeTypeLongString(objType) Then
            isNodeType = True
        Else
            isNodeType = False
        End If

    End Function

    ''' <summary>
    ''' WorkTimeDetail [09:00-10:00@20101226] から 09:00 を取得する
    ''' </summary>
    ''' <param name="strWorkTimeDetail"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getTimeStartFromWorkDetail(ByVal strWorkTimeDetail As String) As String

        getTimeStartFromWorkDetail = _
            strWorkTimeDetail.Substring(0, strWorkTimeDetail.IndexOf("-"))

    End Function

    ''' <summary>
    ''' WorkTimeDetail [09:00-10:00@20101226] から 10:00 を取得する
    ''' </summary>
    ''' <param name="strWorkTimeDetail"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getTimeEndFromWorkDetail(ByVal strWorkTimeDetail As String) As String

        getTimeEndFromWorkDetail = _
            strWorkTimeDetail.Substring( _
                strWorkTimeDetail.IndexOf("-") + 1, 5)

    End Function

    ''' <summary>
    ''' WorkTimeDetail [09:00-10:00@20101226] から 20101226 を取得する
    ''' </summary>
    ''' <param name="strWorkTimeDetail"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getDateFromWorkDetail(ByVal strWorkTimeDetail As String) As String

        getDateFromWorkDetail = _
            strWorkTimeDetail.Substring(strWorkTimeDetail.IndexOf("@") + 1)

    End Function

    Public Function getTagNameFromTag(ByVal strTag As String) As String

        getTagNameFromTag = Split(strTag, ",")(0)

    End Function

    Public Function getTextFromText(ByVal strText As String) As String

        getTextFromText = Split(strText, ":")(1)

    End Function

    Public Function getDateFromNodeText(ByVal strNodeText As String) As String

        Return strNodeText.Substring( _
            strNodeText.IndexOf(":") + 1, _
            strNodeText.IndexOf("(") - strNodeText.IndexOf(":") - 1)

    End Function

    Public Function getTimeFromNodeText(ByVal strNodeText As String) As String

        Return strNodeText.Substring( _
            strNodeText.IndexOf("(") + 1, _
            strNodeText.IndexOf(")") - strNodeText.IndexOf("(") - 1)

    End Function

    ''' <summary>
    ''' TreeNode.Tag から 日付 を取得する
    ''' </summary>
    ''' <param name="objTreeNode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getWorkTimeDateFromTag(ByVal objTreeNode As TreeNode)

        getWorkTimeDateFromTag = _
            objTreeNode.Tag.ToString.Substring(objTreeNode.Tag.ToString.IndexOf("@") + 1)

    End Function

    ''' <summary>
    ''' TreeNode.Tag から NodeType を取得する
    ''' </summary>
    ''' <param name="objTreeNode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getNodeTypeLongStringFromTag(ByVal objTreeNode As TreeNode) As String

        getNodeTypeLongStringFromTag = Split(objTreeNode.Tag, ",")(0)

    End Function

    ''' <summary>
    ''' 各 Node に割り当てられる Code を取得する
    ''' </summary>
    ''' <param name="objTreeNode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getNodeCodeFromTag(ByVal objTreeNode As TreeNode) As String

        getNodeCodeFromTag = Split(objTreeNode.Tag, ",")(1)

    End Function

    ''' <summary>
    ''' WorkTimeDetail を取得する
    ''' </summary>
    ''' <param name="objTreeNode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getWorkTimeDetailFromTag(ByVal objTreeNode As TreeNode) As String

        If isNodeType(eNodeType.vWorkTime, objTreeNode) = False Then
            getWorkTimeDetailFromTag = ""
            Exit Function
        End If

        getWorkTimeDetailFromTag = Split(objTreeNode.Tag, ",")(2)

    End Function

    ''' <summary>
    ''' NodeType を定義する
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum eNodeType As Integer
        vCustomer = 0
        vBusiness = 1
        vClass = 2
        vDetail = 3
        vWorkTime = 4
        vRoot = 5
    End Enum

    ''' <summary>
    ''' NodeType を表す短縮形の文字列を取得する
    ''' </summary>
    ''' <param name="intNodeType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getNodeTypeShortString(ByVal intNodeType As eNodeType) As String

        Select Case intNodeType

            Case eNodeType.vCustomer
                getNodeTypeShortString = "CS"

            Case eNodeType.vBusiness
                getNodeTypeShortString = "BS"

            Case eNodeType.vClass
                getNodeTypeShortString = "CL"

            Case eNodeType.vDetail
                getNodeTypeShortString = "DT"

            Case eNodeType.vWorkTime
                getNodeTypeShortString = "WT"

            Case eNodeType.vRoot
                getNodeTypeShortString = "RT"

            Case Else
                getNodeTypeShortString = ""

        End Select

    End Function

    ''' <summary>
    ''' NodeType を表す非短縮形の文字列を取得する
    ''' </summary>
    ''' <param name="intNodeType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getNodeTypeLongString(ByVal intNodeType As eNodeType) As String

        Select Case intNodeType

            Case eNodeType.vCustomer
                getNodeTypeLongString = "Customer"

            Case eNodeType.vBusiness
                getNodeTypeLongString = "Business"

            Case eNodeType.vClass
                getNodeTypeLongString = "Class"

            Case eNodeType.vDetail
                getNodeTypeLongString = "Detail"

            Case eNodeType.vWorkTime
                getNodeTypeLongString = "WorkTime"

            Case eNodeType.vRoot
                getNodeTypeLongString = "Root"

            Case Else
                getNodeTypeLongString = ""

        End Select

    End Function

    ''' <summary>
    ''' List(Of TreeNode) から TreeNode にオブジェクトを型変換する
    ''' </summary>
    ''' <param name="objVoList"></param>
    ''' <param name="objParentTreeNode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getTreeNodeFromNodeList(ByVal objVoList As List(Of TreeNode), ByVal objParentTreeNode As TreeNode) As TreeNode

        Dim objTreeNode As New TreeNode

        For Each objVo As TreeNode In objVoList
            objTreeNode.Nodes.Add(objVo)
        Next

        objTreeNode.Text = objParentTreeNode.Text
        objTreeNode.Tag = objParentTreeNode.Tag

        getTreeNodeFromNodeList = objTreeNode

    End Function

    ''' <summary>
    ''' TreeNode から指定された Node を返す
    ''' </summary>
    ''' <param name="objSearchTreeNode"></param>
    ''' <param name="objTargetTreeNode"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getSelectedNode(ByVal objSearchTreeNode As TreeNode, ByVal objTargetTreeNode As TreeNode) As TreeNode

        If getNodeCodeFromTag(objSearchTreeNode) = _
            getNodeCodeFromTag(objTargetTreeNode) Then

            getSelectedNode = objSearchTreeNode

        Else

            Dim objReturnNode As New TreeNode

            For Each objNode As TreeNode In objSearchTreeNode.Nodes

                If getNodeTypeLongStringFromTag(objNode) <> _
                    getNodeTypeLongString(eNodeType.vWorkTime) Then

                    objReturnNode = _
                        getSelectedNode( _
                            objNode, objTargetTreeNode)

                End If

                If Not isNothingOrEmptyString(objReturnNode.Text) Then
                    If getNodeCodeFromTag(objReturnNode) = _
                        getNodeCodeFromTag(objTargetTreeNode) Then
                        Exit For
                    End If
                End If

            Next

            getSelectedNode = objReturnNode

        End If

    End Function

    Public Function getTreeNodeCopy(ByVal objTreeNode As TreeNode, ByVal objDateStart As Date, ByVal objDateEnd As Date, ByVal blnDeleteEmptyNode As Boolean) As List(Of TreeNode)

        Dim objNewTreeNodes As New List(Of TreeNode)

        For Each objNode As TreeNode In objTreeNode.Nodes

            Dim objNewChildTreeNode As New TreeNode

            If getNodeTypeLongStringFromTag(objNode) = _
                getNodeTypeLongString(eNodeType.vCustomer) _
            Or getNodeTypeLongStringFromTag(objNode) = _
                getNodeTypeLongString(eNodeType.vBusiness) _
            Or getNodeTypeLongStringFromTag(objNode) = _
                getNodeTypeLongString(eNodeType.vClass) _
            Or getNodeTypeLongStringFromTag(objNode) = _
                getNodeTypeLongString(eNodeType.vDetail) Then

                Dim objSubNodes As List(Of TreeNode) = _
                    getTreeNodeCopy(objNode, objDateStart, objDateEnd, blnDeleteEmptyNode)

                If objSubNodes.Count <> 0 _
                Or blnDeleteEmptyNode = False Then

                    objNewChildTreeNode = getTreeNodeFromNodeList(objSubNodes, objNode)

                End If

            End If

            If getNodeTypeLongStringFromTag(objNode) = _
                getNodeTypeLongString(eNodeType.vWorkTime) Then

                If Integer.Parse(getWorkTimeDateFromTag(objNode)) <= _
                    Integer.Parse(objDateEnd.ToString("yyyyMMdd")) _
                And _
                   Integer.Parse(getWorkTimeDateFromTag(objNode)) >= _
                    Integer.Parse(objDateStart.ToString("yyyyMMdd")) Then

                    objNewChildTreeNode.Text = objNode.Text
                    objNewChildTreeNode.Tag = objNode.Tag

                    objNewTreeNodes.Add(objNewChildTreeNode)

                End If

            End If

            If getNodeTypeLongStringFromTag(objNode) <> _
                getNodeTypeLongString(eNodeType.vWorkTime) Then

                If objNewChildTreeNode.Nodes.Count <> 0 _
                Or blnDeleteEmptyNode = False Then
                    objNewTreeNodes.Add(objNewChildTreeNode)
                End If

            End If


        Next

        getTreeNodeCopy = objNewTreeNodes

    End Function

End Module
