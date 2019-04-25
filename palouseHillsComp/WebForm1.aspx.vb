Imports System.Data
Imports System.Data.SqlClient
Public Class WebForm1
    Inherits System.Web.UI.Page
    Public Shared con As New SqlConnection("Data Source=cb-ot-devst04.ad.wsu.edu;Initial Catalog=RC91jaredgaralde;Persist Security Info=True; User ID=jaredgaralde;Password=!@#qWe11531540")


    Private Sub Store_Init(sender As Object, e As EventArgs) Handles Me.Init

        'Fill Tables
        FillInventoryTable()
        FillEmployeeTable()
        FillCustomerTable()
        FillInventoryTable()
        FillEquipmentTable()
        FillTasksTable()
        FillCurrentTasksTable()
        FillCompleteTasksTable()
        FillWorkOrdersTable()
        FillCurrentWorkOrdersTable()
        FillCompleteWorkOrdersTable()
        FillDDLInventoryList()
        FillDDLTaskList()
        FillDDLWorkOrders()


        MultiView1.ActiveViewIndex = 0

        MaintainScrollPositionOnPostBack = True

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        gvTasks.Visible = True
        gvTasksCurrent.Visible = False
        gvTasksOld.Visible = False
        gvWorkOrders.Visible = True
        gvWorkOrdersCurrent.Visible = False
        gvWorkOrdersOld.Visible = False
    End Sub


#Region "Fill Tables"

    Private Sub FillEmployeeTable()
        Dim RecordsCustomer As New SqlDataAdapter("SELECT * FROM EMPLOYEES4", con)
        Dim RecordsCustomerList As New DataTable

        If RecordsCustomerList.Rows.Count > 0 Then
            RecordsCustomerList.Rows.Clear()
        End If

        Try
            RecordsCustomer.Fill(RecordsCustomerList)
            gvEmployee.DataSource = RecordsCustomerList
            gvEmployee.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Private Sub FillCustomerTable()
        Dim RecordsCustomer As New SqlDataAdapter("SELECT * FROM CUSTOMERS4", con)
        Dim RecordsCustomerList As New DataTable

        If RecordsCustomerList.Rows.Count > 0 Then
            RecordsCustomerList.Rows.Clear()
        End If

        Try
            RecordsCustomer.Fill(RecordsCustomerList)
            gvCustomers.DataSource = RecordsCustomerList
            gvCustomers.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Private Sub FillInventoryTable()
        Dim RecordsCustomer As New SqlDataAdapter("SELECT * FROM INVENTORY4", con)
        Dim RecordsCustomerList As New DataTable

        If RecordsCustomerList.Rows.Count > 0 Then
            RecordsCustomerList.Rows.Clear()
        End If

        Try
            RecordsCustomer.Fill(RecordsCustomerList)
            gvInventory.DataSource = RecordsCustomerList
            gvInventory.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Private Sub FillEquipmentTable()
        Dim RecordsCustomer As New SqlDataAdapter("SELECT * FROM EQUIPMENT4", con)
        Dim RecordsCustomerList As New DataTable

        If RecordsCustomerList.Rows.Count > 0 Then
            RecordsCustomerList.Rows.Clear()
        End If

        Try
            RecordsCustomer.Fill(RecordsCustomerList)
            gvEquipment.DataSource = RecordsCustomerList
            gvEquipment.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Private Sub FillTasksTable()
        Dim RecordsCustomer As New SqlDataAdapter("SELECT * FROM REPAIR_TASK", con)
        Dim RecordsCustomerList As New DataTable

        If RecordsCustomerList.Rows.Count > 0 Then
            RecordsCustomerList.Rows.Clear()
        End If

        Try
            RecordsCustomer.Fill(RecordsCustomerList)
            gvTasks.DataSource = RecordsCustomerList
            gvTasks.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Private Sub FillCurrentTasksTable()
        Dim RecordsCustomer As New SqlDataAdapter("SELECT * FROM REPAIR_TASK WHERE completionStatus = 'Incomplete'", con)
        Dim RecordsCustomerList As New DataTable

        If RecordsCustomerList.Rows.Count > 0 Then
            RecordsCustomerList.Rows.Clear()
        End If

        Try
            RecordsCustomer.Fill(RecordsCustomerList)
            gvTasksCurrent.DataSource = RecordsCustomerList
            gvTasksCurrent.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Private Sub FillCompleteTasksTable()
        Dim RecordsCustomer As New SqlDataAdapter("SELECT * FROM REPAIR_TASK WHERE completionStatus = 'Complete'", con)
        Dim RecordsCustomerList As New DataTable

        If RecordsCustomerList.Rows.Count > 0 Then
            RecordsCustomerList.Rows.Clear()
        End If

        Try
            RecordsCustomer.Fill(RecordsCustomerList)
            gvTasksOld.DataSource = RecordsCustomerList
            gvTasksOld.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Private Sub FillWorkOrdersTable()
        Dim RecordsCustomer As New SqlDataAdapter("SELECT * FROM WORK_ORDERS", con)
        Dim RecordsCustomerList As New DataTable

        If RecordsCustomerList.Rows.Count > 0 Then
            RecordsCustomerList.Rows.Clear()
        End If

        Try
            RecordsCustomer.Fill(RecordsCustomerList)
            gvWorkOrders.DataSource = RecordsCustomerList
            gvWorkOrders.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Private Sub FillCurrentWorkOrdersTable()
        Dim RecordsCustomer As New SqlDataAdapter("SELECT * FROM WORK_ORDERS WHERE completionStatus ='Incomplete'", con)
        Dim RecordsCustomerList As New DataTable

        If RecordsCustomerList.Rows.Count > 0 Then
            RecordsCustomerList.Rows.Clear()
        End If

        Try
            RecordsCustomer.Fill(RecordsCustomerList)
            gvWorkOrdersCurrent.DataSource = RecordsCustomerList
            gvWorkOrdersCurrent.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Private Sub FillCompleteWorkOrdersTable()
        Dim RecordsCustomer As New SqlDataAdapter("SELECT * FROM WORK_ORDERS WHERE completionStatus ='Complete'", con)
        Dim RecordsCustomerList As New DataTable

        If RecordsCustomerList.Rows.Count > 0 Then
            RecordsCustomerList.Rows.Clear()
        End If

        Try
            RecordsCustomer.Fill(RecordsCustomerList)
            gvWorkOrdersOld.DataSource = RecordsCustomerList
            gvWorkOrdersOld.DataBind()
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
#End Region

#Region "Add New Customer"

    Protected Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Dim cmdInsertNewCustomer As New SqlCommand("INSERT CUSTOMERS4 (customerID, customerName, phoneNumber, email, address) VALUES (@p1, @p2, @p3, @p4, @p5)", con)

        With cmdInsertNewCustomer.Parameters
            .Clear()
            .AddWithValue("@p1", tbCustomerID.Text)
            .AddWithValue("@p2", tbCustomerName.Text)
            .AddWithValue("@p3", tbPhoneNum.Text)
            .AddWithValue("@p4", tbCustomerEmail.Text)
            .AddWithValue("@p5", tbAddress.Text)
        End With

        Try
            If con.State = ConnectionState.Closed Then con.Open()
            cmdInsertNewCustomer.ExecuteNonQuery()
            FillCustomerTable()
            tbCustomerID.Text = Nothing
            tbCustomerName.Text = Nothing
            tbPhoneNum.Text = Nothing
            tbCustomerEmail.Text = Nothing
            tbAddress.Text = Nothing
            Response.Write("New Customer Added")
        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
#End Region
#Region "Add New Work Order"
    Protected Sub btnAddWorkOrder_Click(sender As Object, e As EventArgs) Handles btnAddWorkOrder.Click
        Dim cmdInsertNewCustomer As New SqlCommand("INSERT WORK_ORDERS (orderID, customerID, taskID, description, orderRecieved, orderCompleted, completionStatus, repairCost) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", con)

        With cmdInsertNewCustomer.Parameters
            .Clear()
            .AddWithValue("@p1", tbWorkOrderID.Text)
            .AddWithValue("@p2", tbWorkOrderCustomerID.Text)
            .AddWithValue("@p3", tbWorkOrderTaskID.Text)
            .AddWithValue("@p4", tbWorkOrderDescription.Text)
            .AddWithValue("@p5", tbWorkOrderRecieved.Text)
            .AddWithValue("@p6", tbWorkOrderCompleted.Text)
            .AddWithValue("@p7", tbWorkOrderCompletionStatus.Text)
            .AddWithValue("@p8", tbWorkOrderCost.Text)
        End With

        Try
            If con.State = ConnectionState.Closed Then con.Open()
            cmdInsertNewCustomer.ExecuteNonQuery()
            FillWorkOrdersTable()
            FillCompleteWorkOrdersTable()
            FillCurrentWorkOrdersTable()
            Response.Write("New Work Order Added")

        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
#End Region

#Region "Add New Task"
    Protected Sub btnAddTask_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click
        Dim cmdInsertNewCustomer As New SqlCommand("INSERT REPAIR_TASK (taskID, description, completionStatus, employeeID) VALUES (@p1, @p2, @p3, @p4)", con)

        With cmdInsertNewCustomer.Parameters
            .Clear()
            .AddWithValue("@p1", tbTaskID.Text)
            .AddWithValue("@p2", tbTaskDescription.Text)
            .AddWithValue("@p3", tbTaskCompletionStatus.Text)
            .AddWithValue("@p4", tbTaskEmployeeID.Text)

        End With

        Try
            If con.State = ConnectionState.Closed Then con.Open()
            cmdInsertNewCustomer.ExecuteNonQuery()
            FillTasksTable()
            FillCompleteTasksTable()
            FillCurrentTasksTable()
            Response.Write("New Task Added")

        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
#End Region
#Region "Add New Employee"
    Protected Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim cmdInsertNewCustomer As New SqlCommand("INSERT EMPLOYEES4 (employeeID, employeeName) VALUES (@p1, @p2)", con)

        With cmdInsertNewCustomer.Parameters
            .Clear()
            .AddWithValue("@p1", tblEmployeeID.Text)
            .AddWithValue("@p2", tblEmployeeName.Text)
        End With

        Try
            If con.State = ConnectionState.Closed Then con.Open()
            cmdInsertNewCustomer.ExecuteNonQuery()
            FillEmployeeTable()
            tblEmployeeID.Text = Nothing
            tblEmployeeName.Text = Nothing
            Response.Write("New Employee Added")

        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
#End Region

#Region "Add New Inventory"
    Protected Sub btnAddInventory_Click(sender As Object, e As EventArgs) Handles btnAddInventory.Click
        Dim cmdInsertNewCustomer As New SqlCommand("INSERT INVENTORY4 (inventoryID, equipmentID, productName, quantity) VALUES (@p1, @p2, @p3, @p4)", con)

        With cmdInsertNewCustomer.Parameters
            .Clear()
            .AddWithValue("@p1", tbInventoryID.Text)
            .AddWithValue("@p2", tbEquipmentID_INV.Text)
            .AddWithValue("@p3", tbProductName.Text)
            .AddWithValue("@p4", tbQuantity.Text)
        End With

        Try
            If con.State = ConnectionState.Closed Then con.Open()
            cmdInsertNewCustomer.ExecuteNonQuery()
            FillInventoryTable()
            Response.Write("New Item Added")
        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
#End Region
#Region "Update Tasks"
    Private Sub FillDDLTaskList()
        Dim SelectProduct As New SqlDataAdapter("SELECT taskID, description FROM REPAIR_TASK", con)
        Dim dtProduct As New DataTable

        Try
            SelectProduct.Fill(dtProduct)

            With ddlTasks

                .DataSource = dtProduct
                .DataValueField = "taskID"
                .DataTextField = "description"
                .DataBind()
                .Items.Insert(0, "Select a task")
            End With
        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Protected Sub ddlTasksFill_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlTasks.SelectedIndexChanged

        Dim daGetOneCustomer As New SqlDataAdapter("Select * FROM REPAIR_TASK Where taskID = @p1", con)
        Dim dtOneCustomer As New DataTable

        With daGetOneCustomer.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@p1", ddlTasks.SelectedValue)
        End With

        Try
            daGetOneCustomer.Fill(dtOneCustomer)

            With dtOneCustomer.Rows(0)
                tbTaskID.Text = .Item("taskID")
                tbTaskDescription.Text = .Item("description")
                tbTaskCompletionStatus.Text = .Item("completionStatus")
                tbTaskEmployeeID.Text = .Item("employeeID")
            End With

            FillTasksTable()
            FillCompleteTasksTable()
            FillCurrentTasksTable()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try

    End Sub
    Protected Sub btnUpdateTasks_Click(sender As Object, e As EventArgs) Handles btnUpdateTask.Click
        Dim UpdateCommand As New SqlCommand("Update REPAIR_TASK SET  description = @p1, completionStatus = @p2, employeeID = @p3 WHERE taskID = @p4", con)

        With UpdateCommand.Parameters
            .Clear()
            .AddWithValue("@p1", tbTaskDescription.Text)
            .AddWithValue("@p2", tbTaskCompletionStatus.Text)
            .AddWithValue("@p3", tbTaskEmployeeID.Text)
            .AddWithValue("@p4", ddlTasks.SelectedValue)

        End With

        Try
            If con.State = ConnectionState.Closed Then con.Open()
            'here is where the insert command above in red is run
            UpdateCommand.ExecuteNonQuery()

            FillTasksTable()
            FillCurrentTasksTable()
            FillCompleteTasksTable()
            Response.Write("Record Updated")

        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
#End Region
#Region "Update Inventory"
    'Fill Drop Down with Inventory Items
    Private Sub FillDDLInventoryList()
        Dim SelectProduct As New SqlDataAdapter("SELECT inventoryID, productName FROM INVENTORY4", con)
        Dim dtProduct As New DataTable

        Try
            SelectProduct.Fill(dtProduct)

            With ddlInventory

                .DataSource = dtProduct
                .DataValueField = "inventoryID"
                .DataTextField = "productName"
                .DataBind()
                .Items.Insert(0, "Select a product")
            End With
        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    'Fill boxes with item details
    Protected Sub ddlInventoryFill_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlInventory.SelectedIndexChanged

        Dim daGetOneCustomer As New SqlDataAdapter("Select * FROM INVENTORY4 Where inventoryID = @p1", con)
        Dim dtOneCustomer As New DataTable

        With daGetOneCustomer.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@p1", ddlInventory.SelectedValue)
        End With

        Try
            daGetOneCustomer.Fill(dtOneCustomer)

            With dtOneCustomer.Rows(0)
                tbInventoryID.Text = .Item("inventoryID")
                tbEquipmentID_INV.Text = .Item("equipmentID")
                tbProductName.Text = .Item("productName")
                tbQuantity.Text = .Item("quantity")
            End With

            FillInventoryTable()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try

    End Sub
    'Update the inventory in SQL Server
    Protected Sub btnUpdateInventory_Click(sender As Object, e As EventArgs) Handles btnUpdateInventory.Click
        Dim UpdateCommand As New SqlCommand("Update INVENTORY4 SET productName = @p1, quantity = @p2 WHERE inventoryID = @p3", con)

        With UpdateCommand.Parameters
            .Clear()
            .AddWithValue("@p1", tbProductName.Text)
            .AddWithValue("@p2", tbQuantity.Text)
            .AddWithValue("@p3", ddlInventory.SelectedValue)

        End With

        Try
            If con.State = ConnectionState.Closed Then con.Open()
            'here is where the insert command above in red is run
            UpdateCommand.ExecuteNonQuery()

            FillInventoryTable()
            Response.Write("Record Updated")

        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'Clear 
    Protected Sub btnClearInventory_Click(sender As Object, e As EventArgs) Handles btnClearInventory.Click
        tbInventoryID.Text = Nothing
        tbEquipmentID_INV.Text = Nothing
        tbProductName.Text = Nothing
        tbQuantity.Text = Nothing
    End Sub



#End Region

#Region "Update Work Orders"
    'Fill Drop Down with work orders
    Private Sub FillDDLWorkOrders()
        Dim SelectProduct As New SqlDataAdapter("SELECT orderID, description FROM WORK_ORDERS", con)
        Dim dtProduct As New DataTable

        Try
            SelectProduct.Fill(dtProduct)

            With ddlWorkOrders

                .DataSource = dtProduct
                .DataValueField = "orderID"
                .DataTextField = "description"
                .DataBind()
                .Items.Insert(0, "Select an order")
            End With
        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    'Fill boxes with order details
    Protected Sub ddlWorkOrdersFill_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlWorkOrders.SelectedIndexChanged

        Dim daGetOneCustomer As New SqlDataAdapter("Select * FROM WORK_ORDERS Where orderID = @p1", con)
        Dim dtOneCustomer As New DataTable

        With daGetOneCustomer.SelectCommand.Parameters
            .Clear()
            .AddWithValue("@p1", ddlWorkOrders.SelectedValue)
        End With

        Try
            daGetOneCustomer.Fill(dtOneCustomer)

            With dtOneCustomer.Rows(0)
                tbWorkOrderID.Text = .Item("orderID")
                tbWorkOrderCustomerID.Text = .Item("customerID")
                tbWorkOrderTaskID.Text = .Item("taskID")
                tbWorkOrderDescription.Text = .Item("description")
                tbWorkOrderCompletionStatus.Text = .Item("completionStatus")
                tbWorkOrderCost.Text = .Item("repairCost")

            End With

            FillWorkOrdersTable()
            FillCurrentWorkOrdersTable()
            FillCompleteWorkOrdersTable()

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try

    End Sub
    'Update the inventory in SQL Server
    Protected Sub btnUpdateWorkOrder_Click(sender As Object, e As EventArgs) Handles btnUpdateWorkOrder.Click
        Dim UpdateCommand As New SqlCommand("Update WORK_ORDERS SET customerID = @p1, taskID = @p2, description = @p3, orderRecieved = @p4, orderCompleted = @p5, completionStatus = @p6, repairCost = @p7 WHERE orderID = @p8", con)

        With UpdateCommand.Parameters
            .Clear()
            .AddWithValue("@p1", tbWorkOrderCustomerID.Text)
            .AddWithValue("@p2", tbWorkOrderTaskID.Text)
            .AddWithValue("@p3", tbWorkOrderDescription.Text)
            .AddWithValue("@p4", tbWorkOrderRecieved.Text)
            .AddWithValue("@p5", tbWorkOrderCompleted.Text)
            .AddWithValue("@p6", tbWorkOrderCompletionStatus.Text)
            .AddWithValue("@p7", tbWorkOrderCost.Text)
            .AddWithValue("@p8", ddlWorkOrders.SelectedValue)

        End With

        Try
            If con.State = ConnectionState.Closed Then con.Open()
            'here is where the insert command above in red is run
            UpdateCommand.ExecuteNonQuery()

            FillInventoryTable()
            Response.Write("Record Updated")

        Catch ex As Exception
            Response.Write(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

#End Region
#Region "Page Links"
    Protected Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        MultiView1.ActiveViewIndex = 0
    End Sub

    Protected Sub btnWorkOrders_Click(sender As Object, e As EventArgs) Handles btnWorkOrders.Click
        MultiView1.ActiveViewIndex = 0
    End Sub
    Protected Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        MultiView1.ActiveViewIndex = 1
    End Sub

    Protected Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        MultiView1.ActiveViewIndex = 2
    End Sub

    Protected Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        MultiView1.ActiveViewIndex = 3
    End Sub

#End Region

#Region "Filters"
    Protected Sub rbTaskFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rbTaskFilter.SelectedIndexChanged
        Select Case rbTaskFilter.SelectedIndex
            Case 0
                gvTasks.Visible = True
                gvTasksCurrent.Visible = False
                gvTasksOld.Visible = False

            Case 1
                gvTasks.Visible = False
                gvTasksCurrent.Visible = True
                gvTasksOld.Visible = False
            Case 2
                gvTasks.Visible = False
                gvTasksCurrent.Visible = False
                gvTasksOld.Visible = True

        End Select

    End Sub

    Protected Sub rbWorkOrderFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rbWorkOrderFilter.SelectedIndexChanged
        Select Case rbWorkOrderFilter.SelectedIndex
            Case 0
                gvWorkOrders.Visible = True
                gvWorkOrdersCurrent.Visible = False
                gvWorkOrdersOld.Visible = False

            Case 1
                gvWorkOrders.Visible = False
                gvWorkOrdersCurrent.Visible = True
                gvWorkOrdersOld.Visible = False
            Case 2
                gvWorkOrders.Visible = False
                gvWorkOrdersCurrent.Visible = False
                gvWorkOrdersOld.Visible = True

        End Select
    End Sub


#End Region


End Class