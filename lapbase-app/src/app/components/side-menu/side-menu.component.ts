import { Component, OnInit, Input } from '@angular/core';
import { MsalService } from '@azure/msal-angular';

@Component({
  selector: 'app-side-menu',
  templateUrl: './side-menu.component.html',
  styleUrls: ['./side-menu.component.scss']
})
export class SideMenuComponent implements OnInit {
  @Input() loggedIn: boolean;

  generalRoutes = [
    { linkName: 'Dashboard', url: '/dashboard', icon: 'fas fa-columns fa-lg' },
    { linkName: 'Tasks', url: '/tasks', icon: 'fas fa-tasks fa-lg' },
    { linkName: 'Reports', url: '/reports', icon: 'fas fa-chart-area fa-lg' },
    { linkName: 'Appointments', url: '/appointments', icon: 'fas fa-calendar-alt fa-lg' },
    { linkName: 'Timeline', url: '/timeline', icon: 'fas fa-stream fa-lg' },
  ];

  managementRoutes = [
    { linkName: 'Settings', url: '/account', icon: 'fas fa-cog fa-lg' },
    { linkName: 'Help', url: '/help', icon: 'fas fa-info-circle fa-lg' },
    { linkName: 'Feedback', url: '/feedback', icon: 'fas fa-star fa-lg' },
  ];

  constructor(private authService: MsalService) {  }

  ngOnInit() {
  }

  login = () => this.authService.loginRedirect();

  logout = () => this.authService.logout();
}
