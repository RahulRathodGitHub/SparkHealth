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

  constructor(private service: AppointmentService) {
    const patientId = 107057612;
    const organizationCode = 2;
    this.service.getAppointmentsById(patientId,organizationCode).then(result => this.timelineEvents = result);
  }

  ngOnInit() {
  }

}
