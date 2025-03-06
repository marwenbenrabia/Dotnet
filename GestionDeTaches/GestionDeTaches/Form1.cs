using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;

namespace GestionDeTaches
{
    public partial class Form1 : Form
    {
        private List<Task> tasks;
        public Form1()
        {
            InitializeComponent();
            tasks = new List<Task>();
            listBoxTasks.DrawMode = DrawMode.OwnerDrawFixed; // Activer laffichage personnalise
            listBoxTasks.DrawItem += ListBoxTasks_DrawItem; // Associer l evenement DrawItem
        }
        // Ajouter une tache
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string title = txtTaskTitle.Text;

                if (title == null || title.Trim().Equals("") )
                {
             
                        MessageBox.Show(" Veuillez saisir la tache ", " Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
                else if (cmbPriority.SelectedItem != null)
                {

                    Priority priority = (Priority)Enum.Parse(typeof(Priority), cmbPriority.SelectedItem.ToString());
                    Task newTask = new Task(title, priority);
                    tasks.Add(newTask);

                    Form1_Load(sender, e);

                }
                else
                {
                     MessageBox.Show(" Veuillez choisir le niveau de priorité ", " Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }

        // Afficher toutes les taches
        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxTasks.Items.Clear();
            var sortedTasks = tasks.OrderBy(t => t.TaskPriority).ToList();  // Trie par priorité
            foreach (var task in sortedTasks)
            {
                listBoxTasks.Items.Add(task);

            }
        }
        // Suppriner une tache
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if(listBoxTasks.SelectedItem != null )
            {
                Task selectdTask = (Task) listBoxTasks.SelectedItem;
                tasks.Remove(selectdTask);
                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show(" Veuillez selectionner une tache à supprimer " , " Erreur " , MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

        }
        // Terminer une tache
        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                Task selectedTask = (Task) listBoxTasks.SelectedItem;
                selectedTask.IsCompleted = true;
                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show(" Veuillez selectionner une tache à terminer ", " Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Enrgistrer toutes les taches dans un fichier Json
        private void btnSaveTasks_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(tasks);
            File.WriteAllText("tasks.json",json);
        }
        // Importer toutes les taches à partir du fichier Json
        private void btnLoadTasks_Click(object sender, EventArgs e)
        {

            if (File.Exists("tasks.json"))
            {
                string json = File.ReadAllText("tasks.json");
                tasks = JsonConvert.DeserializeObject<List<Task>>(json);
                Form1_Load(sender, e);
            }

        }

        private void ListBoxTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return; // Vérifie si l'index est valide

            Task task = (Task)listBoxTasks.Items[e.Index];

            // Définir l'apparence par défaut
            e.DrawBackground();

            // Si la tâche est terminée, la griser ou la barrer
            if (task.IsCompleted)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds);  // Fond gris pour les tâches terminées
                e.Graphics.DrawString(task.ToString(), e.Font, Brushes.Gray, e.Bounds);  // Texte grisé
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);  // Fond blanc pour les tâches non terminées
                e.Graphics.DrawString(task.ToString(), e.Font, Brushes.Black, e.Bounds);  // Texte noir
            }

            // Dessiner la priorité (facultatif, selon vos préférences)
             string priority = task.TaskPriority.ToString();
             e.Graphics.DrawString(priority, e.Font, Brushes.Blue, e.Bounds.Right + 10, e.Bounds.Top);

            e.DrawFocusRectangle();
        }

    }

}
