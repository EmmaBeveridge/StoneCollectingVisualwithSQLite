
namespace StoneCollectingVisual
{
    partial class DisplayStonesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonAllStones = new System.Windows.Forms.RadioButton();
            this.radioButtonStonesFound = new System.Windows.Forms.RadioButton();
            this.radioButtonStonesNotFound = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StoneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoneColour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoneLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoneFound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show:";
            // 
            // radioButtonAllStones
            // 
            this.radioButtonAllStones.AutoSize = true;
            this.radioButtonAllStones.Location = new System.Drawing.Point(130, 51);
            this.radioButtonAllStones.Name = "radioButtonAllStones";
            this.radioButtonAllStones.Size = new System.Drawing.Size(92, 21);
            this.radioButtonAllStones.TabIndex = 1;
            this.radioButtonAllStones.TabStop = true;
            this.radioButtonAllStones.Text = "All Stones";
            this.radioButtonAllStones.UseVisualStyleBackColor = true;
            this.radioButtonAllStones.CheckedChanged += new System.EventHandler(this.radioButtonAllStones_CheckedChanged);
            // 
            // radioButtonStonesFound
            // 
            this.radioButtonStonesFound.AutoSize = true;
            this.radioButtonStonesFound.Location = new System.Drawing.Point(262, 51);
            this.radioButtonStonesFound.Name = "radioButtonStonesFound";
            this.radioButtonStonesFound.Size = new System.Drawing.Size(117, 21);
            this.radioButtonStonesFound.TabIndex = 2;
            this.radioButtonStonesFound.TabStop = true;
            this.radioButtonStonesFound.Text = "Stones Found";
            this.radioButtonStonesFound.UseVisualStyleBackColor = true;
            this.radioButtonStonesFound.CheckedChanged += new System.EventHandler(this.radioButtonStonesFound_CheckedChanged);
            // 
            // radioButtonStonesNotFound
            // 
            this.radioButtonStonesNotFound.AutoSize = true;
            this.radioButtonStonesNotFound.Location = new System.Drawing.Point(413, 51);
            this.radioButtonStonesNotFound.Name = "radioButtonStonesNotFound";
            this.radioButtonStonesNotFound.Size = new System.Drawing.Size(143, 21);
            this.radioButtonStonesNotFound.TabIndex = 3;
            this.radioButtonStonesNotFound.TabStop = true;
            this.radioButtonStonesNotFound.Text = "Stones Not Found";
            this.radioButtonStonesNotFound.UseVisualStyleBackColor = true;
            this.radioButtonStonesNotFound.CheckedChanged += new System.EventHandler(this.radioButtonStonesNotFound_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoneID,
            this.StoneName,
            this.StoneColour,
            this.StoneLocation,
            this.StoneFound});
            this.dataGridView1.Location = new System.Drawing.Point(30, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 322);
            this.dataGridView1.TabIndex = 4;
            // 
            // StoneID
            // 
            this.StoneID.HeaderText = "Stone ID";
            this.StoneID.MinimumWidth = 6;
            this.StoneID.Name = "StoneID";
            this.StoneID.ReadOnly = true;
            this.StoneID.Width = 125;
            // 
            // StoneName
            // 
            this.StoneName.HeaderText = "Stone Name";
            this.StoneName.MinimumWidth = 6;
            this.StoneName.Name = "StoneName";
            this.StoneName.ReadOnly = true;
            this.StoneName.Width = 125;
            // 
            // StoneColour
            // 
            this.StoneColour.HeaderText = "Stone Colour";
            this.StoneColour.MinimumWidth = 6;
            this.StoneColour.Name = "StoneColour";
            this.StoneColour.ReadOnly = true;
            this.StoneColour.Width = 125;
            // 
            // StoneLocation
            // 
            this.StoneLocation.HeaderText = "Stone Location";
            this.StoneLocation.MinimumWidth = 6;
            this.StoneLocation.Name = "StoneLocation";
            this.StoneLocation.ReadOnly = true;
            this.StoneLocation.Width = 125;
            // 
            // StoneFound
            // 
            this.StoneFound.HeaderText = "Stone Found";
            this.StoneFound.MinimumWidth = 6;
            this.StoneFound.Name = "StoneFound";
            this.StoneFound.ReadOnly = true;
            this.StoneFound.Width = 125;
            // 
            // DisplayStonesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButtonStonesNotFound);
            this.Controls.Add(this.radioButtonStonesFound);
            this.Controls.Add(this.radioButtonAllStones);
            this.Controls.Add(this.label1);
            this.Name = "DisplayStonesForm";
            this.Text = "DisplayStonesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisplayStonesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonAllStones;
        private System.Windows.Forms.RadioButton radioButtonStonesFound;
        private System.Windows.Forms.RadioButton radioButtonStonesNotFound;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoneID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoneColour;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoneLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoneFound;
    }
}