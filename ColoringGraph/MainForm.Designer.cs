
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.denseGraph = new System.Windows.Forms.Button();
            this.saturationColoring = new System.Windows.Forms.Button();
            this.incidenceColoring = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iterationsNumber = new System.Windows.Forms.NumericUpDown();
            this.maxEdges = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxEdges)).BeginInit();
            this.SuspendLayout();
            // 
            // matrix
            // 
            this.matrix.AllowUserToAddRows = false;
            this.matrix.AllowUserToDeleteRows = false;
            this.matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrix.BackgroundColor = System.Drawing.SystemColors.Window;
            this.matrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.GridColor = System.Drawing.Color.Tomato;
            this.matrix.Location = new System.Drawing.Point(302, 121);
            this.matrix.Name = "matrix";
            this.matrix.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.matrix.RowHeadersWidth = 62;
            this.matrix.RowTemplate.Height = 28;
            this.matrix.Size = new System.Drawing.Size(794, 477);
            this.matrix.TabIndex = 0;
            this.matrix.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.matrix_RowPrePaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(288, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество вершин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(288, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество ребер";
            // 
            // completeGraph
            // 
            this.completeGraph.AutoSize = true;
            this.completeGraph.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completeGraph.Location = new System.Drawing.Point(770, 14);
            this.completeGraph.Name = "completeGraph";
            this.completeGraph.Size = new System.Drawing.Size(262, 49);
            this.completeGraph.TabIndex = 5;
            this.completeGraph.Text = "Полный граф";
            this.completeGraph.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(770, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сгенерировать граф";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vertexQuantity
            // 
            this.vertexQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vertexQuantity.Location = new System.Drawing.Point(622, 14);
            this.vertexQuantity.Name = "vertexQuantity";
            this.vertexQuantity.Size = new System.Drawing.Size(120, 44);
            this.vertexQuantity.TabIndex = 7;
            this.vertexQuantity.ValueChanged += new System.EventHandler(this.vertexQuantity_ValueChanged);
            // 
            // edgeQuantity
            // 
            this.edgeQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edgeQuantity.Location = new System.Drawing.Point(622, 70);
            this.edgeQuantity.Name = "edgeQuantity";
            this.edgeQuantity.Size = new System.Drawing.Size(120, 44);
            this.edgeQuantity.TabIndex = 8;
            // 
            // buildGraph
            // 
            this.buildGraph.BackColor = System.Drawing.Color.Plum;
            this.buildGraph.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.buildGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildGraph.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildGraph.Location = new System.Drawing.Point(3, 122);
            this.buildGraph.Name = "buildGraph";
            this.buildGraph.Size = new System.Drawing.Size(290, 117);
            this.buildGraph.TabIndex = 9;
            this.buildGraph.Text = "Построить граф";
            this.buildGraph.UseVisualStyleBackColor = false;
            this.buildGraph.Click += new System.EventHandler(this.buildGraph_Click);
            // 
            // firstFitButton
            // 
            this.firstFitButton.BackColor = System.Drawing.Color.Plum;
            this.firstFitButton.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.firstFitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstFitButton.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstFitButton.Location = new System.Drawing.Point(1102, 121);
            this.firstFitButton.Name = "firstFitButton";
            this.firstFitButton.Size = new System.Drawing.Size(338, 118);
            this.firstFitButton.TabIndex = 10;
            this.firstFitButton.Text = "Последовательная раскраска";
            this.firstFitButton.UseVisualStyleBackColor = false;
            this.firstFitButton.Click += new System.EventHandler(this.firstFitButton_Click);
            // 
            // degreeBasedAlgorithm
            // 
            this.degreeBasedAlgorithm.BackColor = System.Drawing.Color.Plum;
            this.degreeBasedAlgorithm.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.degreeBasedAlgorithm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.degreeBasedAlgorithm.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degreeBasedAlgorithm.Location = new System.Drawing.Point(3, 319);
            this.degreeBasedAlgorithm.Name = "degreeBasedAlgorithm";
            this.degreeBasedAlgorithm.Size = new System.Drawing.Size(290, 160);
            this.degreeBasedAlgorithm.TabIndex = 11;
            this.degreeBasedAlgorithm.Text = "Раскраска с наибольшей степенью";
            this.degreeBasedAlgorithm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.degreeBasedAlgorithm.UseVisualStyleBackColor = false;
            this.degreeBasedAlgorithm.Click += new System.EventHandler(this.degreeBasedAlgorithm_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Plum;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(1104, 487);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(336, 111);
            this.button7.TabIndex = 17;
            this.button7.Text = "Анализ алгоритмов";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Plum;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1102, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(338, 118);
            this.button2.TabIndex = 18;
            this.button2.Text = "Исчерпывающая раскраска";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // denseGraph
            // 
            this.denseGraph.BackColor = System.Drawing.Color.Plum;
            this.denseGraph.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.denseGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.denseGraph.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.denseGraph.Location = new System.Drawing.Point(3, 244);
            this.denseGraph.Name = "denseGraph";
            this.denseGraph.Size = new System.Drawing.Size(290, 69);
            this.denseGraph.TabIndex = 19;
            this.denseGraph.Text = "Плотность";
            this.denseGraph.UseVisualStyleBackColor = false;
            this.denseGraph.Click += new System.EventHandler(this.denseGraph_Click);
            // 
            // saturationColoring
            // 
            this.saturationColoring.BackColor = System.Drawing.Color.Plum;
            this.saturationColoring.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.saturationColoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saturationColoring.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saturationColoring.Location = new System.Drawing.Point(1103, 368);
            this.saturationColoring.Name = "saturationColoring";
            this.saturationColoring.Size = new System.Drawing.Size(337, 113);
            this.saturationColoring.TabIndex = 24;
            this.saturationColoring.Text = "Насыщенная раскраска";
            this.saturationColoring.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saturationColoring.UseVisualStyleBackColor = false;
            this.saturationColoring.Click += new System.EventHandler(this.saturationColoring_Click);
            // 
            // incidenceColoring
            // 
            this.incidenceColoring.BackColor = System.Drawing.Color.Plum;
            this.incidenceColoring.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.incidenceColoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incidenceColoring.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incidenceColoring.Location = new System.Drawing.Point(3, 485);
            this.incidenceColoring.Name = "incidenceColoring";
            this.incidenceColoring.Size = new System.Drawing.Size(290, 113);
            this.incidenceColoring.TabIndex = 25;
            this.incidenceColoring.Text = "Раскраска по охвату вершин";
            this.incidenceColoring.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.incidenceColoring.UseVisualStyleBackColor = false;
            this.incidenceColoring.Click += new System.EventHandler(this.incidenceColoring_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(343, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 45);
            this.label3.TabIndex = 26;
            this.label3.Text = "Количество итераций";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(343, 663);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(558, 45);
            this.label4.TabIndex = 27;
            this.label4.Text = "Максимальное количество вершин";
            // 
            // iterationsNumber
            // 
            this.iterationsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterationsNumber.Location = new System.Drawing.Point(923, 606);
            this.iterationsNumber.Name = "iterationsNumber";
            this.iterationsNumber.Size = new System.Drawing.Size(120, 44);
            this.iterationsNumber.TabIndex = 28;
            // 
            // maxEdges
            // 
            this.maxEdges.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxEdges.Location = new System.Drawing.Point(923, 663);
            this.maxEdges.Name = "maxEdges";
            this.maxEdges.Size = new System.Drawing.Size(120, 44);
            this.maxEdges.TabIndex = 29;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1451, 737);
            this.Controls.Add(this.maxEdges);
            this.Controls.Add(this.iterationsNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.incidenceColoring);
            this.Controls.Add(this.saturationColoring);
            this.Controls.Add(this.denseGraph);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Графы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertexQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgeQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxEdges)).EndInit();
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
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button denseGraph;
        private System.Windows.Forms.Button saturationColoring;
        private System.Windows.Forms.Button incidenceColoring;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown iterationsNumber;
        private System.Windows.Forms.NumericUpDown maxEdges;
    }
}

