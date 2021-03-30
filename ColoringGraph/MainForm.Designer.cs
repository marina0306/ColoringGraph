
namespace ColoringGraph
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.matrix = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.completeGraph = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vertexQuantity = new System.Windows.Forms.NumericUpDown();
            this.edgeQuantity = new System.Windows.Forms.NumericUpDown();
            this.buildGraph = new System.Windows.Forms.Button();
            this.firstFitButton = new System.Windows.Forms.Button();
            this.degreeBasedAlgorithm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // matrix
            // 
            this.matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.Location = new System.Drawing.Point(19, 112);
            this.matrix.Name = "matrix";
            this.matrix.RowHeadersWidth = 62;
            this.matrix.RowTemplate.Height = 28;
            this.matrix.Size = new System.Drawing.Size(799, 360);
            this.matrix.TabIndex = 0;
            this.matrix.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.matrix_RowPrePaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество вершин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество ребер";
            // 
            // completeGraph
            // 
            this.completeGraph.AutoSize = true;
            this.completeGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completeGraph.Location = new System.Drawing.Point(493, 10);
            this.completeGraph.Name = "completeGraph";
            this.completeGraph.Size = new System.Drawing.Size(226, 41);
            this.completeGraph.TabIndex = 5;
            this.completeGraph.Text = "Полный граф";
            this.completeGraph.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(493, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сгенерировать граф";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vertexQuantity
            // 
            this.vertexQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vertexQuantity.Location = new System.Drawing.Point(344, 7);
            this.vertexQuantity.Name = "vertexQuantity";
            this.vertexQuantity.Size = new System.Drawing.Size(120, 44);
            this.vertexQuantity.TabIndex = 7;
            this.vertexQuantity.ValueChanged += new System.EventHandler(this.vertexQuantity_ValueChanged);
            // 
            // edgeQuantity
            // 
            this.edgeQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edgeQuantity.Location = new System.Drawing.Point(344, 62);
            this.edgeQuantity.Name = "edgeQuantity";
            this.edgeQuantity.Size = new System.Drawing.Size(120, 44);
            this.edgeQuantity.TabIndex = 8;
            // 
            // buildGraph
            // 
            this.buildGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildGraph.Location = new System.Drawing.Point(563, 478);
            this.buildGraph.Name = "buildGraph";
            this.buildGraph.Size = new System.Drawing.Size(255, 51);
            this.buildGraph.TabIndex = 9;
            this.buildGraph.Text = "Построить граф";
            this.buildGraph.UseVisualStyleBackColor = true;
            this.buildGraph.Click += new System.EventHandler(this.buildGraph_Click);
            // 
            // firstFitButton
            // 
            this.firstFitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstFitButton.Location = new System.Drawing.Point(19, 478);
            this.firstFitButton.Name = "firstFitButton";
            this.firstFitButton.Size = new System.Drawing.Size(285, 51);
            this.firstFitButton.TabIndex = 10;
            this.firstFitButton.Text = "First Fit Algorithm";
            this.firstFitButton.UseVisualStyleBackColor = true;
            this.firstFitButton.Click += new System.EventHandler(this.firstFitButton_Click);
            // 
            // degreeBasedAlgorithm
            // 
            this.degreeBasedAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degreeBasedAlgorithm.Location = new System.Drawing.Point(310, 478);
            this.degreeBasedAlgorithm.Name = "degreeBasedAlgorithm";
            this.degreeBasedAlgorithm.Size = new System.Drawing.Size(247, 51);
            this.degreeBasedAlgorithm.TabIndex = 11;
            this.degreeBasedAlgorithm.Text = "Degree Based";
            this.degreeBasedAlgorithm.UseVisualStyleBackColor = true;
            this.degreeBasedAlgorithm.Click += new System.EventHandler(this.degreeBasedAlgorithm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 539);
            this.Controls.Add(this.degreeBasedAlgorithm);
            this.Controls.Add(this.firstFitButton);
            this.Controls.Add(this.buildGraph);
            this.Controls.Add(this.edgeQuantity);
            this.Controls.Add(this.vertexQuantity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.completeGraph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrix);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox completeGraph;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown vertexQuantity;
        private System.Windows.Forms.NumericUpDown edgeQuantity;
        private System.Windows.Forms.Button buildGraph;
        private System.Windows.Forms.Button firstFitButton;
        private System.Windows.Forms.Button degreeBasedAlgorithm;
    }
}

