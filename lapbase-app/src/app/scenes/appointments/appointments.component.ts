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
  eventDescription = '';
  eventDoctorName = '';
  eventLocation = '';
  eventTime = '';

  constructor(private appointmentService: AppointmentService) {
    // this.calendarEvents = this.appointmentService.getAppointmentsDemo();
    // this.appointmentService.getAppointments().then(result => this.calendarEvents = result);
    this.appointmentService.getAppointmentsById(107057612).then(result => this.calendarEvents = result);
    // 107068092 -> Another good patient ID with a description.
    // The description is provided in the notes part of the DB; especially deleted by wayne
    // console.log(this.calendarEvents);
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
