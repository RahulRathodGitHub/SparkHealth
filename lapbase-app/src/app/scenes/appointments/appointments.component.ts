import { Component } from '@angular/core';
import dayGridPlugin from '@fullcalendar/daygrid';
import timeGrigPlugin from '@fullcalendar/timegrid';
import interactionPlugin from '@fullcalendar/interaction'; // for dateClick

@Component({
  selector: 'app-appointments',
  templateUrl: './appointments.component.html',
  styleUrls: ['./appointments.component.scss']
})
export class AppointmentsComponent{

  //The plugins can be added if we want more calendar functionality
  calendarPlugins = [dayGridPlugin,      //For normal Day Grid Calendar View
                     timeGrigPlugin, 
                     interactionPlugin
                    ];

  calendarEvents = [
    {title: 'Event 1', date: '2019-08-01'},
    {title: 'Event 2', date: '2019-08-02'}
  ];

  handleDateClick(event){
    alert("You have an appointment on "+ event.event.start);
  }

 /*addEvent() {
    this.calendarEvents = this.calendarEvents.concat({ // creates a new array!
      { title: 'Event 3', date: '2019-04-02' }
    });
  }*/

}
