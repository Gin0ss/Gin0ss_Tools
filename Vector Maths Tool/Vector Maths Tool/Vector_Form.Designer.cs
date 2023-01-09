
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectVectorButton = new System.Windows.Forms.Button();
            this.LineColorButton = new System.Windows.Forms.Button();
            this.GuideColorButton = new System.Windows.Forms.Button();
            this.LineThicknessLabel = new System.Windows.Forms.Label();
            this.LineThicknessIncrement = new System.Windows.Forms.NumericUpDown();
            this.Bool_Label_3 = new System.Windows.Forms.Label();
            this.Bool_Label_2 = new System.Windows.Forms.Label();
            this.Bool_Label_1 = new System.Windows.Forms.Label();
            this.Bool_Label_0 = new System.Windows.Forms.Label();
            this.UI_Delay = new System.ComponentModel.BackgroundWorker();
            this.CurrentLineColor = new System.Windows.Forms.ColorDialog();
            this.CurrentGuideColor = new System.Windows.Forms.ColorDialog();
            this.ButtonTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.Bool_Check_3 = new System.Windows.Forms.PictureBox();
            this.Bool_Check_1 = new System.Windows.Forms.PictureBox();
            this.Bool_Check_2 = new System.Windows.Forms.PictureBox();
            this.Bool_Check_0 = new System.Windows.Forms.PictureBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.Button_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineThicknessIncrement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bool_Check_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bool_Check_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bool_Check_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bool_Check_0)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.FlatAppearance.BorderSize = 2;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Input", 13F);
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(159, 1014);
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
            this.TimerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.TimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TimerButton.Font = new System.Drawing.Font("Input", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerButton.Location = new System.Drawing.Point(10, 29);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(237, 39);
            this.TimerButton.TabIndex = 2;
            this.TimerButton.Text = "Timer";
            this.ButtonTooltip.SetToolTip(this.TimerButton, "Random Timer decided to ad for no reason have fun\r\n;]");
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
            this.CreateVectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.CreateVectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateVectorButton.Font = new System.Drawing.Font("Input", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateVectorButton.Location = new System.Drawing.Point(10, 99);
            this.CreateVectorButton.Name = "CreateVectorButton";
            this.CreateVectorButton.Size = new System.Drawing.Size(237, 39);
            this.CreateVectorButton.TabIndex = 3;
            this.CreateVectorButton.Text = "Create Line";
            this.ButtonTooltip.SetToolTip(this.CreateVectorButton, "Toggle line creation on canvas that contains vector data.\r\nShortcut: [Space]");
            this.CreateVectorButton.UseVisualStyleBackColor = false;
            this.CreateVectorButton.Click += new System.EventHandler(this.CreateVectorButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ClearButton.AutoSize = true;
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.ClearButton.FlatAppearance.BorderSize = 2;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Input", 13F);
            this.ClearButton.Location = new System.Drawing.Point(166, 764);
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
            this.Button_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.Button_Panel.Controls.Add(this.label6);
            this.Button_Panel.Controls.Add(this.label5);
            this.Button_Panel.Controls.Add(this.label4);
            this.Button_Panel.Controls.Add(this.label3);
            this.Button_Panel.Controls.Add(this.label2);
            this.Button_Panel.Controls.Add(this.label1);
            this.Button_Panel.Controls.Add(this.SelectVectorButton);
            this.Button_Panel.Controls.Add(this.LineColorButton);
            this.Button_Panel.Controls.Add(this.GuideColorButton);
            this.Button_Panel.Controls.Add(this.LineThicknessLabel);
            this.Button_Panel.Controls.Add(this.LineThicknessIncrement);
            this.Button_Panel.Controls.Add(this.Bool_Label_3);
            this.Button_Panel.Controls.Add(this.Bool_Check_3);
            this.Button_Panel.Controls.Add(this.Bool_Label_2);
            this.Button_Panel.Controls.Add(this.Bool_Label_1);
            this.Button_Panel.Controls.Add(this.Bool_Label_0);
            this.Button_Panel.Controls.Add(this.Bool_Check_1);
            this.Button_Panel.Controls.Add(this.Bool_Check_2);
            this.Button_Panel.Controls.Add(this.Bool_Check_0);
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
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Input", 7F);
            this.label6.Location = new System.Drawing.Point(8, 1004);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 9);
            this.label6.TabIndex = 23;
            this.label6.Text = "Gradient: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonTooltip.SetToolTip(this.label6, "Slope variable of line.\r\n(0 is a straight line)");
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Input", 12.2F);
            this.label5.Location = new System.Drawing.Point(7, 787);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Line Count: 0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTooltip.SetToolTip(this.label5, "How many lines are there!");
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Input", 7F);
            this.label4.Location = new System.Drawing.Point(8, 855);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 9);
            this.label4.TabIndex = 21;
            this.label4.Text = "Start: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Input", 7F);
            this.label3.Location = new System.Drawing.Point(8, 892);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 9);
            this.label3.TabIndex = 20;
            this.label3.Text = "End:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Input", 7F);
            this.label2.Location = new System.Drawing.Point(8, 929);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 9);
            this.label2.TabIndex = 19;
            this.label2.Text = "Magnitude:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonTooltip.SetToolTip(this.label2, "Length of Vector");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Input", 7F);
            this.label1.Location = new System.Drawing.Point(8, 966);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 9);
            this.label1.TabIndex = 18;
            this.label1.Text = "Normal: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonTooltip.SetToolTip(this.label1, "Vector to magnitude of 1\r\n(Vectors Direction)");
            // 
            // SelectVectorButton
            // 
            this.SelectVectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectVectorButton.AutoSize = true;
            this.SelectVectorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.SelectVectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectVectorButton.Font = new System.Drawing.Font("Input", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectVectorButton.Location = new System.Drawing.Point(10, 169);
            this.SelectVectorButton.Name = "SelectVectorButton";
            this.SelectVectorButton.Size = new System.Drawing.Size(237, 39);
            this.SelectVectorButton.TabIndex = 17;
            this.SelectVectorButton.Text = "Select Line";
            this.ButtonTooltip.SetToolTip(this.SelectVectorButton, "Select line to edit or show vector math options.\r\nShortcut: [n/a]\r\n(Not Implement" +
        "ed Yet)");
            this.SelectVectorButton.UseVisualStyleBackColor = false;
            this.SelectVectorButton.Click += new System.EventHandler(this.SelectVectorButton_Click);
            // 
            // LineColorButton
            // 
            this.LineColorButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LineColorButton.AutoSize = true;
            this.LineColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.LineColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LineColorButton.Font = new System.Drawing.Font("Input", 13F);
            this.LineColorButton.Location = new System.Drawing.Point(115, 688);
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
            this.GuideColorButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GuideColorButton.AutoSize = true;
            this.GuideColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.GuideColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GuideColorButton.Font = new System.Drawing.Font("Input", 10F);
            this.GuideColorButton.Location = new System.Drawing.Point(149, 721);
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
            this.LineThicknessLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LineThicknessLabel.AutoSize = true;
            this.LineThicknessLabel.Font = new System.Drawing.Font("Input", 14F);
            this.LineThicknessLabel.Location = new System.Drawing.Point(136, 634);
            this.LineThicknessLabel.Name = "LineThicknessLabel";
            this.LineThicknessLabel.Size = new System.Drawing.Size(118, 17);
            this.LineThicknessLabel.TabIndex = 14;
            this.LineThicknessLabel.Text = "Line Width";
            // 
            // LineThicknessIncrement
            // 
            this.LineThicknessIncrement.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LineThicknessIncrement.AutoSize = true;
            this.LineThicknessIncrement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(6)))), ((int)(((byte)(8)))));
            this.LineThicknessIncrement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineThicknessIncrement.Cursor = System.Windows.Forms.Cursors.Default;
            this.LineThicknessIncrement.Font = new System.Drawing.Font("Input", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineThicknessIncrement.ForeColor = System.Drawing.Color.Red;
            this.LineThicknessIncrement.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LineThicknessIncrement.Location = new System.Drawing.Point(134, 654);
            this.LineThicknessIncrement.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LineThicknessIncrement.Name = "LineThicknessIncrement";
            this.LineThicknessIncrement.Size = new System.Drawing.Size(120, 19);
            this.LineThicknessIncrement.TabIndex = 13;
            this.LineThicknessIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonTooltip.SetToolTip(this.LineThicknessIncrement, "Changes width of line\r\n(Min: 1 | Max: 100)\r\nShortcuts:\r\n   Increase: [Up Arrow]\r\n" +
        "   Decrease: [Down Arrow]\r\n");
            this.LineThicknessIncrement.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.LineThicknessIncrement.ValueChanged += new System.EventHandler(this.LineThicknessIncrement_ValueChanged);
            // 
            // Bool_Label_3
            // 
            this.Bool_Label_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bool_Label_3.AutoSize = true;
            this.Bool_Label_3.Font = new System.Drawing.Font("Input", 7F);
            this.Bool_Label_3.Location = new System.Drawing.Point(157, 966);
            this.Bool_Label_3.Name = "Bool_Label_3";
            this.Bool_Label_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bool_Label_3.Size = new System.Drawing.Size(41, 9);
            this.Bool_Label_3.TabIndex = 12;
            this.Bool_Label_3.Text = "Bool_3";
            this.Bool_Label_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Bool_Label_2
            // 
            this.Bool_Label_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bool_Label_2.AutoSize = true;
            this.Bool_Label_2.Font = new System.Drawing.Font("Input", 7F);
            this.Bool_Label_2.Location = new System.Drawing.Point(157, 929);
            this.Bool_Label_2.Name = "Bool_Label_2";
            this.Bool_Label_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bool_Label_2.Size = new System.Drawing.Size(41, 9);
            this.Bool_Label_2.TabIndex = 10;
            this.Bool_Label_2.Text = "Bool_2";
            this.Bool_Label_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Bool_Label_1
            // 
            this.Bool_Label_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bool_Label_1.AutoSize = true;
            this.Bool_Label_1.Font = new System.Drawing.Font("Input", 7F);
            this.Bool_Label_1.Location = new System.Drawing.Point(157, 892);
            this.Bool_Label_1.Name = "Bool_Label_1";
            this.Bool_Label_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bool_Label_1.Size = new System.Drawing.Size(41, 9);
            this.Bool_Label_1.TabIndex = 9;
            this.Bool_Label_1.Text = "Bool_1";
            this.Bool_Label_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Bool_Label_0
            // 
            this.Bool_Label_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bool_Label_0.AutoSize = true;
            this.Bool_Label_0.Font = new System.Drawing.Font("Input", 7F);
            this.Bool_Label_0.Location = new System.Drawing.Point(157, 855);
            this.Bool_Label_0.Name = "Bool_Label_0";
            this.Bool_Label_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bool_Label_0.Size = new System.Drawing.Size(41, 9);
            this.Bool_Label_0.TabIndex = 8;
            this.Bool_Label_0.Text = "Bool_0";
            this.Bool_Label_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(6)))), ((int)(((byte)(8)))));
            this.Canvas.BackgroundImage = global::Vector_Maths_Tool.Properties.Resources.backgroundSpeed;
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
            // Bool_Check_3
            // 
            this.Bool_Check_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bool_Check_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bool_Check_3.Location = new System.Drawing.Point(238, 962);
            this.Bool_Check_3.Name = "Bool_Check_3";
            this.Bool_Check_3.Size = new System.Drawing.Size(16, 16);
            this.Bool_Check_3.TabIndex = 11;
            this.Bool_Check_3.TabStop = false;
            // 
            // Bool_Check_1
            // 
            this.Bool_Check_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bool_Check_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bool_Check_1.Location = new System.Drawing.Point(238, 888);
            this.Bool_Check_1.Name = "Bool_Check_1";
            this.Bool_Check_1.Size = new System.Drawing.Size(16, 16);
            this.Bool_Check_1.TabIndex = 7;
            this.Bool_Check_1.TabStop = false;
            // 
            // Bool_Check_2
            // 
            this.Bool_Check_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bool_Check_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bool_Check_2.Location = new System.Drawing.Point(238, 925);
            this.Bool_Check_2.Name = "Bool_Check_2";
            this.Bool_Check_2.Size = new System.Drawing.Size(16, 16);
            this.Bool_Check_2.TabIndex = 6;
            this.Bool_Check_2.TabStop = false;
            // 
            // Bool_Check_0
            // 
            this.Bool_Check_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bool_Check_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bool_Check_0.Location = new System.Drawing.Point(238, 851);
            this.Bool_Check_0.Name = "Bool_Check_0";
            this.Bool_Check_0.Size = new System.Drawing.Size(16, 16);
            this.Bool_Check_0.TabIndex = 5;
            this.Bool_Check_0.TabStop = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(48, 36);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // Vector_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
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
            this.Load += new System.EventHandler(this.Vector_Form_Load);
            this.Button_Panel.ResumeLayout(false);
            this.Button_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineThicknessIncrement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bool_Check_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bool_Check_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bool_Check_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bool_Check_0)).EndInit();
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
        private System.Windows.Forms.Label Bool_Label_2;
        private System.Windows.Forms.Label Bool_Label_1;
        private System.Windows.Forms.Label Bool_Label_0;
        private System.Windows.Forms.PictureBox Bool_Check_1;
        private System.Windows.Forms.PictureBox Bool_Check_2;
        private System.Windows.Forms.PictureBox Bool_Check_0;
        private System.ComponentModel.BackgroundWorker UI_Delay;
        private System.Windows.Forms.Label Bool_Label_3;
        private System.Windows.Forms.PictureBox Bool_Check_3;
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
    }
}

