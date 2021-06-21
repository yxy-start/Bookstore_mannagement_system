Module ManageConsumerService
    Dim objdataSet As New DataSet
    Public Function manageConsumer_Select(user As User)
        If (user.Get_用户名 <> "" And user.Get_性别() = "") Then
            If (SelectUsername(user)) Then
                objdataSet = SelectUsernameTable(user)
                Return objdataSet
            Else
                MsgBox("用户不存在哦！")
            End If
        ElseIf (user.Get_性别 <> "" And user.Get_用户名() = "") Then
            objdataSet = SelectUsersexTable(user)
            Return objdataSet
        ElseIf (user.Get_用户名() = "" And user.Get_性别() = "") Then
            objdataSet = SelectUserAllTable(user)
            Return objdataSet
        Else
            MsgBox("请只输入一个条件查询！")
        End If
        Return 0
    End Function

    Public Function manageConsumerAll_Select(user As User)

        If (user.Get_用户名 <> "" And user.Get_性别() <> "") Then
            If (SelectUsername(user)) Then
                objdataSet = SelectConsumerAllTable(user)
                Return objdataSet
            Else
                MsgBox("用户不存在哦！")
            End If
        ElseIf (user.Get_用户名() = "" And user.Get_性别() = "") Then
            objdataSet = SelectUserAllTable(user)
            Return objdataSet
        Else
            MsgBox("请输入两个条件查询！")
        End If
        Return 0

    End Function

    Public Sub manageConsumer_Delete(user As User)
        DeleteManageConsumer(user)

    End Sub

    Public Sub manageConsumer_Update(user As User)
        UpdateManageConsumer(user)
    End Sub
End Module
