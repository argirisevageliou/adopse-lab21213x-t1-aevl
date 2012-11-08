<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employees))
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim TitleOfCourtesyLabel As System.Windows.Forms.Label
        Dim BirthDateLabel As System.Windows.Forms.Label
        Dim HireDateLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim RegionLabel As System.Windows.Forms.Label
        Dim PostalCodeLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim HomePhoneLabel As System.Windows.Forms.Label
        Dim ExtensionLabel As System.Windows.Forms.Label
        Dim PhotoLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim ReportsToLabel As System.Windows.Forms.Label
        Me.NorthwindDataSet = New DataForms.NorthwindDataSet
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesTableAdapter = New DataForms.NorthwindDataSetTableAdapters.EmployeesTableAdapter
        Me.TableAdapterManager = New DataForms.NorthwindDataSetTableAdapters.TableAdapterManager
        Me.EmployeesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EmployeesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.EmployeeIDLabel1 = New System.Windows.Forms.Label
        Me.LastNameTextBox = New System.Windows.Forms.TextBox
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox
        Me.TitleTextBox = New System.Windows.Forms.TextBox
        Me.TitleOfCourtesyTextBox = New System.Windows.Forms.TextBox
        Me.BirthDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.HireDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.CityTextBox = New System.Windows.Forms.TextBox
        Me.RegionTextBox = New System.Windows.Forms.TextBox
        Me.PostalCodeTextBox = New System.Windows.Forms.TextBox
        Me.CountryTextBox = New System.Windows.Forms.TextBox
        Me.HomePhoneTextBox = New System.Windows.Forms.TextBox
        Me.ExtensionTextBox = New System.Windows.Forms.TextBox
        Me.PhotoTextBox = New System.Windows.Forms.TextBox
        Me.NotesTextBox = New System.Windows.Forms.TextBox
        Me.ReportsToTextBox = New System.Windows.Forms.TextBox
        EmployeeIDLabel = New System.Windows.Forms.Label
        LastNameLabel = New System.Windows.Forms.Label
        FirstNameLabel = New System.Windows.Forms.Label
        TitleLabel = New System.Windows.Forms.Label
        TitleOfCourtesyLabel = New System.Windows.Forms.Label
        BirthDateLabel = New System.Windows.Forms.Label
        HireDateLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        CityLabel = New System.Windows.Forms.Label
        RegionLabel = New System.Windows.Forms.Label
        PostalCodeLabel = New System.Windows.Forms.Label
        CountryLabel = New System.Windows.Forms.Label
        HomePhoneLabel = New System.Windows.Forms.Label
        ExtensionLabel = New System.Windows.Forms.Label
        PhotoLabel = New System.Windows.Forms.Label
        NotesLabel = New System.Windows.Forms.Label
        ReportsToLabel = New System.Windows.Forms.Label
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NorthwindDataSet
        '
        Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.NorthwindDataSet
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Me.EmployeesTableAdapter
        Me.TableAdapterManager.Order_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.ShippersTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DataForms.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeesBindingNavigator
        '
        Me.EmployeesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeesBindingNavigator.BindingSource = Me.EmployeesBindingSource
        Me.EmployeesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployeesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeesBindingNavigatorSaveItem})
        Me.EmployeesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmployeesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmployeesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmployeesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmployeesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmployeesBindingNavigator.Name = "EmployeesBindingNavigator"
        Me.EmployeesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmployeesBindingNavigator.Size = New System.Drawing.Size(349, 25)
        Me.EmployeesBindingNavigator.TabIndex = 0
        Me.EmployeesBindingNavigator.Text = "BindingNavigator1"
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
        'EmployeesBindingNavigatorSaveItem
        '
        Me.EmployeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeesBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeesBindingNavigatorSaveItem.Name = "EmployeesBindingNavigatorSaveItem"
        Me.EmployeesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EmployeesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Location = New System.Drawing.Point(12, 37)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(70, 13)
        EmployeeIDLabel.TabIndex = 1
        EmployeeIDLabel.Text = "Employee ID:"
        '
        'EmployeeIDLabel1
        '
        Me.EmployeeIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "EmployeeID", True))
        Me.EmployeeIDLabel1.Location = New System.Drawing.Point(106, 37)
        Me.EmployeeIDLabel1.Name = "EmployeeIDLabel1"
        Me.EmployeeIDLabel1.Size = New System.Drawing.Size(200, 23)
        Me.EmployeeIDLabel1.TabIndex = 2
        Me.EmployeeIDLabel1.Text = "Label1"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(12, 66)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 3
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(106, 63)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastNameTextBox.TabIndex = 4
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(12, 92)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 5
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(106, 89)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstNameTextBox.TabIndex = 6
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(12, 118)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 7
        TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(106, 115)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TitleTextBox.TabIndex = 8
        '
        'TitleOfCourtesyLabel
        '
        TitleOfCourtesyLabel.AutoSize = True
        TitleOfCourtesyLabel.Location = New System.Drawing.Point(12, 144)
        TitleOfCourtesyLabel.Name = "TitleOfCourtesyLabel"
        TitleOfCourtesyLabel.Size = New System.Drawing.Size(88, 13)
        TitleOfCourtesyLabel.TabIndex = 9
        TitleOfCourtesyLabel.Text = "Title Of Courtesy:"
        '
        'TitleOfCourtesyTextBox
        '
        Me.TitleOfCourtesyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "TitleOfCourtesy", True))
        Me.TitleOfCourtesyTextBox.Location = New System.Drawing.Point(106, 141)
        Me.TitleOfCourtesyTextBox.Name = "TitleOfCourtesyTextBox"
        Me.TitleOfCourtesyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TitleOfCourtesyTextBox.TabIndex = 10
        '
        'BirthDateLabel
        '
        BirthDateLabel.AutoSize = True
        BirthDateLabel.Location = New System.Drawing.Point(12, 171)
        BirthDateLabel.Name = "BirthDateLabel"
        BirthDateLabel.Size = New System.Drawing.Size(57, 13)
        BirthDateLabel.TabIndex = 11
        BirthDateLabel.Text = "Birth Date:"
        '
        'BirthDateDateTimePicker
        '
        Me.BirthDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeesBindingSource, "BirthDate", True))
        Me.BirthDateDateTimePicker.Location = New System.Drawing.Point(106, 167)
        Me.BirthDateDateTimePicker.Name = "BirthDateDateTimePicker"
        Me.BirthDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.BirthDateDateTimePicker.TabIndex = 12
        '
        'HireDateLabel
        '
        HireDateLabel.AutoSize = True
        HireDateLabel.Location = New System.Drawing.Point(12, 197)
        HireDateLabel.Name = "HireDateLabel"
        HireDateLabel.Size = New System.Drawing.Size(55, 13)
        HireDateLabel.TabIndex = 13
        HireDateLabel.Text = "Hire Date:"
        '
        'HireDateDateTimePicker
        '
        Me.HireDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeesBindingSource, "HireDate", True))
        Me.HireDateDateTimePicker.Location = New System.Drawing.Point(106, 193)
        Me.HireDateDateTimePicker.Name = "HireDateDateTimePicker"
        Me.HireDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.HireDateDateTimePicker.TabIndex = 14
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(12, 222)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 15
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(106, 219)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddressTextBox.TabIndex = 16
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(12, 248)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 17
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(106, 245)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CityTextBox.TabIndex = 18
        '
        'RegionLabel
        '
        RegionLabel.AutoSize = True
        RegionLabel.Location = New System.Drawing.Point(12, 274)
        RegionLabel.Name = "RegionLabel"
        RegionLabel.Size = New System.Drawing.Size(44, 13)
        RegionLabel.TabIndex = 19
        RegionLabel.Text = "Region:"
        '
        'RegionTextBox
        '
        Me.RegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Region", True))
        Me.RegionTextBox.Location = New System.Drawing.Point(106, 271)
        Me.RegionTextBox.Name = "RegionTextBox"
        Me.RegionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RegionTextBox.TabIndex = 20
        '
        'PostalCodeLabel
        '
        PostalCodeLabel.AutoSize = True
        PostalCodeLabel.Location = New System.Drawing.Point(12, 300)
        PostalCodeLabel.Name = "PostalCodeLabel"
        PostalCodeLabel.Size = New System.Drawing.Size(67, 13)
        PostalCodeLabel.TabIndex = 21
        PostalCodeLabel.Text = "Postal Code:"
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "PostalCode", True))
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(106, 297)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PostalCodeTextBox.TabIndex = 22
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(12, 326)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 23
        CountryLabel.Text = "Country:"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(106, 323)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CountryTextBox.TabIndex = 24
        '
        'HomePhoneLabel
        '
        HomePhoneLabel.AutoSize = True
        HomePhoneLabel.Location = New System.Drawing.Point(12, 352)
        HomePhoneLabel.Name = "HomePhoneLabel"
        HomePhoneLabel.Size = New System.Drawing.Size(72, 13)
        HomePhoneLabel.TabIndex = 25
        HomePhoneLabel.Text = "Home Phone:"
        '
        'HomePhoneTextBox
        '
        Me.HomePhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "HomePhone", True))
        Me.HomePhoneTextBox.Location = New System.Drawing.Point(106, 349)
        Me.HomePhoneTextBox.Name = "HomePhoneTextBox"
        Me.HomePhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.HomePhoneTextBox.TabIndex = 26
        '
        'ExtensionLabel
        '
        ExtensionLabel.AutoSize = True
        ExtensionLabel.Location = New System.Drawing.Point(12, 378)
        ExtensionLabel.Name = "ExtensionLabel"
        ExtensionLabel.Size = New System.Drawing.Size(56, 13)
        ExtensionLabel.TabIndex = 27
        ExtensionLabel.Text = "Extension:"
        '
        'ExtensionTextBox
        '
        Me.ExtensionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Extension", True))
        Me.ExtensionTextBox.Location = New System.Drawing.Point(106, 375)
        Me.ExtensionTextBox.Name = "ExtensionTextBox"
        Me.ExtensionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ExtensionTextBox.TabIndex = 28
        '
        'PhotoLabel
        '
        PhotoLabel.AutoSize = True
        PhotoLabel.Location = New System.Drawing.Point(12, 404)
        PhotoLabel.Name = "PhotoLabel"
        PhotoLabel.Size = New System.Drawing.Size(38, 13)
        PhotoLabel.TabIndex = 29
        PhotoLabel.Text = "Photo:"
        '
        'PhotoTextBox
        '
        Me.PhotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Photo", True))
        Me.PhotoTextBox.Location = New System.Drawing.Point(106, 401)
        Me.PhotoTextBox.Name = "PhotoTextBox"
        Me.PhotoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhotoTextBox.TabIndex = 30
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(12, 430)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(38, 13)
        NotesLabel.TabIndex = 31
        NotesLabel.Text = "Notes:"
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(106, 427)
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NotesTextBox.TabIndex = 32
        '
        'ReportsToLabel
        '
        ReportsToLabel.AutoSize = True
        ReportsToLabel.Location = New System.Drawing.Point(12, 456)
        ReportsToLabel.Name = "ReportsToLabel"
        ReportsToLabel.Size = New System.Drawing.Size(63, 13)
        ReportsToLabel.TabIndex = 33
        ReportsToLabel.Text = "Reports To:"
        '
        'ReportsToTextBox
        '
        Me.ReportsToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "ReportsTo", True))
        Me.ReportsToTextBox.Location = New System.Drawing.Point(106, 453)
        Me.ReportsToTextBox.Name = "ReportsToTextBox"
        Me.ReportsToTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ReportsToTextBox.TabIndex = 34
        '
        'Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 504)
        Me.Controls.Add(EmployeeIDLabel)
        Me.Controls.Add(Me.EmployeeIDLabel1)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(TitleOfCourtesyLabel)
        Me.Controls.Add(Me.TitleOfCourtesyTextBox)
        Me.Controls.Add(BirthDateLabel)
        Me.Controls.Add(Me.BirthDateDateTimePicker)
        Me.Controls.Add(HireDateLabel)
        Me.Controls.Add(Me.HireDateDateTimePicker)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(RegionLabel)
        Me.Controls.Add(Me.RegionTextBox)
        Me.Controls.Add(PostalCodeLabel)
        Me.Controls.Add(Me.PostalCodeTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(HomePhoneLabel)
        Me.Controls.Add(Me.HomePhoneTextBox)
        Me.Controls.Add(ExtensionLabel)
        Me.Controls.Add(Me.ExtensionTextBox)
        Me.Controls.Add(PhotoLabel)
        Me.Controls.Add(Me.PhotoTextBox)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(ReportsToLabel)
        Me.Controls.Add(Me.ReportsToTextBox)
        Me.Controls.Add(Me.EmployeesBindingNavigator)
        Me.Name = "Employees"
        Me.Text = "Employees"
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeesBindingNavigator.ResumeLayout(False)
        Me.EmployeesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NorthwindDataSet As DataForms.NorthwindDataSet
    Friend WithEvents EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeesTableAdapter As DataForms.NorthwindDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents TableAdapterManager As DataForms.NorthwindDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents EmployeesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EmployeeIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleOfCourtesyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BirthDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents HireDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostalCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HomePhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExtensionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhotoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReportsToTextBox As System.Windows.Forms.TextBox
End Class
