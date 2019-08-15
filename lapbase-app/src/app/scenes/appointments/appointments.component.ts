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

  calendarTitle;
  calendarEvents: IAppointment[];

  eventClicked = false;
  eventTitle = "Empty Event";
  eventDescription = "Empty Description";

  constructor(private appointmentService: AppointmentService){
    //this.calendarEvents = this.appointmentService.getAppointmentsDemo();
    this.appointmentService.getAppointments().then(result => this.calendarEvents = result);
    //this.appointmentService.getAppointment(2756).then(result => this.calendarEvents = result);
    //console.log(this.calendarEvents);
  }

  @ViewChild('calendar') calendarComponent: FullCalendarComponent;

  getCalendarTitle(){

    let calendarApi = this.calendarComponent.getApi();
    //Using this API I can recreate the design using Bulma

    if(calendarApi) return calendarApi.view.title;
    else return "";
  }

  //The plugins can be added if we want more calendar functionality
  calendarPlugins = [dayGridPlugin,      //For normal Day Grid Calendar View
                     timeGrigPlugin, 
                     interactionPlugin
                    ];


  handleDateClick(event){
    this.eventClicked = true;
    this.eventTitle = event.event.title;
    this.eventDescription = "You have "+event.event.title+" on "+ event.event.start.toDateString()+ 
                            "\n From "+ event.event.start.toLocaleTimeString() + 
                            " to " + event.event.end.toLocaleTimeString();
  }

 /*addEvent() {
    this.calendarEvents = this.calendarEvents.concat({ // creates a new array!
      { title: 'Event 3', date: '2019-04-02' }
    });
  }*/

}
