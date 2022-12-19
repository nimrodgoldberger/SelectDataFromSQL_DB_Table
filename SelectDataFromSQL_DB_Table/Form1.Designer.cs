namespace SelectDataFromSQL_DB_Table
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
            this._buttonGetAllUsersToGrid = new System.Windows.Forms.Button();
            this._dataGridViewSqlResult = new System.Windows.Forms.DataGridView();
            this._buttonOlderThan = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this._buttonGetConnectionString = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this._buttonGetAllUsersToMSGbox = new System.Windows.Forms.Button();
            this._textBoxResult = new System.Windows.Forms.TextBox();
            this._numericUpDownAGE = new System.Windows.Forms.NumericUpDown();
            this._textBoxNewName = new System.Windows.Forms.TextBox();
            this._labelNewName = new System.Windows.Forms.Label();
            this._numericUpDownYoungerThan = new System.Windows.Forms.NumericUpDown();
            this._labelYoungerThan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewSqlResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownAGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownYoungerThan)).BeginInit();
            this.SuspendLayout();
            // 
            // _buttonGetAllUsersToGrid
            // 
            this._buttonGetAllUsersToGrid.Location = new System.Drawing.Point(9, 9);
            this._buttonGetAllUsersToGrid.Name = "_buttonGetAllUsersToGrid";
            this._buttonGetAllUsersToGrid.Size = new System.Drawing.Size(97, 58);
            this._buttonGetAllUsersToGrid.TabIndex = 0;
            this._buttonGetAllUsersToGrid.Text = "Get all Usernames To Grid box";
            this._buttonGetAllUsersToGrid.UseVisualStyleBackColor = true;
            this._buttonGetAllUsersToGrid.Click += new System.EventHandler(this.button1_Click);
            // 
            // _dataGridViewSqlResult
            // 
            this._dataGridViewSqlResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewSqlResult.Location = new System.Drawing.Point(33, 183);
            this._dataGridViewSqlResult.Name = "_dataGridViewSqlResult";
            this._dataGridViewSqlResult.RowHeadersWidth = 62;
            this._dataGridViewSqlResult.Size = new System.Drawing.Size(755, 232);
            this._dataGridViewSqlResult.TabIndex = 1;
            this._dataGridViewSqlResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // _buttonOlderThan
            // 
            this._buttonOlderThan.Location = new System.Drawing.Point(110, 9);
            this._buttonOlderThan.Margin = new System.Windows.Forms.Padding(2);
            this._buttonOlderThan.Name = "_buttonOlderThan";
            this._buttonOlderThan.Size = new System.Drawing.Size(124, 36);
            this._buttonOlderThan.TabIndex = 2;
            this._buttonOlderThan.Text = "Get older than age";
            this._buttonOlderThan.UseVisualStyleBackColor = true;
            this._buttonOlderThan.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "Rename youngs";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // _buttonGetConnectionString
            // 
            this._buttonGetConnectionString.Location = new System.Drawing.Point(339, 9);
            this._buttonGetConnectionString.Margin = new System.Windows.Forms.Padding(2);
            this._buttonGetConnectionString.Name = "_buttonGetConnectionString";
            this._buttonGetConnectionString.Size = new System.Drawing.Size(97, 58);
            this._buttonGetConnectionString.TabIndex = 4;
            this._buttonGetConnectionString.Text = "Get connection string";
            this._buttonGetConnectionString.UseVisualStyleBackColor = true;
            this._buttonGetConnectionString.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(535, 9);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 55);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // _buttonGetAllUsersToMSGbox
            // 
            this._buttonGetAllUsersToMSGbox.Location = new System.Drawing.Point(440, 9);
            this._buttonGetAllUsersToMSGbox.Name = "_buttonGetAllUsersToMSGbox";
            this._buttonGetAllUsersToMSGbox.Size = new System.Drawing.Size(91, 55);
            this._buttonGetAllUsersToMSGbox.TabIndex = 6;
            this._buttonGetAllUsersToMSGbox.Text = "Get all Usernames To Message box";
            this._buttonGetAllUsersToMSGbox.UseVisualStyleBackColor = true;
            this._buttonGetAllUsersToMSGbox.Click += new System.EventHandler(this._buttonGetAllUsersToMSGbox_Click);
            // 
            // _textBoxResult
            // 
            this._textBoxResult.Location = new System.Drawing.Point(110, 76);
            this._textBoxResult.Multiline = true;
            this._textBoxResult.Name = "_textBoxResult";
            this._textBoxResult.ReadOnly = true;
            this._textBoxResult.Size = new System.Drawing.Size(118, 86);
            this._textBoxResult.TabIndex = 8;
            this._textBoxResult.TextChanged += new System.EventHandler(this._textBoxResult_TextChanged);
            // 
            // _numericUpDownAGE
            // 
            this._numericUpDownAGE.Location = new System.Drawing.Point(110, 53);
            this._numericUpDownAGE.Name = "_numericUpDownAGE";
            this._numericUpDownAGE.ReadOnly = true;
            this._numericUpDownAGE.Size = new System.Drawing.Size(78, 20);
            this._numericUpDownAGE.TabIndex = 9;
            this._numericUpDownAGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._numericUpDownAGE.ValueChanged += new System.EventHandler(this._numericUpDownAGE_ValueChanged);
            this._numericUpDownAGE.Leave += new System.EventHandler(this._numericUpDownAGE_LeftFocus);
            // 
            // _textBoxNewName
            // 
            this._textBoxNewName.Location = new System.Drawing.Point(238, 94);
            this._textBoxNewName.Multiline = true;
            this._textBoxNewName.Name = "_textBoxNewName";
            this._textBoxNewName.Size = new System.Drawing.Size(95, 25);
            this._textBoxNewName.TabIndex = 10;
            this._textBoxNewName.TextChanged += new System.EventHandler(this._textBoxNewName_TextChanged);
            // 
            // _labelNewName
            // 
            this._labelNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._labelNewName.Location = new System.Drawing.Point(240, 69);
            this._labelNewName.Name = "_labelNewName";
            this._labelNewName.Size = new System.Drawing.Size(93, 22);
            this._labelNewName.TabIndex = 11;
            this._labelNewName.Text = "New Name:";
            this._labelNewName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _numericUpDownYoungerThan
            // 
            this._numericUpDownYoungerThan.Location = new System.Drawing.Point(238, 152);
            this._numericUpDownYoungerThan.Name = "_numericUpDownYoungerThan";
            this._numericUpDownYoungerThan.ReadOnly = true;
            this._numericUpDownYoungerThan.Size = new System.Drawing.Size(95, 20);
            this._numericUpDownYoungerThan.TabIndex = 13;
            this._numericUpDownYoungerThan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._numericUpDownYoungerThan.ValueChanged += new System.EventHandler(this._numericUpDownYoungerThan_ValueChanged);
            // 
            // _labelYoungerThan
            // 
            this._labelYoungerThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._labelYoungerThan.Location = new System.Drawing.Point(238, 122);
            this._labelYoungerThan.Name = "_labelYoungerThan";
            this._labelYoungerThan.Size = new System.Drawing.Size(97, 27);
            this._labelYoungerThan.TabIndex = 14;
            this._labelYoungerThan.Text = "If Younger Than:";
            this._labelYoungerThan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._labelYoungerThan);
            this.Controls.Add(this._numericUpDownYoungerThan);
            this.Controls.Add(this._labelNewName);
            this.Controls.Add(this._textBoxNewName);
            this.Controls.Add(this._numericUpDownAGE);
            this.Controls.Add(this._textBoxResult);
            this.Controls.Add(this._buttonGetAllUsersToMSGbox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this._buttonGetConnectionString);
            this.Controls.Add(this.button3);
            this.Controls.Add(this._buttonOlderThan);
            this.Controls.Add(this._dataGridViewSqlResult);
            this.Controls.Add(this._buttonGetAllUsersToGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewSqlResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownAGE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownYoungerThan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonGetAllUsersToGrid;
        private System.Windows.Forms.DataGridView _dataGridViewSqlResult;
        private System.Windows.Forms.Button _buttonOlderThan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button _buttonGetConnectionString;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button _buttonGetAllUsersToMSGbox;
        private System.Windows.Forms.TextBox _textBoxResult;
        private System.Windows.Forms.NumericUpDown _numericUpDownAGE;
        private System.Windows.Forms.TextBox _textBoxNewName;
        private System.Windows.Forms.Label _labelNewName;
        private System.Windows.Forms.NumericUpDown _numericUpDownYoungerThan;
        private System.Windows.Forms.Label _labelYoungerThan;
    }
}

