import { AppointmentService } from './../../services/appointment.service';
import { Component, ViewChild } from '@angular/core';
import dayGridPlugin from '@fullcalendar/daygrid';
import timeGrigPlugin from '@fullcalendar/timegrid';
import interactionPlugin from '@fullcalendar/interaction'; // for dateClick
import CalendarComponent from '@fullcalendar/core/CalendarComponent';
import { FullCalendarComponent } from '@fullcalendar/angular';
import { IAppointment } from 'src/app/models';


@Component({
  selector: 'app-appointments',
  templateUrl: './appointments.component.html',
  styleUrls: ['./appointments.component.scss']
})
export class AppointmentsComponent{

  constructor(private appointmentService: AppointmentService){
    this.calendarEvents = this.appointmentService.getAppointmentsDemo();
  }

  calendarTitle;

  calendarEvents: IAppointment[];

  @ViewChild('calendar') calendarComponent: FullCalendarComponent;

  getCalendarTitle(){
    let calendarApi = this.calendarComponent.getApi();
    //Using this API I can recreate the design using Bulma

    this.calendarTitle = calendarApi.view.title;
  }

  //The plugins can be added if we want more calendar functionality
  calendarPlugins = [dayGridPlugin,      //For normal Day Grid Calendar View
                     timeGrigPlugin, 
                     interactionPlugin
                    ];


  handleDateClick(event){
    alert("You have "+event.event.title+" on "+ event.event.start);
  }

 /*addEvent() {
    this.calendarEvents = this.calendarEvents.concat({ // creates a new array!
      { title: 'Event 3', date: '2019-04-02' }
    });
  }*/

}
