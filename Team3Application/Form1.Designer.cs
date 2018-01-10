namespace Team3Application {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnExpand = new System.Windows.Forms.Button();
            this.LabelAccumulatorValue = new System.Windows.Forms.Label();
            this.TxtAccumulator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridMemory = new System.Windows.Forms.DataGridView();
            this.Chrono = new System.Windows.Forms.Timer(this.components);
            this.ConsoleBox = new System.Windows.Forms.GroupBox();
            this.Console = new System.Windows.Forms.TextBox();
            this.RTBoxMain = new System.Windows.Forms.RichTextBox();
            this.LblTextEditor = new System.Windows.Forms.Label();
            this.BtnTransferTEtoP = new System.Windows.Forms.Button();
            this.BtnTransferPtoTE = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Menu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnExpand);
            this.groupBox1.Controls.Add(this.LabelAccumulatorValue);
            this.groupBox1.Controls.Add(this.TxtAccumulator);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine State";
            // 
            // BtnExpand
            // 
            this.BtnExpand.Location = new System.Drawing.Point(433, 13);
            this.BtnExpand.Name = "BtnExpand";
            this.BtnExpand.Size = new System.Drawing.Size(114, 23);
            this.BtnExpand.TabIndex = 4;
            this.BtnExpand.Text = "Show Text Editor";
            this.BtnExpand.UseVisualStyleBackColor = true;
            this.BtnExpand.Click += new System.EventHandler(this.BtnExpand_Click);
            // 
            // LabelAccumulatorValue
            // 
            this.LabelAccumulatorValue.AutoSize = true;
            this.LabelAccumulatorValue.Location = new System.Drawing.Point(197, 16);
            this.LabelAccumulatorValue.MaximumSize = new System.Drawing.Size(130, 0);
            this.LabelAccumulatorValue.MinimumSize = new System.Drawing.Size(130, 0);
            this.LabelAccumulatorValue.Name = "LabelAccumulatorValue";
            this.LabelAccumulatorValue.Size = new System.Drawing.Size(130, 13);
            this.LabelAccumulatorValue.TabIndex = 2;
            this.LabelAccumulatorValue.Text = "0";
            // 
            // TxtAccumulator
            // 
            this.TxtAccumulator.Enabled = false;
            this.TxtAccumulator.Location = new System.Drawing.Point(91, 13);
            this.TxtAccumulator.Name = "TxtAccumulator";
            this.TxtAccumulator.ReadOnly = true;
            this.TxtAccumulator.Size = new System.Drawing.Size(100, 20);
            this.TxtAccumulator.TabIndex = 1;
            this.TxtAccumulator.Text = "00000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accumulator:";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(943, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.stepToolStripMenuItem,
            this.toolStripSeparator2,
            this.resetToolStripMenuItem,
            this.memDumpToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.stepToolStripMenuItem.Text = "Step";
            this.stepToolStripMenuItem.Click += new System.EventHandler(this.stepToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // memDumpToolStripMenuItem
            // 
            this.memDumpToolStripMenuItem.Name = "memDumpToolStripMenuItem";
            this.memDumpToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.memDumpToolStripMenuItem.Text = "Mem Dump";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridMemory);
            this.groupBox2.Location = new System.Drawing.Point(13, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 470);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Memory";
            // 
            // GridMemory
            // 
            this.GridMemory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMemory.Location = new System.Drawing.Point(8, 19);
            this.GridMemory.MultiSelect = false;
            this.GridMemory.Name = "GridMemory";
            this.GridMemory.Size = new System.Drawing.Size(538, 466);
            this.GridMemory.TabIndex = 0;
            // 
            // Chrono
            // 
            this.Chrono.Interval = 1;
            this.Chrono.Tick += new System.EventHandler(this.Chrono_Tick);
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Location = new System.Drawing.Point(13, 576);
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.Size = new System.Drawing.Size(552, 76);
            this.ConsoleBox.TabIndex = 3;
            this.ConsoleBox.TabStop = false;
            this.ConsoleBox.Text = "Console";
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Console.ForeColor = System.Drawing.SystemColors.Window;
            this.Console.Location = new System.Drawing.Point(21, 600);
            this.Console.Multiline = true;
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.Size = new System.Drawing.Size(538, 43);
            this.Console.TabIndex = 0;
            this.Console.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Console_KeyDown);
            // 
            // RTBoxMain
            // 
            this.RTBoxMain.Location = new System.Drawing.Point(592, 99);
            this.RTBoxMain.Name = "RTBoxMain";
            this.RTBoxMain.Size = new System.Drawing.Size(327, 408);
            this.RTBoxMain.TabIndex = 4;
            this.RTBoxMain.Text = "";
            // 
            // LblTextEditor
            // 
            this.LblTextEditor.AutoSize = true;
            this.LblTextEditor.Location = new System.Drawing.Point(690, 74);
            this.LblTextEditor.Name = "LblTextEditor";
            this.LblTextEditor.Size = new System.Drawing.Size(73, 13);
            this.LblTextEditor.TabIndex = 5;
            this.LblTextEditor.Text = "Text Editor";
            // 
            // BtnTransferTEtoP
            // 
            this.BtnTransferTEtoP.Location = new System.Drawing.Point(844, 513);
            this.BtnTransferTEtoP.Name = "BtnTransferTEtoP";
            this.BtnTransferTEtoP.Size = new System.Drawing.Size(75, 23);
            this.BtnTransferTEtoP.TabIndex = 6;
            this.BtnTransferTEtoP.Text = "Transfer";
            this.BtnTransferTEtoP.UseVisualStyleBackColor = true;
            this.BtnTransferTEtoP.Click += new System.EventHandler(this.BtnTransferTEtoP_Click);
            // 
            // BtnTransferPtoTE
            // 
            this.BtnTransferPtoTE.Location = new System.Drawing.Point(844, 542);
            this.BtnTransferPtoTE.Name = "BtnTransferPtoTE";
            this.BtnTransferPtoTE.Size = new System.Drawing.Size(75, 23);
            this.BtnTransferPtoTE.TabIndex = 7;
            this.BtnTransferPtoTE.Text = "Transfer";
            this.BtnTransferPtoTE.UseVisualStyleBackColor = true;
            this.BtnTransferPtoTE.Click += new System.EventHandler(this.BtnTransferPtoTE_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(844, 571);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 8;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Transfer current program to Text Editor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Transfer from Text Editor to Program\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 576);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Load data into text editor from .txt file";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(844, 629);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 12;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 634);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Clear all data inside Text Editor";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(844, 600);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(589, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Save data from Text Editor to .txt file";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(779, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "i";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 676);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnTransferPtoTE);
            this.Controls.Add(this.BtnTransferTEtoP);
            this.Controls.Add(this.LblTextEditor);
            this.Controls.Add(this.RTBoxMain);
            this.Controls.Add(this.ConsoleBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "UVUSim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridMemory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtAccumulator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelAccumulatorValue;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridMemory;
        private System.Windows.Forms.Timer Chrono;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memDumpToolStripMenuItem;
        private System.Windows.Forms.GroupBox ConsoleBox;
        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.Button BtnExpand;
        private System.Windows.Forms.RichTextBox RTBoxMain;
        private System.Windows.Forms.Label LblTextEditor;
        private System.Windows.Forms.Button BtnTransferTEtoP;
        private System.Windows.Forms.Button BtnTransferPtoTE;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

