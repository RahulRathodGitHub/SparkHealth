import { AppointmentService } from './../../services/appointment.service';
import { Component, ViewChild, OnInit } from '@angular/core';
import dayGridPlugin from '@fullcalendar/daygrid';
import timeGrigPlugin from '@fullcalendar/timegrid';
import interactionPlugin from '@fullcalendar/interaction'; // for dateClick
import { FullCalendarComponent } from '@fullcalendar/angular';
import { IAppointment } from 'src/app/models';
import { asRoughYears } from '@fullcalendar/core/datelib/duration';
import CalendarComponent from '@fullcalendar/core/CalendarComponent';


@Component({
  selector: 'app-appointments',
  templateUrl: './appointments.component.html',
  styleUrls: ['./appointments.component.scss']
})
export class AppointmentsComponent{

  options: any;
  calendarTitle;
  calendarEvents: IAppointment[];



  eventClicked = false;
  eventTitle = 'Empty Event';
  eventDescription = '';
  eventDoctorName = '';
  eventLocation = '';
  eventTime = '';
  eventBmi = 0;
  eventWeight = 0;
  

  constructor(private appointmentService: AppointmentService) {
    const organizationCode = 2;
    const patientId = 2756; //Ricky Perez
    //107057612;
    // this.calendarEvents = this.appointmentService.getAppointmentsDemo();
    // this.appointmentService.getAppointments().then(result => this.calendarEvents = result);
    this.appointmentService.getAppointmentsById(patientId, organizationCode).then(result => this.calendarEvents = result);
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
    this.eventBmi = event.event.extendedProps.bmi;
    this.eventWeight = event.event.extendedProps.weight;

    if (event.event) {
      if (event.event.extendedProps.description.length !== 0) {
          this.eventDescription = event.event.extendedProps.description;
        } else {
        this.eventDescription = '';
      }
    }
  }

  

}
