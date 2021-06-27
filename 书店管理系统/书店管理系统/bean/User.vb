Public Class User

    Private 用户编号 As String
    Private 用户名 As String
    Private 用户密码 As String
    Private 性别 As String
    Private 电话号码 As String
    Private 籍贯 As String
    Private table As String


    Public Function Get_用户编号()
        Return 用户编号
    End Function
    Public Sub Set_用户编号(userId As String)
        Me.用户编号 = userId
    End Sub
    Public Function Get_用户名()
        Return 用户名
    End Function
    Public Sub Set_用户名(username As String)
        Me.用户名 = username
    End Sub

    Public Function Get_用户密码()
        Return 用户密码
    End Function

    Public Sub Set_用户密码(passworld As String)
        Me.用户密码 = passworld
    End Sub

    Public Function Get_性别()
        Return 性别
    End Function

    Public Sub Set_性别(sex As String)
        Me.性别 = sex
    End Sub

    Public Function Get_电话号码()
        Return 电话号码
    End Function

    Public Sub Set_电话号码(iPhone As String)
        Me.电话号码 = iPhone
    End Sub
    Public Function Get_籍贯()
        Return 籍贯
    End Function
    Public Sub Set_籍贯(brithFrom As String)
        Me.籍贯 = brithFrom
    End Sub

    Public Function Get_table()
        Return table
    End Function
    Public Sub Set_table(t As String)
        Me.table = t
    End Sub

End Class
