namespace Clicker
{
    partial class FormAdvanced
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
   

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdvanced));
            this.labelMouseXY = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelClick = new System.Windows.Forms.Label();
            this.buttonDetector = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPositionMouseX = new System.Windows.Forms.TextBox();
            this.labelKeyboardHook = new System.Windows.Forms.Label();
            this.labelPositionMouseX = new System.Windows.Forms.Label();
            this.labelPositionMouseY = new System.Windows.Forms.Label();
            this.textBoxPositionMouseY = new System.Windows.Forms.TextBox();
            this.labelTimeClick = new System.Windows.Forms.Label();
            this.textBoxTimeClick = new System.Windows.Forms.TextBox();
            this.panelMouseMove = new System.Windows.Forms.Panel();
            this.panelMainFormCopy = new System.Windows.Forms.Panel();
            this.panelMainFormCopy_2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMouseXY
            // 
            this.labelMouseXY.AutoSize = true;
            this.labelMouseXY.Font = new System.Drawing.Font("Cascadia Mono", 13.8F);
            this.labelMouseXY.Location = new System.Drawing.Point(169, 72);
            this.labelMouseXY.Name = "labelMouseXY";
            this.labelMouseXY.Size = new System.Drawing.Size(52, 30);
            this.labelMouseXY.TabIndex = 2;
            this.labelMouseXY.Text = "0;0";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(134, 100);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.closingToolStripMenuItem.Text = "Closing";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // labelClick
            // 
            this.labelClick.AutoSize = true;
            this.labelClick.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClick.Location = new System.Drawing.Point(12, 20);
            this.labelClick.Name = "labelClick";
            this.labelClick.Size = new System.Drawing.Size(130, 30);
            this.labelClick.TabIndex = 5;
            this.labelClick.Text = "Click ---";
            // 
            // buttonDetector
            // 
            this.buttonDetector.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDetector.Location = new System.Drawing.Point(161, 10);
            this.buttonDetector.Name = "buttonDetector";
            this.buttonDetector.Size = new System.Drawing.Size(70, 50);
            this.buttonDetector.TabIndex = 4;
            this.buttonDetector.Text = "Off";
            this.buttonDetector.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 13.8F);
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Keyboard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 13.8F);
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mouse";
            // 
            // textBoxPositionMouseX
            // 
            this.textBoxPositionMouseX.Location = new System.Drawing.Point(235, 160);
            this.textBoxPositionMouseX.Name = "textBoxPositionMouseX";
            this.textBoxPositionMouseX.Size = new System.Drawing.Size(100, 22);
            this.textBoxPositionMouseX.TabIndex = 8;
            // 
            // labelKeyboardHook
            // 
            this.labelKeyboardHook.AutoSize = true;
            this.labelKeyboardHook.Font = new System.Drawing.Font("Cascadia Mono", 13.8F);
            this.labelKeyboardHook.Location = new System.Drawing.Point(169, 112);
            this.labelKeyboardHook.Name = "labelKeyboardHook";
            this.labelKeyboardHook.Size = new System.Drawing.Size(26, 30);
            this.labelKeyboardHook.TabIndex = 9;
            this.labelKeyboardHook.Text = "-";
            // 
            // labelPositionMouseX
            // 
            this.labelPositionMouseX.AutoSize = true;
            this.labelPositionMouseX.Font = new System.Drawing.Font("Cascadia Mono", 13.8F);
            this.labelPositionMouseX.Location = new System.Drawing.Point(12, 160);
            this.labelPositionMouseX.Name = "labelPositionMouseX";
            this.labelPositionMouseX.Size = new System.Drawing.Size(195, 30);
            this.labelPositionMouseX.TabIndex = 10;
            this.labelPositionMouseX.Text = "PositionMouseX";
            // 
            // labelPositionMouseY
            // 
            this.labelPositionMouseY.AutoSize = true;
            this.labelPositionMouseY.Font = new System.Drawing.Font("Cascadia Mono", 13.8F);
            this.labelPositionMouseY.Location = new System.Drawing.Point(12, 199);
            this.labelPositionMouseY.Name = "labelPositionMouseY";
            this.labelPositionMouseY.Size = new System.Drawing.Size(195, 30);
            this.labelPositionMouseY.TabIndex = 12;
            this.labelPositionMouseY.Text = "PositionMouseY";
            // 
            // textBoxPositionMouseY
            // 
            this.textBoxPositionMouseY.Location = new System.Drawing.Point(235, 199);
            this.textBoxPositionMouseY.Name = "textBoxPositionMouseY";
            this.textBoxPositionMouseY.Size = new System.Drawing.Size(100, 22);
            this.textBoxPositionMouseY.TabIndex = 11;
            // 
            // labelTimeClick
            // 
            this.labelTimeClick.AutoSize = true;
            this.labelTimeClick.Font = new System.Drawing.Font("Cascadia Mono", 13.8F);
            this.labelTimeClick.Location = new System.Drawing.Point(12, 237);
            this.labelTimeClick.Name = "labelTimeClick";
            this.labelTimeClick.Size = new System.Drawing.Size(130, 30);
            this.labelTimeClick.TabIndex = 14;
            this.labelTimeClick.Text = "TimeClick";
            // 
            // textBoxTimeClick
            // 
            this.textBoxTimeClick.Location = new System.Drawing.Point(235, 237);
            this.textBoxTimeClick.Name = "textBoxTimeClick";
            this.textBoxTimeClick.Size = new System.Drawing.Size(100, 22);
            this.textBoxTimeClick.TabIndex = 13;
            // 
            // panelMouseMove
            // 
            this.panelMouseMove.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMouseMove.Location = new System.Drawing.Point(0, 0);
            this.panelMouseMove.Name = "panelMouseMove";
            this.panelMouseMove.Size = new System.Drawing.Size(25, 25);
            this.panelMouseMove.TabIndex = 15;
            // 
            // panelMainFormCopy
            // 
            this.panelMainFormCopy.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelMainFormCopy.Location = new System.Drawing.Point(0, 0);
            this.panelMainFormCopy.Name = "panelMainFormCopy";
            this.panelMainFormCopy.Size = new System.Drawing.Size(10, 80);
            this.panelMainFormCopy.TabIndex = 16;
            // 
            // panelMainFormCopy_2
            // 
            this.panelMainFormCopy_2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelMainFormCopy_2.Location = new System.Drawing.Point(0, 0);
            this.panelMainFormCopy_2.Name = "panelMainFormCopy_2";
            this.panelMainFormCopy_2.Size = new System.Drawing.Size(258, 10);
            this.panelMainFormCopy_2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 13.8F);
            this.label1.Location = new System.Drawing.Point(341, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 120);
            this.label1.TabIndex = 18;
            this.label1.Text = "s\r\na\r\nv\r\ne";
            // 
            // FormAdvanced
            // 
            this.ClientSize = new System.Drawing.Size(373, 282);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMainFormCopy_2);
            this.Controls.Add(this.panelMainFormCopy);
            this.Controls.Add(this.panelMouseMove);
            this.Controls.Add(this.labelTimeClick);
            this.Controls.Add(this.textBoxTimeClick);
            this.Controls.Add(this.labelPositionMouseY);
            this.Controls.Add(this.textBoxPositionMouseY);
            this.Controls.Add(this.labelPositionMouseX);
            this.Controls.Add(this.labelKeyboardHook);
            this.Controls.Add(this.textBoxPositionMouseX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelClick);
            this.Controls.Add(this.buttonDetector);
            this.Controls.Add(this.labelMouseXY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdvanced";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdvanced_FormClosed);
            this.Load += new System.EventHandler(this.FormAdvanced_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAdvanced_MouseDown);
            this.MouseEnter += new System.EventHandler(this.FormAdvanced_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FormAdvanced_MouseLeave);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMouseXY;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelClick;
        private System.Windows.Forms.Button buttonDetector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPositionMouseX;
        private System.Windows.Forms.Label labelKeyboardHook;
        private System.Windows.Forms.Label labelPositionMouseX;
        private System.Windows.Forms.Label labelPositionMouseY;
        private System.Windows.Forms.TextBox textBoxPositionMouseY;
        private System.Windows.Forms.Label labelTimeClick;
        private System.Windows.Forms.TextBox textBoxTimeClick;
        private System.Windows.Forms.Panel panelMouseMove;
        private System.Windows.Forms.Panel panelMainFormCopy;
        private System.Windows.Forms.Panel panelMainFormCopy_2;
        private System.Windows.Forms.Label label1;
    }
}
