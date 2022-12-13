
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vector_Form));
            this.ExitButton = new System.Windows.Forms.Button();
            this.HeaderText_1 = new System.Windows.Forms.Label();
            this.TimerButton = new System.Windows.Forms.Button();
            this.TimerWorker = new System.ComponentModel.BackgroundWorker();
            this.CreateVector = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Canvas = new System.Windows.Forms.Panel();
            this.Button_Panel = new System.Windows.Forms.Panel();
            this.Bool_Label_2 = new System.Windows.Forms.Label();
            this.Bool_Label_1 = new System.Windows.Forms.Label();
            this.Bool_Label_0 = new System.Windows.Forms.Label();
            this.Bool_Check_1 = new System.Windows.Forms.PictureBox();
            this.Bool_Check_2 = new System.Windows.Forms.PictureBox();
            this.Bool_Check_0 = new System.Windows.Forms.PictureBox();
            this.UI_Delay = new System.ComponentModel.BackgroundWorker();
            this.Button_Panel.SuspendLayout();
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
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Input", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(159, 1018);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExitButton.Size = new System.Drawing.Size(88, 32);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "CLOSE";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.TimerButton.Location = new System.Drawing.Point(17, 29);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(232, 39);
            this.TimerButton.TabIndex = 2;
            this.TimerButton.Text = "Timer";
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
            // CreateVector
            // 
            this.CreateVector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateVector.AutoSize = true;
            this.CreateVector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.CreateVector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateVector.Font = new System.Drawing.Font("Input", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateVector.Location = new System.Drawing.Point(17, 99);
            this.CreateVector.Name = "CreateVector";
            this.CreateVector.Size = new System.Drawing.Size(232, 39);
            this.CreateVector.TabIndex = 3;
            this.CreateVector.Text = "Create Vector";
            this.CreateVector.UseVisualStyleBackColor = false;
            this.CreateVector.Click += new System.EventHandler(this.CreateVector_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.AutoSize = true;
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Font = new System.Drawing.Font("Input", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(17, 169);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(232, 39);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear Screen";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.AutoSize = true;
            this.Canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Canvas.Location = new System.Drawing.Point(11, 28);
            this.Canvas.Margin = new System.Windows.Forms.Padding(2);
            this.Canvas.Name = "Canvas";
            this.Canvas.Padding = new System.Windows.Forms.Padding(2);
            this.Canvas.Size = new System.Drawing.Size(1635, 1041);
            this.Canvas.TabIndex = 5;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // Button_Panel
            // 
            this.Button_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Panel.AutoSize = true;
            this.Button_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.Button_Panel.Controls.Add(this.Bool_Label_2);
            this.Button_Panel.Controls.Add(this.Bool_Label_1);
            this.Button_Panel.Controls.Add(this.Bool_Label_0);
            this.Button_Panel.Controls.Add(this.Bool_Check_1);
            this.Button_Panel.Controls.Add(this.Bool_Check_2);
            this.Button_Panel.Controls.Add(this.Bool_Check_0);
            this.Button_Panel.Controls.Add(this.TimerButton);
            this.Button_Panel.Controls.Add(this.ClearButton);
            this.Button_Panel.Controls.Add(this.CreateVector);
            this.Button_Panel.Controls.Add(this.ExitButton);
            this.Button_Panel.Location = new System.Drawing.Point(1650, 14);
            this.Button_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Panel.Name = "Button_Panel";
            this.Button_Panel.Padding = new System.Windows.Forms.Padding(2);
            this.Button_Panel.Size = new System.Drawing.Size(259, 1055);
            this.Button_Panel.TabIndex = 6;
            // 
            // Bool_Label_2
            // 
            this.Bool_Label_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bool_Label_2.AutoSize = true;
            this.Bool_Label_2.Font = new System.Drawing.Font("Input", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bool_Label_2.Location = new System.Drawing.Point(131, 980);
            this.Bool_Label_2.Name = "Bool_Label_2";
            this.Bool_Label_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bool_Label_2.Size = new System.Drawing.Size(53, 12);
            this.Bool_Label_2.TabIndex = 10;
            this.Bool_Label_2.Text = "Bool_2";
            this.Bool_Label_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Bool_Label_1
            // 
            this.Bool_Label_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bool_Label_1.AutoSize = true;
            this.Bool_Label_1.Font = new System.Drawing.Font("Input", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bool_Label_1.Location = new System.Drawing.Point(131, 945);
            this.Bool_Label_1.Name = "Bool_Label_1";
            this.Bool_Label_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bool_Label_1.Size = new System.Drawing.Size(53, 12);
            this.Bool_Label_1.TabIndex = 9;
            this.Bool_Label_1.Text = "Bool_1";
            this.Bool_Label_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Bool_Label_0
            // 
            this.Bool_Label_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bool_Label_0.AutoSize = true;
            this.Bool_Label_0.Font = new System.Drawing.Font("Input", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bool_Label_0.Location = new System.Drawing.Point(131, 910);
            this.Bool_Label_0.Name = "Bool_Label_0";
            this.Bool_Label_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bool_Label_0.Size = new System.Drawing.Size(53, 12);
            this.Bool_Label_0.TabIndex = 8;
            this.Bool_Label_0.Text = "Bool_0";
            this.Bool_Label_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Bool_Check_1
            // 
            this.Bool_Check_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bool_Check_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bool_Check_1.Location = new System.Drawing.Point(231, 943);
            this.Bool_Check_1.Name = "Bool_Check_1";
            this.Bool_Check_1.Size = new System.Drawing.Size(16, 16);
            this.Bool_Check_1.TabIndex = 7;
            this.Bool_Check_1.TabStop = false;
            // 
            // Bool_Check_2
            // 
            this.Bool_Check_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bool_Check_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bool_Check_2.Location = new System.Drawing.Point(231, 978);
            this.Bool_Check_2.Name = "Bool_Check_2";
            this.Bool_Check_2.Size = new System.Drawing.Size(16, 16);
            this.Bool_Check_2.TabIndex = 6;
            this.Bool_Check_2.TabStop = false;
            // 
            // Bool_Check_0
            // 
            this.Bool_Check_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bool_Check_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bool_Check_0.Location = new System.Drawing.Point(231, 908);
            this.Bool_Check_0.Name = "Bool_Check_0";
            this.Bool_Check_0.Size = new System.Drawing.Size(16, 16);
            this.Bool_Check_0.TabIndex = 5;
            this.Bool_Check_0.TabStop = false;
            // 
            // Vector_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Button_Panel);
            this.Controls.Add(this.Canvas);
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
        private System.Windows.Forms.Button CreateVector;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Panel Button_Panel;
        private System.Windows.Forms.Label Bool_Label_2;
        private System.Windows.Forms.Label Bool_Label_1;
        private System.Windows.Forms.Label Bool_Label_0;
        private System.Windows.Forms.PictureBox Bool_Check_1;
        private System.Windows.Forms.PictureBox Bool_Check_2;
        private System.Windows.Forms.PictureBox Bool_Check_0;
        private System.ComponentModel.BackgroundWorker UI_Delay;
    }
}

