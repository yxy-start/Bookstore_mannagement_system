Module UserService

    Public Sub UserSystemIndex(user As User)
        If (userSelectUsername(user)) Then
            If (userSelectPassworld(user)) Then
                Dim usersystemindex As New User_System_Index(user)
                usersystemindex.ShowDialog()
            Else
                MsgBox("密码错误,请重新输入！")
            End If
        Else
            MsgBox("系统用户不存在，请点击注册！")
        End If
    End Sub

    Public Sub UserIndex(user As User)
        If (userSelectUsername(user)) Then
            If (userSelectPassworld(user)) Then
                Dim userindex As New User_Index(user)
                userindex.ShowDialog()
            Else
                MsgBox("密码错误,请重新输入！")
            End If
        Else
            MsgBox("普通用户不存在，请点击注册！")
        End If
    End Sub

    Public Sub userLoginindex(user As User)
        If (userSelectUsername(user) = 0) Then
            If (userInsert(user) = 0) Then
                Dim dl As New UserLogin
                MsgBox("注册成功,即将返回登录界面！")
                dl.ShowDialog()
            End If
        Else
            MsgBox("用户已存在！")
        End If
    End Sub

    Public Sub userupdatapassworld(user As User)
        If (SelectUsername(user)) Then
            userUpdatepassworld(user)
            Dim dl As New UserLogin
            MsgBox("修改成功,即将返回登录界面！")
            dl.ShowDialog()
        Else
            MsgBox("普通用户不存在，请点击注册！")
        End If

    End Sub

    Public Sub Consumer_Select(username As String)
        Dim user As User
        user = userSelect(username)
        'MsgBox(user.Get_用户名())
        Dim consumer As New Consumer(user)
        consumer.ShowDialog()
    End Sub

    Public Sub consumerUpdate(user As User)
        user = userconsumer_Update(user)
        MsgBox("个人信息修改成功！")
        Dim consumer As New Consumer(user)
        consumer.ShowDialog()
    End Sub

    Public Sub consumerDelete(user As User)
        userconsumer_Delete(user)
    End Sub

End Module
