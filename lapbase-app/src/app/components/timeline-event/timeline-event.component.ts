import { Component, OnInit, Input } from '@angular/core';
import { AppointmentService } from './../../services/appointment.service';
import { IAppointment } from 'src/app/models';


@Component({
  selector: 'app-timeline-event',
  templateUrl: './timeline-event.component.html',
  styleUrls: ['./timeline-event.component.scss']
})
export class TimelineEventComponent implements OnInit {

  date: Date;
  description: string = 'Next Appointment';
  break: Date;
  @Input() timelineEvent: IAppointment;

  descriptionVisible = false;
  
  constructor() {
  }

  ngOnInit() {
    this.date = this.timelineEvent.start;

    if (this.date > new Date()) {
      
      this.description = 'Next Appointment';

    } else if (this.timelineEvent.description){

      this.description = this.timelineEvent.description;

    } else {

      this.description = '';

    }
  }



}
