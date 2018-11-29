import { Component, OnInit } from '@angular/core';
import { Task, TaskService, Worker, WorkerService } from 'src/app/shared/imports';

@Component({
  selector: 'app-my-tasks',
  templateUrl: './my-tasks.component.html',
  styleUrls: ['./my-tasks.component.css']
})
export class MyTasksComponent implements OnInit {

  myTasks:Array<Task>;
  worker:Worker;

  constructor(private taskService:TaskService,private workerService:WorkerService) { 
   this.worker= this.workerService.getCurrentWorker();
  }

  ngOnInit() {
    this.taskService.GetTasksWithWorkerAndProjectByWorkerId(this.worker.workerId).subscribe((res)=>{
      this.myTasks=res;
    })
  }

}
