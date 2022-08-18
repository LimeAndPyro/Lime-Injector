namespace LimesInjector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Toppanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleLable = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Pathtext = new System.Windows.Forms.TextBox();
            this.DllButton = new System.Windows.Forms.Button();
            this.InjectButton = new System.Windows.Forms.Button();
            this.ProcessList = new System.Windows.Forms.ComboBox();
            this.TextStatus = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.resulttext = new System.Windows.Forms.TextBox();
            this.Toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.Black;
            this.Toppanel.Controls.Add(this.label1);
            this.Toppanel.Controls.Add(this.TitleLable);
            this.Toppanel.Controls.Add(this.CloseButton);
            this.Toppanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Font = new System.Drawing.Font("Gabriola", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(354, 28);
            this.Toppanel.TabIndex = 0;
            this.Toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Toppanel_MouseDown);
            this.Toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Toppanel_MouseMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Gabriola", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(296, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "--";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.BackColor = System.Drawing.Color.Transparent;
            this.TitleLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TitleLable.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLable.ForeColor = System.Drawing.Color.Lime;
            this.TitleLable.Location = new System.Drawing.Point(0, 3);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(89, 29);
            this.TitleLable.TabIndex = 1;
            this.TitleLable.Text = "lime Injector";
            this.TitleLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TitleLable.Click += new System.EventHandler(this.TitleLable_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Font = new System.Drawing.Font("Gabriola", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.Lime;
            this.CloseButton.Location = new System.Drawing.Point(327, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 28);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Pathtext
            // 
            this.Pathtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Pathtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pathtext.Font = new System.Drawing.Font("SimSun", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Pathtext.ForeColor = System.Drawing.Color.Lime;
            this.Pathtext.Location = new System.Drawing.Point(3, 37);
            this.Pathtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pathtext.Name = "Pathtext";
            this.Pathtext.Size = new System.Drawing.Size(260, 15);
            this.Pathtext.TabIndex = 1;
            this.Pathtext.Text = "Path To DLL";
            // 
            // DllButton
            // 
            this.DllButton.AutoSize = true;
            this.DllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DllButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DllButton.Font = new System.Drawing.Font("SimSun", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DllButton.ForeColor = System.Drawing.Color.Lime;
            this.DllButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DllButton.Location = new System.Drawing.Point(268, 34);
            this.DllButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.DllButton.Name = "DllButton";
            this.DllButton.Size = new System.Drawing.Size(76, 23);
            this.DllButton.TabIndex = 2;
            this.DllButton.Text = "Find DLL";
            this.DllButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DllButton.UseVisualStyleBackColor = false;
            this.DllButton.Click += new System.EventHandler(this.DllButton_Click);
            // 
            // InjectButton
            // 
            this.InjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.InjectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InjectButton.FlatAppearance.BorderSize = 0;
            this.InjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InjectButton.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InjectButton.ForeColor = System.Drawing.Color.Lime;
            this.InjectButton.Location = new System.Drawing.Point(3, 82);
            this.InjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InjectButton.Name = "InjectButton";
            this.InjectButton.Size = new System.Drawing.Size(341, 26);
            this.InjectButton.TabIndex = 4;
            this.InjectButton.Text = "INJECT";
            this.InjectButton.UseVisualStyleBackColor = false;
            this.InjectButton.Click += new System.EventHandler(this.InjectButton_Click);
            // 
            // ProcessList
            // 
            this.ProcessList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ProcessList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProcessList.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProcessList.ForeColor = System.Drawing.Color.Lime;
            this.ProcessList.FormattingEnabled = true;
            this.ProcessList.Location = new System.Drawing.Point(3, 58);
            this.ProcessList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(342, 20);
            this.ProcessList.TabIndex = 3;
            this.ProcessList.Text = "Select Process To Inject";
            // 
            // TextStatus
            // 
            this.TextStatus.BackColor = System.Drawing.Color.Black;
            this.TextStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextStatus.Font = new System.Drawing.Font("SimSun", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TextStatus.ForeColor = System.Drawing.Color.Lime;
            this.TextStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextStatus.Location = new System.Drawing.Point(4, 142);
            this.TextStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextStatus.Name = "TextStatus";
            this.TextStatus.Size = new System.Drawing.Size(341, 16);
            this.TextStatus.TabIndex = 5;
            this.TextStatus.Text = "Injection Status ";
            this.TextStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh.FlatAppearance.BorderSize = 0;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Refresh.ForeColor = System.Drawing.Color.Lime;
            this.Refresh.Location = new System.Drawing.Point(3, 112);
            this.Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(341, 26);
            this.Refresh.TabIndex = 6;
            this.Refresh.Text = "Refresh Process List";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // resulttext
            // 
            this.resulttext.BackColor = System.Drawing.Color.Black;
            this.resulttext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resulttext.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resulttext.ForeColor = System.Drawing.Color.Lime;
            this.resulttext.Location = new System.Drawing.Point(4, 163);
            this.resulttext.Name = "resulttext";
            this.resulttext.Size = new System.Drawing.Size(341, 19);
            this.resulttext.TabIndex = 7;
            this.resulttext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(354, 193);
            this.Controls.Add(this.resulttext);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.TextStatus);
            this.Controls.Add(this.InjectButton);
            this.Controls.Add(this.ProcessList);
            this.Controls.Add(this.DllButton);
            this.Controls.Add(this.Pathtext);
            this.Controls.Add(this.Toppanel);
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lime Injector";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Toppanel.ResumeLayout(false);
            this.Toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Toppanel;
        private Label CloseButton;
        private Label TitleLable;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private TextBox Pathtext;
        private Button DllButton;
        private Button InjectButton;
        private ComboBox ProcessList;
        private TextBox TextStatus;
        private Button Refresh;
        private TextBox resulttext;
    }
}