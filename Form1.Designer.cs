namespace Note_Taking
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
            label2 = new Label();
            TxtTitle = new TextBox();
            TxtMessage = new TextBox();
            dataGridView1 = new DataGridView();
            BttNew = new Button();
            BttSave = new Button();
            BttRead = new Button();
            BttDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 72);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Message";
            // 
            // TxtTitle
            // 
            TxtTitle.Location = new Point(88, 64);
            TxtTitle.Name = "TxtTitle";
            TxtTitle.Size = new Size(100, 23);
            TxtTitle.TabIndex = 2;
            // 
            // TxtMessage
            // 
            TxtMessage.Location = new Point(88, 113);
            TxtMessage.Multiline = true;
            TxtMessage.Name = "TxtMessage";
            TxtMessage.Size = new Size(134, 115);
            TxtMessage.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(303, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(209, 193);
            dataGridView1.TabIndex = 4;
            // 
            // BttNew
            // 
            BttNew.Location = new Point(132, 322);
            BttNew.Name = "BttNew";
            BttNew.Size = new Size(75, 23);
            BttNew.TabIndex = 5;
            BttNew.Text = "New";
            BttNew.UseVisualStyleBackColor = true;
            BttNew.Click += BttNew_Click;
            // 
            // BttSave
            // 
            BttSave.Location = new Point(227, 322);
            BttSave.Name = "BttSave";
            BttSave.Size = new Size(75, 23);
            BttSave.TabIndex = 6;
            BttSave.Text = "Save";
            BttSave.UseVisualStyleBackColor = true;
            BttSave.Click += BttSave_Click;
            // 
            // BttRead
            // 
            BttRead.Location = new Point(319, 322);
            BttRead.Name = "BttRead";
            BttRead.Size = new Size(75, 23);
            BttRead.TabIndex = 7;
            BttRead.Text = "Read";
            BttRead.UseVisualStyleBackColor = true;
            BttRead.Click += BttRead_Click;
            // 
            // BttDelete
            // 
            BttDelete.Location = new Point(419, 322);
            BttDelete.Name = "BttDelete";
            BttDelete.Size = new Size(75, 23);
            BttDelete.TabIndex = 8;
            BttDelete.Text = "Delete";
            BttDelete.UseVisualStyleBackColor = true;
            BttDelete.Click += BttDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BttDelete);
            Controls.Add(BttRead);
            Controls.Add(BttSave);
            Controls.Add(BttNew);
            Controls.Add(dataGridView1);
            Controls.Add(TxtMessage);
            Controls.Add(TxtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtTitle;
        private TextBox TxtMessage;
        private DataGridView dataGridView1;
        private Button BttNew;
        private Button BttSave;
        private Button BttRead;
        private Button BttDelete;
    }
}