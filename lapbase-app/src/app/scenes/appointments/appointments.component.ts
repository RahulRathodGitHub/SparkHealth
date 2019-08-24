import { AppointmentService } from './../../services/appointment.service';
import { Component, ViewChild } from '@angular/core';
import dayGridPlugin from '@fullcalendar/daygrid';
import timeGrigPlugin from '@fullcalendar/timegrid';
import interactionPlugin from '@fullcalendar/interaction'; // for dateClick
import { FullCalendarComponent } from '@fullcalendar/angular';
import { IAppointment } from 'src/app/models';


@Component({
  selector: 'app-appointments',
  templateUrl: './appointments.component.html',
  styleUrls: ['./appointments.component.scss']
})
export class AppointmentsComponent {

  calendarTitle;
  calendarEvents: IAppointment[];

  eventClicked = false;
  eventTitle = 'Empty Event';
  eventDescription = "Empty Description";
  eventDoctorName = '';
  eventLocation = '';
  eventTime = '';

  constructor(private appointmentService: AppointmentService) {
    // Currently the below mentioned variables are hardCoded
    const patientId = 107057612; // 107068092 -> Another good patient ID with a description.
    const organizationCode = 2;

    this.appointmentService.getAppointmentsById(patientId, organizationCode).then(result => this.calendarEvents = result);
  }

  @ViewChild('calendar') calendarComponent: FullCalendarComponent;

  // The plugins can be added if we want more calendar functionality
  calendarPlugins = [dayGridPlugin,      // For normal Day Grid Calendar View
    timeGrigPlugin,
    interactionPlugin
  ];


  handleDateClick(event) {
    this.eventClicked = true;
    this.eventTitle = event.event.title;
    this.eventDoctorName = event.event.extendedProps.doctorName;
    this.eventLocation = event.event.extendedProps.location;
    this.eventTime = event.event.start.toDateString();

    if (event.event) {
      if (event.event.extendedProps.description.length !== 0) {
          this.eventDescription = event.event.extendedProps.description;
        } else {
        this.eventDescription = '';
      }
    }
  }

}
