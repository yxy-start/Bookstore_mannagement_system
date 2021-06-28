Imports System.Data.SqlClient
Imports System.Data.OleDb

Module UserDao

    Dim conn As String = sqlconn()
    Dim conn2 As String = sqlconn2()

    '方法：userSelectUsername();
    '参数：(User)
    '返回值：用户名是否存在于表中(int),1存在，否在不存在

    Public Function userSelectUsername(user As User)

        Dim f As Integer
        Try
            Dim objconn As New SqlConnection(conn2)
            Dim strsql As String = "select count(*) from " & User.Get_table() & " where 用户名 = '" & User.Get_用户名() & "'"
            objconn.Open()
            'MsgBox(strsql)
            Dim objcmd As New SqlCommand(strsql, objconn)
            f = objcmd.ExecuteScalar
            objconn.Close()
            objcmd.Dispose()
        Catch ex As Exception
            MsgBox("userSelectUsername" + ex.Message)
        End Try
        If (f > 0) Then
            Return 1
        Else
            Return 0
        End If
    End Function


    '方法：userSelectPassworld();
    '返回值：1密码正确
    Public Function userSelectPassworld(user As User)

        Dim f As Integer
        Try
            Dim objconn As New OleDbConnection(conn)    '创建连接对象
            Dim objAdap As OleDbDataAdapter             '创建适配器对象
            Dim objDataSet As New DataSet               '创建数据集对象
            Dim strsql As String = "select 用户密码 from " & user.Get_table() & " where 用户名 = '" & user.Get_用户名() & "'"
            objAdap = New OleDbDataAdapter(strsql, conn)
            objDataSet.Reset()                          '清除数据集
            objAdap.Fill(objDataSet, "user")            '第二个参数就是给这个虚拟表起个名字
            f = objDataSet.Tables("user").Rows(0).Item(0)
        Catch ex As Exception
            MsgBox("userSelectPassworld" + ex.Message)
        End Try
        If (Int(user.Get_用户密码()) = f) Then
            Return 1
        Else
            Return 0
        End If

    End Function

    '方法：userSelect();
    '作用：用户表数据查询
    '参数：(username)
    '返回值：user

    Public Function userSelect(username As String)
        Dim user As New User()

        Try
            Dim objconn As New OleDbConnection(conn)        '创建连接对象
            Dim objAdap As OleDbDataAdapter                 '创建适配器对象
            Dim objdataSet As New DataSet
            Dim strsql As String = "select * from 普通用户表 where 用户名='" & username & "'"
            objAdap = New OleDbDataAdapter(strsql, objconn)

            objdataSet.Reset()'清除数据集
            objAdap.Fill(objdataSet, "user")                '第二个参数就是给这个虚拟表起个名字
            user.Set_用户编号(objdataSet.Tables("user").Rows(0).Item(0))   '第一行第一个单元格
            user.Set_用户名(objdataSet.Tables("user").Rows(0).Item(1))   '第一行第一个单元格
            user.Set_用户密码(objdataSet.Tables("user").Rows(0).Item(2))
            user.Set_性别(objdataSet.Tables("user").Rows(0).Item(3))
            user.Set_电话号码(objdataSet.Tables("user").Rows(0).Item(4))
            user.Set_籍贯(objdataSet.Tables("user").Rows(0).Item(5))
            'MsgBox(user.Get_性别())


            Return user
        Catch ex As Exception
            MsgBox("userSelect" + ex.Message)
        End Try
        Return 0
    End Function

    '方法：SelectUserid();
    '作用：查询用户名
    '参数：(userRegister)
    Public Function SelectUserid(user As User)

        Dim f As Integer
        Try
            Dim objconn As New SqlConnection(conn2)
            Dim strsql As String = "select count(*) from 普通用户表 where 用户编号 = '" & user.Get_用户编号() & "'"
            objconn.Open()
            Dim objcmd As New SqlCommand(strsql, objconn)
            f = objcmd.ExecuteScalar
            objconn.Close()
            objcmd.Dispose()
        Catch ex As Exception
            MsgBox("SelectUserid" + ex.Message)
        End Try
        If (f > 0) Then
            Return 1
        Else
            Return 0
        End If
    End Function

    '方法：SelectUsername();
    '作用：查询用户名
    '参数：(userRegister)
    Public Function SelectUsername(user As User)
        Dim f As Integer
        Try
            Dim objconn As New SqlConnection(conn2)
            Dim strsql As String = "select count(*) from 普通用户表 where 用户名 = '" & user.Get_用户名() & "'"
            objconn.Open()
            Dim objcmd As New SqlCommand(strsql, objconn)
            f = objcmd.ExecuteScalar
            objconn.Close()
            objcmd.Dispose()

        Catch ex As Exception
            MsgBox("SelectUsername" + ex.Message)
        End Try
        If (f > 0) Then
            Return 1
        Else
            Return 0
        End If
    End Function

    '方法：userInsert();
    '作用：用户添加
    '参数：(user)
    Public Sub userInsert(user As User)

        Try
            Dim strsql As String = "insert into 普通用户表(用户编号,用户名 ,用户密码 ,性别 ,电话号码,籍贯) values ('" & user.Get_用户编号() & "','" & user.Get_用户名() & "','" & user.Get_用户密码() & "','" & user.Get_性别() & "','" & user.Get_电话号码() & "','" & user.Get_籍贯() & "')"
            Dim objconn As New SqlConnection(conn2)
            Dim objcmd As New SqlCommand(strsql, objconn)
            objconn.Open()
            objcmd.ExecuteNonQuery()
            objconn.Close()
        Catch ex As Exception
            MsgBox("添加失败：" + ex.Message)
        End Try

    End Sub

    '方法：userUpdatepassworld();
    '作用：用户密码修改
    '参数：(user)
    Public Sub userUpdatepassworld(user As User)

        Try
            Dim strsql As String = "update 普通用户表 set 用户密码 = '" & user.Get_用户密码() & "' where 用户名 = '" & user.Get_用户名() & "'"
            Dim objconn As New SqlConnection(conn2)
            Dim objcmd As New SqlCommand(strsql, objconn)
            objconn.Open()
            objcmd.ExecuteNonQuery()
            objconn.Close()
        Catch ex As Exception
            MsgBox("userUpdata" + ex.Message)
        End Try

    End Sub

    Public Function userconsumer_Update(user As User)
        Try
            Dim strsql As String = "update 普通用户表 set 用户名 = '" & user.Get_用户名() & "',性别 = '" & user.Get_性别() & "',电话号码 = '" & user.Get_电话号码() & "',籍贯 = '" & user.Get_籍贯() & "' where 用户编号 = '" & user.Get_用户编号() & "'"
            Dim objconn As New SqlConnection(conn2)
            Dim objcmd As New SqlCommand(strsql, objconn)
            objconn.Open()
            objcmd.ExecuteNonQuery()
            objconn.Close()
            Return user
        Catch ex As Exception
            MsgBox("userconsumer_Update" + ex.Message)
        End Try
        Return 0
    End Function

    Public Sub userconsumer_Delete(user As User)
        Try
            Dim strsql As String = "delete from  普通用户表  where 用户编号 = '" & user.Get_用户编号() & "'"
            Dim objconn As New SqlConnection(conn2)
            Dim objcmd As New SqlCommand(strsql, objconn)
            objconn.Open()
            objcmd.ExecuteNonQuery()
            objconn.Close()
        Catch ex As Exception
            MsgBox("userconsumer_Delete" + ex.Message)
        End Try
    End Sub

    Public Function SelectUseridTable(user As User)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select 用户编号,用户名,性别,电话号码,籍贯 from 普通用户表 where 用户编号 = '" & user.Get_用户编号() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "user")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectUseridTable" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectUsernameTable(user As User)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select 用户编号,用户名,性别,电话号码,籍贯 from 普通用户表 where 用户名 = '" & user.Get_用户名() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "user")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectUsernameTable" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectUsersexTable(user As User)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select 用户编号,用户名,性别,电话号码,籍贯 from 普通用户表 where 性别 = '" & user.Get_性别() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "user")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectUsersexTable" + ex.Message)
        End Try
        Return 0
    End Function
    Public Function SelectUserfrom(user As User)
        Dim f As Integer
        Try
            Dim objconn As New SqlConnection(conn2)
            Dim strsql As String = "select count(*) from 普通用户表 where 籍贯 = '" & user.Get_籍贯() & "'"
            objconn.Open()
            Dim objcmd As New SqlCommand(strsql, objconn)
            f = objcmd.ExecuteScalar
            objconn.Close()
            objcmd.Dispose()
        Catch ex As Exception
            MsgBox("SelectUserfrom" + ex.Message)
        End Try
        If (f > 0) Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Public Function SelectUserfromTable(user As User)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select用户编号,用户名,性别,电话号码,籍贯 from 普通用户表 where 籍贯 = '" & user.Get_籍贯() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "user")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectUserfromTable" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectUserAllTable(user As User)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select 用户编号,用户名,性别,电话号码,籍贯 from 普通用户表"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "user")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectUserAllTable" + ex.Message)
        End Try
        Return 0
    End Function

    Public Function SelectConsumerAllTable(user As User)
        Try
            Dim sqlConnection As New SqlConnection(conn2)
            sqlConnection.Open()
            Dim strsql As String = "select 用户编号,用户名,性别,电话号码,籍贯 from 普通用户表 where 用户名 = '" & user.Get_用户名() & "' and 性别 = '" & user.Get_性别() & "'"
            Dim da As New SqlDataAdapter(strsql, sqlConnection)
            sqlConnection.Close()
            Dim objdataSet As New DataSet
            da.Fill(objdataSet, "user")
            Return objdataSet
        Catch ex As Exception
            MsgBox("SelectConsumerAllTable" + ex.Message)
        End Try
        Return 0
    End Function

    Public Sub DeleteManageConsumer(user As User)
        Try
            Dim strsql As String = "delete from  普通用户表  where 用户编号 = '" & user.Get_用户编号() & "'"
            Dim objconn As New SqlConnection(conn2)
            Dim objcmd As New SqlCommand(strsql, objconn)
            objconn.Open()
            objcmd.ExecuteNonQuery()
            objconn.Close()
        Catch ex As Exception
            MsgBox("DeleteManageConsumer" + ex.Message)
        End Try
    End Sub

    Public Sub UpdateManageConsumer(user As User)
        Try
            Dim strsql As String = "update 普通用户表 set  用户名 = '" & user.Get_用户名() & "',性别 = '" & user.Get_性别() & "',电话号码 = '" & user.Get_电话号码() & "',籍贯 = '" & user.Get_籍贯() & "' where 用户编号 = '" & user.Get_用户编号() & "'"
            Dim objconn As New SqlConnection(conn2)
            Dim objcmd As New SqlCommand(strsql, objconn)
            objconn.Open()
            objcmd.ExecuteNonQuery()
            objconn.Close()
            'Return user
        Catch ex As Exception
            MsgBox("UpdateManageConsumer" + ex.Message)
        End Try
    End Sub

    Public Sub InsertManageConsumer(user As User)
        Try
            Dim strsql As String = "insert into 普通用户表(用户编号,用户名 ,用户密码 ,性别 ,电话号码,籍贯) values ('" & user.Get_用户编号() & "','" & user.Get_用户名() & "','" & user.Get_用户密码() & "','" & user.Get_性别() & "','" & user.Get_电话号码() & "','" & user.Get_籍贯() & "')"
            Dim objconn As New SqlConnection(conn2)
            Dim objcmd As New SqlCommand(strsql, objconn)
            objconn.Open()
            objcmd.ExecuteNonQuery()
            objconn.Close()
            'Return user
        Catch ex As Exception
            MsgBox("InsertManageConsumer" + ex.Message)
        End Try

    End Sub
    '方法： CountUserid();
    '作用：统计用户
    '参数：(userRegister)
    Public Function CountUserid(user As User)
        Try
            Dim objconn As New OleDbConnection(conn)        '创建连接对象
            Dim objAdap As OleDbDataAdapter                 '创建适配器对象
            Dim objdataSet As New DataSet
            Dim strsql As String = "select count(用户编号) from 普通用户表"
            objAdap = New OleDbDataAdapter(strsql, objconn)
            objdataSet.Reset() '清除数据集
            objAdap.Fill(objdataSet, "user")                '第二个参数就是给这个虚拟表起个名字
            user.Set_count(objdataSet.Tables("user").Rows(0).Item(0))   '第一行第一个单元格
            Return user
        Catch ex As Exception
            MsgBox("CountUserid" + ex.Message)
        End Try
        Return 0
    End Function
End Module
