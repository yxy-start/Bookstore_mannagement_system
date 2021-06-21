Public Class Manage_Consumer

    Dim user As New User()
    Dim objdataSet As New DataSet
    Dim linenum As Integer
    Dim dr As DataRow
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        linenum = 0
        Try
            Dim username As String = TextBox1.Text
            Dim usersex As String = ComboBox1.Text
            user.Set_用户名(username)
            user.Set_性别(usersex)
            'MsgBox(user.Get_性别())
            objdataSet = manageConsumer_Select(user)
            DataGridView1.DataSource = objdataSet.Tables("user")
            DataGridView1.AllowUserToAddRows = False                        'DataGridView不显示最后空白的行
            linenum = DataGridView1.CurrentRow.Index
            DataGridView1.CurrentCell = DataGridView1.Rows(linenum).Cells(0)    '移动游标
            DataGridView1.Rows(linenum).Selected = True                         '设置选中行
            
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        linenum = 0
        Try
            Dim username As String = TextBox1.Text
            Dim usersex As String = ComboBox1.Text
            user.Set_用户名(username)
            user.Set_性别(usersex)
            objdataSet = manageConsumerAll_Select(user)
            DataGridView1.DataSource = objdataSet.Tables("user")
            DataGridView1.AllowUserToAddRows = False                            'DataGridView不显示最后空白的行
            linenum = DataGridView1.CurrentRow.Index
            DataGridView1.CurrentCell = DataGridView1.Rows(linenum).Cells(0)    '移动游标
            DataGridView1.Rows(linenum).Selected = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        linenum = DataGridView1.CurrentRow.Index
        DataGridView1.CurrentCell = DataGridView1.Rows(linenum).Cells(0)  '移动游标
        DataGridView1.Rows(linenum).Selected = True '设置选中行
        dr = objdataSet.Tables(0).Rows(linenum)
        Call consumer()
    End Sub
    Dim xgzqxh As String = ""
    Public Sub consumer()
        If Not dr.IsNull("用户名") Then
            TextBox1.Text = dr.Item("用户名")
            xgzqxh = TextBox1.Text
        Else
            TextBox1.Text = ""
            xgzqxh = ""
        End If
        If Not dr.IsNull("性别") Then
            ComboBox1.Text = dr.Item("性别")
        Else
            ComboBox1.Text = ""
        End If
        If Not dr.IsNull("电话号码") Then
            TextBox2.Text = dr.Item("电话号码")
        Else
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username As String = TextBox1.Text
        user.Set_用户名(username)
        If TextBox1.Text = "" Then
            MsgBox("没有选择记录不能删除！", 64, "提示")
        Else
            Dim yn As Integer
            yn = MsgBox("真的要删除吗?", 16 + 4, "提示")
            If yn = 6 Then
                manageConsumer_Delete(user)
                MsgBox("删除成功！")
                Call consumer1()
            End If

        End If
    End Sub
    Public Sub consumer1()
        TextBox1.Text = ""
        ComboBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim username As String = TextBox1.Text
        user.Set_用户名(username)
        If TextBox1.Text = "" Then
            MsgBox("没有选择记录不能修改！", 64, "提示")
        Else
            Dim manageupdate As New Manage_Consumer_Update(user)
            manageupdate.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        ComboBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Manage_Consumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class