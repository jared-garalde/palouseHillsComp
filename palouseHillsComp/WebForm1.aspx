<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="palouseHillsComp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Palouse Hills Computing</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>



<body onload="setState()">
    <form id="form1" runat="server">

        
        <asp:MultiView ID="MultiView1" runat="server">
           <%-- Dashboard/Home--%>
            <asp:View ID="homepageView" runat="server">
   
                <div class="jumbotron jumbotron-fluid">
                  <div class="container">
                    <h1 class="display-4">Hello, Admin</h1>
                    <p class="lead">Here is your daily summary.</p>
                  </div>
                </div>        
                
<%--                accordions--%>
                <div class="accordion" id="accordionExample">
                  <div class="card">
                    <div class="card-header" id="headingOne">
                      <h5 class="mb-0">
                        <button id="panel1State" class="btn btn-link btn-block collapsed" type="button" data-toggle="collapse" data-target="#Panel1" aria-expanded="true" aria-controls="Panel1" onclick="setCookie('Panel1')">
                          Work Orders
                        </button>
                      </h5>
                    </div>
                  
                    <div id="Panel1" class="collapse" aria-labelledby="headingOne" data-parent="#accordionExample">
                      <div class="card-body">
                          <div class="container">
                              <h3>Tasks</h3>
                              <div class="row">

                                  <div class="col-9">
                                     <asp:GridView ID="gvTasks" runat="server" class="table table-hover table-dark table-sm">
                                     </asp:GridView>
                                     <asp:GridView ID="gvTasksCurrent" runat="server" class="table table-hover table-dark table-sm">
                                     </asp:GridView>
                                     <asp:GridView ID="gvTasksOld" runat="server" class="table table-hover table-dark table-sm">
                                     </asp:GridView>
                                  </div>
                                  <div class="col-3">
                                      <div class="card">
                                          <h5 class="card-header">Filter</h5>
                                          <div class="card-body">
                                              <asp:RadioButtonList ID="rbTaskFilter" runat="server" AutoPostBack="True">
                                                  <asp:ListItem Selected="True" Value="0">All Tasks</asp:ListItem>
                                                  <asp:ListItem Value="1">Current Tasks</asp:ListItem>
                                                  <asp:ListItem Value="2">Completed Tasks</asp:ListItem>
                                              </asp:RadioButtonList>
                                          </div>
                                      </div>
                                  </div>
                              </div>
                              <h3>Work Orders</h3>
                              <div class="row">
                                  <div class="col-9">
                                     <asp:GridView ID="gvWorkOrders" runat="server" class="table table-hover table-dark table-sm">
                                     </asp:GridView>
                                     <asp:GridView ID="gvWorkOrdersCurrent" runat="server" class="table table-hover table-dark table-sm">
                                     </asp:GridView>
                                     <asp:GridView ID="gvWorkOrdersOld" runat="server" class="table table-hover table-dark table-sm">
                                     </asp:GridView>
                                  </div>
                                  <div class="col-3">
                                      <div class="card">
                                          <h5 class="card-header">Filter</h5>
                                          <div class="card-body">
                                              <asp:RadioButtonList ID="rbWorkOrderFilter" runat="server" AutoPostBack="True">
                                                  <asp:ListItem Selected="True" Value="0">All Tasks</asp:ListItem>
                                                  <asp:ListItem Value="1">Current Tasks</asp:ListItem>
                                                  <asp:ListItem Value="2">Completed Tasks</asp:ListItem>
                                              </asp:RadioButtonList>
                                          </div>
                                      </div>
                                  </div>
                              </div>
                              <div class="row">
                                  <div class="col">
                                        <div class="card">
                                           <h5 class="card-header">Add a Work Order</h5>
                                            <div class="card-body">
                                                
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                          <label for="tbWorkOrderID">Order ID</label>
                                                          <asp:TextBox ID="tbWorkOrderID" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                      </div>
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                          <label for="tbWorkOrderCustomerID">Customer ID</label>
                                                          <asp:TextBox ID="tbWorkOrderCustomerID" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                      </div>
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                          <label for="tbWorkOrderTaskID">Task ID</label>
                                                          <asp:TextBox ID="tbWorkOrderTaskID" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                      </div> 
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                          <label for="tbWorkOrderDescription">Order Description</label>
                                                          <asp:TextBox ID="tbWorkOrderDescription" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                      </div> 
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                          <label for="tbWorkOrderRecieved">Order Recieved</label>
                                                          <asp:TextBox ID="tbWorkOrderRecieved" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                      </div> 
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                          <label for="tbWorkOrderCompleted">Order Completed</label>
                                                          <asp:TextBox ID="tbWorkOrderCompleted" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                      </div>
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                          <label for="tbWorkOrderCompletionStatus">Completion Status</label>
                                                          <asp:TextBox ID="tbWorkOrderCompletionStatus" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                      </div>  
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                          <label for="tbWorkOrderCost">Order Cost</label>
                                                          <asp:TextBox ID="tbWorkOrderCost" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                      </div>                                                 
                                                
                                                <asp:Button ID="btnAddWorkOrder" runat="server" Text="Add Work Order" class="btn btn-primary"/>
                                                <asp:Button ID="btnUpdateWorkOrder" runat="server" Text="Update Task" class="btn btn-primary"/>
                                                <br />
                                                <br />
                                               <h5>Update</h5>
                                               <div class="form-row">
                                                   <div class="form-group">
                                                       <asp:DropDownList ID="ddlWorkOrders" runat="server" AutoPostBack="True"></asp:DropDownList>
                                                   </div>

                                               </div>
                                            </div>
                                        </div>
                                  </div>
                                  <div class="col">
                                        <div class="card">
                                           <h5 class="card-header">Manage Tasks</h5>
                                            <div class="card-body">
                                                    <h5>Add</h5>
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                          <label for="tbTaskID">Task ID</label>
                                                          <asp:TextBox ID="tbTaskID" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                      </div>
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                          <label for="tbTaskDescription">Description</label>
                                                          <asp:TextBox ID="tbTaskDescription" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                      </div>
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                          <label for="tbTaskCompletionStatus">Completion Status</label>
                                                          <asp:TextBox ID="tbTaskCompletionStatus" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                      </div> 
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                          <label for="tbTaskEmployeeID">Employee ID</label>
                                                          <asp:TextBox ID="tbTaskEmployeeID" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                      </div>
                                                                                            
                                               <asp:Button ID="btnAddTask" runat="server" Text="Add Task" class="btn btn-primary"/>
                                                <asp:Button ID="btnUpdateTask" runat="server" Text="Update Task" class="btn btn-primary"/>
                                                <br />
                                                <br />
                                               <h5>Update</h5>
                                               <div class="form-row">
                                                   <div class="form-group">
                                                       <asp:DropDownList ID="ddlTasks" runat="server" AutoPostBack="True"></asp:DropDownList>
                                                   </div>

                                               </div>
                                            </div>
                                        </div>
                                  </div>


                              </div>
                          </div>
                      </div>
                    </div>
                  </div>
                  <div class="card">
                    <div class="card-header" id="headingTwo">
                      <h5 class="mb-0">
                        <button id="panel2State" class="btn btn-link btn-block collapsed" type="button" data-toggle="collapse" data-target="#Panel2" aria-expanded="false" aria-controls="Panel2" onclick="setCookie('Panel2')" >
                          Customers
                        </button>
                      </h5>
                    </div>
                    <div id="Panel2" class="collapse" aria-labelledby="headingTwo" data-parent="#accordionExample">
                      <div class="card-body">
                            <div class="container">
                                <h3>Customers</h3>
                                <div class="row">
                                    <div class="col-9">
                                       <asp:GridView ID="gvCustomers" runat="server" class="table table-hover table-dark table-sm">
                                       </asp:GridView>
                                    </div>
                                    <div class ="col-3">
                                        <div class="card">
                                           <h5 class="card-header">Add a Customer</h5>
                                            <div class="card-body">
                                                <form>
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                          <label for="tbCustomerID">Customer ID</label>
                                                          <asp:TextBox ID="tbCustomerID" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                      </div>
                                                      <div class="form-row">
                                                          <div class="form-group">
                                                              <label for="tbCustomerName">Customer Name</label>
                                                              <asp:TextBox ID="tbCustomerName" runat="server" class="form-control"></asp:TextBox>
                                                          </div>
                                                      </div>
                                                      <div class="form-row">
                                                          <div class="form-group">
                                                              <label for="tbPhoneNum">Phone Number</label>
                                                             <asp:TextBox ID="tbPhoneNum" runat="server" class="form-control"></asp:TextBox>
                                                          </div>
                                                      </div>  
                                                      <div class="form-row">
                                                          <div class="form-group">
                                                              <label for="tbCustomerEmail">Customer Email</label>
                                                              <asp:TextBox ID="tbCustomerEmail" runat="server" class="form-control"></asp:TextBox>
                                                          </div>
                                                      </div>
                                                      <div class="form-row">
                                                          <div class="form-group">
                                                              <label for="tbAddress">Customer Address</label>
                                                              <asp:TextBox ID="tbAddress" runat="server" class="form-control"></asp:TextBox>
                                                          </div>
                                                      </div>                                            
                                                      
                                                      
                                                </form>
                                                <asp:Button ID="btnAddCustomer" runat="server" Text="Add Customer" class="btn btn-primary"/>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                      </div>
                    </div>
                  </div>
                  <div class="card">
                    <div class="card-header" id="headingThree">
                      <h5 class="mb-0">
                        <button id="panel3State" class="btn btn-link btn-block collapsed" type="button" data-toggle="collapse" data-target="#Panel3" aria-expanded="false" aria-controls="Panel3" onclick="setCookie('Panel3')">
                          Employees
                        </button>
                      </h5>
                    </div>
                    <div id="Panel3" class="collapse" aria-labelledby="headingThree" data-parent="#accordionExample">
                      <div class="card-body">
                            <div class="container">
                                <h3>Customers</h3>
                                <div class="row">
                                    <div class="col-9">
                                      <asp:GridView ID="gvEmployee" runat="server" class="table table-hover table-dark table-sm">
                                      </asp:GridView>
                                    </div>
                                    <div class ="col-3">
                                        <div class="card">
                                           
                                            <div class="card-body">
                                                
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                            <label for="tbEmployeeID">Employee ID</label>
                                                            <asp:TextBox ID="tblEmployeeID" runat="server" class="form-control"></asp:TextBox>

                                                        </div>
                                                      </div>
                                                      <div class="form-row">
                                                          <div class="form-group">
                                                              <label for="tbEmployeeName">Employee Name</label>
                                                              <asp:TextBox ID="tblEmployeeName" runat="server" class="form-control"></asp:TextBox>
                                                          </div>
                                                      </div>
                                                
                                               <asp:Button ID="btnAddEmployee" runat="server" Text="Add Employee" class="btn btn-primary"/>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                          </div>
     
                    </div>
                  </div>
                  <div class="card">
                    <div class="card-header" id="headingFour">
                      <h5 class="mb-0">
                        <button id="panel4State" class="btn btn-link btn-block collapsed" type="button" data-toggle="collapse" data-target="#Panel4" aria-expanded="false" aria-controls="Panel4" onclick="setCookie('Panel4')">
                          Inventory
                        </button>
                      </h5>
                    </div>
                    <div id="Panel4" class="collapse" aria-labelledby="headingThree" data-parent="#accordionExample">
                      <div class="card-body">
                          <div class="container">
                              
                              <div class="row">
                                  <div class="col-9">
                                    <h3>Inventory</h3>
                                    <asp:GridView ID="gvInventory" runat="server" class="table table-hover table-dark table-sm">
                                    </asp:GridView>
                                    <h3>Equipment</h3>
                                    <asp:GridView ID="gvEquipment" runat="server" class="table table-hover table-dark table-sm">
                                    </asp:GridView>
                                  </div>
                                  <div class="col-3">
                                      <div class="card">
                                          <h5 class="card-header">Manage Inventory</h5>
                                          <div class="card-body">
                                                
                                                    <h5>Add</h5>
                                                      <div class="form-row">
                                                        <div class="form-group">
                                                          <label for="tbInventoryID">Inventory ID</label>
                                                          <asp:TextBox ID="tbInventoryID" runat="server" class="form-control"></asp:TextBox>
                                                        </div>
                                                      </div>
                                                      <div class="form-row">
                                                          <div class="form-group">
                                                              <label for="tbEquipmentID_INV">Equipment ID</label>
                                                              <asp:TextBox ID="tbEquipmentID_INV" runat="server" class="form-control"></asp:TextBox>
                                                          </div>
                                                      </div>
                                                      <div class="form-row">
                                                          <div class="form-group">
                                                              <label for="tbProductName">Product Name</label>
                                                              <asp:TextBox ID="tbProductName" runat="server" class="form-control"></asp:TextBox>
                                                          </div>
                                                      </div>  
                                                      <div class="form-row">
                                                          <div class="form-group">
                                                              <label for="tbQuantity">Quantity</label>
                                                              <asp:TextBox ID="tbQuantity" runat="server" class="form-control"></asp:TextBox>
                                                          </div>
                                                      </div>        

                                                        <asp:Button ID="btnAddInventory" runat="server" Text="Add Item" class="btn btn-primary"/>

                                                    <br />
                                                                                                       <br />
                                                        <br />
                                                    <div class="form-row">

                                                        <h5>Update</h5>
                                                    </div>

                                                      
                                                     
                                                        <div class="form-row">
                                                            
                                                           <div class="form-group">
                                                              <label for="ddlInventory">Choose Item to Update</label>
                                                              <asp:DropDownList ID="ddlInventory" runat="server" AutoPostBack="True"></asp:DropDownList>
                                                            </div>
                                                            
                                                        </div>
                                                        <div class="form-row">
                                                            <div class="form-group">
                                                                <asp:Button ID="btnUpdateInventory" runat="server" Text="Update Item" class="btn btn-primary"/>
                                                                <asp:Button ID="btnClearInventory" runat="server" Text="Clear" class="btn btn-primary"/>
                                                            </div>
                                                        </div>
                                                              
 
                                                  
                                                
                                              </div>

                                          </div>

                                      </div>
                                  </div>
                              </div>

                          </div>



                            
                            
                            
                            
                            

                      </div>
                    </div>

                  </div>
               






            </asp:View>
            <asp:View ID="customerView" runat="server">

            </asp:View>
            <asp:View ID="employeeView" runat="server">

            </asp:View>
            <asp:View ID="InventoryView" runat="server">

            </asp:View>
        </asp:MultiView>

    </form>
<script src="panelState.js"></script>
<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>
