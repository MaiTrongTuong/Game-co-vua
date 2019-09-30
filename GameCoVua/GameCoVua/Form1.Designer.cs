namespace GameCaro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelChessBoard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelChessBoard
            // 
            this.PanelChessBoard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PanelChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.PanelChessBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelChessBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelChessBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelChessBoard.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelChessBoard.Location = new System.Drawing.Point(276, 12);
            this.PanelChessBoard.Name = "PanelChessBoard";
            this.PanelChessBoard.Size = new System.Drawing.Size(530, 620);
            this.PanelChessBoard.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 684);
            this.Controls.Add(this.PanelChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Caro";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelChessBoard;
    }
}

