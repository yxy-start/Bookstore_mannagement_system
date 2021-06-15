Module ManageUserService

    Public Sub manageUser_Select(manageuser As ManageUser)
        If (Selectmanagename(manageuser)) Then
            MsgBox("查询结如下！")
        Else
            MsgBox("此管理员不存在，请点击添加！")
        End If

    End Sub

    Public Sub manageUser_Insert(manageuser As ManageUser)
        If (Selectmanagename(manageuser) = 0) Then
            Insertmanage(manageuser)
        Else
            MsgBox("用户已存在，无法再添加！")
        End If
    End Sub

    Public Sub manageUser_delete(manageuser As ManageUser)
        If (Selectmanagename(manageuser)) Then
            Deletemanage(manageuser)
        Else
            MsgBox("此管理员不存在，无法删除！")
        End If
    End Sub
End Module
