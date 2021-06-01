Module UserService


    Public Sub UserIndex(user As UserLogin)
        If (userSelectUsername(user)) Then
            If (userSelectPassworld(user)) Then
                Dim userindex As New User_Index
                userindex.ShowDialog()
            Else
                MsgBox("密码错误")
            End If
        Else
            MsgBox("普通用户不存在，请点击注册！")
        End If
    End Sub

End Module
