import { Component, OnInit } from "@angular/core";
import { AuthService } from "src/app/auth/auth.service";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.scss"]
})
export class LoginComponent implements OnInit {
  public screenWidth;
  constructor(private authService: AuthService) {}

  ngOnInit() {
    this.screenWidth = window.innerWidth;
    console.log(this.screenWidth);
  }

  onSubmit() {
    this.authService.login();
  }
}
