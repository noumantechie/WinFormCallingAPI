namespace Testing
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtCapacity = new TextBox();
            label3 = new Label();
            txtLocation = new TextBox();
            chkAvalibilty = new CheckBox();
            btnAdd = new Button();
            gdvHall = new DataGridView();
            btnUpdateHall = new Button();
            btnDeleteHall = new Button();
            cboRoomType = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)gdvHall).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 102);
            label1.Name = "label1";
            label1.Size = new Size(93, 34);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(255, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 27);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(97, 172);
            label2.Name = "label2";
            label2.Size = new Size(125, 34);
            label2.TabIndex = 0;
            label2.Text = "Capacity";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(255, 179);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(220, 27);
            txtCapacity.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 243);
            label3.Name = "label3";
            label3.Size = new Size(129, 34);
            label3.TabIndex = 0;
            label3.Text = "Location";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(255, 243);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(220, 27);
            txtLocation.TabIndex = 1;
            // 
            // chkAvalibilty
            // 
            chkAvalibilty.AutoSize = true;
            chkAvalibilty.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkAvalibilty.Location = new Point(166, 343);
            chkAvalibilty.Name = "chkAvalibilty";
            chkAvalibilty.Size = new Size(243, 38);
            chkAvalibilty.TabIndex = 2;
            chkAvalibilty.Text = "Avaliblity Status";
            chkAvalibilty.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(735, 358);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 70);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gdvHall
            // 
            gdvHall.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdvHall.Location = new Point(12, 458);
            gdvHall.Name = "gdvHall";
            gdvHall.RowHeadersWidth = 51;
            gdvHall.Size = new Size(918, 211);
            gdvHall.TabIndex = 4;
            gdvHall.MouseDoubleClick += gdvHall_MouseDoubleClick;
            // 
            // btnUpdateHall
            // 
            btnUpdateHall.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateHall.Location = new Point(569, 375);
            btnUpdateHall.Name = "btnUpdateHall";
            btnUpdateHall.Size = new Size(141, 59);
            btnUpdateHall.TabIndex = 5;
            btnUpdateHall.Text = "Update";
            btnUpdateHall.UseVisualStyleBackColor = true;
            btnUpdateHall.Click += btnUpdateHall_Click;
            // 
            // btnDeleteHall
            // 
            btnDeleteHall.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteHall.Location = new Point(396, 375);
            btnDeleteHall.Name = "btnDeleteHall";
            btnDeleteHall.Size = new Size(141, 59);
            btnDeleteHall.TabIndex = 5;
            btnDeleteHall.Text = "Delete";
            btnDeleteHall.UseVisualStyleBackColor = true;
            btnDeleteHall.Click += btnDeleteHall_Click;
            // 
            // cboRoomType
            // 
            cboRoomType.FormattingEnabled = true;
            cboRoomType.Location = new Point(757, 141);
            cboRoomType.Name = "cboRoomType";
            cboRoomType.Size = new Size(173, 28);
            cboRoomType.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(479, 134);
            label4.Name = "label4";
            label4.Size = new Size(257, 34);
            label4.TabIndex = 0;
            label4.Text = "Select Room Type";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 702);
            Controls.Add(cboRoomType);
            Controls.Add(btnDeleteHall);
            Controls.Add(btnUpdateHall);
            Controls.Add(gdvHall);
            Controls.Add(btnAdd);
            Controls.Add(chkAvalibilty);
            Controls.Add(txtLocation);
            Controls.Add(label3);
            Controls.Add(txtCapacity);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gdvHall).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtCapacity;
        private Label label3;
        private TextBox txtLocation;
        private CheckBox chkAvalibilty;
        private Button btnAdd;
        private DataGridView gdvHall;
        private Button btnUpdateHall;
        private Button btnDeleteHall;
        private ComboBox cboRoomType;
        private Label label4;
    }
}
