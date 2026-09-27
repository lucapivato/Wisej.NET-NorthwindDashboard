///////////////////////////////////////////////////////////////////////////////
//
// (C) 2026 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
//
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//

///////////////////////////////////////////////////////////////////////////////

namespace Wisej.NorthwindDashboard
{
	partial class MainPage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Wisej.Web.Segment segment1 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment2 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment3 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment4 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment5 = new Wisej.Web.Segment();
			this.sidebar = new Wisej.Web.Panel();
			this.sourceCaption = new Wisej.Web.Label();
			this.sourceLabel = new Wisej.Web.Label();
			this.teamButton = new Wisej.Web.Button();
			this.customersButton = new Wisej.Web.Button();
			this.productsButton = new Wisej.Web.Button();
			this.fulfillmentButton = new Wisej.Web.Button();
			this.ordersButton = new Wisej.Web.Button();
			this.salesButton = new Wisej.Web.Button();
			this.overviewButton = new Wisej.Web.Button();
			this.navigationLabel = new Wisej.Web.Label();
			this.brandCaption = new Wisej.Web.Label();
			this.brandLabel = new Wisej.Web.Label();
			this.logo = new Wisej.Web.PictureBox();
			this.topBar = new Wisej.Web.Panel();
			this.userAvatar = new Wisej.Web.Avatar();
			this.searchButton = new Wisej.Web.Button();
			this.periodSelector = new Wisej.Web.SegmentedButton();
			this.subtitleLabel = new Wisej.Web.Label();
			this.titleLabel = new Wisej.Web.Label();
			this.contentPanel = new Wisej.Web.Panel();
			this.commandPalette = new Wisej.Web.CommandPalette(this.components);
			this.sidebar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			this.topBar.SuspendLayout();
			this.SuspendLayout();
			//
			// sidebar
			//
			this.sidebar.AppearanceKey = "nw-sidebar";
			this.sidebar.Controls.Add(this.sourceCaption);
			this.sidebar.Controls.Add(this.sourceLabel);
			this.sidebar.Controls.Add(this.teamButton);
			this.sidebar.Controls.Add(this.customersButton);
			this.sidebar.Controls.Add(this.productsButton);
			this.sidebar.Controls.Add(this.fulfillmentButton);
			this.sidebar.Controls.Add(this.ordersButton);
			this.sidebar.Controls.Add(this.salesButton);
			this.sidebar.Controls.Add(this.overviewButton);
			this.sidebar.Controls.Add(this.navigationLabel);
			this.sidebar.Controls.Add(this.brandCaption);
			this.sidebar.Controls.Add(this.brandLabel);
			this.sidebar.Controls.Add(this.logo);
			this.sidebar.Dock = Wisej.Web.DockStyle.Left;
			this.sidebar.Location = new System.Drawing.Point(0, 0);
			this.sidebar.Name = "sidebar";
			this.sidebar.Size = new System.Drawing.Size(232, 900);
			this.sidebar.TabIndex = 0;
			//
			// sourceCaption
			//
			this.sourceCaption.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.sourceCaption.AppearanceKey = "nw-caption";
			this.sourceCaption.Location = new System.Drawing.Point(24, 836);
			this.sourceCaption.Name = "sourceCaption";
			this.sourceCaption.Size = new System.Drawing.Size(188, 40);
			this.sourceCaption.TabIndex = 12;
			this.sourceCaption.Text = "Microsoft sample database";
			//
			// sourceLabel
			//
			this.sourceLabel.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.sourceLabel.AppearanceKey = "nw-overline";
			this.sourceLabel.Location = new System.Drawing.Point(24, 814);
			this.sourceLabel.Name = "sourceLabel";
			this.sourceLabel.Size = new System.Drawing.Size(188, 20);
			this.sourceLabel.TabIndex = 11;
			this.sourceLabel.Text = "NORTHWIND DATA";
			//
			// teamButton
			//
			this.teamButton.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.teamButton.AppearanceKey = "nw-nav";
			this.teamButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.teamButton.ImageSource = "Assets/Icons/team.svg";
			this.teamButton.Location = new System.Drawing.Point(12, 376);
			this.teamButton.Name = "teamButton";
			this.teamButton.Size = new System.Drawing.Size(208, 40);
			this.teamButton.TabIndex = 10;
			this.teamButton.Text = "Team";
			this.teamButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.teamButton.TextImageRelation = Wisej.Web.TextImageRelation.ImageBeforeText;
			this.teamButton.Click += new System.EventHandler(this.navButton_Click);
			//
			// customersButton
			//
			this.customersButton.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.customersButton.AppearanceKey = "nw-nav";
			this.customersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.customersButton.ImageSource = "Assets/Icons/customers.svg";
			this.customersButton.Location = new System.Drawing.Point(12, 332);
			this.customersButton.Name = "customersButton";
			this.customersButton.Size = new System.Drawing.Size(208, 40);
			this.customersButton.TabIndex = 9;
			this.customersButton.Text = "Customers";
			this.customersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.customersButton.TextImageRelation = Wisej.Web.TextImageRelation.ImageBeforeText;
			this.customersButton.Click += new System.EventHandler(this.navButton_Click);
			//
			// productsButton
			//
			this.productsButton.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.productsButton.AppearanceKey = "nw-nav";
			this.productsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.productsButton.ImageSource = "Assets/Icons/products.svg";
			this.productsButton.Location = new System.Drawing.Point(12, 288);
			this.productsButton.Name = "productsButton";
			this.productsButton.Size = new System.Drawing.Size(208, 40);
			this.productsButton.TabIndex = 8;
			this.productsButton.Text = "Products";
			this.productsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.productsButton.TextImageRelation = Wisej.Web.TextImageRelation.ImageBeforeText;
			this.productsButton.Click += new System.EventHandler(this.navButton_Click);
			//
			// fulfillmentButton
			//
			this.fulfillmentButton.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.fulfillmentButton.AppearanceKey = "nw-nav";
			this.fulfillmentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.fulfillmentButton.ImageSource = "Assets/Icons/fulfillment.svg";
			this.fulfillmentButton.Location = new System.Drawing.Point(12, 244);
			this.fulfillmentButton.Name = "fulfillmentButton";
			this.fulfillmentButton.Size = new System.Drawing.Size(208, 40);
			this.fulfillmentButton.TabIndex = 7;
			this.fulfillmentButton.Text = "Fulfillment";
			this.fulfillmentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.fulfillmentButton.TextImageRelation = Wisej.Web.TextImageRelation.ImageBeforeText;
			this.fulfillmentButton.Click += new System.EventHandler(this.navButton_Click);
			//
			// ordersButton
			//
			this.ordersButton.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.ordersButton.AppearanceKey = "nw-nav";
			this.ordersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ordersButton.ImageSource = "Assets/Icons/orders.svg";
			this.ordersButton.Location = new System.Drawing.Point(12, 200);
			this.ordersButton.Name = "ordersButton";
			this.ordersButton.Size = new System.Drawing.Size(208, 40);
			this.ordersButton.TabIndex = 6;
			this.ordersButton.Text = "Orders";
			this.ordersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ordersButton.TextImageRelation = Wisej.Web.TextImageRelation.ImageBeforeText;
			this.ordersButton.Click += new System.EventHandler(this.navButton_Click);
			//
			// salesButton
			//
			this.salesButton.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.salesButton.AppearanceKey = "nw-nav";
			this.salesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.salesButton.ImageSource = "Assets/Icons/sales.svg";
			this.salesButton.Location = new System.Drawing.Point(12, 156);
			this.salesButton.Name = "salesButton";
			this.salesButton.Size = new System.Drawing.Size(208, 40);
			this.salesButton.TabIndex = 5;
			this.salesButton.Text = "Sales";
			this.salesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.salesButton.TextImageRelation = Wisej.Web.TextImageRelation.ImageBeforeText;
			this.salesButton.Click += new System.EventHandler(this.navButton_Click);
			//
			// overviewButton
			//
			this.overviewButton.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.overviewButton.AppearanceKey = "nw-nav-active";
			this.overviewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.overviewButton.ImageSource = "Assets/Icons/overview.svg";
			this.overviewButton.Location = new System.Drawing.Point(12, 112);
			this.overviewButton.Name = "overviewButton";
			this.overviewButton.Size = new System.Drawing.Size(208, 40);
			this.overviewButton.TabIndex = 4;
			this.overviewButton.Text = "Overview";
			this.overviewButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.overviewButton.TextImageRelation = Wisej.Web.TextImageRelation.ImageBeforeText;
			this.overviewButton.Click += new System.EventHandler(this.navButton_Click);
			//
			// navigationLabel
			//
			this.navigationLabel.AppearanceKey = "nw-overline";
			this.navigationLabel.Location = new System.Drawing.Point(24, 84);
			this.navigationLabel.Name = "navigationLabel";
			this.navigationLabel.Size = new System.Drawing.Size(188, 20);
			this.navigationLabel.TabIndex = 3;
			this.navigationLabel.Text = "DASHBOARD";
			//
			// brandCaption
			//
			this.brandCaption.AppearanceKey = "nw-caption";
			this.brandCaption.Location = new System.Drawing.Point(62, 37);
			this.brandCaption.Name = "brandCaption";
			this.brandCaption.Size = new System.Drawing.Size(150, 18);
			this.brandCaption.TabIndex = 2;
			this.brandCaption.Text = "Traders · Sales dashboard";
			//
			// brandLabel
			//
			this.brandLabel.AppearanceKey = "nw-brand";
			this.brandLabel.Location = new System.Drawing.Point(62, 15);
			this.brandLabel.Name = "brandLabel";
			this.brandLabel.Size = new System.Drawing.Size(150, 22);
			this.brandLabel.TabIndex = 1;
			this.brandLabel.Text = "Northwind";
			//
			// logo
			//
			this.logo.ImageSource = "Assets/logo.svg";
			this.logo.Location = new System.Drawing.Point(20, 18);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(34, 34);
			this.logo.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			//
			// topBar
			//
			this.topBar.AppearanceKey = "nw-topbar";
			this.topBar.Controls.Add(this.userAvatar);
			this.topBar.Controls.Add(this.searchButton);
			this.topBar.Controls.Add(this.periodSelector);
			this.topBar.Controls.Add(this.subtitleLabel);
			this.topBar.Controls.Add(this.titleLabel);
			this.topBar.Dock = Wisej.Web.DockStyle.Top;
			this.topBar.Location = new System.Drawing.Point(232, 0);
			this.topBar.Name = "topBar";
			this.topBar.Size = new System.Drawing.Size(1208, 72);
			this.topBar.TabIndex = 1;
			//
			// userAvatar
			//
			this.userAvatar.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.userAvatar.AvatarSize = 36;
			this.userAvatar.Label = "Andrew Fuller";
			this.userAvatar.Location = new System.Drawing.Point(1002, 14);
			this.userAvatar.Name = "userAvatar";
			this.userAvatar.Presence = Wisej.Web.AvatarPresence.Online;
			this.userAvatar.Size = new System.Drawing.Size(182, 44);
			this.userAvatar.SubLabel = "VP, Sales";
			this.userAvatar.TabIndex = 4;
			this.userAvatar.Text = "Andrew Fuller";
			this.userAvatar.Click += new System.EventHandler(this.userAvatar_Click);
			//
			// searchButton
			//
			this.searchButton.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.searchButton.AppearanceKey = "nw-search";
			this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.searchButton.ImageSource = "Assets/Icons/search.svg";
			this.searchButton.Location = new System.Drawing.Point(774, 18);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(212, 36);
			this.searchButton.TabIndex = 3;
			this.searchButton.Text = "Search…            Ctrl+K";
			this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.searchButton.TextImageRelation = Wisej.Web.TextImageRelation.ImageBeforeText;
			this.searchButton.ToolTipText = "Search customers, products, orders and pages";
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			//
			// periodSelector
			//
			this.periodSelector.AccessibleName = "Reporting period";
			this.periodSelector.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			segment1.Text = "30D";
			segment1.ToolTipText = "Last 30 days";
			segment1.Value = "Last30Days";
			segment2.Text = "90D";
			segment2.ToolTipText = "Last 90 days";
			segment2.Value = "Last90Days";
			segment3.Text = "YTD";
			segment3.ToolTipText = "Year to date";
			segment3.Value = "YearToDate";
			segment4.Text = "12M";
			segment4.ToolTipText = "Last 12 months";
			segment4.Value = "Last12Months";
			segment5.Text = "All";
			segment5.ToolTipText = "Complete order history";
			segment5.Value = "AllTime";
			this.periodSelector.Items.Add(segment1);
			this.periodSelector.Items.Add(segment2);
			this.periodSelector.Items.Add(segment3);
			this.periodSelector.Items.Add(segment4);
			this.periodSelector.Items.Add(segment5);
			this.periodSelector.Location = new System.Drawing.Point(502, 16);
			this.periodSelector.Name = "periodSelector";
			this.periodSelector.SegmentSize = Wisej.Web.SegmentSize.Small;
			this.periodSelector.Size = new System.Drawing.Size(256, 40);
			this.periodSelector.TabIndex = 2;
			this.periodSelector.SelectionChanged += new System.EventHandler(this.periodSelector_SelectionChanged);
			//
			// subtitleLabel
			//
			this.subtitleLabel.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.subtitleLabel.AppearanceKey = "nw-subtitle";
			this.subtitleLabel.AutoEllipsis = true;
			this.subtitleLabel.Location = new System.Drawing.Point(28, 42);
			this.subtitleLabel.Name = "subtitleLabel";
			this.subtitleLabel.Size = new System.Drawing.Size(460, 18);
			this.subtitleLabel.TabIndex = 1;
			this.subtitleLabel.Text = "Year to date · Jan 1 – May 6, 1998";
			//
			// titleLabel
			//
			this.titleLabel.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.titleLabel.AppearanceKey = "nw-page-title";
			this.titleLabel.AutoEllipsis = true;
			this.titleLabel.Location = new System.Drawing.Point(28, 12);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(460, 30);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "Overview";
			//
			// contentPanel
			//
			this.contentPanel.AppearanceKey = "nw-content";
			this.contentPanel.Dock = Wisej.Web.DockStyle.Fill;
			this.contentPanel.Location = new System.Drawing.Point(232, 72);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new System.Drawing.Size(1208, 828);
			this.contentPanel.TabIndex = 2;
			//
			// commandPalette
			//
			this.commandPalette.FilterMode = Wisej.Web.CommandFilterMode.Server;
			this.commandPalette.PlaceholderText = "Search customers, products, orders or pages…";
			this.commandPalette.Width = 640;
			this.commandPalette.QueryChanged += new System.EventHandler<Wisej.Web.CommandQueryEventArgs>(this.commandPalette_QueryChanged);
			this.commandPalette.CommandExecuted += new System.EventHandler<Wisej.Web.CommandEventArgs>(this.commandPalette_CommandExecuted);
			//
			// MainPage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.topBar);
			this.Controls.Add(this.sidebar);
			this.Name = "MainPage";
			this.Size = new System.Drawing.Size(1440, 900);
			this.Text = "Northwind Traders";
			this.sidebar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
			this.topBar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel sidebar;
		private Wisej.Web.PictureBox logo;
		private Wisej.Web.Label brandLabel;
		private Wisej.Web.Label brandCaption;
		private Wisej.Web.Label navigationLabel;
		private Wisej.Web.Button overviewButton;
		private Wisej.Web.Button salesButton;
		private Wisej.Web.Button ordersButton;
		private Wisej.Web.Button fulfillmentButton;
		private Wisej.Web.Button productsButton;
		private Wisej.Web.Button customersButton;
		private Wisej.Web.Button teamButton;
		private Wisej.Web.Label sourceLabel;
		private Wisej.Web.Label sourceCaption;
		private Wisej.Web.Panel topBar;
		private Wisej.Web.Label titleLabel;
		private Wisej.Web.Label subtitleLabel;
		private Wisej.Web.SegmentedButton periodSelector;
		private Wisej.Web.Button searchButton;
		private Wisej.Web.Avatar userAvatar;
		private Wisej.Web.Panel contentPanel;
		private Wisej.Web.CommandPalette commandPalette;
	}
}
