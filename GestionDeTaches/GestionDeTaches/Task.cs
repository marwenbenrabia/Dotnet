using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeTaches
{
    class Task
    {

        public string Title { get; set; } // titre de la tâche
        public Priority TaskPriority { get; set; } // priorité de la tâche
        public bool IsCompleted { get; set; } // Etat de la tâche 

        public Task (string title, Priority priority)
        {
            Title = title;
            TaskPriority = priority;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $" Titre : {Title}  -------  Niveau de priorite : {TaskPriority} --------  Etat : {IsCompleted} ";
        }

    }
}
