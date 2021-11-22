
namespace StoneCollectingVisual
{
    partial class EnterStoneForm
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
            this.textBoxStoneName = new System.Windows.Forms.TextBox();
            this.textBoxStoneColour = new System.Windows.Forms.TextBox();
            this.textBoxStoneLocation = new System.Windows.Forms.TextBox();
            this.checkBoxStoneFound = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxStoneName
            // 
            this.textBoxStoneName.Location = new System.Drawing.Point(280, 92);
            this.textBoxStoneName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStoneName.Name = "textBoxStoneName";
            this.textBoxStoneName.Size = new System.Drawing.Size(181, 22);
            this.textBoxStoneName.TabIndex = 0;
            this.textBoxStoneName.TextChanged += new System.EventHandler(this.textBoxStoneName_TextChanged);
            // 
            // textBoxStoneColour
            // 
            this.textBoxStoneColour.Location = new System.Drawing.Point(280, 181);
            this.textBoxStoneColour.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStoneColour.Name = "textBoxStoneColour";
            this.textBoxStoneColour.Size = new System.Drawing.Size(181, 22);
            this.textBoxStoneColour.TabIndex = 1;
            this.textBoxStoneColour.TextChanged += new System.EventHandler(this.textBoxStoneColour_TextChanged);
            // 
            // textBoxStoneLocation
            // 
            this.textBoxStoneLocation.Location = new System.Drawing.Point(280, 263);
            this.textBoxStoneLocation.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStoneLocation.Name = "textBoxStoneLocation";
            this.textBoxStoneLocation.Size = new System.Drawing.Size(181, 22);
            this.textBoxStoneLocation.TabIndex = 2;
            this.textBoxStoneLocation.TextChanged += new System.EventHandler(this.textBoxStoneLocation_TextChanged);
            // 
            // checkBoxStoneFound
            // 
            this.checkBoxStoneFound.AutoSize = true;
            this.checkBoxStoneFound.Location = new System.Drawing.Point(280, 347);
            this.checkBoxStoneFound.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxStoneFound.Name = "checkBoxStoneFound";
            this.checkBoxStoneFound.Size = new System.Drawing.Size(18, 17);
            this.checkBoxStoneFound.TabIndex = 3;
            this.checkBoxStoneFound.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stone Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stone Found:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stone Colour:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stone Location:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(392, 409);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 31);
            this.label5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 31);
            this.label6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(493, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 31);
            this.label7.TabIndex = 11;
            // 
            // EnterStoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 505);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxStoneFound);
            this.Controls.Add(this.textBoxStoneLocation);
            this.Controls.Add(this.textBoxStoneColour);
            this.Controls.Add(this.textBoxStoneName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnterStoneForm";
            this.Text = "EnterStoneForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnterStoneForm_FormClosing);
            this.Load += new System.EventHandler(this.EnterStoneForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.TextBox textBoxStoneName;
        protected System.Windows.Forms.TextBox textBoxStoneColour;
        protected System.Windows.Forms.TextBox textBoxStoneLocation;
        protected System.Windows.Forms.CheckBox checkBoxStoneFound;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
    }
}