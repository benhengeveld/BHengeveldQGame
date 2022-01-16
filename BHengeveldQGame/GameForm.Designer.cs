
namespace BHengeveldQGame
{
    partial class GameForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.txtNumOfMoves = new System.Windows.Forms.TextBox();
            this.txtNumOfBoxes = new System.Windows.Forms.TextBox();
            this.lblNumOfMoves = new System.Windows.Forms.Label();
            this.lblNumOfBoxes = new System.Windows.Forms.Label();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "QGame File|*.qgame|All files|*.*";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(899, 327);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 75);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.MoveButtonClicked);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(899, 408);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 75);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.MoveButtonClicked);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(818, 408);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 75);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.MoveButtonClicked);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(980, 408);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 75);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.MoveButtonClicked);
            // 
            // txtNumOfMoves
            // 
            this.txtNumOfMoves.Location = new System.Drawing.Point(854, 101);
            this.txtNumOfMoves.Name = "txtNumOfMoves";
            this.txtNumOfMoves.ReadOnly = true;
            this.txtNumOfMoves.Size = new System.Drawing.Size(168, 20);
            this.txtNumOfMoves.TabIndex = 5;
            this.txtNumOfMoves.TabStop = false;
            this.txtNumOfMoves.Text = "0";
            // 
            // txtNumOfBoxes
            // 
            this.txtNumOfBoxes.Location = new System.Drawing.Point(854, 183);
            this.txtNumOfBoxes.Name = "txtNumOfBoxes";
            this.txtNumOfBoxes.ReadOnly = true;
            this.txtNumOfBoxes.Size = new System.Drawing.Size(168, 20);
            this.txtNumOfBoxes.TabIndex = 6;
            this.txtNumOfBoxes.TabStop = false;
            this.txtNumOfBoxes.Text = "0";
            // 
            // lblNumOfMoves
            // 
            this.lblNumOfMoves.AutoSize = true;
            this.lblNumOfMoves.Location = new System.Drawing.Point(851, 85);
            this.lblNumOfMoves.Name = "lblNumOfMoves";
            this.lblNumOfMoves.Size = new System.Drawing.Size(94, 13);
            this.lblNumOfMoves.TabIndex = 4;
            this.lblNumOfMoves.Text = "Number of Moves:";
            // 
            // lblNumOfBoxes
            // 
            this.lblNumOfBoxes.AutoSize = true;
            this.lblNumOfBoxes.Location = new System.Drawing.Point(851, 167);
            this.lblNumOfBoxes.Name = "lblNumOfBoxes";
            this.lblNumOfBoxes.Size = new System.Drawing.Size(144, 13);
            this.lblNumOfBoxes.TabIndex = 4;
            this.lblNumOfBoxes.Text = "Number of Remaining Boxes:";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 664);
            this.Controls.Add(this.lblNumOfBoxes);
            this.Controls.Add(this.lblNumOfMoves);
            this.Controls.Add(this.txtNumOfBoxes);
            this.Controls.Add(this.txtNumOfMoves);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.TextBox txtNumOfMoves;
        private System.Windows.Forms.TextBox txtNumOfBoxes;
        private System.Windows.Forms.Label lblNumOfMoves;
        private System.Windows.Forms.Label lblNumOfBoxes;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}