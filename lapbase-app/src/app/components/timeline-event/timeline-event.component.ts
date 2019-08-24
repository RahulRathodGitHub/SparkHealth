import { Component, OnInit, Input } from '@angular/core';
import { AppointmentService } from './../../services/appointment.service';
import { IAppointment } from 'src/app/models';

@Component({
  selector: 'app-timeline-event',
  templateUrl: './timeline-event.component.html',
  styleUrls: ['./timeline-event.component.scss']
})
export class TimelineEventComponent implements OnInit {

  @Input() date: string;
  @Input() description: string = 'Next Appointment';

  descriptionVisible = false;
  

  ngOnInit() {
  }



}
