namespace GestionDeTaches
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveTasks = new System.Windows.Forms.Button();
            this.btnLoadTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddTask.Location = new System.Drawing.Point(345, 133);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(168, 55);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "Ajouter une tache";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(231, 29);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(324, 22);
            this.txtTaskTitle.TabIndex = 1;
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Haute",
            "Moyenne",
            "Basse"});
            this.cmbPriority.Location = new System.Drawing.Point(231, 77);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 24);
            this.cmbPriority.TabIndex = 2;
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 16;
            this.listBoxTasks.Location = new System.Drawing.Point(138, 209);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(596, 212);
            this.listBoxTasks.TabIndex = 3;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.SystemColors.Info;
            this.btnDeleteTask.Location = new System.Drawing.Point(563, 133);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(197, 55);
            this.btnDeleteTask.TabIndex = 4;
            this.btnDeleteTask.Text = "Supprimer une tache";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCompleteTask.Location = new System.Drawing.Point(12, 133);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(297, 55);
            this.btnCompleteTask.TabIndex = 5;
            this.btnCompleteTask.Text = "Marquer une tache comme terminée";
            this.btnCompleteTask.UseVisualStyleBackColor = false;
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saisir une tache";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Choisir un niveau de priorité";
            // 
            // btnSaveTasks
            // 
            this.btnSaveTasks.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSaveTasks.Location = new System.Drawing.Point(563, 448);
            this.btnSaveTasks.Name = "btnSaveTasks";
            this.btnSaveTasks.Size = new System.Drawing.Size(186, 33);
            this.btnSaveTasks.TabIndex = 8;
            this.btnSaveTasks.Text = "Enregistrer les taches";
            this.btnSaveTasks.UseVisualStyleBackColor = true;
            this.btnSaveTasks.Click += new System.EventHandler(this.btnSaveTasks_Click);
            // 
            // btnLoadTasks
            // 
            this.btnLoadTasks.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLoadTasks.Location = new System.Drawing.Point(274, 448);
            this.btnLoadTasks.Name = "btnLoadTasks";
            this.btnLoadTasks.Size = new System.Drawing.Size(223, 36);
            this.btnLoadTasks.TabIndex = 9;
            this.btnLoadTasks.Text = "Charger les taches";
            this.btnLoadTasks.UseVisualStyleBackColor = true;
            this.btnLoadTasks.Click += new System.EventHandler(this.btnLoadTasks_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(931, 503);
            this.Controls.Add(this.btnLoadTasks);
            this.Controls.Add(this.btnSaveTasks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCompleteTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.txtTaskTitle);
            this.Controls.Add(this.btnAddTask);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Gestion de taches";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveTasks;
        private System.Windows.Forms.Button btnLoadTasks;
    }
}

