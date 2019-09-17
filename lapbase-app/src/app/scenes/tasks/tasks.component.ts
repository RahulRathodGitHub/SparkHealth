import { TaskService } from './../../services/task.service';
import { Component, OnInit } from '@angular/core';
import { ITask, TaskType } from 'src/app/models';


@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.scss']
})
export class TasksComponent implements OnInit {
  private tasks: ITask[];
  selectedTaskId: string;
  selectedTaskType: TaskType;
  step: number;

//   data: {
//     "id": "db225c97-8515-4087-aeb9-f519cea4edea",
//     "patientId": 1,
//     "organizationCode": 1,
//     "dateAssigned": "2019-09-12T09:24:44.0948073+00:00",
//     "calories": 3000.00,
//     "weight": 70.00,
//     "foods": [
//                 {
//                     "name": "Food1,Food 2,Food 3",
//                     "quantity": "1,2,3",
//                     "mealTime": "Breakfast"
//                 },
//                 {
//                     "name": "Food1,Food 2,Food 3",
//                     "quantity": "1,2,3",
//                     "mealTime": "Lunch"
//                 }
//     ],
//     "exercises": {
//         "name": "push ups, Ex 2"
//         "quantity": "10, 20"
//     }
// }

  constructor(private taskService: TaskService) {
    taskService.getTasks().then(result => this.tasks = result);
    this.step = 0;

    
  }

  onButtonClick(taskId: string) {
    this.selectedTaskId = taskId;
    this.selectedTaskType = this.tasks.find(t => t.id === taskId).type;
    this.step++;
  }

  next() {
    this.step++;
  }

  back() {
    this.step--;
    if (this.step === 0) {
      this.taskService.getTasks().then(result => this.tasks = result);
    }
  }

  ngOnInit() {
   
  }

  
}
