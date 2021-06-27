Public Class Manage_Consumer

    Dim user As New User()
    Dim objdataSet As New DataSet
    Dim linenum As Integer
    Dim dr As DataRow
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        linenum = 0
        Try
<<<<<<< HEAD

            Dim userid As String = TextBox3.Text.Trim
            Dim username As String = TextBox1.Text.Trim
            Dim usersex As String = ComboBox1.Text
            Dim userfrom As String = TextBox4.Text.Trim
            user.Set_用户编号(userid)
            user.Set_用户名(username)
            user.Set_性别(usersex)
            user.Set_籍贯(userfrom)

=======
            Dim username As String = TextBox1.Text
            Dim usersex As String = ComboBox1.Text
            user.Set_用户名(username)
            user.Set_性别(usersex)
            'MsgBox(user.Get_性别())
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
            objdataSet = manageConsumer_Select(user)
            DataGridView1.DataSource = objdataSet.Tables("user")
            DataGridView1.AllowUserToAddRows = False                        'DataGridView不显示最后空白的行
            linenum = DataGridView1.CurrentRow.Index
            DataGridView1.CurrentCell = DataGridView1.Rows(linenum).Cells(0)    '移动游标
            DataGridView1.Rows(linenum).Selected = True                         '设置选中行
<<<<<<< HEAD

        Catch ex As Exception
            MsgBox("单查询" + ex.Message)
        End Try
    End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    linenum = 0
    '    Try
    '        Dim userid As Integer = TextBox3.Text
    '        Dim username As String = TextBox1.Text
    '        Dim usersex As String = ComboBox1.Text
    '        Dim userfrom As String = TextBox4.Text
    '        user.Set_用户编号(userid)
    '        user.Set_用户名(username)
    '        user.Set_性别(usersex)
    '        user.Set_籍贯(userfrom)
    '        objdataSet = manageConsumerAll_Select(user)
    '        DataGridView1.DataSource = objdataSet.Tables("user")
    '        DataGridView1.AllowUserToAddRows = False                            'DataGridView不显示最后空白的行
    '        linenum = DataGridView1.CurrentRow.Index
    '        DataGridView1.CurrentCell = DataGridView1.Rows(linenum).Cells(0)    '移动游标
    '        DataGridView1.Rows(linenum).Selected = True
    '    Catch ex As Exception

    '    End Try
    'End Sub
=======
            
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
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        linenum = DataGridView1.CurrentRow.Index
        DataGridView1.CurrentCell = DataGridView1.Rows(linenum).Cells(0)  '移动游标
        DataGridView1.Rows(linenum).Selected = True '设置选中行
        dr = objdataSet.Tables(0).Rows(linenum)
        Call consumer()
    End Sub
    Dim xgzqxh As String = ""
    Public Sub consumer()
<<<<<<< HEAD

        If Not dr.IsNull("用户编号") Then
            TextBox3.Text = dr.Item("用户编号")
            xgzqxh = TextBox3.Text
        Else
            TextBox3.Text = ""
            xgzqxh = ""
        End If
=======
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
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
<<<<<<< HEAD
        If Not dr.IsNull("籍贯") Then
            TextBox4.Text = dr.Item("籍贯")
            xgzqxh = TextBox4.Text
        Else
            TextBox4.Text = ""
            xgzqxh = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim userid As String = TextBox3.Text
        user.Set_用户编号(userid)
        If TextBox3.Text = "" Then
=======
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username As String = TextBox1.Text
        user.Set_用户名(username)
        If TextBox1.Text = "" Then
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
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
<<<<<<< HEAD
        TextBox3.Text = ""
        TextBox1.Text = ""
        ComboBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim userid As String = TextBox3.Text.Trim
        Dim username As String = TextBox1.Text.Trim
        Dim usersex As String = ComboBox1.Text
        Dim userfrom As String = TextBox4.Text.Trim
        user.Set_用户编号(userid)
        user.Set_用户名(username)
        user.Set_性别(usersex)
        user.Set_籍贯(userfrom)
        If TextBox3.Text = "" Then
=======
        TextBox1.Text = ""
        ComboBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim username As String = TextBox1.Text
        user.Set_用户名(username)
        If TextBox1.Text = "" Then
>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
            MsgBox("没有选择记录不能修改！", 64, "提示")
        Else
            Dim manageupdate As New Manage_Consumer_Update(user)
            manageupdate.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
<<<<<<< HEAD
        TextBox3.Text = ""
        TextBox1.Text = ""
        ComboBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
    End Sub

   
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim manageconsumeradd As New Manage_Consumer_Add(user)
        manageconsumeradd.ShowDialog()
=======
        TextBox1.Text = ""
        ComboBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Manage_Consumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

>>>>>>> 41ebf7d88b3ef9cd38b46e1b73ce164c29239ad1
    End Sub
End Class