
namespace BHengeveldQGame
{
    partial class DesignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGenerate = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.pnlToolbox = new System.Windows.Forms.Panel();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.lblToolbox = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.pnlGenerate.SuspendLayout();
            this.pnlToolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pnlGenerate
            // 
            this.pnlGenerate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGenerate.Controls.Add(this.btnGenerate);
            this.pnlGenerate.Controls.Add(this.txtColumns);
            this.pnlGenerate.Controls.Add(this.txtRows);
            this.pnlGenerate.Controls.Add(this.lblColumns);
            this.pnlGenerate.Controls.Add(this.lblRows);
            this.pnlGenerate.Location = new System.Drawing.Point(2, 27);
            this.pnlGenerate.Name = "pnlGenerate";
            this.pnlGenerate.Size = new System.Drawing.Size(542, 66);
            this.pnlGenerate.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(358, 10);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(172, 44);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtColumns
            // 
            this.txtColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumns.Location = new System.Drawing.Point(232, 21);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(100, 22);
            this.txtColumns.TabIndex = 2;
            // 
            // txtRows
            // 
            this.txtRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRows.Location = new System.Drawing.Point(57, 21);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 22);
            this.txtRows.TabIndex = 1;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumns.Location = new System.Drawing.Point(166, 24);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(63, 16);
            this.lblColumns.TabIndex = 1;
            this.lblColumns.Text = "Columns:";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.Location = new System.Drawing.Point(9, 24);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(45, 16);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Rows:";
            // 
            // pnlToolbox
            // 
            this.pnlToolbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbox.Controls.Add(this.btnGreenBox);
            this.pnlToolbox.Controls.Add(this.btnRedBox);
            this.pnlToolbox.Controls.Add(this.btnGreenDoor);
            this.pnlToolbox.Controls.Add(this.btnRedDoor);
            this.pnlToolbox.Controls.Add(this.btnWall);
            this.pnlToolbox.Controls.Add(this.btnNone);
            this.pnlToolbox.Controls.Add(this.lblToolbox);
            this.pnlToolbox.Location = new System.Drawing.Point(2, 94);
            this.pnlToolbox.Name = "pnlToolbox";
            this.pnlToolbox.Size = new System.Drawing.Size(200, 411);
            this.pnlToolbox.TabIndex = 2;
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenBox.ImageIndex = 5;
            this.btnGreenBox.ImageList = this.imageList1;
            this.btnGreenBox.Location = new System.Drawing.Point(3, 348);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(192, 57);
            this.btnGreenBox.TabIndex = 9;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.SelectItem);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BlankImage.jpg");
            this.imageList1.Images.SetKeyName(1, "WallImage.jpg");
            this.imageList1.Images.SetKeyName(2, "RedDoorImage.jpg");
            this.imageList1.Images.SetKeyName(3, "GreenDoorImage.jpg");
            this.imageList1.Images.SetKeyName(4, "RedBoxImage.jpg");
            this.imageList1.Images.SetKeyName(5, "GreenBoxImage.jpg");
            // 
            // btnRedBox
            // 
            this.btnRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedBox.ImageIndex = 4;
            this.btnRedBox.ImageList = this.imageList1;
            this.btnRedBox.Location = new System.Drawing.Point(3, 285);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(192, 57);
            this.btnRedBox.TabIndex = 8;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.SelectItem);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreenDoor.ImageIndex = 3;
            this.btnGreenDoor.ImageList = this.imageList1;
            this.btnGreenDoor.Location = new System.Drawing.Point(3, 222);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(192, 57);
            this.btnGreenDoor.TabIndex = 7;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.SelectItem);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedDoor.ImageIndex = 2;
            this.btnRedDoor.ImageList = this.imageList1;
            this.btnRedDoor.Location = new System.Drawing.Point(3, 159);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(192, 57);
            this.btnRedDoor.TabIndex = 6;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.SelectItem);
            // 
            // btnWall
            // 
            this.btnWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.ImageIndex = 1;
            this.btnWall.ImageList = this.imageList1;
            this.btnWall.Location = new System.Drawing.Point(3, 96);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(192, 57);
            this.btnWall.TabIndex = 5;
            this.btnWall.Text = "Wall";
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.SelectItem);
            // 
            // btnNone
            // 
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNone.ImageIndex = 0;
            this.btnNone.ImageList = this.imageList1;
            this.btnNone.Location = new System.Drawing.Point(3, 33);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(192, 57);
            this.btnNone.TabIndex = 4;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.SelectItem);
            // 
            // lblToolbox
            // 
            this.lblToolbox.AutoSize = true;
            this.lblToolbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolbox.Location = new System.Drawing.Point(43, 1);
            this.lblToolbox.Name = "lblToolbox";
            this.lblToolbox.Size = new System.Drawing.Size(102, 29);
            this.lblToolbox.TabIndex = 0;
            this.lblToolbox.Text = "Toolbox";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "savegame";
            this.saveFileDialog1.Filter = "QGame File|*.qgame|All files|*.*";
            this.saveFileDialog1.Title = "Save As";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "QGame File|*.qgame|All files|*.*";
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 679);
            this.Controls.Add(this.pnlToolbox);
            this.Controls.Add(this.pnlGenerate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DesignForm";
            this.Text = "Design Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlGenerate.ResumeLayout(false);
            this.pnlGenerate.PerformLayout();
            this.pnlToolbox.ResumeLayout(false);
            this.pnlToolbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGenerate;
        private System.Windows.Forms.Panel pnlToolbox;
        private System.Windows.Forms.Label lblToolbox;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
    }
}