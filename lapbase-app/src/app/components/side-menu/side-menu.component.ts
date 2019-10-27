import { Component, OnInit, Input } from '@angular/core';
import { MsalService } from '@azure/msal-angular';

@Component({
  selector: 'app-side-menu',
  templateUrl: './side-menu.component.html',
  styleUrls: ['./side-menu.component.scss']
})
export class SideMenuComponent implements OnInit {
  @Input() loggedIn: boolean;
  isActive = true;

  generalRoutes = [
    { linkName: 'Dashboard', url: '/dashboard', icon: 'fas fa-columns fa-lg' },
    { linkName: 'Tasks', url: '/tasks', icon: 'fas fa-tasks fa-lg' },
    { linkName: 'Reports', url: '/reports', icon: 'fas fa-chart-area fa-lg' },
    { linkName: 'Appointments', url: '/appointments', icon: 'fas fa-calendar-alt fa-lg' },
  ];

  managementRoutes = [
    { linkName: 'Account', url: '/account', icon: 'fas fa-user fa-lg'},
  ];

  constructor(private authService: MsalService) {  }

  ngOnInit() {
  }

  toggleNavbar(){
    this.isActive = !this.isActive;
  }
  login = () => this.authService.loginRedirect();

  logout = () => this.authService.logout();
}
