Imports System.Data.SqlClient
Imports System.Data.OleDb

Module UserDao

    Dim conn As String = "Provider=Sqloledb;data source=DESKTOP-D3LOO8V;connect timeout=5;User ID=sa;Password='20204';initial catalog=Bookstore;"
    Dim conn2 As String = "data source=DESKTOP-D3LOO8V;connect timeout=5;User ID=sa;Password='20204';initial catalog=Bookstore;"

    '方法：userSelectUsername();
    '作用：用于查询2个登录用户是否存在
    '参数：(username,table)
    '返回值：用户名是否存在于表中(int),1存在，否在不存在

    Public Function userSelectUsername(user As UserLogin)
        Dim f As Integer
        Try
            Dim objconn As New SqlConnection(conn2)
            Dim strsql As String = "select count(*) from " & user.Get_table() & " where 用户名 = '" & user.Get_用户名() & "'"
            objconn.Open()
            'MsgBox(strsql)
            Dim objcmd As New SqlCommand(strsql, objconn)
            f = objcmd.ExecuteScalar
            objconn.Close()
            objcmd.Dispose()
        Catch ex As Exception
            MsgBox("用户名：" + ex.Message)
        End Try
        If (f > 0) Then
            Return 1
        Else
            Return 0
        End If
    End Function


    '方法：userSelectPassworld();
    '作用：用于2个登录用户表的密码判断
    '参数：(username,table)
    '返回值：1密码正确
    Public Function userSelectPassworld(user As UserLogin)

        Dim f As Integer
        Try
            Dim objconn As New OleDbConnection(conn)    '创建连接对象
            Dim objAdap As OleDbDataAdapter             '创建适配器对象
            Dim objDataSet As New DataSet               '创建数据集对象
            Dim strsql As String = "select 用户密码 from " & user.Get_table() & " where 用户密码 = '" & user.Get_用户密码() & "'"
            objAdap = New OleDbDataAdapter(strsql, conn)
            objDataSet.Reset()                          '清除数据集
            objAdap.Fill(objDataSet, "user")       '第二个参数就是给这个虚拟表起个名字
            f = objDataSet.Tables("user").Rows(0).Item(0)

        Catch ex As Exception
            MsgBox("用户密码：" + ex.Message)
        End Try
        If (Int(user.Get_用户密码()) = f) Then
            Return 1
        Else
            Return 0
        End If

    End Function

    '方法：userSelect();
    '作用：用户表数据查询
    '参数：(username,table)
    '返回值：user

    Public Function userSelect(username As String)
        Dim user As New UserLogin
        Try
            Dim objconn As New OleDbConnection(conn)        '创建连接对象
            Dim objAdap As OleDbDataAdapter                 '创建适配器对象
            Dim objdataSet As New DataSet
            Dim strsql As String = "select count(*) from " & user.Get_table() & " where 用户名='" & username & "'" & "  and  " & "  用户密码='" & user.Get_用户密码() & "'"
            objAdap = New OleDbDataAdapter(strsql, objconn)
            objdataSet.Reset()                              '清除数据集
            objAdap.Fill(objdataSet, "user")                '第二个参数就是给这个虚拟表起个名字

            user.Set_用户名(objdataSet.Tables("user").Rows(0).Item(0))   '第一行第一个单元格
            user.Set_用户密码(objdataSet.Tables("user").Rows(0).Item(1))
        Catch ex As Exception
            MsgBox("userSelect:" + ex.Message)
        End Try
        Return user
    End Function

End Module
