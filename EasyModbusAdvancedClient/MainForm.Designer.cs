/*
 * Created by SharpDevelop.
 * User: srossmann
 * Date: 25.11.2015
 * Time: 06:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EasyModbusAdvancedClient
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnStopAllJobs = new System.Windows.Forms.Button();
            this.btnStartAllJobs = new System.Windows.Forms.Button();
            this.btnEditFunctionCode = new System.Windows.Forms.Button();
            this.btnDelFunctionCode = new System.Windows.Forms.Button();
            this.btnAddFunctionCode = new System.Windows.Forms.Button();
            this.btnEditConnection = new System.Windows.Forms.Button();
            this.btnDelConnection = new System.Windows.Forms.Button();
            this.btnAddConnection = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addFunctionCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFunctionCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFunctionCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.startSingleJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopCurrentJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAllJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAllJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.updateValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAllValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvFunctionCode = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.workspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addConnectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteConnectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editConnectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.addFunctionCodeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFunctionCodeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editFunctionCodeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.startAllJobsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAllJobsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.updateAllValuessingleReadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionCode)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnStopAllJobs);
            this.splitContainer1.Panel1.Controls.Add(this.btnStartAllJobs);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditFunctionCode);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelFunctionCode);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddFunctionCode);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditConnection);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelConnection);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddConnection);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(1498, 685);
            this.splitContainer1.SplitterDistance = 477;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitContainer1SplitterMoved);
            // 
            // btnStopAllJobs
            // 
            this.btnStopAllJobs.Image = ((System.Drawing.Image)(resources.GetObject("btnStopAllJobs.Image")));
            this.btnStopAllJobs.Location = new System.Drawing.Point(299, 26);
            this.btnStopAllJobs.Name = "btnStopAllJobs";
            this.btnStopAllJobs.Size = new System.Drawing.Size(41, 32);
            this.btnStopAllJobs.TabIndex = 8;
            this.btnStopAllJobs.UseVisualStyleBackColor = true;
            this.btnStopAllJobs.Click += new System.EventHandler(this.btnStopAllJobs_Click);
            // 
            // btnStartAllJobs
            // 
            this.btnStartAllJobs.Image = ((System.Drawing.Image)(resources.GetObject("btnStartAllJobs.Image")));
            this.btnStartAllJobs.Location = new System.Drawing.Point(257, 26);
            this.btnStartAllJobs.Name = "btnStartAllJobs";
            this.btnStartAllJobs.Size = new System.Drawing.Size(41, 32);
            this.btnStartAllJobs.TabIndex = 7;
            this.btnStartAllJobs.UseVisualStyleBackColor = true;
            this.btnStartAllJobs.Click += new System.EventHandler(this.btnStartAllJobs_Click);
            // 
            // btnEditFunctionCode
            // 
            this.btnEditFunctionCode.Image = global::EasyModbusAdvancedClient.Properties.Resources.tab;
            this.btnEditFunctionCode.Location = new System.Drawing.Point(215, 26);
            this.btnEditFunctionCode.Name = "btnEditFunctionCode";
            this.btnEditFunctionCode.Size = new System.Drawing.Size(41, 32);
            this.btnEditFunctionCode.TabIndex = 5;
            this.btnEditFunctionCode.UseVisualStyleBackColor = true;
            this.btnEditFunctionCode.Click += new System.EventHandler(this.btnEditFunctionCode_Click);
            // 
            // btnDelFunctionCode
            // 
            this.btnDelFunctionCode.Image = global::EasyModbusAdvancedClient.Properties.Resources.tab_close;
            this.btnDelFunctionCode.Location = new System.Drawing.Point(173, 26);
            this.btnDelFunctionCode.Name = "btnDelFunctionCode";
            this.btnDelFunctionCode.Size = new System.Drawing.Size(41, 32);
            this.btnDelFunctionCode.TabIndex = 4;
            this.btnDelFunctionCode.UseVisualStyleBackColor = true;
            this.btnDelFunctionCode.Click += new System.EventHandler(this.btnDelFunctionCode_Click);
            // 
            // btnAddFunctionCode
            // 
            this.btnAddFunctionCode.Image = global::EasyModbusAdvancedClient.Properties.Resources.tab_new;
            this.btnAddFunctionCode.Location = new System.Drawing.Point(131, 26);
            this.btnAddFunctionCode.Name = "btnAddFunctionCode";
            this.btnAddFunctionCode.Size = new System.Drawing.Size(41, 32);
            this.btnAddFunctionCode.TabIndex = 2;
            this.btnAddFunctionCode.UseVisualStyleBackColor = true;
            this.btnAddFunctionCode.Click += new System.EventHandler(this.btnAddFunctionCode_Click);
            // 
            // btnEditConnection
            // 
            this.btnEditConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnEditConnection.Image")));
            this.btnEditConnection.Location = new System.Drawing.Point(89, 26);
            this.btnEditConnection.Name = "btnEditConnection";
            this.btnEditConnection.Size = new System.Drawing.Size(41, 32);
            this.btnEditConnection.TabIndex = 3;
            this.btnEditConnection.UseVisualStyleBackColor = true;
            this.btnEditConnection.Click += new System.EventHandler(this.btnEditConnection_Click);
            // 
            // btnDelConnection
            // 
            this.btnDelConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnDelConnection.Image")));
            this.btnDelConnection.Location = new System.Drawing.Point(47, 26);
            this.btnDelConnection.Name = "btnDelConnection";
            this.btnDelConnection.Size = new System.Drawing.Size(41, 32);
            this.btnDelConnection.TabIndex = 2;
            this.btnDelConnection.UseVisualStyleBackColor = true;
            this.btnDelConnection.Click += new System.EventHandler(this.btnDelConnection_Click);
            // 
            // btnAddConnection
            // 
            this.btnAddConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnAddConnection.Image")));
            this.btnAddConnection.Location = new System.Drawing.Point(5, 26);
            this.btnAddConnection.Name = "btnAddConnection";
            this.btnAddConnection.Size = new System.Drawing.Size(41, 32);
            this.btnAddConnection.TabIndex = 1;
            this.btnAddConnection.UseVisualStyleBackColor = true;
            this.btnAddConnection.Click += new System.EventHandler(this.btnAddConnection_Click);
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.ForeColor = System.Drawing.Color.Black;
            this.treeView1.ItemHeight = 16;
            this.treeView1.Location = new System.Drawing.Point(3, 64);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(469, 619);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConnectionToolStripMenuItem,
            this.deleteConnectionToolStripMenuItem,
            this.editConnectionToolStripMenuItem,
            this.toolStripSeparator1,
            this.addFunctionCodeToolStripMenuItem,
            this.deleteFunctionCodeToolStripMenuItem,
            this.editFunctionCodeToolStripMenuItem,
            this.toolStripSeparator2,
            this.startSingleJobToolStripMenuItem,
            this.stopCurrentJobToolStripMenuItem,
            this.startAllJobsToolStripMenuItem,
            this.stopAllJobsToolStripMenuItem,
            this.toolStripSeparator3,
            this.updateValuesToolStripMenuItem,
            this.updateAllValuesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(287, 286);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1Opening);
            // 
            // addConnectionToolStripMenuItem
            // 
            this.addConnectionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addConnectionToolStripMenuItem.Image")));
            this.addConnectionToolStripMenuItem.Name = "addConnectionToolStripMenuItem";
            this.addConnectionToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.addConnectionToolStripMenuItem.Text = "Add connection";
            this.addConnectionToolStripMenuItem.Click += new System.EventHandler(this.AddConnectionToolStripMenuItemClick);
            // 
            // deleteConnectionToolStripMenuItem
            // 
            this.deleteConnectionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteConnectionToolStripMenuItem.Image")));
            this.deleteConnectionToolStripMenuItem.Name = "deleteConnectionToolStripMenuItem";
            this.deleteConnectionToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.deleteConnectionToolStripMenuItem.Text = "Delete connection";
            this.deleteConnectionToolStripMenuItem.Click += new System.EventHandler(this.DeleteConnectionToolStripMenuItemClick);
            // 
            // editConnectionToolStripMenuItem
            // 
            this.editConnectionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editConnectionToolStripMenuItem.Image")));
            this.editConnectionToolStripMenuItem.Name = "editConnectionToolStripMenuItem";
            this.editConnectionToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.editConnectionToolStripMenuItem.Text = "Edit connection";
            this.editConnectionToolStripMenuItem.Click += new System.EventHandler(this.EditConnectionToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(283, 6);
            // 
            // addFunctionCodeToolStripMenuItem
            // 
            this.addFunctionCodeToolStripMenuItem.Image = global::EasyModbusAdvancedClient.Properties.Resources.tab_new;
            this.addFunctionCodeToolStripMenuItem.Name = "addFunctionCodeToolStripMenuItem";
            this.addFunctionCodeToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.addFunctionCodeToolStripMenuItem.Text = "Add function code";
            this.addFunctionCodeToolStripMenuItem.Click += new System.EventHandler(this.AddFunctionCodeToolStripMenuItemClick);
            // 
            // deleteFunctionCodeToolStripMenuItem
            // 
            this.deleteFunctionCodeToolStripMenuItem.Image = global::EasyModbusAdvancedClient.Properties.Resources.tab_close;
            this.deleteFunctionCodeToolStripMenuItem.Name = "deleteFunctionCodeToolStripMenuItem";
            this.deleteFunctionCodeToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.deleteFunctionCodeToolStripMenuItem.Text = "Delete function code";
            this.deleteFunctionCodeToolStripMenuItem.Click += new System.EventHandler(this.DeleteFunctionCodeToolStripMenuItemClick);
            // 
            // editFunctionCodeToolStripMenuItem
            // 
            this.editFunctionCodeToolStripMenuItem.Image = global::EasyModbusAdvancedClient.Properties.Resources.tab;
            this.editFunctionCodeToolStripMenuItem.Name = "editFunctionCodeToolStripMenuItem";
            this.editFunctionCodeToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.editFunctionCodeToolStripMenuItem.Text = "Edit function Code";
            this.editFunctionCodeToolStripMenuItem.Click += new System.EventHandler(this.EditFunctionCodeToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(283, 6);
            // 
            // startSingleJobToolStripMenuItem
            // 
            this.startSingleJobToolStripMenuItem.Name = "startSingleJobToolStripMenuItem";
            this.startSingleJobToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.startSingleJobToolStripMenuItem.Text = "Start current job (continuous read)";
            this.startSingleJobToolStripMenuItem.Click += new System.EventHandler(this.StartSingleJobToolStripMenuItemClick);
            // 
            // stopCurrentJobToolStripMenuItem
            // 
            this.stopCurrentJobToolStripMenuItem.Name = "stopCurrentJobToolStripMenuItem";
            this.stopCurrentJobToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.stopCurrentJobToolStripMenuItem.Text = "Stop current job";
            this.stopCurrentJobToolStripMenuItem.Click += new System.EventHandler(this.stopCurrentJobToolStripMenuItem_Click);
            // 
            // startAllJobsToolStripMenuItem
            // 
            this.startAllJobsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("startAllJobsToolStripMenuItem.Image")));
            this.startAllJobsToolStripMenuItem.Name = "startAllJobsToolStripMenuItem";
            this.startAllJobsToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.startAllJobsToolStripMenuItem.Text = "Start all jobs (continuous read)";
            this.startAllJobsToolStripMenuItem.Click += new System.EventHandler(this.StartAllJobsToolStripMenuItemClick);
            // 
            // stopAllJobsToolStripMenuItem
            // 
            this.stopAllJobsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stopAllJobsToolStripMenuItem.Image")));
            this.stopAllJobsToolStripMenuItem.Name = "stopAllJobsToolStripMenuItem";
            this.stopAllJobsToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.stopAllJobsToolStripMenuItem.Text = "Stop all jobs";
            this.stopAllJobsToolStripMenuItem.Click += new System.EventHandler(this.StopAllJobsToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(283, 6);
            // 
            // updateValuesToolStripMenuItem
            // 
            this.updateValuesToolStripMenuItem.Name = "updateValuesToolStripMenuItem";
            this.updateValuesToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.updateValuesToolStripMenuItem.Text = "Update values current job (single read) ";
            this.updateValuesToolStripMenuItem.Click += new System.EventHandler(this.UpdateValuesToolStripMenuItemClick);
            // 
            // updateAllValuesToolStripMenuItem
            // 
            this.updateAllValuesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateAllValuesToolStripMenuItem.Image")));
            this.updateAllValuesToolStripMenuItem.Name = "updateAllValuesToolStripMenuItem";
            this.updateAllValuesToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.updateAllValuesToolStripMenuItem.Text = "Update all values (single read)";
            this.updateAllValuesToolStripMenuItem.Click += new System.EventHandler(this.UpdateAllValuesToolStripMenuItemClick);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(3, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 54);
            this.button2.TabIndex = 2;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(84, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 648);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvFunctionCode);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(910, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FunctionCodes list";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvFunctionCode
            // 
            this.dgvFunctionCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunctionCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column4,
            this.Column3,
            this.Column2});
            this.dgvFunctionCode.Location = new System.Drawing.Point(20, 6);
            this.dgvFunctionCode.Name = "dgvFunctionCode";
            this.dgvFunctionCode.Size = new System.Drawing.Size(894, 611);
            this.dgvFunctionCode.TabIndex = 0;
            this.dgvFunctionCode.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Connection";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Address";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Datatype";
            this.Column4.Items.AddRange(new object[] {
            "BOOL",
            "INT16",
            "UINT16"});
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Value";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tag (optional)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(910, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Raw Data View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(896, 615);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(3, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 54);
            this.button1.TabIndex = 1;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workspaceToolStripMenuItem,
            this.connectionManagerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1498, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // workspaceToolStripMenuItem
            // 
            this.workspaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveWorkspaceToolStripMenuItem,
            this.changeWorkspaceToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.workspaceToolStripMenuItem.Name = "workspaceToolStripMenuItem";
            this.workspaceToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.workspaceToolStripMenuItem.Text = "Workspace";
            // 
            // saveWorkspaceToolStripMenuItem
            // 
            this.saveWorkspaceToolStripMenuItem.Name = "saveWorkspaceToolStripMenuItem";
            this.saveWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveWorkspaceToolStripMenuItem.Text = "Save Workspace";
            this.saveWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.saveWorkspaceToolStripMenuItem_Click);
            // 
            // changeWorkspaceToolStripMenuItem
            // 
            this.changeWorkspaceToolStripMenuItem.Name = "changeWorkspaceToolStripMenuItem";
            this.changeWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.changeWorkspaceToolStripMenuItem.Text = "Change Workspace";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // connectionManagerToolStripMenuItem
            // 
            this.connectionManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConnectionToolStripMenuItem1,
            this.deleteConnectionToolStripMenuItem1,
            this.editConnectionToolStripMenuItem1,
            this.toolStripSeparator4,
            this.addFunctionCodeToolStripMenuItem1,
            this.deleteFunctionCodeToolStripMenuItem1,
            this.editFunctionCodeToolStripMenuItem1,
            this.toolStripSeparator5,
            this.startAllJobsToolStripMenuItem1,
            this.stopAllJobsToolStripMenuItem1,
            this.toolStripSeparator6,
            this.updateAllValuessingleReadToolStripMenuItem});
            this.connectionManagerToolStripMenuItem.Name = "connectionManagerToolStripMenuItem";
            this.connectionManagerToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.connectionManagerToolStripMenuItem.Text = "Connection Manager";
            // 
            // addConnectionToolStripMenuItem1
            // 
            this.addConnectionToolStripMenuItem1.Image = global::EasyModbusAdvancedClient.Properties.Resources.network_connect;
            this.addConnectionToolStripMenuItem1.Name = "addConnectionToolStripMenuItem1";
            this.addConnectionToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.addConnectionToolStripMenuItem1.Text = "Add connection";
            this.addConnectionToolStripMenuItem1.Click += new System.EventHandler(this.AddConnectionToolStripMenuItemClick);
            // 
            // deleteConnectionToolStripMenuItem1
            // 
            this.deleteConnectionToolStripMenuItem1.Image = global::EasyModbusAdvancedClient.Properties.Resources.network_disconnect_2;
            this.deleteConnectionToolStripMenuItem1.Name = "deleteConnectionToolStripMenuItem1";
            this.deleteConnectionToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.deleteConnectionToolStripMenuItem1.Text = "Delete connection";
            this.deleteConnectionToolStripMenuItem1.Visible = false;
            this.deleteConnectionToolStripMenuItem1.Click += new System.EventHandler(this.DeleteConnectionToolStripMenuItemClick);
            // 
            // editConnectionToolStripMenuItem1
            // 
            this.editConnectionToolStripMenuItem1.Image = global::EasyModbusAdvancedClient.Properties.Resources.network_connect_2;
            this.editConnectionToolStripMenuItem1.Name = "editConnectionToolStripMenuItem1";
            this.editConnectionToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.editConnectionToolStripMenuItem1.Text = "Edit connection";
            this.editConnectionToolStripMenuItem1.Visible = false;
            this.editConnectionToolStripMenuItem1.Click += new System.EventHandler(this.EditConnectionToolStripMenuItemClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(237, 6);
            this.toolStripSeparator4.Visible = false;
            // 
            // addFunctionCodeToolStripMenuItem1
            // 
            this.addFunctionCodeToolStripMenuItem1.Image = global::EasyModbusAdvancedClient.Properties.Resources.tab_new;
            this.addFunctionCodeToolStripMenuItem1.Name = "addFunctionCodeToolStripMenuItem1";
            this.addFunctionCodeToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.addFunctionCodeToolStripMenuItem1.Text = "Add function code";
            this.addFunctionCodeToolStripMenuItem1.Visible = false;
            this.addFunctionCodeToolStripMenuItem1.Click += new System.EventHandler(this.AddFunctionCodeToolStripMenuItemClick);
            // 
            // deleteFunctionCodeToolStripMenuItem1
            // 
            this.deleteFunctionCodeToolStripMenuItem1.Image = global::EasyModbusAdvancedClient.Properties.Resources.tab_close;
            this.deleteFunctionCodeToolStripMenuItem1.Name = "deleteFunctionCodeToolStripMenuItem1";
            this.deleteFunctionCodeToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.deleteFunctionCodeToolStripMenuItem1.Text = "Delete function code";
            this.deleteFunctionCodeToolStripMenuItem1.Visible = false;
            this.deleteFunctionCodeToolStripMenuItem1.Click += new System.EventHandler(this.DeleteFunctionCodeToolStripMenuItemClick);
            // 
            // editFunctionCodeToolStripMenuItem1
            // 
            this.editFunctionCodeToolStripMenuItem1.Image = global::EasyModbusAdvancedClient.Properties.Resources.tab;
            this.editFunctionCodeToolStripMenuItem1.Name = "editFunctionCodeToolStripMenuItem1";
            this.editFunctionCodeToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.editFunctionCodeToolStripMenuItem1.Text = "Edit function code";
            this.editFunctionCodeToolStripMenuItem1.Visible = false;
            this.editFunctionCodeToolStripMenuItem1.Click += new System.EventHandler(this.EditFunctionCodeToolStripMenuItemClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(237, 6);
            this.toolStripSeparator5.Visible = false;
            // 
            // startAllJobsToolStripMenuItem1
            // 
            this.startAllJobsToolStripMenuItem1.Image = global::EasyModbusAdvancedClient.Properties.Resources.view_refresh_2;
            this.startAllJobsToolStripMenuItem1.Name = "startAllJobsToolStripMenuItem1";
            this.startAllJobsToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.startAllJobsToolStripMenuItem1.Text = "Start all jobs (continuous read)";
            this.startAllJobsToolStripMenuItem1.Visible = false;
            this.startAllJobsToolStripMenuItem1.Click += new System.EventHandler(this.StartAllJobsToolStripMenuItemClick);
            // 
            // stopAllJobsToolStripMenuItem1
            // 
            this.stopAllJobsToolStripMenuItem1.Image = global::EasyModbusAdvancedClient.Properties.Resources.process_stop_2;
            this.stopAllJobsToolStripMenuItem1.Name = "stopAllJobsToolStripMenuItem1";
            this.stopAllJobsToolStripMenuItem1.Size = new System.Drawing.Size(240, 22);
            this.stopAllJobsToolStripMenuItem1.Text = "Stop all jobs";
            this.stopAllJobsToolStripMenuItem1.Visible = false;
            this.stopAllJobsToolStripMenuItem1.Click += new System.EventHandler(this.StopAllJobsToolStripMenuItemClick);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(237, 6);
            this.toolStripSeparator6.Visible = false;
            // 
            // updateAllValuessingleReadToolStripMenuItem
            // 
            this.updateAllValuessingleReadToolStripMenuItem.Name = "updateAllValuessingleReadToolStripMenuItem";
            this.updateAllValuessingleReadToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.updateAllValuessingleReadToolStripMenuItem.Text = "Update all Values (single read)";
            this.updateAllValuessingleReadToolStripMenuItem.Visible = false;
            this.updateAllValuessingleReadToolStripMenuItem.Click += new System.EventHandler(this.UpdateAllValuesToolStripMenuItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 685);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "EasyModbus Advanced Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainFormSizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionCode)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		
				private System.Windows.Forms.ToolStripMenuItem deleteConnectionToolStripMenuItem;
			private System.Windows.Forms.ToolStripMenuItem editConnectionToolStripMenuItem;
			private System.Windows.Forms.ToolStripMenuItem deleteFunctionCodeToolStripMenuItem;
			private System.Windows.Forms.ToolStripMenuItem editFunctionCodeToolStripMenuItem;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dgvFunctionCode;
		private System.Windows.Forms.ToolStripMenuItem updateAllValuesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateValuesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startAllJobsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startSingleJobToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addFunctionCodeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addConnectionToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.Button btnAddConnection;
		private System.Windows.Forms.Button btnAddFunctionCode;
		private System.Windows.Forms.Button btnEditConnection;
		private System.Windows.Forms.Button btnDelConnection;
		private System.Windows.Forms.Button btnStartAllJobs;
		private System.Windows.Forms.Button btnStopAllJobs;
		private System.Windows.Forms.Button btnEditFunctionCode;
		private System.Windows.Forms.Button btnDelFunctionCode;
		private System.Windows.Forms.ToolStripMenuItem stopCurrentJobToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stopAllJobsToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem workspaceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveWorkspaceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeWorkspaceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectionManagerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addConnectionToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deleteConnectionToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editConnectionToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem addFunctionCodeToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deleteFunctionCodeToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editFunctionCodeToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem startAllJobsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem stopAllJobsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem updateAllValuessingleReadToolStripMenuItem;
	
	
		
		void ContextMenuStrip1Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
	

