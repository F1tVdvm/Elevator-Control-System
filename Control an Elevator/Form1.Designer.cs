namespace Control_an_Elevator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.controlPanel = new System.Windows.Forms.GroupBox();
            this.DisplayWindow = new System.Windows.Forms.PictureBox();
            this.btnOnGroundFloor = new System.Windows.Forms.Button();
            this.WindowDisplay2 = new System.Windows.Forms.PictureBox();
            this.btnOnFirstFloor = new System.Windows.Forms.Button();
            this.Logs = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.btnDisplayLogs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnWall1 = new System.Windows.Forms.Button();
            this.btnWall0 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowDisplay2)).BeginInit();
            this.Logs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.DisplayWindow);
            this.controlPanel.Controls.Add(this.btnOnGroundFloor);
            this.controlPanel.Controls.Add(this.WindowDisplay2);
            this.controlPanel.Controls.Add(this.btnOnFirstFloor);
            this.controlPanel.Location = new System.Drawing.Point(533, 155);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(200, 406);
            this.controlPanel.TabIndex = 0;
            this.controlPanel.TabStop = false;
            this.controlPanel.Text = "Control Panel";
            // 
            // DisplayWindow
            // 
            this.DisplayWindow.Image = global::Control_an_Elevator.Properties.Resources.GroundFloor;
            this.DisplayWindow.Location = new System.Drawing.Point(48, 93);
            this.DisplayWindow.Name = "DisplayWindow";
            this.DisplayWindow.Size = new System.Drawing.Size(98, 61);
            this.DisplayWindow.TabIndex = 7;
            this.DisplayWindow.TabStop = false;
            // 
            // btnOnGroundFloor
            // 
            this.btnOnGroundFloor.Location = new System.Drawing.Point(48, 184);
            this.btnOnGroundFloor.Name = "btnOnGroundFloor";
            this.btnOnGroundFloor.Size = new System.Drawing.Size(98, 35);
            this.btnOnGroundFloor.TabIndex = 6;
            this.btnOnGroundFloor.Text = "1";
            this.btnOnGroundFloor.UseVisualStyleBackColor = true;
            this.btnOnGroundFloor.Click += new System.EventHandler(this.btnOnGroundFloor_Click);
            // 
            // WindowDisplay2
            // 
            this.WindowDisplay2.Image = global::Control_an_Elevator.Properties.Resources.FirstFloor;
            this.WindowDisplay2.Location = new System.Drawing.Point(48, 93);
            this.WindowDisplay2.Name = "WindowDisplay2";
            this.WindowDisplay2.Size = new System.Drawing.Size(98, 61);
            this.WindowDisplay2.TabIndex = 8;
            this.WindowDisplay2.TabStop = false;
            // 
            // btnOnFirstFloor
            // 
            this.btnOnFirstFloor.Location = new System.Drawing.Point(48, 262);
            this.btnOnFirstFloor.Name = "btnOnFirstFloor";
            this.btnOnFirstFloor.Size = new System.Drawing.Size(98, 35);
            this.btnOnFirstFloor.TabIndex = 5;
            this.btnOnFirstFloor.Text = "0";
            this.btnOnFirstFloor.UseVisualStyleBackColor = true;
            this.btnOnFirstFloor.Click += new System.EventHandler(this.btnOnFirstFloor_Click);
            // 
            // Logs
            // 
            this.Logs.Controls.Add(this.dataGrid);
            this.Logs.Controls.Add(this.checkBox1);
            this.Logs.Controls.Add(this.btnClearLogs);
            this.Logs.Controls.Add(this.btnDisplayLogs);
            this.Logs.Location = new System.Drawing.Point(765, 155);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(620, 406);
            this.Logs.TabIndex = 1;
            this.Logs.TabStop = false;
            this.Logs.Text = "logs";
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(31, 35);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(422, 314);
            this.dataGrid.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(276, 365);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(177, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Connection established";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.Location = new System.Drawing.Point(502, 202);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(75, 29);
            this.btnClearLogs.TabIndex = 2;
            this.btnClearLogs.Text = "Clear";
            this.btnClearLogs.UseVisualStyleBackColor = true;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // btnDisplayLogs
            // 
            this.btnDisplayLogs.Location = new System.Drawing.Point(502, 125);
            this.btnDisplayLogs.Name = "btnDisplayLogs";
            this.btnDisplayLogs.Size = new System.Drawing.Size(75, 29);
            this.btnDisplayLogs.TabIndex = 1;
            this.btnDisplayLogs.Text = "Reload";
            this.btnDisplayLogs.UseVisualStyleBackColor = true;
            this.btnDisplayLogs.Click += new System.EventHandler(this.btnDisplayLogs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Control_an_Elevator.Properties.Resources.elevator;
            this.pictureBox1.Location = new System.Drawing.Point(85, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Control_an_Elevator.Properties.Resources.elevator;
            this.pictureBox2.Location = new System.Drawing.Point(85, 339);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(375, 281);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Control_an_Elevator.Properties.Resources.inside;
            this.pictureBox3.Location = new System.Drawing.Point(210, 417);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 181);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnWall1
            // 
            this.btnWall1.Location = new System.Drawing.Point(137, 190);
            this.btnWall1.Name = "btnWall1";
            this.btnWall1.Size = new System.Drawing.Size(52, 50);
            this.btnWall1.TabIndex = 5;
            this.btnWall1.UseVisualStyleBackColor = true;
            this.btnWall1.Click += new System.EventHandler(this.btnWall1_Click);
            // 
            // btnWall0
            // 
            this.btnWall0.Location = new System.Drawing.Point(137, 470);
            this.btnWall0.Name = "btnWall0";
            this.btnWall0.Size = new System.Drawing.Size(52, 46);
            this.btnWall0.TabIndex = 6;
            this.btnWall0.UseVisualStyleBackColor = true;
            this.btnWall0.Click += new System.EventHandler(this.btnWall0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1413, 722);
            this.Controls.Add(this.btnWall0);
            this.Controls.Add(this.btnWall1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.controlPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control an Elevator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowDisplay2)).EndInit();
            this.Logs.ResumeLayout(false);
            this.Logs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlPanel;
        private System.Windows.Forms.GroupBox Logs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnOnFirstFloor;
        private System.Windows.Forms.Button btnOnGroundFloor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.Button btnDisplayLogs;
        private System.Windows.Forms.Button btnWall1;
        private System.Windows.Forms.Button btnWall0;
        private System.Windows.Forms.PictureBox DisplayWindow;
        private System.Windows.Forms.PictureBox WindowDisplay2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

