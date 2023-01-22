namespace MyDesktopForm
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.ClientsListView = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPatronymic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoadInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientsListView
            // 
            this.ClientsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderSurname,
            this.columnHeaderFirstName,
            this.columnHeaderPatronymic});
            this.ClientsListView.FullRowSelect = true;
            this.ClientsListView.GridLines = true;
            this.ClientsListView.HideSelection = false;
            this.ClientsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ClientsListView.Location = new System.Drawing.Point(12, 12);
            this.ClientsListView.MultiSelect = false;
            this.ClientsListView.Name = "ClientsListView";
            this.ClientsListView.Size = new System.Drawing.Size(776, 347);
            this.ClientsListView.TabIndex = 0;
            this.ClientsListView.UseCompatibleStateImageBehavior = false;
            this.ClientsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "#";
            // 
            // columnHeaderSurname
            // 
            this.columnHeaderSurname.Text = "Фамилия";
            this.columnHeaderSurname.Width = 200;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "Имя";
            this.columnHeaderFirstName.Width = 200;
            // 
            // columnHeaderPatronymic
            // 
            this.columnHeaderPatronymic.Text = "Отчество";
            this.columnHeaderPatronymic.Width = 200;
            // 
            // LoadInfoButton
            // 
            this.LoadInfoButton.Location = new System.Drawing.Point(700, 365);
            this.LoadInfoButton.Name = "LoadInfoButton";
            this.LoadInfoButton.Size = new System.Drawing.Size(88, 41);
            this.LoadInfoButton.TabIndex = 1;
            this.LoadInfoButton.Text = "Загрузить";
            this.LoadInfoButton.UseVisualStyleBackColor = true;
            this.LoadInfoButton.Click += new System.EventHandler(this.LoadInfoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.LoadInfoButton);
            this.Controls.Add(this.ClientsListView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Моя клиника";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ClientsListView;
        private System.Windows.Forms.Button LoadInfoButton;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderSurname;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderPatronymic;
    }
}
