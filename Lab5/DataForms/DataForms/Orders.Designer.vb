<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orders))
        Dim OrderIDLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim OrderDateLabel As System.Windows.Forms.Label
        Dim RequiredDateLabel As System.Windows.Forms.Label
        Dim ShippedDateLabel As System.Windows.Forms.Label
        Dim ShipViaLabel As System.Windows.Forms.Label
        Dim FreightLabel As System.Windows.Forms.Label
        Dim ShipNameLabel As System.Windows.Forms.Label
        Dim ShipAddressLabel As System.Windows.Forms.Label
        Dim ShipCityLabel As System.Windows.Forms.Label
        Dim ShipRegionLabel As System.Windows.Forms.Label
        Dim ShipPostalCodeLabel As System.Windows.Forms.Label
        Dim ShipCountryLabel As System.Windows.Forms.Label
        Me.NorthwindDataSet = New DataForms.NorthwindDataSet
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New DataForms.NorthwindDataSetTableAdapters.OrdersTableAdapter
        Me.TableAdapterManager = New DataForms.NorthwindDataSetTableAdapters.TableAdapterManager
        Me.OrdersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.OrdersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.OrderIDLabel1 = New System.Windows.Forms.Label
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox
        Me.OrderDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.RequiredDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ShippedDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ShipViaTextBox = New System.Windows.Forms.TextBox
        Me.FreightTextBox = New System.Windows.Forms.TextBox
        Me.ShipNameTextBox = New System.Windows.Forms.TextBox
        Me.ShipAddressTextBox = New System.Windows.Forms.TextBox
        Me.ShipCityTextBox = New System.Windows.Forms.TextBox
        Me.ShipRegionTextBox = New System.Windows.Forms.TextBox
        Me.ShipPostalCodeTextBox = New System.Windows.Forms.TextBox
        Me.ShipCountryTextBox = New System.Windows.Forms.TextBox
        OrderIDLabel = New System.Windows.Forms.Label
        CustomerIDLabel = New System.Windows.Forms.Label
        EmployeeIDLabel = New System.Windows.Forms.Label
        OrderDateLabel = New System.Windows.Forms.Label
        RequiredDateLabel = New System.Windows.Forms.Label
        ShippedDateLabel = New System.Windows.Forms.Label
        ShipViaLabel = New System.Windows.Forms.Label
        FreightLabel = New System.Windows.Forms.Label
        ShipNameLabel = New System.Windows.Forms.Label
        ShipAddressLabel = New System.Windows.Forms.Label
        ShipCityLabel = New System.Windows.Forms.Label
        ShipRegionLabel = New System.Windows.Forms.Label
        ShipPostalCodeLabel = New System.Windows.Forms.Label
        ShipCountryLabel = New System.Windows.Forms.Label
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrdersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NorthwindDataSet
        '
        Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.NorthwindDataSet
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Order_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Me.OrdersTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.ShippersTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DataForms.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OrdersBindingNavigator
        '
        Me.OrdersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OrdersBindingNavigator.BindingSource = Me.OrdersBindingSource
        Me.OrdersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OrdersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OrdersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OrdersBindingNavigatorSaveItem})
        Me.OrdersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OrdersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OrdersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OrdersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OrdersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OrdersBindingNavigator.Name = "OrdersBindingNavigator"
        Me.OrdersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OrdersBindingNavigator.Size = New System.Drawing.Size(356, 25)
        Me.OrdersBindingNavigator.TabIndex = 0
        Me.OrdersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'OrdersBindingNavigatorSaveItem
        '
        Me.OrdersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OrdersBindingNavigatorSaveItem.Image = CType(resources.GetObject("OrdersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OrdersBindingNavigatorSaveItem.Name = "OrdersBindingNavigatorSaveItem"
        Me.OrdersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.OrdersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OrderIDLabel
        '
        OrderIDLabel.AutoSize = True
        OrderIDLabel.Location = New System.Drawing.Point(12, 36)
        OrderIDLabel.Name = "OrderIDLabel"
        OrderIDLabel.Size = New System.Drawing.Size(50, 13)
        OrderIDLabel.TabIndex = 1
        OrderIDLabel.Text = "Order ID:"
        '
        'OrderIDLabel1
        '
        Me.OrderIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "OrderID", True))
        Me.OrderIDLabel1.Location = New System.Drawing.Point(109, 36)
        Me.OrderIDLabel1.Name = "OrderIDLabel1"
        Me.OrderIDLabel1.Size = New System.Drawing.Size(200, 23)
        Me.OrderIDLabel1.TabIndex = 2
        Me.OrderIDLabel1.Text = "Label1"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(12, 65)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(68, 13)
        CustomerIDLabel.TabIndex = 3
        CustomerIDLabel.Text = "Customer ID:"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(109, 62)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustomerIDTextBox.TabIndex = 4
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Location = New System.Drawing.Point(12, 91)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(70, 13)
        EmployeeIDLabel.TabIndex = 5
        EmployeeIDLabel.Text = "Employee ID:"
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "EmployeeID", True))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(109, 88)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmployeeIDTextBox.TabIndex = 6
        '
        'OrderDateLabel
        '
        OrderDateLabel.AutoSize = True
        OrderDateLabel.Location = New System.Drawing.Point(12, 118)
        OrderDateLabel.Name = "OrderDateLabel"
        OrderDateLabel.Size = New System.Drawing.Size(62, 13)
        OrderDateLabel.TabIndex = 7
        OrderDateLabel.Text = "Order Date:"
        '
        'OrderDateDateTimePicker
        '
        Me.OrderDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "OrderDate", True))
        Me.OrderDateDateTimePicker.Location = New System.Drawing.Point(109, 114)
        Me.OrderDateDateTimePicker.Name = "OrderDateDateTimePicker"
        Me.OrderDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.OrderDateDateTimePicker.TabIndex = 8
        '
        'RequiredDateLabel
        '
        RequiredDateLabel.AutoSize = True
        RequiredDateLabel.Location = New System.Drawing.Point(12, 144)
        RequiredDateLabel.Name = "RequiredDateLabel"
        RequiredDateLabel.Size = New System.Drawing.Size(79, 13)
        RequiredDateLabel.TabIndex = 9
        RequiredDateLabel.Text = "Required Date:"
        '
        'RequiredDateDateTimePicker
        '
        Me.RequiredDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "RequiredDate", True))
        Me.RequiredDateDateTimePicker.Location = New System.Drawing.Point(109, 140)
        Me.RequiredDateDateTimePicker.Name = "RequiredDateDateTimePicker"
        Me.RequiredDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.RequiredDateDateTimePicker.TabIndex = 10
        '
        'ShippedDateLabel
        '
        ShippedDateLabel.AutoSize = True
        ShippedDateLabel.Location = New System.Drawing.Point(12, 170)
        ShippedDateLabel.Name = "ShippedDateLabel"
        ShippedDateLabel.Size = New System.Drawing.Size(75, 13)
        ShippedDateLabel.TabIndex = 11
        ShippedDateLabel.Text = "Shipped Date:"
        '
        'ShippedDateDateTimePicker
        '
        Me.ShippedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "ShippedDate", True))
        Me.ShippedDateDateTimePicker.Location = New System.Drawing.Point(109, 166)
        Me.ShippedDateDateTimePicker.Name = "ShippedDateDateTimePicker"
        Me.ShippedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ShippedDateDateTimePicker.TabIndex = 12
        '
        'ShipViaLabel
        '
        ShipViaLabel.AutoSize = True
        ShipViaLabel.Location = New System.Drawing.Point(12, 195)
        ShipViaLabel.Name = "ShipViaLabel"
        ShipViaLabel.Size = New System.Drawing.Size(49, 13)
        ShipViaLabel.TabIndex = 13
        ShipViaLabel.Text = "Ship Via:"
        '
        'ShipViaTextBox
        '
        Me.ShipViaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipVia", True))
        Me.ShipViaTextBox.Location = New System.Drawing.Point(109, 192)
        Me.ShipViaTextBox.Name = "ShipViaTextBox"
        Me.ShipViaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShipViaTextBox.TabIndex = 14
        '
        'FreightLabel
        '
        FreightLabel.AutoSize = True
        FreightLabel.Location = New System.Drawing.Point(12, 221)
        FreightLabel.Name = "FreightLabel"
        FreightLabel.Size = New System.Drawing.Size(42, 13)
        FreightLabel.TabIndex = 15
        FreightLabel.Text = "Freight:"
        '
        'FreightTextBox
        '
        Me.FreightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Freight", True))
        Me.FreightTextBox.Location = New System.Drawing.Point(109, 218)
        Me.FreightTextBox.Name = "FreightTextBox"
        Me.FreightTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FreightTextBox.TabIndex = 16
        '
        'ShipNameLabel
        '
        ShipNameLabel.AutoSize = True
        ShipNameLabel.Location = New System.Drawing.Point(12, 247)
        ShipNameLabel.Name = "ShipNameLabel"
        ShipNameLabel.Size = New System.Drawing.Size(62, 13)
        ShipNameLabel.TabIndex = 17
        ShipNameLabel.Text = "Ship Name:"
        '
        'ShipNameTextBox
        '
        Me.ShipNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipName", True))
        Me.ShipNameTextBox.Location = New System.Drawing.Point(109, 244)
        Me.ShipNameTextBox.Name = "ShipNameTextBox"
        Me.ShipNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShipNameTextBox.TabIndex = 18
        '
        'ShipAddressLabel
        '
        ShipAddressLabel.AutoSize = True
        ShipAddressLabel.Location = New System.Drawing.Point(12, 273)
        ShipAddressLabel.Name = "ShipAddressLabel"
        ShipAddressLabel.Size = New System.Drawing.Size(72, 13)
        ShipAddressLabel.TabIndex = 19
        ShipAddressLabel.Text = "Ship Address:"
        '
        'ShipAddressTextBox
        '
        Me.ShipAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipAddress", True))
        Me.ShipAddressTextBox.Location = New System.Drawing.Point(109, 270)
        Me.ShipAddressTextBox.Name = "ShipAddressTextBox"
        Me.ShipAddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShipAddressTextBox.TabIndex = 20
        '
        'ShipCityLabel
        '
        ShipCityLabel.AutoSize = True
        ShipCityLabel.Location = New System.Drawing.Point(12, 299)
        ShipCityLabel.Name = "ShipCityLabel"
        ShipCityLabel.Size = New System.Drawing.Size(51, 13)
        ShipCityLabel.TabIndex = 21
        ShipCityLabel.Text = "Ship City:"
        '
        'ShipCityTextBox
        '
        Me.ShipCityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipCity", True))
        Me.ShipCityTextBox.Location = New System.Drawing.Point(109, 296)
        Me.ShipCityTextBox.Name = "ShipCityTextBox"
        Me.ShipCityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShipCityTextBox.TabIndex = 22
        '
        'ShipRegionLabel
        '
        ShipRegionLabel.AutoSize = True
        ShipRegionLabel.Location = New System.Drawing.Point(12, 325)
        ShipRegionLabel.Name = "ShipRegionLabel"
        ShipRegionLabel.Size = New System.Drawing.Size(68, 13)
        ShipRegionLabel.TabIndex = 23
        ShipRegionLabel.Text = "Ship Region:"
        '
        'ShipRegionTextBox
        '
        Me.ShipRegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipRegion", True))
        Me.ShipRegionTextBox.Location = New System.Drawing.Point(109, 322)
        Me.ShipRegionTextBox.Name = "ShipRegionTextBox"
        Me.ShipRegionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShipRegionTextBox.TabIndex = 24
        '
        'ShipPostalCodeLabel
        '
        ShipPostalCodeLabel.AutoSize = True
        ShipPostalCodeLabel.Location = New System.Drawing.Point(12, 351)
        ShipPostalCodeLabel.Name = "ShipPostalCodeLabel"
        ShipPostalCodeLabel.Size = New System.Drawing.Size(91, 13)
        ShipPostalCodeLabel.TabIndex = 25
        ShipPostalCodeLabel.Text = "Ship Postal Code:"
        '
        'ShipPostalCodeTextBox
        '
        Me.ShipPostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipPostalCode", True))
        Me.ShipPostalCodeTextBox.Location = New System.Drawing.Point(109, 348)
        Me.ShipPostalCodeTextBox.Name = "ShipPostalCodeTextBox"
        Me.ShipPostalCodeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShipPostalCodeTextBox.TabIndex = 26
        '
        'ShipCountryLabel
        '
        ShipCountryLabel.AutoSize = True
        ShipCountryLabel.Location = New System.Drawing.Point(12, 377)
        ShipCountryLabel.Name = "ShipCountryLabel"
        ShipCountryLabel.Size = New System.Drawing.Size(70, 13)
        ShipCountryLabel.TabIndex = 27
        ShipCountryLabel.Text = "Ship Country:"
        '
        'ShipCountryTextBox
        '
        Me.ShipCountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "ShipCountry", True))
        Me.ShipCountryTextBox.Location = New System.Drawing.Point(109, 374)
        Me.ShipCountryTextBox.Name = "ShipCountryTextBox"
        Me.ShipCountryTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ShipCountryTextBox.TabIndex = 28
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 421)
        Me.Controls.Add(OrderIDLabel)
        Me.Controls.Add(Me.OrderIDLabel1)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(EmployeeIDLabel)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.Controls.Add(OrderDateLabel)
        Me.Controls.Add(Me.OrderDateDateTimePicker)
        Me.Controls.Add(RequiredDateLabel)
        Me.Controls.Add(Me.RequiredDateDateTimePicker)
        Me.Controls.Add(ShippedDateLabel)
        Me.Controls.Add(Me.ShippedDateDateTimePicker)
        Me.Controls.Add(ShipViaLabel)
        Me.Controls.Add(Me.ShipViaTextBox)
        Me.Controls.Add(FreightLabel)
        Me.Controls.Add(Me.FreightTextBox)
        Me.Controls.Add(ShipNameLabel)
        Me.Controls.Add(Me.ShipNameTextBox)
        Me.Controls.Add(ShipAddressLabel)
        Me.Controls.Add(Me.ShipAddressTextBox)
        Me.Controls.Add(ShipCityLabel)
        Me.Controls.Add(Me.ShipCityTextBox)
        Me.Controls.Add(ShipRegionLabel)
        Me.Controls.Add(Me.ShipRegionTextBox)
        Me.Controls.Add(ShipPostalCodeLabel)
        Me.Controls.Add(Me.ShipPostalCodeTextBox)
        Me.Controls.Add(ShipCountryLabel)
        Me.Controls.Add(Me.ShipCountryTextBox)
        Me.Controls.Add(Me.OrdersBindingNavigator)
        Me.Name = "Orders"
        Me.Text = "Orders"
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrdersBindingNavigator.ResumeLayout(False)
        Me.OrdersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NorthwindDataSet As DataForms.NorthwindDataSet
    Friend WithEvents OrdersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdersTableAdapter As DataForms.NorthwindDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents TableAdapterManager As DataForms.NorthwindDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrdersBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OrdersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OrderIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents CustomerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrderDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RequiredDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShippedDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShipViaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FreightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipCityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipRegionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipPostalCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShipCountryTextBox As System.Windows.Forms.TextBox
End Class
