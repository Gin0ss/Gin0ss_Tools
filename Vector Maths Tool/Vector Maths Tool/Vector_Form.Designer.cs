
namespace Vector_Maths_Tool
{
    partial class Vector_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vector_Form));
            this.ExitButton = new System.Windows.Forms.Button();
            this.HeaderText_1 = new System.Windows.Forms.Label();
            this.TimerButton = new System.Windows.Forms.Button();
            this.TimerWorker = new System.ComponentModel.BackgroundWorker();
            this.CreateVectorButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Button_Panel = new System.Windows.Forms.Panel();
            this.MaximizeScreenButton = new System.Windows.Forms.Button();
            this.ToggleBorderButton = new System.Windows.Forms.Button();
            this.SideBarLabel = new System.Windows.Forms.Label();
            this.FreehandBrushButton = new System.Windows.Forms.Button();
            this.VectorMathsButton = new System.Windows.Forms.Button();
            this.SelectRadiusIncrementor = new System.Windows.Forms.NumericUpDown();
            this.SelectRadiusLabel = new System.Windows.Forms.Label();
            this.DeleteVectorButton = new System.Windows.Forms.Button();
            this.mouseXLabel = new System.Windows.Forms.Label();
            this.mouseYLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectVectorButton = new System.Windows.Forms.Button();
            this.LineColorButton = new System.Windows.Forms.Button();
            this.GuideColorButton = new System.Windows.Forms.Button();
            this.LineThicknessLabel = new System.Windows.Forms.Label();
            this.LineThicknessIncrement = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_Delay = new System.ComponentModel.BackgroundWorker();
            this.CurrentLineColor = new System.Windows.Forms.ColorDialog();
            this.CurrentGuideColor = new System.Windows.Forms.ColorDialog();
            this.ButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.PopupVectorMathsButton = new System.Windows.Forms.Button();
            this.PopupDeleteVectorButton = new System.Windows.Forms.Button();
            this.PopupMoveLineButton = new System.Windows.Forms.Button();
            this.PopupCopyLineButton = new System.Windows.Forms.Button();
            this.AddVectorButton = new System.Windows.Forms.Button();
            this.SubtractVectorButton = new System.Windows.Forms.Button();
            this.MultiplyVectorButton = new System.Windows.Forms.Button();
            this.DivideVectorButton = new System.Windows.Forms.Button();
            this.SidePanelMinimizeButton = new System.Windows.Forms.Button();
            this.ProductVectorButton = new System.Windows.Forms.Button();
            this.CrossProductButton = new System.Windows.Forms.Button();
            this.DotProductButton = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.SelectPopupPanel = new System.Windows.Forms.Panel();
            this.PopupTitleLabel = new System.Windows.Forms.Label();
            this.SelectPopupLabel = new System.Windows.Forms.Label();
            this.VectorMathsTitleLabel = new System.Windows.Forms.Label();
            this.VectorMathsPanel = new System.Windows.Forms.Panel();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.SelectedMathsPanel = new System.Windows.Forms.Panel();
            this.MathsResultLabel = new System.Windows.Forms.Label();
            this.MathOperationLabel = new System.Windows.Forms.Label();
            this.MathsLeftLabel = new System.Windows.Forms.Label();
            this.MathsRightLabel = new System.Windows.Forms.Label();
            this.MathTrackBar = new System.Windows.Forms.TrackBar();
            this.ProductPopupPanel = new System.Windows.Forms.Panel();
            this.ProductTitleLabel = new System.Windows.Forms.Label();
            this.Button_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectRadiusIncrementor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineThicknessIncrement)).BeginInit();
            this.SelectPopupPanel.SuspendLayout();
            this.VectorMathsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SelectedMathsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MathTrackBar)).BeginInit();
            this.ProductPopupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.FlatAppearance.BorderSize = 2;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Input", 13F);
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(166, 1014);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExitButton.Size = new System.Drawing.Size(88, 32);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "CLOSE";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonTooltip.SetToolTip(this.ExitButton, "Bye Bye");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HeaderText_1
            // 
            this.HeaderText_1.AutoSize = true;
            this.HeaderText_1.Font = new System.Drawing.Font("Input", 13F);
            this.HeaderText_1.ForeColor = System.Drawing.Color.LimeGreen;
            this.HeaderText_1.Location = new System.Drawing.Point(12, 9);
            this.HeaderText_1.Name = "HeaderText_1";
            this.HeaderText_1.Size = new System.Drawing.Size(129, 17);
            this.HeaderText_1.TabIndex = 1;
            this.HeaderText_1.Text = "Vector Tool";
            this.HeaderText_1.Click += new System.EventHandler(this.HeaderText_1_Click);
            // 
            // TimerButton
            // 
            this.TimerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerButton.AutoSize = true;
            this.TimerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TimerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.TimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TimerButton.Font = new System.Drawing.Font("Input", 18F);
            this.TimerButton.Location = new System.Drawing.Point(82, 385);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(90, 32);
            this.TimerButton.TabIndex = 2;
            this.TimerButton.Text = "Timer";
            this.ButtonTooltip.SetToolTip(this.TimerButton, "Random Timer decided to add for no reason have fun\r\n;]\r\nDo you want a shortcut on" +
        " this? [To be determined]");
            this.TimerButton.UseVisualStyleBackColor = false;
            this.TimerButton.Click += new System.EventHandler(this.TimerButton_Click);
            // 
            // TimerWorker
            // 
            this.TimerWorker.WorkerReportsProgress = true;
            this.TimerWorker.WorkerSupportsCancellation = true;
            this.TimerWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.timerWorker_DoWork);
            this.TimerWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.timerWorker_ProgressChanged);
            // 
            // CreateVectorButton
            // 
            this.CreateVectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateVectorButton.AutoSize = true;
            this.CreateVectorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateVectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.CreateVectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateVectorButton.Font = new System.Drawing.Font("Input", 18F);
            this.CreateVectorButton.Location = new System.Drawing.Point(40, 60);
            this.CreateVectorButton.Name = "CreateVectorButton";
            this.CreateVectorButton.Size = new System.Drawing.Size(174, 32);
            this.CreateVectorButton.TabIndex = 3;
            this.CreateVectorButton.Text = "Create Line";
            this.ButtonTooltip.SetToolTip(this.CreateVectorButton, "Toggle line creation on canvas that contains vector data.\r\nShortcut: [Space]");
            this.CreateVectorButton.UseVisualStyleBackColor = false;
            this.CreateVectorButton.Click += new System.EventHandler(this.CreateVectorButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.AutoSize = true;
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.ClearButton.FlatAppearance.BorderSize = 2;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Font = new System.Drawing.Font("Input", 13F);
            this.ClearButton.Location = new System.Drawing.Point(5, 987);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(88, 59);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear\r\nScreen";
            this.ButtonTooltip.SetToolTip(this.ClearButton, "Clears screen and deletes all lines on canvas.\r\nShortcut: [Haven\'t got one yet]");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Button_Panel
            // 
            this.Button_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(20)))));
            this.Button_Panel.Controls.Add(this.MaximizeScreenButton);
            this.Button_Panel.Controls.Add(this.ToggleBorderButton);
            this.Button_Panel.Controls.Add(this.SideBarLabel);
            this.Button_Panel.Controls.Add(this.FreehandBrushButton);
            this.Button_Panel.Controls.Add(this.VectorMathsButton);
            this.Button_Panel.Controls.Add(this.SelectRadiusIncrementor);
            this.Button_Panel.Controls.Add(this.SelectRadiusLabel);
            this.Button_Panel.Controls.Add(this.DeleteVectorButton);
            this.Button_Panel.Controls.Add(this.mouseXLabel);
            this.Button_Panel.Controls.Add(this.mouseYLabel);
            this.Button_Panel.Controls.Add(this.label5);
            this.Button_Panel.Controls.Add(this.SelectVectorButton);
            this.Button_Panel.Controls.Add(this.LineColorButton);
            this.Button_Panel.Controls.Add(this.GuideColorButton);
            this.Button_Panel.Controls.Add(this.LineThicknessLabel);
            this.Button_Panel.Controls.Add(this.LineThicknessIncrement);
            this.Button_Panel.Controls.Add(this.TimerButton);
            this.Button_Panel.Controls.Add(this.ClearButton);
            this.Button_Panel.Controls.Add(this.CreateVectorButton);
            this.Button_Panel.Controls.Add(this.ExitButton);
            this.Button_Panel.Location = new System.Drawing.Point(1650, 14);
            this.Button_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Panel.Name = "Button_Panel";
            this.Button_Panel.Padding = new System.Windows.Forms.Padding(2);
            this.Button_Panel.Size = new System.Drawing.Size(259, 1055);
            this.Button_Panel.TabIndex = 6;
            // 
            // MaximizeScreenButton
            // 
            this.MaximizeScreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.MaximizeScreenButton.FlatAppearance.BorderSize = 2;
            this.MaximizeScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MaximizeScreenButton.Font = new System.Drawing.Font("Input", 13F);
            this.MaximizeScreenButton.Location = new System.Drawing.Point(5, 857);
            this.MaximizeScreenButton.Name = "MaximizeScreenButton";
            this.MaximizeScreenButton.Size = new System.Drawing.Size(88, 59);
            this.MaximizeScreenButton.TabIndex = 37;
            this.MaximizeScreenButton.Text = "Full\r\nScreen";
            this.ButtonTooltip.SetToolTip(this.MaximizeScreenButton, "Fills window to screen\r\nShortcut: [Up Up Down Down Left Right Left Right A B]\r\n(W" +
        "indowed Fullscreen)");
            this.MaximizeScreenButton.UseVisualStyleBackColor = false;
            this.MaximizeScreenButton.Click += new System.EventHandler(this.MaximizeScreenButton_Click);
            // 
            // ToggleBorderButton
            // 
            this.ToggleBorderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToggleBorderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.ToggleBorderButton.FlatAppearance.BorderSize = 2;
            this.ToggleBorderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToggleBorderButton.Font = new System.Drawing.Font("Input", 13F);
            this.ToggleBorderButton.Location = new System.Drawing.Point(5, 922);
            this.ToggleBorderButton.Name = "ToggleBorderButton";
            this.ToggleBorderButton.Size = new System.Drawing.Size(88, 59);
            this.ToggleBorderButton.TabIndex = 36;
            this.ToggleBorderButton.Text = "Toggle\r\nBorder";
            this.ButtonTooltip.SetToolTip(this.ToggleBorderButton, "Toggles window border enabling resizing of the window\r\nShortcut: [Haven\'t got one" +
        " yet]");
            this.ToggleBorderButton.UseVisualStyleBackColor = false;
            this.ToggleBorderButton.Click += new System.EventHandler(this.ToggleBorderButton_Click);
            // 
            // SideBarLabel
            // 
            this.SideBarLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.SideBarLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SideBarLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SideBarLabel.Font = new System.Drawing.Font("Input", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideBarLabel.Location = new System.Drawing.Point(2, 2);
            this.SideBarLabel.Name = "SideBarLabel";
            this.SideBarLabel.Size = new System.Drawing.Size(255, 43);
            this.SideBarLabel.TabIndex = 35;
            this.SideBarLabel.Text = " Control Panel";
            this.SideBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FreehandBrushButton
            // 
            this.FreehandBrushButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FreehandBrushButton.AutoSize = true;
            this.FreehandBrushButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FreehandBrushButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.FreehandBrushButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FreehandBrushButton.Font = new System.Drawing.Font("Input", 18F);
            this.FreehandBrushButton.Location = new System.Drawing.Point(19, 320);
            this.FreehandBrushButton.Name = "FreehandBrushButton";
            this.FreehandBrushButton.Size = new System.Drawing.Size(216, 32);
            this.FreehandBrushButton.TabIndex = 34;
            this.FreehandBrushButton.Text = "Freehand Brush";
            this.ButtonTooltip.SetToolTip(this.FreehandBrushButton, "Freehand brush allowing you to create custom shapes and\r\nputting down notes.\r\n(Sh" +
        "ould i have a clear brush and clear lines button or just clear screen?)\r\nShortcu" +
        "t: [N/A]");
            this.FreehandBrushButton.UseVisualStyleBackColor = false;
            this.FreehandBrushButton.Click += new System.EventHandler(this.FreehandBrushButton_Click);
            // 
            // VectorMathsButton
            // 
            this.VectorMathsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VectorMathsButton.AutoSize = true;
            this.VectorMathsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VectorMathsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.VectorMathsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VectorMathsButton.Font = new System.Drawing.Font("Input", 18F);
            this.VectorMathsButton.Location = new System.Drawing.Point(33, 125);
            this.VectorMathsButton.Name = "VectorMathsButton";
            this.VectorMathsButton.Size = new System.Drawing.Size(188, 32);
            this.VectorMathsButton.TabIndex = 33;
            this.VectorMathsButton.Text = "Vector Maths";
            this.ButtonTooltip.SetToolTip(this.VectorMathsButton, "Delete selected line (If line isn\'t selected last created line is deleted)\r\nShort" +
        "cut: [X]");
            this.VectorMathsButton.UseVisualStyleBackColor = false;
            this.VectorMathsButton.Click += new System.EventHandler(this.VectorMathsButton_Click);
            // 
            // SelectRadiusIncrementor
            // 
            this.SelectRadiusIncrementor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectRadiusIncrementor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.SelectRadiusIncrementor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectRadiusIncrementor.Cursor = System.Windows.Forms.Cursors.Default;
            this.SelectRadiusIncrementor.Font = new System.Drawing.Font("Input", 9.5F);
            this.SelectRadiusIncrementor.ForeColor = System.Drawing.Color.Red;
            this.SelectRadiusIncrementor.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.SelectRadiusIncrementor.Location = new System.Drawing.Point(196, 992);
            this.SelectRadiusIncrementor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SelectRadiusIncrementor.Name = "SelectRadiusIncrementor";
            this.SelectRadiusIncrementor.Size = new System.Drawing.Size(58, 15);
            this.SelectRadiusIncrementor.TabIndex = 31;
            this.SelectRadiusIncrementor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonTooltip.SetToolTip(this.SelectRadiusIncrementor, "Select cursor\'s circular radius for brush and selection\r\n(Min: 0 | Max: 100)\r\nSho" +
        "rtcuts:\r\n   Increase: [Scroll Wheel +]\r\n   Decrease: [Scroll Wheel -]\r\n   Scroll" +
        "wheel active when in SELECT mode");
            this.SelectRadiusIncrementor.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SelectRadiusIncrementor.ValueChanged += new System.EventHandler(this.SelectRadiusIncrementor_ValueChanged);
            // 
            // SelectRadiusLabel
            // 
            this.SelectRadiusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectRadiusLabel.AutoSize = true;
            this.SelectRadiusLabel.Font = new System.Drawing.Font("Input", 12.5F);
            this.SelectRadiusLabel.Location = new System.Drawing.Point(187, 951);
            this.SelectRadiusLabel.Name = "SelectRadiusLabel";
            this.SelectRadiusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectRadiusLabel.Size = new System.Drawing.Size(67, 30);
            this.SelectRadiusLabel.TabIndex = 30;
            this.SelectRadiusLabel.Text = "Cursor\r\nRadius";
            this.SelectRadiusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteVectorButton
            // 
            this.DeleteVectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteVectorButton.AutoSize = true;
            this.DeleteVectorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteVectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.DeleteVectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteVectorButton.Font = new System.Drawing.Font("Input", 18F);
            this.DeleteVectorButton.Location = new System.Drawing.Point(40, 255);
            this.DeleteVectorButton.Name = "DeleteVectorButton";
            this.DeleteVectorButton.Size = new System.Drawing.Size(174, 32);
            this.DeleteVectorButton.TabIndex = 26;
            this.DeleteVectorButton.Text = "Delete Line";
            this.ButtonTooltip.SetToolTip(this.DeleteVectorButton, "Delete selected line (If line isn\'t selected last created line is deleted)\r\nShort" +
        "cut: [X]");
            this.DeleteVectorButton.UseVisualStyleBackColor = false;
            this.DeleteVectorButton.Click += new System.EventHandler(this.DeleteVectorButton_Click);
            // 
            // mouseXLabel
            // 
            this.mouseXLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mouseXLabel.AutoSize = true;
            this.mouseXLabel.Font = new System.Drawing.Font("Input", 10F);
            this.mouseXLabel.Location = new System.Drawing.Point(5, 821);
            this.mouseXLabel.Name = "mouseXLabel";
            this.mouseXLabel.Size = new System.Drawing.Size(71, 13);
            this.mouseXLabel.TabIndex = 25;
            this.mouseXLabel.Text = "MouseX: ";
            this.mouseXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mouseYLabel
            // 
            this.mouseYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mouseYLabel.AutoSize = true;
            this.mouseYLabel.Font = new System.Drawing.Font("Input", 10F);
            this.mouseYLabel.Location = new System.Drawing.Point(5, 841);
            this.mouseYLabel.Name = "mouseYLabel";
            this.mouseYLabel.Size = new System.Drawing.Size(71, 13);
            this.mouseYLabel.TabIndex = 24;
            this.mouseYLabel.Text = "MouseY: ";
            this.mouseYLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Input", 12.2F);
            this.label5.Location = new System.Drawing.Point(5, 790);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Line Count: 0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTooltip.SetToolTip(this.label5, "How many lines are there!");
            // 
            // SelectVectorButton
            // 
            this.SelectVectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectVectorButton.AutoSize = true;
            this.SelectVectorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectVectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.SelectVectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectVectorButton.Font = new System.Drawing.Font("Input", 18F);
            this.SelectVectorButton.Location = new System.Drawing.Point(40, 190);
            this.SelectVectorButton.Name = "SelectVectorButton";
            this.SelectVectorButton.Size = new System.Drawing.Size(174, 32);
            this.SelectVectorButton.TabIndex = 17;
            this.SelectVectorButton.Text = "Select Line";
            this.ButtonTooltip.SetToolTip(this.SelectVectorButton, "Select line to edit or show vector math options.\r\nShortcut: {Z]");
            this.SelectVectorButton.UseVisualStyleBackColor = false;
            this.SelectVectorButton.Click += new System.EventHandler(this.SelectVectorButton_Click);
            // 
            // LineColorButton
            // 
            this.LineColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineColorButton.AutoSize = true;
            this.LineColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.LineColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LineColorButton.Font = new System.Drawing.Font("Input", 13F);
            this.LineColorButton.Location = new System.Drawing.Point(115, 821);
            this.LineColorButton.Name = "LineColorButton";
            this.LineColorButton.Size = new System.Drawing.Size(139, 27);
            this.LineColorButton.TabIndex = 16;
            this.LineColorButton.Text = "Line Colour";
            this.ButtonTooltip.SetToolTip(this.LineColorButton, "Changes drawn line colour.\r\nShortcut: [C]");
            this.LineColorButton.UseVisualStyleBackColor = false;
            this.LineColorButton.Click += new System.EventHandler(this.LineColorButton_Click);
            // 
            // GuideColorButton
            // 
            this.GuideColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuideColorButton.AutoSize = true;
            this.GuideColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.GuideColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GuideColorButton.Font = new System.Drawing.Font("Input", 10F);
            this.GuideColorButton.Location = new System.Drawing.Point(149, 854);
            this.GuideColorButton.Name = "GuideColorButton";
            this.GuideColorButton.Size = new System.Drawing.Size(105, 23);
            this.GuideColorButton.TabIndex = 15;
            this.GuideColorButton.Text = "Guide Color";
            this.ButtonTooltip.SetToolTip(this.GuideColorButton, "Changes guide line colour.\r\nShortcut: [Does it really need one]\r\n\r\n\r\n\r\n\r\n\r\nNah");
            this.GuideColorButton.UseVisualStyleBackColor = false;
            this.GuideColorButton.Click += new System.EventHandler(this.GuideColorButton_Click);
            // 
            // LineThicknessLabel
            // 
            this.LineThicknessLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineThicknessLabel.AutoSize = true;
            this.LineThicknessLabel.Font = new System.Drawing.Font("Input", 12.5F);
            this.LineThicknessLabel.Location = new System.Drawing.Point(197, 886);
            this.LineThicknessLabel.Name = "LineThicknessLabel";
            this.LineThicknessLabel.Size = new System.Drawing.Size(57, 30);
            this.LineThicknessLabel.TabIndex = 14;
            this.LineThicknessLabel.Text = "Line\r\nWidth";
            this.LineThicknessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LineThicknessIncrement
            // 
            this.LineThicknessIncrement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineThicknessIncrement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.LineThicknessIncrement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineThicknessIncrement.Cursor = System.Windows.Forms.Cursors.Default;
            this.LineThicknessIncrement.Font = new System.Drawing.Font("Input", 9.5F);
            this.LineThicknessIncrement.ForeColor = System.Drawing.Color.Red;
            this.LineThicknessIncrement.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LineThicknessIncrement.Location = new System.Drawing.Point(196, 927);
            this.LineThicknessIncrement.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LineThicknessIncrement.Name = "LineThicknessIncrement";
            this.LineThicknessIncrement.Size = new System.Drawing.Size(58, 15);
            this.LineThicknessIncrement.TabIndex = 13;
            this.LineThicknessIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonTooltip.SetToolTip(this.LineThicknessIncrement, resources.GetString("LineThicknessIncrement.ToolTip"));
            this.LineThicknessIncrement.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.LineThicknessIncrement.ValueChanged += new System.EventHandler(this.LineThicknessIncrement_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Input", 7F);
            this.label6.Location = new System.Drawing.Point(12, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 9);
            this.label6.TabIndex = 23;
            this.label6.Text = "Gradient: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonTooltip.SetToolTip(this.label6, "Slope variable of line.\r\n(0 is a straight line)");
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectPopupPanel_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Input", 7F);
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 9);
            this.label4.TabIndex = 21;
            this.label4.Text = "Start: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectPopupPanel_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Input", 7F);
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 9);
            this.label3.TabIndex = 20;
            this.label3.Text = "End:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectPopupPanel_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Input", 7F);
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 9);
            this.label2.TabIndex = 19;
            this.label2.Text = "Magnitude:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonTooltip.SetToolTip(this.label2, "Length of Vector");
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectPopupPanel_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Input", 7F);
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 9);
            this.label1.TabIndex = 18;
            this.label1.Text = "Normal: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonTooltip.SetToolTip(this.label1, "Vector to magnitude of 1\r\n(Vectors Direction)");
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectPopupPanel_MouseMove);
            // 
            // PopupVectorMathsButton
            // 
            this.PopupVectorMathsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PopupVectorMathsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.PopupVectorMathsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PopupVectorMathsButton.Font = new System.Drawing.Font("Input", 13F);
            this.PopupVectorMathsButton.Location = new System.Drawing.Point(172, 53);
            this.PopupVectorMathsButton.Name = "PopupVectorMathsButton";
            this.PopupVectorMathsButton.Size = new System.Drawing.Size(162, 39);
            this.PopupVectorMathsButton.TabIndex = 33;
            this.PopupVectorMathsButton.Text = "Vector Maths";
            this.ButtonTooltip.SetToolTip(this.PopupVectorMathsButton, "Vector Maths functions that create a new line based on the\r\nmath function and lin" +
        "es selected.\r\n(Only works with more than one line present)\r\nShortcut: [N/A]\r\n(Sh" +
        "ould this have a shortcut)");
            this.PopupVectorMathsButton.UseVisualStyleBackColor = false;
            this.PopupVectorMathsButton.Click += new System.EventHandler(this.PopupVectorMathsButton_Click);
            this.PopupVectorMathsButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectPopupPanel_MouseMove);
            // 
            // PopupDeleteVectorButton
            // 
            this.PopupDeleteVectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PopupDeleteVectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.PopupDeleteVectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PopupDeleteVectorButton.Font = new System.Drawing.Font("Input", 13F);
            this.PopupDeleteVectorButton.Location = new System.Drawing.Point(172, 215);
            this.PopupDeleteVectorButton.Name = "PopupDeleteVectorButton";
            this.PopupDeleteVectorButton.Size = new System.Drawing.Size(162, 39);
            this.PopupDeleteVectorButton.TabIndex = 34;
            this.PopupDeleteVectorButton.Text = "Delete Line";
            this.ButtonTooltip.SetToolTip(this.PopupDeleteVectorButton, "Deletes currently selected line.\r\nShortcut: [X]");
            this.PopupDeleteVectorButton.UseVisualStyleBackColor = false;
            this.PopupDeleteVectorButton.Click += new System.EventHandler(this.DeleteVectorButton_Click);
            this.PopupDeleteVectorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectPopupPanel_MouseMove);
            // 
            // PopupMoveLineButton
            // 
            this.PopupMoveLineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PopupMoveLineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.PopupMoveLineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PopupMoveLineButton.Font = new System.Drawing.Font("Input", 13F);
            this.PopupMoveLineButton.Location = new System.Drawing.Point(172, 107);
            this.PopupMoveLineButton.Name = "PopupMoveLineButton";
            this.PopupMoveLineButton.Size = new System.Drawing.Size(162, 39);
            this.PopupMoveLineButton.TabIndex = 35;
            this.PopupMoveLineButton.Text = "Move Line";
            this.ButtonTooltip.SetToolTip(this.PopupMoveLineButton, "Moves currently selected line.\r\nShortcut: [N/A]\r\nNot done yet");
            this.PopupMoveLineButton.UseVisualStyleBackColor = false;
            this.PopupMoveLineButton.Click += new System.EventHandler(this.PopupMoveLineButton_Click);
            this.PopupMoveLineButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectPopupPanel_MouseMove);
            // 
            // PopupCopyLineButton
            // 
            this.PopupCopyLineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PopupCopyLineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.PopupCopyLineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PopupCopyLineButton.Font = new System.Drawing.Font("Input", 13F);
            this.PopupCopyLineButton.Location = new System.Drawing.Point(172, 161);
            this.PopupCopyLineButton.Name = "PopupCopyLineButton";
            this.PopupCopyLineButton.Size = new System.Drawing.Size(162, 39);
            this.PopupCopyLineButton.TabIndex = 36;
            this.PopupCopyLineButton.Text = "Copy Line";
            this.ButtonTooltip.SetToolTip(this.PopupCopyLineButton, "Duplicates line selected.\r\nShortcut: [N/A]\r\nNothin yet combe back later");
            this.PopupCopyLineButton.UseVisualStyleBackColor = false;
            this.PopupCopyLineButton.Click += new System.EventHandler(this.PopupCopyLineButton_Click);
            this.PopupCopyLineButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectPopupPanel_MouseMove);
            // 
            // AddVectorButton
            // 
            this.AddVectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddVectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.AddVectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddVectorButton.Font = new System.Drawing.Font("Input", 10.5F);
            this.AddVectorButton.Location = new System.Drawing.Point(21, 42);
            this.AddVectorButton.Name = "AddVectorButton";
            this.AddVectorButton.Size = new System.Drawing.Size(119, 37);
            this.AddVectorButton.TabIndex = 37;
            this.AddVectorButton.Text = "Add";
            this.ButtonTooltip.SetToolTip(this.AddVectorButton, "Adds two selected vectors to create a new line representing the result\r\n(X1 + X2," +
        " Y1 + Y2) = (X3, Y3)\r\n");
            this.AddVectorButton.UseVisualStyleBackColor = false;
            this.AddVectorButton.Click += new System.EventHandler(this.AddVectorButton_Click);
            this.AddVectorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VectorMathsPanel_MouseMove);
            // 
            // SubtractVectorButton
            // 
            this.SubtractVectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubtractVectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.SubtractVectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubtractVectorButton.Font = new System.Drawing.Font("Input", 10.5F);
            this.SubtractVectorButton.Location = new System.Drawing.Point(21, 82);
            this.SubtractVectorButton.Name = "SubtractVectorButton";
            this.SubtractVectorButton.Size = new System.Drawing.Size(119, 37);
            this.SubtractVectorButton.TabIndex = 38;
            this.SubtractVectorButton.Text = "Subtract";
            this.ButtonTooltip.SetToolTip(this.SubtractVectorButton, "Subtracts two selected vectors to create a new line representing the result\r\n(X1 " +
        "- X2, Y1 - Y2) = (X3, Y3)\r\n");
            this.SubtractVectorButton.UseVisualStyleBackColor = false;
            this.SubtractVectorButton.Click += new System.EventHandler(this.SubtractVectorButton_Click);
            this.SubtractVectorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VectorMathsPanel_MouseMove);
            // 
            // MultiplyVectorButton
            // 
            this.MultiplyVectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MultiplyVectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.MultiplyVectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MultiplyVectorButton.Font = new System.Drawing.Font("Input", 10.5F);
            this.MultiplyVectorButton.Location = new System.Drawing.Point(21, 122);
            this.MultiplyVectorButton.Name = "MultiplyVectorButton";
            this.MultiplyVectorButton.Size = new System.Drawing.Size(119, 37);
            this.MultiplyVectorButton.TabIndex = 39;
            this.MultiplyVectorButton.Text = "Multiply";
            this.ButtonTooltip.SetToolTip(this.MultiplyVectorButton, "Multiplies two selected vectors to create a new line representing the result\r\n(X1" +
        " * X2, Y1 * Y2) = (X3, Y3)\r\n");
            this.MultiplyVectorButton.UseVisualStyleBackColor = false;
            this.MultiplyVectorButton.Click += new System.EventHandler(this.MultiplyVectorButton_Click);
            this.MultiplyVectorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VectorMathsPanel_MouseMove);
            // 
            // DivideVectorButton
            // 
            this.DivideVectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivideVectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.DivideVectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DivideVectorButton.Font = new System.Drawing.Font("Input", 10.5F);
            this.DivideVectorButton.Location = new System.Drawing.Point(21, 162);
            this.DivideVectorButton.Name = "DivideVectorButton";
            this.DivideVectorButton.Size = new System.Drawing.Size(119, 37);
            this.DivideVectorButton.TabIndex = 40;
            this.DivideVectorButton.Text = "Divide";
            this.ButtonTooltip.SetToolTip(this.DivideVectorButton, "Divides two selected vectors to create a new line representing the result\r\n(X1 / " +
        "X2, Y1 / Y2) = (X3, Y3)\r\n");
            this.DivideVectorButton.UseVisualStyleBackColor = false;
            this.DivideVectorButton.Click += new System.EventHandler(this.DivideVectorButton_Click);
            this.DivideVectorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VectorMathsPanel_MouseMove);
            // 
            // SidePanelMinimizeButton
            // 
            this.SidePanelMinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SidePanelMinimizeButton.BackColor = System.Drawing.Color.DarkRed;
            this.SidePanelMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SidePanelMinimizeButton.Font = new System.Drawing.Font("Input", 25F, System.Drawing.FontStyle.Bold);
            this.SidePanelMinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.SidePanelMinimizeButton.Location = new System.Drawing.Point(1888, 9);
            this.SidePanelMinimizeButton.Name = "SidePanelMinimizeButton";
            this.SidePanelMinimizeButton.Size = new System.Drawing.Size(35, 36);
            this.SidePanelMinimizeButton.TabIndex = 36;
            this.SidePanelMinimizeButton.Text = "-";
            this.ButtonTooltip.SetToolTip(this.SidePanelMinimizeButton, "Minimize button side panel.\r\nShortcut [What keey should it bee]");
            this.SidePanelMinimizeButton.UseVisualStyleBackColor = false;
            this.SidePanelMinimizeButton.Click += new System.EventHandler(this.SidePanelMinimizeButton_Click);
            // 
            // ProductVectorButton
            // 
            this.ProductVectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductVectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.ProductVectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProductVectorButton.Font = new System.Drawing.Font("Input", 10.5F);
            this.ProductVectorButton.Location = new System.Drawing.Point(21, 202);
            this.ProductVectorButton.Name = "ProductVectorButton";
            this.ProductVectorButton.Size = new System.Drawing.Size(119, 37);
            this.ProductVectorButton.TabIndex = 41;
            this.ProductVectorButton.Text = "Product";
            this.ButtonTooltip.SetToolTip(this.ProductVectorButton, "Popup product math functions.\r\n");
            this.ProductVectorButton.UseVisualStyleBackColor = false;
            this.ProductVectorButton.Click += new System.EventHandler(this.ProductVectorButton_Click);
            this.ProductVectorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VectorMathsPanel_MouseMove);
            // 
            // CrossProductButton
            // 
            this.CrossProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CrossProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.CrossProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CrossProductButton.Font = new System.Drawing.Font("Input", 8F);
            this.CrossProductButton.Location = new System.Drawing.Point(17, 76);
            this.CrossProductButton.Name = "CrossProductButton";
            this.CrossProductButton.Size = new System.Drawing.Size(73, 33);
            this.CrossProductButton.TabIndex = 38;
            this.CrossProductButton.Text = "Cross";
            this.ButtonTooltip.SetToolTip(this.CrossProductButton, "Subtracts two selected vectors to create a new line representing the result\r\n(X1 " +
        "- X2, Y1 - Y2) = (X3, Y3)\r\n");
            this.CrossProductButton.UseVisualStyleBackColor = false;
            this.CrossProductButton.Click += new System.EventHandler(this.CrossProductButton_Click);
            // 
            // DotProductButton
            // 
            this.DotProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DotProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.DotProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DotProductButton.Font = new System.Drawing.Font("Input", 8F);
            this.DotProductButton.Location = new System.Drawing.Point(17, 39);
            this.DotProductButton.Margin = new System.Windows.Forms.Padding(1);
            this.DotProductButton.Name = "DotProductButton";
            this.DotProductButton.Size = new System.Drawing.Size(73, 33);
            this.DotProductButton.TabIndex = 37;
            this.DotProductButton.Text = "Dot";
            this.ButtonTooltip.SetToolTip(this.DotProductButton, "Dot Product of two vectors\r\n(X1 + X2, Y1 + Y2) = (X3, Y3)\r\n");
            this.DotProductButton.UseVisualStyleBackColor = false;
            this.DotProductButton.Click += new System.EventHandler(this.DotProductButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // SelectPopupPanel
            // 
            this.SelectPopupPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectPopupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(12)))), ((int)(((byte)(20)))));
            this.SelectPopupPanel.Controls.Add(this.PopupCopyLineButton);
            this.SelectPopupPanel.Controls.Add(this.PopupMoveLineButton);
            this.SelectPopupPanel.Controls.Add(this.PopupDeleteVectorButton);
            this.SelectPopupPanel.Controls.Add(this.PopupVectorMathsButton);
            this.SelectPopupPanel.Controls.Add(this.PopupTitleLabel);
            this.SelectPopupPanel.Controls.Add(this.SelectPopupLabel);
            this.SelectPopupPanel.Controls.Add(this.label4);
            this.SelectPopupPanel.Controls.Add(this.label1);
            this.SelectPopupPanel.Controls.Add(this.label2);
            this.SelectPopupPanel.Controls.Add(this.label3);
            this.SelectPopupPanel.Controls.Add(this.label6);
            this.SelectPopupPanel.Enabled = false;
            this.SelectPopupPanel.Location = new System.Drawing.Point(68, 270);
            this.SelectPopupPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.SelectPopupPanel.Name = "SelectPopupPanel";
            this.SelectPopupPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.SelectPopupPanel.Size = new System.Drawing.Size(340, 274);
            this.SelectPopupPanel.TabIndex = 8;
            this.SelectPopupPanel.Visible = false;
            this.SelectPopupPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectPopupPanel_MouseMove);
            // 
            // PopupTitleLabel
            // 
            this.PopupTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.PopupTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PopupTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PopupTitleLabel.Font = new System.Drawing.Font("Input", 15.5F);
            this.PopupTitleLabel.ForeColor = System.Drawing.Color.Lime;
            this.PopupTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.PopupTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PopupTitleLabel.Name = "PopupTitleLabel";
            this.PopupTitleLabel.Size = new System.Drawing.Size(334, 29);
            this.PopupTitleLabel.TabIndex = 9;
            this.PopupTitleLabel.Text = "Edit Vector";
            this.PopupTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PopupTitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectPopupPanel_MouseMove);
            // 
            // SelectPopupLabel
            // 
            this.SelectPopupLabel.AutoSize = true;
            this.SelectPopupLabel.Font = new System.Drawing.Font("Input", 10F);
            this.SelectPopupLabel.ForeColor = System.Drawing.Color.Lime;
            this.SelectPopupLabel.Location = new System.Drawing.Point(5, 56);
            this.SelectPopupLabel.Name = "SelectPopupLabel";
            this.SelectPopupLabel.Padding = new System.Windows.Forms.Padding(5);
            this.SelectPopupLabel.Size = new System.Drawing.Size(145, 23);
            this.SelectPopupLabel.TabIndex = 0;
            this.SelectPopupLabel.Text = "Selected Line: 0";
            this.SelectPopupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectPopupLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SelectPopupPanel_MouseMove);
            // 
            // VectorMathsTitleLabel
            // 
            this.VectorMathsTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.VectorMathsTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VectorMathsTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VectorMathsTitleLabel.Font = new System.Drawing.Font("Input", 14F);
            this.VectorMathsTitleLabel.ForeColor = System.Drawing.Color.Lime;
            this.VectorMathsTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.VectorMathsTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.VectorMathsTitleLabel.Name = "VectorMathsTitleLabel";
            this.VectorMathsTitleLabel.Size = new System.Drawing.Size(162, 29);
            this.VectorMathsTitleLabel.TabIndex = 37;
            this.VectorMathsTitleLabel.Text = "Vector Maths";
            this.VectorMathsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VectorMathsTitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VectorMathsPanel_MouseMove);
            // 
            // VectorMathsPanel
            // 
            this.VectorMathsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.VectorMathsPanel.Controls.Add(this.ProductVectorButton);
            this.VectorMathsPanel.Controls.Add(this.DivideVectorButton);
            this.VectorMathsPanel.Controls.Add(this.MultiplyVectorButton);
            this.VectorMathsPanel.Controls.Add(this.SubtractVectorButton);
            this.VectorMathsPanel.Controls.Add(this.AddVectorButton);
            this.VectorMathsPanel.Controls.Add(this.VectorMathsTitleLabel);
            this.VectorMathsPanel.Enabled = false;
            this.VectorMathsPanel.Location = new System.Drawing.Point(435, 277);
            this.VectorMathsPanel.Name = "VectorMathsPanel";
            this.VectorMathsPanel.Size = new System.Drawing.Size(162, 249);
            this.VectorMathsPanel.TabIndex = 38;
            this.VectorMathsPanel.Visible = false;
            this.VectorMathsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VectorMathsPanel_MouseMove);
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(6)))), ((int)(((byte)(8)))));
            this.Canvas.BackgroundImage = global::Vector_Maths_Tool.Properties.Resources.backgroundSpeed;
            this.Canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Canvas.Location = new System.Drawing.Point(12, 29);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1633, 1040);
            this.Canvas.TabIndex = 7;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseEnter += new System.EventHandler(this.Canvas_MouseEnter);
            this.Canvas.MouseLeave += new System.EventHandler(this.Canvas_MouseLeave);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            this.Canvas.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Canvas_PreviewKeyDown);
            // 
            // SelectedMathsPanel
            // 
            this.SelectedMathsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectedMathsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.SelectedMathsPanel.Controls.Add(this.MathsResultLabel);
            this.SelectedMathsPanel.Controls.Add(this.MathOperationLabel);
            this.SelectedMathsPanel.Controls.Add(this.MathsLeftLabel);
            this.SelectedMathsPanel.Controls.Add(this.MathsRightLabel);
            this.SelectedMathsPanel.Enabled = false;
            this.SelectedMathsPanel.Location = new System.Drawing.Point(617, 92);
            this.SelectedMathsPanel.Name = "SelectedMathsPanel";
            this.SelectedMathsPanel.Size = new System.Drawing.Size(423, 145);
            this.SelectedMathsPanel.TabIndex = 41;
            this.SelectedMathsPanel.Visible = false;
            this.SelectedMathsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.SelectedMathsPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.SelectedMathsPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // MathsResultLabel
            // 
            this.MathsResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MathsResultLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(20)))));
            this.MathsResultLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MathsResultLabel.Font = new System.Drawing.Font("Input", 18F);
            this.MathsResultLabel.ForeColor = System.Drawing.Color.Lime;
            this.MathsResultLabel.Location = new System.Drawing.Point(13, 72);
            this.MathsResultLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MathsResultLabel.Name = "MathsResultLabel";
            this.MathsResultLabel.Size = new System.Drawing.Size(400, 72);
            this.MathsResultLabel.TabIndex = 40;
            this.MathsResultLabel.Text = "(2, 2)";
            this.MathsResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MathsResultLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.MathsResultLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.MathsResultLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // MathOperationLabel
            // 
            this.MathOperationLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MathOperationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(20)))));
            this.MathOperationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MathOperationLabel.Font = new System.Drawing.Font("Input", 22F, System.Drawing.FontStyle.Bold);
            this.MathOperationLabel.ForeColor = System.Drawing.Color.Lime;
            this.MathOperationLabel.Location = new System.Drawing.Point(162, 0);
            this.MathOperationLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MathOperationLabel.Name = "MathOperationLabel";
            this.MathOperationLabel.Size = new System.Drawing.Size(102, 72);
            this.MathOperationLabel.TabIndex = 39;
            this.MathOperationLabel.Text = "+";
            this.MathOperationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MathOperationLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.MathOperationLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.MathOperationLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // MathsLeftLabel
            // 
            this.MathsLeftLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MathsLeftLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(20)))));
            this.MathsLeftLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MathsLeftLabel.Font = new System.Drawing.Font("Input", 10.5F);
            this.MathsLeftLabel.ForeColor = System.Drawing.Color.Lime;
            this.MathsLeftLabel.Location = new System.Drawing.Point(13, 0);
            this.MathsLeftLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MathsLeftLabel.Name = "MathsLeftLabel";
            this.MathsLeftLabel.Size = new System.Drawing.Size(149, 72);
            this.MathsLeftLabel.TabIndex = 37;
            this.MathsLeftLabel.Text = "[0]\r\n(1, 1)";
            this.MathsLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MathsLeftLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.MathsLeftLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.MathsLeftLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // MathsRightLabel
            // 
            this.MathsRightLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MathsRightLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(20)))));
            this.MathsRightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MathsRightLabel.Font = new System.Drawing.Font("Input", 10.5F);
            this.MathsRightLabel.ForeColor = System.Drawing.Color.Lime;
            this.MathsRightLabel.Location = new System.Drawing.Point(264, 0);
            this.MathsRightLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MathsRightLabel.Name = "MathsRightLabel";
            this.MathsRightLabel.Size = new System.Drawing.Size(149, 72);
            this.MathsRightLabel.TabIndex = 38;
            this.MathsRightLabel.Text = "[1]\r\n(1, 1)";
            this.MathsRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MathsRightLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.MathsRightLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.MathsRightLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // MathTrackBar
            // 
            this.MathTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.MathTrackBar.Enabled = false;
            this.MathTrackBar.Location = new System.Drawing.Point(1043, 92);
            this.MathTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.MathTrackBar.Maximum = 50;
            this.MathTrackBar.Minimum = -50;
            this.MathTrackBar.Name = "MathTrackBar";
            this.MathTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.MathTrackBar.Size = new System.Drawing.Size(45, 145);
            this.MathTrackBar.TabIndex = 42;
            this.MathTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.MathTrackBar.Value = 20;
            this.MathTrackBar.Visible = false;
            this.MathTrackBar.Scroll += new System.EventHandler(this.MathTrackBar_Scroll);
            this.MathTrackBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            // 
            // ProductPopupPanel
            // 
            this.ProductPopupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(19)))));
            this.ProductPopupPanel.Controls.Add(this.CrossProductButton);
            this.ProductPopupPanel.Controls.Add(this.DotProductButton);
            this.ProductPopupPanel.Controls.Add(this.ProductTitleLabel);
            this.ProductPopupPanel.Enabled = false;
            this.ProductPopupPanel.Location = new System.Drawing.Point(617, 277);
            this.ProductPopupPanel.Name = "ProductPopupPanel";
            this.ProductPopupPanel.Size = new System.Drawing.Size(107, 119);
            this.ProductPopupPanel.TabIndex = 42;
            this.ProductPopupPanel.Visible = false;
            // 
            // ProductTitleLabel
            // 
            this.ProductTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(22)))), ((int)(((byte)(18)))));
            this.ProductTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductTitleLabel.Font = new System.Drawing.Font("Input", 12.5F);
            this.ProductTitleLabel.ForeColor = System.Drawing.Color.Lime;
            this.ProductTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.ProductTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ProductTitleLabel.Name = "ProductTitleLabel";
            this.ProductTitleLabel.Size = new System.Drawing.Size(107, 29);
            this.ProductTitleLabel.TabIndex = 37;
            this.ProductTitleLabel.Text = "Product";
            this.ProductTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Vector_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.MathTrackBar);
            this.Controls.Add(this.ProductPopupPanel);
            this.Controls.Add(this.SelectedMathsPanel);
            this.Controls.Add(this.VectorMathsPanel);
            this.Controls.Add(this.SidePanelMinimizeButton);
            this.Controls.Add(this.SelectPopupPanel);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.Button_Panel);
            this.Controls.Add(this.HeaderText_1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Input", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Vector_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vector Tool";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.Vector_Form_Load);
            this.Resize += new System.EventHandler(this.Vector_Form_Resize);
            this.Button_Panel.ResumeLayout(false);
            this.Button_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectRadiusIncrementor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineThicknessIncrement)).EndInit();
            this.SelectPopupPanel.ResumeLayout(false);
            this.SelectPopupPanel.PerformLayout();
            this.VectorMathsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.SelectedMathsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MathTrackBar)).EndInit();
            this.ProductPopupPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label HeaderText_1;
        private System.Windows.Forms.Button TimerButton;
        private System.ComponentModel.BackgroundWorker TimerWorker;
        private System.Windows.Forms.Button CreateVectorButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel Button_Panel;
        private System.ComponentModel.BackgroundWorker UI_Delay;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.NumericUpDown LineThicknessIncrement;
        private System.Windows.Forms.Label LineThicknessLabel;
        private System.Windows.Forms.ColorDialog CurrentLineColor;
        private System.Windows.Forms.Button LineColorButton;
        private System.Windows.Forms.Button GuideColorButton;
        private System.Windows.Forms.ColorDialog CurrentGuideColor;
        private System.Windows.Forms.Button SelectVectorButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip ButtonTooltip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.Label mouseXLabel;
        private System.Windows.Forms.Label mouseYLabel;
        private System.Windows.Forms.Button DeleteVectorButton;
        private System.Windows.Forms.Panel SelectPopupPanel;
        private System.Windows.Forms.Label SelectPopupLabel;
        private System.Windows.Forms.Label SelectRadiusLabel;
        private System.Windows.Forms.NumericUpDown SelectRadiusIncrementor;
        private System.Windows.Forms.Label PopupTitleLabel;
        private System.Windows.Forms.Button VectorMathsButton;
        private System.Windows.Forms.Button PopupCopyLineButton;
        private System.Windows.Forms.Button PopupMoveLineButton;
        private System.Windows.Forms.Button PopupDeleteVectorButton;
        private System.Windows.Forms.Button PopupVectorMathsButton;
        private System.Windows.Forms.Label SideBarLabel;
        private System.Windows.Forms.Button FreehandBrushButton;
        private System.Windows.Forms.Button SidePanelMinimizeButton;
        private System.Windows.Forms.Label VectorMathsTitleLabel;
        private System.Windows.Forms.Panel VectorMathsPanel;
        private System.Windows.Forms.Button DivideVectorButton;
        private System.Windows.Forms.Button MultiplyVectorButton;
        private System.Windows.Forms.Button SubtractVectorButton;
        private System.Windows.Forms.Button AddVectorButton;
        private System.Windows.Forms.Button MaximizeScreenButton;
        private System.Windows.Forms.Button ToggleBorderButton;
        private System.Windows.Forms.Panel SelectedMathsPanel;
        private System.Windows.Forms.Label MathsLeftLabel;
        private System.Windows.Forms.Label MathOperationLabel;
        private System.Windows.Forms.Label MathsRightLabel;
        private System.Windows.Forms.Label MathsResultLabel;
        private System.Windows.Forms.TrackBar MathTrackBar;
        private System.Windows.Forms.Button ProductVectorButton;
        private System.Windows.Forms.Panel ProductPopupPanel;
        private System.Windows.Forms.Button CrossProductButton;
        private System.Windows.Forms.Button DotProductButton;
        private System.Windows.Forms.Label ProductTitleLabel;
    }
}

