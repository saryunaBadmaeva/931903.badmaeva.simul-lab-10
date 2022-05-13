
namespace Simulation_lab_10
{
    partial class Form1
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
            this.dataGridViewMatches = new System.Windows.Forms.DataGridView();
            this.ColumnTeamName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeamName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_generate = new System.Windows.Forms.Button();
            this.dataGridViewTournament = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMatchesAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeadHeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnScoreSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournament)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatches
            // 
            this.dataGridViewMatches.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTeamName1,
            this.ColumnTeamName2,
            this.ColumnScore});
            this.dataGridViewMatches.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridViewMatches.Location = new System.Drawing.Point(12, 352);
            this.dataGridViewMatches.Name = "dataGridViewMatches";
            this.dataGridViewMatches.RowHeadersWidth = 62;
            this.dataGridViewMatches.Size = new System.Drawing.Size(514, 268);
            this.dataGridViewMatches.TabIndex = 5;
            // 
            // ColumnTeamName1
            // 
            this.ColumnTeamName1.HeaderText = "Team 1";
            this.ColumnTeamName1.MinimumWidth = 8;
            this.ColumnTeamName1.Name = "ColumnTeamName1";
            this.ColumnTeamName1.Width = 150;
            // 
            // ColumnTeamName2
            // 
            this.ColumnTeamName2.HeaderText = "Team 2";
            this.ColumnTeamName2.MinimumWidth = 8;
            this.ColumnTeamName2.Name = "ColumnTeamName2";
            this.ColumnTeamName2.Width = 150;
            // 
            // ColumnScore
            // 
            this.ColumnScore.HeaderText = "Score";
            this.ColumnScore.MinimumWidth = 8;
            this.ColumnScore.Name = "ColumnScore";
            this.ColumnScore.Width = 150;
            // 
            // bt_generate
            // 
            this.bt_generate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_generate.Location = new System.Drawing.Point(12, 12);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(246, 66);
            this.bt_generate.TabIndex = 4;
            this.bt_generate.Text = "Generate Tournament";
            this.bt_generate.UseVisualStyleBackColor = false;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // dataGridViewTournament
            // 
            this.dataGridViewTournament.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewTournament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTournament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnMatchesAmount,
            this.ColumnWins,
            this.ColumnDeadHeat,
            this.ColumnLosts,
            this.ColumnHits,
            this.ColumnScoreSum});
            this.dataGridViewTournament.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewTournament.Name = "dataGridViewTournament";
            this.dataGridViewTournament.RowHeadersWidth = 62;
            this.dataGridViewTournament.Size = new System.Drawing.Size(1113, 269);
            this.dataGridViewTournament.TabIndex = 3;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Team name";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 150;
            // 
            // ColumnMatchesAmount
            // 
            this.ColumnMatchesAmount.HeaderText = "Matches amount";
            this.ColumnMatchesAmount.MinimumWidth = 8;
            this.ColumnMatchesAmount.Name = "ColumnMatchesAmount";
            this.ColumnMatchesAmount.Width = 150;
            // 
            // ColumnWins
            // 
            this.ColumnWins.HeaderText = "Wins count";
            this.ColumnWins.MinimumWidth = 8;
            this.ColumnWins.Name = "ColumnWins";
            this.ColumnWins.Width = 150;
            // 
            // ColumnDeadHeat
            // 
            this.ColumnDeadHeat.HeaderText = "Dead heat count";
            this.ColumnDeadHeat.MinimumWidth = 8;
            this.ColumnDeadHeat.Name = "ColumnDeadHeat";
            this.ColumnDeadHeat.Width = 150;
            // 
            // ColumnLosts
            // 
            this.ColumnLosts.HeaderText = "Losts count";
            this.ColumnLosts.MinimumWidth = 8;
            this.ColumnLosts.Name = "ColumnLosts";
            this.ColumnLosts.Width = 150;
            // 
            // ColumnHits
            // 
            this.ColumnHits.HeaderText = "Hits count";
            this.ColumnHits.MinimumWidth = 8;
            this.ColumnHits.Name = "ColumnHits";
            this.ColumnHits.Width = 150;
            // 
            // ColumnScoreSum
            // 
            this.ColumnScoreSum.HeaderText = "Score sum";
            this.ColumnScoreSum.MinimumWidth = 8;
            this.ColumnScoreSum.Name = "ColumnScoreSum";
            this.ColumnScoreSum.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 675);
            this.Controls.Add(this.dataGridViewMatches);
            this.Controls.Add(this.bt_generate);
            this.Controls.Add(this.dataGridViewTournament);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeamName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeamName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScore;
        private System.Windows.Forms.Button bt_generate;
        private System.Windows.Forms.DataGridView dataGridViewTournament;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMatchesAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWins;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeadHeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHits;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScoreSum;
    }
}

