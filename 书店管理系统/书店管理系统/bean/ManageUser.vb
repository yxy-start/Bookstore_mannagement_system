Public Class ManageUser

    Private manageName As String
    Private managePassworld As String
    Private manageSex As String
    Private manageIphone As Integer
    Private table As String

    Public Function Get_manageName()
        Return manageName
    End Function
    Public Sub Set_manageName(manageName As String)
        Me.manageName = manageName
    End Sub

    Public Function Get_managePassworld()
        Return managePassworld
    End Function
    Public Sub Set_managePassworld(managePassworld As String)
        Me.managePassworld = managePassworld
    End Sub

    Public Function Get_manageSex()
        Return manageSex
    End Function
    Public Sub Set_manageSex(manageSex As String)
        Me.manageSex = manageSex
    End Sub

    Public Function Get_manageIphone()
        Return manageIphone
    End Function
    Public Sub Set_manageIphone(manageIphone As String)
        Me.manageIphone = manageIphone
    End Sub

    Public Function Get_table()
        Return table
    End Function
    Public Sub Set_table(t As String)
        Me.table = t
    End Sub
End Class
