Module ManageConsumerService
    Dim objdataSet As New DataSet
    Public Function manageConsumer_Select(user As User)
<<<<<<< HEAD
       
        If (user.Get_用户编号() <> "" And user.Get_籍贯() = "" And user.Get_用户名 = "" And user.Get_性别() = "") Then
            If (SelectUserid(user)) Then
                objdataSet = SelectUseridTable(user)
                Return objdataSet
            Else
                MsgBox("用户编号不存在哦！")
            End If
        ElseIf (user.Get_用户名 <> "" And user.Get_性别() = "" And user.Get_用户编号() = "" And user.Get_籍贯() = "") Then
=======
        If (user.Get_用户名 <> "" And user.Get_性别() = "") Then
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
            If (SelectUsername(user)) Then
                objdataSet = SelectUsernameTable(user)
                Return objdataSet
            Else
                MsgBox("用户不存在哦！")
            End If
<<<<<<< HEAD
        ElseIf (user.Get_性别 <> "" And user.Get_用户名() = "" And user.Get_用户编号() = "" And user.Get_籍贯() = "") Then
            objdataSet = SelectUsersexTable(user)
            Return objdataSet

        ElseIf (user.Get_用户名() = "" And user.Get_性别() = "" And user.Get_用户编号() = "" And user.Get_籍贯() <> "") Then
            If (SelectUserfrom(user)) Then
                objdataSet = SelectUserfromTable(user)
                Return objdataSet
            Else
                MsgBox("没有该籍贯的用户哦！")
            End If

        ElseIf (user.Get_用户名() = "" And user.Get_性别() = "" And user.Get_用户编号() = "" And user.Get_籍贯() = "") Then
            objdataSet = SelectUserAllTable(user)
            Return objdataSet

=======
        ElseIf (user.Get_性别 <> "" And user.Get_用户名() = "") Then
            objdataSet = SelectUsersexTable(user)
            Return objdataSet
        ElseIf (user.Get_用户名() = "" And user.Get_性别() = "") Then
            objdataSet = SelectUserAllTable(user)
            Return objdataSet
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
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
<<<<<<< HEAD
    Public Sub manageConsumer_Insert(user As User)
        If (SelectUserid(user)) Then
            MsgBox("用户编号已存在，不能重复添加！")
        Else
            InsertManageConsumer(user)
            MsgBox("添加成功，请重新进入！", 64, "提示")
        End If

    End Sub
=======
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
End Module
