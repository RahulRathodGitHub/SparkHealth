import { TimelineEventComponent } from '../../components/timeline-event/timeline-event.component';
import { Component, OnInit, Input } from '@angular/core';
import { AppointmentService } from './../../services/appointment.service';
import { IAppointment } from 'src/app/models';


@Component({
  selector: 'app-timeline',
  templateUrl: './timeline.component.html',
  styleUrls: ['./timeline.component.scss']
})
export class TimelineComponent implements OnInit {

  @Input() timelineEvents: IAppointment[];

  description:string = 'Next Appointment';
  start: Date = new Date('1900-01-01T00:00:00');
  

  constructor(private service: AppointmentService) {
    const patientId = 107057612;
    this.service.getAppointmentsById(patientId).then(result => this.timelineEvents = result);
  }

  ngOnInit() {
  }

}
