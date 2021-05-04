
namespace ColoringGraph
{
    partial class EdgeContraction
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
            this.vertex1 = new System.Windows.Forms.TextBox();
            this.vertex2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contraction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vertex1
            // 
            this.vertex1.Location = new System.Drawing.Point(64, 118);
            this.vertex1.Name = "vertex1";
            this.vertex1.Size = new System.Drawing.Size(100, 26);
            this.vertex1.TabIndex = 0;
            // 
            // vertex2
            // 
            this.vertex2.Location = new System.Drawing.Point(221, 118);
            this.vertex2.Name = "vertex2";
            this.vertex2.Size = new System.Drawing.Size(100, 26);
            this.vertex2.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contraction
            // 
            this.contraction.Location = new System.Drawing.Point(386, 121);
            this.contraction.Name = "contraction";
            this.contraction.Size = new System.Drawing.Size(75, 23);
            this.contraction.TabIndex = 3;
            this.contraction.Text = "button1";
            this.contraction.UseVisualStyleBackColor = true;
            this.contraction.Click += new System.EventHandler(this.contraction_Click);
            // 
            // EdgeContraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contraction);
            this.Controls.Add(this.vertex2);
            this.Controls.Add(this.vertex1);
            this.Name = "EdgeContraction";
            this.Text = "EdgeContraction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vertex1;
        private System.Windows.Forms.TextBox vertex2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button contraction;
    }
}