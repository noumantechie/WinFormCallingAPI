namespace Testing
{
    partial class Room
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
            txtDescription = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            btnAddRoom = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            gdvRoomType = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gdvRoomType).BeginInit();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(377, 178);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(237, 128);
            txtDescription.TabIndex = 1;
            txtDescription.TextChanged += txtCapacity_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 218);
            label2.Name = "label2";
            label2.Size = new Size(158, 34);
            label2.TabIndex = 2;
            label2.Text = "Descripton";
            // 
            // txtName
            // 
            txtName.Location = new Point(377, 96);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 27);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 112);
            label1.Name = "label1";
            label1.Size = new Size(93, 34);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // btnAddRoom
            // 
            btnAddRoom.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRoom.Location = new Point(574, 339);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(123, 70);
            btnAddRoom.TabIndex = 2;
            btnAddRoom.Text = "Add";
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(367, 339);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 70);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(197, 339);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 70);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // gdvRoomType
            // 
            gdvRoomType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gdvRoomType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdvRoomType.Location = new Point(30, 464);
            gdvRoomType.Name = "gdvRoomType";
            gdvRoomType.RowHeadersWidth = 51;
            gdvRoomType.Size = new Size(1064, 211);
            gdvRoomType.TabIndex = 9;
            gdvRoomType.CellContentClick += gdvRoomType_CellContentClick;
            gdvRoomType.MouseDoubleClick += gdvRoomType_MouseDoubleClick;
            // 
            // Room
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 687);
            Controls.Add(gdvRoomType);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddRoom);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Room";
            Text = "RoomType";
            ((System.ComponentModel.ISupportInitialize)gdvRoomType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Button btnAddRoom;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView gdvRoomType;
    }
}