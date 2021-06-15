Module UserService

    Public Sub UserSystemIndex(user As User)
        If (userSelectUsername(user)) Then
            If (userSelectPassworld(user)) Then
                Dim usersystemindex As New User_System_Index
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
                Dim userindex As New User_Index
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

End Module
