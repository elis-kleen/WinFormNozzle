namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.Create = new System.Windows.Forms.Button();
            this.Events = new System.Windows.Forms.ComboBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NozzleId = new System.Windows.Forms.TextBox();
            this.ConfirmCreate = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Nozzle_Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ShowEvents = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ShowNeedChange = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ListBoxNeedChange = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nozzleTestDataSet = new WindowsFormsApplication4.NozzleTestDataSet();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nozzleTestDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.White;
            this.Create.Location = new System.Drawing.Point(9, 196);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(92, 25);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            this.Create.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyPressedCreateEvent);
            // 
            // Events
            // 
            this.Events.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Events.FormattingEnabled = true;
            this.Events.Items.AddRange(new object[] {
            "Line",
            "Wash",
            "Park"});
            this.Events.Location = new System.Drawing.Point(6, 86);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(121, 21);
            this.Events.TabIndex = 2;
            this.Events.SelectedIndexChanged += new System.EventHandler(this.Events_SelectedIndexChanged);
            this.Events.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyPressedCreateEvent);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(6, 146);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 5;
            this.DatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.DatePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyPressedCreateEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Event Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nozzle Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date Of Event";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 259);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.NozzleId);
            this.tabPage1.Controls.Add(this.ConfirmCreate);
            this.tabPage1.Controls.Add(this.Events);
            this.tabPage1.Controls.Add(this.Create);
            this.tabPage1.Controls.Add(this.DatePicker);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Event";
            // 
            // NozzleId
            // 
            this.NozzleId.Location = new System.Drawing.Point(6, 31);
            this.NozzleId.Name = "NozzleId";
            this.NozzleId.Size = new System.Drawing.Size(100, 20);
            this.NozzleId.TabIndex = 11;
            this.NozzleId.TextChanged += new System.EventHandler(this.NozzleId_TextChanged);
            this.NozzleId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyPressedCreateEvent);
            // 
            // ConfirmCreate
            // 
            this.ConfirmCreate.FormattingEnabled = true;
            this.ConfirmCreate.Location = new System.Drawing.Point(193, 31);
            this.ConfirmCreate.Name = "ConfirmCreate";
            this.ConfirmCreate.Size = new System.Drawing.Size(142, 30);
            this.ConfirmCreate.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Nozzle_Id);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.ShowEvents);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 233);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Show Events";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Nozzle_Id
            // 
            this.Nozzle_Id.Location = new System.Drawing.Point(12, 29);
            this.Nozzle_Id.Name = "Nozzle_Id";
            this.Nozzle_Id.Size = new System.Drawing.Size(100, 20);
            this.Nozzle_Id.TabIndex = 5;
            this.Nozzle_Id.TextChanged += new System.EventHandler(this.Nozzle_Id_TextChanged);
            this.Nozzle_Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyPressedShowEvents);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Events";
            // 
            // listBox1
            // 
            this.listBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 147);
            this.listBox1.TabIndex = 3;
            // 
            // ShowEvents
            // 
            this.ShowEvents.Location = new System.Drawing.Point(149, 29);
            this.ShowEvents.Name = "ShowEvents";
            this.ShowEvents.Size = new System.Drawing.Size(85, 23);
            this.ShowEvents.TabIndex = 2;
            this.ShowEvents.Text = "Show Events";
            this.ShowEvents.UseVisualStyleBackColor = true;
            this.ShowEvents.Click += new System.EventHandler(this.button1_Click);
            this.ShowEvents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyPressedShowEvents);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nozzle Id";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ShowNeedChange);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.ListBoxNeedChange);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(346, 233);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Check For Change";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ShowNeedChange
            // 
            this.ShowNeedChange.Location = new System.Drawing.Point(234, 44);
            this.ShowNeedChange.Name = "ShowNeedChange";
            this.ShowNeedChange.Size = new System.Drawing.Size(82, 20);
            this.ShowNeedChange.TabIndex = 4;
            this.ShowNeedChange.Text = "Show Nozzles";
            this.ShowNeedChange.UseVisualStyleBackColor = true;
            this.ShowNeedChange.Click += new System.EventHandler(this.ShowNeedChange_Click);
            this.ShowNeedChange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyPressedShowNeedChange);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nozzles Needing Change";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyPressedShowNeedChange);
            // 
            // ListBoxNeedChange
            // 
            this.ListBoxNeedChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBoxNeedChange.FormattingEnabled = true;
            this.ListBoxNeedChange.Location = new System.Drawing.Point(9, 117);
            this.ListBoxNeedChange.Name = "ListBoxNeedChange";
            this.ListBoxNeedChange.Size = new System.Drawing.Size(127, 108);
            this.ListBoxNeedChange.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Choose Date";
            // 
            // nozzleTestDataSet
            // 
            this.nozzleTestDataSet.DataSetName = "NozzleTestDataSet";
            this.nozzleTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 258);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Nozzle logger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nozzleTestDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Create;
        public System.Windows.Forms.ComboBox Events;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ShowEvents;
        private NozzleTestDataSet nozzleTestDataSet;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox ListBoxNeedChange;
        private System.Windows.Forms.Button ShowNeedChange;
        private System.Windows.Forms.ListBox ConfirmCreate;
        private System.Windows.Forms.TextBox NozzleId;
        private System.Windows.Forms.TextBox Nozzle_Id;
    }
}

