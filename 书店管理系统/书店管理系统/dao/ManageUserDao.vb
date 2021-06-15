Imports System.Data.SqlClient
Imports System.Data.OleDb

Module ManageUserDao

    Dim conn As String = sqlconn()
    Dim conn2 As String = sqlconn2()

    '方法：userSelectUsername();
    '作用：用于查询2个登录用户是否存在
    '参数：(username,table)
    '返回值：用户名是否存在于表中(int),1存在，否在不存在

    Public Function Selectmanagename(manageuser As ManageUser)
        Dim f As Integer
        Try
            Dim objconn As New SqlConnection(conn2)
            Dim strsql As String = "select count(*) from 系统用户表 where 用户名 = '" & manageuser.Get_manageName() & "'"
            objconn.Open()
            'MsgBox(strsql)
            Dim objcmd As New SqlCommand(strsql, objconn)
            f = objcmd.ExecuteScalar
            objconn.Close()
            objcmd.Dispose()
        Catch ex As Exception
        End Try
        If (f > 0) Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Sub Insertmanage(manageuser As ManageUser)
        Try
            Dim strsql As String = "insert into 系统用户表(用户名 ,用户密码 ,性别 ,电话 ) values('" & manageuser.Get_manageName() & "','" & manageuser.Get_managePassworld() & "','" & manageuser.Get_manageSex() & "','" & manageuser.Get_manageIphone() & "')"
            Dim objconn As New SqlConnection(conn2)
            Dim objcmd As New SqlCommand(strsql, objconn)
            objconn.Open()
            objcmd.ExecuteNonQuery()
            MsgBox("管理员添加成功！")
            objconn.Close()
        Catch ex As Exception
            MsgBox("Insertmanage:" + ex.Message)
        End Try

    End Sub

    Public Sub Deletemanage(manageuser As ManageUser)
        Try
            Dim strsql As String = "delete from 系统用户表 where 用户名 ='" & manageuser.Get_manageName() & "'"
            Dim objconn As New SqlConnection(conn2)
            Dim objcmd As New SqlCommand(strsql, objconn)
            objconn.Open()
            objcmd.ExecuteNonQuery()
            MsgBox("管理员删除成功！")
            objconn.Close()
        Catch ex As Exception
            MsgBox("Deletemanage:" + ex.Message)
        End Try

    End Sub

End Module
